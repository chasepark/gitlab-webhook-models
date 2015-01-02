using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitlab.Models.Objects
{
    [JsonObject]
    public class IssueAttributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("assignee_id")]
        public int AssigneeId { get; set; }
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }
        [JsonProperty("project_id")]
        public int ProjectId { get; set; }
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
        [JsonProperty("position")]
        public int Position { get; set; }
        [JsonProperty("branch_name")]
        public string BranchName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("milestone_id")]
        public int? MilestoneId { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("iid")]
        public int Iid { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
    }
}
