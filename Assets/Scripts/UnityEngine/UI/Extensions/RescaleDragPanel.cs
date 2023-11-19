using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class RescaleDragPanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.Vector2 pointerOffset;
        private UnityEngine.RectTransform canvasRectTransform;
        private UnityEngine.RectTransform panelRectTransform;
        private UnityEngine.Transform goTransform;
        
        // Methods
        public RescaleDragPanel()
        {
        
        }
        private void Awake()
        {
            var val_10;
            var val_11;
            UnityEngine.Canvas val_1 = this.GetComponentInParent<UnityEngine.Canvas>();
            if(0 == val_1)
            {
                    return;
            }
            
            val_10 = 0;
            this.canvasRectTransform = (null == null) ? val_1.transform : 0;
            val_11 = 0;
            this.panelRectTransform = (null == null) ? this.transform.parent : 0;
            this.goTransform = this.transform.parent;
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            float val_7;
            float val_8;
            this.panelRectTransform.SetAsLastSibling();
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
            
            bool val_4 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_7, y = val_8}, cam:  this.panelRectTransform, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera});
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData data)
        {
            UnityEngine.Transform val_12;
            UnityEngine.RectTransform val_13;
            float val_14;
            val_12 = this;
            val_13 = this.panelRectTransform;
            if(0 == val_13)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = this.ClampToWindow(data:  data);
            val_13 = this.canvasRectTransform;
            val_14 = val_3.x;
            if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_14, y = val_3.y}, cam:  val_13, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera})) == false)
            {
                    return;
            }
            
            val_13 = this.goTransform;
            UnityEngine.Vector3 val_6 = val_13.localScale;
            val_12 = this.goTransform;
            UnityEngine.Vector3 val_7 = val_12.localScale;
            val_7.y = S12 * val_7.y;
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  this.pointerOffset * val_6.x, r:  val_7.y);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            val_14 = val_11.x;
            this.panelRectTransform.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_11.z};
        }
        private UnityEngine.Vector2 ClampToWindow(UnityEngine.EventSystems.PointerEventData data)
        {
            UnityEngine.Vector2 val_1 = data.position;
            this.canvasRectTransform.GetWorldCorners(fourCornersArray:  null);
            CinemachineFreeLook.Orbit val_4 = new CinemachineFreeLook.Orbit(h:  UnityEngine.Mathf.Clamp(value:  val_1.x, min:  UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, max:  UnityEngine.Vector3[].__il2cppRuntimeField_castClass), r:  UnityEngine.Mathf.Clamp(value:  val_1.y, min:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, max:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_3C));
            return new UnityEngine.Vector2() {x = val_4.m_Height, y = val_4.m_Radius};
        }
    
    }

}
