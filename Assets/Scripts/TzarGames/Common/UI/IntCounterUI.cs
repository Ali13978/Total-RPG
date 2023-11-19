using UnityEngine;

namespace TzarGames.Common.UI
{
    public class IntCounterUI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.InputFieldUI input;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button incrementButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button decrementButton;
        [UnityEngine.SerializeField]
        private int initialValue;
        [UnityEngine.SerializeField]
        private int minValue;
        [UnityEngine.SerializeField]
        private int maxValue;
        private bool enableDecrement;
        private bool enableIncrement;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<string> OnValueChanged;
        private int currentValue;
        
        // Properties
        public int CurrentValue { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        
        // Methods
        public IntCounterUI()
        {
            this.maxValue = 10;
            this.enableDecrement = true;
            this.enableIncrement = true;
            this.currentValue = 0;
        }
        public void add_OnValueChanged(System.Action<string> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnValueChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511223425552 != this.OnValueChanged);
        
        }
        public void remove_OnValueChanged(System.Action<string> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnValueChanged);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511223562128 != this.OnValueChanged);
        
        }
        public int get_CurrentValue()
        {
            return (int)this.currentValue;
        }
        public void set_CurrentValue(int value)
        {
            this.currentValue = value;
            this.updateValues(updateInputText:  true);
        }
        public int get_MaxValue()
        {
            return (int)this.maxValue;
        }
        public void set_MaxValue(int value)
        {
            this.maxValue = value;
            this.updateValues(updateInputText:  true);
        }
        public int get_MinValue()
        {
            return (int)this.minValue;
        }
        public void set_MinValue(int value)
        {
            this.minValue = value;
            this.updateValues(updateInputText:  true);
        }
        public void EnableDecrement(bool enable)
        {
            bool val_1 = enable;
            this.enableDecrement = val_1;
            this.decrementButton.interactable = val_1;
        }
        public void EnableIncrement(bool enable)
        {
            bool val_1 = enable;
            this.enableIncrement = val_1;
            this.incrementButton.interactable = val_1;
        }
        private void Awake()
        {
            this.input.add_OnValueChanged(value:  new System.Action<System.String>(object:  this, method:  System.Void TzarGames.Common.UI.IntCounterUI::<Awake>m__0(string obj)));
        }
        private void Start()
        {
            if(this.currentValue == 1)
            {
                    this.currentValue = this.initialValue;
            }
            
            this.updateValues(updateInputText:  true);
        }
        private void updateValues(bool updateInputText = True)
        {
            bool val_6;
            int val_1 = UnityEngine.Mathf.Clamp(value:  0, min:  this.currentValue, max:  this.minValue);
            this.currentValue = val_1;
            if(val_1 > this.minValue)
            {
                    val_6 = this.enableDecrement;
            }
            else
            {
                    val_6 = 0;
            }
            
            this.decrementButton.interactable = (val_6 != 0) ? 1 : 0;
            this.incrementButton.interactable = ((this.currentValue < this.maxValue) ? 1 : 0) & ((this.maxValue != 0) ? 1 : 0);
            if(updateInputText == false)
            {
                    return;
            }
            
            this.input.TmproInputField.text = this.currentValue;
        }
        public void OnInputUpdated()
        {
            string val_4;
            TMPro.TMP_InputField val_5;
            val_4 = this;
            if((System.Int32.TryParse(s:  0, result: out  this.input.TmproInputField.text)) == false)
            {
                goto label_2;
            }
            
            if(this.currentValue == 0)
            {
                    return;
            }
            
            this.currentValue = 0;
            this.updateValues(updateInputText:  false);
            val_4 = 1152921511225005464;
            val_5 = this.input.TmproInputField;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_6;
            label_2:
            val_4 = this.currentValue;
            val_5 = this.input.TmproInputField;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            label_6:
            label_8:
            val_5.text = val_4;
        }
        public void Increment()
        {
            int val_1 = this.currentValue;
            val_1 = val_1 + 1;
            this.currentValue = val_1;
            this.updateValues(updateInputText:  true);
        }
        public void Decrement()
        {
            int val_1 = this.currentValue;
            val_1 = val_1 - 1;
            this.currentValue = val_1;
            this.updateValues(updateInputText:  true);
        }
        private void OnEnable()
        {
            if(this.input.enabled != false)
            {
                    return;
            }
            
            this.input.enabled = true;
        }
        private void OnDisable()
        {
            if(this.input.enabled == false)
            {
                    return;
            }
            
            this.input.enabled = false;
        }
        public void OnPushedToPool()
        {
            this.OnValueChanged = 0;
            this.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
        private void <Awake>m__0(string obj)
        {
            if(this.OnValueChanged == null)
            {
                    return;
            }
            
            this.OnValueChanged.Invoke(obj:  obj);
        }
    
    }

}
