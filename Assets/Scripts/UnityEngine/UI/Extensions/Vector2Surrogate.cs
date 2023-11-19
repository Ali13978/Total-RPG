using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public sealed class Vector2Surrogate : ISerializationSurrogate
    {
        // Methods
        public Vector2Surrogate()
        {
        
        }
        public void GetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(info != null)
            {
                    info.AddValue(name:  "x", value:  7.461634E-41f);
            }
            else
            {
                    0.AddValue(name:  "x", value:  7.461634E-41f);
            }
            
            info.AddValue(name:  "y", value:  V8.16B);
        }
        public object SetObjectData(object obj, System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context, System.Runtime.Serialization.ISurrogateSelector selector)
        {
            System.Runtime.Serialization.SerializationInfo val_11 = info;
            object val_4 = val_11.GetValue(name:  "x", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            object val_7 = val_11.GetValue(name:  "y", type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_11 = null;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y});
            return (object)null;
            label_13:
            goto label_13;
        }
    
    }

}
