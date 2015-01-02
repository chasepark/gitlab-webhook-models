using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab.Models.Objects
{
    public class MergeTarget
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ssh_url")]
        public string SSHUrl { get; set; }

        [JsonProperty("visibility_level")]
        public int? VisibilityLevel { get; set; }

        [JsonProperty("http_url")]
        public string HttpUrl {get;set;}

        [JsonProperty("namespace")]
        public string Namespace { get; set; }
    }
}
