using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class Location
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "short_name")]
        public string ShortName { get; set; }

        [DataMember(Name = "displayable_name")]
        public string DisplayableName { get; set; }
    }
}