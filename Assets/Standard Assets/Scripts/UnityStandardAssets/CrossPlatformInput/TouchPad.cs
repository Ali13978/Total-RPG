using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    [UnityEngine.RequireComponent]
    public class TouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
    {
        // Fields
        public UnityStandardAssets.CrossPlatformInput.TouchPad.AxisOption axesToUse;
        public UnityStandardAssets.CrossPlatformInput.TouchPad.ControlStyle controlStyle;
        public string horizontalAxisName;
        public string verticalAxisName;
        public float Xsensitivity;
        public float Ysensitivity;
        private UnityEngine.Vector3 m_StartPos;
        private UnityEngine.Vector2 m_PreviousDelta;
        private UnityEngine.Vector3 m_JoytickOutput;
        private bool m_UseX;
        private bool m_UseY;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;
        private bool m_Dragging;
        private int m_Id;
        private UnityEngine.Vector2 m_PreviousTouchPos;
        private UnityEngine.Vector3 m_Center;
        private UnityEngine.UI.Image m_Image;
        
        // Methods
        public TouchPad()
        {
            this.horizontalAxisName = "Horizontal";
            this.Xsensitivity = 1f;
            this.Ysensitivity = 1f;
            this.m_Id = 0;
            this.verticalAxisName = "Vertical";
        }
        private void OnEnable()
        {
            this.CreateVirtualAxes();
        }
        private void Start()
        {
            UnityEngine.UI.Image val_1 = this.GetComponent<UnityEngine.UI.Image>();
            this.m_Image = val_1;
            UnityEngine.Vector3 val_3 = val_1.transform.position;
            this.m_Center = val_3;
            mem[1152921510541703300] = val_3.y;
            mem[1152921510541703304] = val_3.z;
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
        private void UpdateVirtualAxes(UnityEngine.Vector3 value)
        {
            VirtualAxis val_2;
            bool val_3;
            val_2 = this;
            if((this.m_UseX & 255) != false)
            {
                    this.m_HorizontalVirtualAxis.m_Value = value.x;
                val_3 = this.m_UseY;
            }
            else
            {
                    val_3 = this.m_UseX >> 8;
            }
            
            if(val_3 == false)
            {
                    return;
            }
            
            val_2 = this.m_VerticalVirtualAxis;
            this.m_VerticalVirtualAxis.m_Value = value.y;
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            this.m_Dragging = true;
            this.m_Id = data.pointerId;
            if(this.controlStyle == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = data.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.m_Center = val_3;
            mem[1152921510542104836] = val_3.y;
            mem[1152921510542104840] = val_3.z;
        }
        private void Update()
        {
            int val_10;
            if(this.m_Dragging == false)
            {
                    return;
            }
            
            val_10 = 1152921504719626240;
            int val_10 = this.m_Id;
            if(val_10 == 1)
            {
                    return;
            }
            
            val_10 = val_10 + 1;
            if(UnityEngine.Input.touchCount < val_10)
            {
                    return;
            }
            
            if(this.controlStyle == 2)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.m_PreviousTouchPos, y = V8.16B});
                this.m_Center = val_2;
                mem[1152921510542339716] = val_2.y;
                mem[1152921510542339720] = val_2.z;
                UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
                val_3 = (val_3 + (this.m_Id * 68)) + 32;
                this.m_PreviousTouchPos = val_2.x;
                mem[1152921510542339708] = val_2.y;
            }
            
            UnityEngine.Touch[] val_5 = UnityEngine.Input.touches;
            val_5 = (val_5 + (this.m_Id * 68)) + 32;
            UnityEngine.Touch[] val_7 = UnityEngine.Input.touches;
            val_10 = this.m_Id;
            val_7 = (val_7 + (val_10 * 68)) + 32;
            val_2.x = val_2.x - this.m_Center;
            val_2.y = val_2.y - val_2.z;
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  val_2.x, r:  val_2.y);
            val_2.x = val_2.x * this.Xsensitivity;
            val_2.y = val_2.y * this.Ysensitivity;
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData data)
        {
            this.m_Id = 0;
            this.m_Dragging = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.UpdateVirtualAxes(value:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        private void OnDisable()
        {
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.AxisExists(name:  null)) != false)
            {
                    UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.UnRegisterVirtualAxis(name:  null);
            }
            
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.AxisExists(name:  null)) == false)
            {
                    return;
            }
            
            UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.UnRegisterVirtualAxis(name:  null);
        }
    
    }

}
