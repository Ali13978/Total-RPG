using UnityEngine;

namespace TzarGames.Endless
{
    public static class GoldExchange
    {
        // Fields
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SmallGoldPackAmount;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt MediumGoldPackAmount;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt HugeGoldPackAmount;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SmallGoldPackRubyCost;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt MediumGoldPackRubyCost;
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredInt HugeGoldPackRubyCost;
        
        // Methods
        public static int GetGoldForOneRuby()
        {
            null = null;
            int val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = false, fakeValue = 268435457, fakeValueActive = false});
            val_2 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {inited = true, fakeValue = 268435457, fakeValueActive = false})) / val_2;
            return (int)val_2;
        }
        public static void BuyGoldPack(TzarGames.Endless.GoldPackTypes packType, TzarGames.Endless.EndlessPlayerCharacterTemplate playerTemplateInstance, System.Action<bool> resultCallback)
        {
            if(((playerTemplateInstance < 3) ? (playerTemplateInstance + 3) : 0) > 5)
            {
                    return;
            }
            
            var val_16 = 25804296 + (val_17 < 0x3 ? (playerTemplateInstance + 3) : 0) << 2;
            val_16 = val_16 + 25804296;
            goto (25804296 + (val_17 < 0x3 ? (playerTemplateInstance + 3) : 0) << 2 + 25804296);
        }
        private static GoldExchange()
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6;
            var val_8;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9;
            var val_11;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12;
            var val_14;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_15;
            var val_17;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_18;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount.__il2cppRuntimeField_10 = val_2;
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount.__il2cppRuntimeField_24 = val_5;
            TzarGames.Endless.GoldExchange.MediumGoldPackAmount = val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount.__il2cppRuntimeField_38 = val_8;
            TzarGames.Endless.GoldExchange.HugeGoldPackAmount = val_9;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount.__il2cppRuntimeField_4C = val_11;
            TzarGames.Endless.GoldExchange.SmallGoldPackRubyCost = val_12;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_13 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount.__il2cppRuntimeField_60 = val_14;
            TzarGames.Endless.GoldExchange.MediumGoldPackRubyCost = val_15;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
            TzarGames.Endless.GoldExchange.SmallGoldPackAmount.__il2cppRuntimeField_74 = val_17;
            TzarGames.Endless.GoldExchange.HugeGoldPackRubyCost = val_18;
        }
    
    }

}
