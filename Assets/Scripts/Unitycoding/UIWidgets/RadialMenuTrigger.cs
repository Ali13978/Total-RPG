using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class RadialMenuTrigger : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        protected string instanceName;
        [UnityEngine.SerializeField]
        protected UnityEngine.EventSystems.PointerEventData.InputButton button;
        [UnityEngine.SerializeField]
        protected UnityEngine.Sprite[] options;
        public Unitycoding.UIWidgets.RadialMenuTrigger.TriggerEvent onValueChanged;
        protected Unitycoding.UIWidgets.RadialMenu radialMenu;
        
        // Methods
        public RadialMenuTrigger()
        {
            this.instanceName = "RadialMenu";
        }
        protected virtual void Start()
        {
            this.radialMenu = Unitycoding.UIWidgets.UIUtility.Find<Unitycoding.UIWidgets.Tooltip>(name:  0);
        }
        public virtual void Show()
        {
            UnityEngine.Events.UnityAction<System.Int32> val_1 = new UnityEngine.Events.UnityAction<System.Int32>(object:  this, method:  System.Void Unitycoding.UIWidgets.RadialMenuTrigger::<Show>m__0(int index));
            if(this.radialMenu == null)
            {
                
            }
        
        }
        public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(eventData.button != this.button)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Unitycoding.UIWidgets.RadialMenuTrigger).__il2cppRuntimeField_170;
        }
        protected virtual void OnMouseOver()
        {
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Unitycoding.UIWidgets.RadialMenuTrigger).__il2cppRuntimeField_170;
        }
        private void <Show>m__0(int index)
        {
            this.onValueChanged.Invoke(arg0:  index);
        }
    
    }

}
