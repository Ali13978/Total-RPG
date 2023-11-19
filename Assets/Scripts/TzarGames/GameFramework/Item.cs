using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Item : DatabaseRecord
    {
        // Fields
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        private int id;
        [UnityEngine.SerializeField]
        private bool UniqueInstanceIdRequired;
        public string itemName;
        [UnityEngine.SerializeField]
        public TzarGames.Common.LocalizedStringAsset localizedName;
        [UnityEngine.SerializeField]
        public TzarGames.Common.LocalizedStringAsset localizedDescription;
        public TzarGames.GameFramework.ModificatorGroup AdditionalModificators;
        [UnityEngine.SerializeField]
        private bool availableInShop;
        public UnityEngine.GameObject Prefab;
        public UnityEngine.GameObject DroppedPrefab;
        [UnityEngine.SerializeField]
        private bool autoPickup;
        [UnityEngine.SerializeField]
        private bool destroyOnPickUp;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private System.Collections.Generic.List<TzarGames.GameFramework.Items.Attributes.ItemAttribute> _attributes;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private System.Collections.Generic.List<TzarGames.GameFramework.ItemComponent> _components;
        public UnityEngine.Texture2D Icon;
        public UnityEngine.Sprite Sprite;
        public TzarGames.GameFramework.ItemConsumptionType ConsumptionType;
        public float Cost;
        public float PremiumCost;
        public uint MinimumLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt Level;
        
        // Properties
        public override int Id { get; set; }
        public bool AvailableOnShop { get; }
        public bool AutoPickup { get; }
        public bool DestroyOnPickup { get; }
        
        // Methods
        public Item()
        {
            this.destroyOnPickUp = true;
            this.UniqueInstanceIdRequired = true;
            this._attributes = new System.Collections.Generic.List<TzarGames.GameFramework.Items.Attributes.ItemAttribute>();
            this.ConsumptionType = true;
            this._components = new System.Collections.Generic.List<TzarGames.GameFramework.ItemComponent>();
            this = new UnityEngine.ScriptableObject();
        }
        public override int get_Id()
        {
            return (int)this.id;
        }
        public override void set_Id(int value)
        {
            this.id = value;
        }
        public virtual string GetLocalizedName()
        {
            if(0 != this.localizedName)
            {
                    return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            return (string)this.itemName;
        }
        public virtual string GetDescription()
        {
            if(0 != this.localizedDescription)
            {
                    return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            return 0;
        }
        public bool IsInstanceIdRequired()
        {
            return (bool)this.UniqueInstanceIdRequired;
        }
        public bool get_AvailableOnShop()
        {
            return (bool)this.availableInShop;
        }
        public bool get_AutoPickup()
        {
            return (bool)this.autoPickup;
        }
        public bool get_DestroyOnPickup()
        {
            return (bool)this.destroyOnPickUp;
        }
        public virtual bool CanBeStoredInInventory()
        {
            return true;
        }
        public TzarGames.GameFramework.ItemInstance CreateItemInstance()
        {
            if(this.UniqueInstanceIdRequired != false)
            {
                    this.GenerateID();
            }
            
            this.CreateTemplateInstance(item:  this);
            return (TzarGames.GameFramework.ItemInstance)this;
        }
        protected virtual TzarGames.GameFramework.ItemInstance CreateCustomItemInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)new TzarGames.GameFramework.ItemInstance();
        }
        public void AddAttribute(TzarGames.GameFramework.Items.Attributes.ItemAttribute attribute)
        {
            System.Collections.Generic.List<TzarGames.GameFramework.Items.Attributes.ItemAttribute> val_4;
            if(0 == attribute)
            {
                    return;
            }
            
            val_4 = this._attributes;
            if((val_4.Contains(item:  attribute)) != false)
            {
                    return;
            }
            
            this._attributes.Add(item:  attribute);
        }
        public void RemoveAttribute(TzarGames.GameFramework.Items.Attributes.ItemAttribute attribute)
        {
            bool val_1 = this._attributes.Remove(item:  attribute);
        }
        public bool HasAttribute(TzarGames.GameFramework.Items.Attributes.ItemAttribute attribute)
        {
            if(this._attributes != null)
            {
                    return this._attributes.Contains(item:  attribute);
            }
            
            return this._attributes.Contains(item:  attribute);
        }
        public bool HasAttributeOfType(System.Type type)
        {
            var val_4;
            var val_5;
            val_4 = type;
            List.Enumerator<T> val_1 = this._attributes.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.InitializationCallback.GetType() != val_4)
            {
                goto label_4;
            }
            
            0.Dispose();
            val_5 = 1;
            return (bool)val_5;
            label_2:
            0.Dispose();
            val_5 = 0;
            return (bool)val_5;
        }
        public System.Collections.Generic.IEnumerable<TzarGames.GameFramework.Items.Attributes.ItemAttribute> GetAttributes()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.GameFramework.Items.Attributes.ItemAttribute>)this._attributes;
        }
        public TzarGames.GameFramework.Items.Attributes.ItemAttribute GetAttributeAt(int index)
        {
            System.Collections.Generic.List<TzarGames.GameFramework.Items.Attributes.ItemAttribute> val_3;
            var val_4;
            if((index & 2147483648) == 0)
            {
                    val_3 = this._attributes;
                if(val_3.Count > index)
            {
                    TzarGames.GameFramework.Items.Attributes.ItemAttribute val_2 = this._attributes.Item[index];
                return (TzarGames.GameFramework.Items.Attributes.ItemAttribute)val_4;
            }
            
            }
            
            val_4 = 0;
            return (TzarGames.GameFramework.Items.Attributes.ItemAttribute)val_4;
        }
        public int GetAttributeCount()
        {
            if(this._attributes != null)
            {
                    return this._attributes.Count;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            return 0;
        }
        public T GetAttributeOfType<T>()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = __RuntimeMethodHiddenParam;
            val_5 = 0;
            label_4:
            if(val_5 >= this._attributes.Count)
            {
                goto label_2;
            }
            
            TzarGames.GameFramework.Items.Attributes.ItemAttribute val_2 = this._attributes.Item[0];
            val_5 = val_5 + 1;
            if(val_2 == null)
            {
                goto label_4;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 48];
            val_4 = __RuntimeMethodHiddenParam + 48;
            if(val_2 == null)
            {
                goto label_7;
            }
            
            val_6 = val_2;
            if(val_6 != null)
            {
                    return (object)val_6;
            }
            
            goto label_7;
            label_2:
            label_7:
            val_6 = 0;
            return (object)val_6;
        }
        public System.Collections.Generic.List<T> GetAttributesOfType<T>()
        {
            goto label_1;
            label_9:
            0 = 1;
            label_1:
            if(0 >= this._attributes.Count)
            {
                    return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            TzarGames.GameFramework.Items.Attributes.ItemAttribute val_2 = this._attributes.Item[1];
            if(((val_2 == null) || (val_2 == null)) || (val_2 != null))
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public T AddComponent<T>()
        {
            var val_4;
            TzarGames.GameFramework.ItemComponent val_2 = this.AddComponent(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_4 = 0;
            if(val_2 == null)
            {
                    return (object)val_4;
            }
            
            val_4 = val_2;
            if(val_4 != null)
            {
                    return (object)val_4;
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public TzarGames.GameFramework.ItemComponent AddComponent(System.Type t)
        {
            var val_7;
            var val_8;
            System.Collections.Generic.List<TzarGames.GameFramework.ItemComponent> val_9;
            val_7 = null;
            if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) == t)
            {
                goto label_3;
            }
            
            val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(((t & 1) & 1) == 0)
            {
                goto label_7;
            }
            
            label_3:
            val_8 = 0;
            if((UnityEngine.ScriptableObject.CreateInstance(type:  0)) == null)
            {
                goto label_10;
            }
            
            val_8 = 0;
            goto label_10;
            label_7:
            val_9 = 0 + "Invalid item component type: "("Invalid item component type: ");
            UnityEngine.Debug.LogError(message:  0);
            val_8 = 0;
            return (TzarGames.GameFramework.ItemComponent);
            label_10:
            val_9 = this._components;
            val_9.Add(item:  null);
            return (TzarGames.GameFramework.ItemComponent);
        }
        public void RemoveComponentAt(int index)
        {
            System.Collections.Generic.List<TzarGames.GameFramework.ItemComponent> val_4;
            if(((index >> 30) & 2) != 0)
            {
                    return;
            }
            
            val_4 = this._components;
            if(val_4.Count <= index)
            {
                    return;
            }
            
            this.RemoveComponent(component:  this._components.Item[index]);
        }
        public void RemoveComponent(TzarGames.GameFramework.ItemComponent component)
        {
            bool val_1 = this._components.Remove(item:  component);
            if(UnityEngine.Application.isEditor != false)
            {
                    if(UnityEngine.Application.isPlaying == false)
            {
                goto label_3;
            }
            
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_3:
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
        public T GetComponent<T>()
        {
            var val_3;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            List.Enumerator<T> val_1 = this._components.GetEnumerator();
            label_3:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_4 == null)
            {
                goto label_4;
            }
            
            val_7 = val_4;
            if(val_7 == null)
            {
                goto label_5;
            }
            
            val_8 = 0;
            val_9 = 91;
            goto label_9;
            label_2:
            val_8 = 0;
            val_7 = 0;
            val_9 = 84;
            goto label_9;
            label_5:
            label_4:
            val_8 = 0;
            val_7 = 0;
            val_9 = 91;
            label_9:
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_10;
            if(91 != 84)
            {
                    if(91 == 91)
            {
                    return (object)val_7;
            }
            
            }
            
            val_7 = 0;
            return (object)val_7;
        }
        public TzarGames.GameFramework.ItemComponent[] GetComponents()
        {
            if(this._components != null)
            {
                    return this._components.ToArray();
            }
            
            return this._components.ToArray();
        }
        public override string ToString()
        {
            return (string)this.itemName;
        }
        public static int CompareCoast(TzarGames.GameFramework.Item x, TzarGames.GameFramework.Item y)
        {
            return (int)(y.Cost >= 0) ? 1 : 0;
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void OnDestroy()
        {
        
        }
    
    }

}
