using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class NotificationEntryUI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI text;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconImage;
        
        // Properties
        public string Message { get; set; }
        public UnityEngine.Sprite Icon { get; set; }
        
        // Methods
        public NotificationEntryUI()
        {
        
        }
        public string get_Message()
        {
            if(this.text != null)
            {
                    return this.text.text;
            }
            
            return this.text.text;
        }
        public void set_Message(string value)
        {
            this.text.text = value;
        }
        public UnityEngine.Sprite get_Icon()
        {
            if(0 == this.iconImage)
            {
                    return 0;
            }
            
            if(this.iconImage != null)
            {
                    return this.iconImage.sprite;
            }
            
            return this.iconImage.sprite;
        }
        public void set_Icon(UnityEngine.Sprite value)
        {
            var val_5;
            if(0 == this.iconImage)
            {
                    return;
            }
            
            this.iconImage.sprite = value;
            if(0 == value)
            {
                    val_5 = 0;
            }
            else
            {
                    val_5 = 1;
            }
            
            this.iconImage.gameObject.SetActive(value:  true);
        }
        public void OnPulledFromPool()
        {
            this.text.enabled = true;
            if(0 == this.iconImage)
            {
                    return;
            }
            
            this.iconImage.gameObject.SetActive(value:  true);
        }
        public void OnPushedToPool()
        {
            this.text.enabled = false;
            if(0 == this.iconImage)
            {
                    return;
            }
            
            this.iconImage.sprite = 0;
            this.iconImage.gameObject.SetActive(value:  false);
        }
    
    }

}
