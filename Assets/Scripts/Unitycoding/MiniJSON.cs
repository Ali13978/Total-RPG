using UnityEngine;

namespace Unitycoding
{
    public static class MiniJSON
    {
        // Methods
        public static object Deserialize(string json)
        {
            if(X1 == 0)
            {
                    return 0;
            }
            
            return MiniJSON.Parser.Parse(jsonString:  json);
        }
        public static string Serialize(object obj)
        {
            return MiniJSON.Serializer.Serialize(obj:  obj);
        }
    
    }

}
