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
    public class IssueEventTests
    {
        public string SampleIssueRequestBody()
        {
            return @"
            {
              ""object_kind"": ""issue"",
              ""user"": {
                ""name"": ""Administrator"",
                ""username"": ""root"",
                ""avatar_url"": ""http://www.gravatar.com/avatar/e64c7d89f26bd1972efa854d13d7dd61?s=40\u0026d=identicon""
              },
              ""object_attributes"": {
                ""id"": 301,
                ""title"": ""New API: create/update/delete file"",
                ""assignee_id"": 51,
                ""author_id"": 51,
                ""project_id"": 14,
                ""created_at"": ""2013-12-03T17:15:43Z"",
                ""updated_at"": ""2013-12-03T17:15:43Z"",
                ""position"": 0,
                ""branch_name"": null,
                ""description"": ""Create new API for manipulations with repository"",
                ""milestone_id"": null,
                ""state"": ""opened"",
                ""iid"": 23,
                ""url"": ""http://example.com/diaspora/issues/23"",
                ""action"": ""open""
              }
            }
            ";
        }

        [Test]
        public void Can_Deserialize_Body_Into_IssueEvent(){
            IssueEvent issueEvent = JsonConvert.DeserializeObject<IssueEvent>(SampleIssueRequestBody());
            issueEvent.ObjectKind.Should().Be("issue");
            issueEvent.Attributes.Action.Should().Be("open");
        }
    }
}
