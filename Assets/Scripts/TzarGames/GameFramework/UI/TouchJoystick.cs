using UnityEngine;

namespace TzarGames.GameFramework.UI
{
    public class TouchJoystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        public bool Fixed;
        public UnityEngine.RectTransform Stick;
        public UnityEngine.RectTransform StickRoot;
        public UnityEngine.RectTransform StickGlow;
        public UnityEngine.UI.Graphic StickRootGraphicElement;
        public UnityEngine.UI.Graphic StickGlowGraphicElement;
        public float StickRootActiveAlpha;
        public float StickRootInactiveAlpha;
        public float StickRootFadeTime;
        public int MovementRange;
        public TzarGames.GameFramework.UI.TouchJoystick.AxisOption axesToUse;
        public string horizontalAxisName;
        public string verticalAxisName;
        private UnityEngine.Vector3 m_StartPos;
        private UnityEngine.Vector3 m_InitialPos;
        private bool m_UseX;
        private bool m_UseY;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;
        
        // Methods
        public TouchJoystick()
        {
            this.StickRootActiveAlpha = 1f;
            this.StickRootInactiveAlpha = 0.5f;
            this.StickRootFadeTime = 0.5f;
            this.MovementRange = 100;
            this.horizontalAxisName = "Horizontal";
            this.verticalAxisName = "Vertical";
        }
        private void OnEnable()
        {
            this.CreateVirtualAxes();
            if(this.StickGlowGraphicElement == null)
            {
                
            }
        
        }
        private void Start()
        {
            UnityEngine.Vector3 val_1 = this.Stick.position;
            this.m_InitialPos = val_1;
            mem[1152921511451784528] = val_1.y;
            mem[1152921511451784532] = val_1.z;
            this.m_StartPos = val_1;
            mem[1152921511451784516] = val_1.y;
            mem[1152921511451784520] = val_1.z;
            if(this.StickGlowGraphicElement == null)
            {
                
            }
        
        }
        private void UpdateVirtualAxes(UnityEngine.Vector3 value)
        {
            bool val_4;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.m_StartPos, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = -val_1.y, z = val_1.z}, d:  (float)this.MovementRange);
            if((this.m_UseX & 255) != false)
            {
                    this.m_HorizontalVirtualAxis.Update(value:  -val_2.x);
                val_4 = this.m_UseY;
            }
            else
            {
                    val_4 = this.m_UseX >> 8;
            }
            
            if(val_4 == false)
            {
                    return;
            }
            
            this.m_VerticalVirtualAxis.Update(value:  val_2.y);
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
                    this.m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(name:  this.horizontalAxisName);
                UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  0);
                val_11 = this.m_UseY;
            }
            
            if(val_11 == false)
            {
                    return;
            }
            
            this.m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(name:  this.verticalAxisName);
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  0);
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData data)
        {
            UnityEngine.Vector2 val_1 = data.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector3 val_3 = this.clampedStickPos(pos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.Stick.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = this.Stick.position;
            UnityEngine.Vector3 val_5 = this.StickGlow.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  -90f, z:  0f);
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, rhs:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
            this.StickGlow.rotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
            UnityEngine.Vector3 val_10 = this.Stick.position;
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData data)
        {
            this.Stick.position = new UnityEngine.Vector3() {x = this.m_InitialPos, y = this.StickRootFadeTime, z = V10.16B};
            this.StickRoot.position = new UnityEngine.Vector3() {x = this.m_InitialPos, y = this.StickRootFadeTime, z = V10.16B};
            this.StickGlow.position = new UnityEngine.Vector3() {x = this.m_InitialPos, y = this.StickRootFadeTime, z = V10.16B};
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = this.m_StartPos, y = this.StickRootFadeTime, z = V10.16B});
        }
        private UnityEngine.Vector3 clampedStickPos(UnityEngine.Vector3 pos)
        {
            float val_7;
            float val_8;
            float val_9;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_7 = val_1.x;
            val_8 = val_1.y;
            if((this.m_UseX & 255) != false)
            {
                    val_9 = pos.x - this.m_StartPos;
                val_7 = (float)(int)val_9;
            }
            
            if(this.m_UseX >= true)
            {
                    val_9 = pos.y - val_9;
                val_8 = (float)(int)val_9;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_1.z}, maxLength:  (float)this.MovementRange * this.StickRootGraphicElement.canvas.scaleFactor);
            val_6.x = this.m_StartPos + val_6.x;
            val_6.y = val_6.y + S4;
            val_6.z = val_6.z + S5;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            float val_6;
            float val_7;
            val_6 = this.StickRootActiveAlpha;
            val_7 = this.StickRootFadeTime;
            if(this.Fixed != false)
            {
                    this.m_StartPos = this.m_InitialPos;
                mem[1152921511452657220] = typeof(UnityEngine.UI.Graphic).__il2cppRuntimeField_420;
                mem[1152921511452657224] = ???;
            }
            else
            {
                    UnityEngine.Vector2 val_1 = data.position;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
                this.m_StartPos = val_2;
                mem[1152921511452657220] = val_2.y;
                mem[1152921511452657224] = val_2.z;
                this.StickRoot.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
                val_6 = this.m_StartPos;
                val_7 = val_2.y;
                this.StickGlow.position = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_2.z};
            }
            
            UnityEngine.Vector2 val_3 = data.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector3 val_5 = this.clampedStickPos(pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.Stick.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = this.m_StartPos, y = val_5.y, z = val_5.z});
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
