using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class SkillUpgradeUI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image icon;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI commonCounterLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI cooldownCounterLabel;
        public TzarGames.Common.UI.IntCounterUI CommonCounter;
        public TzarGames.Common.UI.IntCounterUI CooldownCounter;
        
        // Properties
        public string CommonCounterLabel { get; set; }
        public string CooldownCounterLabel { get; set; }
        public UnityEngine.Sprite Icon { get; set; }
        
        // Methods
        public SkillUpgradeUI()
        {
        
        }
        public string get_CommonCounterLabel()
        {
            if(this.commonCounterLabel != null)
            {
                    return this.commonCounterLabel.text;
            }
            
            return this.commonCounterLabel.text;
        }
        public void set_CommonCounterLabel(string value)
        {
            this.commonCounterLabel.text = value;
        }
        public string get_CooldownCounterLabel()
        {
            if(this.cooldownCounterLabel != null)
            {
                    return this.cooldownCounterLabel.text;
            }
            
            return this.cooldownCounterLabel.text;
        }
        public void set_CooldownCounterLabel(string value)
        {
            this.cooldownCounterLabel.text = value;
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
        public void OnPushedToPool()
        {
            this.icon.sprite = 0;
            this.commonCounterLabel.enabled = false;
            this.cooldownCounterLabel.enabled = false;
            this.CommonCounter.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.commonCounterLabel.enabled = true;
            this.cooldownCounterLabel.enabled = true;
            this.CommonCounter.enabled = true;
        }
    
    }

}
