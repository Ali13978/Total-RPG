using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class RadialMenuItem : Selectable, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.Events.UnityEvent m_Trigger;
        
        // Properties
        public UnityEngine.Events.UnityEvent onTrigger { get; set; }
        
        // Methods
        public RadialMenuItem()
        {
            this.m_Trigger = new UnityEngine.Events.UnityEvent();
        }
        public UnityEngine.Events.UnityEvent get_onTrigger()
        {
            UnityEngine.Events.UnityEvent val_2 = this.m_Trigger;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEngine.Events.UnityEvent val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.Events.UnityEvent();
            this.m_Trigger = val_2;
            return val_2;
        }
        public void set_onTrigger(UnityEngine.Events.UnityEvent value)
        {
            this.m_Trigger = value;
        }
        private void Press()
        {
            if(this.IsActive() == false)
            {
                    return;
            }
            
            if(this.IsInteractable() == false)
            {
                    return;
            }
            
            this.onTrigger.Invoke();
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.Press();
        }
        public override void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerEnter(eventData:  eventData);
            this.DoStateTransition(state:  1, instant:  false);
        }
    
    }

}
