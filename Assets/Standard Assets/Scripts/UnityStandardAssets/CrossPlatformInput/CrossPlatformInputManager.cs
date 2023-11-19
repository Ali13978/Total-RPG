using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public static class CrossPlatformInputManager
    {
        // Fields
        private static UnityStandardAssets.CrossPlatformInput.VirtualInput activeInput;
        private static UnityStandardAssets.CrossPlatformInput.VirtualInput s_TouchInput;
        private static UnityStandardAssets.CrossPlatformInput.VirtualInput s_HardwareInput;
        
        // Properties
        public static UnityEngine.Vector3 mousePosition { get; }
        
        // Methods
        private static CrossPlatformInputManager()
        {
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.s_TouchInput = new UnityStandardAssets.CrossPlatformInput.VirtualInput();
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.s_HardwareInput = new UnityStandardAssets.CrossPlatformInput.VirtualInput();
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput = UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.s_TouchInput;
        }
        public static void SwitchActiveInputMethod(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.ActiveInputMethod activeInputMethod)
        {
            var val_1;
            var val_2;
            UnityStandardAssets.CrossPlatformInput.VirtualInput val_4;
            var val_5;
            val_1 = W1;
            if(val_1 != 1)
            {
                    if(val_1 != 0)
            {
                    return;
            }
            
                val_1 = 1152921504855195648;
                val_2 = null;
                val_2 = null;
                val_4 = UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.s_HardwareInput;
            }
            else
            {
                    val_1 = 1152921504855195648;
                val_5 = null;
                val_5 = null;
                val_4 = UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.s_TouchInput;
            }
            
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput = val_4;
        }
        public static bool AxisExists(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput != null)
            {
                    return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.AxisExists(name:  X1);
            }
            
            return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.AxisExists(name:  X1);
        }
        public static bool ButtonExists(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput != null)
            {
                    return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.ButtonExists(name:  X1);
            }
            
            return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.ButtonExists(name:  X1);
        }
        public static void RegisterVirtualAxis(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis axis)
        {
            null = null;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.RegisterVirtualAxis(axis:  X1);
        }
        public static void RegisterVirtualButton(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualButton button)
        {
            null = null;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.RegisterVirtualButton(button:  X1);
        }
        public static void UnRegisterVirtualAxis(string name)
        {
            var val_2;
            if(X1 != 0)
            {
                    val_2 = null;
                val_2 = null;
                UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.UnRegisterVirtualAxis(name:  X1);
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "name");
        }
        public static void UnRegisterVirtualButton(string name)
        {
            null = null;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.UnRegisterVirtualButton(name:  X1);
        }
        public static UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput != null)
            {
                    return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.VirtualAxisReference(name:  X1);
            }
            
            return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.VirtualAxisReference(name:  X1);
        }
        public static float GetAxis(string name)
        {
            return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis(name:  null, raw:  X1);
        }
        public static float GetAxisRaw(string name)
        {
            return UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis(name:  null, raw:  X1);
        }
        private static float GetAxis(string name, bool raw)
        {
            null = null;
            var val_1 = W2 & 1;
            goto typeof(UnityStandardAssets.CrossPlatformInput.VirtualInput).__il2cppRuntimeField_150;
        }
        public static bool GetButton(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static bool GetButtonDown(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static bool GetButtonUp(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetButtonDown(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetButtonUp(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetAxisPositive(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetAxisNegative(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetAxisZero(string name)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetAxis(string name, float value)
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static UnityEngine.Vector3 get_mousePosition()
        {
            null = null;
            if(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput == null)
            {
                
            }
        
        }
        public static void SetVirtualMousePositionX(float f)
        {
            null = null;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.<virtualMousePosition>k__BackingField = 0;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.__unknownFiledOffset_14 = 0;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.__unknownFiledOffset_18 = 0;
        }
        public static void SetVirtualMousePositionY(float f)
        {
            null = null;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.<virtualMousePosition>k__BackingField = 0;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.__unknownFiledOffset_14 = 0;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.__unknownFiledOffset_18 = 0;
        }
        public static void SetVirtualMousePositionZ(float f)
        {
            null = null;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.<virtualMousePosition>k__BackingField = 0;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.__unknownFiledOffset_14 = 0;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.activeInput.__unknownFiledOffset_18 = 0;
        }
    
    }

}
