using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class VRInputModule : BaseInputModule
    {
        // Fields
        public static UnityEngine.GameObject targetObject;
        private static UnityEngine.UI.Extensions.VRInputModule _singleton;
        private int counter;
        private static bool mouseClicked;
        public static UnityEngine.Vector3 cursorPosition;
        
        // Methods
        public VRInputModule()
        {
        
        }
        protected override void Awake()
        {
            UnityEngine.UI.Extensions.VRInputModule._singleton = this;
        }
        public override void Process()
        {
            if(0 != UnityEngine.UI.Extensions.VRInputModule.targetObject)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.VRInputModule.mouseClicked = false;
        }
        public static void PointerSubmit(UnityEngine.GameObject obj)
        {
            UnityEngine.GameObject val_7 = X1;
            UnityEngine.UI.Extensions.VRInputModule.targetObject = val_7;
            UnityEngine.UI.Extensions.VRInputModule.mouseClicked = true;
            if(UnityEngine.UI.Extensions.VRInputModule.mouseClicked == false)
            {
                    return;
            }
            
            selectedObject = UnityEngine.UI.Extensions.VRInputModule.targetObject;
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.ISubmitHandler> val_3 = UnityEngine.EventSystems.ExecuteEvents.submitHandler;
            bool val_4 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  UnityEngine.UI.Extensions.VRInputModule.targetObject, functor:  new UnityEngine.EventSystems.BaseEventData(eventSystem:  UnityEngine.UI.Extensions.VRInputModule._singleton.eventSystem));
            val_7 = UnityEngine.UI.Extensions.VRInputModule.targetObject.name;
            string val_6 = 0 + "clicked ";
            UnityEngine.MonoBehaviour.print(message:  0);
            UnityEngine.UI.Extensions.VRInputModule.mouseClicked = false;
        }
        public static void PointerExit(UnityEngine.GameObject obj)
        {
            string val_1 = X1.name;
            string val_2 = 0 + "PointerExit ";
            UnityEngine.MonoBehaviour.print(message:  0);
            UnityEngine.EventSystems.PointerEventData val_4 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.UI.Extensions.VRInputModule._singleton.eventSystem);
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerExitHandler> val_5 = UnityEngine.EventSystems.ExecuteEvents.pointerExitHandler;
            bool val_6 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  X1, functor:  val_4);
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IDeselectHandler> val_7 = UnityEngine.EventSystems.ExecuteEvents.deselectHandler;
            bool val_8 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  X1, functor:  val_4);
        }
        public static void PointerEnter(UnityEngine.GameObject obj)
        {
            string val_1 = X1.name;
            string val_2 = 0 + "PointerEnter ";
            UnityEngine.MonoBehaviour.print(message:  0);
            pointerEnter = X1;
            pointerCurrentRaycast = new UnityEngine.EventSystems.RaycastResult() {distance = 0f, index = 0f, worldPosition = new UnityEngine.Vector3() {x = UnityEngine.UI.Extensions.VRInputModule.cursorPosition, y = UnityEngine.UI.Extensions.VRInputModule.targetObject.__il2cppRuntimeField_18, z = UnityEngine.UI.Extensions.VRInputModule.targetObject.__il2cppRuntimeField_1C}, worldNormal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, screenPosition = new UnityEngine.Vector2() {x = 0f, y = 0f}};
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerEnterHandler> val_5 = UnityEngine.EventSystems.ExecuteEvents.pointerEnterHandler;
            bool val_6 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IUpdateSelectedHandler>(target:  0, eventData:  X1, functor:  new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.UI.Extensions.VRInputModule._singleton.eventSystem));
        }
    
    }

}
