using UnityEngine;

namespace TzarGames.GameFramework
{
    public class InventoryBag
    {
        // Fields
        public string Name;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.Item, int> consumableItems;
        private System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> nonconsumableItems;
        private System.Collections.Generic.Dictionary<System.Type, int> itemCountRestrictions;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.ItemInstance, System.Collections.Generic.List<object>> lockedItems;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.InventoryBag> OnItemsChanged;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> OnItemInstanceAdded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance> OnItemInstanceRemoved;
        
        // Methods
        public InventoryBag(string name)
        {
            this.consumableItems = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.Item, System.Int32>();
            this.nonconsumableItems = new System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance>();
            this.itemCountRestrictions = new System.Collections.Generic.Dictionary<System.Type, System.Int32>();
            this.lockedItems = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.ItemInstance, System.Collections.Generic.List<System.Object>>();
            this.Name = name;
        }
        public void add_OnItemsChanged(System.Action<TzarGames.GameFramework.InventoryBag> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemsChanged);
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
            while(1152921511340738440 != this.OnItemsChanged);
        
        }
        public void remove_OnItemsChanged(System.Action<TzarGames.GameFramework.InventoryBag> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemsChanged);
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
            while(1152921511340875016 != this.OnItemsChanged);
        
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
            while(1152921511341011600 != this.OnItemInstanceAdded);
        
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
            while(1152921511341148176 != this.OnItemInstanceAdded);
        
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
            while(1152921511341284760 != this.OnItemInstanceRemoved);
        
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
            while(1152921511341421336 != this.OnItemInstanceRemoved);
        
        }
        public void AddItemCountRestriction(System.Type type, int maxCount)
        {
            this.itemCountRestrictions.Add(key:  type, value:  (maxCount < 0) ? 0 : maxCount);
        }
        public bool ContainsNonConsumableItem(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            itemInstance.GenerateID();
            return (bool)((this.GetNonConsumableItemInstanceByID(itemInstanceID:  itemInstance.InstanceID)) != 0) ? 1 : 0;
        }
        public bool ContainsConsumableItem(TzarGames.GameFramework.Item item)
        {
            return (bool)((this.GetConsumableItemCount(itemId:  item)) > 0) ? 1 : 0;
        }
        public bool IsThisItemCanBeAdded(TzarGames.GameFramework.Item item)
        {
            System.Collections.Generic.Dictionary<System.Type, System.Int32> val_10;
            UnityEngine.Object val_11;
            var val_12;
            val_11 = item;
            if(0 == val_11)
            {
                    val_12 = 0;
                return (bool)val_12;
            }
            
            val_10 = this.itemCountRestrictions;
            if((val_10.ContainsKey(key:  val_11.GetType())) != false)
            {
                    val_10 = this.itemCountRestrictions;
                val_11 = val_11.GetType();
                var val_9 = (val_10.Item[val_11] > (this.getCountOfItemsOfType(type:  val_11.GetType()))) ? 1 : 0;
                return (bool)val_12;
            }
            
            val_12 = 1;
            return (bool)val_12;
        }
        public bool IsItemInstanceCanBeRemoved(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(itemInstance == null)
            {
                    return false;
            }
            
            bool val_1 = this.IsItemInstanceLocked(itemInstance:  itemInstance);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public void LockItem(TzarGames.GameFramework.ItemInstance itemInstance, object locker)
        {
            if((this.ContainsNonConsumableItem(itemInstance:  itemInstance)) == false)
            {
                    return;
            }
            
            if((this.lockedItems.ContainsKey(key:  itemInstance)) != true)
            {
                    this.lockedItems.Add(key:  itemInstance, value:  new System.Collections.Generic.List<System.Object>());
            }
            
            this = this.lockedItems;
            System.Collections.Generic.List<System.Object> val_5 = this.Item[itemInstance];
            if((val_5.Contains(item:  locker)) != false)
            {
                    return;
            }
            
            val_5.Add(item:  locker);
        }
        public void UnlockItem(TzarGames.GameFramework.ItemInstance itemInstance, object locker)
        {
            if((this.lockedItems.TryGetValue(key:  itemInstance, value: out  0)) == false)
            {
                    return;
            }
            
            if((val_1.Contains(item:  locker)) == false)
            {
                    return;
            }
            
            bool val_4 = val_1.Remove(item:  locker);
        }
        public bool IsItemInstanceLocked(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            TzarGames.GameFramework.ItemInstance val_5;
            var val_6;
            val_5 = itemInstance;
            System.Collections.Generic.List<System.Object> val_1 = 0;
            if((this.lockedItems.TryGetValue(key:  val_5, value: out  val_1)) != false)
            {
                    val_5 = val_1;
                var val_4 = (val_5.Count > 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        private int getCountOfItemsOfType(System.Type type)
        {
            var val_5;
            var val_6;
            var val_7;
            List.Enumerator<T> val_1 = this.nonconsumableItems.GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_6:
            label_2:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            System.Type val_4 = 0.InitializationCallback.GetType();
            goto label_6;
            label_3:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            if((val_7 & 1) != 0)
            {
                    return (int)(val_1.current == type) ? (val_5 + 1) : (val_5);
            }
            
            if(val_6 == 0)
            {
                    return (int)(val_1.current == type) ? (val_5 + 1) : (val_5);
            }
            
            return (int)(val_1.current == type) ? (val_5 + 1) : (val_5);
        }
        public void AddNonconsumableItem(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            TzarGames.GameFramework.Item val_4;
            if(itemInstance == null)
            {
                    return;
            }
            
            if(itemInstance.owner != null)
            {
                    if(itemInstance.owner != this)
            {
                    return;
            }
            
            }
            
            itemInstance.GenerateID();
            if((this.GetNonConsumableItemInstanceByID(itemInstanceID:  itemInstance.InstanceID)) != null)
            {
                    itemInstance.GenerateID();
                string val_2 = 0 + "Instance is already in inventory: ID: "("Instance is already in inventory: ID: ");
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if((this.IsThisItemCanBeAdded(item:  itemInstance.instancedItem)) == false)
            {
                    return;
            }
            
            val_4 = itemInstance.itemTemplate;
            if(itemInstance.itemTemplate.ConsumptionType != 1)
            {
                    return;
            }
            
            itemInstance.owner = this;
            val_4 = this.nonconsumableItems;
            val_4.Add(item:  itemInstance);
            if(this.OnItemInstanceAdded != null)
            {
                    this.OnItemInstanceAdded.Invoke(arg1:  this, arg2:  itemInstance);
            }
            
            if(this.OnItemsChanged == null)
            {
                    return;
            }
            
            this.OnItemsChanged.Invoke(obj:  this);
        }
        public void AddConsumableItem(TzarGames.GameFramework.Item item, int count)
        {
            var val_6;
            if((this.IsThisItemCanBeAdded(item:  item)) == false)
            {
                    return;
            }
            
            val_6 = this.consumableItems.ContainsKey(key:  item);
            if(val_6 != false)
            {
                    val_6 = this.consumableItems.Item[item];
                this.consumableItems.set_Item(key:  item, value:  val_6 + count);
            }
            else
            {
                    this.consumableItems.Add(key:  item, value:  count);
            }
            
            if(this.OnItemsChanged == null)
            {
                    return;
            }
            
            this.OnItemsChanged.Invoke(obj:  this);
        }
        public void RemoveItem(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            TzarGames.GameFramework.Item val_7 = itemInstance.itemTemplate;
            if(itemInstance == null)
            {
                    return;
            }
            
            if(itemInstance.itemTemplate.ConsumptionType != 1)
            {
                    return;
            }
            
            if((this.IsItemInstanceLocked(itemInstance:  itemInstance)) == true)
            {
                    return;
            }
            
            if((this.lockedItems.ContainsKey(key:  itemInstance)) != false)
            {
                    bool val_4 = this.lockedItems.Remove(key:  itemInstance);
            }
            
            val_7 = this.nonconsumableItems;
            if((val_7.Contains(item:  itemInstance)) != false)
            {
                    val_7 = this.nonconsumableItems;
                bool val_6 = val_7.Remove(item:  itemInstance);
                itemInstance.owner = 0;
            }
            
            if(this.OnItemInstanceRemoved != null)
            {
                    this.OnItemInstanceRemoved.Invoke(arg1:  this, arg2:  itemInstance);
            }
            
            if(this.OnItemsChanged == null)
            {
                    return;
            }
            
            this.OnItemsChanged.Invoke(obj:  this);
        }
        public void ResetBag()
        {
            this.consumableItems.Clear();
            this.nonconsumableItems.Clear();
            this.itemCountRestrictions.Clear();
            this.lockedItems.Clear();
        }
        public bool RemoveAllConsumableItems(TzarGames.GameFramework.Item item)
        {
            return this.RemoveConsumableItem(item:  item, count:  2147483647);
        }
        public bool RemoveConsumableItem(TzarGames.GameFramework.Item item, int count)
        {
            int val_4 = count;
            if((val_4 < 1) || (item.ConsumptionType != 0))
            {
                    return false;
            }
            
            if((this.consumableItems.ContainsKey(key:  item)) == false)
            {
                    return false;
            }
            
            val_4 = this.consumableItems.Item[item] - val_4;
            if(val_4 > 0)
            {
                    this.consumableItems.set_Item(key:  item, value:  val_4);
            }
            else
            {
                    bool val_3 = this.consumableItems.Remove(key:  item);
            }
            
            if(this.OnItemsChanged == null)
            {
                    return false;
            }
            
            this.OnItemsChanged.Invoke(obj:  this);
            return false;
        }
        public TzarGames.GameFramework.InventoryBagSerializableInfo<T, K> GetSerializedData<T, K>()
        {
            var val_12;
            var val_13;
            mem2[0] = this.Name;
            mem2[0] = __RuntimeMethodHiddenParam + 48 + 16;
            mem2[0] = __RuntimeMethodHiddenParam + 48 + 32;
            val_12 = 0;
            goto label_5;
            label_22:
            val_12 = 1;
            label_5:
            if(val_12 >= val_1.Length)
            {
                goto label_7;
            }
            
            TzarGames.GameFramework.ItemInstance val_12 = this.GetAllNonconsumableItems()[1];
            mem[16] = val_12.GetOriginalTemplate();
            if(val_12 != null)
            {
                    mem[24] = val_12.GetInstanceID();
            }
            else
            {
                    mem[24] = 0.GetInstanceID();
            }
            
            TzarGames.GameFramework.Item val_5 = val_12.GetTemplateInstance();
            mem[32] = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            if(val_12 != null)
            {
                    mem[40] = val_1[0x1][0].Data;
            }
            else
            {
                    mem[40] = 0;
            }
            
            mem[36] = val_1[0x1][0].Activated;
            if((__RuntimeMethodHiddenParam + 48 + 24) != 0)
            {
                goto label_22;
            }
            
            goto label_22;
            label_7:
            val_13 = 0;
            goto label_24;
            label_37:
            val_13 = 1;
            label_24:
            if(val_13 >= val_7.Length)
            {
                    return (TzarGames.GameFramework.InventoryBagSerializableInfo<T, K>)__RuntimeMethodHiddenParam + 48;
            }
            
            System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, System.Int32> val_13 = this.GetAllConsumableItems()[16];
            mem[16] = val_13.InitializationCallback.Clone();
            mem[20] = ;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_10 = val_13.InitializationCallback;
            mem[24] = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            if((__RuntimeMethodHiddenParam + 48 + 32) != 0)
            {
                goto label_37;
            }
            
            goto label_37;
        }
        public System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, int>[] GetAllConsumableItems()
        {
            System.Collections.Generic.List<T> val_5;
            var val_6;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, System.Int32>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, System.Int32>>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.consumableItems.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            Add(item:  new System.Collections.Generic.KeyValuePair<System.Object, System.Int32>() {Value = val_3.m_Handle});
            goto label_4;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            return (System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, System.Int32>[])ToArray();
        }
        public TzarGames.GameFramework.ItemInstance[] GetAllNonconsumableItems()
        {
            if(this.nonconsumableItems != null)
            {
                    return this.nonconsumableItems.ToArray();
            }
            
            return this.nonconsumableItems.ToArray();
        }
        public System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> GetAllItemInstancesById(int id)
        {
            goto label_1;
            label_9:
            0 = 1;
            label_1:
            if(0 >= this.nonconsumableItems.Count)
            {
                    return (System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance>)new System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance>();
            }
            
            if(val_3.itemTemplate != id)
            {
                goto label_9;
            }
            
            Add(item:  this.nonconsumableItems.Item[1]);
            goto label_9;
        }
        public bool ContainsNonConsumableWithId(int id)
        {
            var val_4;
            var val_5;
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_1 = new System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance>();
            val_4 = 0;
            label_6:
            if(val_4 >= this.nonconsumableItems.Count)
            {
                goto label_2;
            }
            
            TzarGames.GameFramework.ItemInstance val_3 = this.nonconsumableItems.Item[0];
            val_4 = val_4 + 1;
            if(val_3.itemTemplate != id)
            {
                goto label_6;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_2:
            val_5 = 0;
            return (bool)val_5;
        }
        public TzarGames.GameFramework.Item GetItemByID(int id)
        {
            var val_6;
            List.Enumerator<T> val_1 = this.nonconsumableItems.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.InitializationCallback.Clone() != id)
            {
                goto label_5;
            }
            
            0.Dispose();
            return (TzarGames.GameFramework.Item)val_6;
            label_2:
            0.Dispose();
            System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, System.Int32> val_4 = this.getConsumableItemEntryByID(id:  id);
            val_6 = val_4.Value.InitializationCallback;
            return (TzarGames.GameFramework.Item)val_6;
        }
        public TzarGames.GameFramework.ItemInstance GetNonConsumableItemInstanceByID(string itemInstanceID)
        {
            var val_5;
            var val_6;
            val_5 = itemInstanceID;
            List.Enumerator<T> val_1 = this.nonconsumableItems.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_6 = 0.InitializationCallback;
            val_6.GenerateID();
            if((System.String.op_Equality(a:  0, b:  static_value_02131000)) == false)
            {
                goto label_6;
            }
            
            0.Dispose();
            return (TzarGames.GameFramework.ItemInstance)val_6;
            label_2:
            0.Dispose();
            val_6 = 0;
            return (TzarGames.GameFramework.ItemInstance)val_6;
        }
        private System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, int> getConsumableItemEntryByID(int id)
        {
            var val_6;
            var val_7;
            val_6 = id;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.consumableItems.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            if(val_2.m_Handle.InitializationCallback.Clone() != val_6)
            {
                goto label_4;
            }
            
            val_7 = public System.Void Dictionary.Enumerator<TzarGames.GameFramework.Item, System.Int32>::Dispose();
            0.Dispose();
            return 0;
            label_2:
            0.Dispose();
            val_7 = 0;
            return 0;
        }
        public int GetItemCountByID(int id)
        {
            var val_6;
            System.Collections.Generic.KeyValuePair<TzarGames.GameFramework.Item, System.Int32> val_1 = this.getConsumableItemEntryByID(id:  id);
            if(0 != val_1.Value.InitializationCallback)
            {
                    val_6;
                return (int)val_6;
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_4 = this.GetAllItemInstancesById(id:  id);
            if(val_4 != null)
            {
                    int val_5 = val_4.Count;
                return (int)val_6;
            }
            
            val_6 = 0;
            return (int)val_6;
        }
        public int GetConsumableItemCount(int itemId)
        {
            goto label_1;
            label_7:
            0 = 1;
            label_1:
            if(0 >= val_1.Length)
            {
                    return 0;
            }
            
            if(this.GetAllConsumableItems()[16].InitializationCallback.Clone() != itemId)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public void RemoveAllItems()
        {
            int val_10;
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_9 = this.nonconsumableItems;
            val_9 = val_9.Count - 1;
            if((val_9 & 2147483648) == 0)
            {
                    do
            {
                this.RemoveItem(itemInstance:  this.nonconsumableItems.Item[val_9]);
                val_9 = val_9 - 1;
            }
            while((val_9 & 2147483648) == 0);
            
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.Item> val_4 = new System.Collections.Generic.List<TzarGames.GameFramework.Item>(collection:  this.consumableItems.Keys);
            val_10 = Count - 1;
            if((val_10 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                TzarGames.GameFramework.Item val_6 = Item[val_10];
                bool val_8 = this.RemoveConsumableItem(item:  val_6, count:  this.consumableItems.Item[val_6]);
                val_10 = val_10 - 1;
            }
            while((val_10 & 2147483648) == 0);
        
        }
    
    }

}
