using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_WEB : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        public string mErrorMessage;
        private string mCurrentBatch_ToLanguageCode;
        private string mCurrentBatch_FromLanguageCode;
        private System.Collections.Generic.List<string> mCurrentBatch_Text;
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> mQueries;
        private static System.Comparison<System.Collections.Generic.KeyValuePair<string, string>> <>f__am$cache0;
        private static System.Text.RegularExpressions.MatchEvaluator <>f__am$cache1;
        private static System.Text.RegularExpressions.MatchEvaluator <>f__am$cache2;
        
        // Methods
        public TranslationJob_WEB(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            val_1 = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            val_1.FindAllQueries();
            val_1.ExecuteNextBatch();
        }
        private void FindAllQueries()
        {
            var val_7;
            string val_10;
            var val_13;
            System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_14;
            var val_15;
            this.mQueries = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.String>>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this._requests.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            val_13 = 0;
            goto label_3;
            label_10:
            val_13 = 1;
            label_3:
            if(val_13 >= (val_7 + 24))
            {
                goto label_5;
            }
            
            var val_8 = val_7 + 8;
            string val_11 = 0 + val_10 + ":"(":");
            this.mQueries.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, System.String>());
            goto label_10;
            label_16:
            Dispose();
            val_15 = null;
            if((I2.Loc.TranslationJob_WEB.<>f__am$cache0) == null)
            {
                    System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>> val_12 = null;
                val_14 = val_12;
                val_12 = new System.Comparison<System.Collections.Generic.KeyValuePair<System.String, System.String>>(object:  0, method:  static System.Int32 I2.Loc.TranslationJob_WEB::<FindAllQueries>m__0(System.Collections.Generic.KeyValuePair<string, string> a, System.Collections.Generic.KeyValuePair<string, string> b));
                I2.Loc.TranslationJob_WEB.<>f__am$cache0 = val_14;
                val_15 = null;
            }
            
            this.mQueries.Sort(comparison:  I2.Loc.TranslationJob_WEB.<>f__am$cache0);
        }
        private void ExecuteNextBatch()
        {
            var val_16;
            var val_17;
            System.Char[] val_18;
            string val_19;
            if(this.mQueries.Count == 0)
            {
                goto label_2;
            }
            
            this.mCurrentBatch_Text = new System.Collections.Generic.List<System.String>();
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
            val_16 = 0;
            val_17 = 0;
            goto label_3;
            label_17:
            val_16 = 1;
            label_3:
            if(val_16 >= this.mQueries.Count)
            {
                goto label_5;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_5 = this.mQueries.Item[1];
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.Value.InitializationCallback;
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_7 = this.mQueries.Item[1];
            if(val_17 != 0)
            {
                    if((System.String.op_Equality(a:  0, b:  val_7.Value)) == false)
            {
                goto label_11;
            }
            
            }
            
            if(val_16 != 0)
            {
                    System.Text.StringBuilder val_9 = Append(value:  "|||");
            }
            
            System.Text.StringBuilder val_10 = Append(value:  val_6);
            this.mCurrentBatch_Text.Add(item:  val_6);
            val_17 = ;
            label_11:
            if(Length <= 200)
            {
                goto label_17;
            }
            
            label_5:
            this.mQueries.RemoveRange(index:  0, count:  1);
            typeof(System.Char[]).__il2cppRuntimeField_20 = 58;
            val_18 = null;
            System.String[] val_12 = val_7.Value.Split(separator:  val_18);
            if(val_12.Length == 0)
            {
                    val_18 = 0;
            }
            
            val_19 = val_12[0];
            this.mCurrentBatch_FromLanguageCode = val_19;
            if(val_12.Length <= 1)
            {
                    val_18 = 0;
                val_19 = this.mCurrentBatch_FromLanguageCode;
            }
            
            string val_16 = val_12[1];
            this.mCurrentBatch_ToLanguageCode = val_16;
            string val_13 = System.Uri.EscapeUriString(stringToEscape:  0);
            UnityEngine.Debug.Log(message:  0);
            mem[1152921512257399672] = new UnityEngine.WWW(url:  System.String.Format(format:  0, arg0:  "http://www.google.com/translate_t?hl=en&vi=c&ie=UTF8&oe=UTF8&submit=Translate&langpair={0}|{1}&text={2}", arg1:  val_19, arg2:  val_16));
            return;
            label_2:
            mem[1152921512257399664] = 1;
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this != null)
            {
                    if(this.isDone != false)
            {
                    System.Byte[] val_2 = X20.bytes;
                this.ProcessResult(bytes:  val_2, errorMsg:  X21.error);
                val_2.Dispose();
                mem[1152921512257646840] = 0;
            }
            else
            {
                    if(X20 != 0)
            {
                    return (eJobState)this;
            }
            
            }
            
            }
            
            this.ExecuteNextBatch();
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    System.Text.Encoding val_2 = System.Text.Encoding.UTF8;
                bytes = val_2.ParseTranslationResult(html:  val_2, OriginalText:  "aab");
                UnityEngine.Debug.Log(message:  0);
                if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    if(this._OnTranslationReady == null)
            {
                    return;
            }
            
                this._OnTranslationReady.Invoke(arg1:  this._requests, arg2:  0);
                return;
            }
            
            }
            
            mem[1152921512257857216] = 2;
            this.mErrorMessage = errorMsg;
        }
        private string ParseTranslationResult(string html, string OriginalText)
        {
            var val_22;
            System.Text.RegularExpressions.MatchEvaluator val_23;
            IntPtr val_24;
            System.Text.RegularExpressions.MatchEvaluator val_25;
            var val_26;
            string val_27;
            int val_22 = html.IndexOf(value:  "TRANSLATED_TEXT=\'");
            val_22 = "TRANSLATED_TEXT=\'";
            if(("TRANSLATED_TEXT=\'") == null)
            {
                    val_22 = "TRANSLATED_TEXT=\'";
            }
            
            val_22 = Length + val_22;
            int val_23 = val_22;
            val_23 = (html.IndexOf(value:  "\';var", startIndex:  val_23)) - val_22;
            val_23 = I2.Loc.TranslationJob_WEB.<>f__am$cache1;
            if(val_23 == null)
            {
                    val_24 = static System.String I2.Loc.TranslationJob_WEB::<ParseTranslationResult>m__1(System.Text.RegularExpressions.Match match);
                System.Text.RegularExpressions.MatchEvaluator val_5 = new System.Text.RegularExpressions.MatchEvaluator(object:  0, method:  val_24);
                I2.Loc.TranslationJob_WEB.<>f__am$cache1 = null;
                val_23 = I2.Loc.TranslationJob_WEB.<>f__am$cache1;
            }
            
            val_25 = I2.Loc.TranslationJob_WEB.<>f__am$cache2;
            if(val_25 == null)
            {
                    val_24 = static System.String I2.Loc.TranslationJob_WEB::<ParseTranslationResult>m__2(System.Text.RegularExpressions.Match match);
                System.Text.RegularExpressions.MatchEvaluator val_7 = new System.Text.RegularExpressions.MatchEvaluator(object:  0, method:  val_24);
                I2.Loc.TranslationJob_WEB.<>f__am$cache2 = null;
                val_25 = I2.Loc.TranslationJob_WEB.<>f__am$cache2;
            }
            
            val_26 = System.Text.RegularExpressions.Regex.Replace(input:  0, pattern:  System.Text.RegularExpressions.Regex.Replace(input:  0, pattern:  html.Substring(startIndex:  val_22, length:  val_23), evaluator:  "\\\\x([a-fA-F0-9]{2})"), evaluator:  "&#(\\d+);").Replace(oldValue:  "<br>", newValue:  "\n");
            val_27 = OriginalText.ToUpper();
            if((System.String.op_Equality(a:  0, b:  val_27)) != false)
            {
                    val_26 = val_26.ToUpper();
                return (string)val_26;
            }
            
            val_24 = 1152921504964939776;
            val_27 = I2.Loc.GoogleTranslation.UppercaseFirst(s:  0);
            if((System.String.op_Equality(a:  0, b:  val_27)) != false)
            {
                    val_26 = I2.Loc.GoogleTranslation.UppercaseFirst(s:  0);
                return (string)val_26;
            }
            
            val_27 = I2.Loc.GoogleTranslation.TitleCase(s:  0);
            if((System.String.op_Equality(a:  0, b:  val_27)) == false)
            {
                    return (string)val_26;
            }
            
            val_26 = I2.Loc.GoogleTranslation.TitleCase(s:  0);
            return (string)val_26;
        }
        private static int <FindAllQueries>m__0(System.Collections.Generic.KeyValuePair<string, string> a, System.Collections.Generic.KeyValuePair<string, string> b)
        {
            return (int)b.Value.CompareTo(strB:  ???);
        }
        private static string <ParseTranslationResult>m__1(System.Text.RegularExpressions.Match match)
        {
            int val_3 = System.Int32.Parse(s:  0, style:  X1.Item[1].Value);
            return System.Char.ConvertFromUtf32(utf32:  0);
        }
        private static string <ParseTranslationResult>m__2(System.Text.RegularExpressions.Match match)
        {
            string val_2 = X1.Item[1].Value;
            int val_3 = System.Int32.Parse(s:  0);
            return System.Char.ConvertFromUtf32(utf32:  0);
        }
    
    }

}
