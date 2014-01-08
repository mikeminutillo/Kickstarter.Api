using System;
using Newtonsoft.Json;

namespace Kickstarter.Api
{
    internal class KickstarterDateTimeConverter : JsonConverter
    {
        private static DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long seconds;
            if (long.TryParse(String.Format("{0}", reader.Value), out seconds))
            {
                return _epoch.AddSeconds(seconds).ToLocalTime();
            }
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof (DateTime).IsAssignableFrom(objectType)
                   || typeof (DateTime?).IsAssignableFrom(objectType);
        }
    }
}