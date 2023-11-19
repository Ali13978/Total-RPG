using UnityEngine;

namespace I2.Loc
{
    [UnityEngine.AddComponentMenu]
    public class SetLanguageDropdown : MonoBehaviour
    {
        // Methods
        public SetLanguageDropdown()
        {
        
        }
        private void OnEnable()
        {
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if(0 == val_1)
            {
                    return;
            }
            
            if(I2.Loc.LocalizationManager.Sources.Count == 0)
            {
                    bool val_6 = I2.Loc.LocalizationManager.UpdateSources();
            }
            
            System.Collections.Generic.List<System.String> val_7 = I2.Loc.LocalizationManager.GetAllLanguages(SkipDisabled:  false);
            if(val_1 != null)
            {
                    val_1.ClearOptions();
            }
            else
            {
                    val_1.ClearOptions();
            }
            
            val_1.AddOptions(options:  val_7);
            int val_8 = val_7.IndexOf(item:  I2.Loc.LocalizationManager.CurrentLanguage);
            if(val_1 != null)
            {
                    val_1.value = val_8;
            }
            else
            {
                    val_1.value = val_8;
            }
            
            val_1.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void I2.Loc.SetLanguageDropdown::OnValueChanged(int index)));
            val_1.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void I2.Loc.SetLanguageDropdown::OnValueChanged(int index)));
        }
        private void OnValueChanged(int index)
        {
            var val_5;
            string val_6;
            val_5 = index;
            UnityEngine.UI.Dropdown val_1 = this.GetComponent<UnityEngine.UI.Dropdown>();
            if((val_5 & 2147483648) != 0)
            {
                    val_1.value = 0;
                val_5 = 0;
            }
            
            string val_4 = val_1.options.Item[0].text;
            val_6 = null;
            I2.Loc.LocalizationManager.CurrentLanguage = val_6;
        }
    
    }

}
