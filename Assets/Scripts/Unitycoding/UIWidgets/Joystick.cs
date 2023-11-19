using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class Joystick : Selectable, IDragHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform handle;
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private float returnSpeed;
        [UnityEngine.SerializeField]
        private string horizontalAxis;
        [UnityEngine.SerializeField]
        private string verticalAxis;
        public Unitycoding.UIWidgets.Joystick.JoystickEvent onChange;
        private UnityEngine.RectTransform parentTransform;
        private bool returnHandle;
        
        // Properties
        public UnityEngine.Vector2 position { get; }
        
        // Methods
        public Joystick()
        {
            this.radius = 90f;
            this.returnSpeed = 4f;
            this.horizontalAxis = "Horizontal";
            this.verticalAxis = "Vertical";
        }
        public UnityEngine.Vector2 get_position()
        {
            float val_16;
            float val_18;
            UnityEngine.Vector2 val_1 = this.handle.anchoredPosition;
            UnityEngine.Vector2 val_2 = this.handle.anchoredPosition;
            if(val_2.x < 0)
            {
                    UnityEngine.Vector2 val_3 = this.handle.anchoredPosition;
                val_16 = val_3.x;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_16, y = val_3.y}, d:  this.radius);
            }
            
            val_18 = 0.1f;
            if(val_4.x.sqrMagnitude >= 0)
            {
                    return new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius};
            }
            
            if(0 != UnityEngine.EventSystems.EventSystem.current)
            {
                    if(UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == true)
            {
                    return new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius};
            }
            
            }
            
            val_16 = UnityEngine.Input.GetAxis(axisName:  0);
            val_18 = UnityEngine.Input.GetAxis(axisName:  0);
            CinemachineFreeLook.Orbit val_14 = new CinemachineFreeLook.Orbit(h:  val_16, r:  val_18);
            return new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius};
        }
        protected override void Start()
        {
            this.Start();
            this.returnHandle = true;
            this.parentTransform = this.GetComponentInParent<UnityEngine.RectTransform>();
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.RectTransform val_8;
            float val_11;
            float val_12;
            UnityEngine.Vector2 val_13;
            float val_14;
            val_8 = this;
            if(eventData != null)
            {
                    UnityEngine.Vector2 val_1 = eventData.position;
                val_11 = val_1.x;
                val_12 = val_1.y;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = 0.position;
                val_11 = val_2.x;
                val_12 = val_2.y;
            }
            
            val_13 = eventData.pressEventCamera;
            if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_11, y = val_12}, cam:  this.parentTransform, localPoint: out  new UnityEngine.Vector2() {x = val_13, y = val_13})) == false)
            {
                    return;
            }
            
            val_13 = 1152921504730062848;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_11 = val_5.x;
            val_14 = val_5.z;
            this.handle.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_5.y, z = val_14};
            UnityEngine.Vector2 val_6 = this.handle.anchoredPosition;
            if(val_6.x <= this.radius)
            {
                    return;
            }
            
            val_14 = this.radius;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_14}, d:  this.radius);
            val_11 = val_7.x;
            val_8 = this.handle;
            val_8.anchoredPosition = new UnityEngine.Vector2() {x = val_11, y = val_7.y};
        }
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerDown(eventData:  eventData);
            this.returnHandle = false;
            this.OnDrag(eventData:  eventData);
        }
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerUp(eventData:  eventData);
            this.returnHandle = true;
        }
        private void Update()
        {
            var val_11;
            float val_12;
            if(this.returnHandle != false)
            {
                    UnityEngine.Vector2 val_1 = this.handle.anchoredPosition;
                val_11 = null;
                val_11 = null;
                val_12 = UnityEngine.Mathf.Epsilon;
                if(val_1.x > val_12)
            {
                    UnityEngine.Vector2 val_2 = this.handle.anchoredPosition;
                UnityEngine.Vector2 val_3 = this.handle.anchoredPosition;
                UnityEngine.Vector2 val_4 = this.handle.anchoredPosition;
                CinemachineFreeLook.Orbit val_6;
                val_4.y = val_4.y * this.returnSpeed;
                val_6 = new CinemachineFreeLook.Orbit(h:  val_3.x * this.returnSpeed, r:  val_4.y);
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.m_Height, y = val_6.m_Radius}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
                val_12 = val_9.x;
                this.handle.anchoredPosition = new UnityEngine.Vector2() {x = val_12, y = val_9.y};
            }
            
            }
            
            UnityEngine.Vector2 val_10 = this.position;
            this.onChange.Invoke(arg0:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        }
    
    }

}
