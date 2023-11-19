using UnityEngine;

namespace TzarGames.Endless
{
    public static class ItemLevelRestrictionRemoval
    {
        // Fields
        private static CodeStage.AntiCheat.ObscuredTypes.ObscuredULong rubyCost;
        
        // Properties
        public static ulong RubyCost { get; }
        
        // Methods
        public static ulong get_RubyCost()
        {
            null = null;
            return (ulong)CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredULong() {inited = false, fakeValueActive = false});
        }
        public static TzarGames.Endless.PurchaseStatus RemoveItemLevelRestriction(TzarGames.Endless.ICharacterInfo characterInfo, TzarGames.Endless.EndlessPlayerCharacterTemplate template)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_10 = X2;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = 4;
            val_12 = template;
            val_13 = 1152921504866963456;
            if(template < TzarGames.Endless.ItemLevelRestrictionRemoval.RubyCost)
            {
                    val_14 = 2;
                return (TzarGames.Endless.PurchaseStatus)val_14;
            }
            
            val_13 = -TzarGames.Endless.ItemLevelRestrictionRemoval.RubyCost;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = 5;
            val_15 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            if(val_10 != 0)
            {
                    val_10.IsLevelRestrictionDisabled = true;
            }
            else
            {
                    0.IsLevelRestrictionDisabled = true;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.SetHeroData(data:  val_10.GetPlayerData());
            val_10 = TzarGames.Endless.EndlessGameState.Instance;
            val_10.SaveGame();
            val_14 = 0;
            return (TzarGames.Endless.PurchaseStatus)val_14;
        }
        private static ItemLevelRestrictionRemoval()
        {
            var val_2;
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            TzarGames.Endless.ItemLevelRestrictionRemoval.rubyCost.__il2cppRuntimeField_20 = val_2;
            TzarGames.Endless.ItemLevelRestrictionRemoval.rubyCost = val_4;
            TzarGames.Endless.ItemLevelRestrictionRemoval.rubyCost.__il2cppRuntimeField_10 = val_3;
        }
    
    }

}
