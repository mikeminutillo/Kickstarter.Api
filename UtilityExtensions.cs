using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kickstarter.Api
{
    internal static class UtilityExtensions
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static Task<T> ParsedAsJson<T>(this string json)
        {
            var settings = new JsonSerializerSettings
            {
                Converters = new JsonConverter[] {  new KickstarterDateTimeConverter() }
            };

            return JsonConvert.DeserializeObjectAsync<T>(json, settings);
        }
    }
}