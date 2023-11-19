using UnityEngine;

namespace I2.Loc
{
    public static class GoogleTranslation
    {
        // Fields
        private static System.Collections.Generic.List<UnityEngine.WWW> mCurrentTranslations;
        private static System.Collections.Generic.List<I2.Loc.TranslationJob> mTranslationJobs;
        
        // Methods
        public static bool CanTranslate()
        {
            var val_5;
            System.Collections.Generic.List<I2.Loc.LanguageSource> val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            val_6 = I2.Loc.LocalizationManager.Sources;
            if(val_6.Count >= 1)
            {
                    val_6 = I2.Loc.LocalizationManager.GetWebServiceURL(source:  0);
                val_7 = (System.String.IsNullOrEmpty(value:  0)) ^ 1;
                return (bool)val_7 & 1;
            }
            
            val_7 = 0;
            return (bool)val_7 & 1;
        }
        public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Action<string, string> OnTranslationReady)
        {
            var val_8;
            var val_9;
            var val_10;
            System.Action<System.String, System.String> val_11;
            var val_12;
            string val_13;
            string val_14;
            var val_15;
            var val_16;
            string val_17;
            var val_18;
            val_8 = X4;
            GoogleTranslation.<Translate>c__AnonStorey1 val_1 = new GoogleTranslation.<Translate>c__AnonStorey1();
            if(null != 0)
            {
                    val_9 = val_1;
                val_10 = val_1;
                typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_10 = val_8;
                typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_18 = LanguageCodeFrom;
            }
            else
            {
                    val_9 = 16;
                mem[16] = val_8;
                val_10 = 24;
                mem[24] = LanguageCodeFrom;
            }
            
            typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_28 = OnTranslationReady;
            I2.Loc.LocalizationManager.InitializeIfNeeded();
            val_11 = I2.Loc.GoogleTranslation.CanTranslate();
            if(val_11 == false)
            {
                goto label_8;
            }
            
            val_8 = 1152921504608284672;
            val_11 = typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_28;
            if((System.String.op_Equality(a:  0, b:  val_11)) == false)
            {
                goto label_11;
            }
            
            if(null == 0)
            {
                goto label_12;
            }
            
            goto label_13;
            label_8:
            val_12 = mem[16];
            val_13 = 0;
            val_14 = "WebService is not set correctly or needs to be reinstalled";
            val_15 = public System.Void System.Action<System.String, System.String>::Invoke(System.String arg1, System.String arg2);
            goto label_15;
            label_11:
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_5 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>();
            if(null == 0)
            {
                goto label_16;
            }
            
            val_16 = val_1;
            typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_20 = val_5;
            goto label_17;
            label_12:
            val_12 = mem[16];
            label_13:
            if(val_12 != 0)
            {
                goto label_25;
            }
            
            goto label_19;
            label_16:
            val_16 = 32;
            mem[32] = val_5;
            label_17:
            val_11 = typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_28;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_22;
            }
            
            val_18 = null;
            val_12 = mem[16];
            val_18 = null;
            val_17 = System.String.Empty;
            if(val_12 != 0)
            {
                goto label_25;
            }
            
            label_19:
            label_25:
            val_14 = 0;
            val_13 = val_17;
            val_15 = public System.Void System.Action<System.String, System.String>::Invoke(System.String arg1, System.String arg2);
            label_15:
            val_12.Invoke(arg1:  val_13, arg2:  val_14);
            return;
            label_22:
            I2.Loc.GoogleTranslation.CreateQueries(text:  null, LanguageCodeFrom:  mem[24], LanguageCodeTo:  LanguageCodeTo, dict:  typeof(GoogleTranslation.<Translate>c__AnonStorey1).__il2cppRuntimeField_28);
            I2.Loc.GoogleTranslation.Translate(requests:  new System.Action<System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>, System.String>(object:  val_1, method:  System.Void GoogleTranslation.<Translate>c__AnonStorey1::<>m__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error)) = new System.Action<System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>, System.String>(object:  val_1, method:  System.Void GoogleTranslation.<Translate>c__AnonStorey1::<>m__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error)), OnTranslationReady:  mem[32], usePOST:  false);
        }
        public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
        {
            var val_3;
            I2.Loc.GoogleTranslation.AddQuery(text:  null, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  X3);
            do
            {
            
            }
            while(null == 0);
            
            if((new I2.Loc.TranslationJob_Main(requests:  new System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>(), OnTranslationReady:  0)) == 2)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            return I2.Loc.GoogleTranslation.GetQueryResult(text:  null, LanguageCodeTo:  LanguageCodeFrom, dict:  System.String.Empty);
        }
        public static void Translate(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady, bool usePOST = True)
        {
            I2.Loc.TranslationJob_Main val_1 = new I2.Loc.TranslationJob_Main(requests:  OnTranslationReady, OnTranslationReady:  usePOST);
            I2.Loc.GoogleTranslation.AddTranslationJob(job:  null);
        }
        public static bool ForceTranslate(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, bool usePOST = True)
        {
            do
            {
            
            }
            while(null == 0);
            
            return (bool)((new I2.Loc.TranslationJob_Main(requests:  usePOST, OnTranslationReady:  0)) != 2) ? 1 : 0;
        }
        public static System.Collections.Generic.List<string> ConvertTranslationRequest(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, bool encodeGET)
        {
            var val_9;
            var val_11;
            string val_30;
            var val_31;
            var val_32;
            Dictionary.Enumerator<TKey, TValue> val_3 = encodeGET.GetEnumerator();
            label_39:
            if((0 & 1) == 0)
            {
                goto label_45;
            }
            
            val_30 = val_9;
            if(Length >= 1)
            {
                    System.Text.StringBuilder val_13 = Append(value:  "<I2Loc>");
            }
            
            System.Text.StringBuilder val_15 = Append(value:  I2.Loc.GoogleLanguages.GetGoogleLanguageCode(InternationalCode:  null));
            System.Text.StringBuilder val_16 = Append(value:  ":");
            val_31 = 0;
            goto label_10;
            label_20:
            val_31 = 1;
            label_10:
            if(val_31 >= (val_11 + 24))
            {
                goto label_12;
            }
            
            if(val_31 != 0)
            {
                    System.Text.StringBuilder val_17 = Append(value:  ",");
            }
            
            var val_18 = val_11 + 8;
            System.Text.StringBuilder val_20 = Append(value:  I2.Loc.GoogleLanguages.GetGoogleLanguageCode(InternationalCode:  null));
            goto label_20;
            label_12:
            System.Text.StringBuilder val_21 = Append(value:  "=");
            if((System.String.op_Equality(a:  0, b:  I2.Loc.GoogleTranslation.TitleCase(s:  null))) != false)
            {
                    val_30 = val_30.ToLowerInvariant();
            }
            
            if(((W2 & 1) & 1) == 0)
            {
                goto label_28;
            }
            
            System.Text.StringBuilder val_26 = Append(value:  System.Uri.EscapeDataString(stringToEscape:  0));
            if(Length < 4001)
            {
                goto label_39;
            }
            
            Add(item:  new System.Text.StringBuilder());
            Length = 0;
            goto label_39;
            label_28:
            System.Text.StringBuilder val_28 = Append(value:  val_30);
            goto label_39;
            label_45:
            val_32 = public System.Void Dictionary.Enumerator<System.String, I2.Loc.TranslationQuery>::Dispose();
            Dispose();
            if(((0 & 1) == 0) && (null != null))
            {
                    val_32 = 0;
            }
            
            bool val_29 = MoveNext();
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
        }
        private static void AddTranslationJob(I2.Loc.TranslationJob job)
        {
            null = null;
            I2.Loc.GoogleTranslation.mTranslationJobs.Add(item:  X1);
            if(I2.Loc.GoogleTranslation.mTranslationJobs.Count != 1)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_3 = I2.Loc.CoroutineManager.Start(coroutine:  I2.Loc.GoogleTranslation.WaitForTranslations());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private static System.Collections.IEnumerator WaitForTranslations()
        {
            return (System.Collections.IEnumerator)new GoogleTranslation.<WaitForTranslations>c__Iterator0();
        }
        public static string ParseTranslationResult(string html, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests)
        {
            System.String[] val_11;
            string val_12;
            var val_14;
            var val_15;
            var val_16;
            var val_26;
            string val_27;
            var val_28;
            string val_29;
            var val_30;
            var val_31;
            string val_32;
            var val_33;
            if((requests.StartsWith(value:  "<!DOCTYPE html>")) != true)
            {
                    if((requests.StartsWith(value:  "<HTML>")) == false)
            {
                goto label_4;
            }
            
            }
            
            if((requests.Contains(value:  "The script completed but did not return anything")) != false)
            {
                    val_27 = "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
                return (string)0 + "There was a problem contacting the WebService. Please try again later\n";
            }
            
            val_26 = 1152921504608284672;
            val_28 = null;
            if((requests.Contains(value:  "Service invoked too many times in a short time")) == false)
            {
                    return (string)0 + "There was a problem contacting the WebService. Please try again later\n";
            }
            
            val_28 = null;
            val_27 = System.String.Empty;
            return (string)0 + "There was a problem contacting the WebService. Please try again later\n";
            label_4:
            typeof(System.String[]).__il2cppRuntimeField_20 = "<I2Loc>";
            System.String[] val_8 = requests.Split(separator:  null, options:  0);
            typeof(System.String[]).__il2cppRuntimeField_20 = "<i2>";
            Dictionary.KeyCollection<TKey, TValue> val_9 = X2.Keys;
            TSource[] val_10 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            val_26 = 1152921504964939776;
            var val_29 = 0;
            goto label_23;
            label_56:
            X2.set_Item(key:  X23, value:  new I2.Loc.TranslationQuery() {OrigText = ???, Text = val_12, LanguageCode = val_12, TargetLanguagesCode = val_11, Results = ???});
            label_23:
            if(val_29 >= val_10.Length)
            {
                goto label_25;
            }
            
            TSource val_25 = val_10[0];
            I2.Loc.TranslationQuery val_13 = I2.Loc.GoogleTranslation.FindQueryFromOrigText(origText:  null, dict:  val_25);
            val_29 = val_8[0];
            if(val_14 == 0)
            {
                goto label_32;
            }
            
            var val_26 = val_14 + 24;
            val_26 = val_26 - 1;
            if((val_26 & 2147483648) != 0)
            {
                goto label_32;
            }
            
            val_30 = val_10;
            val_31 = val_8;
            var val_27 = (long)val_26;
            do
            {
                var val_18 = val_14 + (((long)(int)((val_14 + 24 - 1))) << 3);
                val_29 = val_29.Replace(oldValue:  I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  358092800), newValue:  (val_14 + ((long)(int)((val_14 + 24 - 1))) << 3) + 32);
                val_27 = val_27 - 1;
            }
            while((val_27 & 2147483648) == 0);
            
            goto label_38;
            label_32:
            val_30 = val_10;
            val_31 = val_8;
            label_38:
            val_32 = null;
            if((System.String.op_Equality(a:  0, b:  I2.Loc.GoogleTranslation.TitleCase(s:  val_32))) == false)
            {
                goto label_47;
            }
            
            val_33 = 0;
            goto label_45;
            label_54:
            val_33 = 1;
            mem2[0] = val_25;
            label_45:
            if(val_33 >= val_20.Length)
            {
                goto label_47;
            }
            
            string val_28 = val_29.Split(separator:  null, options:  0)[1];
            string val_23 = I2.Loc.GoogleTranslation.TitleCase(s:  null);
            if(val_33 < val_20.Length)
            {
                goto label_54;
            }
            
            goto label_54;
            label_47:
            val_29 = val_29 + 1;
            val_11 = val_15;
            val_12 = val_16;
            if(X2 != 0)
            {
                goto label_56;
            }
            
            goto label_56;
            label_25:
            val_27 = 0;
            return (string)0 + "There was a problem contacting the WebService. Please try again later\n";
        }
        public static bool IsTranslating()
        {
            var val_4;
            System.Collections.Generic.List<UnityEngine.WWW> val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = I2.Loc.GoogleTranslation.mCurrentTranslations;
            if(val_5.Count > 0)
            {
                    val_6 = 1;
                return (bool)(val_5.Count > 0) ? 1 : 0;
            }
            
            val_7 = null;
            val_7 = null;
            val_5 = I2.Loc.GoogleTranslation.mTranslationJobs;
            return (bool)(val_5.Count > 0) ? 1 : 0;
        }
        public static void CancelCurrentGoogleTranslations()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            I2.Loc.GoogleTranslation.mCurrentTranslations.Clear();
            List.Enumerator<T> val_1 = I2.Loc.GoogleTranslation.mTranslationJobs.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            object val_3 = 0.InitializationCallback.Clone();
            goto label_7;
            label_5:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            val_7 = null;
            val_7 = null;
            I2.Loc.GoogleTranslation.mTranslationJobs.Clear();
        }
        public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_6;
            I2.Loc.GoogleTranslation val_7;
            var val_8;
            val_7 = X4;
            if((LanguageCodeFrom.Contains(value:  "[i2s_")) == false)
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = I2.Loc.SpecializationManager.GetSpecializations(text:  0, buffer:  LanguageCodeFrom).GetEnumerator();
            val_6 = 1152921509259337008;
            label_9:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Playables.PlayableHandle val_5 = 0.GetHandle();
            I2.Loc.GoogleTranslation.CreateQueries_Plurals(text:  null, LanguageCodeFrom:  val_5.m_Handle, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            goto label_9;
            label_2:
            I2.Loc.GoogleTranslation.CreateQueries_Plurals(text:  null, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  LanguageCodeTo, dict:  dict);
            return;
            label_6:
            val_7 = 0;
            val_8 = 1;
            0.Dispose();
            if((val_8 & 1) != 0)
            {
                    return;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
        
        }
        private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_16;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_17;
            var val_18;
            string val_19;
            var val_20;
            string val_21;
            string val_22;
            string val_23;
            string val_24;
            bool val_25;
            val_16 = X4;
            val_17 = dict;
            val_19 = LanguageCodeTo;
            if(LanguageCodeFrom != null)
            {
                    val_20 = LanguageCodeFrom.Contains(value:  "{[#");
            }
            else
            {
                    val_20 = 0.Contains(value:  "{[#");
            }
            
            val_21 = LanguageCodeFrom;
            val_22 = 1152921504964939776;
            val_21 = null;
            if(((val_20 | (val_21.Contains(value:  "[i2p_"))) != false) && ((I2.Loc.GoogleTranslation.HasParameters(text:  val_21)) != false))
            {
                    val_18 = 1152921504964833280;
                do
            {
                val_23 = 0;
                string val_6 = 0.ToString();
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                if((I2.Loc.GoogleLanguages.LanguageHasPluralType(langCode:  null, pluralType:  val_17)) != false)
            {
                    val_25 = I2.Loc.GoogleTranslation.GetPluralText(text:  null, pluralType:  LanguageCodeFrom);
                val_24 = null;
                int val_10 = I2.Loc.GoogleLanguages.GetPluralTestNumber(langCode:  val_24, pluralType:  val_17);
                bool val_11 = val_20;
                val_23 = I2.Loc.GoogleTranslation.GetPluralParameter(text:  val_10, forceTag:  val_25);
                if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_16 = val_16;
                val_19 = val_19;
                val_22 = val_22;
                val_20 = val_20;
                val_18 = val_18;
                val_17 = val_17;
                val_25 = val_25.Replace(oldValue:  val_23, newValue:  val_10);
            }
            
                I2.Loc.GoogleTranslation.AddQuery(text:  val_22, LanguageCodeFrom:  val_25, LanguageCodeTo:  val_19, dict:  val_17);
            }
            
                I2.Loc.ePluralType val_16 = val_16 + 1;
            }
            while(val_16 < 6);
            
                return;
            }
            
            I2.Loc.GoogleTranslation.AddQuery(text:  null, LanguageCodeFrom:  LanguageCodeFrom, LanguageCodeTo:  val_19, dict:  val_17);
        }
        public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            string val_6;
            UnityEngine.Object val_7;
            string val_8;
            var val_9;
            var val_15;
            UnityEngine.Object val_16;
            var val_17;
            var val_18;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            if((X4.ContainsKey(key:  LanguageCodeFrom)) != false)
            {
                    I2.Loc.TranslationQuery val_5 = X4.Item[LanguageCodeFrom];
                val_16 = val_7;
                if(((System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  val_16)) & 2147483648) != 0)
            {
                    val_15 = null;
                typeof(System.String[]).__il2cppRuntimeField_20 = dict;
                System.Collections.Generic.IEnumerable<TSource> val_11 = System.Linq.Enumerable.Concat<System.String>(first:  0, second:  val_16);
                System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  0);
                val_16 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            }
            
                val_6 = val_6;
                val_8 = val_8;
                val_17;
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>::set_Item(System.String key, I2.Loc.TranslationQuery value);
            }
            else
            {
                    val_15 = null;
                typeof(System.String[]).__il2cppRuntimeField_20 = dict;
                I2.Loc.GoogleTranslation.ParseNonTranslatableElements(query: ref  new I2.Loc.TranslationQuery());
                val_6 = LanguageCodeTo;
                val_9 = 0;
                val_8 = LanguageCodeFrom;
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>::set_Item(System.String key, I2.Loc.TranslationQuery value);
            }
            
            X4.set_Item(key:  LanguageCodeFrom, value:  new I2.Loc.TranslationQuery() {OrigText = val_8, Text = val_8, LanguageCode = val_6, TargetLanguagesCode = val_6});
        }
        private static string GetTranslation(string text, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            UnityEngine.Object val_3;
            var val_4;
            var val_7;
            string val_8;
            var val_9;
            val_7 = dict;
            if((X3.ContainsKey(key:  LanguageCodeTo)) == false)
            {
                goto label_2;
            }
            
            I2.Loc.TranslationQuery val_2 = X3.Item[LanguageCodeTo];
            int val_5 = System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  val_3);
            if(((val_5 & 2147483648) != 0) || (val_4 == 0))
            {
                goto label_5;
            }
            
            val_7 = (long)val_5;
            var val_6 = val_4 + (((long)(int)(val_5)) << 3);
            val_8 = mem[(val_4 + ((long)(int)(val_5)) << 3) + 32];
            val_8 = (val_4 + ((long)(int)(val_5)) << 3) + 32;
            return val_8;
            label_2:
            val_8 = 0;
            return val_8;
            label_5:
            val_7 = 1152921504608284672;
            val_9 = null;
            val_9 = null;
            val_8 = System.String.Empty;
            return val_8;
        }
        private static I2.Loc.TranslationQuery FindQueryFromOrigText(string origText, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            string val_6;
            System.String[] val_8;
            string val_9;
            string val_10;
            string val_12;
            var val_13;
            I2.Loc.TranslationQuery val_0;
            val_12 = X2;
            Dictionary.Enumerator<TKey, TValue> val_1 = val_12.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_12 = val_6;
            if((System.String.op_Equality(a:  0, b:  val_12)) == false)
            {
                goto label_5;
            }
            
            val_13 = 1152921512228172144;
            Dispose();
            val_0.LanguageCode = val_9;
            val_0.Results = val_8;
            val_0.OrigText = val_10;
            return val_0;
            label_2:
            val_13 = 1152921512228172144;
            Dispose();
            val_0.Results = 0;
            val_0.Tags = 0;
            val_0.LanguageCode = 0;
            val_0.TargetLanguagesCode = 0;
            val_0.OrigText = 0;
            val_0.Text = 0;
            return val_0;
        }
        public static bool HasParameters(string text)
        {
            var val_4;
            int val_1 = X1.IndexOf(value:  "{[");
            if((val_1 & 2147483648) == 0)
            {
                    var val_3 = ((X1.IndexOf(value:  "]}", startIndex:  val_1)) > 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public static string GetPluralParameter(string text, bool forceTag)
        {
            var val_6;
            int val_7;
            val_6 = W2;
            val_7 = forceTag.IndexOf(value:  "{[#");
            if((val_7 & 2147483648) != 0)
            {
                    if(((val_6 & 1) & 1) != 0)
            {
                    return 0;
            }
            
                val_7 = forceTag.IndexOf(value:  "{[");
                if((val_7 & 2147483648) != 0)
            {
                    return 0;
            }
            
            }
            
            int val_4 = val_7 + 2;
            val_6 = forceTag.IndexOf(value:  "]}", startIndex:  val_4);
            if((val_6 & 2147483648) != 0)
            {
                    return 0;
            }
            
            var val_6 = 2;
            val_6 = val_6 - val_7;
            val_4 = val_6 + val_6;
            return forceTag.Substring(startIndex:  val_7, length:  val_4);
        }
        public static string GetPluralText(string text, string pluralType)
        {
            var val_10;
            int val_11;
            int val_12;
            int val_13;
            string val_1 = 0 + "[i2p_" + X2;
            val_10 = pluralType.IndexOf(value:  val_1);
            if((val_10 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            val_11 = val_1.Length + val_10;
            if(pluralType != null)
            {
                goto label_14;
            }
            
            goto label_7;
            label_4:
            int val_4 = pluralType.IndexOf(value:  "[i2p_");
            if((val_4 & 2147483648) != 0)
            {
                    return (string)pluralType;
            }
            
            if(val_4 >= 1)
            {
                    val_12 = 0;
                val_13 = val_4;
                return pluralType.Substring(startIndex:  val_12 = val_11, length:  val_13 = val_10 - val_11);
            }
            
            int val_5 = pluralType.IndexOf(value:  "]");
            if((val_5 & 2147483648) != 0)
            {
                    return (string)pluralType;
            }
            
            val_11 = val_5 + 1;
            if(pluralType != null)
            {
                goto label_14;
            }
            
            label_7:
            label_14:
            val_10 = pluralType.IndexOf(value:  "[i2p_", startIndex:  val_11);
            if((val_10 & 2147483648) != 0)
            {
                    val_10 = pluralType.Length;
            }
            
            return pluralType.Substring(startIndex:  val_12, length:  val_13);
        }
        private static int FindClosingTag(string tag, System.Text.RegularExpressions.MatchCollection matches, int startIndex)
        {
            var val_8;
            string val_9;
            val_8 = W3;
            int val_1 = startIndex.Count;
            if(val_1 > val_8)
            {
                    do
            {
                val_9 = I2.Loc.I2Utils.GetCaptureMatch(match:  0);
                if((val_9.Chars[0] & 65535) == ('/'))
            {
                    val_9 = val_9.Substring(startIndex:  1);
                if((matches.StartsWith(value:  val_9)) == true)
            {
                    return (int)val_8;
            }
            
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_1);
            
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        private static string GetGoogleNoTranslateTag(int tagNumber)
        {
            var val_3;
            var val_3 = W1;
            if(val_3 <= 69)
            {
                    return Substring(startIndex:  0, length:  val_3 + 1);
            }
            
            val_3 = null;
            val_3 = null;
            val_3 = val_3 + 1;
            goto label_4;
            label_7:
            val_3 = null;
            label_4:
            val_3 = val_3 - 1;
            if(val_3 != 0)
            {
                goto label_7;
            }
            
            return (string)0 + System.String.Empty;
        }
        private static void ParseNonTranslatableElements(ref I2.Loc.TranslationQuery query)
        {
            var val_35;
            string val_36;
            int val_37;
            string val_38;
            string val_39;
            var val_40;
            string val_41;
            var val_42;
            var val_43;
            var val_44;
            val_35 = X1;
            val_36 = mem[X1 + 8];
            val_36 = X1 + 8;
            System.Text.RegularExpressions.MatchCollection val_1 = System.Text.RegularExpressions.Regex.Matches(input:  0, pattern:  val_36);
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.Count == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            val_37 = val_1.Count;
            if(val_37 < 1)
            {
                goto label_5;
            }
            
            var val_35 = 0;
            label_47:
            string val_5 = I2.Loc.I2Utils.GetCaptureMatch(match:  0);
            val_38 = null;
            if(((I2.Loc.GoogleTranslation.FindClosingTag(tag:  val_38, matches:  val_5, startIndex:  val_1)) & 2147483648) != 0)
            {
                goto label_8;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_5)) == false)
            {
                goto label_11;
            }
            
            val_39 = X1 + 8.Substring(startIndex:  val_1.Index, length:  (val_1.Index - val_1.Index) + val_1.Length);
            val_40 = val_3;
            int val_15 = Count;
            val_35 = val_35;
            val_40 = null;
            val_37 = val_37;
            val_41 = I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  358092800);
            val_42 = null;
            goto label_31;
            label_8:
            val_36 = val_1;
            val_39 = val_36.ToString();
            if(((val_39.StartsWith(value:  "{[")) == false) || ((val_39.EndsWith(value:  "]}")) == false))
            {
                goto label_34;
            }
            
            val_43 = val_3;
            int val_20 = Count;
            val_43 = null;
            val_42 = null;
            val_41 = I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  358092800);
            label_31:
            val_36 = 0 + val_41;
            if((X1 + 8) == 0)
            {
                    val_37 = val_37;
            }
            
            Add(item:  val_39);
            goto label_34;
            label_11:
            string val_24 = val_1.ToString();
            val_44 = val_3;
            int val_25 = Count;
            val_44 = null;
            Add(item:  val_24);
            val_39 = val_1.ToString();
            val_36 = 0 + I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  Count)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  Count));
            Add(item:  val_39);
            val_35 = val_35;
            val_37 = val_37;
            label_34:
            val_35 = val_35 + 1;
            if(val_37 != val_35)
            {
                goto label_47;
            }
            
            label_5:
            mem2[0] = X1 + 8.Replace(oldValue:  val_39, newValue:  val_36).Replace(oldValue:  val_24, newValue:  0 + I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  358092800)(I2.Loc.GoogleTranslation.GetGoogleNoTranslateTag(tagNumber:  358092800))).Replace(oldValue:  val_39, newValue:  val_36);
            mem2[0] = ToArray();
        }
        public static string GetQueryResult(string text, string LanguageCodeTo, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict)
        {
            var val_3;
            UnityEngine.Object val_4;
            string val_8;
            var val_9;
            val_8 = LanguageCodeTo;
            if((X3.ContainsKey(key:  val_8)) == false)
            {
                goto label_5;
            }
            
            I2.Loc.TranslationQuery val_2 = X3.Item[val_8];
            val_8 = val_3;
            if((val_8 == 0) || (((val_3 + 24) & 2147483648) != 0))
            {
                goto label_5;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_8;
            }
            
            val_9 = mem[val_3 + 32];
            val_9 = val_3 + 32;
            return (string)val_9;
            label_5:
            val_9 = 0;
            return (string)val_9;
            label_8:
            if(((System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  val_4)) & 2147483648) != 0)
            {
                    return (string)val_9;
            }
            
            var val_7 = val_8 + (((long)(int)(val_6)) << 3);
            return (string)val_9;
        }
        public static string RebuildTranslation(string text, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string LanguageCodeTo)
        {
            System.Collections.Generic.Dictionary<TKey, TValue> val_11 = X3;
            if((dict.Contains(value:  "[i2s_")) == false)
            {
                    return (string)I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  null, dict:  dict, LanguageCodeTo:  LanguageCodeTo);
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_4 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Dictionary.Enumerator<TKey, TValue> val_5 = I2.Loc.SpecializationManager.GetSpecializations(text:  0, buffer:  dict).GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_18;
            }
            
            UnityEngine.Playables.PlayableHandle val_6 = 0.GetHandle();
            set_Item(key:  val_6.m_Handle.InitializationCallback, value:  I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  null, dict:  val_6.m_Handle, LanguageCodeTo:  LanguageCodeTo));
            goto label_10;
            label_18:
            0.Dispose();
            string val_9 = I2.Loc.SpecializationManager.SetSpecializedText(specializations:  0);
            return (string)I2.Loc.GoogleTranslation.RebuildTranslation_Plural(text:  null, dict:  dict, LanguageCodeTo:  LanguageCodeTo);
        }
        private static string RebuildTranslation_Plural(string text, System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string LanguageCodeTo)
        {
            var val_26;
            string val_27;
            string val_28;
            var val_29;
            string val_30;
            string val_31;
            bool val_32;
            string val_33;
            var val_34;
            var val_35;
            if(dict != null)
            {
                    bool val_1 = dict.Contains(value:  "{[#");
            }
            else
            {
                    bool val_2 = 0.Contains(value:  "{[#");
            }
            
            val_27 = dict;
            val_28 = 1152921504964939776;
            val_29 = val_27.Contains(value:  "[i2p_");
            val_27 = null;
            bool val_26 = val_2;
            val_26 = val_26 | val_29;
            if(val_26 == false)
            {
                    return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  null, LanguageCodeTo:  dict, dict:  X3);
            }
            
            if((I2.Loc.GoogleTranslation.HasParameters(text:  val_27)) == false)
            {
                    return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  null, LanguageCodeTo:  dict, dict:  X3);
            }
            
            val_29 = 1152921504964833280;
            label_33:
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_30 = X3;
            if((I2.Loc.GoogleLanguages.LanguageHasPluralType(langCode:  null, pluralType:  val_30)) == false)
            {
                goto label_11;
            }
            
            val_32 = I2.Loc.GoogleTranslation.GetPluralText(text:  null, pluralType:  dict);
            val_31 = null;
            int val_11 = I2.Loc.GoogleLanguages.GetPluralTestNumber(langCode:  val_31, pluralType:  X3);
            bool val_12 = val_2;
            string val_13 = I2.Loc.GoogleTranslation.GetPluralParameter(text:  val_11, forceTag:  val_32);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_32 = val_32.Replace(oldValue:  val_13, newValue:  val_11);
                val_28 = val_28;
            }
            
            val_33 = I2.Loc.GoogleTranslation.GetTranslation(text:  val_28, LanguageCodeTo:  val_32, dict:  X3);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_33 = val_33.Replace(oldValue:  val_11, newValue:  val_13);
            }
            
            val_34 = val_33;
            if(null == 5)
            {
                goto label_26;
            }
            
            val_30 = val_33;
            if((System.String.op_Equality(a:  0, b:  val_30)) == false)
            {
                goto label_29;
            }
            
            label_11:
            val_34 = 0;
            goto label_30;
            label_29:
            System.Text.StringBuilder val_23 = AppendFormat(format:  "[i2p_{0}]", arg0:  5.ToString());
            val_34 = 0;
            label_26:
            val_30 = val_33;
            System.Text.StringBuilder val_24 = Append(value:  val_30);
            label_30:
            I2.Loc.ePluralType val_27 = val_27 - 1;
            if((val_27 & 2147483648) == 0)
            {
                goto label_33;
            }
            
            val_26 = new System.Text.StringBuilder();
            val_35 = val_26;
            return (string)I2.Loc.GoogleTranslation.GetTranslation(text:  null, LanguageCodeTo:  dict, dict:  X3);
        }
        public static string UppercaseFirst(string s)
        {
            var val_5;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_5 = null;
                val_5 = null;
                return (string)System.String.Empty;
            }
            
            System.Char[] val_3 = X1.ToLower().ToCharArray();
            char val_5 = val_3[0];
            val_3[0] = System.Char.ToUpper(c:  ' ');
            return 0.CreateString(val:  val_3);
        }
        public static string TitleCase(string s)
        {
            var val_3;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_3 = null;
                val_3 = null;
                return (string)System.String.Empty;
            }
            
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
            if(val_2 != null)
            {
                    return val_2.ToTitleCase(str:  X1);
            }
            
            return val_2.ToTitleCase(str:  X1);
        }
        private static GoogleTranslation()
        {
            I2.Loc.GoogleTranslation.mCurrentTranslations = new System.Collections.Generic.List<UnityEngine.WWW>();
            I2.Loc.GoogleTranslation.mTranslationJobs = new System.Collections.Generic.List<I2.Loc.TranslationJob>();
        }
    
    }

}
