using UnityEngine;

namespace UnityEngine.UI
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    public class ExtensionsToggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement, IEventSystemHandler
    {
        // Fields
        public string UniqueID;
        public UnityEngine.UI.ExtensionsToggle.ToggleTransition toggleTransition;
        public UnityEngine.UI.Graphic graphic;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.ExtensionsToggleGroup m_Group;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.ExtensionsToggle.ToggleEvent onValueChanged;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.ExtensionsToggle.ToggleEventObject onToggleChanged;
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        [UnityEngine.TooltipAttribute]
        [UnityEngine.SerializeField]
        private bool m_IsOn;
        
        // Properties
        public UnityEngine.UI.ExtensionsToggleGroup Group { get; set; }
        public bool IsOn { get; set; }
        
        // Methods
        protected ExtensionsToggle()
        {
            this.toggleTransition = 1;
            this.onValueChanged = new ExtensionsToggle.ToggleEvent();
            this.onToggleChanged = new ExtensionsToggle.ToggleEventObject();
        }
        public UnityEngine.UI.ExtensionsToggleGroup get_Group()
        {
            return (UnityEngine.UI.ExtensionsToggleGroup)this.m_Group;
        }
        public void set_Group(UnityEngine.UI.ExtensionsToggleGroup value)
        {
            this.m_Group = value;
            this.SetToggleGroup(newGroup:  value, setMemberValue:  true);
            this.PlayEffect(instant:  true);
        }
        public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
        {
        
        }
        public virtual void LayoutComplete()
        {
        
        }
        public virtual void GraphicUpdateComplete()
        {
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.SetToggleGroup(newGroup:  this.m_Group, setMemberValue:  false);
            this.PlayEffect(instant:  true);
        }
        protected override void OnDisable()
        {
            this.SetToggleGroup(newGroup:  0, setMemberValue:  false);
            this.OnDisable();
        }
        protected override void OnDidApplyAnimationProperties()
        {
            if(0 != this.graphic)
            {
                    UnityEngine.Color val_3 = this.graphic.canvasRenderer.GetColor();
                bool val_4 = UnityEngine.Mathf.Approximately(a:  val_3.a, b:  0f);
                var val_5 = (this.m_IsOn == true) ? 1 : 0;
                val_5 = val_4 ^ val_5;
                if(val_5 != true)
            {
                    bool val_8 = ~val_4;
                val_8 = val_8 & 1;
                this.m_IsOn = val_8;
                this.Set(value:  val_4, sendCallback:  true);
            }
            
            }
            
            this.OnDidApplyAnimationProperties();
        }
        private void SetToggleGroup(UnityEngine.UI.ExtensionsToggleGroup newGroup, bool setMemberValue)
        {
            UnityEngine.UI.ExtensionsToggleGroup val_8;
            if(0 != this.m_Group)
            {
                    this.m_Group.UnregisterToggle(toggle:  this);
            }
            
            if(setMemberValue != false)
            {
                    val_8 = newGroup;
                this.m_Group = newGroup;
            }
            else
            {
                    val_8 = this.m_Group;
            }
            
            if(0 != val_8)
            {
                    if(this.IsActive() != false)
            {
                    this.m_Group.RegisterToggle(toggle:  this);
            }
            
            }
            
            if(0 == newGroup)
            {
                    return;
            }
            
            if(0 == newGroup)
            {
                    return;
            }
            
            if(this.m_IsOn == false)
            {
                    return;
            }
            
            if(this.m_Group.IsActive() == false)
            {
                    return;
            }
            
            this.m_Group.NotifyToggleOn(toggle:  this);
        }
        public bool get_IsOn()
        {
            return (bool)this.m_IsOn;
        }
        public void set_IsOn(bool value)
        {
            this.Set(value:  value, sendCallback:  true);
        }
        private void Set(bool value)
        {
            this.Set(value:  value, sendCallback:  true);
        }
        private void Set(bool value, bool sendCallback)
        {
            bool val_9 = value;
            var val_1 = (this.m_IsOn == true) ? 1 : 0;
            val_1 = val_1 ^ val_9;
            if(val_1 == false)
            {
                    return;
            }
            
            this.m_IsOn = val_9;
            val_9 = this.m_Group;
            if((0 == val_9) || (this.IsActive() == false))
            {
                goto label_10;
            }
            
            if(this.m_IsOn == true)
            {
                goto label_6;
            }
            
            val_9 = this.m_Group;
            if(val_9.AnyTogglesOn() == true)
            {
                goto label_10;
            }
            
            val_9 = this.m_Group;
            if(this.m_Group.m_AllowSwitchOff == true)
            {
                goto label_10;
            }
            
            label_6:
            val_9 = this.m_Group;
            this.m_IsOn = true;
            val_9.NotifyToggleOn(toggle:  this);
            label_10:
            this.PlayEffect(instant:  (this.toggleTransition == 0) ? 1 : 0);
            if(sendCallback == false)
            {
                    return;
            }
            
            this.onValueChanged.Invoke(arg0:  (this.m_IsOn == true) ? 1 : 0);
            this.onToggleChanged.Invoke(arg0:  this);
        }
        private void PlayEffect(bool instant)
        {
            if(0 == this.graphic)
            {
                    return;
            }
            
            var val_3 = (this.m_IsOn == true) ? 1f : 0f;
            var val_4 = (instant != true) ? 0f : 0.1f;
            if(this.graphic == null)
            {
                
            }
        
        }
        protected override void Start()
        {
            this.PlayEffect(instant:  true);
        }
        private void InternalToggle()
        {
            if(this.IsActive() == false)
            {
                    return;
            }
            
            if(this.IsInteractable() == false)
            {
                    return;
            }
            
            this.Set(value:  (this.m_IsOn == false) ? 1 : 0, sendCallback:  true);
        }
        public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(eventData.button != 0)
            {
                    return;
            }
            
            this.InternalToggle();
        }
        public virtual void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
        {
            this.InternalToggle();
        }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
        {
            return this.transform;
        }
        private bool UnityEngine.UI.ICanvasElement.IsDestroyed()
        {
            return this.IsDestroyed();
        }
    
    }

}
