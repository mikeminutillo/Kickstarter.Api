using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    public class CategoryList : HypermediaItem
    {
        [DataMember(Name = "categories")]
        public Category[] Categories { get; set; }

    }
}