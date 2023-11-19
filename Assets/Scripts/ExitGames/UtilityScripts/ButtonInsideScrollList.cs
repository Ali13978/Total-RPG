using UnityEngine;

namespace ExitGames.UtilityScripts
{
    public class ButtonInsideScrollList : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        public ButtonInsideScrollList()
        {
        
        }
        private void Start()
        {
            this.scrollRect = this.GetComponentInParent<UnityEngine.UI.ScrollRect>();
        }
        private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(0 == this.scrollRect)
            {
                    return;
            }
            
            this.scrollRect.enabled = false;
        }
        private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(0 == this.scrollRect)
            {
                    return;
            }
            
            if(this.scrollRect.enabled != false)
            {
                    return;
            }
            
            this.scrollRect.enabled = true;
        }
    
    }

}
