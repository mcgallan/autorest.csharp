﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives.Pipeline;
using System.Collections.Generic;
using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Common.Output.Models;
using AutoRest.CSharp.Output.Models.Types.System;

namespace AutoRest.CSharp.Common.Output.Expressions.KnownValueExpressions.System
{
    internal sealed record MessagePipelineExpression(ValueExpression Untyped) : TypedValueExpression<MessagePipeline>(Untyped)
    {
        public PipelineMessageExpression CreateMessage(RequestOptionsExpression requestContext, ValueExpression responseClassifier) => new(Invoke(nameof(MessagePipeline.CreateMessage), requestContext, responseClassifier));
        public PipelineResponseExpression ProcessMessage(TypedValueExpression message, RequestOptionsExpression? requestContext, CancellationTokenExpression? cancellationToken, bool async)
        {
            var arguments = new List<ValueExpression>
            {
                Untyped,
                message,
                requestContext ?? Snippets.Null
            };

            if (cancellationToken != null)
            {
                arguments.Add(cancellationToken);
            }

            return ClientPipelineExtensionsProvider.Instance.ProcessMessage(arguments, async);
        }

        public ResultExpression ProcessHeadAsBoolMessage(TypedValueExpression message, RequestOptionsExpression? requestContext, bool async)
        {
            var arguments = new List<ValueExpression>
            {
                Untyped,
                message,
                requestContext ?? Snippets.Null
            };

            return ClientPipelineExtensionsProvider.Instance.ProcessHeadAsBoolMessage(arguments, async);
        }
    }
}
