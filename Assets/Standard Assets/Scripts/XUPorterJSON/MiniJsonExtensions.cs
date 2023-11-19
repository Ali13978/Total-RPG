using UnityEngine;

namespace XUPorterJSON
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class MiniJsonExtensions
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static string toJson(System.Collections.Hashtable obj)
        {
            return XUPorterJSON.MiniJSON.jsonEncode(json:  null);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static string toJson(System.Collections.Generic.Dictionary<string, string> obj)
        {
            return XUPorterJSON.MiniJSON.jsonEncode(json:  null);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static System.Collections.ArrayList arrayListFromJson(string json)
        {
            var val_3;
            object val_1 = XUPorterJSON.MiniJSON.jsonDecode(json:  null);
            val_3 = 0;
            return (System.Collections.ArrayList);
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static System.Collections.Hashtable hashtableFromJson(string json)
        {
            var val_3;
            object val_1 = XUPorterJSON.MiniJSON.jsonDecode(json:  null);
            val_3 = 0;
            return (System.Collections.Hashtable);
        }
    
    }

}
