using UnityEngine;

namespace I2.Loc
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.ExecuteInEditMode]
    public class LanguageSource : MonoBehaviour
    {
        // Fields
        public bool NeverDestroy;
        public bool UserAgreesToHaveItOnTheScene;
        public bool UserAgreesToHaveItInsideThePluginsFolder;
        public bool GoogleLiveSyncIsUptoDate;
        public bool mIsGlobalSource;
        public System.Collections.Generic.List<UnityEngine.Object> Assets;
        public System.Collections.Generic.Dictionary<string, UnityEngine.Object> mAssetDictionary;
        public string Google_WebServiceURL;
        public string Google_SpreadsheetKey;
        public string Google_SpreadsheetName;
        public string Google_LastUpdatedVersion;
        public I2.Loc.LanguageSource.eGoogleUpdateFrequency GoogleUpdateFrequency;
        public I2.Loc.LanguageSource.eGoogleUpdateFrequency GoogleInEditorCheckFrequency;
        public float GoogleUpdateDelay;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<I2.Loc.LanguageSource, bool, string> Event_OnSourceUpdateFromGoogle;
        public System.Collections.Generic.List<I2.Loc.LanguageData> mLanguages;
        public bool IgnoreDeviceLanguage;
        public I2.Loc.LanguageSource.eAllowUnloadLanguages _AllowUnloadingLanguages;
        public static string EmptyCategory;
        public static char[] CategorySeparators;
        public System.Collections.Generic.List<I2.Loc.TermData> mTerms;
        public bool CaseInsensitiveTerms;
        public System.Collections.Generic.Dictionary<string, I2.Loc.TermData> mDictionary;
        public I2.Loc.LanguageSource.MissingTranslationAction OnMissingTranslation;
        public string mTerm_AppName;
        private static System.Func<System.Linq.IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>f__mg$cache0;
        private static System.Predicate<UnityEngine.Object> <>f__am$cache0;
        private static System.Func<UnityEngine.Object, string> <>f__am$cache1;
        private static System.Func<System.Linq.IGrouping<string, UnityEngine.Object>, string> <>f__am$cache2;
        private static System.Comparison<I2.Loc.TermData> <>f__am$cache3;
        
        // Methods
        public LanguageSource()
        {
            this.GoogleLiveSyncIsUptoDate = true;
            this.Assets = new System.Collections.Generic.List<UnityEngine.Object>();
            this.GoogleUpdateFrequency = 3;
            this.GoogleUpdateDelay = 5f;
            this.mAssetDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer.Ordinal);
            this._AllowUnloadingLanguages = true;
            this.mLanguages = new System.Collections.Generic.List<I2.Loc.LanguageData>();
            this.mTerms = new System.Collections.Generic.List<I2.Loc.TermData>();
            this.OnMissingTranslation = true;
            this.mDictionary = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>(comparer:  System.StringComparer.Ordinal);
        }
        private void Awake()
        {
            this.NeverDestroy = false;
            I2.Loc.LocalizationManager.AddSource(Source:  null);
            this.UpdateDictionary(force:  false);
            this.UpdateAssetDictionary();
            I2.Loc.LocalizationManager.LocalizeAll(Force:  true);
        }
        private void OnDestroy()
        {
            this.NeverDestroy = false;
            I2.Loc.LocalizationManager.RemoveSource(Source:  null);
        }
        public string GetSourceName()
        {
            var val_10 = this.transform.parent;
            goto label_3;
            label_11:
            val_10 = val_10.parent;
            label_3:
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return (string)this.gameObject.name;
            }
            
            string val_9 = 0 + val_10.name + "_";
            if(val_10 != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        public bool IsEqualTo(I2.Loc.LanguageSource Source)
        {
            string val_11;
            var val_12;
            var val_13;
            val_11 = 1152921510966129504;
            val_12 = Source.mLanguages.Count;
            if(val_12 != this.mLanguages.Count)
            {
                goto label_10;
            }
            
            val_12 = this.mLanguages.Count;
            if(val_12 < 1)
            {
                goto label_6;
            }
            
            var val_11 = 0;
            label_11:
            I2.Loc.LanguageData val_4 = this.mLanguages.Item[0];
            val_11 = val_4.Name;
            if(((Source.GetLanguageIndex(language:  val_11, AllowDiscartingRegion:  true, SkipDisabled:  true)) & 2147483648) != 0)
            {
                goto label_10;
            }
            
            val_11 = val_11 + 1;
            if(val_11 < val_12)
            {
                goto label_11;
            }
            
            label_6:
            val_11 = 1152921512259944144;
            val_12 = Source.mTerms.Count;
            val_13 = 0;
            if(val_12 != this.mTerms.Count)
            {
                    return (bool)val_13;
            }
            
            do
            {
                if(0 >= this.mTerms.Count)
            {
                    return (bool)val_13;
            }
            
                I2.Loc.TermData val_9 = this.mTerms.Item[0];
                val_13 = 0;
                val_12 = 0 + 1;
            }
            while((Source.GetTermData(term:  val_9.Term, allowCategoryMistmatch:  false)) != null);
            
            return (bool)val_13;
            label_10:
            val_13 = 0;
            return (bool)val_13;
        }
        internal bool ManagerHasASimilarSource()
        {
            var val_7;
            var val_8;
            val_7 = null;
            val_7 = null;
            int val_1 = I2.Loc.LocalizationManager.Sources.Count;
            if(val_1 < 1)
            {
                    return false;
            }
            
            var val_7 = 0;
            do
            {
                val_8 = null;
                val_8 = null;
                I2.Loc.LanguageSource val_2 = I2.Loc.LocalizationManager.Sources.Item[0];
                if(0 != val_2)
            {
                    if((val_2.IsEqualTo(Source:  this)) != false)
            {
                    if(0 != val_2)
            {
                    return false;
            }
            
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_1);
            
            return false;
        }
        public void ClearAllData()
        {
            this.mTerms.Clear();
            this.mLanguages.Clear();
            this.mDictionary.Clear();
            this.mAssetDictionary.Clear();
        }
        public bool IsGlobalSource()
        {
            return (bool)this.mIsGlobalSource;
        }
        public void UpdateAssetDictionary()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_9 = null;
            val_9 = null;
            if((I2.Loc.LanguageSource.<>f__am$cache0) == null)
            {
                    val_10 = null;
                val_10 = null;
                I2.Loc.LanguageSource.<>f__am$cache0 = new System.Predicate<UnityEngine.Object>(object:  0, method:  static System.Boolean I2.Loc.LanguageSource::<UpdateAssetDictionary>m__0(UnityEngine.Object x));
                val_9 = null;
            }
            
            val_9 = null;
            int val_2 = this.Assets.RemoveAll(match:  I2.Loc.LanguageSource.<>f__am$cache0);
            val_11 = null;
            if((I2.Loc.LanguageSource.<>f__am$cache1) == null)
            {
                    val_12 = null;
                val_12 = null;
                I2.Loc.LanguageSource.<>f__am$cache1 = new System.Func<UnityEngine.Object, System.String>(object:  0, method:  static System.String I2.Loc.LanguageSource::<UpdateAssetDictionary>m__1(UnityEngine.Object o));
                val_11 = null;
            }
            
            val_11 = null;
            val_13 = null;
            if((I2.Loc.LanguageSource.<>f__am$cache2) == null)
            {
                    val_14 = null;
                val_14 = null;
                I2.Loc.LanguageSource.<>f__am$cache2 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String>(object:  0, method:  static System.String I2.Loc.LanguageSource::<UpdateAssetDictionary>m__2(System.Linq.IGrouping<string, UnityEngine.Object> g));
                val_13 = null;
            }
            
            val_13 = null;
            if((I2.Loc.LanguageSource.<>f__mg$cache0) == null)
            {
                    val_15 = null;
                val_15 = null;
                I2.Loc.LanguageSource.<>f__mg$cache0 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object>(object:  0, method:  public static UnityEngine.Object System.Linq.Enumerable::First<UnityEngine.Object>(System.Collections.Generic.IEnumerable<TSource> source));
                val_13 = null;
            }
            
            val_13 = null;
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String, UnityEngine.Object>(source:  0, keySelector:  System.Linq.Enumerable.GroupBy<UnityEngine.Object, System.String>(source:  0, keySelector:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  0)), elementSelector:  I2.Loc.LanguageSource.<>f__am$cache2);
        }
        public UnityEngine.Object FindAsset(string Name)
        {
            var val_6;
            var val_7;
            UnityEngine.Object val_3 = 0;
            val_7 = 0;
            if(this.Assets == null)
            {
                    return (UnityEngine.Object)((this.mAssetDictionary.TryGetValue(key:  Name, value: out  val_3)) != true) ? (val_3) : 0;
            }
            
            if(this.mAssetDictionary != null)
            {
                    val_6 = this.mAssetDictionary.Count;
                if(val_6 == this.Assets.Count)
            {
                    return (UnityEngine.Object)((this.mAssetDictionary.TryGetValue(key:  Name, value: out  val_3)) != true) ? (val_3) : 0;
            }
            
            }
            
            this.UpdateAssetDictionary();
            return (UnityEngine.Object)((this.mAssetDictionary.TryGetValue(key:  Name, value: out  val_3)) != true) ? (val_3) : 0;
        }
        public bool HasAsset(UnityEngine.Object Obj)
        {
            if(this.Assets != null)
            {
                    return this.Assets.Contains(item:  Obj);
            }
            
            return this.Assets.Contains(item:  Obj);
        }
        public void AddAsset(UnityEngine.Object Obj)
        {
            if((this.Assets.Contains(item:  Obj)) != false)
            {
                    return;
            }
            
            this.Assets.Add(item:  Obj);
            this.UpdateAssetDictionary();
        }
        public string Export_I2CSV(string Category, char Separator = '\x2c', bool specializationsAsRows = True)
        {
            var val_5;
            string val_31;
            bool val_32;
            var val_33;
            var val_34;
            I2.Loc.TermData val_35;
            var val_36;
            var val_37;
            System.Text.StringBuilder val_2 = Append(value:  "Key[*]Type[*]Desc");
            List.Enumerator<T> val_3 = this.mLanguages.GetEnumerator();
            label_13:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            System.Text.StringBuilder val_7 = Append(value:  "[*]");
            if((0 & 1) != 0)
            {
                    System.Text.StringBuilder val_8 = Append(value:  '$');
            }
            
            if(val_5.InitializationCallback != null)
            {
                
            }
            else
            {
                    val_31 = 11993091;
            }
            
            System.Text.StringBuilder val_10 = Append(value:  I2.Loc.GoogleLanguages.GetCodedLanguage(Language:  0, code:  val_31));
            goto label_13;
            label_3:
            val_5.Dispose();
            val_32 = specializationsAsRows;
            System.Text.StringBuilder val_11 = Append(value:  "[ln]");
            int val_12 = this.mLanguages.Count;
            List.Enumerator<T> val_13 = this.mTerms.GetEnumerator();
            goto label_65;
            label_43:
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_15 = val_5.InitializationCallback;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_33;
            }
            
            val_33 = null;
            val_33 = null;
            if((System.String.op_Equality(a:  0, b:  Category)) == false)
            {
                goto label_28;
            }
            
            val_34 = null;
            val_34 = null;
            if(((I2.Loc.LanguageSource.EmptyCategory.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators)) & 2147483648) != 0)
            {
                goto label_33;
            }
            
            label_28:
            if((I2.Loc.LanguageSource.EmptyCategory.StartsWith(value:  0 + Category)) != false)
            {
                    if((System.String.op_Inequality(a:  0, b:  Category)) == true)
            {
                goto label_42;
            }
            
            }
            
            label_65:
            if((0 & 1) != 0)
            {
                goto label_43;
            }
            
            goto label_70;
            label_33:
            if(val_15 != null)
            {
                goto label_46;
            }
            
            goto label_46;
            label_42:
            val_35 = I2.Loc.LanguageSource.EmptyCategory.Substring(startIndex:  Category.Length + 1);
            label_46:
            if((0 & 1) == 0)
            {
                    System.Text.StringBuilder val_26 = Append(value:  "[ln]");
            }
            
            if(val_32 == false)
            {
                goto label_52;
            }
            
            System.Collections.Generic.List<System.String> val_27 = val_15.GetAllSpecializations();
            val_36 = 0;
            goto label_54;
            label_62:
            val_36 = 1;
            label_54:
            if(val_36 >= val_27.Count)
            {
                goto label_65;
            }
            
            if(val_36 != 0)
            {
                    System.Text.StringBuilder val_29 = Append(value:  "[ln]");
            }
            
            string val_30 = val_27.Item[1];
            I2.Loc.LanguageSource.AppendI2Term(Builder:  null, nLanguages:  48295936, Term:  val_12, termData:  val_35, Separator:  val_15, forceSpecialization:  null);
            goto label_62;
            label_52:
            I2.Loc.LanguageSource.AppendI2Term(Builder:  null, nLanguages:  48295936, Term:  val_12, termData:  val_35, Separator:  val_15, forceSpecialization:  null);
            goto label_65;
            label_70:
            val_37 = public System.Void List.Enumerator<I2.Loc.TermData>::Dispose();
            val_5.Dispose();
            if(((0 & 1) == 0) && (null != 0))
            {
                    val_37 = 0;
            }
            
            if(null != 0)
            {
                    return (string)new System.Text.StringBuilder();
            }
            
            return (string)new System.Text.StringBuilder();
        }
        private static void AppendI2Term(System.Text.StringBuilder Builder, int nLanguages, string Term, I2.Loc.TermData termData, char Separator, string forceSpecialization)
        {
            var val_23;
            I2.Loc.LanguageSource.AppendI2Text(Builder:  null, text:  nLanguages);
            if(((System.String.IsNullOrEmpty(value:  0)) != true) && ((System.String.op_Inequality(a:  0, b:  X6)) != false))
            {
                    if(nLanguages != 0)
            {
                    System.Text.StringBuilder val_4 = nLanguages.Append(value:  "[");
                System.Text.StringBuilder val_5 = nLanguages.Append(value:  X6);
            }
            else
            {
                    System.Text.StringBuilder val_6 = 0.Append(value:  "[");
                System.Text.StringBuilder val_7 = 0.Append(value:  X6);
            }
            
                System.Text.StringBuilder val_8 = nLanguages.Append(value:  "]");
            }
            
            System.Text.StringBuilder val_9 = nLanguages.Append(value:  "[*]");
            string val_11 = Separator + 24.ToString();
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if(nLanguages != 0)
            {
                    System.Text.StringBuilder val_13 = nLanguages.Append(value:  val_11);
            }
            else
            {
                    System.Text.StringBuilder val_14 = 0.Append(value:  val_11);
            }
            
            System.Text.StringBuilder val_15 = nLanguages.Append(value:  "[*]");
            val_23 = 0;
            goto label_18;
            label_34:
            I2.Loc.LanguageSource.AppendI2Text(Builder:  nLanguages.Append(value:  Separator + 32), text:  nLanguages);
            val_23 = 1;
            label_18:
            if(val_23 >= (UnityEngine.Mathf.Min(a:  0, b:  Term)))
            {
                    return;
            }
            
            System.Text.StringBuilder val_18 = nLanguages.Append(value:  "[*]");
            var val_19 = (Separator + 40) + 8;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_34;
            }
            
            string val_22 = Separator.GetTranslation(idx:  1, specialization:  X6, editMode:  false);
            goto label_34;
        }
        private static void AppendI2Text(System.Text.StringBuilder Builder, string text)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return;
            }
            
            if((X2.StartsWith(value:  "\'")) != true)
            {
                    if((X2.StartsWith(value:  "=")) == false)
            {
                goto label_7;
            }
            
            }
            
            System.Text.StringBuilder val_6 = text.Append(value:  ''');
            label_7:
            System.Text.StringBuilder val_7 = text.Append(value:  X2);
        }
        private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
        {
            var val_16;
            var val_17;
            var val_18;
            I2.Loc.LanguageData val_1 = this.mLanguages.Item[langIndex];
            if((val_1.Flags & 4) != 0)
            {
                goto label_3;
            }
            
            val_16 = "=";
            val_17 = 0;
            goto label_4;
            label_31:
            val_17 = 1;
            label_4:
            if(val_17 >= this.mTerms.Count)
            {
                goto label_6;
            }
            
            if(val_17 >= 1)
            {
                    System.Text.StringBuilder val_4 = Append(value:  "[i2t]");
            }
            
            if(null != 0)
            {
                    System.Text.StringBuilder val_6 = Append(value:  val_5.Term);
            }
            else
            {
                    System.Text.StringBuilder val_7 = Append(value:  val_5.Term);
            }
            
            System.Text.StringBuilder val_8 = Append(value:  "=");
            string val_10 = val_5.Languages[(long)langIndex];
            if(((this.OnMissingTranslation == 1) && ((System.String.IsNullOrEmpty(value:  0)) != false)) && ((this.TryGetFallbackTranslation(termData:  this.mTerms.Item[1], Translation: out  val_10, langIndex:  langIndex, overrideSpecialization:  0, skipDisabled:  true)) != false))
            {
                    System.Text.StringBuilder val_12 = Append(value:  "[i2fb]");
                if(fillTermWithFallback != false)
            {
                    val_5.Languages[(long)langIndex] = val_10;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_31;
            }
            
            System.Text.StringBuilder val_15 = Append(value:  val_10);
            goto label_31;
            label_3:
            val_18 = 0;
            return (string)val_18;
            label_6:
            val_18 = new System.Text.StringBuilder();
            return (string)val_18;
        }
        public string Export_CSV(string Category, char Separator = '\x2c', bool specializationsAsRows = True)
        {
            var val_6;
            var val_28;
            string val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            I2.Loc.LanguageSource val_36;
            var val_37;
            var val_38;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            int val_2 = this.mLanguages.Count;
            System.Text.StringBuilder val_3 = AppendFormat(format:  "Key{0}Type{0}Desc", arg0:  Separator);
            List.Enumerator<T> val_4 = this.mLanguages.GetEnumerator();
            label_15:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Text.StringBuilder val_8 = Append(value:  Separator);
            if((0 & 1) != 0)
            {
                    System.Text.StringBuilder val_9 = Append(value:  '$');
            }
            
            if(val_6.InitializationCallback != null)
            {
                
            }
            else
            {
                    val_30 = 11993091;
            }
            
            I2.Loc.LanguageSource.AppendString(Builder:  null, Text:  val_1, Separator:  I2.Loc.GoogleLanguages.GetCodedLanguage(Language:  0, code:  val_30));
            goto label_15;
            label_4:
            val_6.Dispose();
            System.Text.StringBuilder val_11 = Append(value:  "\n");
            val_31 = null;
            val_31 = null;
            if((I2.Loc.LanguageSource.<>f__am$cache3) == null)
            {
                    val_32 = null;
                val_32 = null;
                I2.Loc.LanguageSource.<>f__am$cache3 = new System.Comparison<I2.Loc.TermData>(object:  0, method:  static System.Int32 I2.Loc.LanguageSource::<Export_CSV>m__3(I2.Loc.TermData a, I2.Loc.TermData b));
                val_31 = null;
            }
            
            val_31 = null;
            this.mTerms.Sort(comparison:  I2.Loc.LanguageSource.<>f__am$cache3);
            List.Enumerator<T> val_13 = this.mTerms.GetEnumerator();
            label_70:
            if((0 & 1) == 0)
            {
                goto label_75;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_14 = val_6.InitializationCallback;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_41;
            }
            
            val_33 = null;
            val_33 = null;
            if((System.String.op_Equality(a:  0, b:  Category)) == false)
            {
                goto label_36;
            }
            
            val_34 = null;
            val_34 = null;
            if(((I2.Loc.LanguageSource.EmptyCategory.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators)) & 2147483648) != 0)
            {
                goto label_41;
            }
            
            label_36:
            if(((I2.Loc.LanguageSource.EmptyCategory.StartsWith(value:  0 + Category)) == false) || ((System.String.op_Inequality(a:  0, b:  Category)) == false))
            {
                goto label_70;
            }
            
            val_35 = I2.Loc.LanguageSource.EmptyCategory.Substring(startIndex:  Category.Length + 1);
            goto label_54;
            label_41:
            label_54:
            if(specializationsAsRows == true)
            {
                goto label_56;
            }
            
            I2.Loc.LanguageSource.AppendTerm(Builder:  null, nLanguages:  48295936, Term:  val_2, termData:  I2.Loc.LanguageSource.<>f__am$cache3, specialization:  val_14, Separator:  ' ');
            goto label_70;
            label_56:
            List.Enumerator<T> val_26 = val_14.GetAllSpecializations().GetEnumerator();
            label_65:
            if((0 & 1) == 0)
            {
                goto label_62;
            }
            
            I2.Loc.LanguageSource.AppendTerm(Builder:  null, nLanguages:  48295936, Term:  val_2, termData:  I2.Loc.LanguageSource.<>f__am$cache3, specialization:  val_14, Separator:  val_28.InitializationCallback);
            goto label_65;
            label_62:
            val_37 = 444;
            val_36 = 0;
            val_28.Dispose();
            if((444 == 444) || (val_36 == 0))
            {
                goto label_70;
            }
            
            goto label_70;
            label_75:
            val_38 = public System.Void List.Enumerator<I2.Loc.TermData>::Dispose();
            val_6.Dispose();
            if((444 != 493) && (null != 0))
            {
                    val_38 = 0;
            }
            
            if(null != 0)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        private static void AppendTerm(System.Text.StringBuilder Builder, int nLanguages, string Term, I2.Loc.TermData termData, string specialization, char Separator)
        {
            var val_19;
            I2.Loc.LanguageSource.AppendString(Builder:  null, Text:  nLanguages, Separator:  termData);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.String.op_Inequality(a:  0, b:  Separator)) != false)
            {
                    System.Text.StringBuilder val_4 = nLanguages.AppendFormat(format:  "[{0}]", arg0:  Separator);
            }
            
            }
            
            System.Text.StringBuilder val_5 = nLanguages.Append(value:  W6);
            string val_6 = specialization + 24;
            string val_7 = val_6.ToString();
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if(nLanguages != 0)
            {
                    System.Text.StringBuilder val_9 = nLanguages.Append(value:  val_7);
            }
            else
            {
                    System.Text.StringBuilder val_10 = 0.Append(value:  val_7);
            }
            
            System.Text.StringBuilder val_11 = nLanguages.Append(value:  W6);
            I2.Loc.LanguageSource.AppendString(Builder:  null, Text:  nLanguages, Separator:  val_6);
            val_19 = 0;
            goto label_18;
            label_34:
            I2.Loc.LanguageSource.AppendTranslation(Builder:  null, Text:  nLanguages, Separator:  val_7, tags:  W6);
            val_19 = 1;
            label_18:
            int val_12 = UnityEngine.Mathf.Min(a:  0, b:  Term);
            if(val_19 >= val_12)
            {
                goto label_24;
            }
            
            System.Text.StringBuilder val_13 = nLanguages.Append(value:  W6);
            int val_14 = val_12 + 8;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_34;
            }
            
            string val_17 = specialization.GetTranslation(idx:  1, specialization:  Separator, editMode:  false);
            goto label_34;
            label_24:
            System.Text.StringBuilder val_18 = nLanguages.Append(value:  "\n");
        }
        private static void AppendString(System.Text.StringBuilder Builder, string Text, char Separator)
        {
            object val_10 = W3;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            string val_3 = Separator.Replace(oldValue:  "\\n", newValue:  "\n");
            val_10 = 0 + val_10.ToCharArray();
            if(((val_3.IndexOfAny(anyOf:  val_10)) & 2147483648) == 0)
            {
                    System.Text.StringBuilder val_8 = Text.AppendFormat(format:  "\"{0}\"", arg0:  val_3.Replace(oldValue:  "\"", newValue:  "\"\""));
                return;
            }
            
            System.Text.StringBuilder val_9 = Text.Append(value:  val_3);
        }
        private static void AppendTranslation(System.Text.StringBuilder Builder, string Text, char Separator, string tags)
        {
            char val_12 = Separator;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            val_12 = val_12.Replace(oldValue:  "\\n", newValue:  "\n");
            if(((val_12.IndexOfAny(anyOf:  0 + tags.ToCharArray())) & 2147483648) == 0)
            {
                    val_12 = val_12.Replace(oldValue:  "\"", newValue:  "\"\"");
                System.Text.StringBuilder val_8 = Text.AppendFormat(format:  "\"{0}{1}\"", arg0:  X4, arg1:  val_12);
                return;
            }
            
            if(Text != null)
            {
                    System.Text.StringBuilder val_9 = Text.Append(value:  X4);
            }
            else
            {
                    System.Text.StringBuilder val_10 = 0.Append(value:  X4);
            }
            
            System.Text.StringBuilder val_11 = Text.Append(value:  val_12);
        }
        public UnityEngine.WWW Export_Google_CreateWWWcall(I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            if(null != 0)
            {
                    AddField(fieldName:  "key", value:  this.Google_SpreadsheetKey);
                AddField(fieldName:  "action", value:  "SetLanguageSource");
            }
            else
            {
                    AddField(fieldName:  "key", value:  this.Google_SpreadsheetKey);
                AddField(fieldName:  "action", value:  "SetLanguageSource");
            }
            
            AddField(fieldName:  "data", value:  this.Export_Google_CreateData());
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            AddField(fieldName:  "updateMode", value:  UpdateMode.ToString());
            return (UnityEngine.WWW)new UnityEngine.WWW(url:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  null), form:  new UnityEngine.WWWForm());
        }
        private string Export_Google_CreateData()
        {
            var val_10;
            List.Enumerator<T> val_3 = this.GetCategories(OnlyMainCategory:  true, Categories:  0).GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = 0.InitializationCallback;
            if(((1 & 1) & 1) == 0)
            {
                    System.Text.StringBuilder val_6 = Append(value:  "<I2Loc>");
            }
            
            System.Text.StringBuilder val_8 = Append(value:  val_4);
            System.Text.StringBuilder val_9 = Append(value:  "<I2Loc>");
            System.Text.StringBuilder val_10 = Append(value:  this.Export_I2CSV(Category:  val_4, Separator:  ',', specializationsAsRows:  true));
            goto label_8;
            label_12:
            val_10 = public System.Void List.Enumerator<System.String>::Dispose();
            0.Dispose();
            if(((0 & 1) == 0) && (null != null))
            {
                    val_10 = 0;
            }
            
            if(null != 0)
            {
                    return (string)new System.Text.StringBuilder();
            }
            
            return (string)new System.Text.StringBuilder();
        }
        public string Import_CSV(string Category, string CSVstring, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1, char Separator = '\x2c')
        {
            return this.Import_CSV(Category:  Category, CSV:  I2.Loc.LocalizationReader.ReadCSV(Text:  this, Separator:  CSVstring), UpdateMode:  UpdateMode);
        }
        public string Import_I2CSV(string Category, string I2CSVstring, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            return this.Import_CSV(Category:  Category, CSV:  I2.Loc.LocalizationReader.ReadI2CSV(Text:  this), UpdateMode:  UpdateMode);
        }
        public string Import_CSV(string Category, System.Collections.Generic.List<string[]> CSV, I2.Loc.eSpreadsheetUpdateMode UpdateMode = 1)
        {
            System.Collections.Generic.List<System.String[]> val_69;
            System.String[] val_70;
            System.String[] val_71;
            I2.Loc.LanguageSource val_72;
            var val_73;
            int val_74;
            var val_75;
            var val_76;
            var val_77;
            I2.Loc.TermData val_78;
            var val_79;
            string val_80;
            var val_81;
            I2.Loc.LanguageSource val_82;
            int val_83;
            I2.Loc.LanguageSource val_84;
            I2.Loc.LanguageSource val_85;
            System.Collections.Generic.List<System.String[]> val_86;
            var val_87;
            int val_88;
            string val_89;
            var val_90;
            I2.Loc.TermData val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            val_69 = CSV;
            string val_21 = 0;
            System.String[] val_1 = val_69.Item[0];
            typeof(System.String[]).__il2cppRuntimeField_20 = "Key";
            val_70 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "Type";
            val_71 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "Desc";
            val_72 = "Description";
            val_73 = "Description";
            typeof(System.String[]).__il2cppRuntimeField_28 = val_73;
            if((val_1.Length < 2) || ((ArrayContains(MainText:  val_1[0], texts:  null)) == false))
            {
                goto label_19;
            }
            
            if(UpdateMode == 1)
            {
                    val_72 = this;
                this.ClearAllData();
            }
            
            val_74 = val_1.Length;
            if(val_74 >= 3)
            {
                goto label_21;
            }
            
            val_75 = 1;
            goto label_22;
            label_19:
            val_76 = "Bad Spreadsheet Format.\nFirst columns should be \'Key\', \'Type\' and \'Desc\'";
            return (string)System.String.__il2cppRuntimeField_static_fields;
            label_21:
            bool val_3 = this.ArrayContains(MainText:  val_1[1], texts:  val_70);
            bool val_5 = val_3.ArrayContains(MainText:  val_1[1], texts:  val_71);
            val_74 = val_1.Length;
            label_22:
            if(val_74 > 3)
            {
                    bool val_9 = val_5.ArrayContains(MainText:  val_1[2], texts:  val_70);
                var val_10 = (val_9 != true) ? 2 : (((val_3 & true) != 0) ? (-1) : 1);
                string val_73 = val_1[2];
                bool val_11 = val_9.ArrayContains(MainText:  val_73, texts:  val_71);
                var val_13 = (val_11 != true) ? 2 : (((val_5 & true) != 0) ? (-1) : 1);
            }
            
            val_77 = ((val_9 | val_11) != true) ? 3 : (((val_3 | val_5) != true) ? (1 + 1) : 1);
            val_78 = 0;
            val_73 = val_1.Length - val_77;
            int val_15 = UnityEngine.Mathf.Max(a:  0, b:  val_73);
            val_70 = null;
            if(val_15 > 0)
            {
                    var val_75 = 0;
                val_71 = 1152921505030702752;
                val_79 = 1152921504608284672;
                val_77 = val_15;
                do
            {
                string val_74 = val_1[(long)val_77 + val_75];
                val_78 = 0;
                if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    System.Int32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = 0;
            }
            else
            {
                    val_80 = mem[val_1[(long)(int)((val_12 != true ? 3 : val_7 != true ? (1 + 1) : 1 + 0))] + 32];
                val_80 = val_1[(long)(int)((val_12 != true ? 3 : val_7 != true ? (1 + 1) : 1 + 0))] + 32;
                if((val_80.StartsWith(value:  "$")) != false)
            {
                    val_81 = 1;
                val_80 = val_80.Substring(startIndex:  1);
            }
            else
            {
                    val_81 = 0;
            }
            
                I2.Loc.GoogleLanguages.UnPackCodeFromLanguageName(CodedLanguage:  0, Language: out  val_80, code: out  val_21);
                if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_82 = this;
                val_78 = 1;
                int val_24 = this.GetLanguageIndex(language:  val_21, AllowDiscartingRegion:  true, SkipDisabled:  false);
            }
            else
            {
                    val_82 = this;
                val_78 = 1;
            }
            
                val_83 = this.GetLanguageIndexFromCode(Code:  0, exactMatch:  true, ignoreDisabled:  false);
                if((val_83 & 2147483648) != 0)
            {
                    if(null != 0)
            {
                    typeof(I2.Loc.LanguageData).__il2cppRuntimeField_10 = val_21;
                typeof(I2.Loc.LanguageData).__il2cppRuntimeField_18 = 0;
            }
            else
            {
                    mem[16] = val_21;
                typeof(I2.Loc.LanguageData).__il2cppRuntimeField_18 = 0;
            }
            
                typeof(I2.Loc.LanguageData).__il2cppRuntimeField_20 = val_81;
                val_78 = public System.Void System.Collections.Generic.List<I2.Loc.LanguageData>::Add(I2.Loc.LanguageData item);
                this.mLanguages.Add(item:  new System.Object());
                val_83 = this.mLanguages.Count - 1;
                val_79 = val_79;
            }
            
                System.Int32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_83;
            }
            
                val_75 = val_75 + 1;
            }
            while(val_77 != val_75);
            
                val_84 = this;
                val_85 = 1152921512264014120;
                val_86 = val_69;
            }
            else
            {
                    val_84 = this;
                val_85 = 1152921512264014120;
            }
            
            int val_28 = this.mLanguages.Count;
            val_87 = val_77;
            int val_29 = mem[1152921512264014136].Count;
            if(val_29 >= 1)
            {
                    do
            {
                val_78 = public I2.Loc.TermData System.Collections.Generic.List<I2.Loc.TermData>::get_Item(int index);
                val_77 = val_87;
                if(val_30.Languages.Length < val_28)
            {
                    if(mem[1152921512264014136].Item[0] != null)
            {
                    System.Array.Resize<System.String>(array: ref  0, newSize:  val_30 + 40);
            }
            else
            {
                    System.Array.Resize<System.String>(array: ref  0, newSize:  val_30 + 40);
            }
            
                val_78 = val_28;
                System.Array.Resize<System.Byte>(array: ref  0, newSize:  val_30.Flags);
            }
            
                val_71 = 0 + 1;
                val_87 = val_77;
            }
            while(val_29 != val_71);
            
            }
            
            val_88 = val_69.Count;
            if(val_88 < 2)
            {
                goto label_70;
            }
            
            val_71 = 1152921504608284672;
            label_146:
            System.String[] val_35 = val_69.Item[1];
            val_89 = val_35[0];
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_89 = 0 + Category + "/"("/");
            }
            
            if((val_89.EndsWith(value:  "]")) != false)
            {
                    int val_40 = val_89.LastIndexOf(value:  '[');
                if(val_40 >= 1)
            {
                    if(val_89 != null)
            {
                    val_90 = val_89.Length;
            }
            else
            {
                    val_90 = 0.Length;
            }
            
                var val_76 = -2;
                val_76 = val_76 - val_40;
                string val_45 = val_89.Substring(startIndex:  val_40 + 1, length:  val_76 + val_90);
                string val_48 = val_89.Remove(startIndex:  val_40);
            }
            
            }
            
            I2.Loc.LanguageSource.ValidateFullTerm(Term: ref  null);
            val_78 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_126;
            }
            
            val_78 = 0;
            val_91 = this.GetTermData(term:  val_48, allowCategoryMistmatch:  false);
            if(val_91 == null)
            {
                goto label_93;
            }
            
            if(UpdateMode == 3)
            {
                goto label_126;
            }
            
            goto label_95;
            label_93:
            I2.Loc.TermData val_53 = null;
            val_91 = val_53;
            val_53 = new I2.Loc.TermData();
            typeof(I2.Loc.TermData).__il2cppRuntimeField_10 = val_48;
            val_77 = 1152921510966129504;
            int val_54 = this.mLanguages.Count;
            typeof(I2.Loc.TermData).__il2cppRuntimeField_28 = null;
            val_92 = val_85;
            int val_55 = this.mLanguages.Count;
            val_93 = 0;
            typeof(I2.Loc.TermData).__il2cppRuntimeField_30 = null;
            val_71 = val_71;
            goto label_99;
            label_109:
            val_93 = 1;
            val_92 = val_71;
            val_77 = val_71;
            val_71 = val_48;
            mem2[-9223371975562798800] = null;
            label_99:
            if(val_93 >= Count)
            {
                goto label_101;
            }
            
            val_94 = mem[val_48];
            val_94 = val_71;
            if((((val_48 + 266) & 1) != 0) && ((val_48 + 188) == 0))
            {
                    val_94 = mem[val_48];
                val_94 = val_71;
            }
            
            if(((val_48 + 160) == 0) || ((val_48 + 160) != 0))
            {
                goto label_109;
            }
            
            goto label_109;
            label_101:
            mem[1152921512264014136].Add(item:  val_91);
            val_88 = val_88;
            val_78 = val_91;
            mem[1152921512264014152].Add(key:  val_48, value:  val_78);
            val_87 = val_77;
            label_95:
            if(val_10 >= 1)
            {
                    string val_77 = val_35[(long)val_10];
                typeof(I2.Loc.TermData).__il2cppRuntimeField_18 = I2.Loc.LanguageSource.GetTermType(type:  null);
            }
            
            if(val_13 >= 1)
            {
                    typeof(I2.Loc.TermData).__il2cppRuntimeField_20 = val_35[(long)val_13];
            }
            
            val_95 = 0;
            goto label_122;
            label_145:
            val_95 = 1;
            label_122:
            if(val_95 >= (val_35.Length - val_87))
            {
                goto label_126;
            }
            
            string val_79 = val_35[(long)val_87 + val_95];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_145;
            }
            
            val_96 = mem[val_48];
            val_96 = val_71;
            var val_80 = val_96 + 265;
            val_80 = val_80 & 256;
            val_80 = val_80 & 65535;
            if((System.String.op_Equality(a:  0, b:  val_35[(long)(int)((val_12 != true ? 3 : val_7 != true ? (1 + 1) : 1 + val_95))] + 32)) != false)
            {
                    if((val_80 != 0) && ((val_48 + 188) == 0))
            {
                    val_97 = mem[val_48];
                val_97 = val_71;
            }
            
                val_98 = mem[val_48 + 160];
                val_98 = val_48 + 160;
            }
            else
            {
                    if((val_80 != 0) && ((val_48 + 188) == 0))
            {
                    val_99 = mem[val_48];
                val_99 = val_71;
            }
            
            }
            
            SetTranslation(idx:  typeof(System.Int32[]).__il2cppRuntimeField_24, translation:  ((System.String.op_Equality(a:  0, b:  val_35[(long)(int)((val_12 != true ? 3 : val_7 != true ? (1 + 1) : 1 + val_95))] + 32)) != true) ? 0 : (val_35[(long)(int)((val_12 != true ? 3 : val_7 != true ? (1 + 1) : 1 + val_95))] + 32), specialization:  ((System.String.op_Equality(a:  0, b:  val_45)) != true) ? "Touch" : (val_45));
            goto label_145;
            label_126:
            var val_81 = 1;
            val_81 = val_81 + 1;
            if(val_81 != val_88)
            {
                goto label_146;
            }
            
            label_70:
            if(UnityEngine.Application.isPlaying != false)
            {
                    this.SaveLanguages(unloadAll:  this.HasUnloadedLanguages(), fileLocation:  val_78);
            }
            
            val_73 = 1152921504608284672;
            val_100 = null;
            val_100 = null;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private bool ArrayContains(string MainText, string[] texts)
        {
            var val_2;
            if(texts.Length < 1)
            {
                goto label_1;
            }
            
            var val_2 = 0;
            label_6:
            if(((MainText.IndexOf(value:  1152921505019217056, comparisonType:  5)) & 2147483648) == 0)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (long)texts.Length)
            {
                goto label_6;
            }
            
            label_1:
            val_2 = 0;
            return (bool)val_2;
            label_5:
            val_2 = 1;
            return (bool)val_2;
        }
        public static I2.Loc.eTermType GetTermType(string type)
        {
            var val_5;
            var val_6 = 0;
            label_6:
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if((System.String.Equals(a:  0, b:  val_6 + 1.ToString(), comparisonType:  X1)) == true)
            {
                goto label_5;
            }
            
            val_6 = val_6 + 1;
            if(val_6 <= 8)
            {
                goto label_6;
            }
            
            val_5 = 0;
            return (I2.Loc.eTermType)val_5;
            label_5:
            val_5 = val_6 + 1;
            return (I2.Loc.eTermType)val_5;
        }
        private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
        {
            var val_16;
            int val_17;
            string val_18;
            val_16 = onlyCurrentSpecialization;
            val_17 = 0;
            goto label_1;
            label_25:
            val_17 = val_16 + 5;
            label_1:
            if(val_17 >= langData.Length)
            {
                    return;
            }
            
            val_16 = langData.IndexOf(value:  "[i2t]", startIndex:  val_17);
            if((val_16 & 2147483648) != 0)
            {
                    val_16 = langData.Length;
            }
            
            int val_15 = val_17;
            int val_16 = langData.IndexOf(value:  "=", startIndex:  val_15);
            if(val_16 >= val_16)
            {
                    return;
            }
            
            val_15 = val_16 - val_17;
            if((this.GetTermData(term:  langData.Substring(startIndex:  val_17, length:  val_15), allowCategoryMistmatch:  false)) == null)
            {
                goto label_25;
            }
            
            val_16 = val_16 + 1;
            if(val_16 == val_16)
            {
                    val_18 = 0;
            }
            else
            {
                    string val_9 = langData.Substring(startIndex:  val_16, length:  val_16 - val_16);
                bool val_10 = val_9.StartsWith(value:  "[i2fb]");
                val_16 = (val_10 != true) ? 0 : (val_9);
                if((val_10 != false) && (useFallback != false))
            {
                    val_18 = val_9.Substring(startIndex:  6);
            }
            
                var val_12 = (val_18 == null) ? 1 : 0;
                val_12 = val_12 | val_16 ^ 1;
                if(val_12 != true)
            {
                    val_18 = I2.Loc.SpecializationManager.GetSpecializedText(text:  0, specialization:  val_18);
            }
            
            }
            
            val_7.Languages[(long)langIndex] = val_18;
            goto label_25;
        }
        public void add_Event_OnSourceUpdateFromGoogle(System.Action<I2.Loc.LanguageSource, bool, string> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.Event_OnSourceUpdateFromGoogle);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921512264900384 != this.Event_OnSourceUpdateFromGoogle);
        
        }
        public void remove_Event_OnSourceUpdateFromGoogle(System.Action<I2.Loc.LanguageSource, bool, string> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.Event_OnSourceUpdateFromGoogle);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921512265036960 != this.Event_OnSourceUpdateFromGoogle);
        
        }
        public static void FreeUnusedLanguages()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            goto label_5;
            label_14:
            val_7 = 1;
            label_5:
            if(val_7 >= val_1.mTerms.Count)
            {
                    return;
            }
            
            I2.Loc.TermData val_5 = val_1.mTerms.Item[1];
            val_8 = 0;
            goto label_11;
            label_19:
            val_8 = 1;
            label_11:
            if(val_8 >= val_5.Languages.Length)
            {
                goto label_14;
            }
            
            if((I2.Loc.LocalizationManager.Sources.Item[0].GetLanguageIndex(language:  I2.Loc.LocalizationManager.CurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  true)) == val_8)
            {
                goto label_19;
            }
            
            val_5.Languages[1] = 0;
            goto label_19;
        }
        public void Import_Google_FromCache()
        {
            string val_24;
            var val_25;
            string val_26;
            var val_27;
            if(this.GoogleUpdateFrequency == 1)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            string val_2 = this.GetSourcePlayerPrefName();
            string val_3 = 0 + "I2Source_" + val_2;
            val_24 = I2.Loc.PersistentStorage.LoadFile(fileType:  val_3, fileName:  1, logExceptions:  val_3);
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return;
            }
            
            if((val_24.StartsWith(value:  "[i2e]", comparisonType:  4)) != false)
            {
                    if(val_24 != null)
            {
                    val_25 = val_24.Length;
            }
            else
            {
                    val_25 = 0.Length;
            }
            
                string val_11 = val_24.Substring(startIndex:  5, length:  val_25 - 5);
                val_24 = I2.Loc.StringObfucator.Decode(ObfucatedString:  0);
            }
            
            if((I2.Loc.PersistentStorage.HasSetting(key:  0 + "I2SourceVersion_")) != false)
            {
                    string val_15 = 0 + "I2SourceVersion_";
                string val_16 = I2.Loc.PersistentStorage.GetSetting_String(key:  val_15, defaultValue:  val_15);
                val_26 = val_16;
                if((val_16.IsNewerVersion(currentVersion:  this.Google_LastUpdatedVersion, newVersion:  val_26)) != false)
            {
                    if(val_26.Length >= 20)
            {
                    val_27 = null;
                val_27 = null;
                val_26 = System.String.Empty;
            }
            
                this.Google_LastUpdatedVersion = val_26;
                string val_20 = this.Import_Google_Result(JsonString:  val_24, UpdateMode:  1, saveInPlayerPrefs:  false);
                return;
            }
            
            }
            
            string val_21 = 0 + "I2Source_" + val_2;
            bool val_22 = I2.Loc.PersistentStorage.DeleteFile(fileType:  val_21, fileName:  1, logExceptions:  val_21);
            I2.Loc.PersistentStorage.DeleteSetting(key:  0 + "I2SourceVersion_");
        }
        private bool IsNewerVersion(string currentVersion, string newVersion)
        {
            var val_10;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_10 = 0;
                return (bool)val_10;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.Int64.TryParse(s:  0, result: out  newVersion)) != false)
            {
                    if((System.Int64.TryParse(s:  0, result: out  currentVersion)) != false)
            {
                    var val_9 = (0 > 0) ? 1 : 0;
                return (bool)val_10;
            }
            
            }
            
            }
            
            val_10 = 1;
            return (bool)val_10;
        }
        public void Import_Google(bool ForceUpdate, bool justCheck)
        {
            string val_19;
            double val_20;
            if(ForceUpdate != true)
            {
                    if(this.GoogleUpdateFrequency == 1)
            {
                    return;
            }
            
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_19 = this.GetSourcePlayerPrefName();
            if((this.GoogleUpdateFrequency == 0) || (ForceUpdate == true))
            {
                goto label_22;
            }
            
            string val_5 = 0 + "LastGoogleUpdate_";
            string val_6 = I2.Loc.PersistentStorage.GetSetting_String(key:  val_5, defaultValue:  val_5);
            if((System.DateTime.TryParse(s:  0, result: out  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_6}, kind = val_6})) == false)
            {
                goto label_22;
            }
            
            System.DateTime val_8 = System.DateTime.Now;
            System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {ticks = new System.TimeSpan(), kind = val_8.ticks._ticks}, d2:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_8.kind}});
            var val_13 = ((this.GoogleUpdateFrequency - 2) < 4) ? (this.GoogleUpdateFrequency + 13) : 0;
            if(val_13 > 15)
            {
                goto label_13;
            }
            
            if(val_13 == 0)
            {
                goto label_22;
            }
            
            if(val_13 != 15)
            {
                    return;
            }
            
            val_20 = 1;
            goto label_19;
            label_13:
            if(val_13 != 16)
            {
                    if(val_13 != 17)
            {
                    return;
            }
            
                val_20 = 31;
            }
            else
            {
                    val_20 = 8;
            }
            
            label_19:
            if(val_9._ticks.TotalDays < 0)
            {
                    return;
            }
            
            label_22:
            val_19 = 0 + "LastGoogleUpdate_";
            System.DateTime val_15 = System.DateTime.Now;
            I2.Loc.PersistentStorage.SetSetting_String(key:  val_15.ticks._ticks, value:  val_19);
            System.Collections.IEnumerator val_17 = this.Import_Google_Coroutine(JustCheck:  justCheck);
            UnityEngine.Coroutine val_18 = I2.Loc.CoroutineManager.Start(coroutine:  0);
        }
        private string GetSourcePlayerPrefName()
        {
            string val_10;
            var val_11;
            val_10 = this.name;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_10 = 0 + val_10;
            }
            
            val_11 = null;
            val_11 = null;
            string val_5 = this.name;
            if(((System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  I2.Loc.LocalizationManager.GlobalSources)) & 2147483648) == 0)
            {
                    return (string)val_10;
            }
            
            UnityEngine.SceneManagement.Scene val_7 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_10 = 0 + val_7.m_Handle.name + "_";
            return (string)val_10;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Import_Google_Coroutine(bool JustCheck)
        {
            if(null != 0)
            {
                    typeof(LanguageSource.<Import_Google_Coroutine>c__Iterator0).__il2cppRuntimeField_10 = JustCheck;
            }
            else
            {
                    mem[16] = JustCheck;
            }
            
            typeof(LanguageSource.<Import_Google_Coroutine>c__Iterator0).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public UnityEngine.WWW Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
        {
            object val_11;
            string val_12;
            var val_13;
            var val_14;
            if(this.HasGoogleSpreadsheet() != false)
            {
                    string val_2 = this.GetSourcePlayerPrefName();
                string val_3 = 0 + "I2SourceVersion_";
                val_12 = I2.Loc.PersistentStorage.GetSetting_String(key:  val_3, defaultValue:  val_3);
                val_13 = val_12;
                if(val_13.Length >= 20)
            {
                    val_13 = null;
                val_13 = null;
                val_12 = System.String.Empty;
            }
            
                if((IsNewerVersion(currentVersion:  val_12, newVersion:  this.Google_LastUpdatedVersion)) != false)
            {
                    this.Google_LastUpdatedVersion = val_12;
            }
            
                val_11 = "{0}?key={1}&action=GetLanguageSource&version={2}";
                var val_8 = (ForceUpdate != true) ? "0" : (this.Google_LastUpdatedVersion);
                UnityEngine.WWW val_10 = null;
                val_14 = val_10;
                val_10 = new UnityEngine.WWW(url:  System.String.Format(format:  0, arg0:  val_11, arg1:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  null), arg2:  this.Google_SpreadsheetKey));
                return (UnityEngine.WWW)val_14;
            }
            
            val_14 = 0;
            return (UnityEngine.WWW)val_14;
        }
        public bool HasGoogleSpreadsheet()
        {
            var val_8;
            var val_9;
            val_8 = this;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_6;
            }
            
            }
            
            val_9 = 0;
            goto label_7;
            label_6:
            val_8 = I2.Loc.LocalizationManager.GetWebServiceURL(source:  null);
            bool val_6 = System.String.IsNullOrEmpty(value:  0);
            val_9 = val_6 ^ 1;
            label_7:
            val_6 = val_9;
            return (bool)val_6;
        }
        public string Import_Google_Result(string JsonString, I2.Loc.eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = False)
        {
            var val_36;
            string val_37;
            I2.Loc.eSpreadsheetUpdateMode val_38;
            var val_39;
            string val_40;
            var val_41;
            int val_42;
            var val_43;
            var val_44;
            string val_45;
            var val_46;
            System.StringComparison val_47;
            var val_48;
            var val_49;
            var val_50;
            val_37 = saveInPlayerPrefs;
            val_38 = UpdateMode;
            val_39 = null;
            val_39 = null;
            val_40 = System.String.Empty;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (string)val_50;
            }
            
            if((System.String.op_Equality(a:  0, b:  JsonString)) == true)
            {
                    return (string)val_50;
            }
            
            val_41 = "version=";
            int val_36 = JsonString.IndexOf(value:  "version=", comparisonType:  4);
            val_42 = JsonString.IndexOf(value:  "script_version=", comparisonType:  4);
            if(((val_42 | val_36) & 2147483648) != 0)
            {
                goto label_9;
            }
            
            val_43 = "version=";
            if(("version=") == null)
            {
                    val_43 = "version=";
            }
            
            val_44 = "script_version=";
            if(("script_version=") == null)
            {
                    val_44 = "script_version=";
            }
            
            val_36 = ",";
            val_36 = Length + val_36;
            int val_37 = val_36;
            val_41 = JsonString.IndexOf(value:  ",", startIndex:  val_37, comparisonType:  4);
            val_37 = val_41 - val_36;
            val_45 = JsonString.Substring(startIndex:  val_36, length:  val_37);
            val_42 = Length + val_42;
            int val_38 = val_42;
            val_38 = (JsonString.IndexOf(value:  ",", startIndex:  val_38, comparisonType:  4)) - val_42;
            string val_13 = JsonString.Substring(startIndex:  val_42, length:  val_38);
            val_42 = System.Int32.Parse(s:  0);
            if(val_45.Length >= 20)
            {
                    val_46 = null;
                val_46 = null;
                val_45 = System.String.Empty;
            }
            
            if(val_42 != 5)
            {
                goto label_22;
            }
            
            if(val_37 == false)
            {
                goto label_23;
            }
            
            if((IsNewerVersion(currentVersion:  mem[1152921512266636264], newVersion:  val_45)) == false)
            {
                goto label_24;
            }
            
            val_37 = this.GetSourcePlayerPrefName();
            val_42 = 0 + "I2Source_" + val_37;
            string val_20 = I2.Loc.StringObfucator.Encode(NormalString:  0);
            string val_21 = 0 + "[i2e]";
            bool val_22 = I2.Loc.PersistentStorage.SaveFile(fileType:  val_21, fileName:  1, data:  val_42, logExceptions:  val_21);
            string val_23 = 0 + "I2SourceVersion_";
            I2.Loc.PersistentStorage.SetSetting_String(key:  val_23, value:  val_23);
            I2.Loc.PersistentStorage.ForceSaveSettings();
            label_23:
            mem[1152921512266636264] = val_45;
            if(val_38 == 1)
            {
                    this.ClearAllData();
            }
            
            val_47 = 4;
            int val_24 = JsonString.IndexOf(value:  "[i2category]", comparisonType:  val_47);
            if(val_24 >= 1)
            {
                    val_41 = "[/i2category]";
                val_36 = 2;
                do
            {
                val_48 = "[i2category]";
                if("[i2category]" == null)
            {
                    val_48 = "[i2category]";
            }
            
                int val_39 = Length;
                val_39 = val_39 + val_24;
                int val_40 = val_39;
                int val_26 = JsonString.IndexOf(value:  "[/i2category]", startIndex:  val_40, comparisonType:  4);
                val_40 = val_26 - val_39;
                val_37 = JsonString.Substring(startIndex:  val_39, length:  val_40);
                val_49 = "[/i2category]";
                if(("[/i2category]") == null)
            {
                    val_49 = "[/i2category]";
            }
            
                int val_41 = Length;
                val_41 = val_41 + val_26;
                int val_42 = val_41;
                int val_29 = JsonString.IndexOf(value:  "[/i2csv]", startIndex:  val_42, comparisonType:  4);
                val_42 = val_29 - val_41;
                val_42 = JsonString.Substring(startIndex:  val_41, length:  val_42);
                int val_31 = JsonString.IndexOf(value:  "[i2category]", startIndex:  val_29, comparisonType:  4);
                val_47 = I2.Loc.LocalizationReader.ReadI2CSV(Text:  val_31);
                string val_33 = this.Import_CSV(Category:  val_37, CSV:  val_47, UpdateMode:  val_38);
                var val_34 = (val_38 == 1) ? (val_36) : (val_38);
            }
            while(val_31 > 0);
            
            }
            
            mem[1152921512266636219] = 1;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (string)val_50;
            }
            
            this.SaveLanguages(unloadAll:  true, fileLocation:  val_47);
            return (string)val_50;
            label_9:
            val_50 = "Invalid Response from Google, Most likely the WebService needs to be updated";
            return (string)val_50;
            label_22:
            val_50 = "The current Google WebService is not supported.\nPlease, delete the WebService from the Google Drive and Install the latest version.";
            return (string)val_50;
            label_24:
            val_50 = "LanguageSource is up-to-date";
            return (string)val_50;
        }
        public int GetLanguageIndex(string language, bool AllowDiscartingRegion = True, bool SkipDisabled = True)
        {
            var val_11;
            var val_12;
            var val_13;
            string val_14;
            val_11 = AllowDiscartingRegion;
            int val_1 = this.mLanguages.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_12 = 1152921510966130528;
            val_13 = 0;
            label_12:
            if(SkipDisabled == false)
            {
                goto label_3;
            }
            
            val_14 = this.mLanguages.Item[0];
            byte val_11 = val_2.Flags;
            val_11 = val_11 & 1;
            if((val_11 & 1) != 0)
            {
                goto label_6;
            }
            
            label_3:
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[0];
            val_14 = val_3.Name;
            if((System.String.Compare(strA:  0, strB:  val_14, comparisonType:  language)) == 0)
            {
                    return (int)val_13;
            }
            
            label_6:
            val_13 = val_13 + 1;
            if(val_13 < val_1)
            {
                goto label_12;
            }
            
            label_2:
            if(val_11 == false)
            {
                goto label_15;
            }
            
            val_11 = this.mLanguages.Count;
            if(val_11 < 1)
            {
                goto label_15;
            }
            
            val_12 = 1152921510966130528;
            var val_13 = 0;
            val_13 = 0;
            label_24:
            if(SkipDisabled == false)
            {
                goto label_16;
            }
            
            val_14 = this.mLanguages.Item[0];
            byte val_12 = val_6.Flags;
            val_12 = val_12 & 1;
            if((val_12 & 1) != 0)
            {
                goto label_19;
            }
            
            label_16:
            I2.Loc.LanguageData val_7 = this.mLanguages.Item[0];
            val_14 = val_7.Name;
            int val_8 = I2.Loc.LanguageSource.GetCommonWordInLanguageNames(Language1:  null, Language2:  val_14);
            var val_9 = (val_8 > 0) ? (val_8) : 0;
            label_19:
            val_13 = val_13 + 1;
            if(val_11 != val_13)
            {
                goto label_24;
            }
            
            if((((val_8 > 0) ? (val_13) : (val_13)) & 2147483648) == 0)
            {
                    return (int)val_13;
            }
            
            label_15:
            val_13 = 0;
            return (int)val_13;
        }
        public I2.Loc.LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = True)
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_3;
            var val_4;
            val_3 = this;
            AllowDiscartingRegion = AllowDiscartingRegion;
            int val_1 = this.GetLanguageIndex(language:  language, AllowDiscartingRegion:  AllowDiscartingRegion, SkipDisabled:  false);
            if((val_1 & 2147483648) == 0)
            {
                    val_3 = this.mLanguages;
                I2.Loc.LanguageData val_2 = val_3.Item[val_1];
                return (I2.Loc.LanguageData)val_4;
            }
            
            val_4 = 0;
            return (I2.Loc.LanguageData)val_4;
        }
        public bool IsCurrentLanguage(int languageIndex)
        {
            I2.Loc.LanguageData val_2 = this.mLanguages.Item[languageIndex];
            return System.String.op_Equality(a:  0, b:  I2.Loc.LocalizationManager.CurrentLanguage);
        }
        public int GetLanguageIndexFromCode(string Code, bool exactMatch = True, bool ignoreDisabled = False)
        {
            var val_10;
            var val_11;
            string val_12;
            val_10 = exactMatch;
            int val_1 = this.mLanguages.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_12:
            if(ignoreDisabled == false)
            {
                goto label_3;
            }
            
            val_12 = this.mLanguages.Item[0];
            byte val_10 = val_2.Flags;
            val_10 = val_10 & 1;
            if((val_10 & 1) != 0)
            {
                goto label_6;
            }
            
            label_3:
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[0];
            val_12 = val_3.Code;
            if((System.String.Compare(strA:  0, strB:  val_12, comparisonType:  Code)) == 0)
            {
                    return (int)val_11;
            }
            
            label_6:
            val_11 = val_11 + 1;
            if(val_11 < val_1)
            {
                goto label_12;
            }
            
            label_2:
            if(val_10 == true)
            {
                goto label_15;
            }
            
            val_10 = this.mLanguages.Count;
            if(val_10 < 1)
            {
                goto label_15;
            }
            
            val_12 = 1152921510966130528;
            val_11 = 0;
            label_25:
            if(ignoreDisabled == false)
            {
                goto label_16;
            }
            
            I2.Loc.LanguageData val_7 = this.mLanguages.Item[0];
            byte val_11 = val_7.Flags;
            val_11 = val_11 & 1;
            if((val_11 & 1) != 0)
            {
                goto label_19;
            }
            
            label_16:
            I2.Loc.LanguageData val_8 = this.mLanguages.Item[0];
            if((System.String.Compare(strA:  0, indexA:  val_8.Code, strB:  0, indexB:  Code, length:  0, comparisonType:  2)) == 0)
            {
                    return (int)val_11;
            }
            
            label_19:
            val_11 = val_11 + 1;
            if(val_11 < val_10)
            {
                goto label_25;
            }
            
            label_15:
            val_11 = 0;
            return (int)val_11;
        }
        public static int GetCommonWordInLanguageNames(string Language1, string Language2)
        {
            string val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            val_19 = Language2;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_6;
            }
            
            }
            
            val_20 = 0;
            return (int)val_20;
            label_6:
            System.Char[] val_5 = ToCharArray();
            val_19 = val_19.ToLower().Split(separator:  val_5);
            val_18 = X2.ToLower().Split(separator:  val_5);
            val_21 = 0;
            val_20 = 0;
            goto label_13;
            label_20:
            val_21 = 1;
            label_13:
            if(val_21 >= val_7.Length)
            {
                goto label_15;
            }
            
            string val_18 = val_19[1];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_20;
            }
            
            val_20 = (System.Linq.Enumerable.Contains<System.String>(source:  0, value:  val_18)) + val_20;
            goto label_20;
            label_15:
            val_22 = 0;
            goto label_21;
            label_28:
            val_22 = 1;
            label_21:
            if(val_22 >= val_9.Length)
            {
                    return (int)val_20;
            }
            
            string val_19 = val_18[1];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_28;
            }
            
            val_20 = (System.Linq.Enumerable.Contains<System.String>(source:  0, value:  val_19)) + val_20;
            goto label_28;
        }
        public static bool AreTheSameLanguage(string Language1, string Language2)
        {
            string val_1 = I2.Loc.LanguageSource.GetLanguageWithoutRegion(Language:  null);
            return (bool)((System.String.Compare(strA:  0, strB:  val_1, comparisonType:  I2.Loc.LanguageSource.GetLanguageWithoutRegion(Language:  val_1))) == 0) ? 1 : 0;
        }
        public static string GetLanguageWithoutRegion(string Language)
        {
            int val_2 = X1.IndexOfAny(anyOf:  ToCharArray());
            if((val_2 & 2147483648) != 0)
            {
                    return (string)X1;
            }
            
            string val_3 = X1.Substring(startIndex:  0, length:  val_2);
            if(val_3 != null)
            {
                    return val_3.Trim();
            }
            
            return val_3.Trim();
        }
        public void AddLanguage(string LanguageName)
        {
            this.AddLanguage(LanguageName:  LanguageName, LanguageCode:  I2.Loc.GoogleLanguages.GetLanguageCode(Filter:  0, ShowWarnings:  LanguageName));
        }
        public void AddLanguage(string LanguageName, string LanguageCode)
        {
            string val_9 = LanguageName;
            if(((this.GetLanguageIndex(language:  val_9 = LanguageName, AllowDiscartingRegion:  false, SkipDisabled:  true)) & 2147483648) == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    typeof(I2.Loc.LanguageData).__il2cppRuntimeField_10 = val_9;
            }
            else
            {
                    mem[16] = val_9;
            }
            
            typeof(I2.Loc.LanguageData).__il2cppRuntimeField_18 = LanguageCode;
            this.mLanguages.Add(item:  new System.Object());
            int val_3 = this.mLanguages.Count;
            val_9 = this.mTerms.Count;
            if(val_9 < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                I2.Loc.TermData val_5 = this.mTerms.Item[0];
                System.Array.Resize<System.String>(array: ref  0, newSize:  val_5.Languages);
                I2.Loc.TermData val_7 = this.mTerms.Item[0];
                System.Array.Resize<System.Byte>(array: ref  0, newSize:  val_7.Flags);
                val_9 = val_9 + 1;
            }
            while(val_9 != val_9);
        
        }
        public void RemoveLanguage(string LanguageName)
        {
            var val_15;
            int val_1 = this.GetLanguageIndex(language:  LanguageName, AllowDiscartingRegion:  false, SkipDisabled:  false);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            int val_2 = this.mLanguages.Count;
            int val_3 = this.mTerms.Count;
            if(val_3 < 1)
            {
                goto label_4;
            }
            
            int val_4 = val_2 - 1;
            var val_17 = 0;
            label_28:
            val_15 = val_1;
            goto label_5;
            label_25:
            System.Collections.Generic.List<I2.Loc.TermData> val_5 = X24 + this.mTerms;
            val_15 = W27;
            mem2[0] = LanguageName;
            label_5:
            var val_6 = val_15 + 1;
            I2.Loc.TermData val_7 = this.mTerms.Item[0];
            if(val_6 >= val_2)
            {
                goto label_8;
            }
            
            I2.Loc.TermData val_8 = this.mTerms.Item[0];
            var val_9 = mem[val_7.Languages] + (((long)(int)(W27)) << 3);
            mem2[0] = val_8.Languages[(long)val_6];
            I2.Loc.TermData val_10 = this.mTerms.Item[0];
            I2.Loc.TermData val_11 = this.mTerms.Item[0];
            byte val_16 = val_11.Flags[(long)val_6];
            if(val_15 < val_10.Flags.Length)
            {
                goto label_25;
            }
            
            goto label_25;
            label_8:
            System.Array.Resize<System.String>(array: ref  0, newSize:  val_7.Languages);
            I2.Loc.TermData val_13 = this.mTerms.Item[0];
            System.Array.Resize<System.Byte>(array: ref  0, newSize:  val_13.Flags);
            val_17 = val_17 + 1;
            if(val_17 != val_3)
            {
                goto label_28;
            }
            
            label_4:
            this.mLanguages.RemoveAt(index:  val_1);
        }
        public System.Collections.Generic.List<string> GetLanguages(bool skipDisabled = True)
        {
            int val_2 = this.mLanguages.Count;
            if(val_2 < 1)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            var val_6 = 0;
            label_10:
            if(skipDisabled == false)
            {
                goto label_3;
            }
            
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[0];
            byte val_5 = val_3.Flags;
            val_5 = val_5 & 1;
            if((val_5 & 1) != 0)
            {
                goto label_6;
            }
            
            label_3:
            I2.Loc.LanguageData val_4 = this.mLanguages.Item[0];
            Add(item:  val_4.Name);
            label_6:
            val_6 = val_6 + 1;
            if(val_2 != val_6)
            {
                goto label_10;
            }
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
        }
        public System.Collections.Generic.List<string> GetLanguagesCode(bool allowRegions = True, bool skipDisabled = True)
        {
            string val_12;
            int val_2 = this.mLanguages.Count;
            if(val_2 < 1)
            {
                    return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
            }
            
            var val_13 = 0;
            label_18:
            if(skipDisabled == false)
            {
                goto label_3;
            }
            
            I2.Loc.LanguageData val_4 = this.mLanguages.Item[0];
            byte val_12 = val_4.Flags;
            val_12 = val_12 & 1;
            if((val_12 & 1) != 0)
            {
                goto label_16;
            }
            
            label_3:
            I2.Loc.LanguageData val_5 = this.mLanguages.Item[0];
            val_12 = val_5.Code;
            if((val_12 != null) && (allowRegions != true))
            {
                    if(val_12.Length >= 3)
            {
                    val_12 = val_12.Substring(startIndex:  0, length:  2);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((Contains(item:  val_12)) != true)
            {
                    Add(item:  val_12);
            }
            
            }
            
            label_16:
            val_13 = val_13 + 1;
            if(val_2 != val_13)
            {
                goto label_18;
            }
            
            return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
        }
        public bool IsLanguageEnabled(string Language)
        {
            var val_4;
            var val_5;
            val_4 = this;
            int val_1 = this.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  true);
            val_5 = 0;
            if((val_1 & 2147483648) != 0)
            {
                    return (bool)((val_2.Flags & 1) != 0) ? 1 : 0;
            }
            
            val_4 = this.mLanguages.Item[val_1];
            return (bool)((val_2.Flags & 1) != 0) ? 1 : 0;
        }
        public void EnableLanguage(string Language, bool bEnabled)
        {
            int val_1 = this.GetLanguageIndex(language:  Language, AllowDiscartingRegion:  false, SkipDisabled:  true);
            if(((val_1 >> 30) & 2) != 0)
            {
                    return;
            }
            
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[val_1];
            byte val_6 = val_3.Flags;
            val_6 = val_6 & 254;
            val_3.Flags = (bEnabled != true) ? (val_6) : (val_6 | 1);
        }
        public bool AllowUnloadingLanguages()
        {
            return (bool)(this._AllowUnloadingLanguages != 0) ? 1 : 0;
        }
        private string GetSavedLanguageFileName(int languageIndex)
        {
            if((languageIndex & 2147483648) != 0)
            {
                    return 0;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = "LangSource_";
            typeof(System.String[]).__il2cppRuntimeField_28 = this.GetSourcePlayerPrefName();
            typeof(System.String[]).__il2cppRuntimeField_30 = "_";
            I2.Loc.LanguageData val_2 = this.mLanguages.Item[languageIndex];
            typeof(System.String[]).__il2cppRuntimeField_38 = val_2.Name;
            typeof(System.String[]).__il2cppRuntimeField_40 = ".loc";
            return +0;
        }
        public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
        {
            bool val_12;
            var val_13;
            val_12 = useFallback;
            val_13 = UnloadOtherLanguages;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            if((languageIndex & 2147483648) != 0)
            {
                goto label_10;
            }
            
            if(forceLoad == true)
            {
                goto label_4;
            }
            
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[languageIndex];
            if((val_3.Flags & 4) == 0)
            {
                goto label_10;
            }
            
            label_4:
            string val_4 = this.GetSavedLanguageFileName(languageIndex:  languageIndex);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    onlyCurrentSpecialization = onlyCurrentSpecialization;
                this.Import_Language_from_Cache(langIndex:  languageIndex, langData:  I2.Loc.PersistentStorage.LoadFile(fileType:  val_4, fileName:  2, logExceptions:  val_4), useFallback:  val_12, onlyCurrentSpecialization:  onlyCurrentSpecialization);
                I2.Loc.LanguageData val_9 = this.mLanguages.Item[languageIndex];
                byte val_12 = val_9.Flags;
                val_12 = val_12 & 251;
                val_9.Flags = val_12;
            }
            
            label_10:
            if(val_13 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_12 = 1152921510966129504;
            val_13 = 0;
            goto label_15;
            label_19:
            val_13 = 1;
            label_15:
            if(val_13 >= this.mLanguages.Count)
            {
                    return;
            }
            
            if(languageIndex == val_13)
            {
                goto label_19;
            }
            
            this.UnloadLanguage(languageIndex:  1);
            goto label_19;
        }
        public void LoadAllLanguages(bool forceLoad = False)
        {
            goto label_1;
            label_3:
            this.LoadLanguage(languageIndex:  0, UnloadOtherLanguages:  false, useFallback:  false, onlyCurrentSpecialization:  false, forceLoad:  forceLoad);
            0 = 1;
            label_1:
            if(0 < this.mLanguages.Count)
            {
                goto label_3;
            }
        
        }
        public void UnloadLanguage(int languageIndex)
        {
            var val_13;
            int val_14;
            var val_15;
            val_14 = languageIndex;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_13 = this.mLanguages.Item[val_14];
            if((val_3.Flags & 4) != 0)
            {
                    return;
            }
            
            val_13 = this.mLanguages.Item[val_14];
            if((val_4.Flags & 2) != 0)
            {
                    return;
            }
            
            if((this.IsCurrentLanguage(languageIndex:  val_14)) == true)
            {
                    return;
            }
            
            string val_7 = this.GetSavedLanguageFileName(languageIndex:  val_14);
            if((I2.Loc.PersistentStorage.HasFile(fileType:  val_7, fileName:  2, logExceptions:  val_7)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_9 = this.mTerms.GetEnumerator();
            goto label_13;
            label_18:
            System.Collections.Generic.List<I2.Loc.TermData> val_10 = this.mTerms + (((long)(int)(languageIndex)) << 3);
            mem2[0] = 0;
            label_13:
            if((0 & 1) == 0)
            {
                goto label_14;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_11 = 0.InitializationCallback;
            if(0 > val_14)
            {
                goto label_18;
            }
            
            goto label_18;
            label_14:
            val_13 = 0;
            val_15 = 1;
            0.Dispose();
            val_14 = this.mLanguages.Item[val_14];
            byte val_13 = val_12.Flags;
            val_13 = val_13 | 4;
            val_12.Flags = val_13;
        }
        public void SaveLanguages(bool unloadAll, I2.Loc.PersistentStorage.eFileType fileLocation = 2)
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_14;
            var val_15;
            if(this._AllowUnloadingLanguages == 0)
            {
                    return;
            }
            
            if(I2.Loc.PersistentStorage.CanAccessFiles() == false)
            {
                    return;
            }
            
            val_14 = 0;
            goto label_3;
            label_9:
            val_14 = 1;
            label_3:
            if(val_14 >= this.mLanguages.Count)
            {
                goto label_5;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_9;
            }
            
            string val_8 = this.GetSavedLanguageFileName(languageIndex:  1);
            bool val_9 = I2.Loc.PersistentStorage.SaveFile(fileType:  val_8, fileName:  2, data:  val_8, logExceptions:  this.Export_Language_to_Cache(langIndex:  1, fillTermWithFallback:  this.IsCurrentLanguage(languageIndex:  1)));
            goto label_9;
            label_5:
            if(unloadAll == false)
            {
                    return;
            }
            
            val_15 = 0;
            goto label_11;
            label_15:
            val_15 = 1;
            label_11:
            val_14 = this.mLanguages;
            if(val_15 >= val_14.Count)
            {
                    return;
            }
            
            if((this.IsCurrentLanguage(languageIndex:  1)) == true)
            {
                goto label_15;
            }
            
            this.UnloadLanguage(languageIndex:  1);
            goto label_15;
        }
        public bool HasUnloadedLanguages()
        {
            System.Collections.Generic.List<I2.Loc.LanguageData> val_3;
            var val_4;
            var val_3 = 0;
            label_5:
            val_3 = this.mLanguages;
            if(val_3 >= val_3.Count)
            {
                goto label_2;
            }
            
            val_3 = this.mLanguages.Item[0];
            val_3 = val_3 + 1;
            if((val_2.Flags & 4) == 0)
            {
                goto label_5;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_2:
            val_4 = 0;
            return (bool)val_4;
        }
        public System.Collections.Generic.List<string> GetCategories(bool OnlyMainCategory = False, System.Collections.Generic.List<string> Categories)
        {
            var val_8;
            System.Collections.Generic.List<T> val_9;
            var val_10;
            val_8 = Categories;
            if(val_8 == null)
            {
                    System.Collections.Generic.List<System.String> val_1 = null;
                val_8 = val_1;
                val_1 = new System.Collections.Generic.List<System.String>();
            }
            
            List.Enumerator<T> val_2 = this.mTerms.GetEnumerator();
            bool val_3 = OnlyMainCategory;
            label_10:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            string val_5 = I2.Loc.LanguageSource.GetCategoryFromFullTerm(FullTerm:  null, OnlyMainCategory:  0.InitializationCallback);
            if((Contains(item:  val_5)) == true)
            {
                goto label_10;
            }
            
            Add(item:  val_5);
            goto label_10;
            label_3:
            val_9 = 0;
            val_10 = 1;
            0.Dispose();
            Sort();
            return (System.Collections.Generic.List<System.String>)val_8;
        }
        public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = False)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = null;
            if((W2 & 1) != 0)
            {
                    val_6 = null;
                val_7 = OnlyMainCategory;
                int val_3 = val_7.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            else
            {
                    val_8 = null;
                val_7 = OnlyMainCategory;
                System.Char[] val_5 = I2.Loc.LanguageSource.CategorySeparators;
                int val_4 = val_7.LastIndexOfAny(anyOf:  val_5);
            }
            
            if((val_4 & 2147483648) != 0)
            {
                    return (string)OnlyMainCategory;
            }
            
            val_5 = val_4 + 1;
            return OnlyMainCategory.Substring(startIndex:  val_5);
        }
        public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = False)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = null;
            if((W2 & 1) != 0)
            {
                    val_6 = null;
                val_7 = OnlyMainCategory;
                int val_3 = val_7.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            else
            {
                    val_8 = null;
                val_7 = OnlyMainCategory;
                int val_4 = val_7.LastIndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            
            if((val_4 & 2147483648) == 0)
            {
                    if(OnlyMainCategory == true)
            {
                    return OnlyMainCategory.Substring(startIndex:  0, length:  val_4);
            }
            
                return OnlyMainCategory.Substring(startIndex:  0, length:  val_4);
            }
            
            val_9 = null;
            val_9 = null;
            return (string)I2.Loc.LanguageSource.EmptyCategory;
        }
        public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = False)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_9 = null;
            if((W4 & 1) != 0)
            {
                    val_10 = null;
                val_11 = 1152921512271124160;
                int val_3 = Key.IndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            else
            {
                    val_12 = null;
                val_11 = 1152921512271124160;
                int val_4 = Key.LastIndexOfAny(anyOf:  I2.Loc.LanguageSource.CategorySeparators);
            }
            
            if((val_4 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if(Key == null)
            {
                goto label_10;
            }
            
            mem2[0] = Key.Substring(startIndex:  0, length:  val_4);
            goto label_11;
            label_9:
            val_13 = null;
            val_13 = null;
            mem2[0] = I2.Loc.LanguageSource.EmptyCategory;
            Category = 1152921512271124160;
            return;
            label_10:
            mem2[0] = 0.Substring(startIndex:  0, length:  val_4);
            label_11:
            Category = Key.Substring(startIndex:  val_4 + 1);
        }
        public void UpdateDictionary(bool force = False)
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_16;
            PersistentStorage.eFileType val_18;
            if((force != true) && (this.mDictionary != null))
            {
                    val_16 = this.mTerms;
                if(this.mDictionary.Count == val_16.Count)
            {
                    return;
            }
            
            }
            
            if(this.CaseInsensitiveTerms != false)
            {
                    System.StringComparer val_6 = System.StringComparer.OrdinalIgnoreCase;
            }
            else
            {
                    System.StringComparer val_7 = System.StringComparer.Ordinal;
            }
            
            val_16 = this.mDictionary;
            if(val_16.Comparer != val_7)
            {
                    System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_9 = null;
                val_16 = val_9;
                val_18 = public System.Void System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>::.ctor(System.Collections.Generic.IEqualityComparer<TKey> comparer);
                val_9 = new System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData>(comparer:  val_7);
                this.mDictionary = val_16;
            }
            else
            {
                    this.mDictionary.Clear();
            }
            
            int val_10 = this.mTerms.Count;
            if(val_10 >= 1)
            {
                    do
            {
                I2.Loc.TermData val_11 = this.mTerms.Item[0];
                I2.Loc.LanguageSource.ValidateFullTerm(Term: ref  null);
                this.mDictionary.set_Item(key:  mem[val_11.Term], value:  this.mTerms.Item[0]);
                val_18 = public I2.Loc.TermData System.Collections.Generic.List<I2.Loc.TermData>::get_Item(int index);
                this.mTerms.Item[0].Validate();
                val_16 = 0 + 1;
            }
            while(val_10 != val_16);
            
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.SaveLanguages(unloadAll:  true, fileLocation:  val_18);
        }
        public string GetTranslation(string term, string overrideLanguage, string overrideSpecialization, bool skipDisabled = False, bool allowCategoryMistmatch = False)
        {
            var val_7;
            if((this.TryGetTranslation(term:  term, Translation: out  0, overrideLanguage:  overrideLanguage, overrideSpecialization:  overrideSpecialization, skipDisabled:  skipDisabled, allowCategoryMistmatch:  allowCategoryMistmatch)) == true)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_7 = null;
            val_7 = null;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        public bool TryGetTranslation(string term, out string Translation, string overrideLanguage, string overrideSpecialization, bool skipDisabled = False, bool allowCategoryMistmatch = False)
        {
            bool val_12;
            string val_13;
            var val_14;
            var val_15;
            val_12 = allowCategoryMistmatch;
            val_13 = overrideLanguage;
            if(val_13 == null)
            {
                    val_13 = I2.Loc.LocalizationManager.CurrentLanguage;
            }
            
            int val_2 = this.GetLanguageIndex(language:  val_13, AllowDiscartingRegion:  true, SkipDisabled:  false);
            if((val_2 & 2147483648) != 0)
            {
                goto label_9;
            }
            
            if(skipDisabled == false)
            {
                goto label_6;
            }
            
            I2.Loc.LanguageData val_3 = this.mLanguages.Item[val_2];
            byte val_12 = val_3.Flags;
            val_12 = val_12 & 1;
            if((val_12 & 1) != 0)
            {
                goto label_9;
            }
            
            label_6:
            val_12 = this.GetTermData(term:  term, allowCategoryMistmatch:  val_12);
            if(val_12 == null)
            {
                goto label_10;
            }
            
            string val_6 = val_12.GetTranslation(idx:  val_2, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_6;
            if((System.String.op_Equality(a:  0, b:  val_6)) == false)
            {
                goto label_13;
            }
            
            val_14 = null;
            val_14 = null;
            goto label_29;
            label_13:
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_23;
            }
            
            Translation = 0;
            label_10:
            if(this.OnMissingTranslation != 2)
            {
                goto label_20;
            }
            
            Translation = System.String.Format(format:  0, arg0:  "<!-Missing Translation [{0}]-!>");
            goto label_23;
            label_20:
            if((this.OnMissingTranslation == 1) && ((((val_12 == 0) ? 1 : 0) & 1) == 0))
            {
                    skipDisabled = skipDisabled;
                return this.TryGetFallbackTranslation(termData:  val_12, Translation: out  string val_11 = Translation, langIndex:  val_2, overrideSpecialization:  overrideSpecialization, skipDisabled:  skipDisabled);
            }
            
            if(this.OnMissingTranslation == 0)
            {
                goto label_26;
            }
            
            label_9:
            val_15 = 0;
            Translation = 0;
            return (bool)val_15;
            label_26:
            val_14 = null;
            val_14 = null;
            label_29:
            Translation = System.String.Empty;
            label_23:
            val_15 = 1;
            return (bool)val_15;
        }
        private bool TryGetFallbackTranslation(I2.Loc.TermData termData, out string Translation, int langIndex, string overrideSpecialization, bool skipDisabled = False)
        {
            string val_20;
            int val_21;
            var val_22;
            string val_23;
            var val_24;
            var val_25;
            I2.Loc.LanguageData val_1 = this.mLanguages.Item[langIndex];
            val_20 = val_1.Code;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_11;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  0, value:  val_20)) != false)
            {
                    if(val_20 != null)
            {
                    val_21 = val_20.IndexOf(value:  '-');
            }
            else
            {
                    val_21 = 0.IndexOf(value:  '-');
            }
            
                val_20 = val_20.Substring(startIndex:  0, length:  val_21);
            }
            
            val_22 = 0;
            goto label_9;
            label_24:
            val_22 = 1;
            label_9:
            if(val_22 >= this.mLanguages.Count)
            {
                goto label_11;
            }
            
            if(langIndex == val_22)
            {
                goto label_24;
            }
            
            I2.Loc.LanguageData val_8 = this.mLanguages.Item[1];
            if((val_8.Code.StartsWith(value:  val_20)) == false)
            {
                goto label_24;
            }
            
            if(skipDisabled == false)
            {
                goto label_17;
            }
            
            I2.Loc.LanguageData val_10 = this.mLanguages.Item[1];
            byte val_20 = val_10.Flags;
            val_20 = val_20 & 1;
            if((val_20 & 1) != 0)
            {
                goto label_24;
            }
            
            label_17:
            val_23 = termData.GetTranslation(idx:  1, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_23;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_24;
            }
            
            goto label_25;
            label_11:
            val_24 = 0;
            goto label_26;
            label_42:
            val_24 = 1;
            label_26:
            val_23 = this.mLanguages;
            if(val_24 >= val_23.Count)
            {
                goto label_28;
            }
            
            if(langIndex == val_24)
            {
                goto label_42;
            }
            
            if(skipDisabled == false)
            {
                goto label_30;
            }
            
            I2.Loc.LanguageData val_14 = this.mLanguages.Item[1];
            byte val_21 = val_14.Flags;
            val_21 = val_21 & 1;
            if((val_21 & 1) != 0)
            {
                goto label_42;
            }
            
            label_30:
            if(val_20 == null)
            {
                goto label_34;
            }
            
            I2.Loc.LanguageData val_15 = this.mLanguages.Item[1];
            if((val_15.Code.StartsWith(value:  val_20)) == true)
            {
                goto label_42;
            }
            
            label_34:
            val_23 = termData.GetTranslation(idx:  1, specialization:  overrideSpecialization, editMode:  true);
            Translation = val_23;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_42;
            }
            
            label_25:
            val_25 = 1;
            return (bool)val_25;
            label_28:
            val_25 = 0;
            Translation = 0;
            return (bool)val_25;
        }
        public I2.Loc.TermData AddTerm(string term)
        {
            return this.AddTerm(NewTerm:  term, termType:  0, SaveSource:  false);
        }
        public I2.Loc.TermData GetTermData(string term, bool allowCategoryMistmatch = False)
        {
            string val_11;
            var val_12;
            val_11 = term;
            I2.Loc.TermData val_4 = 0;
            val_12 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (I2.Loc.TermData)val_12;
            }
            
            if(this.mDictionary.Count == 0)
            {
                    this.UpdateDictionary(force:  false);
            }
            
            if((this.mDictionary.TryGetValue(key:  val_11, value: out  val_4)) != false)
            {
                    val_12 = val_4;
                return (I2.Loc.TermData)val_12;
            }
            
            if(allowCategoryMistmatch == false)
            {
                goto label_9;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_7 = this.mDictionary.GetEnumerator();
            val_12 = 0;
            label_17:
            if((0 & 1) == 0)
            {
                goto label_13;
            }
            
            UnityEngine.Playables.PlayableHandle val_8 = 0.GetHandle();
            val_11;
            if((val_8.m_Handle.IsTerm(name:  I2.Loc.LanguageSource.GetKeyFromFullTerm(FullTerm:  null, OnlyMainCategory:  val_11), allowCategoryMistmatch:  true)) == false)
            {
                goto label_17;
            }
            
            if(val_12 != 0)
            {
                goto label_16;
            }
            
            goto label_17;
            label_13:
            0.Dispose();
            return (I2.Loc.TermData)val_12;
            label_16:
            0.Dispose();
            label_9:
            val_12 = 0;
            return (I2.Loc.TermData)val_12;
        }
        public bool ContainsTerm(string term)
        {
            return (bool)((this.GetTermData(term:  term, allowCategoryMistmatch:  false)) != 0) ? 1 : 0;
        }
        public System.Collections.Generic.List<string> GetTermsList(string Category)
        {
            System.Collections.Generic.IEnumerable<T> val_11;
            var val_12;
            var val_13;
            val_11 = Category;
            if(this.mDictionary.Count != this.mTerms.Count)
            {
                    this.UpdateDictionary(force:  false);
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_11 = this.mDictionary.Keys;
                System.Collections.Generic.List<System.String> val_5 = null;
                val_12 = val_5;
                val_5 = new System.Collections.Generic.List<System.String>(collection:  val_11);
                return (System.Collections.Generic.List<System.String>)val_12;
            }
            
            System.Collections.Generic.List<System.String> val_6 = null;
            val_12 = val_6;
            val_6 = new System.Collections.Generic.List<System.String>();
            val_13 = 0;
            goto label_9;
            label_21:
            val_13 = 1;
            label_9:
            if(val_13 >= this.mTerms.Count)
            {
                    return (System.Collections.Generic.List<System.String>)val_12;
            }
            
            I2.Loc.TermData val_8 = this.mTerms.Item[1];
            if((System.String.op_Equality(a:  0, b:  I2.Loc.LanguageSource.GetCategoryFromFullTerm(FullTerm:  null, OnlyMainCategory:  val_8.Term))) == false)
            {
                goto label_21;
            }
            
            Add(item:  val_8.Term);
            goto label_21;
        }
        public I2.Loc.TermData AddTerm(string NewTerm, I2.Loc.eTermType termType, bool SaveSource = True)
        {
            I2.Loc.eTermType val_8;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TermData> val_9;
            I2.Loc.TermData val_10;
            val_8 = termType;
            val_9 = this;
            I2.Loc.LanguageSource.ValidateFullTerm(Term: ref  null);
            string val_2 = NewTerm.Trim();
            if(this.mLanguages.Count == 0)
            {
                    this.AddLanguage(LanguageName:  "English", LanguageCode:  "en");
            }
            
            val_10 = this.GetTermData(term:  val_2, allowCategoryMistmatch:  false);
            if(val_10 != null)
            {
                    return val_10;
            }
            
            I2.Loc.TermData val_5 = null;
            val_10 = val_5;
            val_5 = new I2.Loc.TermData();
            if(null != 0)
            {
                    typeof(I2.Loc.TermData).__il2cppRuntimeField_10 = val_2;
            }
            else
            {
                    mem[16] = val_2;
            }
            
            typeof(I2.Loc.TermData).__il2cppRuntimeField_18 = val_8;
            int val_6 = this.mLanguages.Count;
            typeof(I2.Loc.TermData).__il2cppRuntimeField_28 = null;
            int val_7 = this.mLanguages.Count;
            typeof(I2.Loc.TermData).__il2cppRuntimeField_30 = null;
            val_8 = this.mTerms;
            val_8.Add(item:  val_10);
            val_9 = this.mDictionary;
            val_9.Add(key:  val_2, value:  val_10);
            return val_10;
        }
        public void RemoveTerm(string term)
        {
            System.Collections.Generic.List<I2.Loc.TermData> val_5 = this.mTerms;
            int val_1 = val_5.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            label_8:
            I2.Loc.TermData val_2 = this.mTerms.Item[0];
            if((System.String.op_Equality(a:  0, b:  val_2.Term)) == true)
            {
                goto label_7;
            }
            
            val_5 = 0 + 1;
            if(val_5 < val_1)
            {
                goto label_8;
            }
            
            return;
            label_7:
            this.mTerms.RemoveAt(index:  0);
            bool val_4 = this.mDictionary.Remove(key:  term);
        }
        public static void ValidateFullTerm(ref string Term)
        {
            var val_13;
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            string val_1 = X1.Replace(oldChar:  '\', newChar:  '/');
            mem2[0] = val_1;
            string val_2 = val_1.Trim();
            mem2[0] = val_2;
            val_13 = null;
            val_13 = null;
            val_14 = I2.Loc.LanguageSource.EmptyCategory;
            val_15 = val_2;
            if((val_15.StartsWith(value:  val_14, comparisonType:  4)) != false)
            {
                    val_16 = null;
                val_16 = null;
                val_14 = I2.Loc.LanguageSource.EmptyCategory;
                val_15 = val_14;
                if(X1.Length > val_15.Length)
            {
                    val_17 = null;
                val_17 = null;
                val_14 = I2.Loc.LanguageSource.EmptyCategory.Length;
                val_15 = X1;
                if((val_15.Chars[val_14] & 65535) == ('/'))
            {
                    val_18 = null;
                val_18 = null;
                val_14 = I2.Loc.LanguageSource.EmptyCategory.Length;
                string val_11 = X1.Substring(startIndex:  val_14 + 1);
                mem2[0] = val_11;
            }
            
            }
            
            }
            
            mem2[0] = I2.Loc.I2Utils.RemoveNonASCII(text:  val_11, allowCategory:  X1);
        }
        private static LanguageSource()
        {
            I2.Loc.LanguageSource.EmptyCategory = "Default";
            I2.Loc.LanguageSource.CategorySeparators = ToCharArray();
        }
        private static bool <UpdateAssetDictionary>m__0(UnityEngine.Object x)
        {
            return UnityEngine.Object.op_Equality(x:  0, y:  X1);
        }
        private static string <UpdateAssetDictionary>m__1(UnityEngine.Object o)
        {
            if(X1 != 0)
            {
                    return X1.name;
            }
            
            return X1.name;
        }
        private static string <UpdateAssetDictionary>m__2(System.Linq.IGrouping<string, UnityEngine.Object> g)
        {
            var val_2;
            var val_3 = X1;
            if((X1 + 258) == 0)
            {
                goto label_2;
            }
            
            var val_1 = X1 + 152;
            var val_2 = 0;
            val_1 = val_1 + 8;
            label_4:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            val_1 = val_1 + 16;
            if(val_2 < (X1 + 258))
            {
                goto label_4;
            }
            
            label_2:
            val_2 = X1;
            goto ((X1 + ((X1 + 152 + 8)) << 4) + 272);
            label_3:
            val_3 = val_3 + (((X1 + 152 + 8)) << 4);
            val_2 = val_3 + 272;
            goto ((X1 + ((X1 + 152 + 8)) << 4) + 272);
        }
        private static int <Export_CSV>m__3(I2.Loc.TermData a, I2.Loc.TermData b)
        {
            return System.String.CompareOrdinal(strA:  0, strB:  b.Term);
        }
    
    }

}
