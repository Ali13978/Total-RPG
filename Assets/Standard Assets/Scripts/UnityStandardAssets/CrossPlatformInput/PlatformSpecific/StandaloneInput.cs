using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
    public class StandaloneInput : VirtualInput
    {
        // Methods
        public StandaloneInput()
        {
        
        }
        public override float GetAxis(string name, bool raw)
        {
            if(raw == false)
            {
                    return UnityEngine.Input.GetAxis(axisName:  0);
            }
            
            return UnityEngine.Input.GetAxisRaw(axisName:  0);
        }
        public override bool GetButton(string name)
        {
            return UnityEngine.Input.GetButton(buttonName:  0);
        }
        public override bool GetButtonDown(string name)
        {
            return UnityEngine.Input.GetButtonDown(buttonName:  0);
        }
        public override bool GetButtonUp(string name)
        {
            return UnityEngine.Input.GetButtonUp(buttonName:  0);
        }
        public override void SetButtonDown(string name)
        {
            System.Exception val_1 = new System.Exception(message:  " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }
        public override void SetButtonUp(string name)
        {
            System.Exception val_1 = new System.Exception(message:  " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }
        public override void SetAxisPositive(string name)
        {
            System.Exception val_1 = new System.Exception(message:  " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }
        public override void SetAxisNegative(string name)
        {
            System.Exception val_1 = new System.Exception(message:  " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }
        public override void SetAxisZero(string name)
        {
            System.Exception val_1 = new System.Exception(message:  " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }
        public override void SetAxis(string name, float value)
        {
            System.Exception val_1 = new System.Exception(message:  " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }
        public override UnityEngine.Vector3 MousePosition()
        {
            return UnityEngine.Input.mousePosition;
        }
    
    }

}
