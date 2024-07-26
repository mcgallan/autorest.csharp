// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Model.Visibility.Models;

namespace _Type.Model.Visibility.Samples
{
    public partial class Samples_VisibilityClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_GetModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.GetModel(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("readProp").ToString());
            Console.WriteLine(result.GetProperty("queryProp").ToString());
            Console.WriteLine(result.GetProperty("createProp")[0].ToString());
            Console.WriteLine(result.GetProperty("updateProp")[0].ToString());
            Console.WriteLine(result.GetProperty("deleteProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_GetModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.GetModelAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("readProp").ToString());
            Console.WriteLine(result.GetProperty("queryProp").ToString());
            Console.WriteLine(result.GetProperty("createProp")[0].ToString());
            Console.WriteLine(result.GetProperty("updateProp")[0].ToString());
            Console.WriteLine(result.GetProperty("deleteProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_GetModel_ShortVersion_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response<VisibilityModel> response = client.GetModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_GetModel_ShortVersion_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response<VisibilityModel> response = await client.GetModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_GetModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.GetModel(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("readProp").ToString());
            Console.WriteLine(result.GetProperty("queryProp").ToString());
            Console.WriteLine(result.GetProperty("createProp")[0].ToString());
            Console.WriteLine(result.GetProperty("updateProp")[0].ToString());
            Console.WriteLine(result.GetProperty("deleteProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_GetModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.GetModelAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("readProp").ToString());
            Console.WriteLine(result.GetProperty("queryProp").ToString());
            Console.WriteLine(result.GetProperty("createProp")[0].ToString());
            Console.WriteLine(result.GetProperty("updateProp")[0].ToString());
            Console.WriteLine(result.GetProperty("deleteProp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_GetModel_AllParameters_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response<VisibilityModel> response = client.GetModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_GetModel_AllParameters_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response<VisibilityModel> response = await client.GetModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_HeadModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.HeadModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_HeadModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.HeadModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_HeadModel_ShortVersion_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.HeadModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_HeadModel_ShortVersion_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.HeadModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_HeadModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.HeadModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_HeadModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.HeadModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_HeadModel_AllParameters_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.HeadModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_HeadModel_AllParameters_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.HeadModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.PutModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.PutModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutModel_ShortVersion_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.PutModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutModel_ShortVersion_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.PutModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.PutModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.PutModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutModel_AllParameters_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.PutModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutModel_AllParameters_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.PutModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PatchModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.PatchModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PatchModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.PatchModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PatchModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.PatchModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PatchModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.PatchModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PostModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.PostModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PostModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.PostModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PostModel_ShortVersion_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.PostModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PostModel_ShortVersion_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.PostModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PostModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.PostModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PostModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.PostModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PostModel_AllParameters_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.PostModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PostModel_AllParameters_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.PostModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_DeleteModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.DeleteModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_DeleteModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.DeleteModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_DeleteModel_ShortVersion_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.DeleteModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_DeleteModel_ShortVersion_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.DeleteModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_DeleteModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = client.DeleteModel(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_DeleteModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new
            {
                queryProp = 1234,
                createProp = new object[]
            {
"<createProp>"
            },
                updateProp = new object[]
            {
1234
            },
                deleteProp = true,
            });
            Response response = await client.DeleteModelAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_DeleteModel_AllParameters_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = client.DeleteModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_DeleteModel_AllParameters_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            VisibilityModel input = new VisibilityModel(1234, new string[] { "<createProp>" }, new int[] { 1234 }, true);
            Response response = await client.DeleteModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutReadOnlyModel_ShortVersion()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutReadOnlyModel(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutReadOnlyModel_ShortVersion_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutReadOnlyModelAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutReadOnlyModel_ShortVersion_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            ReadOnlyModel input = new ReadOnlyModel();
            Response<ReadOnlyModel> response = client.PutReadOnlyModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutReadOnlyModel_ShortVersion_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            ReadOnlyModel input = new ReadOnlyModel();
            Response<ReadOnlyModel> response = await client.PutReadOnlyModelAsync(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutReadOnlyModel_AllParameters()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.PutReadOnlyModel(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("optionalNullableIntList")[0].ToString());
            Console.WriteLine(result.GetProperty("optionalStringRecord").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutReadOnlyModel_AllParameters_Async()
        {
            VisibilityClient client = new VisibilityClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.PutReadOnlyModelAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("optionalNullableIntList")[0].ToString());
            Console.WriteLine(result.GetProperty("optionalStringRecord").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Visibility_PutReadOnlyModel_AllParameters_Convenience()
        {
            VisibilityClient client = new VisibilityClient();

            ReadOnlyModel input = new ReadOnlyModel();
            Response<ReadOnlyModel> response = client.PutReadOnlyModel(input);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Visibility_PutReadOnlyModel_AllParameters_Convenience_Async()
        {
            VisibilityClient client = new VisibilityClient();

            ReadOnlyModel input = new ReadOnlyModel();
            Response<ReadOnlyModel> response = await client.PutReadOnlyModelAsync(input);
        }
    }
}