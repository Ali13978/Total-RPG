using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class RewardItemUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI itemName;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image icon;
        
        // Properties
        public string Label { get; set; }
        public UnityEngine.Sprite Icon { get; set; }
        
        // Methods
        public RewardItemUI()
        {
        
        }
        public string get_Label()
        {
            if(this.itemName != null)
            {
                    return this.itemName.text;
            }
            
            return this.itemName.text;
        }
        public void set_Label(string value)
        {
            this.itemName.text = value;
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
        }
    
    }

}
