using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class ResizePanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.Vector2 minSize;
        public UnityEngine.Vector2 maxSize;
        private UnityEngine.RectTransform rectTransform;
        private UnityEngine.Vector2 currentPointerPosition;
        private UnityEngine.Vector2 previousPointerPosition;
        private float ratio;
        
        // Methods
        public ResizePanel()
        {
        
        }
        private void Awake()
        {
            UnityEngine.RectTransform val_3 = this.transform.parent.GetComponent<UnityEngine.RectTransform>();
            this.rectTransform = val_3;
            UnityEngine.Rect val_4 = val_3.rect;
            UnityEngine.Rect val_5 = this.rectTransform.rect;
            float val_12 = 0.1f;
            val_5.m_XMin = val_5.m_XMin / val_4.m_XMin;
            this.ratio = val_5.m_XMin;
            val_12 = val_5.m_XMin * val_12;
            CinemachineFreeLook.Orbit val_7 = new CinemachineFreeLook.Orbit(h:  val_4.m_XMin * val_12, r:  val_12);
            float val_13 = 10f;
            val_13 = val_5.m_XMin * val_13;
            CinemachineFreeLook.Orbit val_10;
            this.minSize = val_7.m_Height;
            mem[1152921512702414284] = val_7.m_Height >> 32;
            val_10 = new CinemachineFreeLook.Orbit(h:  val_4.m_XMin * val_13, r:  val_13);
            this.maxSize = val_10.m_Height;
            mem[1152921512702414292] = val_10.m_Height >> 32;
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
            float val_17;
            float val_18;
            float val_20;
            val_14 = this.rectTransform;
            if(0 == val_14)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = this.rectTransform.sizeDelta;
            val_14 = this.rectTransform;
            if(data != null)
            {
                    UnityEngine.Vector2 val_4 = data.position;
                val_17 = val_4.x;
                val_18 = val_4.y;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = 0.position;
                val_17 = val_5.x;
                val_18 = val_5.y;
            }
            
            bool val_7 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_17, y = val_18}, cam:  val_14, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.currentPointerPosition, y = V12.16B}, b:  new UnityEngine.Vector2() {x = this.previousPointerPosition, y = val_17});
            float val_14 = this.ratio;
            CinemachineFreeLook.Orbit val_9;
            val_14 = val_8.x * val_14;
            val_9 = new CinemachineFreeLook.Orbit(h:  val_8.x, r:  val_14);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius});
            val_20 = val_10.y;
            val_20 = val_20;
            CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  UnityEngine.Mathf.Clamp(value:  val_10.x, min:  this.minSize, max:  this.maxSize), r:  UnityEngine.Mathf.Clamp(value:  val_20, min:  this.minSize, max:  this.maxSize));
            this.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius};
            this.previousPointerPosition = this.currentPointerPosition;
            mem[1152921512702712044] = UnityEngine.RectTransformUtility.__il2cppRuntimeField_cctor_finished;
        }
    
    }

}
