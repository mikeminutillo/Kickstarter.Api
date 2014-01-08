using System.Runtime.Serialization;

namespace Kickstarter.Api.Model
{
    [DataContract]
    class LogonResult
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "user")]
        public User User { get; set; }
    }
}
