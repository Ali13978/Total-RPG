using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class LanguageSelectUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private I2.Loc.LanguageSource source;
        [UnityEngine.SerializeField]
        private TMPro.TMP_Dropdown list;
        
        // Methods
        public LanguageSelectUI()
        {
        
        }
        private void Start()
        {
            goto label_3;
            label_9:
            Add(item:  X23);
            0 = 1;
            label_3:
            if(0 >= this.source.mLanguages.Count)
            {
                goto label_5;
            }
            
            I2.Loc.LanguageData val_4 = this.source.mLanguages.Item[1];
            if(null != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_5:
            this.list.AddOptions(options:  new System.Collections.Generic.List<System.String>(capacity:  this.source.mLanguages.Count));
            this.list.value = this.source.GetLanguageIndex(language:  I2.Loc.LocalizationManager.CurrentLanguage, AllowDiscartingRegion:  true, SkipDisabled:  true);
            this.list.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.LanguageSelectUI::onOtherLanguageSelected(int arg0)));
        }
        private void onOtherLanguageSelected(int arg0)
        {
            string val_3 = this.list.options.Item[arg0].text;
            TzarGames.Common.LocalizedStringAsset.SetLanguage(language:  0);
        }
    
    }

}
