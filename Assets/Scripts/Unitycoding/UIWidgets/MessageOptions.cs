using UnityEngine;

namespace Unitycoding.UIWidgets
{
    [Serializable]
    public class MessageOptions
    {
        // Fields
        public string title;
        public string text;
        public UnityEngine.Color color;
        public UnityEngine.Sprite icon;
        public float delay;
        public float duration;
        public bool ignoreTimeScale;
        
        // Methods
        public MessageOptions(Unitycoding.UIWidgets.MessageOptions other)
        {
            null = null;
            this.title = System.String.Empty;
            this.text = System.String.Empty;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.color = val_1;
            mem[1152921512629674260] = val_1.g;
            mem[1152921512629674264] = val_1.b;
            mem[1152921512629674268] = val_1.a;
            this.delay = 2f;
            this.duration = 2f;
            this.ignoreTimeScale = true;
            if(other != null)
            {
                    this.title = other.title;
                this.text = other.text;
                this.icon = other.icon;
            }
            else
            {
                    this.title = 11993091;
                this.text = 7254272;
                this.icon = 0;
            }
            
            this.color = other.color;
            if(other != null)
            {
                    this.duration = other.duration;
            }
            else
            {
                    this.duration = 2.295924E-39f;
            }
            
            this.ignoreTimeScale = other.ignoreTimeScale;
        }
        public MessageOptions()
        {
            null = null;
            this.title = System.String.Empty;
            this.text = System.String.Empty;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.color = val_1;
            mem[1152921512629802644] = val_1.g;
            mem[1152921512629802648] = val_1.b;
            mem[1152921512629802652] = val_1.a;
            this.delay = 2f;
            this.duration = 2f;
            this.ignoreTimeScale = true;
        }
    
    }

}
