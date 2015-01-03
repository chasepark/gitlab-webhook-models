using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab.Models.Objects
{
    [JsonObject]
    public class GitlabUser
    {
        [JsonProperty("name")]
        public string Name { get; set;}

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}
