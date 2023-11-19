using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class BoundTooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.TextAreaAttribute]
        public string text;
        public bool useMousePosition;
        public UnityEngine.Vector3 offset;
        
        // Methods
        public BoundTooltipTrigger()
        {
        
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_7;
            if(this.useMousePosition == false)
            {
                goto label_1;
            }
            
            if(eventData == null)
            {
                goto label_2;
            }
            
            UnityEngine.Vector2 val_1 = eventData.position;
            val_7 = val_1.x;
            goto label_3;
            label_1:
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
            this.StartHover(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return;
            label_2:
            UnityEngine.Vector2 val_5 = 0.position;
            val_7 = val_5.x;
            label_3:
            UnityEngine.Vector2 val_6 = eventData.position;
            this.StartHover(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        public void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.StartHover(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.StopHover();
        }
        public void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData)
        {
            this.StopHover();
        }
        private void StartHover(UnityEngine.Vector3 position)
        {
            UnityEngine.UI.Extensions.BoundTooltipItem.Instance.ShowTooltip(text:  this.text, pos:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        private void StopHover()
        {
            UnityEngine.UI.Extensions.BoundTooltipItem.Instance.HideTooltip();
        }
    
    }

}
