using UnityEngine;

namespace I2.Loc
{
    public static class GoogleLanguages
    {
        // Fields
        public static System.Collections.Generic.Dictionary<string, I2.Loc.GoogleLanguages.LanguageCodeDef> mLanguageDef;
        
        // Methods
        public static string GetLanguageCode(string Filter, bool ShowWarnings = False)
        {
            var val_6;
            var val_10;
            var val_12;
            var val_13;
            var val_14;
            string val_15;
            var val_16;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_17;
            }
            
            val_13 = " /(),";
            if((" /(),") == null)
            {
                    val_13 = " /(),";
            }
            
            val_12 = ShowWarnings.ToLowerInvariant().Split(separator:  ToCharArray());
            val_14 = null;
            val_14 = null;
            Dictionary.Enumerator<TKey, TValue> val_5 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_13:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            if((I2.Loc.GoogleLanguages.LanguageMatchesFilter(Language:  null, Filters:  val_6.InitializationCallback)) == false)
            {
                goto label_13;
            }
            
            val_15 = val_10;
            0.Dispose();
            return val_15;
            label_10:
            0.Dispose();
            if((W2 & 1) != 0)
            {
                    string val_11 = System.String.Format(format:  0, arg0:  "Language \'{0}\' not recognized. Please, add the language code to GoogleTranslation.cs");
                UnityEngine.Debug.Log(message:  0);
            }
            
            label_17:
            val_16 = null;
            val_16 = null;
            val_15 = System.String.Empty;
            return val_15;
        }
        public static System.Collections.Generic.List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
        {
            var val_8;
            var val_9;
            string val_15;
            var val_35;
            var val_36;
            int val_37;
            var val_38;
            string val_39;
            val_35 = " /(),";
            if((" /(),") == null)
            {
                    val_35 = " /(),";
            }
            
            System.String[] val_3 = CodesToExclude.ToLowerInvariant().Split(separator:  ToCharArray());
            val_36 = null;
            val_36 = null;
            Dictionary.Enumerator<TKey, TValue> val_5 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_25:
            if((0 & 1) == 0)
            {
                goto label_43;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((I2.Loc.GoogleLanguages.LanguageMatchesFilter(Language:  null, Filters:  val_9.InitializationCallback)) == false)
            {
                goto label_25;
            }
            
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = 0 + "[" + val_15;
            if((X2.Contains(value:  +0)) == true)
            {
                goto label_25;
            }
            
            Add(item:  0 + val_9.InitializationCallback + " ");
            goto label_25;
            label_43:
            val_8.Dispose();
            int val_23 = Count - 2;
            if((val_23 & 2147483648) != 0)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            do
            {
                if(null != 0)
            {
                    val_38 = Item[val_23];
            }
            else
            {
                    val_38 = Item[val_23];
            }
            
                string val_28 = val_38.Substring(startIndex:  0, length:  Item[val_23].IndexOf(value:  " ["));
                val_37 = val_23 + 1;
                val_39 = Item[val_37];
                if((val_39.StartsWith(value:  val_28)) != false)
            {
                    string val_31 = Item[val_23];
                val_39 = 0 + val_28 + "/"("/");
                set_Item(index:  val_23, value:  val_39);
                Insert(index:  val_37, item:  0 + val_28);
            }
            
                val_23 = val_23 - 1;
            }
            while((val_23 & 2147483648) == 0);
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
        }
        private static bool LanguageMatchesFilter(string Language, string[] Filters)
        {
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            string val_1 = Filters.ToLowerInvariant();
            if((X2 + 24) < 1)
            {
                goto label_3;
            }
            
            val_10 = 0;
            var val_2 = X2 + 32;
            label_20:
            val_11 = null;
            val_9 = mem[(X2 + 32) + 0];
            val_9 = (X2 + 32) + 0;
            val_11 = null;
            if((System.String.op_Inequality(a:  0, b:  val_9)) == false)
            {
                goto label_8;
            }
            
            val_9 = (X2 + 32) + 0.ToLower();
            if((val_1.Contains(value:  val_9)) == false)
            {
                goto label_13;
            }
            
            val_9 = val_1.IndexOf(value:  (X2 + 32) + 0);
            string val_8 = val_1.Remove(startIndex:  val_9, count:  (X2 + 32) + 0.Length);
            label_8:
            val_10 = val_10 + 1;
            if(val_10 < ((long)X2 + 24))
            {
                goto label_20;
            }
            
            label_3:
            val_12 = 1;
            return (bool)val_12;
            label_13:
            val_12 = 0;
            return (bool)val_12;
        }
        public static string GetFormatedLanguageName(string Language)
        {
            string val_9;
            string val_10;
            val_9 = X1;
            int val_1 = val_9.IndexOf(value:  " [");
            if(val_1 >= 1)
            {
                    val_9 = val_9.Substring(startIndex:  0, length:  val_1);
            }
            
            int val_3 = val_9.IndexOf(value:  '/');
            if(val_3 >= 1)
            {
                    val_10 = val_9.Substring(startIndex:  0, length:  val_3);
                string val_5 = 0 + val_10 + "/"("/");
                if((System.String.op_Equality(a:  0, b:  val_9)) == true)
            {
                    return (string)val_10;
            }
            
                return 0 + val_9.Replace(oldValue:  "/", newValue:  " (")(val_9.Replace(oldValue:  "/", newValue:  " ("));
            }
            
            val_10 = val_9;
            return (string)val_10;
        }
        public static string GetCodedLanguage(string Language, string code)
        {
            if((System.String.Compare(strA:  0, strB:  X2, comparisonType:  I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  null, ShowWarnings:  code))) == 0)
            {
                    return (string)code;
            }
            
            return 0 + code + " [" + X2;
        }
        public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
        {
            var val_10;
            var val_11;
            val_10 = 1152921512226071392;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_11 = null;
                val_11 = null;
                code = System.String.Empty;
                mem2[0] = System.String.Empty;
                return;
            }
            
            int val_2 = Language.IndexOf(value:  "[");
            if((val_2 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            code = Language.Substring(startIndex:  0, length:  val_2).Trim();
            if(Language == null)
            {
                goto label_11;
            }
            
            val_10 = Language.IndexOf(value:  "]", startIndex:  val_2);
            goto label_12;
            label_8:
            code = 1152921512226067360;
            string val_6 = I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  null, ShowWarnings:  true);
            goto label_15;
            label_11:
            int val_10 = val_2;
            val_10 = 0.IndexOf(value:  "]", startIndex:  val_10);
            label_12:
            val_10 = val_10 + (~val_2);
            label_15:
            mem2[0] = Language.Substring(startIndex:  val_2 + 1, length:  val_10);
        }
        public static string GetGoogleLanguageCode(string InternationalCode)
        {
            var val_4;
            string val_9;
            var val_15;
            string val_16;
            var val_17;
            val_16 = X1;
            val_17 = null;
            val_17 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_16)) == false)
            {
                goto label_7;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_9)) != false)
            {
                    val_16 = 0;
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_16 = val_15;
            }
            
            }
            
            label_16:
            val_4.Dispose();
            return (string)val_16;
        }
        public static string GetLanguageName(string code, bool useParenthesesForRegion = False, bool allowDiscardRegion = True)
        {
            var val_4;
            var val_5;
            int val_18;
            var val_19;
            string val_20;
            var val_21;
            var val_22;
            val_18 = W3;
            val_19 = null;
            val_19 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            if((System.String.op_Equality(a:  0, b:  useParenthesesForRegion)) == false)
            {
                goto label_7;
            }
            
            val_21 = val_5.InitializationCallback;
            if(allowDiscardRegion != false)
            {
                    int val_10 = val_21.IndexOf(value:  '/');
                if(val_10 >= 1)
            {
                    val_20 = val_21.Substring(startIndex:  0, length:  val_10);
                val_21 = 0 + val_20 + " (" + val_21.Substring(startIndex:  val_10 + 1)(val_21.Substring(startIndex:  val_10 + 1));
            }
            
            }
            
            val_4.Dispose();
            return (string)val_21;
            label_4:
            val_4.Dispose();
            if((val_18 & 1) != 0)
            {
                    val_18 = useParenthesesForRegion.IndexOf(value:  "-");
                val_21 = 0;
                if(val_18 < 1)
            {
                    return (string)val_21;
            }
            
                string val_16 = useParenthesesForRegion.Substring(startIndex:  0, length:  val_18);
                val_22 = null;
                bool val_17 = allowDiscardRegion;
                val_21 = val_22;
                return (string)val_21;
            }
            
            val_21 = 0;
            return (string)val_21;
        }
        public static System.Collections.Generic.List<string> GetAllInternationalCodes()
        {
            string val_5;
            var val_8;
            var val_9;
            var val_10;
            val_8 = null;
            val_8 = null;
            Dictionary.Enumerator<TKey, TValue> val_2 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            bool val_6 = Add(item:  val_5);
            goto label_6;
            label_4:
            val_9 = 0;
            val_10 = 1;
            0.Dispose();
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>(collection:  new System.Collections.Generic.HashSet<System.String>());
        }
        public static bool LanguageCode_HasJoinedWord(string languageCode)
        {
            var val_9;
            var val_11;
            var val_12;
            val_11 = null;
            val_11 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_10:
            if((0 & 1) != 0)
            {
                    if((System.String.op_Equality(a:  0, b:  X1)) != true)
            {
                    if((System.String.op_Equality(a:  0, b:  X1)) == false)
            {
                goto label_10;
            }
            
            }
            
                var val_10 = (val_9 == true) ? 1 : 0;
                0.Dispose();
                return (bool)val_12;
            }
            
            0.Dispose();
            val_12 = 0;
            return (bool)val_12;
        }
        private static int GetPluralRule(string langCode)
        {
            string val_7;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_10 = X1;
            if(val_10.Length >= 3)
            {
                    val_10 = val_10.Substring(startIndex:  0, length:  2);
            }
            
            string val_3 = val_10.ToLower();
            val_11 = null;
            val_11 = null;
            Dictionary.Enumerator<TKey, TValue> val_4 = I2.Loc.GoogleLanguages.mLanguageDef.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_7)) == false)
            {
                goto label_11;
            }
            
            val_12 = val_9;
            0.Dispose();
            return (int)val_12;
            label_8:
            0.Dispose();
            val_12 = 0;
            return (int)val_12;
        }
        public static bool LanguageHasPluralType(string langCode, string pluralType)
        {
            var val_17;
            if((((System.String.op_Equality(a:  0, b:  X2)) == true) || ((System.String.op_Equality(a:  0, b:  X2)) == true)) || ((System.String.op_Equality(a:  0, b:  X2)) == true))
            {
                goto label_23;
            }
            
            if(((I2.Loc.GoogleLanguages.GetPluralRule(langCode:  null)) - 3) > 13)
            {
                goto label_13;
            }
            
            var val_15 = 25812656 + ((val_7 - 3)) << 2;
            val_15 = val_15 - 13;
            if(val_15 > 5)
            {
                goto label_13;
            }
            
            var val_16 = 25812424 + ((25812656 + ((val_7 - 3)) << 2 - 13)) << 2;
            val_16 = val_16 + 25812424;
            goto (25812424 + ((25812656 + ((val_7 - 3)) << 2 - 13)) << 2 + 25812424);
            label_13:
            val_17 = 0;
            return (bool)val_17;
            label_23:
            val_17 = 1;
            return (bool)val_17;
        }
        public static I2.Loc.ePluralType GetPluralType(string langCode, int n)
        {
            var val_45;
            var val_46;
            var val_47;
            val_46 = W2;
            if(val_46 == 0)
            {
                goto label_1;
            }
            
            if(val_46 == 1)
            {
                goto label_65;
            }
            
            val_45 = 1152921504964833280;
            int val_1 = I2.Loc.GoogleLanguages.GetPluralRule(langCode:  null);
            var val_3 = (val_1 < 17) ? (val_1 + 7) : 0;
            val_3 = val_3 - 9;
            if(val_3 > 14)
            {
                goto label_77;
            }
            
            var val_44 = 25812448 + ((val_1 < 17 ? (val_1 + 7) : 0 - 9)) << 2;
            val_44 = val_44 + 25812448;
            goto (25812448 + ((val_1 < 17 ? (val_1 + 7) : 0 - 9)) << 2 + 25812448);
            label_1:
            val_47 = 0;
            return (I2.Loc.ePluralType)val_47;
            label_77:
            val_47 = 5;
            return (I2.Loc.ePluralType)val_47;
            label_65:
            val_47 = 1;
            return (I2.Loc.ePluralType)val_47;
        }
        public static int GetPluralTestNumber(string langCode, I2.Loc.ePluralType pluralType)
        {
            if(((W2 < 5) ? (W2 + 3) : 0) > 7)
            {
                    return (int)( != 15) ? 6 : 1000000;
            }
            
            var val_6 = 25812544 + (W2 < 0x5 ? (W2 + 3) : 0) << 2;
            val_6 = val_6 + 25812544;
            goto (25812544 + (W2 < 0x5 ? (W2 + 3) : 0) << 2 + 25812544);
        }
        private static bool inRange(int amount, int min, int max)
        {
            return (bool)((min >= max) ? 1 : 0) & ((min <= W3) ? 1 : 0);
        }
        private static GoogleLanguages()
        {
            Add(key:  "Abkhazian", value:  new LanguageCodeDef() {Code = "ab", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Afar", value:  new LanguageCodeDef() {Code = "aa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Afrikaans", value:  new LanguageCodeDef() {Code = "af", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Akan", value:  new LanguageCodeDef() {Code = "ak", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Albanian", value:  new LanguageCodeDef() {Code = "sq", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Amharic", value:  new LanguageCodeDef() {Code = "am", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Arabic", value:  new LanguageCodeDef() {Code = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Algeria", value:  new LanguageCodeDef() {Code = "ar-DZ", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Bahrain", value:  new LanguageCodeDef() {Code = "ar-BH", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Egypt", value:  new LanguageCodeDef() {Code = "ar-EG", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Iraq", value:  new LanguageCodeDef() {Code = "ar-IQ", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Jordan", value:  new LanguageCodeDef() {Code = "ar-JO", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Kuwait", value:  new LanguageCodeDef() {Code = "ar-KW", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Lebanon", value:  new LanguageCodeDef() {Code = "ar-LB", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Libya", value:  new LanguageCodeDef() {Code = "ar-LY", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Morocco", value:  new LanguageCodeDef() {Code = "ar-MA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Oman", value:  new LanguageCodeDef() {Code = "ar-OM", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Qatar", value:  new LanguageCodeDef() {Code = "ar-QA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Saudi Arabia", value:  new LanguageCodeDef() {Code = "ar-SA", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Syria", value:  new LanguageCodeDef() {Code = "ar-SY", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Tunisia", value:  new LanguageCodeDef() {Code = "ar-TN", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/U.A.E.", value:  new LanguageCodeDef() {Code = "ar-AE", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Arabic/Yemen", value:  new LanguageCodeDef() {Code = "ar-YE", GoogleCode = "ar", HasJoinedWords = false, PluralRule = 11});
            Add(key:  "Aragonese", value:  new LanguageCodeDef() {Code = "an", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Armenian", value:  new LanguageCodeDef() {Code = "hy", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Assamese", value:  new LanguageCodeDef() {Code = "as", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Avaric", value:  new LanguageCodeDef() {Code = "av", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Avestan", value:  new LanguageCodeDef() {Code = "ae", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Aymara", value:  new LanguageCodeDef() {Code = "ay", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Azerbaijani", value:  new LanguageCodeDef() {Code = "az", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Bambara", value:  new LanguageCodeDef() {Code = "bm", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Bashkir", value:  new LanguageCodeDef() {Code = "ba", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Basque", value:  new LanguageCodeDef() {Code = "eu", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Basque/Spain", value:  new LanguageCodeDef() {Code = "eu-ES", GoogleCode = "eu", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Belarusian", value:  new LanguageCodeDef() {Code = "be", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Bengali", value:  new LanguageCodeDef() {Code = "bn", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Bihari", value:  new LanguageCodeDef() {Code = "bh", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Bislama", value:  new LanguageCodeDef() {Code = "bi", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Bosnian", value:  new LanguageCodeDef() {Code = "bs", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Breton", value:  new LanguageCodeDef() {Code = "br", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Bulgariaa", value:  new LanguageCodeDef() {Code = "bg", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Burmese", value:  new LanguageCodeDef() {Code = "my", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Catalan", value:  new LanguageCodeDef() {Code = "ca", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Chamorro", value:  new LanguageCodeDef() {Code = "ch", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Chechen", value:  new LanguageCodeDef() {Code = "ce", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Chichewa", value:  new LanguageCodeDef() {Code = "ny", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Chinese", value:  new LanguageCodeDef() {Code = "zh", GoogleCode = "zh-CN", HasJoinedWords = 1});
            Add(key:  "Chinese/Hong Kong", value:  new LanguageCodeDef() {Code = "zh-HK", GoogleCode = "zh-TW", HasJoinedWords = true});
            Add(key:  "Chinese/Macau", value:  new LanguageCodeDef() {Code = "zh-MO", GoogleCode = "zh-CN", HasJoinedWords = true});
            Add(key:  "Chinese/PRC", value:  new LanguageCodeDef() {Code = "zh-CN", GoogleCode = "zh-CN", HasJoinedWords = true});
            Add(key:  "Chinese/Simplified", value:  new LanguageCodeDef() {Code = "zh-CN", GoogleCode = "zh-CN", HasJoinedWords = true});
            Add(key:  "Chinese/Singapore", value:  new LanguageCodeDef() {Code = "zh-SG", GoogleCode = "zh-CN", HasJoinedWords = true});
            Add(key:  "Chinese/Taiwan", value:  new LanguageCodeDef() {Code = "zh-TW", GoogleCode = "zh-TW", HasJoinedWords = true});
            Add(key:  "Chinese/Traditional", value:  new LanguageCodeDef() {Code = "zh-TW", GoogleCode = "zh-TW", HasJoinedWords = true});
            Add(key:  "Chuvash", value:  new LanguageCodeDef() {Code = "cv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Cornish", value:  new LanguageCodeDef() {Code = "kw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Corsican", value:  new LanguageCodeDef() {Code = "co", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Cree", value:  new LanguageCodeDef() {Code = "cr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Croatian", value:  new LanguageCodeDef() {Code = "hr", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Croatian/Bosnia and Herzegovina", value:  new LanguageCodeDef() {Code = "hr-BA", GoogleCode = "hr", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Czech", value:  new LanguageCodeDef() {Code = "cs", HasJoinedWords = false, PluralRule = 7});
            Add(key:  "Danish", value:  new LanguageCodeDef() {Code = "da", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Divehi", value:  new LanguageCodeDef() {Code = "dv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Dutch", value:  new LanguageCodeDef() {Code = "nl", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Dutch/Belgium", value:  new LanguageCodeDef() {Code = "nl-BE", GoogleCode = "nl", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Dutch/Netherlands", value:  new LanguageCodeDef() {Code = "nl-NL", GoogleCode = "nl", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Dzongkha", value:  new LanguageCodeDef() {Code = "dz", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English", value:  new LanguageCodeDef() {Code = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Australia", value:  new LanguageCodeDef() {Code = "en-AU", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Belize", value:  new LanguageCodeDef() {Code = "en-BZ", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Canada", value:  new LanguageCodeDef() {Code = "en-CA", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Caribbean", value:  new LanguageCodeDef() {Code = "en-CB", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Ireland", value:  new LanguageCodeDef() {Code = "en-IE", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Jamaica", value:  new LanguageCodeDef() {Code = "en-JM", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/New Zealand", value:  new LanguageCodeDef() {Code = "en-NZ", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Republic of the Philippines", value:  new LanguageCodeDef() {Code = "en-PH", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/South Africa", value:  new LanguageCodeDef() {Code = "en-ZA", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Trinidad", value:  new LanguageCodeDef() {Code = "en-TT", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/United Kingdom", value:  new LanguageCodeDef() {Code = "en-GB", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/United States", value:  new LanguageCodeDef() {Code = "en-US", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "English/Zimbabwe", value:  new LanguageCodeDef() {Code = "en-ZW", GoogleCode = "en", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Esperanto", value:  new LanguageCodeDef() {Code = "eo", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Estonian", value:  new LanguageCodeDef() {Code = "et", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ewe", value:  new LanguageCodeDef() {Code = "ee", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Faeroese", value:  new LanguageCodeDef() {Code = "fo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Fijian", value:  new LanguageCodeDef() {Code = "fj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Finnish", value:  new LanguageCodeDef() {Code = "fi", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "French", value:  new LanguageCodeDef() {Code = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "French/Belgium", value:  new LanguageCodeDef() {Code = "fr-BE", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "French/Canada", value:  new LanguageCodeDef() {Code = "fr-CA", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "French/France", value:  new LanguageCodeDef() {Code = "fr-FR", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "French/Luxembourg", value:  new LanguageCodeDef() {Code = "fr-LU", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "French/Principality of Monaco", value:  new LanguageCodeDef() {Code = "fr-MC", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "French/Switzerland", value:  new LanguageCodeDef() {Code = "fr-CH", GoogleCode = "fr", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "Fulah", value:  new LanguageCodeDef() {Code = "ff", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Galician", value:  new LanguageCodeDef() {Code = "gl", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Galician/Spain", value:  new LanguageCodeDef() {Code = "gl-ES", GoogleCode = "gl", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Georgian", value:  new LanguageCodeDef() {Code = "ka", HasJoinedWords = false});
            Add(key:  "German", value:  new LanguageCodeDef() {Code = "de", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "German/Austria", value:  new LanguageCodeDef() {Code = "de-AT", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "German/Germany", value:  new LanguageCodeDef() {Code = "de-DE", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "German/Liechtenstein", value:  new LanguageCodeDef() {Code = "de-LI", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "German/Luxembourg", value:  new LanguageCodeDef() {Code = "de-LU", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "German/Switzerland", value:  new LanguageCodeDef() {Code = "de-CH", GoogleCode = "de", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Greek", value:  new LanguageCodeDef() {Code = "el", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Guaraní", value:  new LanguageCodeDef() {Code = "gn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Gujarati", value:  new LanguageCodeDef() {Code = "gu", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Haitian", value:  new LanguageCodeDef() {Code = "ht", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Hausa", value:  new LanguageCodeDef() {Code = "ha", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Hebrew", value:  new LanguageCodeDef() {Code = "he", GoogleCode = "iw", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Herero", value:  new LanguageCodeDef() {Code = "hz", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Hindi", value:  new LanguageCodeDef() {Code = "hi", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Hiri Motu", value:  new LanguageCodeDef() {Code = "ho", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Hungarian", value:  new LanguageCodeDef() {Code = "hu", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Interlingua", value:  new LanguageCodeDef() {Code = "ia", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Indonesian", value:  new LanguageCodeDef() {Code = "id", HasJoinedWords = false});
            Add(key:  "Interlingue", value:  new LanguageCodeDef() {Code = "ie", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Irish", value:  new LanguageCodeDef() {Code = "ga", HasJoinedWords = false, PluralRule = 10});
            Add(key:  "Igbo", value:  new LanguageCodeDef() {Code = "ig", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Inupiaq", value:  new LanguageCodeDef() {Code = "ik", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ido", value:  new LanguageCodeDef() {Code = "io", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Icelandic", value:  new LanguageCodeDef() {Code = "is", HasJoinedWords = false, PluralRule = 14});
            Add(key:  "Italian", value:  new LanguageCodeDef() {Code = "it", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Italian/Italy", value:  new LanguageCodeDef() {Code = "it-IT", GoogleCode = "it", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Italian/Switzerland", value:  new LanguageCodeDef() {Code = "it-CH", GoogleCode = "it", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Inuktitut", value:  new LanguageCodeDef() {Code = "iu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Japanese", value:  new LanguageCodeDef() {Code = "ja", HasJoinedWords = true});
            Add(key:  "Javanese", value:  new LanguageCodeDef() {Code = "jv", HasJoinedWords = false, PluralRule = true});
            Add(key:  "Kalaallisut", value:  new LanguageCodeDef() {Code = "kl", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kannada", value:  new LanguageCodeDef() {Code = "kn", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kanuri", value:  new LanguageCodeDef() {Code = "kr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kashmiri", value:  new LanguageCodeDef() {Code = "ks", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kazakh", value:  new LanguageCodeDef() {Code = "kk", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Central Khmer", value:  new LanguageCodeDef() {Code = "km", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kikuyu", value:  new LanguageCodeDef() {Code = "ki", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kinyarwanda", value:  new LanguageCodeDef() {Code = "rw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kirghiz", value:  new LanguageCodeDef() {Code = "ky", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Komi", value:  new LanguageCodeDef() {Code = "kv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kongo", value:  new LanguageCodeDef() {Code = "kg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Korean", value:  new LanguageCodeDef() {Code = "ko", HasJoinedWords = false});
            Add(key:  "Kurdish", value:  new LanguageCodeDef() {Code = "ku", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Kuanyama", value:  new LanguageCodeDef() {Code = "kj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Latin", value:  new LanguageCodeDef() {Code = "la", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Luxembourgish", value:  new LanguageCodeDef() {Code = "lb", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ganda", value:  new LanguageCodeDef() {Code = "lg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Limburgan", value:  new LanguageCodeDef() {Code = "li", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Lingala", value:  new LanguageCodeDef() {Code = "ln", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Lao", value:  new LanguageCodeDef() {Code = "lo", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Latvian", value:  new LanguageCodeDef() {Code = "lv", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Luba-Katanga", value:  new LanguageCodeDef() {Code = "lu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Lithuanian", value:  new LanguageCodeDef() {Code = "lt", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Manx", value:  new LanguageCodeDef() {Code = "gv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Macedonian", value:  new LanguageCodeDef() {Code = "mk", HasJoinedWords = false, PluralRule = 13});
            Add(key:  "Malagasy", value:  new LanguageCodeDef() {Code = "mg", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Malay", value:  new LanguageCodeDef() {Code = "ms", HasJoinedWords = false});
            Add(key:  "Malay/Brunei Darussalam", value:  new LanguageCodeDef() {Code = "ms-BN", GoogleCode = "ms", HasJoinedWords = false});
            Add(key:  "Malay/Malaysia", value:  new LanguageCodeDef() {Code = "ms-MY", GoogleCode = "ms", HasJoinedWords = false});
            Add(key:  "Malayalam", value:  new LanguageCodeDef() {Code = "ml", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Maltese", value:  new LanguageCodeDef() {Code = "mt", HasJoinedWords = false, PluralRule = 12});
            Add(key:  "Maori", value:  new LanguageCodeDef() {Code = "mi", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "Marathi", value:  new LanguageCodeDef() {Code = "mr", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Marshallese", value:  new LanguageCodeDef() {Code = "mh", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Mongolian", value:  new LanguageCodeDef() {Code = "mn", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Nauru", value:  new LanguageCodeDef() {Code = "na", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Navajo", value:  new LanguageCodeDef() {Code = "nv", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "North Ndebele", value:  new LanguageCodeDef() {Code = "nd", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Nepali", value:  new LanguageCodeDef() {Code = "ne", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ndonga", value:  new LanguageCodeDef() {Code = "ng", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Northern Sotho", value:  new LanguageCodeDef() {Code = "ns", GoogleCode = "st", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Norwegian", value:  new LanguageCodeDef() {Code = "nb", GoogleCode = "no", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Norwegian/Nynorsk", value:  new LanguageCodeDef() {Code = "nn", GoogleCode = "no", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Sichuan Yi", value:  new LanguageCodeDef() {Code = "ii", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "South Ndebele", value:  new LanguageCodeDef() {Code = "nr", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Occitan", value:  new LanguageCodeDef() {Code = "oc", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ojibwa", value:  new LanguageCodeDef() {Code = "oj", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Church Slavic", value:  new LanguageCodeDef() {Code = "cu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Oromo", value:  new LanguageCodeDef() {Code = "om", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Oriya", value:  new LanguageCodeDef() {Code = "or", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ossetian", value:  new LanguageCodeDef() {Code = "os", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Pali", value:  new LanguageCodeDef() {Code = "pi", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Pashto", value:  new LanguageCodeDef() {Code = "ps", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Persian", value:  new LanguageCodeDef() {Code = "fa", HasJoinedWords = false});
            Add(key:  "Polish", value:  new LanguageCodeDef() {Code = "pl", HasJoinedWords = false, PluralRule = 8});
            Add(key:  "Portuguese", value:  new LanguageCodeDef() {Code = "pt", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Portuguese/Brazil", value:  new LanguageCodeDef() {Code = "pt-BR", GoogleCode = "pt", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "Portuguese/Portugal", value:  new LanguageCodeDef() {Code = "pt-PT", GoogleCode = "pt", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Punjabi", value:  new LanguageCodeDef() {Code = "pa", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Quechua", value:  new LanguageCodeDef() {Code = "qu", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Quechua/Bolivia", value:  new LanguageCodeDef() {Code = "qu-BO", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Quechua/Ecuador", value:  new LanguageCodeDef() {Code = "qu-EC", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Quechua/Peru", value:  new LanguageCodeDef() {Code = "qu-PE", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Rhaeto-Romanic", value:  new LanguageCodeDef() {Code = "rm", GoogleCode = "ro", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Romanian", value:  new LanguageCodeDef() {Code = "ro", HasJoinedWords = false, PluralRule = 4});
            Add(key:  "Rundi", value:  new LanguageCodeDef() {Code = "rn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Russian", value:  new LanguageCodeDef() {Code = "ru", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Russian/Republic of Moldova", value:  new LanguageCodeDef() {Code = "ru-MO", GoogleCode = "ru", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Sanskrit", value:  new LanguageCodeDef() {Code = "sa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Sardinian", value:  new LanguageCodeDef() {Code = "sc", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Sindhi", value:  new LanguageCodeDef() {Code = "sd", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Northern Sami", value:  new LanguageCodeDef() {Code = "se", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Samoan", value:  new LanguageCodeDef() {Code = "sm", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Sango", value:  new LanguageCodeDef() {Code = "sg", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Serbian", value:  new LanguageCodeDef() {Code = "sr", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Serbian/Bosnia and Herzegovina", value:  new LanguageCodeDef() {Code = "sr-BA", GoogleCode = "sr", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Serbian/Serbia and Montenegro", value:  new LanguageCodeDef() {Code = "sr-SP", GoogleCode = "sr", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Scottish Gaelic", value:  new LanguageCodeDef() {Code = "gd", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Shona", value:  new LanguageCodeDef() {Code = "sn", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Sinhala", value:  new LanguageCodeDef() {Code = "si", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Slovak", value:  new LanguageCodeDef() {Code = "sk", HasJoinedWords = false, PluralRule = 7});
            Add(key:  "Slovenian", value:  new LanguageCodeDef() {Code = "sl", HasJoinedWords = false, PluralRule = 9});
            Add(key:  "Somali", value:  new LanguageCodeDef() {Code = "so", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Southern Sotho", value:  new LanguageCodeDef() {Code = "st", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish", value:  new LanguageCodeDef() {Code = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Argentina", value:  new LanguageCodeDef() {Code = "es-AR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Bolivia", value:  new LanguageCodeDef() {Code = "es-BO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Castilian", value:  new LanguageCodeDef() {Code = "es-ES", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Chile", value:  new LanguageCodeDef() {Code = "es-CL", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Colombia", value:  new LanguageCodeDef() {Code = "es-CO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Costa Rica", value:  new LanguageCodeDef() {Code = "es-CR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Dominican Republic", value:  new LanguageCodeDef() {Code = "es-DO", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Ecuador", value:  new LanguageCodeDef() {Code = "es-EC", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/El Salvador", value:  new LanguageCodeDef() {Code = "es-SV", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Guatemala", value:  new LanguageCodeDef() {Code = "es-GT", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Honduras", value:  new LanguageCodeDef() {Code = "es-HN", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Mexico", value:  new LanguageCodeDef() {Code = "es-MX", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Nicaragua", value:  new LanguageCodeDef() {Code = "es-NI", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Panama", value:  new LanguageCodeDef() {Code = "es-PA", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Paraguay", value:  new LanguageCodeDef() {Code = "es-PY", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Peru", value:  new LanguageCodeDef() {Code = "es-PE", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Puerto Rico", value:  new LanguageCodeDef() {Code = "es-PR", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Spain", value:  new LanguageCodeDef() {Code = "es-ES", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Uruguay", value:  new LanguageCodeDef() {Code = "es-UY", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Venezuela", value:  new LanguageCodeDef() {Code = "es-VE", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Spanish/Latin Americas", value:  new LanguageCodeDef() {Code = "es-US", GoogleCode = "es", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Sundanese", value:  new LanguageCodeDef() {Code = "su", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Swahili", value:  new LanguageCodeDef() {Code = "sw", HasJoinedWords = false});
            Add(key:  "Swati", value:  new LanguageCodeDef() {Code = "ss", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Swedish", value:  new LanguageCodeDef() {Code = "sv", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Swedish/Finland", value:  new LanguageCodeDef() {Code = "sv-FI", GoogleCode = "sv", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Swedish/Sweden", value:  new LanguageCodeDef() {Code = "sv-SE", GoogleCode = "sv", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tamil", value:  new LanguageCodeDef() {Code = "ta", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tatar", value:  new LanguageCodeDef() {Code = "tt", GoogleCode = "-", HasJoinedWords = false});
            Add(key:  "Telugu", value:  new LanguageCodeDef() {Code = "te", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tajik", value:  new LanguageCodeDef() {Code = "tg", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Thai", value:  new LanguageCodeDef() {Code = "th", HasJoinedWords = true});
            Add(key:  "Tigrinya", value:  new LanguageCodeDef() {Code = "ti", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tibetan", value:  new LanguageCodeDef() {Code = "bo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Turkmen", value:  new LanguageCodeDef() {Code = "tk", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tagalog", value:  new LanguageCodeDef() {Code = "tl", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tswana", value:  new LanguageCodeDef() {Code = "tn", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tonga", value:  new LanguageCodeDef() {Code = "to", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Turkish", value:  new LanguageCodeDef() {Code = "tr", HasJoinedWords = false});
            Add(key:  "Tsonga", value:  new LanguageCodeDef() {Code = "ts", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Twi", value:  new LanguageCodeDef() {Code = "tw", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Tahitian", value:  new LanguageCodeDef() {Code = "ty", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Uighur", value:  new LanguageCodeDef() {Code = "ug", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Ukrainian", value:  new LanguageCodeDef() {Code = "uk", HasJoinedWords = false, PluralRule = 5});
            Add(key:  "Urdu", value:  new LanguageCodeDef() {Code = "ur", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Uzbek", value:  new LanguageCodeDef() {Code = "uz", HasJoinedWords = false, PluralRule = 2});
            Add(key:  "Venda", value:  new LanguageCodeDef() {Code = "ve", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Vietnamese", value:  new LanguageCodeDef() {Code = "vi", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Volapük", value:  new LanguageCodeDef() {Code = "vo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Walloon", value:  new LanguageCodeDef() {Code = "wa", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Welsh", value:  new LanguageCodeDef() {Code = "cy", HasJoinedWords = false, PluralRule = 16});
            Add(key:  "Wolof", value:  new LanguageCodeDef() {Code = "wo", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Frisian", value:  new LanguageCodeDef() {Code = "fy", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Xhosa", value:  new LanguageCodeDef() {Code = "xh", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Yiddish", value:  new LanguageCodeDef() {Code = "yi", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Yoruba", value:  new LanguageCodeDef() {Code = "yo", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Zhuang", value:  new LanguageCodeDef() {Code = "za", GoogleCode = "-", HasJoinedWords = false, PluralRule = 1});
            Add(key:  "Zulu", value:  new LanguageCodeDef() {Code = "zu", HasJoinedWords = false, PluralRule = 1});
            I2.Loc.GoogleLanguages.mLanguageDef = new System.Collections.Generic.Dictionary<System.String, LanguageCodeDef>(comparer:  System.StringComparer.Ordinal);
        }
    
    }

}
