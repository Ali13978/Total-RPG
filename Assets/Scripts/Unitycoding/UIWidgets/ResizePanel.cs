using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class ResizePanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.Vector2 minSize;
        public UnityEngine.Vector2 maxSize;
        private UnityEngine.RectTransform panelRectTransform;
        private UnityEngine.Vector2 originalLocalPointerPosition;
        private UnityEngine.Vector2 originalSizeDelta;
        
        // Methods
        public ResizePanel()
        {
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  100f, r:  100f);
            CinemachineFreeLook.Orbit val_3;
            this.minSize = val_1.m_Height;
            mem[1152921512634888476] = val_1.m_Height >> 32;
            val_3 = new CinemachineFreeLook.Orbit(h:  400f, r:  400f);
            this.maxSize = val_3.m_Height;
            mem[1152921512634888484] = val_3.m_Height >> 32;
        }
        private void Awake()
        {
            this.panelRectTransform = this.transform.parent.GetComponent<UnityEngine.RectTransform>();
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            float val_8;
            float val_9;
            UnityEngine.Vector2 val_1 = this.panelRectTransform.sizeDelta;
            this.originalSizeDelta = val_1;
            mem[1152921512635153468] = val_1.y;
            if(data != null)
            {
                    UnityEngine.Vector2 val_2 = data.position;
                val_8 = val_2.x;
                val_9 = val_2.y;
            }
            else
            {
                    UnityEngine.Vector2 val_3 = 0.position;
                val_8 = val_3.x;
                val_9 = val_3.y;
            }
            
            bool val_5 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_8, y = val_9}, cam:  this.panelRectTransform, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera});
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData data)
        {
            UnityEngine.RectTransform val_14;
            UnityEngine.RectTransform val_15;
            float val_18;
            float val_19;
            float val_20;
            val_14 = this;
            val_15 = this.panelRectTransform;
            if(0 == val_15)
            {
                    return;
            }
            
            val_15 = this.panelRectTransform;
            if(data != null)
            {
                    UnityEngine.Vector2 val_3 = data.position;
                val_18 = val_3.x;
                val_19 = val_3.y;
            }
            else
            {
                    UnityEngine.Vector2 val_4 = 0.position;
                val_18 = val_4.x;
                val_19 = val_4.y;
            }
            
            bool val_6 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_18, y = val_19}, cam:  val_15, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = this.originalLocalPointerPosition, y = val_19});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  val_8.x, r:  -val_8.y);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.originalSizeDelta, y = val_19}, b:  new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius});
            val_20 = val_10.y;
            val_20 = val_20;
            CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  UnityEngine.Mathf.Clamp(value:  val_10.x, min:  this.minSize, max:  this.maxSize), r:  UnityEngine.Mathf.Clamp(value:  val_20, min:  this.minSize, max:  this.maxSize));
            val_14 = this.panelRectTransform;
            val_14.sizeDelta = new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius};
        }
    
    }

}
