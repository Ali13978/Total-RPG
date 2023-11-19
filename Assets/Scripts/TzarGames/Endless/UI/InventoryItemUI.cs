using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class InventoryItemUI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconImage;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.RawImage activeIcon;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.RawImage selectedImage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI count;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.InventoryItemUI> OnItemClicked;
        private TzarGames.GameFramework.ItemInstance itemInstance;
        private TzarGames.GameFramework.Item item;
        private UnityEngine.Coroutine itemAnimationCoroutine;
        
        // Properties
        public TzarGames.GameFramework.ItemInstance ItemInstance { get; set; }
        public TzarGames.GameFramework.Item Item { get; set; }
        public UnityEngine.Sprite ItemIcon { get; set; }
        public bool IsActivated { get; set; }
        public bool Selected { get; set; }
        public string Count { get; set; }
        public bool ShowCount { get; set; }
        
        // Methods
        public InventoryItemUI()
        {
        
        }
        public void add_OnItemClicked(System.Action<TzarGames.Endless.UI.InventoryItemUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemClicked);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510948042552 != this.OnItemClicked);
        
        }
        public void remove_OnItemClicked(System.Action<TzarGames.Endless.UI.InventoryItemUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemClicked);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510948179128 != this.OnItemClicked);
        
        }
        public TzarGames.GameFramework.ItemInstance get_ItemInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.itemInstance;
        }
        public void set_ItemInstance(TzarGames.GameFramework.ItemInstance value)
        {
            if(this.itemInstance == value)
            {
                    return;
            }
            
            this.itemInstance = value;
            this.updateSpriteAnimationState();
        }
        public TzarGames.GameFramework.Item get_Item()
        {
            return (TzarGames.GameFramework.Item)this.item;
        }
        public void set_Item(TzarGames.GameFramework.Item value)
        {
            if(0 == this.item)
            {
                    return;
            }
            
            this.item = value;
            this.updateSpriteAnimationState();
        }
        private void updateSpriteAnimationState()
        {
            if(0 != this.item)
            {
                    if(this.itemAnimationCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.itemAnimationCoroutine);
                this.itemAnimationCoroutine = 0;
            }
            
                if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
                if(this.enabled == false)
            {
                    return;
            }
            
                TzarGames.GameFramework.AnimatedIconItemComponent val_5 = this.item.GetComponent<TzarGames.GameFramework.AnimatedIconItemComponent>();
                if(0 == val_5)
            {
                    return;
            }
            
                this.itemAnimationCoroutine = this.StartCoroutine(routine:  this.itemAnimation(item:  val_5, animComponent:  val_5));
                return;
            }
            
            if(this.itemAnimationCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.itemAnimationCoroutine);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator itemAnimation(TzarGames.GameFramework.Item item, TzarGames.GameFramework.AnimatedIconItemComponent animComponent)
        {
            if(null != 0)
            {
                    typeof(InventoryItemUI.<itemAnimation>c__Iterator0).__il2cppRuntimeField_10 = animComponent;
            }
            else
            {
                    mem[16] = animComponent;
            }
            
            typeof(InventoryItemUI.<itemAnimation>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnEnable()
        {
            this.updateSpriteAnimationState();
        }
        private void OnDisable()
        {
            if(this.itemAnimationCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.itemAnimationCoroutine);
            this.itemAnimationCoroutine = 0;
        }
        public void NotifyItemClicked()
        {
            if(this.OnItemClicked == null)
            {
                    return;
            }
            
            this.OnItemClicked.Invoke(obj:  this);
        }
        public void OnPushedToPool()
        {
            this.itemInstance = 0;
            this.iconImage.sprite = 0;
            this.count.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.count.enabled = true;
        }
        public UnityEngine.Sprite get_ItemIcon()
        {
            if(this.iconImage != null)
            {
                    return this.iconImage.sprite;
            }
            
            return this.iconImage.sprite;
        }
        public void set_ItemIcon(UnityEngine.Sprite value)
        {
            this.iconImage.sprite = value;
        }
        public bool get_IsActivated()
        {
            UnityEngine.GameObject val_1 = this.activeIcon.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void set_IsActivated(bool value)
        {
            this.activeIcon.gameObject.SetActive(value:  value);
        }
        public bool get_Selected()
        {
            UnityEngine.GameObject val_1 = this.selectedImage.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void set_Selected(bool value)
        {
            this.selectedImage.gameObject.SetActive(value:  value);
        }
        public string get_Count()
        {
            if(this.count != null)
            {
                    return this.count.text;
            }
            
            return this.count.text;
        }
        public void set_Count(string value)
        {
            this.count.text = value;
        }
        public bool get_ShowCount()
        {
            if(this.count != null)
            {
                    return this.count.enabled;
            }
            
            return this.count.enabled;
        }
        public void set_ShowCount(bool value)
        {
            value = value;
            this.count.enabled = value;
        }
    
    }

}
