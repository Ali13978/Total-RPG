using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class BlockChanceCharm : Charm<TzarGames.Endless.BlockChanceCharm.BlockChanceCharmModificator>
    {
        // Methods
        public BlockChanceCharm()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            var val_2;
            if(template == null)
            {
                    return 0.BlockChanceCharacteristic;
            }
            
            val_2 = null;
            val_2 = null;
            var val_1 = (((TzarGames.TzarHero.TH_CharacterTemplate.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessPlayerCharacterTemplate.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_2) ? template : 0;
            return 0.BlockChanceCharacteristic;
        }
    
    }

}
