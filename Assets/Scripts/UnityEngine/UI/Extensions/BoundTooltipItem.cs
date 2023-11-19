using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class BoundTooltipItem : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text TooltipText;
        public UnityEngine.Vector3 ToolTipOffset;
        private static UnityEngine.UI.Extensions.BoundTooltipItem instance;
        
        // Properties
        public bool IsActive { get; }
        public static UnityEngine.UI.Extensions.BoundTooltipItem Instance { get; }
        
        // Methods
        public BoundTooltipItem()
        {
        
        }
        public bool get_IsActive()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        private void Awake()
        {
            UnityEngine.UI.Extensions.BoundTooltipItem.instance = this;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    this.TooltipText = this.GetComponentInChildren<UnityEngine.UI.Text>();
            }
            
            this.HideTooltip();
        }
        public void ShowTooltip(string text, UnityEngine.Vector3 pos)
        {
            UnityEngine.UI.Text val_5 = this.TooltipText;
            if((System.String.op_Inequality(a:  0, b:  val_5 = this.TooltipText)) != false)
            {
                    val_5 = this.TooltipText;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, b:  new UnityEngine.Vector3() {x = this.ToolTipOffset, y = V12.16B, z = V11.16B});
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.gameObject.SetActive(value:  true);
        }
        public void HideTooltip()
        {
            this.gameObject.SetActive(value:  false);
        }
        public static UnityEngine.UI.Extensions.BoundTooltipItem get_Instance()
        {
            if(0 != UnityEngine.UI.Extensions.BoundTooltipItem.instance)
            {
                    return (UnityEngine.UI.Extensions.BoundTooltipItem)UnityEngine.UI.Extensions.BoundTooltipItem.instance;
            }
            
            UnityEngine.UI.Extensions.BoundTooltipItem.instance = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            return (UnityEngine.UI.Extensions.BoundTooltipItem)UnityEngine.UI.Extensions.BoundTooltipItem.instance;
        }
    
    }

}
