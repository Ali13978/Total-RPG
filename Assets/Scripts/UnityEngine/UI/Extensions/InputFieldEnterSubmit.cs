using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class InputFieldEnterSubmit : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.InputFieldEnterSubmit.EnterSubmitEvent EnterSubmit;
        private UnityEngine.UI.InputField _input;
        
        // Methods
        public InputFieldEnterSubmit()
        {
        
        }
        private void Awake()
        {
            UnityEngine.UI.InputField val_1 = this.GetComponent<UnityEngine.UI.InputField>();
            this._input = val_1;
            val_1.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  public System.Void UnityEngine.UI.Extensions.InputFieldEnterSubmit::OnEndEdit(string txt)));
        }
        public void OnEndEdit(string txt)
        {
            if((UnityEngine.Input.GetKeyDown(key:  0)) != true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                    return;
            }
            
            }
            
            this.EnterSubmit.Invoke(arg0:  txt);
        }
    
    }

}
