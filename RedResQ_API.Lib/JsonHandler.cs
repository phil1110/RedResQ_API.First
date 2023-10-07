using System;
using Newtonsoft.Json;

namespace RedResQ_API.Lib
{
    public static class JsonHandler
    {
        public static string SerializeObject(object toConvert)
        {
            return JsonConvert.SerializeObject(toConvert);
        }

        public static T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}