using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class TopPlayerElementUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.RawImage icon;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI label;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI playerName;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase ui;
        
        // Properties
        public TzarGames.Common.UI.UIBase UiBase { get; }
        public string Label { get; set; }
        public string PlayerName { get; set; }
        public UnityEngine.Texture PlayerIcon { get; set; }
        
        // Methods
        public TopPlayerElementUI()
        {
        
        }
        public TzarGames.Common.UI.UIBase get_UiBase()
        {
            return (TzarGames.Common.UI.UIBase)this.ui;
        }
        public string get_Label()
        {
            if(this.label != null)
            {
                    return this.label.text;
            }
            
            return this.label.text;
        }
        public void set_Label(string value)
        {
            this.label.text = value;
        }
        public string get_PlayerName()
        {
            if(this.playerName != null)
            {
                    return this.playerName.text;
            }
            
            return this.playerName.text;
        }
        public void set_PlayerName(string value)
        {
            this.playerName.text = value;
        }
        public UnityEngine.Texture get_PlayerIcon()
        {
            if(this.icon != null)
            {
                    return this.icon.texture;
            }
            
            return this.icon.texture;
        }
        public void set_PlayerIcon(UnityEngine.Texture value)
        {
            this.icon.texture = value;
        }
    
    }

}
