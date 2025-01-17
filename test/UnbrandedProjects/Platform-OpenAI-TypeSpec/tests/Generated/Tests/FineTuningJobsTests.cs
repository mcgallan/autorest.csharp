// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using NUnit.Framework;

namespace OpenAI.Tests
{
    public partial class FineTuningJobsTests
    {
        [Test]
        public void SmokeTest()
        {
            KeyCredential credential = new KeyCredential(Environment.GetEnvironmentVariable("OpenAIClient_KEY"));
            FineTuningJobs client = new OpenAIClient(credential).GetFineTuningClient().GetFineTuningJobsClient();
            Assert.IsNotNull(client);
        }
    }
}
