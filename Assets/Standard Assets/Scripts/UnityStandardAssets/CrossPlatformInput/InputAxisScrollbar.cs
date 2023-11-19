using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class InputAxisScrollbar : MonoBehaviour
    {
        // Fields
        public string axis;
        
        // Methods
        public InputAxisScrollbar()
        {
        
        }
        private void Update()
        {
        
        }
        public void HandleInput(float value)
        {
            value = value + value;
            value = value + (-1f);
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetAxis(name:  null, value:  value);
        }
    
    }

}
