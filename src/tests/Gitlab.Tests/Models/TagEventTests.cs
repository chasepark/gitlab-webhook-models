using Gitlab.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Gitlab.Tests.Models
{
    [TestFixture]
    public class TagEventTests
    {
        public string SampleTagEventBody()
        {
            return @"
            {
              ""ref"": ""refs/tags/v1.0.0"",
              ""before"": ""0000000000000000000000000000000000000000"",
              ""after"": ""82b3d5ae55f7080f1e6022629cdb57bfae7cccc7"",
              ""user_id"": 1,
              ""user_name"": ""John Smith"",
              ""project_id"": 1,
              ""repository"": {
                ""name"": ""jsmith"",
                ""url"": ""ssh://git@example.com/jsmith/example.git"",
                ""description"": """",
                ""homepage"": ""http://example.com/jsmith/example""
              }
             }
            ";
        }


        [Test]
        public void Can_Deserialize_Tag_Event()
        {
            TagEvent tagEvent = JsonConvert.DeserializeObject<TagEvent>(SampleTagEventBody());
            tagEvent.ProjectId.Should().Be(1);
            tagEvent.After.Should().Be("82b3d5ae55f7080f1e6022629cdb57bfae7cccc7");
            tagEvent.Repository.Name.Should().Be("jsmith");

        }
    }
}
