using UnityEngine;

namespace I2.Loc
{
    [UnityEngine.AddComponentMenu]
    public class LocalizeDropdown : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<string> _Terms;
        
        // Methods
        public LocalizeDropdown()
        {
            this._Terms = new System.Collections.Generic.List<System.String>();
        }
        public void Start()
        {
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            I2.Loc.LocalizationManager.add_OnLocalizeEvent(value:  null);
            this.OnLocalize();
        }
        public void OnDestroy()
        {
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_20 = this;
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_28 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            typeof(LocalizationManager.OnLocalizeCallback).__il2cppRuntimeField_10 = public System.Void I2.Loc.LocalizeDropdown::OnLocalize();
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  null);
        }
        private void OnEnable()
        {
            if(this._Terms.Count == 0)
            {
                    this.FillValues();
            }
            
            this.OnLocalize();
        }
        public void OnLocalize()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            if(0 == this.gameObject)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            string val_7 = I2.Loc.LocalizationManager.CurrentLanguage;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return;
            }
            
            this.UpdateLocalization();
        }
        private void FillValues()
        {
            var val_8;
            var val_9;
            val_8 = this;
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(0 == val_1)
            {
                    if(UnityEngine.Application.isPlaying != false)
            {
                    this.FillValuesTMPro();
                return;
            }
            
            }
            
            List.Enumerator<T> val_5 = val_1.options.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_8;
            }
            
            this._Terms.Add(item:  0.InitializationCallback.text);
            goto label_11;
            label_8:
            val_8 = 0;
            val_9 = 1;
            0.Dispose();
            if((val_9 & 1) != 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        public void UpdateLocalization()
        {
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(0 == val_1)
            {
                    this.UpdateLocalizationTMPro();
                return;
            }
            
            val_1.options.Clear();
            List.Enumerator<T> val_4 = this._Terms.GetEnumerator();
            label_13:
            if((0 & 1) == 0)
            {
                goto label_17;
            }
            
            Dropdown.OptionData val_8 = new Dropdown.OptionData(text:  I2.Loc.LocalizationManager.GetTranslation(Term:  null, FixForRTL:  0.InitializationCallback, maxLineLengthForRTL:  1, ignoreRTLnumbers:  false, applyParameters:  true, localParametersRoot:  0, overrideLanguage:  0));
            val_1.options.Add(item:  null);
            goto label_13;
            label_17:
            0.Dispose();
            val_1.RefreshShownValue();
        }
        public void UpdateLocalizationTMPro()
        {
            TMPro.TMP_Dropdown val_1 = this.GetComponent<TMPro.TMP_Dropdown>();
            if(0 == val_1)
            {
                    return;
            }
            
            val_1.options.Clear();
            List.Enumerator<T> val_5 = this._Terms.GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            TMP_Dropdown.OptionData val_9 = new TMP_Dropdown.OptionData(text:  I2.Loc.LocalizationManager.GetTranslation(Term:  null, FixForRTL:  0.InitializationCallback, maxLineLengthForRTL:  1, ignoreRTLnumbers:  false, applyParameters:  true, localParametersRoot:  0, overrideLanguage:  0));
            val_1.options.Add(item:  null);
            goto label_12;
            label_16:
            0.Dispose();
            val_1.RefreshShownValue();
        }
        private void FillValuesTMPro()
        {
            var val_8;
            var val_9;
            val_8 = this;
            TMPro.TMP_Dropdown val_1 = this.GetComponent<TMPro.TMP_Dropdown>();
            if(0 == val_1)
            {
                    return;
            }
            
            List.Enumerator<T> val_5 = val_1.options.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            this._Terms.Add(item:  0.InitializationCallback.text);
            goto label_9;
            label_6:
            val_8 = 0;
            val_9 = 1;
            0.Dispose();
            if((val_9 & 1) != 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
    
    }

}
