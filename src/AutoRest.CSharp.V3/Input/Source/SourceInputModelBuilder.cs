// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Azure.Core;
using Microsoft.CodeAnalysis;

namespace AutoRest.CSharp.V3.Input.Source
{
    public class SourceInputModelBuilder
    {
        private readonly Compilation _compilation;
        private readonly INamedTypeSymbol _schemaNameAttribute;

        private SourceInputModelBuilder(Compilation compilation)
        {
            _compilation = compilation;
            _schemaNameAttribute = compilation.GetTypeByMetadataName(typeof(CodeGenSchemaAttribute).FullName);
        }

        public static SourceInputModel Build(Compilation compilation)
        {
            return new SourceInputModelBuilder(compilation).BuildInternal();
        }

        private SourceInputModel BuildInternal()
        {
            var assembly = _compilation.Assembly;

            var definedSchemas = new List<SourceTypeMapping>();

            foreach (IModuleSymbol module in assembly.Modules)
            {
                foreach (var type in GetSymbols(module.GlobalNamespace))
                {
                    if (type is INamedTypeSymbol namedTypeSymbol)
                    {
                        if (TryGetSchemaName(type, out var schemaName))
                        {
                            definedSchemas.Add(new SourceTypeMapping(schemaName, namedTypeSymbol));
                        }
                    }
                }
            }

            return new SourceInputModel(definedSchemas.ToArray());
        }

        private bool TryGetSchemaName(ITypeSymbol type, [NotNullWhen(true)] out string? name)
        {
            name = null;
#pragma warning disable RS1024
            var attribute = type.GetAttributes().SingleOrDefault(a => a.AttributeClass.Equals(_schemaNameAttribute));
#pragma warning restore
            if (attribute == null)
            {
                return false;
            }

            name = attribute.ConstructorArguments[0].Value as string;
            return name != null;
        }

        private IEnumerable<ITypeSymbol> GetSymbols(INamespaceSymbol namespaceSymbol)
        {
            foreach (var childNamespaceSymbol in namespaceSymbol.GetNamespaceMembers())
            {
                foreach (var symbol in GetSymbols(childNamespaceSymbol))
                {
                    yield return symbol;
                }
            }

            foreach (INamedTypeSymbol symbol in namespaceSymbol.GetTypeMembers())
            {
                yield return symbol;
            }
        }
    }
}
