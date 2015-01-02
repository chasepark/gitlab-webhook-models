using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gitlab.Models.Objects
{
    public class MergeRequestAttributes
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("target_branch")]
        public string TargetBranch { get; set; }

        [JsonProperty("source_branch")]
        public string SourceBranch { get; set; }

        [JsonProperty("source_project_id")]
        public int? SourceProjectId { get; set; }

        [JsonProperty("author_id")]
        public int? AuthorId { get; set; }

        [JsonProperty("assignee_id")]
        public int? AssigneeId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt{get; set;}

        [JsonProperty("st_commits")]
        public int? StCommits { get; set; }

        [JsonProperty("st_diffs")]
        public int? StDiffs { get; set; }

        [JsonProperty("milestone_id")]
        public int? MilestoneId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("merge_status")]
        public string MergeStatus { get; set; }

        [JsonProperty("target_project_id")]
        public int? TargetProjectId { get; set; }

        [JsonProperty("iid")]
        public int? IId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public MergeTarget Source { get; set; }

        [JsonProperty("target")]
        public MergeTarget Target { get; set; }

        [JsonProperty("last_commit")]
        public Commit LastCommit { get; set; }

    }
}
