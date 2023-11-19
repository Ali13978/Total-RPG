using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.RectTransform Stick;
        public int MovementRange;
        public UnityStandardAssets.CrossPlatformInput.Joystick.AxisOption axesToUse;
        public string horizontalAxisName;
        public string verticalAxisName;
        private UnityEngine.Vector3 m_StartPos;
        private UnityEngine.Vector3 m_InitialPos;
        private bool m_UseX;
        private bool m_UseY;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;
        
        // Methods
        public Joystick()
        {
            this.MovementRange = 100;
            this.horizontalAxisName = "Horizontal";
            this.verticalAxisName = "Vertical";
        }
        private void OnEnable()
        {
            this.CreateVirtualAxes();
        }
        private void Start()
        {
            UnityEngine.Vector3 val_1 = this.Stick.position;
            this.m_InitialPos = val_1;
            mem[1152921510536114072] = val_1.y;
            mem[1152921510536114076] = val_1.z;
            this.m_StartPos = val_1;
            mem[1152921510536114060] = val_1.y;
            mem[1152921510536114064] = val_1.z;
        }
        private void UpdateVirtualAxes(UnityEngine.Vector3 value)
        {
            VirtualAxis val_4;
            bool val_5;
            val_4 = this;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_StartPos, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = -val_1.y, z = val_1.z}, d:  (float)this.MovementRange);
            if((this.m_UseX & 255) != false)
            {
                    this.m_HorizontalVirtualAxis.m_Value = -val_2.x;
                val_5 = this.m_UseY;
            }
            else
            {
                    val_5 = this.m_UseX >> 8;
            }
            
            if(val_5 == false)
            {
                    return;
            }
            
            val_4 = this.m_VerticalVirtualAxis;
            this.m_VerticalVirtualAxis.m_Value = val_2.y;
        }
        private void CreateVirtualAxes()
        {
            AxisOption val_9;
            bool val_10;
            bool val_11;
            val_9 = this.axesToUse;
            if(this != null)
            {
                    this.m_UseX = ((val_9 | 1) == 1) ? 1 : 0;
            }
            else
            {
                    this.m_UseX = ((val_9 | 1) == 1) ? 1 : 0;
                val_10 = this.m_UseX;
                val_9 = this.axesToUse;
            }
            
            this.m_UseY = ((val_9 | 2) == 2) ? 1 : 0;
            if(val_10 != false)
            {
                    typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_10 = this.horizontalAxisName;
                typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_1C = 1;
                this.m_HorizontalVirtualAxis = new System.Object();
                UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  null);
                val_11 = this.m_UseY;
            }
            
            if(val_11 == false)
            {
                    return;
            }
            
            typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_10 = this.verticalAxisName;
            typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_1C = 1;
            this.m_VerticalVirtualAxis = new System.Object();
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  null);
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData data)
        {
            int val_8;
            float val_11;
            float val_12;
            bool val_13;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_11 = val_1.x;
            val_12 = val_1.y;
            if((this.m_UseX & 255) != false)
            {
                    UnityEngine.Vector2 val_3 = data.position;
                val_3.x = val_3.x - this.m_StartPos;
                val_13 = this.m_UseY;
                val_11 = (float)UnityEngine.Mathf.Clamp(value:  0, min:  (int)val_3.x, max:  -this.MovementRange);
            }
            else
            {
                    val_13 = this.m_UseX >> 8;
            }
            
            if(val_13 != false)
            {
                    UnityEngine.Vector2 val_5 = data.position;
                val_5.x = val_5.y - val_5.x;
                val_8 = (int)val_5.x;
                val_12 = (float)UnityEngine.Mathf.Clamp(value:  0, min:  val_8, max:  -this.MovementRange);
            }
            
            UnityEngine.Vector3 val_8 = this.m_StartPos;
            val_8 = val_11 + val_8;
            val_5.y = val_12 + val_5.y;
            val_1.z = val_1.z + val_1.z;
            this.Stick.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_7 = this.Stick.position;
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData data)
        {
            this.Stick.position = new UnityEngine.Vector3() {x = this.m_InitialPos, y = V9.16B, z = V10.16B};
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = this.m_StartPos, y = V9.16B, z = V10.16B});
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            UnityEngine.Vector2 val_1 = data.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            this.m_StartPos = val_2;
            mem[1152921510536776460] = val_2.y;
            mem[1152921510536776464] = val_2.z;
            this.Stick.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = this.m_StartPos, y = val_2.y, z = val_2.z});
        }
        private void OnDisable()
        {
            bool val_2;
            if((this.m_UseX & 255) != false)
            {
                    this.m_HorizontalVirtualAxis.Remove();
                val_2 = this.m_UseY;
            }
            else
            {
                    val_2 = this.m_UseX >> 8;
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            this.m_VerticalVirtualAxis.Remove();
        }
    
    }

}
