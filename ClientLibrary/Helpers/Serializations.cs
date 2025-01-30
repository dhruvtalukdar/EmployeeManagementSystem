using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ClientLibrary.Helpers
{
    public static class Serializations
    {
        public static string SerializeObj<T>(T modelObject) => JsonSerializer.Serialize(modelObject);
        public static T DeserializeJsonString<T>(string jsonString)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (JsonException ex)
            {
                throw new ArgumentException("Invalid JSON format", ex);
            }
        }

        public static IList<T> DeserializeJsonStringList<T>(string jsonString)
        {
            try
            {
                return JsonSerializer.Deserialize<IList<T>>(jsonString);
            }
            catch (JsonException ex)
            {
                throw new ArgumentException("Invalid JSON format", ex);
            }
        }
            
    }
}
