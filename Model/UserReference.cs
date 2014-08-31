using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class UserReference : HypermediaItem
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        [DataMember(Name = "avatar")]
        public IDictionary<string, string> Avatar { get; set; }

    }
}