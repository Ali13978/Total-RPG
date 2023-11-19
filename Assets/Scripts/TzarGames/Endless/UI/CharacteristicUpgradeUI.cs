using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class CharacteristicUpgradeUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset templateText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.IntCounterUI counter;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI label;
        
        // Properties
        public string TemplateText { get; }
        public TzarGames.Common.UI.IntCounterUI Counter { get; }
        public string Label { get; set; }
        
        // Methods
        public CharacteristicUpgradeUI()
        {
        
        }
        public string get_TemplateText()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public TzarGames.Common.UI.IntCounterUI get_Counter()
        {
            return (TzarGames.Common.UI.IntCounterUI)this.counter;
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
        private void Reset()
        {
            this.counter = this.GetComponentInChildren<TzarGames.Common.UI.IntCounterUI>();
            var val_10 = 0;
            label_9:
            if(val_10 >= val_2.Length)
            {
                goto label_2;
            }
            
            T val_9 = this.GetComponentsInChildren<TzarGames.Common.UI.TextUI>()[0];
            var val_4 = (0 != 0) ? (val_9) : 0;
            val_10 = val_10 + 1;
            if(0 == val_9.LocalizedString)
            {
                goto label_9;
            }
            
            this.label = val_9;
            this.templateText = val_9.LocalizedString;
            return;
            label_2:
            if(0 == 0)
            {
                    return;
            }
            
            this.label = 0;
        }
    
    }

}
