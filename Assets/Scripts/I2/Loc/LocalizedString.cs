using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public struct LocalizedString
    {
        // Fields
        public string mTerm;
        public bool mRTL_IgnoreArabicFix;
        public int mRTL_MaxLineLength;
        public bool mRTL_ConvertNumbers;
        public bool m_DontLocalizeParameters;
        
        // Methods
        public LocalizedString(I2.Loc.LocalizedString str)
        {
            this.mRTL_ConvertNumbers = mem[str.mTerm];
            mem[1152921512321883912] = mem[str.mTerm + 8];
            mem[1152921512321883920] = str.mTerm.length;
            mem[1152921512321883916] = (mem[str.mTerm + 8]) >> 32;
            mem[1152921512321883921] = str.mTerm.length >> 8;
        }
        public static string op_Implicit(I2.Loc.LocalizedString s)
        {
            string val_3 = I2.Loc.LocalizationManager.GetTranslation(Term:  null, FixForRTL:  s.mRTL_IgnoreArabicFix, maxLineLengthForRTL:  (((s.mRTL_IgnoreArabicFix + 8) & 255) != 0) ? 1 : 0, ignoreRTLnumbers:  s.mRTL_IgnoreArabicFix + 8 + 4, applyParameters:  ((s.mRTL_IgnoreArabicFix + 16) == 0) ? 1 : 0, localParametersRoot:  1, overrideLanguage:  0);
            var val_4 = ((s.mRTL_IgnoreArabicFix + 17) == 0) ? 1 : 0;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_3, allowLocalizedParameters:  true);
            return val_3;
        }
        public static I2.Loc.LocalizedString op_Implicit(string term)
        {
            mem2[0] = ???;
            mem2[0] = 0;
            return new I2.Loc.LocalizedString() {mTerm = term, mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = false, m_DontLocalizeParameters = false};
        }
        public override string ToString()
        {
        
        }
    
    }

}
