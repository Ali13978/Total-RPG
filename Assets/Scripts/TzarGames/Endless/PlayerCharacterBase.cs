using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayerCharacterBase : TH_Character, IPlayerComponent
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClassInfo classes;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Items.ArmorSet fallbackArmorSet;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform armorSetContainer;
        private TzarGames.Endless.PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> weaponObject;
        private TzarGames.Endless.PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> secondWeaponObject;
        private TzarGames.Endless.PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> shieldObject;
        private TzarGames.Endless.PlayerCharacterBase.ItemPrefabInstance<TzarGames.Endless.Items.ArmorSetPrefab> armorSetPrefabInstance;
        private TzarGames.Endless.TrailFxController trailController;
        private TzarGames.GameFramework.CharacteristicModificator influenceModificator;
        private TzarGames.Endless.PlayerCharacterBase.ItemModificatorInfo blockChanceModificatorInfo;
        private TzarGames.TzarHero.Interfaces.IItemDatabaseProvider itemProvider;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.GameObject> OnEquipmentPrefabInstanceCreated;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.PlayerCharacterBase.ArmorSetChangedDelegate OnArmorSetChanged;
        
        // Properties
        public TzarGames.Endless.EndlessPlayerCharacterTemplate PlayerTemplateInstance { get; }
        public TzarGames.Endless.TrailFxController TrailController { get; }
        public TzarGames.GameFramework.Weapon SecondWeapon { get; }
        public TzarGames.Endless.Items.ArmorSetPrefab ArmorSetPrefabInstance { get; }
        public UnityEngine.GameObject FirstWeaponObject { get; }
        public UnityEngine.GameObject SecondWeaponObject { get; }
        
        // Methods
        public PlayerCharacterBase()
        {
        
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate get_PlayerTemplateInstance()
        {
            if(this.TemplateInstance == null)
            {
                    return (TzarGames.Endless.EndlessPlayerCharacterTemplate);
            }
            
            0 = 0;
            return (TzarGames.Endless.EndlessPlayerCharacterTemplate);
        }
        public TzarGames.Endless.TrailFxController get_TrailController()
        {
            return (TzarGames.Endless.TrailFxController)this.trailController;
        }
        public TzarGames.GameFramework.Weapon get_SecondWeapon()
        {
            var val_5;
            TzarGames.GameFramework.ItemInstance val_2 = this.PlayerTemplateInstance.ActiveSecondWeaponInstance;
            val_5 = 0;
            if(val_2 == null)
            {
                    return (TzarGames.GameFramework.Weapon);
            }
            
            val_5 = 0;
            if(val_2.GetTemplateInstance() == null)
            {
                    return (TzarGames.GameFramework.Weapon);
            }
            
            val_5 = 0;
            return (TzarGames.GameFramework.Weapon);
        }
        public TzarGames.Endless.Items.ArmorSetPrefab get_ArmorSetPrefabInstance()
        {
            if(this.armorSetPrefabInstance == null)
            {
                    return 0;
            }
            
            return (TzarGames.Endless.Items.ArmorSetPrefab)this;
        }
        public UnityEngine.GameObject get_FirstWeaponObject()
        {
            if(this.weaponObject == null)
            {
                    return 0;
            }
            
            return (UnityEngine.GameObject)this;
        }
        public UnityEngine.GameObject get_SecondWeaponObject()
        {
            if(this.secondWeaponObject == null)
            {
                    return 0;
            }
            
            return (UnityEngine.GameObject)this;
        }
        public void add_OnEquipmentPrefabInstanceCreated(System.Action<UnityEngine.GameObject> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnEquipmentPrefabInstanceCreated);
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
            while(this.OnEquipmentPrefabInstanceCreated != this.OnEquipmentPrefabInstanceCreated);
        
        }
        public void remove_OnEquipmentPrefabInstanceCreated(System.Action<UnityEngine.GameObject> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnEquipmentPrefabInstanceCreated);
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
            while(this.OnEquipmentPrefabInstanceCreated != this.OnEquipmentPrefabInstanceCreated);
        
        }
        public void add_OnArmorSetChanged(TzarGames.Endless.PlayerCharacterBase.ArmorSetChangedDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnArmorSetChanged);
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
            while(this.OnArmorSetChanged != this.OnArmorSetChanged);
        
        }
        public void remove_OnArmorSetChanged(TzarGames.Endless.PlayerCharacterBase.ArmorSetChangedDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnArmorSetChanged);
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
            while(this.OnArmorSetChanged != this.OnArmorSetChanged);
        
        }
        private void initEquipment()
        {
            if(this.PlayerTemplateInstance.ArmorSetItemInstance == null)
            {
                    UnityEngine.Debug.LogError(message:  0);
                this.PlayerTemplateInstance.Inventory.DefaultBag.AddNonconsumableItem(itemInstance:  this.fallbackArmorSet.CreateItemInstance());
                TzarGames.Endless.EndlessPlayerCharacterTemplate val_7 = this.PlayerTemplateInstance;
            }
            
            if(this.PlayerTemplateInstance.ShieldInstance != null)
            {
                    this.onActivateShield(itemInstance:  this.PlayerTemplateInstance.ShieldInstance, isActive:  true);
            }
            
            if(this.PlayerTemplateInstance.ActiveWeaponInstance != null)
            {
                    this.SetActiveWeaponInstance(weaponInstance:  this.PlayerTemplateInstance.ActiveWeaponInstance, slot:  0);
            }
            
            if(this.PlayerTemplateInstance.ActiveSecondWeaponInstance == null)
            {
                    return;
            }
            
            this.SetActiveWeaponInstance(weaponInstance:  this.PlayerTemplateInstance.ActiveSecondWeaponInstance, slot:  1);
        }
        protected override void Init()
        {
            System.Action<TzarGames.TzarHero.Interfaces.IInfluence> val_12;
            this.Init();
            this.influenceModificator = new TzarGames.GameFramework.CharacteristicModificator(value:  1f);
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_20 = 0;
            this.influenceModificator.ModificationMode = 0;
            this.influenceModificator.Operator = 2;
            this.add_OnInfluenceAdded(value:  new System.Action<TzarGames.TzarHero.Interfaces.IInfluence>(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterBase::PlayerCharacterBase_OnInfluenceAdded(TzarGames.TzarHero.Interfaces.IInfluence influence)));
            System.Action<TzarGames.TzarHero.Interfaces.IInfluence> val_3 = null;
            val_12 = val_3;
            val_3 = new System.Action<TzarGames.TzarHero.Interfaces.IInfluence>(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterBase::PlayerCharacterBase_OnInfluenceRemoved(TzarGames.TzarHero.Interfaces.IInfluence influence));
            this.add_OnInfluenceRemoved(value:  val_12);
            UnityEngine.GameObject val_4 = this.gameObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) != true)
            {
                    System.Action val_7 = null;
                val_12 = val_7;
                val_7 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterBase::EndlessGameState_OnLoadingSceneReady());
                TzarGames.Endless.EndlessGameState.add_OnLoadingSceneReady(value:  0);
            }
            
            if(0 == this.AnimBasedCombatSystem)
            {
                    return;
            }
            
            this.AnimBasedCombatSystem.add_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterBase::onAnimBasedAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animSystem)));
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            System.Action val_1 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterBase::EndlessGameState_OnLoadingSceneReady());
            TzarGames.Endless.EndlessGameState.remove_OnLoadingSceneReady(value:  0);
        }
        private void EndlessGameState_OnLoadingSceneReady()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) == true)
            {
                    return;
            }
            
            this = this.armorSetPrefabInstance.gameObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) == false)
            {
                    return;
            }
            
            this.transform.SetParent(parent:  0);
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public virtual void SetPlayerData(object data)
        {
            var val_7;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            TzarGames.TzarHero.Interfaces.IItemDatabaseProvider val_21;
            var val_22;
            val_17 = 0;
            if(data != null)
            {
                    val_17 = 0;
            }
            
            if(this.PlayerOwner == null)
            {
                goto label_22;
            }
            
            TzarGames.GameFramework.Player val_3 = this.PlayerOwner;
            if(val_3.NeighbourPlayers == null)
            {
                goto label_22;
            }
            
            TzarGames.GameFramework.Player val_4 = this.PlayerOwner;
            List.Enumerator<T> val_5 = val_4.NeighbourPlayers.GetEnumerator();
            label_18:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_8 = val_7.InitializationCallback;
            val_18 = 0;
            if(0 == )
            {
                goto label_18;
            }
            
            val_19 = 0;
            this.itemProvider = (mem[282584257676847] + (TzarGames.Endless.PlayerCharacterBase.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 0 : 0 + 792;
            goto label_19;
            label_9:
            val_19 = 0;
            label_19:
            val_20 = 1;
            val_7.Dispose();
            label_22:
            val_21 = this.itemProvider;
            if(val_21 != null)
            {
                goto label_23;
            }
            
            val_21 = TzarGames.Common.Utils.FindComponentOfType<TzarGames.TzarHero.Interfaces.IItemDatabaseProvider>();
            this.itemProvider = val_21;
            if(val_21 == null)
            {
                goto label_24;
            }
            
            label_23:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_22 = val_21;
            label_40:
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_14 = this.classes.GetClassTemplate(classType:  (System.Object.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessHeroData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? data : 0 + 20);
            if(0 == val_14)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.SetCharacterTemplate(template:  val_14);
            this.UnsubscribeFromTemplateEvents();
            this.PlayerTemplateInstance.SetPlayerData(playerData:  null, itemDatabase:  val_21);
            this.SubscribeToTemplateEvents();
            this.initEquipment();
            return;
            label_24:
            UnityEngine.Debug.LogError(message:  0);
            goto label_40;
        }
        public virtual void FillNetData(TzarGames.Endless.EndlessHeroData data)
        {
            bool val_2 = this.isDead;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            data.Net_IsDead = val_3;
            mem2[0] = val_3.inited;
            mem[1] = val_3.fakeValue;
            mem[2] = val_3.fakeValueActive;
        }
        public virtual object GetPlayerData()
        {
            return (object)this.PlayerTemplateInstance.GetPlayerData();
        }
        public virtual byte[] GetPlayerDataAsBytes()
        {
            if(this == null)
            {
                    return TzarGames.Endless.EndlessHeroData.GetBytesFromData(data:  0);
            }
            
            return TzarGames.Endless.EndlessHeroData.GetBytesFromData(data:  0);
        }
        public virtual void SetPlayerDataFromBytes(byte[] data)
        {
            var val_6;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = data;
            val_9 = this;
            if((val_8 == null) || (data.Length == 0))
            {
                goto label_2;
            }
            
            if((TzarGames.Endless.EndlessHeroData.GetDataFromBytes(bytes:  0)) == null)
            {
                goto label_3;
            }
            
            val_10 = ???;
            val_9 = ???;
            val_11 = ???;
            goto typeof(TzarGames.Endless.PlayerCharacterBase).__il2cppRuntimeField_510;
            label_2:
            val_6 = val_10 - 32;
            val_12 = mem[(val_10 - 32) + 32];
            val_12 = (val_10 - 32) + 32;
            val_8 = mem[(val_10 - 32) + 16];
            val_8 = (val_10 - 32) + 16;
            val_13 = mem[(val_10 - 32) + 8];
            val_13 = (val_10 - 32) + 8;
            label_3:
            var val_2 = ((val_10 - 32) + 48) + 12;
            mem2[0] = (val_10 - 32) + 16 + 24;
            var val_3 = val_12 - 32;
        }
        protected override void OnActiveWeaponInstanceChanged(TzarGames.GameFramework.ItemInstance weaponInstance, bool activated, int slot)
        {
            UnityEngine.GameObject val_9;
            UnityEngine.Object val_10;
            PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> val_11;
            val_9 = 0;
            if(weaponInstance.GetTemplateInstance() != null)
            {
                    val_9 = 0;
            }
            
            val_10 = 1152921504721543168;
            if(0 == )
            {
                    return;
            }
            
            PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> val_5 = (slot != 0) ? this.secondWeaponObject : this.weaponObject;
            if(val_5 != 0)
            {
                    this.attachWeapon(wobj:  val_5, slot:  slot, attach:  false);
                val_10 = mem[slot != 0 ? this.secondWeaponObject : this.weaponObject + 24];
                val_10 = slot != 0 ? this.secondWeaponObject : this.weaponObject + 24;
                bool val_6 = UnityEngine.Object.op_Inequality(x:  0, y:  val_10);
                if(val_6 != false)
            {
                    val_6.destroyEquipment(obj:  slot != 0 ? this.secondWeaponObject : this.weaponObject + 24);
            }
            
            }
            
            if(activated != false)
            {
                    val_9 = val_6.instantiateEquipment(prefab:  (TzarGames.GameFramework.Item.__il2cppRuntimeField_typeHierarchy + (TzarGames.GameFramework.Weapon.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 72);
                PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> val_8 = null;
                val_11 = val_8;
                val_8 = new PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject>(itemInstance:  weaponInstance, prefabInstance:  val_9, playerCharacter:  this);
                this.attachWeapon(wobj:  val_11, slot:  slot, attach:  true);
            }
            else
            {
                    val_11 = 0;
            }
            
            if(slot != 0)
            {
                    mem2[0] = val_11;
                return;
            }
            
            mem2[0] = val_11;
        }
        private UnityEngine.GameObject instantiateEquipment(UnityEngine.GameObject prefab)
        {
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  0)) == false)
            {
                    return UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            return TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, parent:  prefab);
        }
        private void destroyEquipment(UnityEngine.GameObject obj)
        {
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) != false)
            {
                    TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  0);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void checkArmorSet()
        {
        
        }
        private void removeActiveShield()
        {
            if(this.shieldObject == null)
            {
                    return;
            }
            
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  34799616);
            if(val_1 != false)
            {
                    val_1.destroyEquipment(obj:  34799616);
            }
            
            this.shieldObject = 0;
        }
        private void onActivateShield(TzarGames.GameFramework.ItemInstance itemInstance, bool isActive)
        {
            if(isActive == false)
            {
                goto label_1;
            }
            
            this.removeActiveShield();
            TzarGames.GameFramework.Item val_1 = itemInstance.GetTemplateInstance();
            TzarGames.GameFramework.CharacteristicModificator val_3 = new TzarGames.GameFramework.CharacteristicModificator(value:  0.BlockChance);
            if(null == 0)
            {
                goto label_6;
            }
            
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_20 = 0;
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_10 = 0;
            goto label_7;
            label_1:
            if((this.blockChanceModificatorInfo != null) && ((this.blockChanceModificatorInfo.<ItemInstance>k__BackingField) == itemInstance))
            {
                    this.PlayerTemplateInstance.BlockChanceCharacteristic.UnregisterModificator(modificator:  this.blockChanceModificatorInfo.<Modificator>k__BackingField);
                this.blockChanceModificatorInfo = 0;
            }
            
            if((this.blockChanceModificatorInfo.<ItemInstance>k__BackingField) == itemInstance)
            {
                goto label_14;
            }
            
            return;
            label_6:
            mem[32] = 0;
            mem[16] = 0;
            label_7:
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 3;
            if(this.blockChanceModificatorInfo != null)
            {
                    this.PlayerTemplateInstance.BlockChanceCharacteristic.UnregisterModificator(modificator:  this.blockChanceModificatorInfo.<Modificator>k__BackingField);
            }
            
            typeof(PlayerCharacterBase.ItemModificatorInfo).__il2cppRuntimeField_10 = itemInstance;
            typeof(PlayerCharacterBase.ItemModificatorInfo).__il2cppRuntimeField_18 = val_3;
            this.blockChanceModificatorInfo = new System.Object();
            TzarGames.GameFramework.Characteristic val_10 = this.PlayerTemplateInstance.BlockChanceCharacteristic;
            val_10.AddModificator(modificator:  val_3);
            this.shieldObject = new PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject>(itemInstance:  itemInstance, prefabInstance:  val_10.instantiateEquipment(prefab:  0), playerCharacter:  this);
            this.attachShield(attach:  true);
            return;
            label_14:
            this.removeActiveShield();
        }
        private void onActivateArmorSet(TzarGames.GameFramework.ItemInstance itemInstance, bool isActive)
        {
            TzarGames.GameFramework.ItemInstance val_28;
            PlayerCharacterBase.ItemPrefabInstance<TzarGames.Endless.Items.ArmorSetPrefab> val_29;
            TzarGames.Endless.Items.ArmorSetPrefab val_30;
            var val_31;
            TzarGames.Endless.Items.ArmorSetPrefab val_32;
            val_28 = itemInstance;
            val_29 = this.armorSetPrefabInstance;
            if(val_29 != null)
            {
                
            }
            else
            {
                    val_30 = 0;
            }
            
            if(isActive == false)
            {
                goto label_3;
            }
            
            TzarGames.GameFramework.Item val_1 = val_28.GetTemplateInstance();
            this.removeActiveArmorSet();
            UnityEngine.GameObject val_3 = 0.ArmorSetPrefab.gameObject;
            UnityEngine.GameObject val_4 = val_3.instantiateEquipment(prefab:  val_3);
            TzarGames.Endless.Items.ArmorSetPrefab val_5 = val_4.GetComponent<TzarGames.Endless.Items.ArmorSetPrefab>();
            val_31 = 0;
            if(val_5.CharacterAnimation == null)
            {
                goto label_13;
            }
            
            val_31 = 0;
            goto label_13;
            label_3:
            if(true != val_28)
            {
                goto label_48;
            }
            
            this.removeActiveArmorSet();
            goto label_48;
            label_13:
            if(0 != )
            {
                    AnimatorComponent.runtimeAnimatorController = this.PlayerTemplateInstance.AnimatorController;
            }
            
            this.trailController = val_5.GetComponent<TzarGames.Endless.TrailFxController>();
            this.armorSetPrefabInstance = new PlayerCharacterBase.ItemPrefabInstance<TzarGames.Endless.Items.ArmorSetPrefab>(itemInstance:  val_28, prefabInstance:  val_5, playerCharacter:  this);
            val_29 = val_4.transform;
            val_29.SetParent(parent:  this.armorSetContainer);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.identity;
            val_4.transform.localRotation = new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w};
            if(this.weaponObject != null)
            {
                    this.attachWeapon(wobj:  this.weaponObject, slot:  0, attach:  true);
            }
            
            if(this.secondWeaponObject != null)
            {
                    this.attachWeapon(wobj:  this.secondWeaponObject, slot:  1, attach:  true);
            }
            
            this.attachShield(attach:  true);
            if(0 == this.armorSetPrefabInstance.CharacterAnimation)
            {
                goto label_40;
            }
            
            this.Animation = this.armorSetPrefabInstance.CharacterAnimation;
            val_28 = this.AnimBasedCombatSystem;
            if(0 == val_28)
            {
                goto label_48;
            }
            
            val_28 = this.Animation.GetComponent<UnityEngine.Animator>();
            this.AnimBasedCombatSystem.SetAnimator(newAnimator:  val_28);
            goto label_48;
            label_40:
            val_28 = 0 + "CharacterAnimation is null on ";
            UnityEngine.Debug.LogError(message:  0);
            label_48:
            if(this.OnArmorSetChanged == null)
            {
                    return;
            }
            
            if(this.armorSetPrefabInstance != null)
            {
                
            }
            else
            {
                    val_32 = 0;
            }
            
            this.OnArmorSetChanged.Invoke(oldSet:  val_30, newSet:  val_32);
        }
        private void removeActiveArmorSet()
        {
            this.attachShield(attach:  false);
            this.attachWeapon(wobj:  this.weaponObject, slot:  0, attach:  false);
            this.attachWeapon(wobj:  this.secondWeaponObject, slot:  1, attach:  false);
            this.Animation = 0;
            if(0 != this.AnimBasedCombatSystem)
            {
                    TzarGames.TzarHero.AnimationBasedCombatSystem val_3 = this.AnimBasedCombatSystem;
                val_3.SetAnimator(newAnimator:  0);
            }
            
            if(this.armorSetPrefabInstance != null)
            {
                    if(0 != val_3)
            {
                    UnityEngine.GameObject val_5 = this.armorSetPrefabInstance.gameObject;
                val_5.destroyEquipment(obj:  val_5);
            }
            
                this.armorSetPrefabInstance = 0;
            }
            
            if(0 == this.trailController)
            {
                    return;
            }
            
            this.trailController.RemoveAllTrails();
            this.trailController = 0;
        }
        private void attachShield(bool attach)
        {
            if(this.shieldObject == null)
            {
                    return;
            }
            
            if(0 == 34799616)
            {
                    return;
            }
            
            if(attach == false)
            {
                goto label_5;
            }
            
            if(0 == this.armorSetPrefabInstance)
            {
                goto label_9;
            }
            
            UnityEngine.Transform val_3 = this.shieldObject.transform;
            val_3.SetParent(parent:  this.armorSetPrefabInstance.ShieldSocket);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_3.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            return;
            label_5:
            this.shieldObject.transform.SetParent(parent:  0);
            return;
            label_9:
            UnityEngine.Debug.LogError(message:  0);
        }
        private void attachWeapon(TzarGames.Endless.PlayerCharacterBase.ItemPrefabInstance<UnityEngine.GameObject> wobj, int slot, bool attach)
        {
            TzarGames.Endless.TrailFxController val_14;
            TzarGames.Endless.TrailFxController val_16;
            val_14 = attach;
            if(wobj == null)
            {
                    return;
            }
            
            if(0 == 34799616)
            {
                    return;
            }
            
            if(val_14 == false)
            {
                goto label_5;
            }
            
            if(0 == 34799616)
            {
                goto label_9;
            }
            
            UnityEngine.Transform val_3 = this.armorSetPrefabInstance.transform;
            if(slot == 0)
            {
                goto label_12;
            }
            
            UnityEngine.Transform val_4 = LeftHandWeaponSocket;
            goto label_13;
            label_5:
            val_16 = this.trailController;
            if(0 != val_16)
            {
                    TzarGames.Endless.TrailFxBehaviour val_6 = val_16.GetComponent<TzarGames.Endless.TrailFxBehaviour>();
                val_16 = this.trailController;
                val_16.RemoveTrail(trailFx:  val_6);
            }
            
            val_6.transform.SetParent(parent:  0);
            return;
            label_9:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_12:
            label_13:
            val_3.SetParent(parent:  RightHandWeaponSocket);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            val_3.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            val_14 = this.trailController;
            if(0 == val_14)
            {
                    return;
            }
            
            this.trailController.AddTrail(trailFx:  wobj.GetComponent<TzarGames.Endless.TrailFxBehaviour>());
        }
        protected override void OnItemActivated(TzarGames.GameFramework.ItemInstance itemInstance, TzarGames.TzarHero.ItemActivationInfo info)
        {
            this.OnItemActivated(itemInstance:  itemInstance, info:  info);
            if(itemInstance.GetTemplateInstance() == null)
            {
                    return;
            }
        
        }
        private void PlayerCharacterBase_OnInfluenceAdded(TzarGames.TzarHero.Interfaces.IInfluence influence)
        {
            var val_5;
            if(influence == null)
            {
                    return;
            }
            
            float val_2 = this.PlayerTemplateInstance.InfluenceResistance;
            val_2 = val_2 / (-100f);
            this.influenceModificator.Value = val_2 + 1f;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = influence;
            influence.AddModificator(modificator:  this.influenceModificator);
        }
        private void PlayerCharacterBase_OnInfluenceRemoved(TzarGames.TzarHero.Interfaces.IInfluence influence)
        {
            var val_2;
            if(influence == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = influence;
            influence.UnregisterModificator(modificator:  this.influenceModificator);
        }
        protected override float CalculateFinalStunTime(float originalStunTime)
        {
            float val_3 = this.PlayerTemplateInstance.InfluenceResistance;
            val_3 = val_3 / (-100f);
            val_3 = val_3 + 1f;
            val_3 = (this.CalculateFinalStunTime(originalStunTime:  originalStunTime)) * val_3;
            return (float)val_3;
        }
        public virtual void SetupForServer(TzarGames.GameFramework.Player owner)
        {
            goto typeof(TzarGames.Endless.PlayerCharacterBase).__il2cppRuntimeField_190;
        }
        public virtual void SetupForLocalOrClient(TzarGames.GameFramework.Player owner)
        {
            goto typeof(TzarGames.Endless.PlayerCharacterBase).__il2cppRuntimeField_190;
        }
        public override void SetPlayerOwner(TzarGames.GameFramework.Player owner)
        {
            this.SetPlayerOwner(player:  owner);
            if((owner != null) && (owner.itsMe != false))
            {
                    if(this.OnServer != false)
            {
                    mem[1152921510763130068] = 0;
            }
            
            }
            
            this.SetNetworkInstantiatedFlag(netInstantiated:  true);
        }
        public void SetActive(bool active)
        {
            active = (~active) & 1;
            this.SetImmobilizedState(immobilized:  active);
        }
        public void Respawn(UnityEngine.Vector3 spawnPosition, UnityEngine.Quaternion spawnRotation)
        {
            this.ResetToDefaultState();
            this.TemplateInstance.ActualHitPoints = this.TemplateInstance.HitPoints;
            this.Position = new UnityEngine.Vector3() {x = spawnPosition.x, y = spawnPosition.y, z = spawnPosition.z};
            this.transform.rotation = new UnityEngine.Quaternion() {x = spawnRotation.x, y = spawnRotation.y, z = spawnRotation.z, w = spawnRotation.w};
        }
        public void SetImmobilizedState(bool immobilized)
        {
            State val_1 = this.CurrentState;
            if(immobilized != false)
            {
                    this.CurrentState.ForceGotoState<PlayerCharacterBase.Immobilized>(stateData:  0);
                return;
            }
            
            this.ResetToDefaultState();
        }
        protected override void OnAttackStateEnd()
        {
            this.OnAttackStateEnd();
            this.disableTrails();
        }
        private void onAnimBasedAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem animSystem)
        {
            this.disableTrails();
        }
        private void disableTrails()
        {
            if(0 == this.trailController)
            {
                    return;
            }
            
            this.trailController.DeactivateAndResetTrails();
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            if(this.weaponObject != null)
            {
                    this.destroyEquipment(obj:  0);
                this.weaponObject = 0;
            }
            
            if(this.secondWeaponObject != null)
            {
                    this.destroyEquipment(obj:  0);
                this.secondWeaponObject = 0;
            }
            
            if(this.shieldObject != null)
            {
                    this.destroyEquipment(obj:  0);
                this.shieldObject = 0;
            }
            
            if(this.armorSetPrefabInstance != null)
            {
                    UnityEngine.GameObject val_1 = X20.gameObject;
                val_1.destroyEquipment(obj:  val_1);
                this.armorSetPrefabInstance = 0;
            }
            
            if(this.influenceModificator != null)
            {
                    this.influenceModificator.Clear();
            }
            
            if(this.itemProvider == null)
            {
                    return;
            }
            
            this.itemProvider = 0;
        }
    
    }

}
