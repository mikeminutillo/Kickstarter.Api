using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class Category : HypermediaItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "position")]
        public int Position { get; set; }

        [DataMember(Name = "projects_count")]
        public int ProjectsCount { get; set; }

        [DataMember(Name = "parent_id")]
        public string ParentId { get; set; }

        [DataMember(Name = "parent")]
        public CategoryReference Parent { get; set; }
    }
}