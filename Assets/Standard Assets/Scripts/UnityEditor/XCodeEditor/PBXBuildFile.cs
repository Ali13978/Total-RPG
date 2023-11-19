using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXBuildFile : PBXObject
    {
        // Fields
        private const string FILE_REF_KEY = "fileRef";
        private const string SETTINGS_KEY = "settings";
        private const string ATTRIBUTES_KEY = "ATTRIBUTES";
        private const string WEAK_VALUE = "Weak";
        private const string COMPILER_FLAGS_KEY = "COMPILER_FLAGS";
        
        // Properties
        public string fileRef { get; }
        
        // Methods
        public PBXBuildFile(UnityEditor.XCodeEditor.PBXFileReference fileRef, bool weak = False)
        {
            string val_12;
            val_1 = new UnityEditor.XCodeEditor.PBXObject();
            if(val_1 != null)
            {
                    this.Add(key:  "fileRef", obj:  val_1.guid);
                bool val_4 = this.SetWeakLink(weak:  weak);
            }
            else
            {
                    this.Add(key:  "fileRef", obj:  0.guid);
                bool val_7 = this.SetWeakLink(weak:  weak);
            }
            
            val_12 = fileRef.compilerFlags;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
            val_12 = 0;
            goto label_10;
            label_14:
            bool val_11 = this.AddCompilerFlag(flag:  fileRef.compilerFlags.Split(separator:  null)[34807808]);
            val_12 = 1;
            label_10:
            if(val_12 >= val_10.Length)
            {
                    return;
            }
            
            if(val_12 < val_10.Length)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        public PBXBuildFile(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
        
        }
        public string get_fileRef()
        {
            var val_3;
            if(this.Item["fileRef"] != null)
            {
                    if(null == null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        public bool SetWeakLink(bool weak = False)
        {
            var val_12;
            object val_13;
            string val_14;
            var val_15;
            object val_16;
            val_12 = weak;
            val_13 = this;
            if((ContainsKey(key:  "settings")) == false)
            {
                goto label_2;
            }
            
            object val_3 = Item["settings"];
            if((0.ContainsKey(key:  "ATTRIBUTES")) == false)
            {
                goto label_7;
            }
            
            object val_6 = 0.Item["ATTRIBUTES"];
            if(val_12 == false)
            {
                goto label_12;
            }
            
            goto label_13;
            label_2:
            if(val_12 == false)
            {
                    return true;
            }
            
            int val_8 = Add(value:  "Weak");
            UnityEditor.XCodeEditor.PBXDictionary val_9 = null;
            val_12 = val_9;
            val_9 = new UnityEditor.XCodeEditor.PBXDictionary();
            Add(key:  "ATTRIBUTES", value:  new UnityEditor.XCodeEditor.PBXList());
            val_14 = "settings";
            val_15 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_16 = val_12;
            goto label_18;
            label_7:
            if(val_12 == false)
            {
                    return true;
            }
            
            UnityEditor.XCodeEditor.PBXList val_10 = null;
            val_13 = val_10;
            val_10 = new UnityEditor.XCodeEditor.PBXList();
            int val_11 = Add(value:  "Weak");
            val_14 = "ATTRIBUTES";
            val_16 = val_13;
            val_15 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_18:
            0.Add(key:  val_14, value:  val_16);
            return true;
            label_12:
            label_13:
            0.Add(key:  "ATTRIBUTES", value:  0);
            this.Add(key:  "settings", obj:  0);
            return true;
        }
        public bool AddCodeSignOnCopy()
        {
            var val_11;
            var val_12;
            if((ContainsKey(key:  "settings")) != true)
            {
                    set_Item(key:  "settings", value:  new UnityEditor.XCodeEditor.PBXDictionary());
            }
            
            object val_4 = this.Item["settings"];
            val_11 = 0;
            val_12 = "ATTRIBUTES";
            if((val_11.ContainsKey(key:  "ATTRIBUTES")) != false)
            {
                    object val_7 = val_11.Item["ATTRIBUTES"];
                val_11 = 0;
                val_12 = 1;
                if(val_12 == 0)
            {
                    return true;
            }
            
                return true;
            }
            
            int val_9 = Add(value:  "CodeSignOnCopy");
            int val_10 = Add(value:  "RemoveHeadersOnCopy");
            val_11.Add(key:  "ATTRIBUTES", value:  new UnityEditor.XCodeEditor.PBXList());
            return true;
        }
        public bool AddCompilerFlag(string flag)
        {
            object val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_28 = flag;
            val_29 = 1152921508878312016;
            if((ContainsKey(key:  "settings")) != true)
            {
                    set_Item(key:  "settings", value:  new UnityEditor.XCodeEditor.PBXDictionary());
            }
            
            val_30 = Item["settings"];
            if(val_30 != null)
            {
                
            }
            
            val_30 = 0;
            val_31 = val_30.ContainsKey(key:  "COMPILER_FLAGS");
            val_32 = Item["settings"];
            if(val_32 != null)
            {
                
            }
            
            val_32 = 0;
            if(val_31 == false)
            {
                goto label_18;
            }
            
            val_33 = val_32.Item["COMPILER_FLAGS"];
            typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
            val_29 = 1152921504608284672;
            if(val_33 == null)
            {
                goto label_21;
            }
            
            if(null == null)
            {
                goto label_23;
            }
            
            goto label_24;
            label_18:
            val_32.Add(key:  "COMPILER_FLAGS", value:  val_28);
            goto label_25;
            label_21:
            label_24:
            val_33 = 0;
            label_23:
            val_31 = val_33.Split(separator:  null);
            var val_29 = 0;
            label_30:
            if(val_29 >= val_19.Length)
            {
                goto label_27;
            }
            
            val_29 = val_29 + 1;
            if((val_31[0].CompareTo(strB:  val_28)) != 0)
            {
                goto label_30;
            }
            
            val_34 = 0;
            return (bool)val_34;
            label_27:
            val_35 = this.Item["settings"];
            val_28 = 0 + System.String.Join(separator:  0, value:  " ")(System.String.Join(separator:  0, value:  " ")) + " ";
            if(val_35 != null)
            {
                
            }
            
            val_35 = 0;
            val_35.set_Item(key:  "COMPILER_FLAGS", value:  val_28);
            label_25:
            val_34 = 1;
            return (bool)val_34;
        }
    
    }

}
