using UnityEngine;

namespace TzarGames.Common.UI
{
    public class TextUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset _localizedString;
        public TMPro.TextMeshProUGUI TmproText;
        private bool initialized;
        
        // Properties
        public TzarGames.Common.LocalizedStringAsset LocalizedString { get; }
        public string text { get; set; }
        public UnityEngine.Color Color { get; set; }
        
        // Methods
        public TextUI()
        {
        
        }
        public TzarGames.Common.LocalizedStringAsset get_LocalizedString()
        {
            return (TzarGames.Common.LocalizedStringAsset)this._localizedString;
        }
        public string get_text()
        {
            if(0 != this._localizedString)
            {
                    if(this._localizedString != null)
            {
                    return this._localizedString.Text;
            }
            
                return this._localizedString.Text;
            }
            
            if(this.TmproText != null)
            {
                    return this.TmproText.text;
            }
            
            return this.TmproText.text;
        }
        public void set_text(string value)
        {
            if(0 != this._localizedString)
            {
                    System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
                UnityEngine.Transform val_3 = this.transform;
                TzarGames.Common.Utils.LogObjectPath(textTransform:  val_3, sb:  val_3);
                string val_4 = 0 + "Trying to set localized text ";
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.TmproText.text = value;
        }
        public static void ReplaceLocalizedText(TzarGames.Common.UI.TextUI textUI, string newText)
        {
            newText.text = X2;
        }
        public UnityEngine.Color get_Color()
        {
            if(this.TmproText == null)
            {
                
            }
        
        }
        public void set_Color(UnityEngine.Color value)
        {
            if(this.TmproText == null)
            {
                
            }
        
        }
        private void Awake()
        {
            if(this.initialized != false)
            {
                    return;
            }
            
            this.initialize();
        }
        private void initialize()
        {
            var val_10;
            if(0 == this._localizedString)
            {
                goto label_3;
            }
            
            val_10 = this.text;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_6;
            }
            
            val_10 = this.text;
            if((val_10.Equals(value:  this._localizedString.Text)) == true)
            {
                goto label_9;
            }
            
            label_6:
            this.TmproText.text = this._localizedString.Text;
            label_9:
            this._localizedString.add_OnUpdated(value:  new System.Action<TzarGames.Common.LocalizedStringAsset>(object:  this, method:  System.Void TzarGames.Common.UI.TextUI::LocalizedStringOnOnUpdated(TzarGames.Common.LocalizedStringAsset localizedStringAsset)));
            label_3:
            this.initialized = true;
        }
        private void LocalizedStringOnOnUpdated(TzarGames.Common.LocalizedStringAsset localizedStringAsset)
        {
            this.TmproText.text = this._localizedString.Text;
        }
        private void OnDestroy()
        {
            if(0 == this._localizedString)
            {
                    return;
            }
            
            this._localizedString.remove_OnUpdated(value:  new System.Action<TzarGames.Common.LocalizedStringAsset>(object:  this, method:  System.Void TzarGames.Common.UI.TextUI::LocalizedStringOnOnUpdated(TzarGames.Common.LocalizedStringAsset localizedStringAsset)));
        }
        private void OnEnable()
        {
            this.TmproText.enabled = true;
            if(this.initialized != false)
            {
                    return;
            }
            
            this.initialize();
        }
        private void OnDisable()
        {
            this.TmproText.enabled = false;
        }
    
    }

}
