using Newtonsoft.Json;

namespace HybridNTierECommerce.MVCUI.Models.SessionService
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key,objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string objectString = session.GetString(key);
            if (!string.IsNullOrEmpty(objectString))
            {
                T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
                return deserializedObject;
            }
            return null;
        }
    }
}
