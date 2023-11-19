using UnityEngine;

namespace UnityEngine.UI
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ReturnKeyTriggersButton : MonoBehaviour, ISubmitHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.EventSystems.EventSystem _system;
        public UnityEngine.UI.Button button;
        private bool highlight;
        public float highlightDuration;
        
        // Methods
        public ReturnKeyTriggersButton()
        {
            this.highlight = true;
            this.highlightDuration = 0.2f;
        }
        private void Start()
        {
            this._system = UnityEngine.EventSystems.EventSystem.current;
        }
        private void RemoveHighlight()
        {
            UnityEngine.EventSystems.PointerEventData val_1 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  this._system);
            if(this.button == null)
            {
                
            }
        
        }
        public void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData)
        {
            UnityEngine.UI.Button val_4;
            if(this.highlight != false)
            {
                    val_4 = this.button;
                UnityEngine.EventSystems.PointerEventData val_1 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  this._system);
            }
            
            UnityEngine.EventSystems.PointerEventData val_2 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  this._system);
            bool val_4 = this.highlight;
            if((val_4 & 255) == false)
            {
                    return;
            }
            
            val_4 = val_4 >> 32;
            this.Invoke(methodName:  "RemoveHighlight", time:  val_4);
        }
    
    }

}
