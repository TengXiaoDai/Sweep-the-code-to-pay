using Newtonsoft.Json;

namespace ProDemo.ConvertSettlement
{
    public class ConvertFactory
    {
        public static string SerializeObject<T>(T t)
        {
           return JsonConvert.SerializeObject(t);
        }
        public static T DeserializeObject<T>(string value)
        {
           return  JsonConvert.DeserializeObject<T>(value);
        }
    }
}
