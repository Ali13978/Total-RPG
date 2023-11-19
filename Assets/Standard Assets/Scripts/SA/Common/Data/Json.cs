using UnityEngine;

namespace SA.Common.Data
{
    public static class Json
    {
        // Methods
        public static object Deserialize(string json)
        {
            if(X1 == 0)
            {
                    return 0;
            }
            
            return Json.Parser.Parse(jsonString:  json);
        }
        public static string Serialize(object obj)
        {
            return Json.Serializer.Serialize(obj:  0);
        }
    
    }

}
