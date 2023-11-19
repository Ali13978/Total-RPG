using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_CharacterTemplate : CharacterTemplate
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.LootInfo loot;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Loot[] additionalLoot;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.LootInfo[] additionalLootInfos;
        private System.Collections.Generic.List<TzarGames.GameFramework.Loot> totalLoot;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.ItemInstance, int> activatedItems;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.Skills.CharacterSkill[] skills;
        private System.Collections.Generic.Dictionary<int, TzarGames.TzarHero.Skills.CharacterSkill> skillInstances;
        private System.Collections.Generic.List<TzarGames.TzarHero.Skills.CharacterSkill> skillInstanceList;
        public TzarGames.TzarHero.TH_CharacterTemplate.ItemActivateEvent OnItemActivated;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <OwnerCharacter>k__BackingField;
        
        // Properties
        protected System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Skills.CharacterSkill> Skills { get; }
        protected int SkillCount { get; }
        public int SkillInstanceCount { get; }
        public TzarGames.GameFramework.Loot[] LootList { get; }
        public int MaximumLootSpawnCount { get; }
        public TzarGames.TzarHero.TH_Character OwnerCharacter { get; set; }
        
        // Methods
        public TH_CharacterTemplate()
        {
            this.totalLoot = new System.Collections.Generic.List<TzarGames.GameFramework.Loot>();
            this.activatedItems = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.ItemInstance, System.Int32>();
            this.skillInstances = new System.Collections.Generic.Dictionary<System.Int32, TzarGames.TzarHero.Skills.CharacterSkill>();
            this.skillInstanceList = new System.Collections.Generic.List<TzarGames.TzarHero.Skills.CharacterSkill>();
            this.OnItemActivated = new TH_CharacterTemplate.ItemActivateEvent();
        }
        protected System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Skills.CharacterSkill> get_Skills()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Skills.CharacterSkill>)this.skills;
        }
        public TzarGames.TzarHero.Skills.CharacterSkill GetSkillAtIndex(int index)
        {
            TzarGames.TzarHero.Skills.CharacterSkill[] val_1;
            TzarGames.TzarHero.Skills.CharacterSkill val_2;
            if((index & 2147483648) != 0)
            {
                goto label_0;
            }
            
            val_1 = this.skills;
            int val_1 = this.skills.Length;
            val_1 = val_1 - 1;
            if(val_1 >= index)
            {
                goto label_2;
            }
            
            label_0:
            val_2 = 0;
            return val_2;
            label_2:
            val_1 = (long)index;
            val_2 = this.skills[val_1];
            return val_2;
        }
        protected int get_SkillCount()
        {
            if(this.skills != null)
            {
                    return (int)this.skills.Length;
            }
            
            return (int)this.skills.Length;
        }
        public int get_SkillInstanceCount()
        {
            if(this.skillInstanceList != null)
            {
                    return this.skillInstanceList.Count;
            }
            
            return this.skillInstanceList.Count;
        }
        public TzarGames.TzarHero.Skills.CharacterSkill GetSkillInstanceAtIndex(int index)
        {
            System.Collections.Generic.List<TzarGames.TzarHero.Skills.CharacterSkill> val_4;
            var val_5;
            if((index & 2147483648) == 0)
            {
                    val_4 = this.skillInstanceList;
                if((val_4.Count - 1) >= index)
            {
                    return (TzarGames.TzarHero.Skills.CharacterSkill)this.skillInstanceList.Item[index];
            }
            
            }
            
            val_5 = 0;
            return (TzarGames.TzarHero.Skills.CharacterSkill)this.skillInstanceList.Item[index];
        }
        public TzarGames.GameFramework.Loot[] get_LootList()
        {
            if(this.totalLoot != null)
            {
                    return this.totalLoot.ToArray();
            }
            
            return this.totalLoot.ToArray();
        }
        public void AddLoot(TzarGames.GameFramework.Loot loot)
        {
            this.totalLoot.Add(item:  loot);
        }
        public int get_MaximumLootSpawnCount()
        {
            if(0 == this.loot)
            {
                    return 2147483647;
            }
            
            if(this.loot != null)
            {
                    return this.loot.MaximumLootSpawnCount;
            }
            
            return this.loot.MaximumLootSpawnCount;
        }
        public TzarGames.TzarHero.TH_Character get_OwnerCharacter()
        {
            return (TzarGames.TzarHero.TH_Character)this.<OwnerCharacter>k__BackingField;
        }
        public void set_OwnerCharacter(TzarGames.TzarHero.TH_Character value)
        {
            this.<OwnerCharacter>k__BackingField = value;
        }
        public virtual bool CanActivateItem(TzarGames.GameFramework.ItemInstance itemInstance, int slot)
        {
            UnityEngine.Object val_6;
            var val_7;
            var val_8;
            val_6 = slot;
            if((this.activatedItems.TryGetValue(key:  itemInstance, value: out  0)) != false)
            {
                    val_7 = 0;
                if(0 == val_6)
            {
                    return (bool)val_7;
            }
            
            }
            
            val_6 = itemInstance.GetTemplateInstance();
            if((0 != val_6) && (val_6 != null))
            {
                    val_6 = val_6;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_8 = val_6;
                if((val_6 & 1) == 0)
            {
                    return (bool)val_7;
            }
            
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        public virtual bool CanDeactivateItem(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(this.activatedItems != null)
            {
                    return this.activatedItems.ContainsKey(key:  itemInstance);
            }
            
            return this.activatedItems.ContainsKey(key:  itemInstance);
        }
        public virtual int GetActivatedItemSlot(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            int val_1 = 0;
            return (int)((this.activatedItems.TryGetValue(key:  itemInstance, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public virtual void ActivateWeaponModificators(TzarGames.GameFramework.Weapon weapon, bool activate)
        {
            TzarGames.GameFramework.Characteristic val_1 = this.DamageCharacteristic;
            TzarGames.GameFramework.CharacteristicModificator val_2 = weapon.DamageModificator;
            if(activate != false)
            {
                    val_1.AddModificator(modificator:  val_2);
                this.AttackSpeedCharacteristic.AddModificator(modificator:  weapon.AttackSpeedModificator);
                return;
            }
            
            val_1.UnregisterModificator(modificator:  val_2);
            this.AttackSpeedCharacteristic.UnregisterModificator(modificator:  weapon.AttackSpeedModificator);
        }
        public virtual bool SetItemActive(TzarGames.GameFramework.ItemInstance itemInstance, bool active, int slot)
        {
            TzarGames.TzarHero.ItemActivationInfo val_21;
            TzarGames.GameFramework.CharacteristicModificator val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            if(active == false)
            {
                goto label_1;
            }
            
            if((this & 1) == 0)
            {
                goto label_14;
            }
            
            TzarGames.GameFramework.Item val_1 = itemInstance.GetTemplateInstance();
            val_1.AdditionalModificators.ApplyToTemplate(template:  this);
            val_23 = 1152921504910733312;
            val_24 = null;
            val_24 = null;
            goto label_13;
            label_1:
            if((this & 1) == 0)
            {
                goto label_14;
            }
            
            TzarGames.GameFramework.Item val_4 = itemInstance.GetTemplateInstance();
            if(val_4 == null)
            {
                goto label_27;
            }
            
            val_23 = 1152921504910733312;
            val_25 = null;
            val_25 = null;
            goto label_24;
            label_14:
            val_26 = 0;
            return (bool)val_26;
            label_13:
            val_23 = DefenceModificator;
            this.DefenceCharacteristic.AddModificator(modificator:  val_23);
            if(val_1 != null)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_27 = val_1;
            }
            
            itemInstance.Activated = true;
            this.activatedItems.Add(key:  itemInstance, value:  slot);
            TzarGames.GameFramework.InventoryBag val_11 = this.Inventory.GetBagOfItemInstance(itemInstance:  itemInstance);
            if(val_11 == null)
            {
                goto label_52;
            }
            
            val_11.LockItem(itemInstance:  itemInstance, locker:  this);
            goto label_53;
            label_24:
            val_23 = DefenceModificator;
            this.DefenceCharacteristic.UnregisterModificator(modificator:  val_23);
            label_27:
            if(val_4 != null)
            {
                    val_23 = null;
                var val_22 = 0;
                val_22 = val_22 + 1;
                val_28 = val_4;
            }
            
            val_4.AdditionalModificators.RemoveFromTemplate(template:  this);
            itemInstance.Activated = false;
            bool val_15 = this.activatedItems.Remove(key:  itemInstance);
            TzarGames.GameFramework.InventoryBag val_17 = this.Inventory.GetBagOfItemInstance(itemInstance:  itemInstance);
            if(val_17 == null)
            {
                goto label_52;
            }
            
            val_17.UnlockItem(itemInstance:  itemInstance, locker:  this);
            goto label_53;
            label_52:
            string val_18 = 0 + "No bag found for item ";
            UnityEngine.Debug.LogError(message:  0);
            label_53:
            TzarGames.TzarHero.ItemActivationInfo val_20 = null;
            val_21 = val_20;
            val_20 = new TzarGames.TzarHero.ItemActivationInfo(isActive:  active, slot:  slot);
            this.OnItemActivated.Invoke(arg0:  itemInstance, arg1:  val_21);
            val_26 = 1;
            return (bool)val_26;
        }
        public bool IsItemActivated(TzarGames.GameFramework.ItemInstance item)
        {
            if(this.activatedItems != null)
            {
                    return this.activatedItems.ContainsKey(key:  item);
            }
            
            return this.activatedItems.ContainsKey(key:  item);
        }
        public override void Initialize()
        {
            var val_11;
            this.Initialize();
            this.totalLoot = new System.Collections.Generic.List<TzarGames.GameFramework.Loot>();
            if(0 != this.loot)
            {
                    TzarGames.GameFramework.Loot[] val_3 = this.loot.Loots;
                if(val_3.Length >= 1)
            {
                    this.totalLoot.AddRange(collection:  this.loot.Loots);
            }
            
            }
            
            if((this.additionalLoot != null) && (this.additionalLoot.Length >= 1))
            {
                    this.totalLoot.AddRange(collection:  this.additionalLoot);
            }
            
            val_11 = 0;
            goto label_12;
            label_19:
            this.additionalLoot.AddRange(collection:  this.totalLoot);
            val_11 = 1;
            label_12:
            if(val_11 >= this.additionalLootInfos.Length)
            {
                goto label_14;
            }
            
            TzarGames.GameFramework.Loot[] val_5 = this.additionalLootInfos[1].Loots;
            if(this.totalLoot != null)
            {
                goto label_19;
            }
            
            goto label_19;
            label_14:
            this.Inventory.add_OnItemInstanceAdded(value:  new System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterTemplate::Inventory_OnItemInstanceAdded(TzarGames.GameFramework.InventoryBag inventoryBag, TzarGames.GameFramework.ItemInstance itemInstance)));
            this.Inventory.add_OnItemInstanceRemoved(value:  new System.Action<TzarGames.GameFramework.InventoryBag, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterTemplate::Inventory_OnItemInstanceRemoved(TzarGames.GameFramework.InventoryBag inventoryBag, TzarGames.GameFramework.ItemInstance itemInstance)));
            if(this.skills.Length < 1)
            {
                    return;
            }
            
            var val_12 = 0;
            do
            {
                TzarGames.TzarHero.Skills.CharacterSkill val_10 = this.GetSkillAtIndex(index:  0);
                val_12 = val_12 + 1;
            }
            while(this.skills.Length != val_12);
        
        }
        public override void ResetTemplate()
        {
            var val_4;
            this.ResetTemplate();
            this.activatedItems.Clear();
            this.Inventory.ResetInventory();
            val_4 = 0;
            goto label_3;
            label_8:
            val_4 = 1;
            label_3:
            if(val_4 >= this.skillInstanceList.Count)
            {
                    return;
            }
            
            if(this.skillInstanceList.Item[1] != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        private void Inventory_OnItemInstanceAdded(TzarGames.GameFramework.InventoryBag inventoryBag, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = itemInstance;
            val_11 = this;
            val_12 = 0;
            if(val_10.GetTemplateInstance() != null)
            {
                    val_12 = 0;
            }
            
            if(0 == )
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
            goto (TzarGames.GameFramework.Item.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Item.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 480;
        }
        private void Inventory_OnItemInstanceRemoved(TzarGames.GameFramework.InventoryBag inventoryBag, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = itemInstance;
            val_11 = this;
            val_12 = 0;
            if(val_10.GetTemplateInstance() != null)
            {
                    val_12 = 0;
            }
            
            if(0 == )
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
            goto (TzarGames.GameFramework.Item.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Item.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 496;
        }
        public TzarGames.TzarHero.Skills.CharacterSkill GetSkillInstanceById(int id)
        {
            var val_4;
            var val_5;
            val_4 = id;
            List.Enumerator<T> val_1 = this.skillInstanceList.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_5 = 0.InitializationCallback;
            if(val_5.Clone() != val_4)
            {
                goto label_4;
            }
            
            0.Dispose();
            return (TzarGames.TzarHero.Skills.CharacterSkill)val_5;
            label_2:
            0.Dispose();
            val_5 = 0;
            return (TzarGames.TzarHero.Skills.CharacterSkill)val_5;
        }
        public TzarGames.TzarHero.Skills.CharacterSkill GetSkillInstance(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            UnityEngine.Object val_6;
            var val_7;
            val_6 = skill;
            TzarGames.TzarHero.Skills.CharacterSkill val_3 = 0;
            if(0 == val_6)
            {
                    UnityEngine.Debug.LogError(message:  0);
                val_7 = 0;
                return (TzarGames.TzarHero.Skills.CharacterSkill)((this.skillInstances.TryGetValue(key:  val_6 = val_6.Id, value: out  val_3)) != true) ? (val_3) : 0;
            }
            
            return (TzarGames.TzarHero.Skills.CharacterSkill)((this.skillInstances.TryGetValue(key:  val_6, value: out  val_3)) != true) ? (val_3) : 0;
        }
        public System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Skills.CharacterSkill> GetSkills()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.TzarHero.Skills.CharacterSkill>)this.skillInstanceList;
        }
        public virtual void AddSkill(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            System.Collections.Generic.Dictionary<System.Int32, TzarGames.TzarHero.Skills.CharacterSkill> val_8;
            if(0 == skill)
            {
                    return;
            }
            
            val_8 = this.skillInstances;
            if((val_8.ContainsKey(key:  skill.Id)) != false)
            {
                    return;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_6 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            val_6.Start();
            val_6.SetCharacter(character:  this.<OwnerCharacter>k__BackingField);
            this.skillInstances.Add(key:  skill.Id, value:  val_6);
            this.skillInstanceList.Add(item:  val_6);
        }
        public virtual void RemoveSkill(TzarGames.TzarHero.Skills.CharacterSkill skill)
        {
            System.Collections.Generic.Dictionary<System.Int32, TzarGames.TzarHero.Skills.CharacterSkill> val_9;
            TzarGames.TzarHero.Skills.CharacterSkill val_4 = 0;
            if(0 == skill)
            {
                    return;
            }
            
            val_9 = this.skillInstances;
            if((val_9.TryGetValue(key:  skill.Id, value: out  val_4)) == false)
            {
                    return;
            }
            
            val_4.SetCharacter(character:  0);
            UnityEngine.Object.Destroy(obj:  0);
            val_9 = this.skillInstances;
            bool val_7 = val_9.Remove(key:  skill.Id);
            this = this.skillInstanceList;
            bool val_8 = this.Remove(item:  val_4);
        }
        public override void Update()
        {
            this.Update();
            float val_1 = UnityEngine.Time.deltaTime;
            int val_2 = this.skillInstanceList.Count;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                bool val_4 = this.skillInstanceList.Item[0].IsPerforming;
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
        
        }
    
    }

}
