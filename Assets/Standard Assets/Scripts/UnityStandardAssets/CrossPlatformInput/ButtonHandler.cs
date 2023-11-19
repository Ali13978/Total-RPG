using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {
        // Fields
        public string Name;
        
        // Methods
        public ButtonHandler()
        {
        
        }
        private void OnDisable()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetButtonUp(name:  null);
        }
        public void SetDownState()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetButtonDown(name:  null);
        }
        public void SetUpState()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetButtonUp(name:  null);
        }
        public void SetAxisPositiveState()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetAxisPositive(name:  null);
        }
        public void SetAxisNeutralState()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetAxisZero(name:  null);
        }
        public void SetAxisNegativeState()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.SetAxisNegative(name:  null);
        }
    
    }

}
