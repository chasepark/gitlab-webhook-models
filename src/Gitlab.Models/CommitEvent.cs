using Gitlab.Models.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Gitlab.Models
{
    //Example
//    {
//  "before": "95790bf891e76fee5e1747ab589903a6a1f80f22",
//  "after": "da1560886d4f094c3e6c9ef40349f7d38b5d27d7",
//  "ref": "refs/heads/master",
//  "user_id": 4,
//  "user_name": "John Smith",
//  "project_id": 15,
//  "repository": {
//    "name": "Diaspora",
//    "url": "git@example.com:diaspora.git",
//    "description": "",
//    "homepage": "http://example.com/diaspora"
//  },
//  "commits": [
//    {
//      "id": "b6568db1bc1dcd7f8b4d5a946b0b91f9dacd7327",
//      "message": "Update Catalan translation to e38cb41.",
//      "timestamp": "2011-12-12T14:27:31+02:00",
//      "url": "http://example.com/diaspora/commits/b6568db1bc1dcd7f8b4d5a946b0b91f9dacd7327",
//      "author": {
//        "name": "Jordi Mallach",
//        "email": "jordi@softcatala.org"
//      }
//    },
//    {
//      "id": "da1560886d4f094c3e6c9ef40349f7d38b5d27d7",
//      "message": "fixed readme",
//      "timestamp": "2012-01-03T23:36:29+02:00",
//      "url": "http://example.com/diaspora/commits/da1560886d4f094c3e6c9ef40349f7d38b5d27d7",
//      "author": {
//        "name": "GitLab dev user",
//        "email": "gitlabdev@dv6700.(none)"
//      }
//    }
//  ],
//  "total_commits_count": 4
//}
    public class CommitEvent
    {
        [JsonProperty("before")]
        public string Before { get; set; }
        [JsonProperty("after")]
        public string After { get; set; }
        [JsonProperty("ref")]
        public string Ref { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("user_name")]
        public string UserName{get;set;}
        [JsonProperty("project_id")]
        public int ProjectId { get; set; }
        [JsonProperty("total_commits_count")]
        public int TotalCommitCount { get; set; }
        [JsonProperty("repository")]
        public Repository Repository { get; set; }
        [JsonProperty("commits")]
        public Commit[] Commits { get; set; }


    }
}
