using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public abstract class VirtualInput
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <virtualMousePosition>k__BackingField;
        protected System.Collections.Generic.Dictionary<string, UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;
        protected System.Collections.Generic.Dictionary<string, UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualButton> m_VirtualButtons;
        protected System.Collections.Generic.List<string> m_AlwaysUseVirtual;
        
        // Properties
        public UnityEngine.Vector3 virtualMousePosition { get; set; }
        
        // Methods
        protected VirtualInput()
        {
            this.m_VirtualAxes = new System.Collections.Generic.Dictionary<System.String, VirtualAxis>();
            this.m_VirtualButtons = new System.Collections.Generic.Dictionary<System.String, VirtualButton>();
            this.m_AlwaysUseVirtual = new System.Collections.Generic.List<System.String>();
        }
        public UnityEngine.Vector3 get_virtualMousePosition()
        {
            return new UnityEngine.Vector3() {x = this.<virtualMousePosition>k__BackingField};
        }
        private void set_virtualMousePosition(UnityEngine.Vector3 value)
        {
            this.<virtualMousePosition>k__BackingField = value;
            mem[1152921510543057300] = value.y;
            mem[1152921510543057304] = value.z;
        }
        public bool AxisExists(string name)
        {
            if(this.m_VirtualAxes != null)
            {
                    return this.m_VirtualAxes.ContainsKey(key:  name);
            }
            
            return this.m_VirtualAxes.ContainsKey(key:  name);
        }
        public bool ButtonExists(string name)
        {
            if(this.m_VirtualButtons != null)
            {
                    return this.m_VirtualButtons.ContainsKey(key:  name);
            }
            
            return this.m_VirtualButtons.ContainsKey(key:  name);
        }
        public void RegisterVirtualAxis(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis axis)
        {
            if((this.m_VirtualAxes.ContainsKey(key:  axis.<name>k__BackingField)) != false)
            {
                    string val_2 = 0 + "There is already a virtual axis named " + axis.<name>k__BackingField(axis.<name>k__BackingField);
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.m_VirtualAxes.Add(key:  axis.<name>k__BackingField, value:  axis);
            if((axis.<matchWithInputManager>k__BackingField) != false)
            {
                    return;
            }
            
            this.m_AlwaysUseVirtual.Add(item:  axis.<name>k__BackingField);
        }
        public void RegisterVirtualButton(UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualButton button)
        {
            if((this.m_VirtualButtons.ContainsKey(key:  button.<name>k__BackingField)) != false)
            {
                    string val_2 = 0 + "There is already a virtual button named " + button.<name>k__BackingField(button.<name>k__BackingField);
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.m_VirtualButtons.Add(key:  button.<name>k__BackingField, value:  button);
            if((button.<matchWithInputManager>k__BackingField) != false)
            {
                    return;
            }
            
            this.m_AlwaysUseVirtual.Add(item:  button.<name>k__BackingField);
        }
        public void UnRegisterVirtualAxis(string name)
        {
            if((this.m_VirtualAxes.ContainsKey(key:  name)) == false)
            {
                    return;
            }
            
            bool val_2 = this.m_VirtualAxes.Remove(key:  name);
        }
        public void UnRegisterVirtualButton(string name)
        {
            if((this.m_VirtualButtons.ContainsKey(key:  name)) == false)
            {
                    return;
            }
            
            bool val_2 = this.m_VirtualButtons.Remove(key:  name);
        }
        public UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
        {
            var val_3;
            if((this.m_VirtualAxes.ContainsKey(key:  name)) != false)
            {
                    VirtualAxis val_2 = this.m_VirtualAxes.Item[name];
                return (VirtualAxis)val_3;
            }
            
            val_3 = 0;
            return (VirtualAxis)val_3;
        }
        public void SetVirtualMousePositionX(float f)
        {
            this.<virtualMousePosition>k__BackingField = 0;
            mem[1152921510544219940] = 0;
            mem[1152921510544219944] = 0;
        }
        public void SetVirtualMousePositionY(float f)
        {
            this.<virtualMousePosition>k__BackingField = 0;
            mem[1152921510544331940] = 0;
            mem[1152921510544331944] = 0;
        }
        public void SetVirtualMousePositionZ(float f)
        {
            this.<virtualMousePosition>k__BackingField = 0;
            mem[1152921510544443940] = 0;
            mem[1152921510544443944] = 0;
        }
        public abstract float GetAxis(string name, bool raw); // 0
        public abstract bool GetButton(string name); // 0
        public abstract bool GetButtonDown(string name); // 0
        public abstract bool GetButtonUp(string name); // 0
        public abstract void SetButtonDown(string name); // 0
        public abstract void SetButtonUp(string name); // 0
        public abstract void SetAxisPositive(string name); // 0
        public abstract void SetAxisNegative(string name); // 0
        public abstract void SetAxisZero(string name); // 0
        public abstract void SetAxis(string name, float value); // 0
        public abstract UnityEngine.Vector3 MousePosition(); // 0
    
    }

}
