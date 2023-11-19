using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public sealed class ColorSurrogate : ISerializationSurrogate
    {
        // Methods
        public ColorSurrogate()
        {
        
        }
        public void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(info != null)
            {
                    info.AddValue(name:  "r", value:  7.461634E-41f);
                info.AddValue(name:  "g", value:  V10.16B);
                info.AddValue(name:  "b", value:  V9.16B);
            }
            else
            {
                    0.AddValue(name:  "r", value:  7.461634E-41f);
                0.AddValue(name:  "g", value:  V10.16B);
                0.AddValue(name:  "b", value:  V9.16B);
            }
            
            info.AddValue(name:  "a", value:  V8.16B);
        }
        public object SetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
        {
            var val_19;
            var val_20;
            val_19 = info;
            object val_4 = val_19.GetValue(name:  "r", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_20 = null;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            object val_7 = val_19.GetValue(name:  "g", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_20 = null;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y});
            object val_10 = val_19.GetValue(name:  "b", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_20 = null;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y});
            object val_13 = val_19.GetValue(name:  "a", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_19 = null;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y});
            return (object)null;
            label_21:
            goto label_21;
        }
    
    }

}
