using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class XCModFile
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <filePath>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <isWeak>k__BackingField;
        
        // Properties
        public string filePath { get; set; }
        public bool isWeak { get; set; }
        
        // Methods
        public XCModFile(string inputString)
        {
            System.Char[] val_5;
            this.<isWeak>k__BackingField = false;
            if((inputString.Contains(value:  ":")) != false)
            {
                    val_5 = null;
                typeof(System.Char[]).__il2cppRuntimeField_20 = 58;
                System.String[] val_2 = inputString.Split(separator:  val_5);
                this.<filePath>k__BackingField = val_2[0];
                this.<isWeak>k__BackingField = ((val_2[1].CompareTo(strB:  "weak")) == 0) ? 1 : 0;
                return;
            }
            
            this.<filePath>k__BackingField = inputString;
        }
        public string get_filePath()
        {
            return (string)this.<filePath>k__BackingField;
        }
        private void set_filePath(string value)
        {
            this.<filePath>k__BackingField = value;
        }
        public bool get_isWeak()
        {
            return (bool)this.<isWeak>k__BackingField;
        }
        private void set_isWeak(bool value)
        {
            this.<isWeak>k__BackingField = value;
        }
    
    }

}
