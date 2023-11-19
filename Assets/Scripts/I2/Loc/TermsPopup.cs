using UnityEngine;

namespace I2.Loc
{
    public class TermsPopup : PropertyAttribute
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Filter>k__BackingField;
        
        // Properties
        public string Filter { get; set; }
        
        // Methods
        public TermsPopup(string filter = "")
        {
            this.<Filter>k__BackingField = filter;
        }
        public string get_Filter()
        {
            return (string)this.<Filter>k__BackingField;
        }
        private void set_Filter(string value)
        {
            this.<Filter>k__BackingField = value;
        }
    
    }

}
