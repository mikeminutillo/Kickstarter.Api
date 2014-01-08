using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class HypermediaItem : IHypermediaItem
    {
        [DataMember(Name = "urls")]
        public Urls Urls { get; set; }
    }
}