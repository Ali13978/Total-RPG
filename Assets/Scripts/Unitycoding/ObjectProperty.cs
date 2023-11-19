using UnityEngine;

namespace Unitycoding
{
    [Serializable]
    public class ObjectProperty : INameable
    {
        // Fields
        [UnityEngine.SerializeField]
        private string name;
        [UnityEngine.SerializeField]
        private int typeIndex;
        public string stringValue;
        public int intValue;
        public float floatValue;
        public UnityEngine.Color colorValue;
        public bool boolValue;
        public UnityEngine.Object objectReferenceValue;
        public UnityEngine.Vector2 vector2Value;
        public UnityEngine.Vector3 vector3Value;
        public bool show;
        public UnityEngine.Color color;
        
        // Properties
        public string Name { get; set; }
        public System.Type SerializedType { get; }
        public static System.Type[] SupportedTypes { get; }
        public static string[] DisplayNames { get; }
        
        // Methods
        public ObjectProperty()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.color = val_1;
            mem[1152921512612447596] = val_1.g;
            mem[1152921512612447600] = val_1.b;
            mem[1152921512612447604] = val_1.a;
        }
        public string get_Name()
        {
            return (string)this.name;
        }
        public void set_Name(string value)
        {
            this.name = value;
        }
        public System.Type get_SerializedType()
        {
            return (System.Type)Unitycoding.ObjectProperty.SupportedTypes[this.typeIndex];
        }
        public object GetValue()
        {
            var val_10;
            var val_11;
            UnityEngine.Object val_12;
            var val_13;
            float val_14;
            var val_15;
            val_10 = this;
            System.Type val_1 = this.SerializedType;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_11 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_4;
            }
            
            val_11 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_7;
            }
            
            val_11 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_10;
            }
            
            val_11 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_13;
            }
            
            val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((val_11 & 1) == 0)
            {
                goto label_17;
            }
            
            val_12 = this.objectReferenceValue;
            return (object)val_14;
            label_1:
            val_12 = 0;
            return (object)val_14;
            label_4:
            val_12 = this.stringValue;
            return (object)val_14;
            label_7:
            val_13 = null;
            goto label_34;
            label_10:
            val_13 = null;
            goto label_34;
            label_13:
            val_14 = this.floatValue;
            val_15 = 1152921504608444416;
            goto label_23;
            label_17:
            val_11 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_26;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_34;
            }
            
            val_11 = null;
            val_12 = 0;
            if(val_1 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    return (object)val_14;
            }
            
            val_13 = null;
            goto label_34;
            label_26:
            val_14 = this.intValue;
            val_15 = 1152921504607113216;
            label_23:
            label_34:
            return (object)val_14;
        }
        public void SetValue(object value)
        {
            var val_16;
            var val_17;
            UnityEngine.Object val_18;
            string val_19;
            val_17 = value;
            if(val_17 == null)
            {
                goto label_1;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_4;
            }
            
            if((null == null) || (null == null))
            {
                goto label_6;
            }
            
            label_1:
            val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Type val_2 = val_17.GetType();
            if((val_16 & 1) == 0)
            {
                goto label_11;
            }
            
            this.typeIndex = 4;
            val_18 = 0;
            this.objectReferenceValue = val_18;
            return;
            label_2:
            this.typeIndex = 0;
            if(null != null)
            {
                    val_19 = 0;
            }
            
            this.stringValue = val_19;
            return;
            label_11:
            if(val_17 == null)
            {
                    return;
            }
            
            if((((((((null == null) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null))
            {
                goto label_26;
            }
            
            if(null == null)
            {
                goto label_27;
            }
            
            if(null != null)
            {
                    return;
            }
            
            this.typeIndex = 7;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.vector3Value = new UnityEngine.Vector3();
            mem[1152921512613216476] = 1152921504719785984;
            mem[1152921512613216480] = null;
            return;
            label_3:
            this.typeIndex = 1;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.boolValue = null;
            return;
            label_4:
            this.typeIndex = 2;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.colorValue = new UnityEngine.Color();
            return;
            label_6:
            this.typeIndex = 3;
            this.floatValue = System.Convert.ToSingle(value:  0);
            return;
            label_26:
            this.typeIndex = 5;
            this.intValue = System.Convert.ToInt32(value:  0);
            return;
            label_27:
            this.typeIndex = 6;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.vector2Value = new UnityEngine.Vector2();
            mem[1152921512613216468] = 1152921504730062848;
            return;
            label_46:
            goto label_46;
        }
        public static string GetPropertyName(System.Type mType)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = X1;
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_3;
            }
            
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_6;
            }
            
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_9;
            }
            
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_12;
            }
            
            if((((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) & 1) & 1) == 0)
            {
                goto label_16;
            }
            
            val_11 = "objectReferenceValue";
            return (string)val_11;
            label_3:
            val_11 = "stringValue";
            return (string)val_11;
            label_6:
            val_11 = "boolValue";
            return (string)val_11;
            label_9:
            val_11 = "colorValue";
            return (string)val_11;
            label_12:
            val_11 = "floatValue";
            return (string)val_11;
            label_16:
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_24;
            }
            
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_27;
            }
            
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == val_10)
            {
                goto label_30;
            }
            
            val_10 = 1152921504608284672;
            val_12 = null;
            val_12 = null;
            return (string)val_11;
            label_24:
            val_11 = "intValue";
            return (string)val_11;
            label_27:
            val_11 = "vector2Value";
            return (string)val_11;
            label_30:
            val_11 = "vector3Value";
            return (string)val_11;
        }
        public static System.Type[] get_SupportedTypes()
        {
            typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_28 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_30 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_38 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_40 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_48 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_50 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_58 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            return (System.Type[])null;
        }
        public static string[] get_DisplayNames()
        {
            typeof(System.String[]).__il2cppRuntimeField_20 = "String";
            typeof(System.String[]).__il2cppRuntimeField_28 = "Bool";
            typeof(System.String[]).__il2cppRuntimeField_30 = "Color";
            typeof(System.String[]).__il2cppRuntimeField_38 = "Float";
            typeof(System.String[]).__il2cppRuntimeField_40 = "Object";
            typeof(System.String[]).__il2cppRuntimeField_48 = "Int";
            typeof(System.String[]).__il2cppRuntimeField_50 = "Vector2";
            typeof(System.String[]).__il2cppRuntimeField_58 = "Vector3";
            return (System.String[])null;
        }
    
    }

}
