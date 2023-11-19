using UnityEngine;

namespace TzarGames.Common
{
    public class Configuration
    {
        // Fields
        private static bool initCompleted;
        private static TzarGames.Common.ConfigurationEntry entryHeadNode;
        
        // Methods
        public Configuration()
        {
        
        }
        private static TzarGames.Common.ConfigurationEntry initialize()
        {
            var val_11;
            var val_19;
            var val_20;
            string val_2 = 0 + UnityEngine.Application.dataPath;
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            val_19 = 0;
            goto label_3;
            label_13:
            val_19 = 1;
            label_3:
            if(val_19 >= val_3.Length)
            {
                goto label_5;
            }
            
            if((System.String.op_Equality(a:  0, b:  System.IO.Path.GetExtension(path:  0))) == false)
            {
                goto label_13;
            }
            
            Add(item:  System.IO.Directory.GetFiles(path:  0)[1]);
            goto label_13;
            label_5:
            if(Count == 0)
            {
                    return 0;
            }
            
            TzarGames.Common.ConfigurationEntry val_8 = new TzarGames.Common.ConfigurationEntry();
            List.Enumerator<T> val_9 = GetEnumerator();
            label_26:
            if((0 & 1) == 0)
            {
                goto label_32;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_12 = val_11.InitializationCallback;
            System.IO.StringReader val_14 = new System.IO.StringReader(s:  System.IO.File.ReadAllText(path:  0));
            Configuration.ConfigXmlHandler val_15 = new Configuration.ConfigXmlHandler();
            Mono.Xml.SmallXmlParser val_16 = new Mono.Xml.SmallXmlParser();
            Parse(input:  null, handler:  null);
            string val_17 = System.IO.Path.GetFileName(path:  0);
            Configuration.ConfigXmlHandler.__il2cppRuntimeField_10 = System.IO.Path.GetFileNameWithoutExtension(path:  0);
            TzarGames.Common.ConfigurationEntry.__il2cppRuntimeField_element_class.Add(item:  Configuration.ConfigXmlHandler.__il2cppRuntimeField_name);
            goto label_26;
            label_32:
            val_11.Dispose();
            val_20 = null;
            val_20 = null;
            TzarGames.Common.Configuration.initCompleted = true;
            return 0;
        }
        public static int GetInt(string section, string key)
        {
            string val_1 = TzarGames.Common.Configuration.GetString(section:  null, key:  key);
            return System.Int32.Parse(s:  0);
        }
        public static string GetString(string section, string key)
        {
            var val_4;
            var val_11;
            System.Collections.Generic.List<TzarGames.Common.ConfigurationEntry> val_12;
            var val_13;
            val_11 = null;
            val_11 = null;
            if(TzarGames.Common.Configuration.initCompleted != true)
            {
                    TzarGames.Common.Configuration.entryHeadNode = TzarGames.Common.Configuration.initialize();
                val_11 = null;
            }
            
            val_11 = null;
            val_12 = mem[val_1 + 48];
            val_12 = val_1.Entries;
            List.Enumerator<T> val_2 = val_12.GetEnumerator();
            label_14:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            val_12 = val_4.InitializationCallback;
            if((System.String.op_Equality(a:  0, b:  X22)) == false)
            {
                goto label_14;
            }
            
            val_4.Dispose();
            if(val_12 == null)
            {
                goto label_26;
            }
            
            List.Enumerator<T> val_8 = key.GetEnumerator();
            do
            {
                if((0 & 1) == 0)
            {
                goto label_28;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = 0.InitializationCallback;
            }
            while((System.String.op_Equality(a:  0, b:  val_12)) == false);
            
            0.Dispose();
            return (string)val_13;
            label_10:
            label_28:
            val_4.Dispose();
            label_26:
            val_13 = 0;
            return (string)val_13;
        }
        public static System.Collections.Generic.List<string> GetStringArray(string section, string arrayName)
        {
            var val_4;
            var val_14;
            var val_16;
            System.Collections.Generic.List<TzarGames.Common.ConfigurationEntry> val_17;
            System.Collections.Generic.List<T> val_18;
            var val_19;
            val_16 = null;
            val_16 = null;
            if(TzarGames.Common.Configuration.initCompleted != true)
            {
                    TzarGames.Common.Configuration.entryHeadNode = TzarGames.Common.Configuration.initialize();
                val_16 = null;
            }
            
            val_16 = null;
            val_17 = mem[val_1 + 48];
            val_17 = val_1.Entries;
            List.Enumerator<T> val_2 = val_17.GetEnumerator();
            label_14:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            val_17 = val_4.InitializationCallback;
            if((System.String.op_Equality(a:  0, b:  X22)) == false)
            {
                goto label_14;
            }
            
            val_4.Dispose();
            if(val_17 == null)
            {
                    return 0;
            }
            
            List.Enumerator<T> val_8 = arrayName.GetEnumerator();
            do
            {
                if((0 & 1) == 0)
            {
                goto label_34;
            }
            
            }
            while((System.String.op_Equality(a:  0, b:  val_17)) == false);
            
            System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_12 = val_4.InitializationCallback.GetEnumerator();
            label_28:
            if((0 & 1) == 0)
            {
                goto label_25;
            }
            
            Add(item:  val_14.InitializationCallback);
            goto label_28;
            label_10:
            label_34:
            val_4.Dispose();
            return 0;
            label_25:
            val_18 = 0;
            val_19 = 248;
            val_14.Dispose();
            val_4.Dispose();
            return 0;
        }
        [TzarGames.Common.ConsoleCommand]
        public static void Test_Configuration_String(string sectionName, string keyName)
        {
            string val_1 = TzarGames.Common.Configuration.GetString(section:  null, key:  keyName);
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void Test_Configuration_Array(string sectionName, string arrayName)
        {
            var val_4;
            var val_5;
            List.Enumerator<T> val_2 = TzarGames.Common.Configuration.GetStringArray(section:  null, arrayName:  arrayName).GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = 0.InitializationCallback;
            UnityEngine.Debug.Log(message:  0);
            goto label_7;
            label_4:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        private static Configuration()
        {
            TzarGames.Common.Configuration.initCompleted = false;
            TzarGames.Common.Configuration.entryHeadNode = new TzarGames.Common.ConfigurationEntry();
        }
    
    }

}
