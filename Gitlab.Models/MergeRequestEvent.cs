using Gitlab.Models.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab.Models
{
    public class MergeRequestEvent
    {
        [JsonProperty("object_kind")]
        public String ObjectKind { get; set; }

        [JsonProperty("user")]
        public GitlabUser User { get; set; }

        [JsonProperty("object_attributes")]
        public MergeRequestAttributes ObjectAttributes { get; set; }
    }
}
