// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using Payload.MultiPart.Models;

namespace Payload.MultiPart.Samples
{
    public partial class Samples_FormData
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_Basic_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.Basic(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_Basic_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.BasicAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_Basic_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = client.Basic(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_Basic_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = await client.BasicAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_Basic_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.Basic(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_Basic_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.BasicAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_Basic_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = client.Basic(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_Basic_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = await client.BasicAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_FileArrayAndBasic_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = client.FileArrayAndBasic(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_FileArrayAndBasic_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = await client.FileArrayAndBasicAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_FileArrayAndBasic_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            ComplexPartsRequest body = new ComplexPartsRequest("<id>", new Address("<city>"), null, new Stream[] { null });
            Response response = client.FileArrayAndBasic(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_FileArrayAndBasic_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            ComplexPartsRequest body = new ComplexPartsRequest("<id>", new Address("<city>"), null, new Stream[] { null });
            Response response = await client.FileArrayAndBasicAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_FileArrayAndBasic_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = client.FileArrayAndBasic(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_FileArrayAndBasic_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = await client.FileArrayAndBasicAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_FileArrayAndBasic_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            ComplexPartsRequest body = new ComplexPartsRequest("<id>", new Address("<city>"), null, new Stream[] { null });
            Response response = client.FileArrayAndBasic(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_FileArrayAndBasic_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            ComplexPartsRequest body = new ComplexPartsRequest("<id>", new Address("<city>"), null, new Stream[] { null });
            Response response = await client.FileArrayAndBasicAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_JsonPart_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.JsonPart(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_JsonPart_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.JsonPartAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_JsonPart_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            JsonPartRequest body = new JsonPartRequest(new Address("<city>"), null);
            Response response = client.JsonPart(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_JsonPart_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            JsonPartRequest body = new JsonPartRequest(new Address("<city>"), null);
            Response response = await client.JsonPartAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_JsonPart_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.JsonPart(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_JsonPart_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                address = new
                {
                    city = "<city>",
                },
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.JsonPartAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_JsonPart_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            JsonPartRequest body = new JsonPartRequest(new Address("<city>"), null);
            Response response = client.JsonPart(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_JsonPart_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            JsonPartRequest body = new JsonPartRequest(new Address("<city>"), null);
            Response response = await client.JsonPartAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_BinaryArrayParts_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = client.BinaryArrayParts(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_BinaryArrayParts_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = await client.BinaryArrayPartsAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_BinaryArrayParts_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            BinaryArrayPartsRequest body = new BinaryArrayPartsRequest("<id>", new Stream[] { null });
            Response response = client.BinaryArrayParts(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_BinaryArrayParts_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            BinaryArrayPartsRequest body = new BinaryArrayPartsRequest("<id>", new Stream[] { null });
            Response response = await client.BinaryArrayPartsAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_BinaryArrayParts_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = client.BinaryArrayParts(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_BinaryArrayParts_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                pictures = new object[]
            {
System.IO.File.OpenRead("<filePath>")
            },
            });
            Response response = await client.BinaryArrayPartsAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_BinaryArrayParts_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            BinaryArrayPartsRequest body = new BinaryArrayPartsRequest("<id>", new Stream[] { null });
            Response response = client.BinaryArrayParts(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_BinaryArrayParts_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            BinaryArrayPartsRequest body = new BinaryArrayPartsRequest("<id>", new Stream[] { null });
            Response response = await client.BinaryArrayPartsAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_MultiBinaryParts_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.MultiBinaryParts(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_MultiBinaryParts_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.MultiBinaryPartsAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_MultiBinaryParts_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiBinaryPartsRequest body = new MultiBinaryPartsRequest(null);
            Response response = client.MultiBinaryParts(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_MultiBinaryParts_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiBinaryPartsRequest body = new MultiBinaryPartsRequest(null);
            Response response = await client.MultiBinaryPartsAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_MultiBinaryParts_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
                picture = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.MultiBinaryParts(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_MultiBinaryParts_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
                picture = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.MultiBinaryPartsAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_MultiBinaryParts_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiBinaryPartsRequest body = new MultiBinaryPartsRequest(null)
            {
                Picture = null,
            };
            Response response = client.MultiBinaryParts(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_MultiBinaryParts_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiBinaryPartsRequest body = new MultiBinaryPartsRequest(null)
            {
                Picture = null,
            };
            Response response = await client.MultiBinaryPartsAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_CheckFileNameAndContentType_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.CheckFileNameAndContentType(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_CheckFileNameAndContentType_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.CheckFileNameAndContentTypeAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_CheckFileNameAndContentType_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = client.CheckFileNameAndContentType(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_CheckFileNameAndContentType_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = await client.CheckFileNameAndContentTypeAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_CheckFileNameAndContentType_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.CheckFileNameAndContentType(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_CheckFileNameAndContentType_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                id = "<id>",
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.CheckFileNameAndContentTypeAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_CheckFileNameAndContentType_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = client.CheckFileNameAndContentType(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_CheckFileNameAndContentType_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            MultiPartRequest body = new MultiPartRequest("<id>", null);
            Response response = await client.CheckFileNameAndContentTypeAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_AnonymousModel_ShortVersion()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.AnonymousModel(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_AnonymousModel_ShortVersion_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.AnonymousModelAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_AnonymousModel_ShortVersion_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            Response response = client.AnonymousModel(null);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_AnonymousModel_ShortVersion_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            Response response = await client.AnonymousModelAsync(null);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_AnonymousModel_AllParameters()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = client.AnonymousModel(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_AnonymousModel_AllParameters_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            using RequestContent content = RequestContent.Create(new
            {
                profileImage = System.IO.File.OpenRead("<filePath>"),
            });
            Response response = await client.AnonymousModelAsync(content, "multipart/form-data");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FormData_AnonymousModel_AllParameters_Convenience()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            Response response = client.AnonymousModel(null);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FormData_AnonymousModel_AllParameters_Convenience_Async()
        {
            FormData client = new MultiPartClient().GetFormDataClient();

            Response response = await client.AnonymousModelAsync(null);
        }
    }
}
