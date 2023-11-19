using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class KeyTrigger : MonoBehaviour
    {
        // Fields
        public UnityEngine.KeyCode key;
        public Unitycoding.UIWidgets.KeyTrigger.KeyEvent onKeyDown;
        
        // Methods
        public KeyTrigger()
        {
        
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                    return;
            }
            
            if((0 != UnityEngine.EventSystems.EventSystem.current) && (0 != UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject))
            {
                    if(0 != (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<UnityEngine.UI.InputField>()))
            {
                    return;
            }
            
            }
            
            this.onKeyDown.Invoke();
        }
    
    }

}
