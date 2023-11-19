using UnityEngine;

namespace TzarGames.Endless
{
    public class SingleActivableItem : Item, IActivatedByCharacter
    {
        // Methods
        public SingleActivableItem()
        {
        
        }
        public virtual bool CanBeActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_9;
            var val_10;
            var val_11;
            return false;
            label_8:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            if((characterTemplate.IsItemActivated(item:  0.InitializationCallback)) == false)
            {
                goto label_8;
            }
            
            val_9 = 0;
            val_10 = 0;
            goto label_9;
            label_7:
            val_9 = 0;
            val_10 = 11;
            label_9:
            val_11 = 1;
            0.Dispose();
            var val_8 = (11 == 11) ? 1 : 0;
            return false;
        }
        public virtual void OnActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
        
        }
        public virtual void OnDeactivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
        
        }
    
    }

}
