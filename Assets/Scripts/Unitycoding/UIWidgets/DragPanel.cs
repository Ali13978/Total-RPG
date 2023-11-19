using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class DragPanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.Vector2 pointerOffset;
        private UnityEngine.RectTransform canvasRectTransform;
        private UnityEngine.RectTransform panelRectTransform;
        
        // Methods
        public DragPanel()
        {
        
        }
        private void Awake()
        {
            var val_8;
            var val_9;
            UnityEngine.Canvas val_1 = this.GetComponentInParent<UnityEngine.Canvas>();
            if(0 == val_1)
            {
                    return;
            }
            
            val_8 = 0;
            this.canvasRectTransform = (null == null) ? val_1.transform : 0;
            val_9 = 0;
            this.panelRectTransform = (null == null) ? this.transform.parent : 0;
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
            UnityEngine.RectTransform val_8;
            float val_9;
            val_8 = this.panelRectTransform;
            if(0 == val_8)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = this.ClampToWindow(data:  data);
            val_8 = this.canvasRectTransform;
            val_9 = val_3.x;
            if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_9, y = val_3.y}, cam:  val_8, localPoint: out  new UnityEngine.Vector2() {x = data.pressEventCamera, y = data.pressEventCamera})) == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = this.pointerOffset, y = val_3.y});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_9 = val_7.x;
            this.panelRectTransform.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_7.y, z = val_7.z};
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
