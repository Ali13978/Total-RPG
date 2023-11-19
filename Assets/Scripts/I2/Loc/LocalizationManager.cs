using UnityEngine;

namespace I2.Loc
{
    public static class LocalizationManager
    {
        // Fields
        private static string mCurrentLanguage;
        private static string mLanguageCode;
        private static System.Globalization.CultureInfo mCurrentCulture;
        private static bool mChangeCultureInfo;
        public static bool IsRight2Left;
        public static bool HasJoinedWords;
        public static System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager> ParamManagers;
        private static string[] LanguagesRTL;
        public static System.Collections.Generic.List<I2.Loc.LanguageSource> Sources;
        public static string[] GlobalSources;
        private static string mCurrentDeviceLanguage;
        public static System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor> mLocalizeTargets;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static I2.Loc.LocalizationManager.OnLocalizeCallback OnLocalizeEvent;
        private static bool mLocalizeIsScheduled;
        private static bool mLocalizeIsScheduledWithForcedValue;
        public static bool HighlightLocalizedTargets;
        private static I2.Loc.LocalizationManager._GetParam <>f__am$cache0;
        
        // Properties
        public static string CurrentLanguage { get; set; }
        public static string CurrentLanguageCode { get; set; }
        public static string CurrentRegion { get; set; }
        public static string CurrentRegionCode { get; set; }
        public static System.Globalization.CultureInfo CurrentCulture { get; }
        
        // Methods
        public static void InitializeIfNeeded()
        {
            var val_5;
            string val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            val_6 = I2.Loc.LocalizationManager.mCurrentLanguage;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_7 = null;
                val_7 = null;
                val_6 = I2.Loc.LocalizationManager.Sources;
                if(val_6.Count != 0)
            {
                    return;
            }
            
            }
            
            bool val_4 = I2.Loc.LocalizationManager.UpdateSources();
            I2.Loc.LocalizationManager.SelectStartupLanguage();
        }
        public static string GetVersion()
        {
            return "2.8.8 f1";
        }
        public static int GetRequiredWebServiceVersion()
        {
            return 5;
        }
        public static string GetWebServiceURL(I2.Loc.LanguageSource source)
        {
            UnityEngine.Object val_11;
            string val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_11 = X1;
            if(0 == val_11)
            {
                goto label_3;
            }
            
            val_12 = val_11;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_7;
            }
            
            label_3:
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_11 = 0;
            goto label_10;
            label_27:
            val_11 = 1;
            label_10:
            val_13 = null;
            val_13 = null;
            if(val_11 >= I2.Loc.LocalizationManager.Sources.Count)
            {
                goto label_14;
            }
            
            val_14 = null;
            val_14 = null;
            if(0 == I2.Loc.LocalizationManager.Sources.Item[1])
            {
                goto label_27;
            }
            
            val_15 = null;
            val_15 = null;
            I2.Loc.LanguageSource val_7 = I2.Loc.LocalizationManager.Sources.Item[1];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_27;
            }
            
            val_16 = null;
            val_16 = null;
            val_11 = I2.Loc.LocalizationManager.Sources.Item[1];
            val_12 = val_10.Google_WebServiceURL;
            return (string)X1 + 48;
            label_14:
            val_17 = null;
            val_17 = null;
            return (string)X1 + 48;
            label_7:
            if(val_11 != 0)
            {
                    return (string)X1 + 48;
            }
            
            return (string)X1 + 48;
        }
        public static string get_CurrentLanguage()
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            return (string)I2.Loc.LocalizationManager.mCurrentLanguage;
        }
        public static void set_CurrentLanguage(string value)
        {
            var val_6;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((System.String.op_Inequality(a:  0, b:  I2.Loc.LocalizationManager.mCurrentLanguage)) == false)
            {
                    return;
            }
            
            string val_5 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  null);
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_5, LanguageCode:  I2.Loc.LocalizationManager.GetSupportedLanguage(Language:  null, ignoreDisabled:  X1), RememberLanguage:  val_5, Force:  true);
        }
        public static string get_CurrentLanguageCode()
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            return (string)I2.Loc.LocalizationManager.mLanguageCode;
        }
        public static void set_CurrentLanguageCode(string value)
        {
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            if((System.String.op_Inequality(a:  0, b:  I2.Loc.LocalizationManager.mLanguageCode)) == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  null, LanguageCode:  I2.Loc.LocalizationManager.GetLanguageFromCode(Code:  null, exactMatch:  X1), RememberLanguage:  X1, Force:  true);
        }
        public static string get_CurrentRegion()
        {
            var val_10;
            var val_11;
            var val_12;
            string val_1 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_10 = "/\\";
            if(("/\\") == null)
            {
                    val_10 = "/\\";
            }
            
            System.Char[] val_10 = ToCharArray();
            int val_3 = val_1.IndexOfAny(anyOf:  val_10);
            if(val_3 >= 1)
            {
                    val_10 = val_3 + 1;
                return val_1.Substring(startIndex:  val_10);
            }
            
            int val_5 = val_1.IndexOfAny(anyOf:  ToCharArray());
            val_11 = "])";
            if("])" == null)
            {
                    val_11 = "])";
            }
            
            int val_7 = val_1.LastIndexOfAny(anyOf:  ToCharArray());
            if((val_5 >= 1) && (val_7 != val_5))
            {
                    return val_1.Substring(startIndex:  val_5 + 1, length:  val_7 + (~val_5));
            }
            
            val_12 = null;
            val_12 = null;
            return (string)System.String.Empty;
        }
        public static void set_CurrentRegion(string value)
        {
            string val_12;
            var val_13;
            int val_14;
            string val_15;
            var val_16;
            val_12 = I2.Loc.LocalizationManager.CurrentLanguage;
            val_13 = "/\\";
            if(("/\\") == null)
            {
                    val_13 = "/\\";
            }
            
            System.Char[] val_12 = ToCharArray();
            val_14 = val_12.IndexOfAny(anyOf:  val_12);
            if(val_14 >= 1)
            {
                    val_12 = val_14 + 1;
                string val_5 = 0 + val_12.Substring(startIndex:  val_12)(val_12.Substring(startIndex:  val_12));
            }
            else
            {
                    val_14 = val_12.IndexOfAny(anyOf:  ToCharArray());
                val_16 = "])";
                if("])" == null)
            {
                    val_16 = "])";
            }
            
                if((val_14 >= 1) && (val_14 != (val_12.LastIndexOfAny(anyOf:  ToCharArray()))))
            {
                    val_12 = val_12.Substring(startIndex:  val_14);
            }
            
                string val_11 = 0 + val_12 + "(" + X1;
            }
            
            val_15 = null;
            I2.Loc.LocalizationManager.CurrentLanguage = val_15;
        }
        public static string get_CurrentRegionCode()
        {
            var val_4;
            var val_5;
            string val_1 = I2.Loc.LocalizationManager.CurrentLanguageCode;
            val_4 = " -_/\\";
            if((" -_/\\") == null)
            {
                    val_4 = " -_/\\";
            }
            
            System.Char[] val_4 = ToCharArray();
            int val_3 = val_1.IndexOfAny(anyOf:  val_4);
            if((val_3 & 2147483648) == 0)
            {
                    val_4 = val_3 + 1;
                return val_1.Substring(startIndex:  val_4);
            }
            
            val_5 = null;
            val_5 = null;
            return (string)System.String.Empty;
        }
        public static void set_CurrentRegionCode(string value)
        {
            string val_6;
            var val_7;
            string val_8;
            val_6 = I2.Loc.LocalizationManager.CurrentLanguageCode;
            val_7 = " -_/\\";
            if((" -_/\\") == null)
            {
                    val_7 = " -_/\\";
            }
            
            int val_3 = val_6.IndexOfAny(anyOf:  ToCharArray());
            if(val_3 >= 1)
            {
                    val_6 = val_6.Substring(startIndex:  0, length:  val_3);
            }
            
            string val_5 = 0 + val_6 + "-"("-");
            val_8 = null;
            I2.Loc.LocalizationManager.CurrentLanguageCode = val_8;
        }
        public static System.Globalization.CultureInfo get_CurrentCulture()
        {
            null = null;
            return (System.Globalization.CultureInfo)I2.Loc.LocalizationManager.mCurrentCulture;
        }
        public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = True, bool Force = False)
        {
            var val_11;
            string val_12;
            string val_13;
            var val_14;
            string val_15;
            string val_16;
            val_11 = null;
            val_11 = null;
            val_12 = I2.Loc.LocalizationManager.mCurrentLanguage;
            val_13 = 0;
            bool val_1 = System.String.op_Inequality(a:  val_13, b:  val_12);
            if(val_1 != true)
            {
                    val_14 = null;
                val_14 = null;
                val_12 = I2.Loc.LocalizationManager.mLanguageCode;
                val_13 = 0;
                if(((System.String.op_Inequality(a:  val_13, b:  val_12)) != true) && ((W4 & 1) == 0))
            {
                    return;
            }
            
            }
            
            if(Force != false)
            {
                    I2.Loc.PersistentStorage.SetSetting_String(key:  val_1, value:  "I2 Language");
            }
            
            val_15 = null;
            val_15 = null;
            I2.Loc.LocalizationManager.mCurrentLanguage = LanguageCode;
            I2.Loc.LocalizationManager.mLanguageCode = RememberLanguage;
            I2.Loc.LocalizationManager.mCurrentCulture = I2.Loc.LocalizationManager.CreateCultureForCode(code:  val_15);
            val_16 = null;
            if(I2.Loc.LocalizationManager.mChangeCultureInfo != false)
            {
                    I2.Loc.LocalizationManager.SetCurrentCultureInfo();
                val_16 = null;
            }
            
            val_16 = null;
            I2.Loc.LocalizationManager.IsRight2Left = I2.Loc.LocalizationManager.IsRTL(Code:  val_16);
            bool val_8 = I2.Loc.GoogleLanguages.LanguageCode_HasJoinedWord(languageCode:  0);
            var val_10 = W4 & 1;
            I2.Loc.LocalizationManager.HasJoinedWords = val_8;
            I2.Loc.LocalizationManager.LocalizeAll(Force:  val_8);
        }
        private static System.Globalization.CultureInfo CreateCultureForCode(string code)
        {
            return (System.Globalization.CultureInfo)System.Globalization.CultureInfo.CreateSpecificCulture(name:  0);
        }
        public static void EnableChangingCultureInfo(bool bEnable)
        {
            var val_3 = null;
            if(I2.Loc.LocalizationManager.mChangeCultureInfo != true)
            {
                    var val_1 = W1 ^ 1;
                val_1 = val_1 & 1;
                if((val_1 & 1) == 0)
            {
                    I2.Loc.LocalizationManager.SetCurrentCultureInfo();
                val_3 = null;
            }
            
            }
            
            val_3 = null;
            I2.Loc.LocalizationManager.mChangeCultureInfo = W1 & 1;
        }
        private static void SetCurrentCultureInfo()
        {
            var val_2 = null;
            System.Threading.Thread.CurrentThread.CurrentCulture = I2.Loc.LocalizationManager.mCurrentCulture;
        }
        private static void SelectStartupLanguage()
        {
            var val_24;
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_25;
            var val_26;
            string val_27;
            bool val_28;
            var val_30;
            string val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            string val_40;
            string val_41;
            val_24 = null;
            val_24 = null;
            val_25 = I2.Loc.LocalizationManager.Sources;
            val_26 = 1152921512227456208;
            if(val_25.Count == 0)
            {
                    return;
            }
            
            val_27 = null;
            val_27 = null;
            string val_2 = I2.Loc.PersistentStorage.GetSetting_String(key:  val_27, defaultValue:  "I2 Language");
            val_28 = I2.Loc.LocalizationManager.GetCurrentDeviceLanguage();
            if(((System.String.IsNullOrEmpty(value:  0)) == true) || ((I2.Loc.LocalizationManager.HasLanguage(Language:  null, AllowDiscartingRegion:  val_2, Initialize:  true, SkipDisabled:  false)) == false))
            {
                goto label_12;
            }
            
            string val_7 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  null);
            val_30 = 1;
            val_31 = val_2;
            goto label_15;
            label_12:
            val_32 = null;
            val_32 = null;
            I2.Loc.LanguageSource val_8 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_8.IgnoreDeviceLanguage == true)
            {
                goto label_20;
            }
            
            val_28 = I2.Loc.LocalizationManager.GetSupportedLanguage(Language:  null, ignoreDisabled:  val_28);
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_25;
            }
            
            label_20:
            val_33 = null;
            val_33 = null;
            val_25 = I2.Loc.LocalizationManager.Sources;
            val_34 = val_25.Count;
            if(val_34 < 1)
            {
                    return;
            }
            
            label_51:
            val_35 = null;
            val_35 = null;
            I2.Loc.LanguageSource val_13 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_13.mLanguages.Count < 1)
            {
                goto label_42;
            }
            
            val_36 = 0;
            goto label_36;
            label_49:
            val_36 = 1;
            label_36:
            val_37 = null;
            val_37 = null;
            I2.Loc.LanguageSource val_15 = I2.Loc.LocalizationManager.Sources.Item[0];
            if(val_36 >= val_15.mLanguages.Count)
            {
                goto label_42;
            }
            
            val_38 = null;
            val_38 = null;
            I2.Loc.LanguageSource val_17 = I2.Loc.LocalizationManager.Sources.Item[0];
            I2.Loc.LanguageData val_18 = val_17.mLanguages.Item[1];
            byte val_24 = val_18.Flags;
            val_24 = val_24 & 1;
            if((val_24 & 1) != 0)
            {
                goto label_49;
            }
            
            goto label_50;
            label_42:
            val_25 = 0 + 1;
            if(val_25 < val_34)
            {
                goto label_51;
            }
            
            return;
            label_50:
            val_39 = null;
            val_39 = null;
            I2.Loc.LanguageSource val_19 = I2.Loc.LocalizationManager.Sources.Item[0];
            I2.Loc.LanguageData val_20 = val_19.mLanguages.Item[1];
            val_40 = val_20.Name;
            I2.Loc.LanguageSource val_21 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_28 = val_21.mLanguages.Item[1];
            val_41 = val_22.Code;
            val_30 = 0;
            val_31 = val_40;
            goto label_62;
            label_25:
            string val_23 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  null);
            val_30 = 0;
            val_31 = val_28;
            label_15:
            val_41 = val_23;
            label_62:
            I2.Loc.LocalizationManager.SetLanguageAndCode(LanguageName:  val_23, LanguageCode:  val_31, RememberLanguage:  val_41, Force:  false);
        }
        public static bool HasLanguage(string Language, bool AllowDiscartingRegion = True, bool Initialize = True, bool SkipDisabled = True)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = Initialize;
            if(SkipDisabled != false)
            {
                    I2.Loc.LocalizationManager.InitializeIfNeeded();
            }
            
            val_10 = null;
            val_10 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 < 1)
            {
                goto label_7;
            }
            
            var val_9 = 0;
            label_13:
            val_11 = null;
            val_11 = null;
            if(((I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  AllowDiscartingRegion, AllowDiscartingRegion:  false, SkipDisabled:  W4 & 1)) & 2147483648) == 0)
            {
                goto label_12;
            }
            
            val_9 = val_9 + 1;
            if(val_9 < val_1)
            {
                goto label_13;
            }
            
            label_7:
            if(val_9 != false)
            {
                    val_12 = null;
                val_12 = null;
                val_9 = I2.Loc.LocalizationManager.Sources.Count;
                val_13 = 0;
                if(val_9 < 1)
            {
                    return (bool)val_13;
            }
            
                var val_10 = 0;
                do
            {
                val_14 = null;
                val_14 = null;
                val_13 = 1;
                if(((I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  AllowDiscartingRegion, AllowDiscartingRegion:  true, SkipDisabled:  W4 & 1)) & 2147483648) == 0)
            {
                    return (bool)val_13;
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < val_9);
            
            }
            
            val_13 = 0;
            return (bool)val_13;
            label_12:
            val_13 = 1;
            return (bool)val_13;
        }
        public static string GetSupportedLanguage(string Language, bool ignoreDisabled = False)
        {
            var val_27;
            string val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_34;
            var val_35;
            int val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            string val_46;
            var val_47;
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_48;
            var val_49;
            var val_50;
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_51;
            var val_52;
            var val_53;
            int val_54;
            var val_55;
            var val_56;
            val_27 = W2;
            val_28 = I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  0, ShowWarnings:  ignoreDisabled);
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_19;
            }
            
            val_29 = null;
            val_29 = null;
            val_30 = 1152921512227456208;
            val_31 = null;
            val_32 = I2.Loc.LocalizationManager.Sources.Count;
            var val_5 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_10A & 1) != 0) ? 1 : 0;
            if(val_32 < 1)
            {
                goto label_9;
            }
            
            val_34 = 0;
            label_15:
            val_5 = val_5 & 1;
            val_35 = null;
            val_36 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  val_28, exactMatch:  true, ignoreDisabled:  val_27 & 1);
            if((val_36 & 2147483648) == 0)
            {
                goto label_14;
            }
            
            val_37 = null;
            val_34 = val_34 + 1;
            var val_9 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_10A & 1) != 0) ? 1 : 0;
            if(val_34 < val_32)
            {
                goto label_15;
            }
            
            label_9:
            val_37 = null;
            val_32 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_32 < 1)
            {
                goto label_19;
            }
            
            val_30 = 1152921512260140112;
            val_34 = 0;
            label_25:
            val_38 = null;
            val_38 = null;
            val_36 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  val_28, exactMatch:  false, ignoreDisabled:  val_27 & 1);
            if((val_36 & 2147483648) == 0)
            {
                goto label_24;
            }
            
            val_34 = val_34 + 1;
            if(val_34 < val_32)
            {
                goto label_25;
            }
            
            label_19:
            val_39 = null;
            val_39 = null;
            int val_14 = I2.Loc.LocalizationManager.Sources.Count;
            val_40 = null;
            var val_15 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_10A & 1) != 0) ? 1 : 0;
            if(val_14 < 1)
            {
                goto label_29;
            }
            
            val_30 = 1152921512260140112;
            val_28 = 0;
            label_35:
            val_15 = val_15 & 1;
            val_42 = null;
            val_32 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  ignoreDisabled, AllowDiscartingRegion:  false, SkipDisabled:  val_27 & 1);
            if((val_32 & 2147483648) == 0)
            {
                goto label_34;
            }
            
            val_43 = null;
            val_28 = val_28 + 1;
            var val_19 = ((I2.Loc.LocalizationManager.__il2cppRuntimeField_10A & 1) != 0) ? 1 : 0;
            if(val_28 < val_14)
            {
                goto label_35;
            }
            
            label_29:
            val_43 = null;
            val_28 = I2.Loc.LocalizationManager.Sources;
            int val_20 = val_28.Count;
            if(val_20 < 1)
            {
                goto label_39;
            }
            
            val_28 = 0;
            label_45:
            val_44 = null;
            val_44 = null;
            val_32 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  ignoreDisabled, AllowDiscartingRegion:  true, SkipDisabled:  val_27 & 1);
            if((val_32 & 2147483648) == 0)
            {
                goto label_44;
            }
            
            val_28 = val_28 + 1;
            if(val_28 < val_20)
            {
                goto label_45;
            }
            
            label_39:
            val_45 = null;
            val_45 = null;
            return (string)mem[val_26.Name];
            label_34:
            val_47 = null;
            val_47 = null;
            val_48 = I2.Loc.LocalizationManager.Sources;
            val_49 = public I2.Loc.LanguageSource System.Collections.Generic.List<I2.Loc.LanguageSource>::get_Item(int index);
            goto label_52;
            label_14:
            val_50 = null;
            val_50 = null;
            val_51 = I2.Loc.LocalizationManager.Sources;
            val_52 = public I2.Loc.LanguageSource System.Collections.Generic.List<I2.Loc.LanguageSource>::get_Item(int index);
            goto label_56;
            label_44:
            val_53 = null;
            val_53 = null;
            val_48 = I2.Loc.LocalizationManager.Sources;
            val_49 = public I2.Loc.LanguageSource System.Collections.Generic.List<I2.Loc.LanguageSource>::get_Item(int index);
            label_52:
            I2.Loc.LanguageSource val_24 = val_48.Item[0];
            val_54 = val_32;
            val_55 = public I2.Loc.LanguageData System.Collections.Generic.List<I2.Loc.LanguageData>::get_Item(int index);
            goto label_62;
            label_24:
            val_56 = null;
            val_56 = null;
            val_51 = I2.Loc.LocalizationManager.Sources;
            val_52 = public I2.Loc.LanguageSource System.Collections.Generic.List<I2.Loc.LanguageSource>::get_Item(int index);
            label_56:
            I2.Loc.LanguageSource val_25 = val_51.Item[0];
            val_54 = val_36;
            val_55 = public I2.Loc.LanguageData System.Collections.Generic.List<I2.Loc.LanguageData>::get_Item(int index);
            label_62:
            val_27 = val_25.mLanguages.Item[val_54];
            val_46 = val_26.Name;
            return (string)mem[val_26.Name];
        }
        public static string GetLanguageCode(string Language)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            string val_13;
            var val_14;
            val_8 = null;
            val_8 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            val_9 = null;
            val_9 = null;
            int val_3 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_3 < 1)
            {
                goto label_10;
            }
            
            var val_8 = 0;
            label_16:
            val_10 = null;
            val_10 = null;
            int val_5 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  X1, AllowDiscartingRegion:  true, SkipDisabled:  true);
            if((val_5 & 2147483648) == 0)
            {
                goto label_15;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < val_3)
            {
                goto label_16;
            }
            
            label_10:
            val_11 = 1152921504608284672;
            val_12 = null;
            val_12 = null;
            return (string)mem[val_7.Code];
            label_15:
            val_14 = null;
            val_14 = null;
            I2.Loc.LanguageSource val_6 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_11 = val_6.mLanguages.Item[val_5];
            val_13 = val_7.Code;
            return (string)mem[val_7.Code];
        }
        public static string GetLanguageFromCode(string Code, bool exactMatch = True)
        {
            var val_8;
            var val_9;
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_10;
            var val_11;
            var val_12;
            var val_13;
            string val_14;
            var val_15;
            bool val_8 = W2;
            val_8 = null;
            val_8 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            val_9 = null;
            val_9 = null;
            val_10 = I2.Loc.LocalizationManager.Sources;
            int val_3 = val_10.Count;
            if(val_3 < 1)
            {
                goto label_10;
            }
            
            val_10 = 0;
            val_8 = val_8 & 1;
            label_16:
            val_11 = null;
            val_11 = null;
            int val_5 = I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndexFromCode(Code:  exactMatch, exactMatch:  val_8, ignoreDisabled:  false);
            if((val_5 & 2147483648) == 0)
            {
                goto label_15;
            }
            
            val_10 = val_10 + 1;
            if(val_10 < val_3)
            {
                goto label_16;
            }
            
            label_10:
            val_12 = 1152921504608284672;
            val_13 = null;
            val_13 = null;
            return (string)mem[val_7.Name];
            label_15:
            val_15 = null;
            val_15 = null;
            I2.Loc.LanguageSource val_6 = I2.Loc.LocalizationManager.Sources.Item[0];
            val_12 = val_6.mLanguages.Item[val_5];
            val_14 = val_7.Name;
            return (string)mem[val_7.Name];
        }
        public static System.Collections.Generic.List<string> GetAllLanguages(bool SkipDisabled = True)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            bool val_10 = W1;
            val_10 = null;
            val_10 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_3 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            typeof(LocalizationManager.<GetAllLanguages>c__AnonStorey2).__il2cppRuntimeField_10 = new System.Collections.Generic.List<System.String>();
            val_11 = null;
            val_11 = null;
            val_12 = 0;
            val_10 = val_10 & 1;
            goto label_11;
            label_19:
            X23.AddRange(collection:  X24);
            val_12 = 1;
            label_11:
            if(val_12 >= I2.Loc.LocalizationManager.Sources.Count)
            {
                    return (System.Collections.Generic.List<System.String>)typeof(LocalizationManager.<GetAllLanguages>c__AnonStorey2).__il2cppRuntimeField_10;
            }
            
            val_13 = null;
            val_13 = null;
            System.Func<System.String, System.Boolean> val_8 = new System.Func<System.String, System.Boolean>(object:  new System.Object(), method:  System.Boolean LocalizationManager.<GetAllLanguages>c__AnonStorey2::<>m__0(string x));
            System.Collections.Generic.IEnumerable<TSource> val_9 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  I2.Loc.LocalizationManager.Sources.Item[1].GetLanguages(skipDisabled:  val_10));
            if(null != 0)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        public static System.Collections.Generic.List<string> GetAllLanguagesCode(bool allowRegions = True, bool SkipDisabled = True)
        {
            var val_9;
            var val_10;
            var val_11;
            bool val_9 = W2;
            typeof(LocalizationManager.<GetAllLanguagesCode>c__AnonStorey3).__il2cppRuntimeField_10 = new System.Collections.Generic.List<System.String>();
            val_9 = null;
            val_9 = null;
            val_10 = 0;
            val_9 = val_9 & 1;
            goto label_5;
            label_13:
            X24.AddRange(collection:  X25);
            val_10 = 1;
            label_5:
            if(val_10 >= I2.Loc.LocalizationManager.Sources.Count)
            {
                    return (System.Collections.Generic.List<System.String>)typeof(LocalizationManager.<GetAllLanguagesCode>c__AnonStorey3).__il2cppRuntimeField_10;
            }
            
            val_11 = null;
            val_11 = null;
            System.Func<System.String, System.Boolean> val_7 = new System.Func<System.String, System.Boolean>(object:  new System.Object(), method:  System.Boolean LocalizationManager.<GetAllLanguagesCode>c__AnonStorey3::<>m__0(string x));
            System.Collections.Generic.IEnumerable<TSource> val_8 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  I2.Loc.LocalizationManager.Sources.Item[1].GetLanguagesCode(allowRegions:  SkipDisabled, skipDisabled:  val_9));
            if(null != 0)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        public static bool IsLanguageEnabled(string Language)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 < 1)
            {
                goto label_4;
            }
            
            val_5 = 0;
            label_10:
            val_6 = null;
            val_6 = null;
            if((I2.Loc.LocalizationManager.Sources.Item[0].IsLanguageEnabled(Language:  X1)) == false)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_10;
            }
            
            label_4:
            val_7 = 1;
            return (bool)val_7;
            label_9:
            val_7 = 0;
            return (bool)val_7;
        }
        private static void LoadCurrentLanguage()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 0;
            goto label_2;
            label_13:
            X21.LoadLanguage(languageIndex:  34807808, UnloadOtherLanguages:  true, useFallback:  true, onlyCurrentSpecialization:  true, forceLoad:  false);
            val_5 = 1;
            label_2:
            val_6 = null;
            val_6 = null;
            if(val_5 >= I2.Loc.LocalizationManager.Sources.Count)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            int val_3 = I2.Loc.LocalizationManager.Sources.Item[1].GetLanguageIndex(language:  I2.Loc.LocalizationManager.mCurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  false);
            if(I2.Loc.LocalizationManager.Sources.Item[1] != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        public static void PreviewLanguage(string NewLanguage)
        {
            null = null;
            I2.Loc.LocalizationManager.mCurrentLanguage = X1;
            string val_1 = I2.Loc.LocalizationManager.GetLanguageCode(Language:  null);
            I2.Loc.LocalizationManager.mLanguageCode = val_1;
            I2.Loc.LocalizationManager.IsRight2Left = I2.Loc.LocalizationManager.IsRTL(Code:  val_1);
            I2.Loc.LocalizationManager.HasJoinedWords = I2.Loc.GoogleLanguages.LanguageCode_HasJoinedWord(languageCode:  0);
        }
        public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = True)
        {
            _GetParam val_3;
            string val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((I2.Loc.LocalizationManager.<>f__am$cache0) == null)
            {
                    val_3 = null;
                typeof(LocalizationManager._GetParam).__il2cppRuntimeField_20 = 0;
                typeof(LocalizationManager._GetParam).__il2cppRuntimeField_28 = static System.Object I2.Loc.LocalizationManager::<ApplyLocalizationParams>m__0(string p);
                typeof(LocalizationManager._GetParam).__il2cppRuntimeField_10 = static System.Object I2.Loc.LocalizationManager::<ApplyLocalizationParams>m__0(string p);
                val_5 = null;
                val_5 = null;
                I2.Loc.LocalizationManager.<>f__am$cache0 = val_3;
                val_4 = null;
            }
            
            val_4 = null;
            var val_1 = W2 & 1;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_4, getParam:  allowLocalizedParameters, allowLocalizedParameters:  false);
        }
        public static void ApplyLocalizationParams(ref string translation, UnityEngine.GameObject root, bool allowLocalizedParameters = True)
        {
            typeof(LocalizationManager.<ApplyLocalizationParams>c__AnonStorey4).__il2cppRuntimeField_10 = allowLocalizedParameters;
            typeof(LocalizationManager._GetParam).__il2cppRuntimeField_20 = new System.Object();
            typeof(LocalizationManager._GetParam).__il2cppRuntimeField_28 = System.Object LocalizationManager.<ApplyLocalizationParams>c__AnonStorey4::<>m__0(string p);
            typeof(LocalizationManager._GetParam).__il2cppRuntimeField_10 = System.Object LocalizationManager.<ApplyLocalizationParams>c__AnonStorey4::<>m__0(string p);
            var val_2 = W3 & 1;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  null, getParam:  root, allowLocalizedParameters:  false);
        }
        public static void ApplyLocalizationParams(ref string translation, System.Collections.Generic.Dictionary<string, object> parameters, bool allowLocalizedParameters = True)
        {
            typeof(LocalizationManager.<ApplyLocalizationParams>c__AnonStorey5).__il2cppRuntimeField_10 = allowLocalizedParameters;
            typeof(LocalizationManager._GetParam).__il2cppRuntimeField_20 = new System.Object();
            typeof(LocalizationManager._GetParam).__il2cppRuntimeField_28 = System.Object LocalizationManager.<ApplyLocalizationParams>c__AnonStorey5::<>m__0(string p);
            typeof(LocalizationManager._GetParam).__il2cppRuntimeField_10 = System.Object LocalizationManager.<ApplyLocalizationParams>c__AnonStorey5::<>m__0(string p);
            var val_2 = W3 & 1;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  null, getParam:  parameters, allowLocalizedParameters:  false);
        }
        public static void ApplyLocalizationParams(ref string translation, I2.Loc.LocalizationManager._GetParam getParam, bool allowLocalizedParameters = True)
        {
            var val_39;
            var val_40;
            var val_41;
            I2.Loc.LanguageSource val_42;
            var val_43;
            string val_44;
            var val_45;
            var val_46;
            val_39 = allowLocalizedParameters;
            if(null == null)
            {
                    return;
            }
            
            int val_1 = 1152921504966963200.Length;
            val_40 = 0;
            goto label_17;
            label_38:
            int val_2 = 1152921504966963200.IndexOf(value:  "{[", startIndex:  0);
            if((val_2 & 2147483648) != 0)
            {
                goto label_18;
            }
            
            int val_3 = 1152921504966963200.IndexOf(value:  "]}", startIndex:  val_2);
            if((val_3 & 2147483648) != 0)
            {
                goto label_18;
            }
            
            val_41 = 1152921504966963200.IndexOf(value:  "{[", startIndex:  val_2 + 1);
            if(val_41 >= 1)
            {
                    if(val_41 < val_3)
            {
                goto label_36;
            }
            
            }
            
            int val_6 = val_2 + 2;
            var val_9 = ((1152921504966963200.Chars[val_6] & 65535) == '#') ? (2 + 1) : 2;
            int val_10 = val_3 - val_2;
            val_6 = val_9 + val_2;
            val_42 = val_39.Invoke(param:  1152921504966963200.Substring(startIndex:  val_6, length:  val_10 - val_9));
            if(val_42 == null)
            {
                goto label_15;
            }
            
            if(null == null)
            {
                goto label_14;
            }
            
            goto label_15;
            label_14:
            if(((???) & 1) != 0)
            {
                goto label_16;
            }
            
            label_15:
            val_43 = val_3 + 2;
            label_36:
            if((val_43 & 2147483648) == 0)
            {
                goto label_17;
            }
            
            goto label_18;
            label_16:
            I2.Loc.TermData val_16 = I2.Loc.LocalizationManager.GetTermData(term:  null, source: out  val_42);
            if(val_16 != null)
            {
                    val_44 = I2.Loc.LocalizationManager.CurrentLanguage;
                if(0 == 0)
            {
                    val_44 = val_44;
            }
            
                int val_18 = 0.GetLanguageIndex(language:  val_44, AllowDiscartingRegion:  true, SkipDisabled:  true);
                if((val_18 & 2147483648) == 0)
            {
                    val_42 = val_16.GetTranslation(idx:  val_18, specialization:  0, editMode:  false);
            }
            
            }
            
            mem2[0] = 1152921504966963200.Replace(oldValue:  1152921504966963200.Substring(startIndex:  val_2, length:  val_10 + 2), newValue:  val_42);
            if((System.Int32.TryParse(s:  0, result: out  val_42)) != false)
            {
                    string val_27 = I2.Loc.GoogleLanguages.GetPluralType(langCode:  0, n:  I2.Loc.LocalizationManager.CurrentLanguageCode).ToString();
                UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            }
            
            val_42 = val_42.Length + val_2;
            goto label_36;
            label_17:
            if(val_40 < 1152921504966963200.Length)
            {
                goto label_38;
            }
            
            label_18:
            if(0 == 0)
            {
                    return;
            }
            
            val_45 = "[i2p_";
            string val_31 = 0 + "[i2p_" + 0;
            int val_32 = 1152921504966963200.IndexOf(value:  val_31, comparisonType:  5);
            if((val_32 & 2147483648) == 0)
            {
                    val_46 = val_31.Length + val_32;
            }
            else
            {
                    val_46 = 0;
            }
            
            val_39 = 1152921504966963200.IndexOf(value:  "[i2p_", startIndex:  val_46 + 1, comparisonType:  5);
            if((val_39 & 2147483648) != 0)
            {
                    val_39 = 1152921504966963200.Length;
            }
            
            mem2[0] = 1152921504966963200.Substring(startIndex:  0, length:  val_39 - val_46);
        }
        internal static string GetLocalizationParam(string ParamName, UnityEngine.GameObject root)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_9 = 0;
            if(((UnityEngine.Object.op_Implicit(exists:  0)) == false) || (val_2.Length < 1))
            {
                goto label_6;
            }
            
            val_10 = 1152921504968986624;
            val_11 = 0;
            label_18:
            val_8 = X2.GetComponents<UnityEngine.MonoBehaviour>()[val_11];
            if((val_8 == 0) || ((val_2[0x0] + 32.enabled) == false))
            {
                goto label_12;
            }
            
            var val_10 = val_8;
            if((val_2[0x0][0] + 258) == 0)
            {
                goto label_13;
            }
            
            var val_8 = val_2[0x0][0] + 152;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_15:
            if(((val_2[0x0][0] + 152 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (val_2[0x0][0] + 258))
            {
                goto label_15;
            }
            
            label_13:
            val_9 = 0;
            val_12 = val_8;
            goto label_16;
            label_14:
            val_10 = val_10 + (((val_2[0x0][0] + 152 + 8)) << 4);
            val_12 = val_10 + 272;
            label_16:
            val_13 = val_8;
            if(val_13 != 0)
            {
                    return (string)val_13;
            }
            
            label_12:
            val_11 = val_11 + 1;
            if(val_11 < (long)val_2.Length)
            {
                goto label_18;
            }
            
            label_6:
            val_11 = 1152921504966909952;
            val_14 = null;
            val_14 = null;
            int val_4 = I2.Loc.LocalizationManager.ParamManagers.Count;
            if(val_4 >= 1)
            {
                    val_10 = 1152921504968986624;
                val_8 = 0;
                do
            {
                val_15 = null;
                val_15 = null;
                val_16 = public I2.Loc.ILocalizationParamsManager System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager>::get_Item(int index);
                I2.Loc.ILocalizationParamsManager val_5 = I2.Loc.LocalizationManager.ParamManagers.Item[0];
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_16 = 0;
                val_17 = val_5;
                val_13 = val_5;
                if(val_13 != null)
            {
                    return (string)val_13;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_4);
            
            }
            
            val_13 = 0;
            return (string)val_13;
        }
        private static string GetPluralType(System.Text.RegularExpressions.MatchCollection matches, string langCode, I2.Loc.LocalizationManager._GetParam getParam)
        {
            int val_13;
            var val_14;
            val_13 = getParam;
            int val_1 = langCode.Count;
            val_14 = 0;
            if(val_1 < 1)
            {
                    return (string)val_14;
            }
            
            var val_13 = 0;
            label_14:
            object val_6 = X3.Invoke(param:  langCode.Item[langCode.Count - 1].Value);
            if(val_6 == null)
            {
                goto label_12;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            goto label_12;
            label_11:
            if((System.Int32.TryParse(s:  0, result: out  val_6)) == true)
            {
                goto label_13;
            }
            
            label_12:
            val_13 = val_13 + 1;
            if(val_13 < val_1)
            {
                goto label_14;
            }
            
            val_14 = 0;
            return (string)val_14;
            label_13:
            I2.Loc.ePluralType val_10 = I2.Loc.GoogleLanguages.GetPluralType(langCode:  0, n:  val_13);
            val_13 = val_10;
            val_14 = val_10.ToString();
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (string)val_14;
        }
        public static string ApplyRTLfix(string line)
        {
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  null, maxCharacters:  X1, ignoreNumbers:  false);
        }
        public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
        {
            var val_47;
            var val_48;
            int val_49;
            string val_50;
            var val_51;
            var val_52;
            int val_53;
            int val_54;
            val_47 = W3;
            val_48 = maxCharacters;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (string)val_48;
            }
            
            char val_4 = val_48.Chars[0] & 65535;
            if(val_4 <= ('?'))
            {
                    val_4 = 1 << val_4;
                val_4 = val_4 & (-9223301659520663552);
                if(val_4 != 0)
            {
                    val_49 = 0 + val_48.Substring(startIndex:  1)(val_48.Substring(startIndex:  1));
            }
            
            }
            
            int val_9 = 0;
            null = new System.Collections.Generic.List<System.String>();
            if((I2.Loc.I2Utils.FindNextTag(line:  null, iStart:  val_49, tagStart: out  0, tagEnd: out  val_9)) != false)
            {
                    val_47 = 1152921504608231424;
                do
            {
                Add(item:  val_49.Substring(startIndex:  0, length:  (1 - val_9) + 0));
                if(val_49 != null)
            {
                    val_50 = val_49.Substring(startIndex:  0, length:  0);
            }
            else
            {
                    val_50 = 0.Substring(startIndex:  0, length:  0);
            }
            
                string val_20 = val_49.Substring(startIndex:  0 + 1);
                string val_21 = 0 + val_50 + 0 + "@@" + Count + 40000(Count + 40000)(0 + "@@" + Count + 40000(Count + 40000));
                val_49 = val_21;
            }
            while((I2.Loc.I2Utils.FindNextTag(line:  val_21, iStart:  val_49, tagStart: out  val_9 + 5, tagEnd: out  val_9)) == true);
            
            }
            
            string val_25 = val_49.Replace(oldValue:  "\r\n", newValue:  "\n");
            string val_26 = I2.Loc.I2Utils.SplitLine(line:  val_25, maxCharacters:  val_25);
            var val_27 = (~val_47) & 1;
            val_51 = I2.Loc.RTLFixer.Fix(str:  val_26, showTashkeel:  val_26, useHinduNumbers:  true);
            val_52 = 0;
            goto label_20;
            label_47:
            val_52 = 1;
            label_20:
            if(val_52 >= Count)
            {
                    return (string)val_48;
            }
            
            int val_30 = val_51.Length;
            if(val_30 < 1)
            {
                goto label_47;
            }
            
            label_36:
            if((val_51.Chars[0] & 65535) != '@')
            {
                goto label_26;
            }
            
            val_53 = 0 + 1;
            if((val_51.Chars[val_53] & 65535) != '@')
            {
                goto label_34;
            }
            
            int val_35 = 0 + 2;
            if(((((uint)(val_51.Chars[val_35] >> 6) & 1023) < 625) || (((val_51.Chars[0 + 3]) & 65535) != '@')) || (((val_51.Chars[0 + 4]) & 65535) != '@'))
            {
                goto label_34;
            }
            
            goto label_35;
            label_26:
            val_53 = 0 + 1;
            label_34:
            if(val_53 < val_30)
            {
                goto label_36;
            }
            
            goto label_47;
            label_35:
            char val_43 = val_51.Chars[val_35];
            char val_44 = val_43 & 65535;
            val_44 = 2 & (~(val_44 << 1));
            val_44 = val_44 + val_43;
            val_54 = val_44 + 40000;
            if(val_54 >= Count)
            {
                    val_54 = Count - 1;
            }
            
            string val_50 = val_51.Substring(startIndex:  0 + 5);
            string val_51 = 0 + val_51.Substring(startIndex:  0, length:  0)(val_51.Substring(startIndex:  0, length:  0)) + Item[val_54];
            goto label_47;
        }
        public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = False)
        {
            null = null;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return (string)maxCharacters;
            }
            
            var val_1 = W3 & 1;
            return I2.Loc.LocalizationManager.ApplyRTLfix(line:  null, maxCharacters:  maxCharacters, ignoreNumbers:  ignoreNumber);
        }
        public static bool IsRTL(string Code)
        {
            null = null;
            return (bool)((System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  I2.Loc.LocalizationManager.LanguagesRTL)) >= 0) ? 1 : 0;
        }
        public static bool UpdateSources()
        {
            I2.Loc.LocalizationManager.UnregisterDeletededSources();
            I2.Loc.LocalizationManager.RegisterSourceInResources();
            I2.Loc.LocalizationManager.RegisterSceneSources();
            return (bool)(I2.Loc.LocalizationManager.Sources.Count > 0) ? 1 : 0;
        }
        private static void UnregisterDeletededSources()
        {
            var val_6;
            int val_7;
            var val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            val_7 = I2.Loc.LocalizationManager.Sources.Count - 1;
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_8 = null;
                val_8 = null;
                if(0 == I2.Loc.LocalizationManager.Sources.Item[val_7])
            {
                    val_9 = null;
                val_9 = null;
                I2.Loc.LocalizationManager.RemoveSource(Source:  I2.Loc.LocalizationManager.Sources.Item[val_7]);
            }
            
                val_7 = val_7 - 1;
            }
            while((val_7 & 2147483648) == 0);
        
        }
        private static void RegisterSceneSources()
        {
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_6 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  0);
            if(val_6 == null)
            {
                goto label_3;
            }
            
            val_7 = val_6;
            if(val_7 == null)
            {
                goto label_4;
            }
            
            val_8 = 0;
            val_9 = val_7;
            goto label_5;
            label_4:
            label_3:
            val_7 = 0;
            val_9 = 0;
            val_8 = 1;
            label_5:
            if(7254272 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            var val_4 = val_7 + 32;
            do
            {
                val_10 = null;
                val_10 = null;
                val_6 = I2.Loc.LocalizationManager.Sources;
                if((val_6.Contains(item:  (val_7 + 32) + 0)) != true)
            {
                    val_6 = mem[(val_7 + 32) + 0];
                val_6 = (val_7 + 32) + 0;
                I2.Loc.LocalizationManager.AddSource(Source:  null);
            }
            
                val_7 = val_7 + 1;
            }
            while(7254272 != val_7);
        
        }
        private static void RegisterSourceInResources()
        {
            var val_8;
            var val_9;
            I2.Loc.LanguageSource val_10;
            var val_11;
            val_8 = null;
            val_8 = null;
            val_9 = 0;
            goto label_3;
            label_22:
            val_9 = 1;
            label_3:
            if(val_9 >= I2.Loc.LocalizationManager.GlobalSources.Length)
            {
                    return;
            }
            
            val_10 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_10 = I2.Loc.ResourceManager.pInstance.GetAsset<UnityEngine.GameObject>(Name:  I2.Loc.LocalizationManager.GlobalSources.Length + 32).GetComponent<I2.Loc.LanguageSource>();
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_22;
            }
            
            val_11 = null;
            val_11 = null;
            if((I2.Loc.LocalizationManager.Sources.Contains(item:  val_10)) == true)
            {
                goto label_22;
            }
            
            val_4.mIsGlobalSource = true;
            I2.Loc.LocalizationManager.AddSource(Source:  null);
            goto label_22;
        }
        internal static void AddSource(I2.Loc.LanguageSource Source)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = 1152921504966909952;
            val_10 = null;
            val_10 = null;
            if((I2.Loc.LocalizationManager.Sources.Contains(item:  X1)) == true)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            I2.Loc.LocalizationManager.Sources.Add(item:  X1);
            if((X1.HasGoogleSpreadsheet() != false) && ((X1 + 80) != 1))
            {
                    X1.Import_Google_FromCache();
                if((X1 + 88) > 0f)
            {
                    System.Collections.IEnumerator val_4 = I2.Loc.LocalizationManager.Delayed_Import_Google(source:  null, delay:  X1 + 88, justCheck:  X1);
                UnityEngine.Coroutine val_5 = I2.Loc.CoroutineManager.Start(coroutine:  0);
            }
            else
            {
                    X1.Import_Google(ForceUpdate:  false, justCheck:  false);
            }
            
            }
            
            val_12 = 0;
            goto label_16;
            label_22:
            bool val_9 = static_value_020F68E8;
            val_12 = 1;
            val_9 = val_9 & 251;
            label_16:
            val_9 = System.Linq.Enumerable.Count<I2.Loc.LanguageData>(source:  0);
            if(val_12 >= val_9)
            {
                goto label_19;
            }
            
            if((X1 + 104.Item[1]) != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_19:
            if((X1 + 136.Count) != 0)
            {
                    return;
            }
            
            X1.UpdateDictionary(force:  true);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private static System.Collections.IEnumerator Delayed_Import_Google(I2.Loc.LanguageSource source, float delay, bool justCheck)
        {
            if(null != 0)
            {
                    typeof(LocalizationManager.<Delayed_Import_Google>c__Iterator0).__il2cppRuntimeField_10 = delay;
                typeof(LocalizationManager.<Delayed_Import_Google>c__Iterator0).__il2cppRuntimeField_18 = justCheck;
            }
            else
            {
                    mem[16] = delay;
                mem[24] = justCheck;
            }
            
            typeof(LocalizationManager.<Delayed_Import_Google>c__Iterator0).__il2cppRuntimeField_20 = W2 & 1;
            return (System.Collections.IEnumerator)new System.Object();
        }
        internal static void RemoveSource(I2.Loc.LanguageSource Source)
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.Sources.Remove(item:  X1);
        }
        public static bool IsGlobalSource(string SourceName)
        {
            null = null;
            return (bool)((System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  I2.Loc.LocalizationManager.GlobalSources)) >= 0) ? 1 : 0;
        }
        public static I2.Loc.LanguageSource GetSourceContaining(string term, bool fallbackToFirst = True)
        {
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_8;
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_9 = W2;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_7;
            }
            
            val_10 = null;
            val_10 = null;
            val_8 = I2.Loc.LocalizationManager.Sources;
            int val_3 = val_8.Count;
            if(val_3 < 1)
            {
                goto label_7;
            }
            
            val_8 = 0;
            label_13:
            val_11 = null;
            val_11 = null;
            if((I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  fallbackToFirst, allowCategoryMistmatch:  false)) != null)
            {
                goto label_12;
            }
            
            val_8 = val_8 + 1;
            if(val_8 < val_3)
            {
                goto label_13;
            }
            
            label_7:
            if((val_9 & 1) != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_9 = I2.Loc.LocalizationManager.Sources;
                if(val_9.Count >= 1)
            {
                    val_13 = null;
                val_13 = null;
                val_9 = I2.Loc.LocalizationManager.Sources;
                val_14 = 0;
                val_15 = public I2.Loc.LanguageSource System.Collections.Generic.List<I2.Loc.LanguageSource>::get_Item(int index);
                return (I2.Loc.LanguageSource)val_9.Item[0];
            }
            
            }
            
            val_16 = 0;
            return (I2.Loc.LanguageSource)val_9.Item[0];
            label_12:
            val_17 = null;
            val_17 = null;
            val_9 = I2.Loc.LocalizationManager.Sources;
            val_15 = public I2.Loc.LanguageSource System.Collections.Generic.List<I2.Loc.LanguageSource>::get_Item(int index);
            val_14 = val_8;
            return (I2.Loc.LanguageSource)val_9.Item[0];
        }
        public static UnityEngine.Object FindAsset(string value)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = null;
            val_6 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 >= 1)
            {
                    val_7 = 0;
                do
            {
                val_8 = null;
                val_8 = null;
                val_9 = I2.Loc.LocalizationManager.Sources.Item[0].FindAsset(Name:  X1);
                if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return (UnityEngine.Object)val_9;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1);
            
            }
            
            val_9 = 0;
            return (UnityEngine.Object)val_9;
        }
        public static string GetCurrentDeviceLanguage()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    I2.Loc.LocalizationManager.DetectDeviceLanguage();
            }
            
            val_3 = null;
            val_3 = null;
            return (string)I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
        }
        private static void DetectDeviceLanguage()
        {
            var val_15;
            var val_16;
            var val_17;
            string val_18;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "java/util/Locale");
            val_15 = null;
            val_15 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getDefault", args:  null).Call<System.String>(methodName:  "toString", args:  null);
            val_16 = 1152921504608284672;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_17 = null;
                val_17 = null;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = I2.Loc.LocalizationManager.mCurrentDeviceLanguage.Replace(oldChar:  '_', newChar:  '-');
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = I2.Loc.GoogleLanguages.GetLanguageName(code:  0, useParenthesesForRegion:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage, allowDiscardRegion:  true);
                val_18 = I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
                if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_20 = null;
            val_20 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = UnityEngine.Application.systemLanguage.ToString();
            val_16 = 1152921504608284672;
            if((System.String.op_Equality(a:  0, b:  I2.Loc.LocalizationManager.mCurrentDeviceLanguage)) != false)
            {
                    val_21 = null;
                val_21 = null;
                I2.Loc.LocalizationManager.mCurrentDeviceLanguage = "Chinese (Simplified)";
            }
            
            val_22 = null;
            val_22 = null;
            val_18 = I2.Loc.LocalizationManager.mCurrentDeviceLanguage;
            if((System.String.op_Equality(a:  0, b:  val_18)) == false)
            {
                    return;
            }
            
            val_23 = null;
            val_23 = null;
            I2.Loc.LocalizationManager.mCurrentDeviceLanguage = "Chinese (Traditional)";
        }
        public static void RegisterTarget(I2.Loc.ILocalizeTargetDescriptor desc)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            typeof(LocalizationManager.<RegisterTarget>c__AnonStorey6).__il2cppRuntimeField_10 = X1;
            val_9 = null;
            val_9 = null;
            if((I2.Loc.LocalizationManager.mLocalizeTargets.FindIndex(match:  new System.Predicate<I2.Loc.ILocalizeTargetDescriptor>(object:  new System.Object(), method:  System.Boolean LocalizationManager.<RegisterTarget>c__AnonStorey6::<>m__0(I2.Loc.ILocalizeTargetDescriptor x)))) != 1)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_6;
            label_17:
            val_10 = 1;
            label_6:
            val_11 = null;
            val_11 = null;
            val_12 = null;
            if(val_10 >= I2.Loc.LocalizationManager.mLocalizeTargets.Count)
            {
                goto label_10;
            }
            
            val_13 = null;
            I2.Loc.ILocalizeTargetDescriptor val_7 = I2.Loc.LocalizationManager.mLocalizeTargets.Item[1];
            if(val_7.Priority <= (X1 + 24))
            {
                goto label_17;
            }
            
            val_14 = null;
            val_14 = null;
            I2.Loc.LocalizationManager.mLocalizeTargets.Insert(index:  1, item:  typeof(LocalizationManager.<RegisterTarget>c__AnonStorey6).__il2cppRuntimeField_10);
            return;
            label_10:
            val_15 = null;
            I2.Loc.LocalizationManager.mLocalizeTargets.Add(item:  typeof(LocalizationManager.<RegisterTarget>c__AnonStorey6).__il2cppRuntimeField_10);
        }
        public static void add_OnLocalizeEvent(I2.Loc.LocalizationManager.OnLocalizeCallback value)
        {
            var val_3;
            OnLocalizeCallback val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = I2.Loc.LocalizationManager.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504966914128 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnLocalizeEvent(I2.Loc.LocalizationManager.OnLocalizeCallback value)
        {
            var val_3;
            OnLocalizeCallback val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = I2.Loc.LocalizationManager.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504966914128 != val_4)
            {
                goto label_8;
            }
        
        }
        public static string GetTranslation(string Term, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            bool val_5 = I2.Loc.LocalizationManager.TryGetTranslation(Term:  null, Translation: out  FixForRTL, FixForRTL:  true, maxLineLengthForRTL:  maxLineLengthForRTL & 1, ignoreRTLnumbers:  ignoreRTLnumbers, applyParameters:  applyParameters, localParametersRoot:  localParametersRoot & 1, overrideLanguage:  overrideLanguage);
            return 0;
        }
        public static string GetTermTranslation(string Term, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            applyParameters = applyParameters;
            localParametersRoot = localParametersRoot & 1;
            maxLineLengthForRTL = maxLineLengthForRTL & 1;
            return I2.Loc.LocalizationManager.GetTranslation(Term:  null, FixForRTL:  FixForRTL, maxLineLengthForRTL:  maxLineLengthForRTL, ignoreRTLnumbers:  ignoreRTLnumbers, applyParameters:  applyParameters, localParametersRoot:  localParametersRoot, overrideLanguage:  overrideLanguage);
        }
        public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = True, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = True, bool applyParameters = False, UnityEngine.GameObject localParametersRoot, string overrideLanguage)
        {
            string val_4;
            bool val_11;
            int val_12;
            var val_13;
            var val_14;
            string val_15;
            string val_16;
            val_11 = ignoreRTLnumbers;
            val_12 = maxLineLengthForRTL;
            mem2[0] = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_3;
            }
            
            val_11 = 1152921504966909952;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            int val_3 = I2.Loc.LocalizationManager.Sources.Count;
            val_13 = 0;
            if(val_3 < 1)
            {
                    return (bool)val_13;
            }
            
            val_12 = val_4;
            var val_10 = 0;
            label_13:
            val_14 = null;
            val_14 = null;
            val_15 = FixForRTL;
            if((I2.Loc.LocalizationManager.Sources.Item[0].TryGetTranslation(term:  Translation, Translation: out  val_15, overrideLanguage:  val_12, overrideSpecialization:  0, skipDisabled:  false, allowCategoryMistmatch:  false)) == true)
            {
                goto label_12;
            }
            
            val_10 = val_10 + 1;
            if(val_10 < val_3)
            {
                goto label_13;
            }
            
            label_3:
            val_13 = 0;
            return (bool)val_13;
            label_12:
            if((localParametersRoot & 1) != 0)
            {
                    val_15 = overrideLanguage;
                I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  null, root:  FixForRTL, allowLocalizedParameters:  val_15);
            }
            
            val_16 = null;
            val_16 = null;
            if(I2.Loc.LocalizationManager.IsRight2Left == false)
            {
                    return (bool)val_13;
            }
            
            if((val_12 & 1) == 0)
            {
                    return (bool)val_13;
            }
            
            bool val_8 = applyParameters;
            mem2[0] = I2.Loc.LocalizationManager.ApplyRTLfix(line:  val_16, maxCharacters:  FixForRTL, ignoreNumbers:  val_11);
            return (bool)val_13;
        }
        public static T GetTranslatedObject<T>(string Term, I2.Loc.Localize optionalLocComp)
        {
            var val_8;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_10 = X3;
            val_11 = optionalLocComp;
            val_12 = 1152921504721543168;
            if(0 != __RuntimeMethodHiddenParam)
            {
                    val_8 = ???;
                val_10 = ???;
                val_11 = ???;
                val_12 = ???;
            }
            else
            {
                    UnityEngine.Object val_2 = I2.Loc.LocalizationManager.FindAsset(value:  0);
                val_13 = 0;
                if(val_2 != null)
            {
                    val_13 = val_2;
                if(val_13 == null)
            {
                    val_13 = 0;
            }
            
            }
            
                if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    val_13 = I2.Loc.ResourceManager.pInstance;
            }
            
                var val_7 = val_8 - 48;
                return (object)val_13;
            }
        
        }
        public static string GetAppName(string languageCode)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return UnityEngine.Application.productName;
            }
            
            val_14 = 0;
            goto label_4;
            label_30:
            val_14 = 1;
            label_4:
            val_15 = null;
            val_15 = null;
            if(val_14 >= I2.Loc.LocalizationManager.Sources.Count)
            {
                    return UnityEngine.Application.productName;
            }
            
            val_16 = null;
            val_16 = null;
            I2.Loc.LanguageSource val_4 = I2.Loc.LocalizationManager.Sources.Item[1];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_30;
            }
            
            val_17 = null;
            val_17 = null;
            int val_8 = I2.Loc.LocalizationManager.Sources.Item[1].GetLanguageIndexFromCode(Code:  X1, exactMatch:  false, ignoreDisabled:  false);
            if((val_8 & 2147483648) != 0)
            {
                goto label_30;
            }
            
            val_18 = null;
            val_18 = null;
            I2.Loc.LanguageSource val_10 = I2.Loc.LocalizationManager.Sources.Item[1];
            I2.Loc.TermData val_11 = I2.Loc.LocalizationManager.Sources.Item[1].GetTermData(term:  val_10.mTerm_AppName, allowCategoryMistmatch:  false);
            if((val_11 == null) || ((System.String.IsNullOrEmpty(value:  0)) == true))
            {
                goto label_30;
            }
            
            return (string)val_11.GetTranslation(idx:  val_8, specialization:  0, editMode:  false);
        }
        public static void LocalizeAll(bool Force = False)
        {
            var val_9;
            I2.Loc.LocalizationManager.LoadCurrentLanguage();
            val_9 = null;
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_3;
            }
            
            val_9 = null;
            bool val_5 = (I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue == true) ? 1 : 0;
            val_5 = val_5 | W1;
            val_5 = val_5 & 1;
            I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = val_5;
            if(I2.Loc.LocalizationManager.mLocalizeIsScheduled == false)
            {
                goto label_6;
            }
            
            return;
            label_3:
            var val_6 = W1 & 1;
            I2.Loc.LocalizationManager.DoLocalizeAll(Force:  false);
            return;
            label_6:
            System.Collections.IEnumerator val_7 = I2.Loc.LocalizationManager.Coroutine_LocalizeAll();
            UnityEngine.Coroutine val_8 = I2.Loc.CoroutineManager.Start(coroutine:  0);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private static System.Collections.IEnumerator Coroutine_LocalizeAll()
        {
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void DoLocalizeAll(bool Force = False)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            OnLocalizeCallback val_9;
            bool val_6 = W1;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object[] val_2 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  0);
            if(val_2 == null)
            {
                goto label_3;
            }
            
            val_5 = val_2;
            if(val_5 == null)
            {
                goto label_4;
            }
            
            val_6 = 0;
            val_7 = val_5;
            goto label_5;
            label_4:
            label_3:
            val_5 = 0;
            val_7 = 0;
            val_6 = 1;
            label_5:
            if(7254272 >= 1)
            {
                    var val_7 = 0;
                var val_4 = val_5 + 32;
                val_6 = val_6 & 1;
                do
            {
                (val_5 + 32) + 0.OnLocalize(Force:  val_6);
                val_7 = val_7 + 1;
            }
            while(7254272 != val_7);
            
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = I2.Loc.LocalizationManager.OnLocalizeEvent;
            if(val_9 != null)
            {
                    val_9 = I2.Loc.LocalizationManager.OnLocalizeEvent;
                if(val_9 == null)
            {
                    val_9 = 0;
            }
            
                val_9.Invoke();
            }
            
            I2.Loc.ResourceManager.pInstance.CleanResourceCache();
        }
        public static System.Collections.Generic.List<string> GetCategories()
        {
            var val_5;
            var val_6;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_5 = null;
            val_5 = null;
            int val_2 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_5 = 0;
            do
            {
                val_6 = null;
                val_6 = null;
                System.Collections.Generic.List<System.String> val_4 = I2.Loc.LocalizationManager.Sources.Item[0].GetCategories(OnlyMainCategory:  false, Categories:  val_1);
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
            
            return val_1;
        }
        public static System.Collections.Generic.List<string> GetTermsList(string Category)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = null;
            val_10 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            val_11 = null;
            val_11 = null;
            if(I2.Loc.LocalizationManager.Sources.Count == 1)
            {
                    val_12 = null;
                val_12 = null;
                I2.Loc.LanguageSource val_4 = I2.Loc.LocalizationManager.Sources.Item[0];
                if(val_4 != null)
            {
                    return val_4.GetTermsList(Category:  X1);
            }
            
                return val_4.GetTermsList(Category:  X1);
            }
            
            val_13 = null;
            val_13 = null;
            int val_6 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_6 < 1)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  new System.Collections.Generic.HashSet<System.String>());
            }
            
            var val_10 = 0;
            do
            {
                val_14 = null;
                val_14 = null;
                UnionWith(other:  I2.Loc.LocalizationManager.Sources.Item[0].GetTermsList(Category:  X1));
                val_10 = val_10 + 1;
            }
            while(val_6 != val_10);
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  new System.Collections.Generic.HashSet<System.String>());
        }
        public static I2.Loc.TermData GetTermData(string term)
        {
            var val_4;
            var val_5;
            var val_6;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 >= 1)
            {
                    val_4 = 0;
                do
            {
                val_5 = null;
                val_5 = null;
                if((I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  X1, allowCategoryMistmatch:  false)) != null)
            {
                    return (I2.Loc.TermData)val_6;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1);
            
            }
            
            val_6 = 0;
            return (I2.Loc.TermData)val_6;
        }
        public static I2.Loc.TermData GetTermData(string term, out I2.Loc.LanguageSource source)
        {
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_5;
            var val_6;
            var val_7;
            var val_8;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_5 = I2.Loc.LocalizationManager.Sources;
            int val_1 = val_5.Count;
            if(val_1 < 1)
            {
                goto label_4;
            }
            
            val_5 = 0;
            label_10:
            val_6 = null;
            val_6 = null;
            val_7 = I2.Loc.LocalizationManager.Sources.Item[0].GetTermData(term:  source, allowCategoryMistmatch:  false);
            if(val_7 != null)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_10;
            }
            
            label_4:
            val_7 = 0;
            mem2[0] = 0;
            return (I2.Loc.TermData)val_7;
            label_9:
            val_8 = null;
            val_8 = null;
            mem2[0] = I2.Loc.LocalizationManager.Sources.Item[0];
            return (I2.Loc.TermData)val_7;
        }
        private static LocalizationManager()
        {
            I2.Loc.LocalizationManager.mChangeCultureInfo = false;
            I2.Loc.LocalizationManager.IsRight2Left = false;
            I2.Loc.LocalizationManager.HasJoinedWords = false;
            I2.Loc.LocalizationManager.ParamManagers = new System.Collections.Generic.List<I2.Loc.ILocalizationParamsManager>();
            typeof(System.String[]).__il2cppRuntimeField_20 = "ar-DZ";
            typeof(System.String[]).__il2cppRuntimeField_28 = "ar";
            typeof(System.String[]).__il2cppRuntimeField_30 = "ar-BH";
            typeof(System.String[]).__il2cppRuntimeField_38 = "ar-EG";
            typeof(System.String[]).__il2cppRuntimeField_40 = "ar-IQ";
            typeof(System.String[]).__il2cppRuntimeField_48 = "ar-JO";
            typeof(System.String[]).__il2cppRuntimeField_50 = "ar-KW";
            typeof(System.String[]).__il2cppRuntimeField_58 = "ar-LB";
            typeof(System.String[]).__il2cppRuntimeField_60 = "ar-LY";
            typeof(System.String[]).__il2cppRuntimeField_68 = "ar-MA";
            typeof(System.String[]).__il2cppRuntimeField_70 = "ar-OM";
            typeof(System.String[]).__il2cppRuntimeField_78 = "ar-QA";
            typeof(System.String[]).__il2cppRuntimeField_80 = "ar-SA";
            typeof(System.String[]).__il2cppRuntimeField_88 = "ar-SY";
            typeof(System.String[]).__il2cppRuntimeField_90 = "ar-TN";
            typeof(System.String[]).__il2cppRuntimeField_98 = "ar-AE";
            typeof(System.String[]).__il2cppRuntimeField_A0 = "ar-YE";
            typeof(System.String[]).__il2cppRuntimeField_A8 = "he";
            typeof(System.String[]).__il2cppRuntimeField_B0 = "ur";
            typeof(System.String[]).__il2cppRuntimeField_B8 = "ji";
            I2.Loc.LocalizationManager.LanguagesRTL = null;
            I2.Loc.LocalizationManager.Sources = new System.Collections.Generic.List<I2.Loc.LanguageSource>();
            typeof(System.String[]).__il2cppRuntimeField_20 = "I2Languages";
            I2.Loc.LocalizationManager.GlobalSources = null;
            I2.Loc.LocalizationManager.mLocalizeTargets = new System.Collections.Generic.List<I2.Loc.ILocalizeTargetDescriptor>();
            I2.Loc.LocalizationManager.mLocalizeIsScheduled = false;
            I2.Loc.LocalizationManager.mLocalizeIsScheduledWithForcedValue = false;
            I2.Loc.LocalizationManager.HighlightLocalizedTargets = false;
        }
        private static object <ApplyLocalizationParams>m__0(string p)
        {
            return I2.Loc.LocalizationManager.GetLocalizationParam(ParamName:  null, root:  X1);
        }
    
    }

}
