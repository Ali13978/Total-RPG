using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
    public class MobileInput : VirtualInput
    {
        // Methods
        public MobileInput()
        {
        
        }
        private void AddButton(string name)
        {
            typeof(CrossPlatformInputManager.VirtualButton).__il2cppRuntimeField_1C = -17179869189;
            null = new System.Object();
            typeof(CrossPlatformInputManager.VirtualButton).__il2cppRuntimeField_18 = 1;
            typeof(CrossPlatformInputManager.VirtualButton).__il2cppRuntimeField_10 = name;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualButton(button:  null);
        }
        private void AddAxes(string name)
        {
            object val_1 = new System.Object();
            typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_1C = 1;
            typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_10 = name;
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  null);
        }
        public override float GetAxis(string name, bool raw)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddAxes(name:  name);
            }
            
            if(this.Item[name] != null)
            {
                    return (float)val_3.m_Value;
            }
            
            return (float)val_3.m_Value;
        }
        public override void SetButtonDown(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddButton(name:  name);
            }
            
            VirtualButton val_3 = this.Item[name];
            if(val_3.m_Pressed == true)
            {
                    return;
            }
            
            val_3.m_Pressed = true;
            val_3.m_LastPressedFrame = UnityEngine.Time.frameCount;
        }
        public override void SetButtonUp(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddButton(name:  name);
            }
            
            VirtualButton val_3 = this.Item[name];
            val_3.m_Pressed = false;
            val_3.m_ReleasedFrame = UnityEngine.Time.frameCount;
        }
        public override void SetAxisPositive(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddAxes(name:  name);
            }
            
            VirtualAxis val_3 = this.Item[name];
            val_3.m_Value = 1f;
        }
        public override void SetAxisNegative(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddAxes(name:  name);
            }
            
            VirtualAxis val_3 = this.Item[name];
            val_3.m_Value = -1f;
        }
        public override void SetAxisZero(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddAxes(name:  name);
            }
            
            VirtualAxis val_3 = this.Item[name];
            val_3.m_Value = 0f;
        }
        public override void SetAxis(string name, float value)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddAxes(name:  name);
            }
            
            VirtualAxis val_3 = this.Item[name];
            val_3.m_Value = value;
        }
        public override bool GetButtonDown(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddButton(name:  name);
            }
            
            VirtualButton val_2 = this.Item[name];
            return (bool)((val_2.m_LastPressedFrame - UnityEngine.Time.frameCount) == 1) ? 1 : 0;
        }
        public override bool GetButtonUp(string name)
        {
            bool val_1 = ContainsKey(key:  name);
            if(val_1 != true)
            {
                    val_1.AddButton(name:  name);
            }
            
            VirtualButton val_2 = this.Item[name];
            return (bool)(val_2.m_ReleasedFrame == (UnityEngine.Time.frameCount - 1)) ? 1 : 0;
        }
        public override bool GetButton(string name)
        {
            var val_4 = this;
            if((ContainsKey(key:  name)) != false)
            {
                    VirtualButton val_2 = this.Item[name];
                if(val_2 != null)
            {
                    return (bool)val_3.m_Pressed;
            }
            
            }
            
            val_2.AddButton(name:  name);
            if(this.Item[name] != null)
            {
                    return (bool)val_3.m_Pressed;
            }
        
        }
        public override UnityEngine.Vector3 MousePosition()
        {
            return new UnityEngine.Vector3();
        }
    
    }

}
