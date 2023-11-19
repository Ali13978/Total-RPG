using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class FloatingTextLabelUI : FloatingLabelBaseUI
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI _textUi;
        
        // Properties
        public string Text { get; set; }
        public UnityEngine.Color Color { get; set; }
        
        // Methods
        public FloatingTextLabelUI()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public string get_Text()
        {
            if(this._textUi != null)
            {
                    return this._textUi.text;
            }
            
            return this._textUi.text;
        }
        public void set_Text(string value)
        {
            this._textUi.text = value;
        }
        public UnityEngine.Color get_Color()
        {
            if(this._textUi != null)
            {
                    return this._textUi.Color;
            }
            
            return this._textUi.Color;
        }
        public void set_Color(UnityEngine.Color value)
        {
            this._textUi.Color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            if(0 == this._textUi)
            {
                    return;
            }
            
            this._textUi.enabled = true;
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            if(0 == this._textUi)
            {
                    return;
            }
            
            this._textUi.enabled = false;
        }
    
    }

}
