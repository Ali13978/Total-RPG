using UnityEngine;

namespace UnityEngine.EventSystems
{
    [UnityEngine.AddComponentMenu]
    public class GamePadInputModule : BaseInputModule
    {
        // Fields
        private float m_PrevActionTime;
        private UnityEngine.Vector2 m_LastMoveVector;
        private int m_ConsecutiveMoveCount;
        [UnityEngine.SerializeField]
        private string m_HorizontalAxis;
        [UnityEngine.SerializeField]
        private string m_VerticalAxis;
        [UnityEngine.SerializeField]
        private string m_SubmitButton;
        [UnityEngine.SerializeField]
        private string m_CancelButton;
        [UnityEngine.SerializeField]
        private float m_InputActionsPerSecond;
        [UnityEngine.SerializeField]
        private float m_RepeatDelay;
        
        // Properties
        public float inputActionsPerSecond { get; set; }
        public float repeatDelay { get; set; }
        public string horizontalAxis { get; set; }
        public string verticalAxis { get; set; }
        public string submitButton { get; set; }
        public string cancelButton { get; set; }
        
        // Methods
        protected GamePadInputModule()
        {
            this.m_HorizontalAxis = "Horizontal";
            this.m_VerticalAxis = "Vertical";
            this.m_SubmitButton = "Submit";
            this.m_CancelButton = "Cancel";
            this.m_InputActionsPerSecond = 10f;
            this.m_RepeatDelay = 7.346868E-41f;
        }
        public float get_inputActionsPerSecond()
        {
            return (float)this.m_InputActionsPerSecond;
        }
        public void set_inputActionsPerSecond(float value)
        {
            this.m_InputActionsPerSecond = value;
        }
        public float get_repeatDelay()
        {
            return (float)this.m_RepeatDelay;
        }
        public void set_repeatDelay(float value)
        {
            this.m_RepeatDelay = value;
        }
        public string get_horizontalAxis()
        {
            return (string)this.m_HorizontalAxis;
        }
        public void set_horizontalAxis(string value)
        {
            this.m_HorizontalAxis = value;
        }
        public string get_verticalAxis()
        {
            return (string)this.m_VerticalAxis;
        }
        public void set_verticalAxis(string value)
        {
            this.m_VerticalAxis = value;
        }
        public string get_submitButton()
        {
            return (string)this.m_SubmitButton;
        }
        public void set_submitButton(string value)
        {
            this.m_SubmitButton = value;
        }
        public string get_cancelButton()
        {
            return (string)this.m_CancelButton;
        }
        public void set_cancelButton(string value)
        {
            this.m_CancelButton = value;
        }
        public override bool ShouldActivateModule()
        {
            var val_8;
            if(this.ShouldActivateModule() != false)
            {
                    bool val_2 = UnityEngine.Input.GetButtonDown(buttonName:  0);
                bool val_3 = UnityEngine.Input.GetButtonDown(buttonName:  0);
                bool val_5 = UnityEngine.Mathf.Approximately(a:  UnityEngine.Input.GetAxisRaw(axisName:  0), b:  0f);
                bool val_7 = UnityEngine.Mathf.Approximately(a:  UnityEngine.Input.GetAxisRaw(axisName:  0), b:  0f);
                val_8 = 1;
                return (bool)val_8;
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public override void ActivateModule()
        {
            UnityEngine.Object val_11;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if((this.GetComponent<UnityEngine.EventSystems.StandaloneInputModule>().enabled) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            }
            
            this.ActivateModule();
            val_11 = this.eventSystem.currentSelectedGameObject;
            if(0 == val_11)
            {
                    val_11 = this.eventSystem.firstSelectedGameObject;
            }
            
            this.eventSystem.SetSelectedGameObject(selected:  val_11, pointer:  this.GetBaseEventData());
        }
        public override void DeactivateModule()
        {
            this.DeactivateModule();
        }
        public override void Process()
        {
            if((this.SendUpdateEventToSelectedObject() | (~this.eventSystem.sendNavigationEvents)) == true)
            {
                    return;
            }
            
            if(this.SendMoveEventToSelectedObject() != false)
            {
                    return;
            }
            
            bool val_8 = this.SendSubmitEventToSelectedObject();
        }
        protected bool SendSubmitEventToSelectedObject()
        {
            UnityEngine.EventSystems.BaseEventData val_16;
            UnityEngine.EventSystems.BaseEventData val_17;
            val_16 = this;
            if(0 == this.eventSystem.currentSelectedGameObject)
            {
                    return false;
            }
            
            UnityEngine.EventSystems.BaseEventData val_5 = this.GetBaseEventData();
            if((UnityEngine.Input.GetButtonDown(buttonName:  0)) != false)
            {
                    ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> val_9 = UnityEngine.EventSystems.ExecuteEvents.submitHandler;
                bool val_10 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  this.eventSystem.currentSelectedGameObject, functor:  val_5);
            }
            
            val_17 = this.m_CancelButton;
            if((UnityEngine.Input.GetButtonDown(buttonName:  0)) != false)
            {
                    val_16 = this.eventSystem.currentSelectedGameObject;
                ExecuteEvents.EventFunction<UnityEngine.EventSystems.ICancelHandler> val_14 = UnityEngine.EventSystems.ExecuteEvents.cancelHandler;
                val_17 = val_16;
                bool val_15 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  val_17, functor:  val_5);
            }
            
            if(val_5 != null)
            {
                    return val_5.used;
            }
            
            return val_5.used;
        }
        private UnityEngine.Vector2 GetRawMoveVector()
        {
            float val_6;
            float val_7;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_6 = UnityEngine.Input.GetAxisRaw(axisName:  0);
            val_7 = UnityEngine.Input.GetAxisRaw(axisName:  0);
            if((UnityEngine.Input.GetButtonDown(buttonName:  0)) != false)
            {
                    if(val_6 < 0)
            {
                    val_6 = -1f;
            }
            else
            {
                    if(val_6 > 0f)
            {
                    val_6 = 1f;
            }
            
            }
            
            }
            
            if((UnityEngine.Input.GetButtonDown(buttonName:  0)) == false)
            {
                    return new UnityEngine.Vector2() {x = val_6, y = val_7};
            }
            
            if(val_7 < 0)
            {
                    val_7 = -1f;
                return new UnityEngine.Vector2() {x = val_6, y = val_7};
            }
            
            if(val_7 <= 0f)
            {
                    return new UnityEngine.Vector2() {x = val_6, y = val_7};
            }
            
            val_7 = 1f;
            return new UnityEngine.Vector2() {x = val_6, y = val_7};
        }
        protected bool SendMoveEventToSelectedObject()
        {
            var val_15;
            float val_16;
            int val_17;
            float val_1 = UnityEngine.Time.unscaledTime;
            UnityEngine.Vector2 val_2 = this.GetRawMoveVector();
            if((UnityEngine.Mathf.Approximately(a:  val_2.x, b:  0f)) != false)
            {
                    if((UnityEngine.Mathf.Approximately(a:  val_2.y, b:  0f)) != false)
            {
                    this.m_ConsecutiveMoveCount = 0;
                return false;
            }
            
            }
            
            if((UnityEngine.Input.GetButtonDown(buttonName:  0)) != false)
            {
                    val_15 = 1;
            }
            else
            {
                    val_15 = UnityEngine.Input.GetButtonDown(buttonName:  0);
            }
            
            float val_8 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, rhs:  new UnityEngine.Vector2() {x = this.m_LastMoveVector, y = V11.16B});
            if(val_15 != true)
            {
                    if((val_8 > 0f) && (this.m_ConsecutiveMoveCount == 1))
            {
                    val_16 = this.m_PrevActionTime + this.m_RepeatDelay;
            }
            else
            {
                    float val_14 = this.m_InputActionsPerSecond;
                val_14 = 1f / val_14;
                val_16 = this.m_PrevActionTime + val_14;
            }
            
                if(val_1 <= val_16)
            {
                    return false;
            }
            
            }
            
            UnityEngine.EventSystems.AxisEventData val_9 = this.GetAxisEventData(x:  val_2.x, y:  val_2.y, moveDeadZone:  0.6f);
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IMoveHandler> val_12 = UnityEngine.EventSystems.ExecuteEvents.moveHandler;
            bool val_13 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  this.eventSystem.currentSelectedGameObject, functor:  val_9);
            if(val_8 > 0f)
            {
                    val_17 = this.m_ConsecutiveMoveCount + 1;
            }
            else
            {
                    val_17 = 1;
                this.m_ConsecutiveMoveCount = 0;
            }
            
            this.m_ConsecutiveMoveCount = val_17;
            this.m_PrevActionTime = val_1;
            this.m_LastMoveVector = val_2;
            mem[1152921512731471360] = val_2.y;
            if(val_9 == null)
            {
                
            }
        
        }
        protected bool SendUpdateEventToSelectedObject()
        {
            if(0 == this.eventSystem.currentSelectedGameObject)
            {
                    return false;
            }
            
            UnityEngine.EventSystems.BaseEventData val_5 = this.GetBaseEventData();
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IUpdateSelectedHandler> val_8 = UnityEngine.EventSystems.ExecuteEvents.updateSelectedHandler;
            bool val_9 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  this.eventSystem.currentSelectedGameObject, functor:  val_5);
            if(val_5 != null)
            {
                    return val_5.used;
            }
            
            return val_5.used;
        }
    
    }

}
