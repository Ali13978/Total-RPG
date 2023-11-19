using UnityEngine;

namespace I2.Loc
{
    [UnityEngine.AddComponentMenu]
    public class Localize : MonoBehaviour
    {
        // Fields
        public string mTerm;
        public string mTermSecondary;
        public string FinalTerm;
        public string FinalSecondaryTerm;
        public I2.Loc.Localize.TermModification PrimaryTermModifier;
        public I2.Loc.Localize.TermModification SecondaryTermModifier;
        public string TermPrefix;
        public string TermSuffix;
        public bool LocalizeOnAwake;
        private string LastLocalizedLanguage;
        public bool IgnoreRTL;
        public int MaxCharactersInRTL;
        public bool IgnoreNumbersInRTL;
        public bool CorrectAlignmentForRTL;
        public bool AddSpacesToJoinedLanguages;
        public bool AllowLocalizedParameters;
        public System.Collections.Generic.List<UnityEngine.Object> TranslatedObjects;
        public System.Collections.Generic.Dictionary<string, UnityEngine.Object> mAssetDictionary;
        public UnityEngine.Events.UnityEvent LocalizeEvent;
        public static string MainTranslation;
        public static string SecondaryTranslation;
        public static string CallBackTerm;
        public static string CallBackSecondaryTerm;
        public static I2.Loc.Localize CurrentLocalizeComponent;
        public bool AlwaysForceLocalize;
        [UnityEngine.SerializeField]
        public I2.Loc.EventCallback LocalizeCallBack;
        public bool mGUI_ShowReferences;
        public bool mGUI_ShowTems;
        public bool mGUI_ShowCallback;
        public I2.Loc.ILocalizeTarget mLocalizeTarget;
        public string mLocalizeTargetName;
        private static System.Func<System.Linq.IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>f__mg$cache0;
        private static System.Predicate<UnityEngine.Object> <>f__am$cache0;
        private static System.Func<UnityEngine.Object, string> <>f__am$cache1;
        private static System.Func<UnityEngine.Object, string> <>f__am$cache2;
        private static System.Func<System.Linq.IGrouping<string, UnityEngine.Object>, string> <>f__am$cache3;
        
        // Properties
        public string Term { get; set; }
        public string SecondaryTerm { get; set; }
        
        // Methods
        public Localize()
        {
            null = null;
            this.mTerm = System.String.Empty;
            this.LocalizeOnAwake = true;
            this.IgnoreNumbersInRTL = true;
            this.CorrectAlignmentForRTL = true;
            this.mTermSecondary = System.String.Empty;
            this.AllowLocalizedParameters = true;
            this.TranslatedObjects = new System.Collections.Generic.List<UnityEngine.Object>();
            this.mAssetDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer.Ordinal);
            this.LocalizeEvent = new UnityEngine.Events.UnityEvent();
            this.mGUI_ShowTems = true;
            this.LocalizeCallBack = new I2.Loc.EventCallback();
        }
        public string get_Term()
        {
            return (string)this.mTerm;
        }
        public void set_Term(string value)
        {
            this.SetTerm(primary:  value);
        }
        public string get_SecondaryTerm()
        {
            return (string)this.mTermSecondary;
        }
        public void set_SecondaryTerm(string value)
        {
            this.SetTerm(primary:  0, secondary:  value);
        }
        private void Awake()
        {
            this.UpdateAssetDictionary();
            bool val_1 = this.FindTarget();
            if(this.LocalizeOnAwake == false)
            {
                    return;
            }
            
            this.OnLocalize(Force:  false);
        }
        private void OnEnable()
        {
            this.OnLocalize(Force:  false);
        }
        public bool HasCallback()
        {
            UnityEngine.Events.UnityEvent val_5;
            var val_6;
            val_5 = this;
            if(this.LocalizeCallBack.HasCallback() != false)
            {
                    val_6 = 1;
                return (bool)(val_5.GetPersistentEventCount() > 0) ? 1 : 0;
            }
            
            val_5 = this.LocalizeEvent;
            return (bool)(val_5.GetPersistentEventCount() > 0) ? 1 : 0;
        }
        public void OnLocalize(bool Force = False)
        {
            UnityEngine.Object val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            string val_87;
            var val_88;
            var val_89;
            var val_91;
            string val_92;
            string val_93;
            string val_94;
            var val_95;
            string val_96;
            string val_97;
            var val_98;
            char val_99;
            bool val_100;
            string val_101;
            I2.Loc.ILocalizeTarget val_104;
            var val_105;
            if(Force != true)
            {
                    if(this.enabled == false)
            {
                    return;
            }
            
                val_82 = this.gameObject;
                if(0 == val_82)
            {
                    return;
            }
            
                val_82 = this.gameObject;
                if(val_82.activeInHierarchy == false)
            {
                    return;
            }
            
            }
            
            val_82 = I2.Loc.LocalizationManager.CurrentLanguage;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            if((this.AlwaysForceLocalize != true) && (Force != true))
            {
                    if(this.HasCallback() != true)
            {
                    val_82 = I2.Loc.LocalizationManager.CurrentLanguage;
                if((System.String.op_Equality(a:  0, b:  this.LastLocalizedLanguage)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            this.LastLocalizedLanguage = I2.Loc.LocalizationManager.CurrentLanguage;
            string val_21 = this.FinalTerm;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_28;
            }
            
            }
            
            this.GetFinalTerms(primaryTerm: out  val_21, secondaryTerm: out  this.FinalSecondaryTerm);
            label_28:
            if((UnityEngine.Application.isPlaying != false) && (this.HasCallback() != false))
            {
                    val_83 = 1;
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_82 = this.FinalSecondaryTerm;
                if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            }
            
                val_83 = 0;
            }
            
            I2.Loc.Localize.CallBackTerm = this.FinalTerm;
            I2.Loc.Localize.CallBackSecondaryTerm = this.FinalSecondaryTerm;
            val_84 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_84 = 0;
                if((System.String.op_Equality(a:  0, b:  val_21)) != true)
            {
                    val_85 = 1;
            }
            
            }
            
            I2.Loc.Localize.MainTranslation = I2.Loc.LocalizationManager.GetTranslation(Term:  null, FixForRTL:  val_21, maxLineLengthForRTL:  0, ignoreRTLnumbers:  false, applyParameters:  true, localParametersRoot:  0, overrideLanguage:  0);
            val_86 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_86 = 0;
                if((System.String.op_Equality(a:  0, b:  this.FinalSecondaryTerm)) != true)
            {
                    val_85 = 1;
            }
            
            }
            
            I2.Loc.Localize.SecondaryTranslation = I2.Loc.LocalizationManager.GetTranslation(Term:  null, FixForRTL:  this.FinalSecondaryTerm, maxLineLengthForRTL:  0, ignoreRTLnumbers:  false, applyParameters:  true, localParametersRoot:  0, overrideLanguage:  0);
            if((val_83 & 1) == 0)
            {
                    if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_82 = I2.Loc.Localize.SecondaryTranslation;
                if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            }
            
            }
            
            I2.Loc.Localize.CurrentLocalizeComponent = this;
            this.LocalizeCallBack.Execute(Sender:  this);
            this.LocalizeEvent.Invoke();
            val_82 = this.gameObject;
            val_87 = null;
            var val_43 = (this.AllowLocalizedParameters == true) ? 1 : 0;
            I2.Loc.LocalizationManager.ApplyLocalizationParams(translation: ref  val_87, root:  I2.Loc.Localize.MainTranslation, allowLocalizedParameters:  val_82);
            if(this.FindTarget() == false)
            {
                    return;
            }
            
            val_88 = null;
            val_88 = null;
            if(I2.Loc.LocalizationManager.IsRight2Left != false)
            {
                    val_89 = this.IgnoreRTL ^ 1;
            }
            else
            {
                    val_89 = 0;
            }
            
            val_82 = I2.Loc.Localize.MainTranslation;
            if(val_82 == null)
            {
                goto label_116;
            }
            
            TermModification val_80 = this.PrimaryTermModifier;
            TermModification val_45 = val_80 - 1;
            val_80 = val_80 + 62;
            var val_46 = (val_45 < 4) ? (val_80) : 0;
            val_45 = val_46 - 63;
            if(val_45 > 3)
            {
                goto label_71;
            }
            
            var val_81 = 25810528;
            val_81 = (25810528 + ((val_45 < 0x4 ? (this.PrimaryTermModifier + 62) : 0 - 63)) << 2) + val_81;
            goto (25810528 + ((val_45 < 0x4 ? (this.PrimaryTermModifier + 62) : 0 - 63)) << 2 + 25810528);
            label_71:
            if(val_46 != 0)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if(val_89 != 0)
            {
                    val_91 = null;
                val_92 = this.TermPrefix;
                val_93 = ;
            }
            else
            {
                    val_91 = null;
                val_93 = this.TermPrefix;
                val_92 = ;
            }
            
                I2.Loc.Localize.MainTranslation = 0 + val_93;
            }
            
            val_94 = this.TermSuffix;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if(val_89 != 0)
            {
                    val_95 = null;
                val_96 = this.TermSuffix;
                val_97 = I2.Loc.Localize.MainTranslation;
            }
            else
            {
                    val_95 = null;
                val_97 = this.TermSuffix;
                val_96 = I2.Loc.Localize.MainTranslation;
            }
            
                val_94 = val_96;
                I2.Loc.Localize.MainTranslation = 0 + val_94;
            }
            
            if(this.AddSpacesToJoinedLanguages == false)
            {
                goto label_101;
            }
            
            val_98 = null;
            val_98 = null;
            if(I2.Loc.LocalizationManager.HasJoinedWords == false)
            {
                goto label_101;
            }
            
            val_94 = I2.Loc.Localize.MainTranslation;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_101;
            }
            
            System.Text.StringBuilder val_61 = Append(value:  I2.Loc.Localize.MainTranslation.Chars[0]);
            val_99 = 0;
            val_100 = 1;
            goto label_105;
            label_110:
            val_99 = W24;
            System.Text.StringBuilder val_63 = Append(value:  val_99);
            val_100 = 2;
            label_105:
            if(val_100 >= I2.Loc.Localize.MainTranslation.Length)
            {
                goto label_107;
            }
            
            System.Text.StringBuilder val_64 = Append(value:  ' ');
            char val_65 = I2.Loc.Localize.MainTranslation.Chars[2];
            if(null != 0)
            {
                goto label_110;
            }
            
            goto label_110;
            label_107:
            val_94 = mem[null + 320 + 8];
            I2.Loc.Localize.MainTranslation = new System.Text.StringBuilder();
            label_101:
            if((val_89 != 0) && ((this.mLocalizeTarget & 1) != 0))
            {
                    if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_100 = this.IgnoreNumbersInRTL;
                var val_68 = (val_100 == true) ? 1 : 0;
                I2.Loc.Localize.MainTranslation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  null, maxCharacters:  48295936, ignoreNumbers:  this.MaxCharactersInRTL);
            }
            
            }
            
            label_116:
            val_101 = I2.Loc.Localize.SecondaryTranslation;
            if(val_101 == null)
            {
                goto label_135;
            }
            
            TermModification val_82 = this.SecondaryTermModifier;
            TermModification val_70 = val_82 - 1;
            val_82 = val_82 + 102;
            var val_71 = (val_70 < 4) ? (val_82) : 0;
            val_70 = val_71 - 103;
            if(val_70 > 3)
            {
                goto label_120;
            }
            
            var val_83 = 25810544;
            val_83 = (25810544 + ((val_70 < 0x4 ? (this.SecondaryTermModifier + 102) : 0 - 103)) << 2) + val_83;
            goto (25810544 + ((val_70 < 0x4 ? (this.SecondaryTermModifier + 102) : 0 - 103)) << 2 + 25810544);
            label_120:
            if(val_71 != 0)
            {
                    return;
            }
            
            if(val_89 != 0)
            {
                    val_104 = this.mLocalizeTarget;
                if((val_104 & 1) != 0)
            {
                    val_104 = ;
                if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_104 = ;
                I2.Loc.Localize.SecondaryTranslation = I2.Loc.LocalizationManager.ApplyRTLfix(line:  null);
            }
            
            }
            
            }
            
            label_135:
            val_105 = null;
            val_105 = null;
            if(I2.Loc.LocalizationManager.HighlightLocalizedTargets != false)
            {
                    I2.Loc.Localize.MainTranslation = 0 + "LOC:"("LOC:");
            }
            
            val_82 = I2.Loc.Localize.SecondaryTranslation;
            I2.Loc.Localize.CurrentLocalizeComponent = 0;
        }
        public bool FindTarget()
        {
            var val_9;
            System.Runtime.Serialization.SerializationInfo val_24;
            string val_25;
            string val_26;
            var val_27;
            string val_28;
            I2.Loc.ILocalizeTarget val_29;
            var val_30;
            var val_31;
            var val_32;
            val_24 = this;
            if(0 != this.mLocalizeTarget)
            {
                    if(((this.mLocalizeTarget & 1) & 1) != 0)
            {
                goto label_5;
            }
            
            }
            
            if(0 != this.mLocalizeTarget)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  0);
                val_25 = 0;
                val_26 = this.mLocalizeTargetName;
                this.mLocalizeTarget = 0;
                this.mLocalizeTargetName = 0;
            }
            else
            {
                    val_26 = val_24;
                val_25 = this.mLocalizeTargetName;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_32;
            }
            
            val_27 = null;
            val_27 = null;
            List.Enumerator<T> val_7 = I2.Loc.LocalizationManager.mLocalizeTargets.GetEnumerator();
            label_29:
            if((0 & 1) == 0)
            {
                goto label_18;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_10 = val_9.InitializationCallback;
            val_28 = this.mLocalizeTargetName;
            object val_11 = val_10.Clone();
            if((System.String.op_Equality(a:  0, b:  val_28)) == false)
            {
                goto label_29;
            }
            
            if(((val_10.Clone() & 1) & 1) != 0)
            {
                    val_10.GetObjectData(info:  this, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
                val_29 = val_10;
                this.mLocalizeTarget = val_29;
            }
            else
            {
                    val_29 = this.mLocalizeTarget;
            }
            
            if(0 == val_29)
            {
                goto label_29;
            }
            
            val_30 = public System.Void List.Enumerator<I2.Loc.ILocalizeTargetDescriptor>::Dispose();
            goto label_30;
            label_18:
            val_9.Dispose();
            label_32:
            val_31 = null;
            val_31 = null;
            List.Enumerator<T> val_17 = I2.Loc.LocalizationManager.mLocalizeTargets.GetEnumerator();
            val_28 = 1152921512278414400;
            label_42:
            if((0 & 1) == 0)
            {
                goto label_36;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_18 = 0.InitializationCallback;
            if(((val_18.Clone() & 1) & 1) == 0)
            {
                goto label_42;
            }
            
            val_18.GetObjectData(info:  this, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            this.mLocalizeTarget = val_18;
            this.mLocalizeTargetName = val_18.Clone();
            if(0 == this.mLocalizeTarget)
            {
                goto label_42;
            }
            
            val_30 = public System.Void List.Enumerator<I2.Loc.ILocalizeTargetDescriptor>::Dispose();
            label_30:
            0.Dispose();
            label_5:
            val_32 = 1;
            return (bool)val_32;
            label_36:
            0.Dispose();
            val_32 = 0;
            return (bool)val_32;
        }
        public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
        {
            var val_11;
            string val_12;
            val_11 = null;
            val_11 = null;
            primaryTerm = System.String.Empty;
            secondaryTerm = System.String.Empty;
            if(this.FindTarget() == false)
            {
                    return;
            }
            
            if(0 != this.mLocalizeTarget)
            {
                    val_12 = this;
                primaryTerm = I2.Loc.I2Utils.RemoveNonASCII(text:  this.mLocalizeTarget, allowCategory:  primaryTerm);
            }
            else
            {
                    val_12 = this.mTerm;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    primaryTerm = mem[this.mTerm];
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    secondaryTerm = this.mTermSecondary;
            }
            
            if(primaryTerm != null)
            {
                    primaryTerm = primaryTerm.Trim();
            }
            
            if(secondaryTerm == null)
            {
                    return;
            }
            
            secondaryTerm = secondaryTerm.Trim();
        }
        public string GetMainTargetsText()
        {
            if(0 == this.mLocalizeTarget)
            {
                    return (string)((System.String.IsNullOrEmpty(value:  0)) != true) ? this.mTerm : -917981000;
            }
            
            0 = 0;
            return (string)((System.String.IsNullOrEmpty(value:  0)) != true) ? this.mTerm : -917981000;
        }
        public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
        {
            primaryTerm = I2.Loc.I2Utils.RemoveNonASCII(text:  this, allowCategory:  Main);
            secondaryTerm = Secondary;
        }
        public void SetTerm(string primary)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    this.mTerm = primary;
                this.FinalTerm = primary;
            }
            
            this.OnLocalize(Force:  true);
        }
        public void SetTerm(string primary, string secondary)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    this.mTerm = primary;
                this.FinalTerm = primary;
            }
            
            this.FinalSecondaryTerm = secondary;
            this.mTermSecondary = secondary;
            this.OnLocalize(Force:  true);
        }
        internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation)
        {
            string val_7;
            UnityEngine.Object val_8;
            val_7 = 1152921512279378240;
            string val_2 = 0;
            string val_1 = 0;
            this.DeserializeTranslation(translation:  mainTranslation, value: out  val_1, secondary: out  val_2);
            val_8 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_8 = this;
                if(0 != this)
            {
                    mainTranslation = val_1;
                secondaryTranslation = val_2;
            }
            
            }
            
            if(0 != this)
            {
                    return (object)val_8;
            }
            
            val_7 = secondaryTranslation;
            val_8 = this;
            return (object)val_8;
        }
        public void UpdateAssetDictionary()
        {
            System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_13;
            if((I2.Loc.Localize.<>f__am$cache0) == null)
            {
                    I2.Loc.Localize.<>f__am$cache0 = new System.Predicate<UnityEngine.Object>(object:  0, method:  static System.Boolean I2.Loc.Localize::<UpdateAssetDictionary>m__0(UnityEngine.Object x));
            }
            
            int val_2 = this.TranslatedObjects.RemoveAll(match:  I2.Loc.Localize.<>f__am$cache0);
            val_13 = 1152921512260533456;
            if((I2.Loc.Localize.<>f__am$cache1) == null)
            {
                    I2.Loc.Localize.<>f__am$cache1 = new System.Func<UnityEngine.Object, System.String>(object:  0, method:  static System.String I2.Loc.Localize::<UpdateAssetDictionary>m__1(UnityEngine.Object o));
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<UnityEngine.Object, System.String>(source:  0, keySelector:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  0));
            if((I2.Loc.Localize.<>f__am$cache2) == null)
            {
                    I2.Loc.Localize.<>f__am$cache2 = new System.Func<UnityEngine.Object, System.String>(object:  0, method:  static System.String I2.Loc.Localize::<UpdateAssetDictionary>m__2(UnityEngine.Object o));
            }
            
            if((I2.Loc.Localize.<>f__am$cache3) == null)
            {
                    I2.Loc.Localize.<>f__am$cache3 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String>(object:  0, method:  static System.String I2.Loc.Localize::<UpdateAssetDictionary>m__3(System.Linq.IGrouping<string, UnityEngine.Object> g));
            }
            
            if((I2.Loc.Localize.<>f__mg$cache0) == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object> val_10 = null;
                val_13 = val_10;
                val_10 = new System.Func<System.Linq.IGrouping<System.String, UnityEngine.Object>, UnityEngine.Object>(object:  0, method:  public static UnityEngine.Object System.Linq.Enumerable::First<UnityEngine.Object>(System.Collections.Generic.IEnumerable<TSource> source));
                I2.Loc.Localize.<>f__mg$cache0 = val_13;
            }
            
            this.mAssetDictionary = System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, UnityEngine.Object>, System.String, UnityEngine.Object>(source:  0, keySelector:  System.Linq.Enumerable.GroupBy<UnityEngine.Object, System.String>(source:  0, keySelector:  System.Linq.Enumerable.Distinct<UnityEngine.Object>(source:  0)), elementSelector:  I2.Loc.Localize.<>f__am$cache3);
        }
        internal T GetObject<T>(string Translation)
        {
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return 0;
            }
            
            if(this == null)
            {
                
            }
        
        }
        private T GetTranslatedObject<T>(string Translation)
        {
            if(this == null)
            {
                
            }
        
        }
        private void DeserializeTranslation(string translation, out string value, out string secondary)
        {
            var val_12;
            if(((System.String.IsNullOrEmpty(value:  0)) == true) || (translation.Length < 2))
            {
                goto label_9;
            }
            
            char val_5 = translation.Chars[0] & 65535;
            if(val_5 != '[')
            {
                goto label_9;
            }
            
            int val_6 = translation.IndexOf(value:  ']');
            int val_7 = val_6 - 1;
            if(val_5 < '[')
            {
                goto label_9;
            }
            
            if(translation == null)
            {
                goto label_10;
            }
            
            secondary = translation.Substring(startIndex:  1, length:  val_7);
            goto label_11;
            label_9:
            value = translation;
            val_12 = null;
            val_12 = null;
            secondary = System.String.Empty;
            return;
            label_10:
            secondary = 0.Substring(startIndex:  1, length:  val_7);
            label_11:
            value = translation.Substring(startIndex:  val_6 + 1);
        }
        public T FindTranslatedObject<T>(string value)
        {
            var val_5;
            var val_19;
            IntPtr val_20;
            var val_21;
            var val_23;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_19 = 0;
                return (object)val_19;
            }
            
            if(this.mAssetDictionary != null)
            {
                    if(this.mAssetDictionary.Count == this.TranslatedObjects.Count)
            {
                goto label_7;
            }
            
            }
            
            this.UpdateAssetDictionary();
            label_7:
            Dictionary.Enumerator<TKey, TValue> val_4 = this.mAssetDictionary.GetEnumerator();
            do
            {
                label_16:
                if((0 & 1) == 0)
            {
                goto label_37;
            }
            
                UnityEngine.Playables.PlayableHandle val_7 = val_5.GetHandle();
            }
            while(val_7.m_Handle == 0);
            
            if(((value.EndsWith(value:  val_7.m_Handle.InitializationCallback, comparisonType:  5)) == false) || ((System.String.Compare(strA:  0, strB:  value, comparisonType:  val_7.m_Handle.InitializationCallback)) != 0))
            {
                goto label_16;
            }
            
            if(val_7.m_Handle != 0)
            {
                    val_19 = ;
                if(val_7.m_Handle != 0)
            {
                    val_20 = 0;
                val_21 = 240;
            }
            
            }
            
            label_37:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_23;
            if( != 191)
            {
                    if( == 240)
            {
                    return (object)val_19;
            }
            
            }
            
            val_21 = I2.Loc.LocalizationManager.FindAsset(value:  0);
            val_19 = 0;
            if(val_21 != null)
            {
                    val_19 = val_21;
                if(val_19 == null)
            {
                    val_19 = 0;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return (object)val_19;
            }
            
            val_19 = I2.Loc.ResourceManager.pInstance;
            return (object)val_19;
        }
        public bool HasTranslatedObject(UnityEngine.Object Obj)
        {
            if((this.TranslatedObjects.Contains(item:  Obj)) != false)
            {
                    return true;
            }
            
            I2.Loc.ResourceManager val_3 = I2.Loc.ResourceManager.pInstance;
            if(val_3 != null)
            {
                    return val_3.HasAsset(Obj:  Obj);
            }
            
            return val_3.HasAsset(Obj:  Obj);
        }
        public void AddTranslatedObject(UnityEngine.Object Obj)
        {
            if((this.TranslatedObjects.Contains(item:  Obj)) != false)
            {
                    return;
            }
            
            this.TranslatedObjects.Add(item:  Obj);
            this.UpdateAssetDictionary();
        }
        public void SetGlobalLanguage(string Language)
        {
            I2.Loc.LocalizationManager.CurrentLanguage = null;
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
        private static string <UpdateAssetDictionary>m__2(UnityEngine.Object o)
        {
            if(X1 != 0)
            {
                    return X1.name;
            }
            
            return X1.name;
        }
        private static string <UpdateAssetDictionary>m__3(System.Linq.IGrouping<string, UnityEngine.Object> g)
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
    
    }

}
