using UnityEngine;

namespace Google.Developers
{
    public class JavaObjWrapper
    {
        // Fields
        private IntPtr raw;
        private IntPtr cachedRawClass;
        
        // Properties
        public IntPtr RawObject { get; }
        public virtual IntPtr RawClass { get; }
        
        // Methods
        protected JavaObjWrapper()
        {
            this.cachedRawClass = 0;
        }
        public JavaObjWrapper(string clazzName)
        {
            this.cachedRawClass = 0;
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            this.raw = UnityEngine.AndroidJNI.AllocObject(clazz:  0);
        }
        public JavaObjWrapper(IntPtr rawObject)
        {
            this.cachedRawClass = 0;
            this.raw = rawObject;
        }
        public IntPtr get_RawObject()
        {
            return (IntPtr)this.raw;
        }
        public virtual IntPtr get_RawClass()
        {
            if((System.IntPtr.op_Equality(value1:  0, value2:  this.cachedRawClass)) == false)
            {
                    return (IntPtr)this.cachedRawClass;
            }
            
            if((System.IntPtr.op_Inequality(value1:  0, value2:  this.raw)) == false)
            {
                    return (IntPtr)this.cachedRawClass;
            }
            
            this.cachedRawClass = UnityEngine.AndroidJNI.GetObjectClass(obj:  0);
            return (IntPtr)this.cachedRawClass;
        }
        public void CreateInstance(string clazzName, object[] args)
        {
            if((System.IntPtr.op_Inequality(value1:  0, value2:  this.raw)) != true)
            {
                    IntPtr val_2 = UnityEngine.AndroidJNIHelper.GetConstructorID(jclass:  0, args:  this);
                UnityEngine.jvalue[] val_3 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  val_2);
                this.raw = UnityEngine.AndroidJNI.NewObject(clazz:  0, methodID:  this, args:  val_2);
                UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  args);
                return;
            }
            
            System.Exception val_11 = new System.Exception(message:  "Java object already set");
        }
        protected static UnityEngine.jvalue[] ConstructArgArray(object[] theArgs)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            UnityEngine.jvalue val_27;
            int val_28;
            int val_29;
            val_18 = 0;
            goto label_2;
            label_20:
            var val_1 = null + ((X25) << 3);
            mem2[0] = X1 + 24;
            val_18 = 1;
            label_2:
            if(val_18 >= (X1 + 24))
            {
                goto label_4;
            }
            
            var val_2 = X1 + 8;
            val_19 = mem[(X1 + 8) + 32];
            val_19 = (X1 + 8) + 32;
            val_20 = 0;
            if(val_18 >= (X1 + 24))
            {
                    val_21 = mem[(X1 + 8) + 32];
                val_21 = (X1 + 8) + 32;
            }
            
            val_22 = (X1 + 8) + 32 + 16;
            if((((X1 + 8) + 32 + 16) == 0) || (((X1 + 8) + 32 + 16) != 0))
            {
                goto label_20;
            }
            
            goto label_20;
            label_4:
            UnityEngine.jvalue[] val_7 = UnityEngine.AndroidJNIHelper.CreateJNIArgArray(args:  0);
            val_23 = 1152921504722821120;
            val_24 = 0;
            goto label_21;
            label_46:
            val_24 = 1;
            label_21:
            if(val_24 >= (X1 + 24))
            {
                goto label_23;
            }
            
            var val_8 = X1 + 8;
            val_25 = mem[(X1 + 8) + 32];
            val_25 = (X1 + 8) + 32;
            if(val_24 >= (X1 + 24))
            {
                    val_25 = mem[(X1 + 8) + 32];
                val_25 = (X1 + 8) + 32;
            }
            
            if(val_25 == 0)
            {
                goto label_46;
            }
            
            if(val_24 < (X1 + 24))
            {
                goto label_32;
            }
            
            val_25 = mem[(X1 + 8) + 32];
            val_25 = (X1 + 8) + 32;
            val_26 = 0;
            if(val_25 == 0)
            {
                goto label_35;
            }
            
            label_32:
            val_26 = val_25;
            val_26 = 0;
            label_35:
            val_27 = UnityEngine.AndroidJNIHelper.CreateJavaProxy(proxy:  0);
            val_28 = val_7.Length;
            val_7[1] = ;
            goto label_46;
            label_23:
            if(val_7.Length != 1)
            {
                    return val_7;
            }
            
            val_24 = "---- [";
            val_23 = "] -- ";
            val_29 = 0;
            goto label_49;
            label_72:
            UnityEngine.Debug.Log(message:  0);
            val_29 = 1;
            label_49:
            if(val_29 >= val_7.Length)
            {
                    return val_7;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "---- [";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_29;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "] -- ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_7[1];
            string val_15 = +0;
            goto label_72;
            label_76:
            goto label_76;
        }
        public static T StaticInvokeObjectCall<T>(string type, string name, string sig, object[] args)
        {
            System.Type[] val_16;
            var val_17;
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            UnityEngine.jvalue[] val_3 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  0);
            val_16 = null;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(System.Type[]).__il2cppRuntimeField_20 = UnityEngine.AndroidJNI.CallStaticObjectMethod(clazz:  0, methodID:  val_1, args:  UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  0, name:  val_1, sig:  sig)).GetType();
            System.Reflection.ConstructorInfo val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetConstructor(types:  val_16);
            if(val_8 == null)
            {
                goto label_10;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            val_16 = val_8.Invoke(parameters:  null);
            if(val_16 == null)
            {
                goto label_29;
            }
            
            val_17 = val_16;
            if(val_17 != null)
            {
                goto label_30;
            }
            
            goto label_17;
            label_10:
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).IsArray) == false)
            {
                goto label_21;
            }
            
            val_17 = 0;
            goto label_30;
            label_21:
            UnityEngine.Debug.Log(message:  0);
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_16 = System.Runtime.InteropServices.Marshal.PtrToStructure(ptr:  0, structureType:  null);
            if(val_16 == null)
            {
                goto label_29;
            }
            
            val_17 = val_16;
            if(val_17 != null)
            {
                goto label_30;
            }
            
            label_17:
            label_29:
            val_17 = 0;
            label_30:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  __RuntimeMethodHiddenParam);
            return (object)val_17;
        }
        public static void StaticInvokeCallVoid(string type, string name, string sig, object[] args)
        {
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            IntPtr val_2 = UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  0, name:  val_1, sig:  sig);
            UnityEngine.jvalue[] val_3 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  val_2);
            UnityEngine.AndroidJNI.CallStaticVoidMethod(clazz:  0, methodID:  val_1, args:  val_2);
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  X4);
        }
        public static T GetStaticObjectField<T>(string clsName, string name, string sig)
        {
            System.Type val_14;
            System.Object[] val_15;
            var val_16;
            var val_17;
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            IntPtr val_2 = UnityEngine.AndroidJNI.GetStaticFieldID(clazz:  0, name:  val_1, sig:  sig);
            IntPtr val_3 = UnityEngine.AndroidJNI.GetStaticObjectField(clazz:  0, fieldID:  val_1);
            if(val_3 != 0)
            {
                    val_14 = val_3.GetType();
            }
            else
            {
                    val_14 = val_3.GetType();
            }
            
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(System.Type[]).__il2cppRuntimeField_20 = val_14;
            System.Reflection.ConstructorInfo val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetConstructor(types:  null);
            if(val_8 != null)
            {
                    val_15 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = null;
                object val_9 = val_8.Invoke(parameters:  val_15);
                val_16 = mem[X4 + 48 + 8];
                val_16 = X4 + 48 + 8;
                val_17 = 0;
                if(val_9 == null)
            {
                    return (object)val_17;
            }
            
                val_17 = val_9;
                if(val_17 != null)
            {
                    return (object)val_17;
            }
            
            }
            else
            {
                    System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_15 = null;
                object val_12 = System.Runtime.InteropServices.Marshal.PtrToStructure(ptr:  0, structureType:  val_15);
                val_16 = mem[X4 + 48 + 8];
                val_16 = X4 + 48 + 8;
                val_17 = 0;
                if(val_12 == null)
            {
                    return (object)val_17;
            }
            
                val_17 = val_12;
                if(val_17 != null)
            {
                    return (object)val_17;
            }
            
            }
            
            val_17 = 0;
            return (object)val_17;
        }
        public static int GetStaticIntField(string clsName, string name)
        {
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            IntPtr val_2 = UnityEngine.AndroidJNI.GetStaticFieldID(clazz:  0, name:  val_1, sig:  X2);
            return UnityEngine.AndroidJNI.GetStaticIntField(clazz:  0, fieldID:  val_1);
        }
        public static string GetStaticStringField(string clsName, string name)
        {
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            IntPtr val_2 = UnityEngine.AndroidJNI.GetStaticFieldID(clazz:  0, name:  val_1, sig:  X2);
            return UnityEngine.AndroidJNI.GetStaticStringField(clazz:  0, fieldID:  val_1);
        }
        public static float GetStaticFloatField(string clsName, string name)
        {
            IntPtr val_1 = UnityEngine.AndroidJNI.FindClass(name:  0);
            IntPtr val_2 = UnityEngine.AndroidJNI.GetStaticFieldID(clazz:  0, name:  val_1, sig:  X2);
            return UnityEngine.AndroidJNI.GetStaticFloatField(clazz:  0, fieldID:  val_1);
        }
        public void InvokeCallVoid(string name, string sig, object[] args)
        {
            IntPtr val_1 = UnityEngine.AndroidJNI.GetMethodID(clazz:  0, name:  this, sig:  name);
            UnityEngine.jvalue[] val_2 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  val_1);
            UnityEngine.AndroidJNI.CallVoidMethod(obj:  0, methodID:  this.raw, args:  val_1);
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  args);
        }
        public T InvokeCall<T>(string name, string sig, object[] args)
        {
            string val_36;
            var val_37;
            var val_38;
            val_36 = this;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            IntPtr val_2 = UnityEngine.AndroidJNI.GetMethodID(clazz:  0, name:  this, sig:  name);
            if((System.IntPtr.op_Equality(value1:  0, value2:  val_2)) == true)
            {
                goto label_4;
            }
            
            UnityEngine.jvalue[] val_4 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  0);
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_7;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_10;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_13;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_16;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_19;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_22;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_25;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_28;
            }
            
            val_37 = null;
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_31;
            }
            
            val_38 = val_36;
            goto label_59;
            label_7:
            bool val_15 = UnityEngine.AndroidJNI.CallBooleanMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_15;
            if(val_15 == false)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_15 == true)
            {
                goto label_59;
            }
            
            goto label_57;
            label_10:
            val_36 = UnityEngine.AndroidJNI.CallStringMethod(obj:  0, methodID:  this.raw, args:  val_2);
            if(val_36 == null)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_38 != null)
            {
                goto label_59;
            }
            
            goto label_57;
            label_13:
            int val_19 = UnityEngine.AndroidJNI.CallIntMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_19;
            if(val_19 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_19 != 0)
            {
                goto label_59;
            }
            
            goto label_57;
            label_16:
            float val_21 = UnityEngine.AndroidJNI.CallFloatMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_21;
            if(val_21 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_21 != 0)
            {
                goto label_59;
            }
            
            goto label_57;
            label_19:
            double val_23 = UnityEngine.AndroidJNI.CallDoubleMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_23;
            if(val_23 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_23 != 0)
            {
                goto label_59;
            }
            
            goto label_57;
            label_22:
            byte val_25 = UnityEngine.AndroidJNI.CallByteMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_25;
            if(val_25 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_25 != 0)
            {
                goto label_59;
            }
            
            goto label_57;
            label_25:
            char val_27 = UnityEngine.AndroidJNI.CallCharMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_27;
            if(val_27 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_27 != 0)
            {
                goto label_59;
            }
            
            goto label_57;
            label_28:
            long val_29 = UnityEngine.AndroidJNI.CallLongMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_29;
            if(val_29 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_29 != 0)
            {
                goto label_59;
            }
            
            goto label_57;
            label_31:
            short val_31 = UnityEngine.AndroidJNI.CallShortMethod(obj:  0, methodID:  this.raw, args:  val_2);
            val_36 = val_31;
            if(val_31 == 0)
            {
                goto label_58;
            }
            
            val_38 = val_36;
            if(val_31 != 0)
            {
                goto label_59;
            }
            
            label_57:
            label_58:
            val_38 = 0;
            label_59:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  args);
            return (object)val_38;
            label_75:
            if(args != 1)
            {
                goto label_60;
            }
            
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  ???);
            if(1179403647 == 0)
            {
                    return (object)val_38;
            }
            
            return (object)val_38;
            label_4:
            string val_33 = 0 + "Cannot get method for ";
            UnityEngine.Debug.LogError(message:  0);
            System.Exception val_35 = new System.Exception(message:  0 + "Cannot get method for ");
            goto label_75;
            label_60:
        }
        public static T StaticInvokeCall<T>(string type, string name, string sig, object[] args)
        {
            string val_33;
            var val_34;
            val_33 = sig;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            IntPtr val_2 = UnityEngine.AndroidJNI.FindClass(name:  0);
            IntPtr val_3 = UnityEngine.AndroidJNI.GetStaticMethodID(clazz:  0, name:  val_2, sig:  val_33);
            UnityEngine.jvalue[] val_4 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  0);
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_5;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_8;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_11;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_14;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_17;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_20;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_23;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_26;
            }
            
            if(val_1 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_29;
            }
            
            val_34 = 0;
            goto label_56;
            label_5:
            bool val_15 = UnityEngine.AndroidJNI.CallStaticBooleanMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_15;
            if(val_15 == false)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_15 == true)
            {
                goto label_56;
            }
            
            goto label_54;
            label_8:
            val_33 = UnityEngine.AndroidJNI.CallStaticStringMethod(clazz:  0, methodID:  val_2, args:  val_3);
            if(val_33 == null)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_34 != null)
            {
                goto label_56;
            }
            
            goto label_54;
            label_11:
            int val_19 = UnityEngine.AndroidJNI.CallStaticIntMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_19;
            if(val_19 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_19 != 0)
            {
                goto label_56;
            }
            
            goto label_54;
            label_14:
            float val_21 = UnityEngine.AndroidJNI.CallStaticFloatMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_21;
            if(val_21 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_21 != 0)
            {
                goto label_56;
            }
            
            goto label_54;
            label_17:
            double val_23 = UnityEngine.AndroidJNI.CallStaticDoubleMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_23;
            if(val_23 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_23 != 0)
            {
                goto label_56;
            }
            
            goto label_54;
            label_20:
            byte val_25 = UnityEngine.AndroidJNI.CallStaticByteMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_25;
            if(val_25 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_25 != 0)
            {
                goto label_56;
            }
            
            goto label_54;
            label_23:
            char val_27 = UnityEngine.AndroidJNI.CallStaticCharMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_27;
            if(val_27 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_27 != 0)
            {
                goto label_56;
            }
            
            goto label_54;
            label_26:
            long val_29 = UnityEngine.AndroidJNI.CallStaticLongMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_29;
            if(val_29 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_29 != 0)
            {
                goto label_56;
            }
            
            goto label_54;
            label_29:
            short val_31 = UnityEngine.AndroidJNI.CallStaticShortMethod(clazz:  0, methodID:  val_2, args:  val_3);
            val_33 = val_31;
            if(val_31 == 0)
            {
                goto label_55;
            }
            
            val_34 = val_33;
            if(val_31 != 0)
            {
                goto label_56;
            }
            
            label_54:
            label_55:
            val_34 = 0;
            label_56:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  __RuntimeMethodHiddenParam);
            return (object)val_34;
        }
        public T InvokeObjectCall<T>(string name, string sig, object[] theArgs)
        {
            string val_13;
            var val_14;
            val_13 = name;
            UnityEngine.jvalue[] val_2 = Google.Developers.JavaObjWrapper.ConstructArgArray(theArgs:  0);
            if((0 & 1) != 0)
            {
                goto label_24;
            }
            
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(System.Type[]).__il2cppRuntimeField_20 = UnityEngine.AndroidJNI.CallObjectMethod(obj:  0, methodID:  this.raw, args:  UnityEngine.AndroidJNI.GetMethodID(clazz:  0, name:  this, sig:  val_13)).GetType();
            System.Reflection.ConstructorInfo val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetConstructor(types:  null);
            if(val_7 == null)
            {
                goto label_12;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            val_13 = val_7.Invoke(parameters:  null);
            if(val_13 == null)
            {
                goto label_24;
            }
            
            val_14 = val_13;
            if(val_14 != null)
            {
                goto label_25;
            }
            
            goto label_19;
            label_12:
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_13 = System.Runtime.InteropServices.Marshal.PtrToStructure(ptr:  0, structureType:  null);
            if(val_13 == null)
            {
                goto label_24;
            }
            
            val_14 = val_13;
            if(val_14 != null)
            {
                goto label_25;
            }
            
            label_19:
            label_24:
            val_14 = 0;
            label_25:
            UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(args:  0, jniArgs:  theArgs);
            return (object)val_14;
        }
    
    }

}
