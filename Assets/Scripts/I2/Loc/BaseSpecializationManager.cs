using UnityEngine;

namespace I2.Loc
{
    public class BaseSpecializationManager
    {
        // Fields
        public string[] mSpecializations;
        public System.Collections.Generic.Dictionary<string, string> mSpecializationsFallbacks;
        
        // Methods
        public BaseSpecializationManager()
        {
        
        }
        public virtual void InitializeSpecializations()
        {
            typeof(System.String[]).__il2cppRuntimeField_20 = "Any";
            typeof(System.String[]).__il2cppRuntimeField_28 = "PC";
            typeof(System.String[]).__il2cppRuntimeField_30 = "Touch";
            typeof(System.String[]).__il2cppRuntimeField_38 = "Controller";
            typeof(System.String[]).__il2cppRuntimeField_40 = "VR";
            typeof(System.String[]).__il2cppRuntimeField_48 = "XBox";
            typeof(System.String[]).__il2cppRuntimeField_50 = "PS4";
            typeof(System.String[]).__il2cppRuntimeField_58 = "OculusVR";
            typeof(System.String[]).__il2cppRuntimeField_60 = "ViveVR";
            typeof(System.String[]).__il2cppRuntimeField_68 = "GearVR";
            typeof(System.String[]).__il2cppRuntimeField_70 = "Android";
            typeof(System.String[]).__il2cppRuntimeField_78 = "IOS";
            mem[1152921512223027792] = null;
            if(null != 0)
            {
                    Add(key:  "XBox", value:  "Controller");
            }
            else
            {
                    Add(key:  "XBox", value:  "Controller");
            }
            
            Add(key:  "PS4", value:  "Controller");
            if(null != 0)
            {
                    Add(key:  "OculusVR", value:  "VR");
            }
            else
            {
                    Add(key:  "OculusVR", value:  "VR");
            }
            
            Add(key:  "ViveVR", value:  "VR");
            if(null != 0)
            {
                    Add(key:  "GearVR", value:  "VR");
            }
            else
            {
                    Add(key:  "GearVR", value:  "VR");
            }
            
            Add(key:  "Android", value:  "Touch");
            Add(key:  "IOS", value:  "Touch");
            mem[1152921512223027800] = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        public virtual string GetCurrentSpecialization()
        {
            if(this.mSpecializations != null)
            {
                    return "Android";
            }
            
            return "Android";
        }
        public virtual string GetFallbackSpecialization(string specialization)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = this.mSpecializationsFallbacks;
            if(val_4 != null)
            {
                    return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -973455832 : "Any";
            }
            
            val_4 = this.mSpecializationsFallbacks;
            if(val_4 != null)
            {
                    return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -973455832 : "Any";
            }
            
            val_4 = 0;
            return (string)((val_4.TryGetValue(key:  specialization, value: out  0)) != true) ? -973455832 : "Any";
        }
    
    }

}
