using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXList : ArrayList
    {
        // Methods
        public PBXList()
        {
        
        }
        public PBXList(object firstValue)
        {
            int val_1 = this.Add(value:  firstValue);
        }
        public static bool op_Implicit(UnityEditor.XCodeEditor.PBXList x)
        {
            if(X1 == 0)
            {
                    return false;
            }
            
            return (bool)(X1 == 0) ? 1 : 0;
        }
        public string ToCSV()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_10 = null;
            val_10 = null;
            System.Collections.IEnumerator val_1 = this.GetEnumerator();
            label_18:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = val_1;
            if(((val_1 & 1) & 1) == 0)
            {
                goto label_27;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = val_1;
            val_13 = val_1;
            val_14 = null;
            if(val_13 == null)
            {
                goto label_14;
            }
            
            if(null == val_14)
            {
                goto label_15;
            }
            
            val_14 = null;
            label_14:
            val_13 = 0;
            label_15:
            string val_7 = 0 + 0 + System.String.Empty(0 + System.String.Empty);
            string val_8 = 0 + val_7;
            goto label_18;
            label_27:
            if(val_1 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_15 = val_1;
            }
            
            if(0 == 98)
            {
                    return val_7;
            }
            
            if(null == null)
            {
                    return val_7;
            }
            
            return val_7;
        }
        public override string ToString()
        {
            return 0 + "{" + this.ToCSV();
        }
    
    }

}
