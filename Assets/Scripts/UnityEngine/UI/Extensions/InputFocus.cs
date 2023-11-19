using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class InputFocus : MonoBehaviour
    {
        // Fields
        protected UnityEngine.UI.InputField _inputField;
        public bool _ignoreNextActivation;
        
        // Methods
        public InputFocus()
        {
        
        }
        private void Start()
        {
            this._inputField = this.GetComponent<UnityEngine.UI.InputField>();
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyUp(key:  0)) == false)
            {
                    return;
            }
            
            if(this._inputField.isFocused == true)
            {
                    return;
            }
            
            if(this._ignoreNextActivation != false)
            {
                    this._ignoreNextActivation = false;
                return;
            }
            
            this._inputField.ActivateInputField();
        }
        public void buttonPressed()
        {
            var val_4 = null;
            this._inputField.text = System.String.Empty;
            if((System.String.op_Equality(a:  0, b:  this._inputField.text)) != false)
            {
                    return;
            }
            
            this._inputField.ActivateInputField();
        }
        public void OnEndEdit(string textString)
        {
            var val_4;
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            this._inputField.text = System.String.Empty;
            if((System.String.op_Equality(a:  0, b:  this._inputField.text)) == false)
            {
                    return;
            }
            
            this._ignoreNextActivation = true;
        }
    
    }

}
