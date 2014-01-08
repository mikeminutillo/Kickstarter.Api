using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class User : HypermediaItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "avatar")]
        public Dictionary<string, string> Avatar { get; set; }

        [DataMember(Name = "location")]
        public Location Location { get; set; }

        [DataMember(Name = "biography")]
        public string Biography { get; set; }

        [DataMember(Name = "backed_projects_count")]
        public int BackedProjectsCount { get; set; }

        [DataMember(Name = "created_projects_count")]
        public int CreatedProjectsCount { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }
    }
}