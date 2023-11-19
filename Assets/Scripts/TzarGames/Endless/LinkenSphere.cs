using UnityEngine;

namespace TzarGames.Endless
{
    public class LinkenSphere : Charm<TzarGames.Endless.LinkenSphere.InfluenceCharmModificator>, IActivatedByCharacter
    {
        // Methods
        public LinkenSphere()
        {
        
        }
        protected override TzarGames.GameFramework.Characteristic getCharacteristic(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            var val_3;
            if(template != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            var val_2 = (((TzarGames.TzarHero.TH_CharacterTemplate.__il2cppRuntimeField_typeHierarchy + TzarGames.Endless.EndlessPlayerCharacterTemplate.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? template : 0;
            return (TzarGames.GameFramework.Characteristic)(TzarGames.TzarHero.TH_CharacterTemplate.__il2cppRuntimeField_typeHierarchy + TzarGames.Endless.EndlessPlayerCharacterTemplate.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_3 ? template : 0 + 368;
        }
    
    }

}
