using UnityEngine;

namespace UnityEngine.UI
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.DisallowMultipleComponent]
    public class ExtensionsToggleGroup : UIBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool m_AllowSwitchOff;
        private System.Collections.Generic.List<UnityEngine.UI.ExtensionsToggle> m_Toggles;
        public UnityEngine.UI.ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupChanged;
        public UnityEngine.UI.ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupToggleChanged;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.UI.ExtensionsToggle <SelectedToggle>k__BackingField;
        private static System.Predicate<UnityEngine.UI.ExtensionsToggle> <>f__am$cache0;
        private static System.Func<UnityEngine.UI.ExtensionsToggle, bool> <>f__am$cache1;
        
        // Properties
        public bool AllowSwitchOff { get; set; }
        public UnityEngine.UI.ExtensionsToggle SelectedToggle { get; set; }
        
        // Methods
        protected ExtensionsToggleGroup()
        {
            this.m_Toggles = new System.Collections.Generic.List<UnityEngine.UI.ExtensionsToggle>();
            this.onToggleGroupChanged = new ExtensionsToggleGroup.ToggleGroupEvent();
            this.onToggleGroupToggleChanged = new ExtensionsToggleGroup.ToggleGroupEvent();
        }
        public bool get_AllowSwitchOff()
        {
            return (bool)this.m_AllowSwitchOff;
        }
        public void set_AllowSwitchOff(bool value)
        {
            this.m_AllowSwitchOff = value;
        }
        public UnityEngine.UI.ExtensionsToggle get_SelectedToggle()
        {
            return (UnityEngine.UI.ExtensionsToggle)this.<SelectedToggle>k__BackingField;
        }
        private void set_SelectedToggle(UnityEngine.UI.ExtensionsToggle value)
        {
            this.<SelectedToggle>k__BackingField = value;
        }
        private void ValidateToggleIsInGroup(UnityEngine.UI.ExtensionsToggle toggle)
        {
            if(0 != toggle)
            {
                    if((this.m_Toggles.Contains(item:  toggle)) != false)
            {
                    return;
            }
            
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = toggle;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this;
            System.ArgumentException val_6 = new System.ArgumentException(message:  System.String.Format(format:  0, args:  "Toggle {0} is not part of ToggleGroup {1}"));
        }
        public void NotifyToggleOn(UnityEngine.UI.ExtensionsToggle toggle)
        {
            var val_7;
            this.ValidateToggleIsInGroup(toggle:  toggle);
            val_7 = 0;
            goto label_1;
            label_11:
            val_7 = 1;
            label_1:
            if(val_7 >= this.m_Toggles.Count)
            {
                goto label_3;
            }
            
            if(0 != this.m_Toggles.Item[1])
            {
                goto label_7;
            }
            
            this.<SelectedToggle>k__BackingField = toggle;
            goto label_11;
            label_7:
            this.m_Toggles.Item[1].Set(value:  false, sendCallback:  true);
            goto label_11;
            label_3:
            this.onToggleGroupChanged.Invoke(arg0:  this.AnyTogglesOn());
        }
        public void UnregisterToggle(UnityEngine.UI.ExtensionsToggle toggle)
        {
            if((this.m_Toggles.Contains(item:  toggle)) == false)
            {
                    return;
            }
            
            bool val_2 = this.m_Toggles.Remove(item:  toggle);
            toggle.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void UnityEngine.UI.ExtensionsToggleGroup::NotifyToggleChanged(bool isOn)));
        }
        private void NotifyToggleChanged(bool isOn)
        {
            isOn = isOn;
            this.onToggleGroupToggleChanged.Invoke(arg0:  isOn);
        }
        public void RegisterToggle(UnityEngine.UI.ExtensionsToggle toggle)
        {
            if((this.m_Toggles.Contains(item:  toggle)) != false)
            {
                    return;
            }
            
            this.m_Toggles.Add(item:  toggle);
            toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void UnityEngine.UI.ExtensionsToggleGroup::NotifyToggleChanged(bool isOn)));
        }
        public bool AnyTogglesOn()
        {
            if((UnityEngine.UI.ExtensionsToggleGroup.<>f__am$cache0) != null)
            {
                    return UnityEngine.Object.op_Inequality(x:  0, y:  this.m_Toggles.Find(match:  UnityEngine.UI.ExtensionsToggleGroup.<>f__am$cache0 = new System.Predicate<UnityEngine.UI.ExtensionsToggle>(object:  0, method:  static System.Boolean UnityEngine.UI.ExtensionsToggleGroup::<AnyTogglesOn>m__0(UnityEngine.UI.ExtensionsToggle x))));
            }
            
            null = null;
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.m_Toggles.Find(match:  UnityEngine.UI.ExtensionsToggleGroup.<>f__am$cache0));
        }
        public System.Collections.Generic.IEnumerable<UnityEngine.UI.ExtensionsToggle> ActiveToggles()
        {
            if((UnityEngine.UI.ExtensionsToggleGroup.<>f__am$cache1) != null)
            {
                    return System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  this.m_Toggles);
            }
            
            UnityEngine.UI.ExtensionsToggleGroup.<>f__am$cache1 = new System.Func<UnityEngine.UI.ExtensionsToggle, System.Boolean>(object:  0, method:  static System.Boolean UnityEngine.UI.ExtensionsToggleGroup::<ActiveToggles>m__1(UnityEngine.UI.ExtensionsToggle x));
            return System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  this.m_Toggles);
        }
        public void SetAllTogglesOff()
        {
            var val_3;
            this.m_AllowSwitchOff = true;
            val_3 = 0;
            goto label_1;
            label_6:
            X21.Set(value:  false, sendCallback:  true);
            val_3 = 1;
            label_1:
            if(val_3 >= this.m_Toggles.Count)
            {
                goto label_3;
            }
            
            if(this.m_Toggles.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            this.m_AllowSwitchOff = this.m_AllowSwitchOff;
        }
        public void HasTheGroupToggle(bool value)
        {
            string val_2 = 0 + "Testing, the group has toggled [" + value;
            UnityEngine.Debug.Log(message:  0);
        }
        public void HasAToggleFlipped(bool value)
        {
            string val_2 = 0 + "Testing, a toggle has toggled [" + value;
            UnityEngine.Debug.Log(message:  0);
        }
        private static bool <AnyTogglesOn>m__0(UnityEngine.UI.ExtensionsToggle x)
        {
            if(X1 != 0)
            {
                    return (bool)X1 + 264;
            }
            
            return (bool)X1 + 264;
        }
        private static bool <ActiveToggles>m__1(UnityEngine.UI.ExtensionsToggle x)
        {
            if(X1 != 0)
            {
                    return (bool)X1 + 264;
            }
            
            return (bool)X1 + 264;
        }
    
    }

}
