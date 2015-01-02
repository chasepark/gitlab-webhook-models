﻿using Gitlab.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab.Tests.Models
{
    [TestFixture]
    public class MergeRequestEventTests
    {
        public string SampleMergeRequest()
        {
            return @"
            {
              ""object_kind"": ""merge_request"",
              ""user"": {
                ""name"": ""Administrator"",
                ""username"": ""root"",
                ""avatar_url"": ""http://www.gravatar.com/avatar/e64c7d89f26bd1972efa854d13d7dd61?s=40\u0026d=identicon""
              },
              ""object_attributes"": {
                ""id"": 99,
                ""target_branch"": ""master"",
                ""source_branch"": ""ms-viewport"",
                ""source_project_id"": 14,
                ""author_id"": 51,
                ""assignee_id"": 6,
                ""title"": ""MS-Viewport"",
                ""created_at"": ""2013-12-03T17:23:34Z"",
                ""updated_at"": ""2013-12-03T17:23:34Z"",
                ""st_commits"": null,
                ""st_diffs"": null,
                ""milestone_id"": null,
                ""state"": ""opened"",
                ""merge_status"": ""unchecked"",
                ""target_project_id"": 14,
                ""iid"": 1,
                ""description"": """",
                ""source"": {
                  ""name"": ""awesome_project_updates"",
                  ""ssh_url"": ""ssh://git@example.com/awesome_space/awesome_project.git"",
                  ""http_url"": ""http://example.com/awesome_space/awesome_project.git"",
                  ""visibility_level"": 20,
                  ""namespace"": ""awesome_space""
                },
                ""target"": {
                  ""name"": ""awesome_project"",
                  ""ssh_url"": ""ssh://git@example.com/awesome_space/awesome_project.git"",
                  ""http_url"": ""http://example.com/awesome_space/awesome_project.git"",
                  ""visibility_level"": 20,
                  ""namespace"": ""awesome_space""
                },
                ""last_commit"": {
                  ""id"": ""da1560886d4f094c3e6c9ef40349f7d38b5d27d7"",
                  ""message"": ""fixed readme"",
                  ""timestamp"": ""2012-01-03T23:36:29+02:00"",
                  ""url"": ""http://example.com/awesome_space/awesome_project/commits/da1560886d4f094c3e6c9ef40349f7d38b5d27d7"",
                  ""author"": {
                    ""name"": ""GitLab dev user"",
                    ""email"": ""gitlabdev@dv6700.(none)""
                  }
                }
              }
            }
            ";
        }


        [Test]
        public void Can_Deserialize_Into_MergeRequestEvent()
        {
            MergeRequestEvent e = JsonConvert.DeserializeObject<MergeRequestEvent>(SampleMergeRequest());
            e.ObjectKind.Should().Be("merge_request");
            e.User.Name.Should().Be("Administrator");
            e.ObjectAttributes.AssigneeId.Should().Be(6);
            e.ObjectAttributes.Source.Name.Should().Be("awesome_project_updates");
            e.ObjectAttributes.Target.Name.Should().Be("awesome_project");
            e.ObjectAttributes.LastCommit.Id.Should().Be("da1560886d4f094c3e6c9ef40349f7d38b5d27d7");

        }
    }
}
