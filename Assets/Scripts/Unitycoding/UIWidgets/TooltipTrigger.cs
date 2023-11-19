using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private string instanceName;
        [UnityEngine.SerializeField]
        private bool showBackground;
        [UnityEngine.SerializeField]
        private float width;
        [UnityEngine.SerializeField]
        private UnityEngine.Color color;
        [UnityEngine.TextAreaAttribute]
        public string tooltip;
        public UnityEngine.Sprite icon;
        private Unitycoding.UIWidgets.Tooltip instance;
        
        // Methods
        public TooltipTrigger()
        {
            this.width = 300f;
            this.instanceName = "Tooltip";
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.color = val_1;
            mem[1152921512640195820] = val_1.g;
            mem[1152921512640195824] = val_1.b;
            mem[1152921512640195828] = val_1.a;
        }
        private void Start()
        {
            this.instance = Unitycoding.UIWidgets.UIUtility.Find<Unitycoding.UIWidgets.Tooltip>(name:  0);
            if(this.enabled == false)
            {
                    return;
            }
            
            if(0 != this.instance)
            {
                    return;
            }
            
            this.enabled = false;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            string val_1 = Unitycoding.UIWidgets.UIUtility.ColorString(value:  null, color:  new UnityEngine.Color() {r = this.color, g = V10.16B, b = V9.16B, a = V8.16B});
            var val_2 = (this.showBackground == true) ? 1 : 0;
            goto typeof(Unitycoding.UIWidgets.Tooltip).__il2cppRuntimeField_1E0;
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.instance == null)
            {
                
            }
        
        }
        private void OnMouseEnter()
        {
            string val_1 = Unitycoding.UIWidgets.UIUtility.ColorString(value:  null, color:  new UnityEngine.Color() {r = this.color, g = V10.16B, b = V9.16B, a = V8.16B});
            var val_2 = (this.showBackground == true) ? 1 : 0;
            goto typeof(Unitycoding.UIWidgets.Tooltip).__il2cppRuntimeField_1E0;
        }
        private void OnMouseExit()
        {
            if(this.instance == null)
            {
                
            }
        
        }
    
    }

}
