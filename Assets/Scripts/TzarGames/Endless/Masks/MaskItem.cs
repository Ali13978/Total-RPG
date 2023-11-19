using UnityEngine;

namespace TzarGames.Endless.Masks
{
    public class MaskItem : TH_Item, IBlockChanceItem
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite inactiveIcon;
        [UnityEngine.SerializeField]
        private bool addBlockChance;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator blockChanceModificator;
        
        // Properties
        public UnityEngine.Sprite InactiveIcon { get; }
        public float BlockChance { get; }
        
        // Methods
        public MaskItem()
        {
        
        }
        public UnityEngine.Sprite get_InactiveIcon()
        {
            return (UnityEngine.Sprite)this.inactiveIcon;
        }
        public float get_BlockChance()
        {
            if(this.blockChanceModificator != null)
            {
                    return this.blockChanceModificator.Value;
            }
            
            return this.blockChanceModificator.Value;
        }
        public override void OnAddedToInventory(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.InventoryBag bag, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            this.OnAddedToInventory(characterTemplate:  characterTemplate, bag:  bag, itemInstance:  itemInstance);
            itemInstance.ApplyToTemplate(template:  characterTemplate);
            if(characterTemplate == null)
            {
                    return;
            }
            
            if(this.addBlockChance == false)
            {
                    return;
            }
            
            characterTemplate.AddModificator(modificator:  this.blockChanceModificator);
        }
        public override void OnRemovedFromInventory(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.InventoryBag bag, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            this.OnRemovedFromInventory(characterTemplate:  characterTemplate, bag:  bag, itemInstance:  itemInstance);
            itemInstance.RemoveFromTemplate(template:  characterTemplate);
            if(characterTemplate == null)
            {
                    return;
            }
            
            if(this.addBlockChance == false)
            {
                    return;
            }
            
            characterTemplate.UnregisterModificator(modificator:  this.blockChanceModificator);
        }
    
    }

}
