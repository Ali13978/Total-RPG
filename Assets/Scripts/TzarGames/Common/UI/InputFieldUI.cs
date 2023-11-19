using UnityEngine;

namespace TzarGames.Common.UI
{
    public class InputFieldUI : MonoBehaviour
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<string> OnValueChanged;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.StringEvent onSubmit;
        public TMPro.TMP_InputField TmproInputField;
        
        // Properties
        public TzarGames.Common.Events.StringEvent OnSubmit { get; }
        public string Text { get; set; }
        public int CharacterLimit { get; set; }
        public int CaretPosition { get; set; }
        
        // Methods
        public InputFieldUI()
        {
        
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
            while(1152921511221511016 != this.OnValueChanged);
        
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
            while(1152921511221647592 != this.OnValueChanged);
        
        }
        public TzarGames.Common.Events.StringEvent get_OnSubmit()
        {
            return (TzarGames.Common.Events.StringEvent)this.onSubmit;
        }
        public string get_Text()
        {
            if(this.TmproInputField != null)
            {
                    return this.TmproInputField.text;
            }
            
            return this.TmproInputField.text;
        }
        public void set_Text(string value)
        {
            this.TmproInputField.text = value;
        }
        public int get_CharacterLimit()
        {
            if(this.TmproInputField != null)
            {
                    return this.TmproInputField.characterLimit;
            }
            
            return this.TmproInputField.characterLimit;
        }
        public void set_CharacterLimit(int value)
        {
            this.TmproInputField.characterLimit = value;
        }
        public int get_CaretPosition()
        {
            if(this.TmproInputField != null)
            {
                    return this.TmproInputField.caretPosition;
            }
            
            return this.TmproInputField.caretPosition;
        }
        public void set_CaretPosition(int value)
        {
            this.TmproInputField.caretPosition = value;
        }
        public void ActivateInputField()
        {
            this.TmproInputField.ActivateInputField();
        }
        private void Awake()
        {
            this.TmproInputField.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void TzarGames.Common.UI.InputFieldUI::onChanged(string val)));
            this.TmproInputField.onSubmit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void TzarGames.Common.UI.InputFieldUI::onSubmitHandler(string text)));
        }
        private void onSubmitHandler(string text)
        {
            this.onSubmit.Invoke(arg0:  text);
        }
        private void onChanged(string val)
        {
            if(this.OnValueChanged == null)
            {
                    return;
            }
            
            this.OnValueChanged.Invoke(obj:  val);
        }
        private void OnDestroy()
        {
            if(0 == this.TmproInputField)
            {
                    return;
            }
            
            this.TmproInputField.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void TzarGames.Common.UI.InputFieldUI::onChanged(string val)));
            this.TmproInputField.onSubmit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void TzarGames.Common.UI.InputFieldUI::onSubmitHandler(string text)));
        }
    
    }

}
