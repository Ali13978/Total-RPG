using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class UI_Knob : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Extensions.UI_Knob.Direction direction;
        [UnityEngine.HideInInspector]
        public float knobValue;
        [UnityEngine.TooltipAttribute]
        public float maxValue;
        [UnityEngine.TooltipAttribute]
        public int loops;
        [UnityEngine.TooltipAttribute]
        public bool clampOutput01;
        [UnityEngine.TooltipAttribute]
        public bool snapToPosition;
        [UnityEngine.TooltipAttribute]
        public int snapStepsPerLoop;
        [UnityEngine.SpaceAttribute]
        public UnityEngine.UI.Extensions.KnobFloatValueEvent OnValueChanged;
        private float _currentLoops;
        private float _previousValue;
        private float _initAngle;
        private float _currentAngle;
        private UnityEngine.Vector2 _currentVector;
        private UnityEngine.Quaternion _initRotation;
        private bool _canDrag;
        
        // Methods
        public UI_Knob()
        {
            this.loops = 1;
            this.snapStepsPerLoop = 10;
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._canDrag = true;
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._canDrag = false;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._canDrag = true;
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._canDrag = false;
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.SetInitPointerData(eventData:  eventData);
        }
        private void SetInitPointerData(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Quaternion val_2 = this.transform.rotation;
            this._initRotation = val_2;
            mem[1152921512711322916] = val_2.y;
            mem[1152921512711322920] = val_2.z;
            mem[1152921512711322924] = val_2.w;
            UnityEngine.Vector2 val_3 = eventData.position;
            UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            this._currentVector = val_7;
            mem[1152921512711322908] = val_7.y;
            float val_8 = val_7.y;
            val_8 = val_8 * 57.29578f;
            this._initAngle = val_8;
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_23;
            float val_24;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            if(this._canDrag == false)
            {
                goto label_1;
            }
            
            UnityEngine.Vector2 val_1 = eventData.position;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this._currentVector = val_5;
            mem[1152921512711479964] = val_5.y;
            float val_6 = val_5.y * 57.29578f;
            this._currentAngle = val_6;
            UnityEngine.Vector3 val_8 = this.transform.forward;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.AngleAxis(angle:  val_6 - this._initAngle, axis:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this._initRotation, y = 0f, z = 0f, w = val_10.w}, rhs:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
            float val_30 = 360f;
            float val_12 = val_11.z / val_30;
            if(this.direction == 0)
            {
                goto label_11;
            }
            
            val_23 = this;
            this.knobValue = val_12;
            if(this.snapToPosition == false)
            {
                goto label_15;
            }
            
            this.SnapToPosition(knobValue: ref  -2.70954E+21f);
            float val_14 = this.knobValue * val_30;
            goto label_13;
            label_1:
            this.SetInitPointerData(eventData:  eventData);
            return;
            label_11:
            val_12 = 1f - val_12;
            val_23 = this;
            this.knobValue = val_12;
            if(this.snapToPosition == false)
            {
                goto label_15;
            }
            
            this.SnapToPosition(knobValue: ref  -2.70954E+21f);
            float val_23 = this.knobValue;
            val_23 = val_23 * val_30;
            float val_16 = val_30 - val_23;
            label_13:
            val_24 = 0f;
            label_15:
            val_26 = this._previousValue;
            val_27 = 0.5f;
            if((System.Math.Abs(this.knobValue - val_26)) <= val_27)
            {
                goto label_28;
            }
            
            val_28 = this.knobValue;
            if(val_28 >= 0)
            {
                goto label_21;
            }
            
            int val_25 = this.loops;
            if(val_25 < 2)
            {
                goto label_21;
            }
            
            val_29 = this._currentLoops;
            val_25 = val_25 - 1;
            if(val_29 >= 0)
            {
                goto label_21;
            }
            
            val_30 = 1f;
            goto label_22;
            label_21:
            if(val_28 <= val_27)
            {
                goto label_25;
            }
            
            val_31 = this._currentLoops;
            if(val_31 >= 1f)
            {
                goto label_24;
            }
            
            val_24 = this._currentLoops;
            if(val_24 != 0f)
            {
                goto label_25;
            }
            
            this.knobValue = 0f;
            goto label_26;
            label_25:
            if(val_28 >= 0)
            {
                goto label_28;
            }
            
            int val_26 = this.loops;
            val_27 = this._currentLoops;
            val_26 = val_26 - 1;
            val_28 = (float)val_26;
            if(val_27 != val_28)
            {
                goto label_28;
            }
            
            this.knobValue = 1f;
            label_26:
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
            val_32 = val_19.x;
            val_26 = val_19.z;
            this.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_32, y = val_19.y, z = val_26};
            this.SetInitPointerData(eventData:  eventData);
            float val_27 = this.knobValue;
            val_27 = val_27 + this._currentLoops;
            goto label_32;
            label_24:
            val_30 = -1f;
            label_22:
            val_30 = val_31 + val_30;
            this._currentLoops = val_30;
            label_28:
            float val_29 = this.maxValue;
            if(val_29 <= 0f)
            {
                goto label_34;
            }
            
            float val_28 = this.knobValue;
            val_28 = val_28 + this._currentLoops;
            if(val_28 <= val_29)
            {
                goto label_34;
            }
            
            this.knobValue = val_29;
            val_29 = val_29 * val_30;
            val_30 = (this.direction == 0) ? (val_30 - val_29) : (val_29);
            this.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.SetInitPointerData(eventData:  eventData);
            label_32:
            this.InvokeEvents(value:  this.knobValue);
            return;
            label_34:
            val_32 = val_11.x;
            val_26 = val_11.z;
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_32, y = val_11.y, z = val_26, w = val_11.w};
            float val_31 = this.knobValue;
            val_31 = val_31 + this._currentLoops;
            this.InvokeEvents(value:  val_31);
            this._previousValue = this.knobValue;
        }
        private void SnapToPosition(ref float knobValue)
        {
            var val_3;
            long val_5;
            float val_6;
            var val_7;
            float val_1 = 1f / (float)this.snapStepsPerLoop;
            float val_2 = knobValue / val_1;
            if(val_2 >= 0f)
            {
                goto label_3;
            }
            
            if((double)val_2 != (-0.5))
            {
                goto label_4;
            }
            
            val_5 = (long)val_3;
            val_6 = (float)val_3;
            val_7 = val_6 + (-1f);
            goto label_5;
            label_3:
            if((double)val_2 != 0.5)
            {
                goto label_6;
            }
            
            val_5 = (long)val_3;
            val_6 = (float)val_3;
            val_7 = val_6 + 1f;
            label_5:
            val_6 = ((val_5 & 1) != 0) ? (val_6) : (val_7);
            goto label_8;
            label_4:
            float val_4 = -0.5f;
            val_4 = val_2 + val_4;
            goto label_8;
            label_6:
            float val_5 = 0.5f;
            val_5 = val_2 + val_5;
            label_8:
            val_5 = val_1 * val_5;
            knobValue = val_5;
        }
        private void InvokeEvents(float value)
        {
            float val_1 = value;
            if(this.clampOutput01 != false)
            {
                    val_1 = val_1 / (float)this.loops;
            }
            
            this.OnValueChanged.Invoke(arg0:  val_1);
        }
    
    }

}
