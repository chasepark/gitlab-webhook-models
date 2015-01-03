using Gitlab.Models.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab.Models
{
    public class TagEvent
    {
        [JsonProperty("ref")]
        public string Ref { get; set; }
        [JsonProperty("before")]
        public string Before { get; set; }
        [JsonProperty("after")]
        public string After { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("project_id")]
        public int ProjectId { get; set; }
        [JsonProperty("repository")]
        public Repository Repository { get; set; }
    }
}
