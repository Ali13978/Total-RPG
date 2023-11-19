using UnityEngine;

namespace SA.Common.Util
{
    public class IdFactory
    {
        // Fields
        private const string PP_ID_KEY = "SA.Common.Util.IdFactory_Key";
        
        // Properties
        public static int NextId { get; }
        public static string RandomString { get; }
        
        // Methods
        public IdFactory()
        {
        
        }
        public static int get_NextId()
        {
            var val_4;
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != false)
            {
                    val_4 = (UnityEngine.PlayerPrefs.GetInt(key:  0)) + 1;
            }
            else
            {
                    val_4 = 1;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  0, value:  1598432384);
            return (int)val_4;
        }
        public static string get_RandomString()
        {
            typeof(IdFactory.<>c__AnonStorey0).__il2cppRuntimeField_10 = new System.Random();
            System.Func<System.String, System.Char> val_4 = new System.Func<System.String, System.Char>(object:  new System.Object(), method:  System.Char IdFactory.<>c__AnonStorey0::<>m__0(string s));
            System.Collections.Generic.IEnumerable<TResult> val_5 = System.Linq.Enumerable.Select<System.Object, System.Char>(source:  0, selector:  System.Linq.Enumerable.Repeat<System.String>(element:  0, count:  1598544512));
            return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  0));
        }
    
    }

}
