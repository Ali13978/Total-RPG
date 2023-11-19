using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class RescalePanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.Vector2 minSize;
        public UnityEngine.Vector2 maxSize;
        private UnityEngine.RectTransform rectTransform;
        private UnityEngine.Transform goTransform;
        private UnityEngine.Vector2 currentPointerPosition;
        private UnityEngine.Vector2 previousPointerPosition;
        private UnityEngine.RectTransform thisRectTransform;
        private UnityEngine.Vector2 sizeDelta;
        
        // Methods
        public RescalePanel()
        {
        
        }
        private void Awake()
        {
            this.rectTransform = this.transform.parent.GetComponent<UnityEngine.RectTransform>();
            this.goTransform = this.transform.parent;
            UnityEngine.RectTransform val_6 = this.GetComponent<UnityEngine.RectTransform>();
            this.thisRectTransform = val_6;
            UnityEngine.Vector2 val_7 = val_6.sizeDelta;
            this.sizeDelta = val_7;
            mem[1152921512701827076] = val_7.y;
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            float val_7;
            float val_8;
            this.rectTransform.SetAsLastSibling();
            if(data != null)
            {
                    UnityEngine.Vector2 val_1 = data.position;
                val_7 = val_1.x;
                val_8 = val_1.y;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = 0.position;
                val_7 = val_2.x;
                val_8 = val_2.y;
            }
            
            bool val_4 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_7, y = val_8}, cam:  this.rectTransform, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera});
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData data)
        {
            UnityEngine.RectTransform val_14;
            UnityEngine.RectTransform val_15;
            float val_18;
            float val_19;
            float val_21;
            val_14 = this;
            val_15 = this.rectTransform;
            if(0 == val_15)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.goTransform.localScale;
            val_15 = this.rectTransform;
            if(data != null)
            {
                    UnityEngine.Vector2 val_4 = data.position;
                val_18 = val_4.x;
                val_19 = val_4.y;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = 0.position;
                val_18 = val_5.x;
                val_19 = val_5.y;
            }
            
            bool val_7 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_18, y = val_19}, cam:  val_15, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.currentPointerPosition, y = V13.16B}, b:  new UnityEngine.Vector2() {x = this.previousPointerPosition, y = val_18});
            float val_14 = -0.001f;
            val_14 = val_8.y * val_14;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_21 = val_9.y;
            val_21 = val_21;
            float val_10 = UnityEngine.Mathf.Clamp(value:  val_9.x, min:  this.minSize, max:  this.maxSize);
            float val_11 = UnityEngine.Mathf.Clamp(value:  val_21, min:  this.minSize, max:  this.maxSize);
            this.goTransform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_21, z = val_9.z};
            this.previousPointerPosition = this.currentPointerPosition;
            mem[1152921512702141172] = UnityEngine.RectTransformUtility.__il2cppRuntimeField_cctor_finished;
            UnityEngine.Vector3 val_12 = this.goTransform.localScale;
            val_12.x = this.sizeDelta / val_12.x;
            CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  val_12.x, r:  val_12.x);
            val_14 = this.thisRectTransform;
            val_14.sizeDelta = new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius};
        }
    
    }

}
