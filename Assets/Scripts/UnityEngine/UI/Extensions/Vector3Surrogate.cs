using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public sealed class Vector3Surrogate : ISerializationSurrogate
    {
        // Methods
        public Vector3Surrogate()
        {
        
        }
        public void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(info != null)
            {
                    info.AddValue(name:  "x", value:  7.461634E-41f);
                info.AddValue(name:  "y", value:  V9.16B);
            }
            else
            {
                    0.AddValue(name:  "x", value:  7.461634E-41f);
                0.AddValue(name:  "y", value:  V9.16B);
            }
            
            info.AddValue(name:  "z", value:  V8.16B);
        }
        public object SetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
        {
            var val_15;
            var val_16;
            val_15 = info;
            object val_4 = val_15.GetValue(name:  "x", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_16 = null;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            object val_7 = val_15.GetValue(name:  "y", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_16 = null;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y});
            object val_10 = val_15.GetValue(name:  "z", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_15 = null;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y});
            return (object)null;
            label_17:
            goto label_17;
        }
    
    }

}
