using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class DialogueEntryUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI _text;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image icon;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.LayoutElement iconLayoutElement;
        
        // Properties
        public string Message { get; set; }
        public UnityEngine.Sprite Icon { get; set; }
        
        // Methods
        public DialogueEntryUI()
        {
        
        }
        public string get_Message()
        {
            if(this._text != null)
            {
                    return this._text.text;
            }
            
            return this._text.text;
        }
        public void set_Message(string value)
        {
            this._text.text = value;
        }
        public UnityEngine.Sprite get_Icon()
        {
            if(this.icon != null)
            {
                    return this.icon.sprite;
            }
            
            return this.icon.sprite;
        }
        public void set_Icon(UnityEngine.Sprite value)
        {
            this.icon.sprite = value;
            UnityEngine.Sprite val_2 = value;
            val_2 = UnityEngine.Object.op_Inequality(x:  0, y:  val_2);
            this.iconLayoutElement.enabled = val_2;
        }
    
    }

}
