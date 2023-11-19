using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class UIWindowBase : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.RectTransform m_transform;
        private bool _isDragging;
        public static bool ResetCoords;
        private UnityEngine.Vector3 m_originalCoods;
        private UnityEngine.Canvas m_canvas;
        private UnityEngine.RectTransform m_canvasRectTransform;
        public int KeepWindowInCanvas;
        
        // Methods
        public UIWindowBase()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.m_originalCoods = val_1;
            mem[1152921512774147016] = val_1.y;
            this.KeepWindowInCanvas = 5;
            mem[1152921512774147020] = val_1.z;
        }
        private void Start()
        {
            UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
            this.m_transform = val_1;
            UnityEngine.Vector3 val_2 = val_1.position;
            this.m_originalCoods = val_2;
            mem[1152921512774271304] = val_2.y;
            mem[1152921512774271308] = val_2.z;
            UnityEngine.Canvas val_3 = this.GetComponentInParent<UnityEngine.Canvas>();
            this.m_canvas = val_3;
            this.m_canvasRectTransform = val_3.GetComponent<UnityEngine.RectTransform>();
        }
        private void Update()
        {
            null = null;
            if(UnityEngine.UI.Extensions.UIWindowBase.ResetCoords == false)
            {
                    return;
            }
            
            this.resetCoordinatePosition();
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_13;
            float val_14;
            if(this._isDragging == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = eventData.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector3 val_3 = this.ScreenToCanvas(screenPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(eventData != null)
            {
                    UnityEngine.Vector2 val_4 = eventData.position;
                val_13 = val_4.x;
                val_14 = val_4.y;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = 0.position;
                val_13 = val_5.x;
                val_14 = val_5.y;
            }
            
            UnityEngine.Vector2 val_6 = eventData.delta;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_13, y = val_14}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector3 val_9 = this.ScreenToCanvas(screenPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = this.m_transform.localPosition;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            this.m_transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Object val_10;
            UnityEngine.EventSystems.RaycastResult val_1 = eventData.pointerCurrentRaycast;
            val_10 = InitializationCallback;
            if(0 == val_10)
            {
                    return;
            }
            
            UnityEngine.EventSystems.RaycastResult val_5 = eventData.pointerCurrentRaycast;
            val_10 = this.name;
            if((System.String.op_Equality(a:  0, b:  InitializationCallback.name)) == false)
            {
                    return;
            }
            
            this._isDragging = true;
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._isDragging = false;
        }
        private void resetCoordinatePosition()
        {
            var val_1;
            this.m_transform.position = new UnityEngine.Vector3() {x = this.m_originalCoods, y = V9.16B, z = V10.16B};
            val_1 = null;
            val_1 = null;
            UnityEngine.UI.Extensions.UIWindowBase.ResetCoords = false;
        }
        private UnityEngine.Vector3 ScreenToCanvas(UnityEngine.Vector3 screenPosition)
        {
            float val_10;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_36;
            float val_37;
            val_29 = screenPosition.z;
            val_30 = screenPosition.y;
            val_31 = screenPosition.x;
            UnityEngine.Vector2 val_1 = this.m_canvasRectTransform.sizeDelta;
            val_32 = val_1.x;
            val_33 = val_1.y;
            if(this.m_canvas.renderMode != 0)
            {
                    if((this.m_canvas.renderMode != 1) || (0 != this.m_canvas.worldCamera))
            {
                goto label_9;
            }
            
            }
            
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            val_36 = val_6.x;
            val_37 = val_6.y;
            goto label_12;
            label_9:
            UnityEngine.Ray val_8 = this.m_canvas.worldCamera.ScreenPointToRay(position:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_29});
            UnityEngine.Vector3 val_11 = this.m_canvasRectTransform.forward;
            UnityEngine.Vector3 val_12 = this.m_canvasRectTransform.position;
            if((0 & 1) == 0)
            {
                goto label_17;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10, y = val_11.y, z = val_11.z}, d:  0f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = this.m_canvasRectTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_31 = val_15.x;
            val_30 = val_15.y;
            UnityEngine.Vector2 val_16 = this.m_canvasRectTransform.pivot;
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_32, y = val_33}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            val_36 = val_18.x;
            val_37 = val_18.y;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.one;
            UnityEngine.Vector2 val_20 = this.m_canvasRectTransform.pivot;
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_32, y = val_33}, b:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            val_29 = val_15.z;
            val_32 = val_22.x;
            val_33 = val_22.y;
            label_12:
            int val_29 = this.KeepWindowInCanvas;
            val_29 = val_37 + (float)val_29;
            return new UnityEngine.Vector3() {x = UnityEngine.Mathf.Clamp(value:  val_31, min:  val_36 + (float)this.KeepWindowInCanvas, max:  val_32 - (float)this.KeepWindowInCanvas), y = UnityEngine.Mathf.Clamp(value:  val_30, min:  val_29, max:  val_33 - (float)val_29), z = val_29};
            label_17:
            System.Exception val_28 = new System.Exception(message:  "Is it practically possible?");
        }
        private static UIWindowBase()
        {
        
        }
    
    }

}
