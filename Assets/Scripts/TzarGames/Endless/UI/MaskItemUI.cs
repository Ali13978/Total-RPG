using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class MaskItemUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Masks.MaskItem maskItem;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconImage;
        private UnityEngine.UI.Button button;
        
        // Properties
        public TzarGames.Endless.Masks.MaskItem Item { get; }
        public bool Collected { get; set; }
        
        // Methods
        public MaskItemUI()
        {
        
        }
        private void Awake()
        {
            this.button = this.GetComponentInChildren<UnityEngine.UI.Button>();
        }
        public TzarGames.Endless.Masks.MaskItem get_Item()
        {
            return (TzarGames.Endless.Masks.MaskItem)this.maskItem;
        }
        public bool get_Collected()
        {
            return UnityEngine.Object.op_Equality(x:  0, y:  this.iconImage.sprite);
        }
        public void set_Collected(bool value)
        {
            UnityEngine.Sprite val_3;
            if(value == false)
            {
                goto label_1;
            }
            
            if(this.iconImage != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_3 = this.maskItem.InactiveIcon;
            if(this.iconImage != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            this.iconImage.sprite = val_3;
            this.button.interactable = value;
        }
        [UnityEngine.ContextMenu]
        private void resetIcons()
        {
            this.iconImage.sprite = this.maskItem;
        }
        [UnityEngine.ContextMenu]
        private void makeButtons()
        {
            UnityEngine.UI.Button val_5 = this.iconImage.GetComponent<UnityEngine.UI.Button>();
            if(0 == val_5)
            {
                    val_5 = this.iconImage.gameObject.AddComponent<UnityEngine.UI.Button>();
            }
            
            val_5.targetGraphic = this.iconImage;
        }
    
    }

}
