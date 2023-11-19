using UnityEngine;

namespace I2.Loc
{
    public class SpecializationManager : BaseSpecializationManager
    {
        // Fields
        public static I2.Loc.SpecializationManager Singleton;
        
        // Methods
        private SpecializationManager()
        {
            this.InitializeSpecializations();
        }
        public static string GetSpecializedText(string text, string specialization)
        {
            string val_16;
            var val_17;
            var val_18;
            int val_19;
            int val_20;
            val_16 = X2;
            int val_1 = specialization.IndexOf(value:  "[i2s_");
            if((val_1 & 2147483648) != 0)
            {
                    return (string)specialization;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_5;
            }
            
            val_17 = null;
            val_17 = null;
            label_23:
            val_16 = I2.Loc.SpecializationManager.Singleton.GetCurrentSpecialization();
            label_5:
            if(((System.String.IsNullOrEmpty(value:  0)) == true) || ((System.String.op_Inequality(a:  0, b:  val_16)) == false))
            {
                goto label_15;
            }
            
            string val_8 = 0 + "[i2s_" + val_16;
            int val_9 = specialization.IndexOf(value:  val_8);
            if((val_9 & 2147483648) == 0)
            {
                goto label_19;
            }
            
            val_18 = null;
            val_18 = null;
            string val_10 = I2.Loc.SpecializationManager.Singleton.GetFallbackSpecialization(specialization:  val_16);
            goto label_23;
            label_15:
            val_19 = 0;
            val_20 = val_1;
            return specialization.Substring(startIndex:  val_19 = val_12, length:  val_20 = val_16 - val_12);
            label_19:
            int val_12 = val_8.Length + val_9;
            val_16 = specialization.IndexOf(value:  "[i2s_", startIndex:  val_12);
            if((val_16 & 2147483648) != 0)
            {
                    val_16 = specialization.Length;
            }
            
            return specialization.Substring(startIndex:  val_19, length:  val_20);
        }
        public static string SetSpecializedText(string text, string newText, string specialization)
        {
            string val_2 = ((System.String.IsNullOrEmpty(value:  0)) != true) ? "Any" : (X3);
            if(newText != null)
            {
                    if((newText.Contains(value:  "[i2s_")) == true)
            {
                goto label_7;
            }
            
            }
            
            if((System.String.op_Equality(a:  0, b:  val_2)) != false)
            {
                    return (string)specialization;
            }
            
            label_7:
            System.Collections.Generic.Dictionary<System.String, System.String> val_7 = I2.Loc.SpecializationManager.GetSpecializations(text:  null, buffer:  newText);
            val_7.set_Item(key:  val_2, value:  specialization);
            return I2.Loc.SpecializationManager.SetSpecializedText(specializations:  val_7);
        }
        public static string SetSpecializedText(System.Collections.Generic.Dictionary<string, string> specializations)
        {
            var val_5;
            var val_14;
            if((X1.TryGetValue(key:  "Any", value: out  0)) != true)
            {
                    val_14 = null;
                val_14 = null;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = X1.GetEnumerator();
            goto label_13;
            label_32:
            do
            {
                label_13:
                if((0 & 1) == 0)
            {
                goto label_35;
            }
            
                UnityEngine.Playables.PlayableHandle val_7 = val_5.GetHandle();
            }
            while((System.String.op_Inequality(a:  0, b:  val_7.m_Handle.InitializationCallback)) == false);
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_13;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = val_4.current.Value;
            typeof(System.String[]).__il2cppRuntimeField_28 = "[i2s_";
            typeof(System.String[]).__il2cppRuntimeField_30 = val_7.m_Handle.InitializationCallback;
            typeof(System.String[]).__il2cppRuntimeField_38 = "]";
            typeof(System.String[]).__il2cppRuntimeField_40 = ;
            string val_13 = +0;
            goto label_32;
            label_35:
            val_5.Dispose();
            if((0 & 1) != 0)
            {
                    return (string)val_4.current.Value;
            }
            
            if(null == null)
            {
                    return (string)val_4.current.Value;
            }
            
            return (string)val_4.current.Value;
        }
        public static System.Collections.Generic.Dictionary<string, string> GetSpecializations(string text, System.Collections.Generic.Dictionary<string, string> buffer)
        {
            int val_13;
            var val_14;
            string val_15;
            string val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_14 = X2;
            if(val_14 != 0)
            {
                    val_14.Clear();
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.String, System.String> val_1 = null;
                val_14 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            }
            
            if(buffer == null)
            {
                goto label_3;
            }
            
            val_13 = buffer.IndexOf(value:  "[i2s_");
            if((val_13 & 2147483648) != 0)
            {
                    val_13 = buffer.Length;
            }
            
            string val_4 = buffer.Substring(startIndex:  0, length:  val_13);
            val_15 = val_4;
            val_16 = "Any";
            val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            goto label_6;
            label_12:
            val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::set_Item(System.String key, System.String value);
            val_16 = val_4;
            val_15 = X23;
            label_6:
            set_Item(key:  val_16, value:  val_15);
            if(val_13 >= buffer.Length)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)val_14;
            }
            
            val_18 = "[i2s_";
            if("[i2s_" == null)
            {
                    val_18 = "[i2s_";
            }
            
            val_13 = Length + val_13;
            int val_13 = val_13;
            int val_14 = buffer.IndexOf(value:  ']', startIndex:  val_13);
            if((val_14 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)val_14;
            }
            
            val_13 = val_14 - val_13;
            string val_8 = buffer.Substring(startIndex:  val_13, length:  val_13);
            val_14 = val_14 + 1;
            val_19 = buffer.IndexOf(value:  "[i2s_", startIndex:  val_14);
            if((val_19 & 2147483648) != 0)
            {
                    val_19 = buffer.Length;
            }
            
            string val_12 = buffer.Substring(startIndex:  val_14, length:  val_19 - val_14);
            if(null != 0)
            {
                goto label_12;
            }
            
            goto label_12;
            label_3:
            val_20 = null;
            val_20 = null;
            set_Item(key:  "Any", value:  System.String.Empty);
            return (System.Collections.Generic.Dictionary<System.String, System.String>)val_14;
        }
        public static void AppendSpecializations(string text, System.Collections.Generic.List<string> list)
        {
            int val_11;
            var val_12;
            var val_13;
            val_12 = X2;
            if(list == null)
            {
                    return;
            }
            
            if(val_12 == 0)
            {
                    System.Collections.Generic.List<System.String> val_1 = null;
                val_12 = val_1;
                val_1 = new System.Collections.Generic.List<System.String>();
                if(null == 0)
            {
                goto label_14;
            }
            
            }
            
            label_14:
            val_11 = "Any";
            if((Contains(item:  "Any")) != true)
            {
                    Add(item:  "Any");
            }
            
            if(list.Length < 1)
            {
                    return;
            }
            
            do
            {
                val_11 = list.IndexOf(value:  "[i2s_", startIndex:  0);
                if((val_11 & 2147483648) != 0)
            {
                    return;
            }
            
                val_13 = "[i2s_";
                if("[i2s_" == null)
            {
                    val_13 = "[i2s_";
            }
            
                val_11 = Length + val_11;
                int val_11 = val_11;
                int val_7 = list.IndexOf(value:  ']', startIndex:  val_11);
                if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
                val_11 = val_7 - val_11;
                string val_8 = list.Substring(startIndex:  val_11, length:  val_11);
                if((Contains(item:  val_8)) != true)
            {
                    Add(item:  val_8);
            }
            
            }
            while(val_11 < list.Length);
        
        }
        private static SpecializationManager()
        {
            InitializeSpecializations();
            I2.Loc.SpecializationManager.Singleton = new I2.Loc.BaseSpecializationManager();
        }
    
    }

}
