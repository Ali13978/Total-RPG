using UnityEngine;

namespace TMPro
{
    [Serializable]
    public class TMP_DigitValidator : TMP_InputValidator
    {
        // Methods
        public TMP_DigitValidator()
        {
        
        }
        public override char Validate(ref string text, ref int pos, char ch)
        {
            char val_1 = ch - 48;
            val_1 = val_1 & 65535;
            if(val_1 > '	')
            {
                    return 0;
            }
            
            int val_2 = pos;
            val_2 = val_2 + 1;
            pos = val_2;
            return 0;
        }
    
    }

}
