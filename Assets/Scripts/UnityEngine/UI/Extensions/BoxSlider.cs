using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class BoxSlider : Selectable, IDragHandler, IInitializePotentialDragHandler, ICanvasElement, IEventSystemHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform m_HandleRect;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.SerializeField]
        private float m_MinValue;
        [UnityEngine.SerializeField]
        private float m_MaxValue;
        [UnityEngine.SerializeField]
        private bool m_WholeNumbers;
        [UnityEngine.SerializeField]
        private float m_ValueX;
        [UnityEngine.SerializeField]
        private float m_ValueY;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.BoxSlider.BoxSliderEvent m_OnValueChanged;
        private UnityEngine.Transform m_HandleTransform;
        private UnityEngine.RectTransform m_HandleContainerRect;
        private UnityEngine.Vector2 m_Offset;
        private UnityEngine.DrivenRectTransformTracker m_Tracker;
        
        // Properties
        public UnityEngine.RectTransform HandleRect { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public bool WholeNumbers { get; set; }
        public float ValueX { get; set; }
        public float NormalizedValueX { get; set; }
        public float ValueY { get; set; }
        public float NormalizedValueY { get; set; }
        public UnityEngine.UI.Extensions.BoxSlider.BoxSliderEvent OnValueChanged { get; set; }
        private float StepSize { get; }
        
        // Methods
        protected BoxSlider()
        {
            this.m_MaxValue = 1f;
            this.m_ValueX = 1f;
            this.m_ValueY = 1f;
            this.m_OnValueChanged = new BoxSlider.BoxSliderEvent();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            mem[1152921512667365764] = val_2.y;
            this.m_Offset = val_2;
        }
        public UnityEngine.RectTransform get_HandleRect()
        {
            return (UnityEngine.RectTransform)this.m_HandleRect;
        }
        public void set_HandleRect(UnityEngine.RectTransform value)
        {
            if((UnityEngine.UI.Extensions.BoxSlider.SetClass<UnityEngine.RectTransform>(currentValue: ref  0, newValue:  this.m_HandleRect)) == false)
            {
                    return;
            }
            
            this.UpdateCachedReferences();
            this.UpdateVisuals();
        }
        public float get_MinValue()
        {
            return (float)this.m_MinValue;
        }
        public void set_MinValue(float value)
        {
            if((UnityEngine.UI.Extensions.BoxSlider.SetStruct<System.Single>(currentValue: ref  0f, newValue:  value)) == false)
            {
                    return;
            }
            
            this.SetX(input:  this.m_ValueX, sendCallback:  true);
            this.SetY(input:  this.m_ValueY, sendCallback:  true);
            this.UpdateVisuals();
        }
        public float get_MaxValue()
        {
            return (float)this.m_MaxValue;
        }
        public void set_MaxValue(float value)
        {
            if((UnityEngine.UI.Extensions.BoxSlider.SetStruct<System.Single>(currentValue: ref  0f, newValue:  value)) == false)
            {
                    return;
            }
            
            this.SetX(input:  this.m_ValueX, sendCallback:  true);
            this.SetY(input:  this.m_ValueY, sendCallback:  true);
            this.UpdateVisuals();
        }
        public bool get_WholeNumbers()
        {
            return (bool)this.m_WholeNumbers;
        }
        public void set_WholeNumbers(bool value)
        {
            bool val_1 = value;
            if((UnityEngine.UI.Extensions.BoxSlider.SetStruct<System.Boolean>(currentValue: ref  false, newValue:  this.m_WholeNumbers)) == false)
            {
                    return;
            }
            
            this.SetX(input:  this.m_ValueX, sendCallback:  true);
            this.SetY(input:  this.m_ValueY, sendCallback:  true);
            this.UpdateVisuals();
        }
        public float get_ValueX()
        {
            var val_1;
            float val_3;
            var val_4;
            float val_5;
            val_3 = this.m_ValueX;
            if(this.m_WholeNumbers == false)
            {
                    return val_3;
            }
            
            if(val_3 >= 0f)
            {
                goto label_4;
            }
            
            if((double)val_3 != (-0.5))
            {
                goto label_5;
            }
            
            val_4 = val_1;
            val_5 = -1f;
            goto label_6;
            label_4:
            if((double)val_3 != 0.5)
            {
                goto label_7;
            }
            
            val_4 = val_1;
            val_5 = 1f;
            label_6:
            val_5 = (float)val_4 + val_5;
            var val_2 = (((long)val_4 & 1) != 0) ? ((float)val_4) : (val_5);
            return val_3;
            label_5:
            float val_3 = -0.5f;
            val_3 = val_3 + val_3;
            return val_3;
            label_7:
            float val_4 = 0.5f;
            val_4 = val_3 + val_4;
            return val_3;
        }
        public void set_ValueX(float value)
        {
            this.SetX(input:  value, sendCallback:  true);
        }
        public float get_NormalizedValueX()
        {
            if((UnityEngine.Mathf.Approximately(a:  this.m_MinValue, b:  this.m_MaxValue)) == false)
            {
                    return UnityEngine.Mathf.InverseLerp(a:  this.m_MinValue, b:  this.m_MaxValue, value:  this.ValueX);
            }
            
            return 0f;
        }
        public void set_NormalizedValueX(float value)
        {
            this.SetX(input:  UnityEngine.Mathf.Lerp(a:  this.m_MinValue, b:  this.m_MaxValue, t:  value), sendCallback:  true);
        }
        public float get_ValueY()
        {
            var val_1;
            float val_3;
            var val_4;
            float val_5;
            val_3 = this.m_ValueY;
            if(this.m_WholeNumbers == false)
            {
                    return val_3;
            }
            
            if(val_3 >= 0f)
            {
                goto label_4;
            }
            
            if((double)val_3 != (-0.5))
            {
                goto label_5;
            }
            
            val_4 = val_1;
            val_5 = -1f;
            goto label_6;
            label_4:
            if((double)val_3 != 0.5)
            {
                goto label_7;
            }
            
            val_4 = val_1;
            val_5 = 1f;
            label_6:
            val_5 = (float)val_4 + val_5;
            var val_2 = (((long)val_4 & 1) != 0) ? ((float)val_4) : (val_5);
            return val_3;
            label_5:
            float val_3 = -0.5f;
            val_3 = val_3 + val_3;
            return val_3;
            label_7:
            float val_4 = 0.5f;
            val_4 = val_3 + val_4;
            return val_3;
        }
        public void set_ValueY(float value)
        {
            this.SetY(input:  value, sendCallback:  true);
        }
        public float get_NormalizedValueY()
        {
            if((UnityEngine.Mathf.Approximately(a:  this.m_MinValue, b:  this.m_MaxValue)) == false)
            {
                    return UnityEngine.Mathf.InverseLerp(a:  this.m_MinValue, b:  this.m_MaxValue, value:  this.ValueY);
            }
            
            return 0f;
        }
        public void set_NormalizedValueY(float value)
        {
            this.SetY(input:  UnityEngine.Mathf.Lerp(a:  this.m_MinValue, b:  this.m_MaxValue, t:  value), sendCallback:  true);
        }
        public UnityEngine.UI.Extensions.BoxSlider.BoxSliderEvent get_OnValueChanged()
        {
            return (BoxSliderEvent)this.m_OnValueChanged;
        }
        public void set_OnValueChanged(UnityEngine.UI.Extensions.BoxSlider.BoxSliderEvent value)
        {
            this.m_OnValueChanged = value;
        }
        private float get_StepSize()
        {
            if(this.m_WholeNumbers != false)
            {
                    return 1f;
            }
            
            float val_1 = this.m_MinValue;
            val_1 = this.m_MaxValue - val_1;
            val_1 = val_1 * 0.1f;
            return (float)val_1;
        }
        public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
        {
        
        }
        public void LayoutComplete()
        {
        
        }
        public void GraphicUpdateComplete()
        {
        
        }
        public static bool SetClass<T>(ref T currentValue, T newValue)
        {
            var val_2;
            if((__RuntimeMethodHiddenParam | 1152921504606900224) != null)
            {
                    if((null == null) || ((0 & 1) == 0))
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_2:
            val_2 = 1;
            mem2[0] = __RuntimeMethodHiddenParam;
            return (bool)val_2;
        }
        public static bool SetStruct<T>(ref T currentValue, T newValue)
        {
            var val_2;
            if(((__RuntimeMethodHiddenParam & 1) & 1) != 0)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            mem2[0] = newValue;
            return (bool)val_2;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.UpdateCachedReferences();
            this.SetX(input:  this.m_ValueX, sendCallback:  false);
            this.SetY(input:  this.m_ValueY, sendCallback:  false);
            this.UpdateVisuals();
        }
        protected override void OnDisable()
        {
            this.m_Tracker.Clear();
            this.OnDisable();
        }
        private void UpdateCachedReferences()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Transform val_2 = this.m_HandleRect.transform;
                this.m_HandleTransform = val_2;
                if(0 == val_2.parent)
            {
                    return;
            }
            
                this.m_HandleContainerRect = this.m_HandleTransform.parent.GetComponent<UnityEngine.RectTransform>();
                return;
            }
            
            this.m_HandleContainerRect = 0;
        }
        private void SetX(float input)
        {
            this.SetX(input:  input, sendCallback:  true);
        }
        private void SetX(float input, bool sendCallback)
        {
            var val_3;
            float val_6;
            var val_7;
            float val_8;
            float val_9;
            bool val_6 = this.m_WholeNumbers;
            val_6 = UnityEngine.Mathf.Clamp(value:  input, min:  this.m_MinValue, max:  this.m_MaxValue);
            if((val_6 & 255) == false)
            {
                goto label_3;
            }
            
            if(val_6 >= 0f)
            {
                goto label_6;
            }
            
            if((double)val_6 != (-0.5))
            {
                goto label_7;
            }
            
            val_7 = val_3;
            val_8 = -1f;
            goto label_8;
            label_3:
            val_6 = val_6 >> 32;
            val_9 = val_6;
            goto label_9;
            label_6:
            if((double)val_6 != 0.5)
            {
                goto label_10;
            }
            
            val_7 = val_3;
            val_8 = 1f;
            label_8:
            val_8 = (float)val_7 + val_8;
            var val_4 = (((long)val_7 & 1) != 0) ? ((float)val_7) : (val_8);
            goto label_12;
            label_7:
            float val_7 = -0.5f;
            val_7 = val_6 + val_7;
            goto label_12;
            label_10:
            float val_8 = 0.5f;
            val_8 = val_6 + val_8;
            label_12:
            val_9 = this.m_ValueX;
            label_9:
            if(val_9 == val_6)
            {
                    return;
            }
            
            this.m_ValueX = val_6;
            this.UpdateVisuals();
            if(sendCallback == false)
            {
                    return;
            }
            
            this.m_OnValueChanged.Invoke(arg0:  val_6, arg1:  this.ValueY);
        }
        private void SetY(float input)
        {
            this.SetY(input:  input, sendCallback:  true);
        }
        private void SetY(float input, bool sendCallback)
        {
            var val_2;
            float val_5;
            var val_6;
            float val_7;
            val_5 = UnityEngine.Mathf.Clamp(value:  input, min:  this.m_MinValue, max:  this.m_MaxValue);
            if(this.m_WholeNumbers == false)
            {
                goto label_11;
            }
            
            if(val_5 >= 0f)
            {
                goto label_6;
            }
            
            if((double)val_5 != (-0.5))
            {
                goto label_7;
            }
            
            val_6 = val_2;
            val_7 = -1f;
            goto label_8;
            label_6:
            if((double)val_5 != 0.5)
            {
                goto label_9;
            }
            
            val_6 = val_2;
            val_7 = 1f;
            label_8:
            val_7 = (float)val_6 + val_7;
            var val_3 = (((long)val_6 & 1) != 0) ? ((float)val_6) : (val_7);
            goto label_11;
            label_7:
            float val_5 = -0.5f;
            val_5 = val_5 + val_5;
            goto label_11;
            label_9:
            float val_6 = 0.5f;
            val_6 = val_5 + val_6;
            label_11:
            if(this.m_ValueY == val_5)
            {
                    return;
            }
            
            this.m_ValueY = val_5;
            this.UpdateVisuals();
            if(sendCallback == false)
            {
                    return;
            }
            
            this.m_OnValueChanged.Invoke(arg0:  this.ValueX, arg1:  val_5);
        }
        protected override void OnRectTransformDimensionsChange()
        {
            this.OnRectTransformDimensionsChange();
            this.UpdateVisuals();
        }
        private void UpdateVisuals()
        {
            this.m_Tracker.Clear();
            if(0 == this.m_HandleContainerRect)
            {
                    return;
            }
            
            this.m_Tracker.Clear();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.one;
            float val_4 = this.NormalizedValueX;
            float val_5 = this.NormalizedValueY;
            this.m_HandleRect.anchorMin = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            this = this.m_HandleRect;
            this.anchorMax = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        private void UpdateDrag(UnityEngine.EventSystems.PointerEventData eventData, UnityEngine.Camera cam)
        {
            float val_13;
            if(0 == this.m_HandleContainerRect)
            {
                    return;
            }
            
            UnityEngine.Rect val_2 = this.m_HandleContainerRect.rect;
            if(val_2.m_XMin <= 0f)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = eventData.position;
            val_13 = val_3.x;
            if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_13, y = val_3.y}, cam:  this.m_HandleContainerRect, localPoint: out  new UnityEngine.Vector2() {x = cam, y = cam})) == false)
            {
                    return;
            }
            
            UnityEngine.Rect val_5 = this.m_HandleContainerRect.rect;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_5.m_XMin, y = val_5.m_YMin});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = this.m_Offset, y = val_5.m_YMin});
            UnityEngine.Rect val_8 = this.m_HandleContainerRect.rect;
            val_8.m_XMin = val_7.x / val_8.m_XMin;
            this.NormalizedValueX = UnityEngine.Mathf.Clamp01(value:  val_8.m_XMin);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = this.m_Offset, y = val_8.m_Height});
            val_13 = val_10.x;
            UnityEngine.Rect val_11 = this.m_HandleContainerRect.rect;
            val_11.m_XMin = val_13 / val_11.m_XMin;
            this.NormalizedValueY = UnityEngine.Mathf.Clamp01(value:  val_11.m_XMin);
        }
        private bool CanDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_5;
            if(this.IsActive() != false)
            {
                    if(this.IsInteractable() != false)
            {
                    var val_4 = (eventData.button == 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.RectTransform val_14;
            float val_17;
            float val_18;
            float val_21;
            var val_22;
            if((this.CanDrag(eventData:  eventData)) == false)
            {
                    return;
            }
            
            this.OnPointerDown(eventData:  eventData);
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            mem[1152921512671643268] = val_2.y;
            this.m_Offset = val_2;
            val_14 = this.m_HandleContainerRect;
            if(0 == val_14)
            {
                goto label_11;
            }
            
            val_14 = this.m_HandleRect;
            if(eventData != null)
            {
                    UnityEngine.Vector2 val_4 = eventData.position;
                val_17 = val_4.x;
                val_18 = val_4.y;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = 0.position;
                val_17 = val_5.x;
                val_18 = val_5.y;
            }
            
            UnityEngine.Camera val_6 = eventData.enterEventCamera;
            if((UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_17, y = val_18}, cam:  val_14)) == false)
            {
                goto label_11;
            }
            
            val_14 = this.m_HandleRect;
            if(eventData == null)
            {
                goto label_12;
            }
            
            UnityEngine.Vector2 val_8 = eventData.position;
            val_17 = val_8.x;
            val_21 = val_8.y;
            goto label_13;
            label_11:
            this.UpdateDrag(eventData:  eventData, cam:  eventData.pressEventCamera);
            return;
            label_12:
            UnityEngine.Vector2 val_10 = 0.position;
            val_17 = val_10.x;
            val_21 = val_10.y;
            label_13:
            if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_17, y = val_21}, cam:  val_14, localPoint: out  new UnityEngine.Vector2() {x = eventData.pressEventCamera, y = eventData.pressEventCamera})) != false)
            {
                    val_22 = 0f;
                this.m_Offset = 0;
                mem[1152921512671643268] = 0;
            }
            
            mem[1152921512671643268] = -val_17;
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((this.CanDrag(eventData:  eventData)) == false)
            {
                    return;
            }
            
            this.UpdateDrag(eventData:  eventData, cam:  eventData.pressEventCamera);
        }
        public virtual void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            eventData.useDragThreshold = false;
        }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
        {
            return this.transform;
        }
        private bool UnityEngine.UI.ICanvasElement.IsDestroyed()
        {
            return this.IsDestroyed();
        }
    
    }

}
