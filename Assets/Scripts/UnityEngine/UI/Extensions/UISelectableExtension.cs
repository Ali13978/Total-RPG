using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.RequireComponent]
    public class UISelectableExtension : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Extensions.UISelectableExtension.UIButtonEvent OnButtonPress;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Extensions.UISelectableExtension.UIButtonEvent OnButtonRelease;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Extensions.UISelectableExtension.UIButtonEvent OnButtonHeld;
        private bool _pressed;
        private UnityEngine.EventSystems.PointerEventData _heldEventData;
        
        // Methods
        public UISelectableExtension()
        {
        
        }
        private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.OnButtonPress != null)
            {
                    this.OnButtonPress.Invoke(arg0:  eventData.button);
            }
            
            this._heldEventData = eventData;
            this._pressed = true;
        }
        private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.OnButtonRelease != null)
            {
                    this.OnButtonRelease.Invoke(arg0:  eventData.button);
            }
            
            this._heldEventData = 0;
            this._pressed = false;
        }
        private void Update()
        {
            UIButtonEvent val_2;
            if(this._pressed == false)
            {
                    return;
            }
            
            val_2 = this.OnButtonHeld;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2.Invoke(arg0:  this._heldEventData.button);
        }
        public void TestClicked()
        {
        
        }
        public void TestPressed()
        {
        
        }
        public void TestReleased()
        {
        
        }
        public void TestHold()
        {
        
        }
        private void OnDisable()
        {
            this._pressed = false;
        }
    
    }

}
