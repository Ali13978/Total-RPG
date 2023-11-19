using UnityEngine;

namespace TzarGames.Endless.Masks
{
    public class MaskRewarder : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Masks.MaskRewardInfo maskRewardInfo;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.ItemEvent onMaskTaken;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Dropped <SpawnedMask>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Dropped SpawnedMask { get; set; }
        
        // Methods
        public MaskRewarder()
        {
        
        }
        public TzarGames.TzarHero.TH_Dropped get_SpawnedMask()
        {
            return (TzarGames.TzarHero.TH_Dropped)this.<SpawnedMask>k__BackingField;
        }
        private void set_SpawnedMask(TzarGames.TzarHero.TH_Dropped value)
        {
            this.<SpawnedMask>k__BackingField = value;
        }
        public void SpawnRandomMaskForLocalPlayer(UnityEngine.Transform position)
        {
            var val_13;
            var val_14;
            val_13 = position;
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 != (this.<SpawnedMask>k__BackingField))
            {
                    this.unregisterMaskEvents(behaviour:  this.<SpawnedMask>k__BackingField);
            }
            
            TzarGames.GameFramework.GameManager val_4 = val_1.MyGameManager;
            UnityEngine.Vector3 val_5 = val_13.position;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            if(val_4 != null)
            {
                    val_13 = 1152921504923992064;
                val_14 = null;
                val_14 = null;
                var val_7 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_GameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_14) ? (val_4) : 0;
            }
            
            TzarGames.TzarHero.TH_Dropped val_8 = 0.SpawnLoot(item:  this.GetRandomAvailableMaskItem(character:  val_1), position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, sessionID:  val_1, dropper:  0);
            this.<SpawnedMask>k__BackingField = val_8;
            val_8.GetComponent<UnityEngine.Collider>().enabled = false;
            this.<SpawnedMask>k__BackingField.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.Masks.MaskRewarder::unregisterMaskEvents(TzarGames.GameFramework.TzarBehaviour behaviour)));
            this.<SpawnedMask>k__BackingField.OnItemTaken.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.ITakeItemEvent>(object:  this, method:  System.Void TzarGames.Endless.Masks.MaskRewarder::SpawnedMask_OnItemTaken(TzarGames.GameFramework.ITakeItemEvent arg0)));
        }
        private void SpawnedMask_OnItemTaken(TzarGames.GameFramework.ITakeItemEvent arg0)
        {
            var val_3;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = arg0;
            this.onMaskTaken.Invoke(arg0:  arg0.GetTemplateInstance());
        }
        private void unregisterMaskEvents(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            var val_5;
            if(behaviour != null)
            {
                    val_5 = null;
                val_5 = null;
                var val_1 = (((TzarGames.GameFramework.TzarBehaviour.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.TH_Dropped.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_5) ? behaviour : 0;
            }
            
            0.OnItemTaken.RemoveListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.ITakeItemEvent>(object:  this, method:  System.Void TzarGames.Endless.Masks.MaskRewarder::SpawnedMask_OnItemTaken(TzarGames.GameFramework.ITakeItemEvent arg0)));
            behaviour.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.Masks.MaskRewarder::unregisterMaskEvents(TzarGames.GameFramework.TzarBehaviour behaviour)));
        }
        [UnityEngine.ContextMenu]
        public void ActivateSpawnedMask()
        {
            if(0 == (this.<SpawnedMask>k__BackingField))
            {
                    return;
            }
            
            this.<SpawnedMask>k__BackingField.GetComponent<UnityEngine.Collider>().enabled = true;
        }
        public TzarGames.Endless.Masks.MaskItem GetRandomAvailableMaskItem(TzarGames.TzarHero.TH_Character character)
        {
            var val_17;
            TzarGames.Endless.Masks.MaskRewardInfo val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_17 = character;
            val_18 = this;
            val_19 = 0;
            val_20 = 0;
            if(0 == )
            {
                    return (TzarGames.Endless.Masks.MaskItem)val_20;
            }
            
            System.Collections.Generic.List<TzarGames.Endless.Masks.MaskItem> val_4 = null;
            val_17 = val_4;
            val_4 = new System.Collections.Generic.List<TzarGames.Endless.Masks.MaskItem>();
            val_18 = this.maskRewardInfo;
            val_21 = 0;
            goto label_8;
            label_15:
            val_21 = 1;
            label_8:
            if(val_21 >= this.maskRewardInfo.maskGroups.Length)
            {
                goto label_10;
            }
            
            MaskGroup val_17 = this.maskRewardInfo.maskGroups[1];
            val_22 = 0;
            goto label_12;
            label_20:
            Add(item:  1);
            val_22 = 1;
            label_12:
            if(val_22 >= this.maskRewardInfo.maskGroups[0x1][0].Masks.Length)
            {
                goto label_15;
            }
            
            TzarGames.Endless.Masks.MaskItem val_18 = this.maskRewardInfo.maskGroups[0x1][0].Masks[1];
            if(null != 0)
            {
                goto label_20;
            }
            
            goto label_20;
            label_10:
            val_23 = 0;
            goto label_25;
            label_38:
            val_23 = 1;
            label_25:
            if(val_23 >= val_8.Length)
            {
                goto label_27;
            }
            
            int val_10 = Count - 1;
            if((val_10 & 2147483648) != 0)
            {
                goto label_38;
            }
            
            do
            {
                if(Item[val_10] == (PlayerTemplateInstance.Inventory.GetBagByName(bagName:  "MASKS_BAG").GetAllNonconsumableItems()[1].GetOriginalTemplate()))
            {
                    RemoveAt(index:  val_10);
            }
            
                val_10 = val_10 - 1;
            }
            while((val_10 & 2147483648) == 0);
            
            goto label_38;
            label_27:
            if(Count != 0)
            {
                    int val_14 = Count;
                TzarGames.Endless.Masks.MaskItem val_16 = Item[UnityEngine.Random.Range(min:  0, max:  0)];
                return (TzarGames.Endless.Masks.MaskItem)val_20;
            }
            
            val_20 = 0;
            return (TzarGames.Endless.Masks.MaskItem)val_20;
        }
        public void RewardPlayerCharacter(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.Endless.Masks.MaskItem val_1 = this.GetRandomAvailableMaskItem(character:  character);
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.GameFramework.ItemInstance val_4 = val_1.CreateItemInstance();
            bool val_5 = character.TakeItem(itemInstance:  val_4, dropperInfo:  0);
            this.onMaskTaken.Invoke(arg0:  val_4.GetTemplateInstance());
        }
        public void HandleCharacterDeathAndReward(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            if(0 == deadEventData.Killer)
            {
                    UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            this.RewardPlayerCharacter(character:  deadEventData.Killer);
        }
    
    }

}
