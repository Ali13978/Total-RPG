using UnityEngine;

namespace TzarGames.Common
{
    public class Console
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Type>> commandAndTypes;
        private System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<string>> typesAndCommands;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Reflection.MethodInfo>> commandAndInfos;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.KeyValuePair<string, int>> logHash;
        private static bool initCompleted;
        private static TzarGames.Common.Console _instance;
        
        // Properties
        private static TzarGames.Common.Console console { get; }
        public static System.Collections.Generic.Dictionary<int, System.Collections.Generic.KeyValuePair<string, int>> LogHash { get; }
        
        // Methods
        private Console()
        {
            this.commandAndTypes = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Type>>();
            this.typesAndCommands = new System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.String>>();
            this.commandAndInfos = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Reflection.MethodInfo>>();
            this.logHash = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.KeyValuePair<System.String, System.Int32>>();
            Application.LogCallback val_5 = new Application.LogCallback(object:  this, method:  System.Void TzarGames.Common.Console::logCallback(string condition, string stackTrace, UnityEngine.LogType type));
            UnityEngine.Application.add_logMessageReceived(value:  0);
        }
        private void init()
        {
            var val_1;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            string val_22;
            string val_23;
            val_17 = this;
            val_18 = null;
            val_18 = null;
            if(TzarGames.Common.Console.initCompleted == true)
            {
                    return;
            }
            
            val_19 = System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16;
            val_20 = 0;
            var val_2 = val_19 + (((long)(int)((val_1 + 1))) << 3);
            val_1 = ;
            val_21 = 0;
            goto label_10;
            label_40:
            val_21 = 1;
            label_10:
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_22 = ((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32;
            if((this.commandAndTypes.ContainsKey(key:  val_22)) != true)
            {
                    val_22 = ((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32;
                this.commandAndTypes.Add(key:  val_22, value:  new System.Collections.Generic.List<System.Type>());
            }
            
            this.commandAndTypes.Item[((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32].Add(item:  (System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32);
            if((this.typesAndCommands.ContainsKey(key:  (System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32)) != true)
            {
                    this.typesAndCommands.Add(key:  (System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32, value:  new System.Collections.Generic.List<System.String>());
            }
            
            this.typesAndCommands.Item[(System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32].Add(item:  ((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32);
            val_23 = ((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32;
            if((this.commandAndInfos.ContainsKey(key:  val_23)) != true)
            {
                    val_23 = ((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32;
                this.commandAndInfos.Add(key:  val_23, value:  new System.Collections.Generic.List<System.Reflection.MethodInfo>());
            }
            
            this.commandAndInfos.Item[((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32].Add(item:  ((System.Void TzarGames.Common.Console::init().__il2cppRuntimeField_18 + 16 + ((long)(int)((val_1 + 1))) << 3) + 32 + 8) + 32);
            goto label_40;
        }
        private void logCallback(string condition, string stackTrace, UnityEngine.LogType type)
        {
            string val_3 = condition;
            if((this.logHash.TryGetValue(key:  val_3 = condition, value: out  new System.Collections.Generic.KeyValuePair<System.String, System.Int32>())) != false)
            {
                    val_3 = 0.InitializationCallback;
                this.logHash.set_Item(key:  val_3, value:  new System.Collections.Generic.KeyValuePair<System.String, System.Int32>());
                return;
            }
            
            this.logHash.Add(key:  val_3, value:  new System.Collections.Generic.KeyValuePair<System.String, System.Int32>());
        }
        private static TzarGames.Common.Console get_console()
        {
            TzarGames.Common.Console val_2;
            TzarGames.Common.Console val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(TzarGames.Common.Console._instance == null)
            {
                    val_2 = val_3;
                val_3 = new TzarGames.Common.Console();
                val_4 = null;
                val_4 = null;
                TzarGames.Common.Console._instance = val_2;
                val_3 = null;
            }
            
            val_3 = null;
            if(TzarGames.Common.Console.initCompleted != true)
            {
                    val_2 = TzarGames.Common.Console._instance;
                init();
                val_3 = null;
            }
            
            val_3 = null;
            return (TzarGames.Common.Console)TzarGames.Common.Console._instance;
        }
        public static void ForceInit()
        {
            TzarGames.Common.Console.console.init();
        }
        public static System.Collections.Generic.Dictionary<int, System.Collections.Generic.KeyValuePair<string, int>> get_LogHash()
        {
            if(TzarGames.Common.Console.console != null)
            {
                    return (System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.KeyValuePair<System.String, System.Int32>>)val_1.logHash;
            }
            
            return (System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.KeyValuePair<System.String, System.Int32>>)val_1.logHash;
        }
        public static void ClearLogs()
        {
            TzarGames.Common.Console val_1 = TzarGames.Common.Console.console;
            val_1.logHash.Clear();
        }
        public static string[] GetAutocompleteResult(string methodName)
        {
            System.Collections.Generic.List<System.String> val_2 = TzarGames.Common.Console.console.getAutocompleteResult(methodName:  X1);
            if(val_2 != null)
            {
                    return val_2.ToArray();
            }
            
            return val_2.ToArray();
        }
        private System.Collections.Generic.List<string> getAutocompleteResult(string methodName)
        {
            var val_6;
            var val_14;
            var val_35;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Reflection.MethodInfo>> val_56;
            var val_57;
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            val_56 = this.commandAndInfos;
            Dictionary.Enumerator<TKey, TValue> val_4 = val_56.GetEnumerator();
            goto label_22;
            label_24:
            UnityEngine.Playables.PlayableHandle val_7 = val_6.GetHandle();
            if((val_7.m_Handle.InitializationCallback.ToLower().StartsWith(value:  methodName.ToLower())) == false)
            {
                goto label_22;
            }
            
            List.Enumerator<T> val_12 = val_7.m_Handle.GetEnumerator();
            label_18:
            if((0 & 1) == 0)
            {
                goto label_23;
            }
            
            if(val_14.InitializationCallback.IsStatic == false)
            {
                goto label_10;
            }
            
            if((Contains(item:  val_7.m_Handle.InitializationCallback)) == true)
            {
                goto label_18;
            }
            
            Add(item:  val_7.m_Handle.InitializationCallback);
            goto label_18;
            label_10:
            if((Contains(item:  val_7.m_Handle.InitializationCallback)) == true)
            {
                goto label_18;
            }
            
            Add(item:  val_7.m_Handle.InitializationCallback);
            goto label_18;
            label_23:
            val_14.Dispose();
            label_22:
            if((0 & 1) != 0)
            {
                goto label_24;
            }
            
            val_6.Dispose();
            val_57 = 1152921511065826112;
            Dictionary.Enumerator<TKey, TValue> val_26 = this.commandAndInfos.GetEnumerator();
            goto label_50;
            label_52:
            UnityEngine.Playables.PlayableHandle val_27 = val_6.GetHandle();
            if((val_27.m_Handle.InitializationCallback.ToLower().Contains(value:  methodName.ToLower())) == false)
            {
                goto label_50;
            }
            
            List.Enumerator<T> val_33 = val_27.m_Handle.GetEnumerator();
            label_46:
            if((0 & 1) == 0)
            {
                goto label_51;
            }
            
            if(val_35.InitializationCallback.IsStatic == false)
            {
                goto label_38;
            }
            
            if((Contains(item:  val_27.m_Handle.InitializationCallback)) == true)
            {
                goto label_46;
            }
            
            Add(item:  val_27.m_Handle.InitializationCallback);
            goto label_46;
            label_38:
            if((Contains(item:  val_27.m_Handle.InitializationCallback)) == true)
            {
                goto label_46;
            }
            
            Add(item:  val_27.m_Handle.InitializationCallback);
            goto label_46;
            label_51:
            val_35.Dispose();
            label_50:
            if((0 & 1) != 0)
            {
                goto label_52;
            }
            
            val_6.Dispose();
            int val_56 = Count;
            goto label_68;
            label_73:
            RemoveAt(index:  val_56);
            label_68:
            val_56 = val_56 - 1;
            label_62:
            if((val_56 & 2147483648) != 0)
            {
                goto label_59;
            }
            
            val_56 = val_56 - 1;
            if((this.commandAndTypes.TryGetValue(key:  Item[val_56], value: out  0)) == false)
            {
                goto label_62;
            }
            
            val_56 = val_56 + 1;
            List.Enumerator<T> val_51 = val_49.GetEnumerator();
            label_67:
            if((0 & 1) == 0)
            {
                goto label_64;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_52 = val_6.InitializationCallback;
            if(0 == (UnityEngine.Object.FindObjectOfType(type:  0)))
            {
                goto label_67;
            }
            
            val_6.Dispose();
            goto label_68;
            label_64:
            val_6.Dispose();
            if(null != 0)
            {
                goto label_73;
            }
            
            goto label_73;
            label_59:
            if(null != 0)
            {
                    AddRange(collection:  val_3);
            }
            else
            {
                    AddRange(collection:  val_3);
            }
            
            AddRange(collection:  new System.Collections.Generic.List<System.String>());
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
        }
        public static System.Collections.Generic.List<System.Reflection.ParameterInfo[]> GetCommandParameters(string command)
        {
            System.Collections.Generic.List<T> val_6;
            var val_7;
            TzarGames.Common.Console val_1 = TzarGames.Common.Console.console;
            List.Enumerator<T> val_4 = val_1.commandAndInfos.Item[X1].GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            Add(item:  0.InitializationCallback);
            goto label_9;
            label_6:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            if((val_7 & 1) != 0)
            {
                    return (System.Collections.Generic.List<System.Reflection.ParameterInfo[]>)new System.Collections.Generic.List<System.Reflection.ParameterInfo[]>();
            }
            
            if(val_6 == 0)
            {
                    return (System.Collections.Generic.List<System.Reflection.ParameterInfo[]>)new System.Collections.Generic.List<System.Reflection.ParameterInfo[]>();
            }
            
            return (System.Collections.Generic.List<System.Reflection.ParameterInfo[]>)new System.Collections.Generic.List<System.Reflection.ParameterInfo[]>();
        }
        public static void Execute(string command)
        {
            TzarGames.Common.Console.console.execute(command:  X1);
        }
        private void execute(string command)
        {
            var val_16;
            var val_21;
            System.Collections.Generic.List<T> val_58;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            val_58 = 1152921504608284672;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
            System.String[] val_3 = command.Split(separator:  null);
            string val_4 = val_3[0].Trim();
            System.Collections.Generic.List<System.Object> val_5 = new System.Collections.Generic.List<System.Object>();
            var val_59 = 0;
            label_18:
            if(val_59 >= (val_3.Length - 1))
            {
                goto label_11;
            }
            
            val_59 = val_59 + 1;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_18;
            }
            
            Add(item:  val_3[(long)val_59].Trim());
            goto label_18;
            label_11:
            if((this.commandAndTypes.ContainsKey(key:  val_4)) == false)
            {
                goto label_26;
            }
            
            List.Enumerator<T> val_14 = this.commandAndTypes.Item[val_4].GetEnumerator();
            val_60 = 0;
            goto label_138;
            label_141:
            List.Enumerator<T> val_19 = this.commandAndInfos.Item[val_4].GetEnumerator();
            label_133:
            if((0 & 1) == 0)
            {
                goto label_139;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_22 = val_21.InitializationCallback;
            val_61 = public System.Int32 System.Collections.Generic.List<System.Object>::get_Count();
            if(1152921509356864288 != Count)
            {
                goto label_36;
            }
            
            val_62 = 0;
            goto label_37;
            label_112:
            val_62 = 1;
            label_37:
            if(val_62 >= 1152921509356864288)
            {
                goto label_39;
            }
            
            if(val_62 >= 1152921509356864288)
            {
                    val_61 = 0;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_24 = val_22 + 8;
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_112;
            }
            
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_48;
            }
            
            val_63 = null;
            if(X27 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_52;
            }
            
            label_48:
            object val_28 = Item[1];
            val_63 = val_62;
            set_Item(index:  1, value:  System.Int32.Parse(s:  0));
            label_52:
            val_64 = null;
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    object val_31 = Item[1];
                val_64 = val_62;
                set_Item(index:  1, value:  System.UInt32.Parse(s:  0));
            }
            
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_66;
            }
            
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_70;
            }
            
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_74;
            }
            
            if(X27 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_78;
            }
            
            if(X27.IsEnum == false)
            {
                goto label_81;
            }
            
            set_Item(index:  1, value:  System.Enum.Parse(enumType:  0, value:  X27, ignoreCase:  Item[1]));
            goto label_112;
            label_66:
            object val_40 = Item[1];
            set_Item(index:  1, value:  System.Int64.Parse(s:  0));
            goto label_112;
            label_70:
            object val_42 = Item[1];
            set_Item(index:  1, value:  System.Single.Parse(s:  0));
            goto label_112;
            label_74:
            object val_44 = Item[1];
            set_Item(index:  1, value:  System.Double.Parse(s:  0));
            goto label_112;
            label_78:
            object val_46 = Item[1];
            set_Item(index:  1, value:  System.Boolean.Parse(value:  0));
            goto label_112;
            label_81:
            string val_49 = 0 + "Unknown parameter type: "("Unknown parameter type: ");
            UnityEngine.Debug.Log(message:  0);
            goto label_112;
            label_36:
            UnityEngine.Debug.LogWarning(message:  0);
            goto label_133;
            label_39:
            if(val_22.IsStatic == false)
            {
                goto label_117;
            }
            
            if(Count < 1)
            {
                goto label_119;
            }
            
            object val_53 = val_22.Invoke(obj:  0, parameters:  ToArray());
            goto label_133;
            label_117:
            val_65 = 0;
            goto label_125;
            label_131:
            val_65 = 1;
            label_125:
            if(val_65 >= val_54.Length)
            {
                goto label_133;
            }
            
            object val_56 = val_16.InitializationCallback.InvokeMember(name:  val_4, invokeAttr:  52, binder:  0, target:  UnityEngine.Object.FindObjectsOfType(type:  0)[1], args:  ToArray());
            goto label_131;
            label_119:
            object val_57 = val_22.Invoke(obj:  0, parameters:  0);
            goto label_133;
            label_139:
            val_21.Dispose();
            val_60 = 1152921504606900224;
            if(0 != 897)
            {
                    val_60 = 0;
                if(null != null)
            {
                    val_60 = 0;
            }
            
            }
            
            label_138:
            if((0 & 1) != 0)
            {
                goto label_141;
            }
            
            goto label_142;
            label_26:
            UnityEngine.Debug.Log(message:  0);
            return;
            label_142:
            val_16.Dispose();
            if(val_59 == 928)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private static Console()
        {
        
        }
    
    }

}
