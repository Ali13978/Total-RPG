using UnityEngine;

namespace Unitycoding
{
    public static class JsonSerializer
    {
        // Methods
        public static string Serialize(Unitycoding.IJsonSerializable[] objs)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_1;
            label_13:
            val_5 = 1;
            label_1:
            if(val_5 >= (X1 + 24))
            {
                    return MiniJSON.Serializer.Serialize(obj:  new System.Collections.Generic.List<System.Object>() = new System.Collections.Generic.List<System.Object>());
            }
            
            var val_2 = X1 + 8;
            if(((X1 + 8) + 32) == 0)
            {
                goto label_13;
            }
            
            var val_6 = (X1 + 8) + 32;
            if(((X1 + 8) + 32 + 258) == 0)
            {
                goto label_8;
            }
            
            var val_4 = (X1 + 8) + 32 + 152;
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_10:
            if((((X1 + 8) + 32 + 152 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < ((X1 + 8) + 32 + 258))
            {
                goto label_10;
            }
            
            label_8:
            val_6 = (X1 + 8) + 32;
            goto label_11;
            label_9:
            val_6 = val_6 + ((((X1 + 8) + 32 + 152 + 8)) << 4);
            val_6 = val_6 + 272;
            label_11:
            Add(item:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
            goto label_13;
        }
        public static void Deserialize(string json, Unitycoding.IJsonSerializable[] objs)
        {
            var val_10;
            var val_11;
            bool val_1 = System.String.IsNullOrEmpty(value:  0);
            if(val_1 == true)
            {
                    return;
            }
            
            if(objs != null)
            {
                    object val_3 = MiniJSON.Parser.Parse(jsonString:  val_1);
            }
            
            val_11 = 0;
            val_10 = 0;
            goto label_8;
            label_22:
            val_10 = 1;
            label_8:
            if(val_10 >= Count)
            {
                    return;
            }
            
            var val_8 = X2 + 8;
            var val_13 = (X2 + 8) + 32;
            if(((X2 + 8) + 32 + 258) == 0)
            {
                goto label_22;
            }
            
            var val_10 = (X2 + 8) + 32 + 152;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_20:
            if((((X2 + 8) + 32 + 152 + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < ((X2 + 8) + 32 + 258))
            {
                goto label_20;
            }
            
            goto label_22;
            label_19:
            var val_12 = val_10;
            val_12 = val_12 + 1;
            val_13 = val_13 + val_12;
            var val_9 = val_13 + 272;
            goto label_22;
        }
        public static System.Collections.Generic.List<T> Deserialize<T>(string json)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_18 = __RuntimeMethodHiddenParam;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (System.Collections.Generic.List<T>)X2 + 48;
            }
            
            val_18 = Unitycoding.MiniJSON.Deserialize(json:  0);
            if(val_18 == null)
            {
                    return (System.Collections.Generic.List<T>)X2 + 48;
            }
            
            if(val_18.Count < 1)
            {
                    return (System.Collections.Generic.List<T>)X2 + 48;
            }
            
            var val_20 = 0;
            label_25:
            object val_5 = val_18.Item[0];
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) == 0)
            {
                goto label_9;
            }
            
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_19 = 0;
            UnityEngine.ScriptableObject val_11 = UnityEngine.ScriptableObject.CreateInstance(type:  0);
            if(val_11 == null)
            {
                goto label_17;
            }
            
            val_20 = val_11;
            if(val_20 != null)
            {
                goto label_13;
            }
            
            val_21;
            goto label_14;
            label_9:
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_19 = 0;
            object val_14 = System.Activator.CreateInstance(type:  0);
            if(val_14 == null)
            {
                goto label_17;
            }
            
            val_20 = val_14;
            if(val_20 == null)
            {
                goto label_18;
            }
            
            label_13:
            val_22 = val_20;
            goto label_19;
            label_18:
            label_14:
            label_17:
            val_20 = 0;
            val_22 = 0;
            label_19:
            if(mem[282584257676929] == 0)
            {
                goto label_20;
            }
            
            var val_17 = mem[282584257676823];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_22:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < mem[282584257676929])
            {
                goto label_22;
            }
            
            label_20:
            val_19 = 1;
            val_23 = val_22;
            goto label_23;
            label_21:
            var val_19 = val_17;
            val_19 = val_19 + 1;
            val_22 = val_22 + val_19;
            val_23 = val_22 + 272;
            label_23:
            val_20 = val_20 + 1;
            if(val_20 < val_18.Count)
            {
                goto label_25;
            }
            
            return (System.Collections.Generic.List<T>)X2 + 48;
        }
        public static string Serialize(Unitycoding.IJsonSerializable obj)
        {
            var val_3;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            var val_4 = X1;
            if((X1 + 258) == 0)
            {
                goto label_2;
            }
            
            var val_2 = X1 + 152;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_4:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (X1 + 258))
            {
                goto label_4;
            }
            
            label_2:
            val_3 = X1;
            return MiniJSON.Serializer.Serialize(obj:  X1);
            label_3:
            val_4 = val_4 + (((X1 + 152 + 8)) << 4);
            val_3 = val_4 + 272;
            return MiniJSON.Serializer.Serialize(obj:  X1);
        }
        public static void Deserialize(string json, Unitycoding.IJsonSerializable obj)
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = 0;
            bool val_1 = System.String.IsNullOrEmpty(value:  0);
            if(val_1 != false)
            {
                    return;
            }
            
            if(obj != null)
            {
                    object val_3 = MiniJSON.Parser.Parse(jsonString:  val_1);
            }
            
            val_7 = 0;
            var val_8 = X2;
            if((X2 + 258) == 0)
            {
                goto label_9;
            }
            
            var val_5 = X2 + 152;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_11:
            if(((X2 + 152 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (X2 + 258))
            {
                goto label_11;
            }
            
            label_9:
            val_6 = 1;
            val_8 = X2;
            goto ((X2 + ((X2 + 152 + 8) + 1)) + 272);
            label_10:
            var val_7 = val_5;
            val_7 = val_7 + 1;
            val_8 = val_8 + val_7;
            val_8 = val_8 + 272;
            goto ((X2 + ((X2 + 152 + 8) + 1)) + 272);
        }
    
    }

}
