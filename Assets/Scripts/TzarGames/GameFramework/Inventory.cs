using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Inventory
    {
        // Fields
        public const string DefaultBagName = "Default";
        public const string HiddenBagName = "Hidden";
        private TzarGames.GameFramework.InventoryBag defaultBag;
        private TzarGames.GameFramework.InventoryBag hiddenBag;
        private System.Collections.Generic.Dictionary<string, TzarGames.GameFramework.InventoryBag> bags;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> OnItemInstanceAdded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> OnItemInstanceRemoved;
        
        // Properties
        public TzarGames.GameFramework.InventoryBag DefaultBag { get; }
        public TzarGames.GameFramework.InventoryBag HiddenBag { get; }
        
        // Methods
        public Inventory()
        {
            this.bags = new System.Collections.Generic.Dictionary<System.String, TzarGames.GameFramework.InventoryBag>();
            this.defaultBag = this.CreateBag(name:  "Default");
            this.hiddenBag = this.CreateBag(name:  "Hidden");
        }
        public void add_OnItemInstanceAdded(System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemInstanceAdded);
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
            while(1152921511345901400 != this.OnItemInstanceAdded);
        
        }
        public void remove_OnItemInstanceAdded(System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemInstanceAdded);
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
            while(1152921511346037976 != this.OnItemInstanceAdded);
        
        }
        public void add_OnItemInstanceRemoved(System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemInstanceRemoved);
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
            while(1152921511346174560 != this.OnItemInstanceRemoved);
        
        }
        public void remove_OnItemInstanceRemoved(System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemInstanceRemoved);
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
            while(1152921511346311136 != this.OnItemInstanceRemoved);
        
        }
        public TzarGames.GameFramework.InventoryBag get_DefaultBag()
        {
            return (TzarGames.GameFramework.InventoryBag)this.defaultBag;
        }
        public TzarGames.GameFramework.InventoryBag get_HiddenBag()
        {
            return (TzarGames.GameFramework.InventoryBag)this.hiddenBag;
        }
        public TzarGames.GameFramework.InventoryBag CreateBag(string name)
        {
            string val_6;
            System.Collections.Generic.Dictionary<System.String, TzarGames.GameFramework.InventoryBag> val_7;
            TzarGames.GameFramework.InventoryBag val_8;
            val_6 = name;
            val_7 = this;
            if((this.bags.ContainsKey(key:  val_6)) != false)
            {
                    val_7 = this.bags;
                val_8 = val_7.Item[val_6];
                return val_8;
            }
            
            TzarGames.GameFramework.InventoryBag val_3 = null;
            val_8 = val_3;
            val_3 = new TzarGames.GameFramework.InventoryBag(name:  val_6);
            this.bags.Add(key:  TzarGames.GameFramework.InventoryBag.__il2cppRuntimeField_name, value:  val_8);
            add_OnItemInstanceAdded(value:  new System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.GameFramework.Inventory::Bag_OnItemInstanceAdded(TzarGames.GameFramework.InventoryBag arg1, TzarGames.GameFramework.ItemInstance arg2)));
            System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> val_5 = null;
            val_6 = System.Void TzarGames.GameFramework.Inventory::Bag_OnItemInstanceRemoved(TzarGames.GameFramework.InventoryBag arg1, TzarGames.GameFramework.ItemInstance arg2);
            val_5 = new System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance>(object:  this, method:  val_6);
            add_OnItemInstanceRemoved(value:  val_5);
            return val_8;
        }
        public void ResetInventory()
        {
            var val_3;
            var val_4;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.bags.Values.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            0.ResetBag();
            goto label_5;
            label_3:
            val_3 = 0;
            val_4 = 1;
            if((val_4 & 1) != 0)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
        
        }
        public void RemoveBag(TzarGames.GameFramework.InventoryBag bag)
        {
            bool val_1 = this.bags.Remove(key:  bag.Name);
            bag.remove_OnItemInstanceAdded(value:  new System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.GameFramework.Inventory::Bag_OnItemInstanceAdded(TzarGames.GameFramework.InventoryBag arg1, TzarGames.GameFramework.ItemInstance arg2)));
            bag.remove_OnItemInstanceRemoved(value:  new System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.GameFramework.Inventory::Bag_OnItemInstanceRemoved(TzarGames.GameFramework.InventoryBag arg1, TzarGames.GameFramework.ItemInstance arg2)));
        }
        private void Bag_OnItemInstanceAdded(TzarGames.GameFramework.InventoryBag arg1, TzarGames.GameFramework.ItemInstance arg2)
        {
            if(this.OnItemInstanceAdded == null)
            {
                    return;
            }
            
            this.OnItemInstanceAdded.Invoke(arg1:  arg1, arg2:  arg2);
        }
        private void Bag_OnItemInstanceRemoved(TzarGames.GameFramework.InventoryBag arg1, TzarGames.GameFramework.ItemInstance arg2)
        {
            if(this.OnItemInstanceRemoved == null)
            {
                    return;
            }
            
            this.OnItemInstanceRemoved.Invoke(arg1:  arg1, arg2:  arg2);
        }
        public TzarGames.GameFramework.InventoryBag GetBagByName(string bagName)
        {
            TzarGames.GameFramework.InventoryBag val_1 = 0;
            return (TzarGames.GameFramework.InventoryBag)((this.bags.TryGetValue(key:  bagName, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public bool IsItemInstanceStoredInAnyBag(TzarGames.GameFramework.ItemInstance instance)
        {
            TzarGames.GameFramework.ItemInstance val_4;
            var val_5;
            val_4 = instance;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.bags.Values.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            if((0.ContainsNonConsumableItem(itemInstance:  val_4)) == false)
            {
                goto label_5;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_3:
            val_5 = 0;
            return (bool)val_5;
        }
        public TzarGames.GameFramework.InventoryBag GetBagOfItemInstance(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            TzarGames.GameFramework.ItemInstance val_4;
            var val_5;
            val_4 = itemInstance;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.bags.Values.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_5 = ;
            if((0.ContainsNonConsumableItem(itemInstance:  val_4)) == false)
            {
                goto label_5;
            }
            
            return (TzarGames.GameFramework.InventoryBag)val_5;
            label_3:
            val_5 = 0;
            return (TzarGames.GameFramework.InventoryBag)val_5;
        }
        public TzarGames.GameFramework.InventoryBag GetBagOfConsumableItem(TzarGames.GameFramework.Item item)
        {
            TzarGames.GameFramework.Item val_4;
            var val_5;
            val_4 = item;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.bags.Values.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_5 = ;
            if((0.ContainsConsumableItem(item:  val_4)) == false)
            {
                goto label_5;
            }
            
            return (TzarGames.GameFramework.InventoryBag)val_5;
            label_3:
            val_5 = 0;
            return (TzarGames.GameFramework.InventoryBag)val_5;
        }
        public TzarGames.GameFramework.ItemInstance GetItemInstanceByID(string id)
        {
            string val_4;
            var val_5;
            val_4 = id;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.bags.Values.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_5 = 0.GetNonConsumableItemInstanceByID(itemInstanceID:  val_4);
            if(val_5 == null)
            {
                goto label_5;
            }
            
            return (TzarGames.GameFramework.ItemInstance)val_5;
            label_3:
            val_5 = 0;
            return (TzarGames.GameFramework.ItemInstance)val_5;
        }
        public TzarGames.GameFramework.InventoryBag[] GetAllBags()
        {
            System.Collections.Generic.List<T> val_5;
            var val_6;
            System.Collections.Generic.List<TzarGames.GameFramework.InventoryBag> val_1 = new System.Collections.Generic.List<TzarGames.GameFramework.InventoryBag>();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this.bags.Values.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            Add(item:  0);
            goto label_5;
            label_3:
            val_5 = 0;
            val_6 = 1;
            return (TzarGames.GameFramework.InventoryBag[])ToArray();
        }
        public System.Collections.Generic.List<TzarGames.GameFramework.InventoryBagSerializableInfo<T, K>> GetSerializedData<T, K>()
        {
            var val_4;
            var val_5;
            var val_6;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.bags.Values.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            if((__RuntimeMethodHiddenParam + 48) != 0)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            val_4 = 0;
            val_5 = 81;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_6;
            if(81 == 81)
            {
                    return (System.Collections.Generic.List<TzarGames.GameFramework.InventoryBagSerializableInfo<T, K>>)__RuntimeMethodHiddenParam + 48;
            }
            
            if(val_4 == 0)
            {
                    return (System.Collections.Generic.List<TzarGames.GameFramework.InventoryBagSerializableInfo<T, K>>)__RuntimeMethodHiddenParam + 48;
            }
            
            return (System.Collections.Generic.List<TzarGames.GameFramework.InventoryBagSerializableInfo<T, K>>)__RuntimeMethodHiddenParam + 48;
        }
    
    }

}
