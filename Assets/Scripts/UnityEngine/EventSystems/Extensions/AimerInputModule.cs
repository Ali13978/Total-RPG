using UnityEngine;

namespace UnityEngine.EventSystems.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class AimerInputModule : PointerInputModule
    {
        // Fields
        public string activateAxis;
        public UnityEngine.Vector2 aimerOffset;
        public static UnityEngine.GameObject objectUnderAimer;
        
        // Methods
        protected AimerInputModule()
        {
            this.activateAxis = "Submit";
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            this.aimerOffset = val_1.m_Height;
            mem[1152921512728007796] = val_1.m_Height >> 32;
        }
        public override void ActivateModule()
        {
            UnityEngine.EventSystems.StandaloneInputModule val_1 = this.GetComponent<UnityEngine.EventSystems.StandaloneInputModule>();
            if(0 == val_1)
            {
                    return;
            }
            
            if(val_1.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public override void Process()
        {
            bool val_4 = UnityEngine.Input.GetButtonUp(buttonName:  0);
            this.ProcessInteraction(pointer:  this, pressed:  UnityEngine.Input.GetButtonDown(buttonName:  0), released:  val_4);
            if(val_4 != false)
            {
                    this.RemovePointerData(data:  this);
                return;
            }
            
            this.ProcessMove(pointerEvent:  this);
        }
        protected virtual UnityEngine.EventSystems.PointerEventData GetAimerPointerEventData()
        {
            UnityEngine.EventSystems.PointerEventData val_1 = 0;
            bool val_2 = this.GetPointerData(id:  -2, data: out  val_1, create:  true);
            int val_3 = UnityEngine.Screen.width;
            float val_9 = (float)val_3;
            float val_10 = 0.5f;
            val_9 = val_9 * val_10;
            val_10 = (float)UnityEngine.Screen.height * val_10;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_9, r:  val_10);
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius}, b:  new UnityEngine.Vector2() {x = this.aimerOffset, y = V8.16B});
            val_1.position = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            this.eventSystem.RaycastAll(eventData:  val_1, raycastResults:  val_3);
            UnityEngine.EventSystems.RaycastResult val_8 = UnityEngine.EventSystems.BaseInputModule.FindFirstRaycast(candidates:  0);
            val_1.pointerCurrentRaycast = new UnityEngine.EventSystems.RaycastResult() {worldPosition = new UnityEngine.Vector3(), worldNormal = new UnityEngine.Vector3(), screenPosition = new UnityEngine.Vector2()};
            this.Clear();
            return val_1;
        }
        private void ProcessInteraction(UnityEngine.EventSystems.PointerEventData pointer, bool pressed, bool released)
        {
            UnityEngine.Object val_50;
            float val_51;
            float val_52;
            UnityEngine.Object val_54;
            var val_55;
            var val_57;
            var val_58;
            val_50 = released;
            UnityEngine.EventSystems.RaycastResult val_1 = pointer.pointerCurrentRaycast;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = InitializationCallback;
            UnityEngine.EventSystems.Extensions.AimerInputModule.objectUnderAimer = UnityEngine.EventSystems.ExecuteEvents.GetEventHandler<UnityEngine.EventSystems.ISubmitHandler>(root:  0);
            if(pressed == false)
            {
                goto label_36;
            }
            
            pointer.eligibleForClick = true;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            val_51 = val_4.y;
            if(pointer != null)
            {
                    val_52 = val_4.x;
                pointer.delta = new UnityEngine.Vector2() {x = val_52, y = val_51};
                UnityEngine.Vector2 val_5 = pointer.position;
                pointer.pressPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
                UnityEngine.EventSystems.RaycastResult val_6 = pointer.pointerCurrentRaycast;
            }
            else
            {
                    0.delta = new UnityEngine.Vector2() {x = val_4.x, y = val_51};
                UnityEngine.Vector2 val_7 = 0.position;
                val_51 = val_7.x;
                val_52 = val_51;
                0.pressPosition = new UnityEngine.Vector2() {x = val_52, y = val_7.y};
                UnityEngine.EventSystems.RaycastResult val_8 = 0.pointerCurrentRaycast;
            }
            
            pointer.pointerPressRaycast = new UnityEngine.EventSystems.RaycastResult() {worldPosition = new UnityEngine.Vector3(), worldNormal = new UnityEngine.Vector3(), screenPosition = new UnityEngine.Vector2()};
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> val_9 = UnityEngine.EventSystems.ExecuteEvents.submitHandler;
            val_54 = UnityEngine.EventSystems.ExecuteEvents.ExecuteHierarchy<UnityEngine.EventSystems.ISubmitHandler>(root:  0, eventData:  val_2, callbackFunction:  pointer);
            if(0 != val_54)
            {
                goto label_14;
            }
            
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> val_12 = UnityEngine.EventSystems.ExecuteEvents.pointerDownHandler;
            val_54 = UnityEngine.EventSystems.ExecuteEvents.ExecuteHierarchy<UnityEngine.EventSystems.ISubmitHandler>(root:  0, eventData:  val_2, callbackFunction:  pointer);
            if(0 != val_54)
            {
                goto label_22;
            }
            
            val_54 = UnityEngine.EventSystems.ExecuteEvents.GetEventHandler<UnityEngine.EventSystems.ISubmitHandler>(root:  0);
            goto label_22;
            label_14:
            pointer.eligibleForClick = false;
            label_22:
            val_55 = pointer.pointerPress;
            if(0 != val_54)
            {
                    if(pointer != null)
            {
                    pointer.pointerPress = val_54;
                pointer.rawPointerPress = val_2;
            }
            else
            {
                    0.pointerPress = val_54;
                0.rawPointerPress = val_2;
            }
            
                pointer.clickCount = 0;
            }
            
            UnityEngine.GameObject val_18 = UnityEngine.EventSystems.ExecuteEvents.GetEventHandler<UnityEngine.EventSystems.ISubmitHandler>(root:  0);
            if(pointer != null)
            {
                    pointer.pointerDrag = val_18;
            }
            else
            {
                    0.pointerDrag = val_18;
            }
            
            if(0 != pointer.pointerDrag)
            {
                    ExecuteEvents.EventFunction<UnityEngine.EventSystems.IBeginDragHandler> val_22 = UnityEngine.EventSystems.ExecuteEvents.beginDragHandler;
                bool val_23 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  pointer.pointerDrag, functor:  pointer);
            }
            
            label_36:
            if(val_50 == false)
            {
                    return;
            }
            
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerUpHandler> val_25 = UnityEngine.EventSystems.ExecuteEvents.pointerUpHandler;
            bool val_26 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  pointer.pointerPress, functor:  pointer);
            val_50 = UnityEngine.EventSystems.ExecuteEvents.GetEventHandler<UnityEngine.EventSystems.ISubmitHandler>(root:  0);
            val_55 = 1152921504721543168;
            if((0 != pointer.pointerPress) || (pointer.eligibleForClick == false))
            {
                goto label_49;
            }
            
            val_51 = UnityEngine.Time.unscaledTime;
            if(pointer == null)
            {
                goto label_50;
            }
            
            float val_32 = pointer.clickTime;
            val_32 = val_51 - val_32;
            if(val_32 >= 0)
            {
                goto label_60;
            }
            
            val_57 = pointer.clickCount;
            goto label_52;
            label_49:
            val_50 = pointer.pointerDrag;
            if(0 == val_50)
            {
                goto label_59;
            }
            
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDropHandler> val_36 = UnityEngine.EventSystems.ExecuteEvents.dropHandler;
            UnityEngine.GameObject val_37 = UnityEngine.EventSystems.ExecuteEvents.ExecuteHierarchy<UnityEngine.EventSystems.ISubmitHandler>(root:  0, eventData:  val_2, callbackFunction:  pointer);
            goto label_59;
            label_50:
            if((val_51 - 0.clickTime) >= 0)
            {
                goto label_60;
            }
            
            val_57 = 0.clickCount;
            label_52:
            val_58 = val_57 + 1;
            goto label_61;
            label_60:
            val_58 = 1;
            label_61:
            pointer.clickCount = 1;
            if(pointer != null)
            {
                    pointer.clickTime = val_51;
            }
            else
            {
                    0.clickTime = val_51;
            }
            
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerClickHandler> val_42 = UnityEngine.EventSystems.ExecuteEvents.pointerClickHandler;
            bool val_43 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  pointer.pointerPress, functor:  pointer);
            label_59:
            if(pointer != null)
            {
                    pointer.eligibleForClick = false;
                pointer.pointerPress = 0;
                pointer.rawPointerPress = 0;
            }
            else
            {
                    0.eligibleForClick = false;
                0.pointerPress = 0;
                0.rawPointerPress = 0;
            }
            
            if(0 != pointer.pointerDrag)
            {
                    ExecuteEvents.EventFunction<UnityEngine.EventSystems.IEndDragHandler> val_47 = UnityEngine.EventSystems.ExecuteEvents.endDragHandler;
                bool val_48 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  pointer.pointerDrag, functor:  pointer);
            }
            
            pointer.pointerDrag = 0;
        }
        public override void DeactivateModule()
        {
            this.DeactivateModule();
            this.ClearSelection();
        }
    
    }

}
