using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class ProjectsList : HypermediaItem
    {
        [DataMember(Name = "projects")]
        public Project[] Projects { get; set; }
    }
}