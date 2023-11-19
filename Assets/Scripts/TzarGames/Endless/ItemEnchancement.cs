using UnityEngine;

namespace TzarGames.Endless
{
    public static class ItemEnchancement
    {
        // Fields
        public const float CostGrowRateDefault = 20;
        public const float ArmorCostGrowRateDefault = 20;
        public const float DefenceCoefficientDefault = 1;
        public const float DamageCoefficientDefault = 1;
        private static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat costGrowRate;
        private static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat armorCostGrowRate;
        private static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat damageCoefficient;
        private static CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat defenceCoefficient;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.GameFramework.Item <RequiredItemTemplate>k__BackingField;
        private static System.Collections.Generic.Dictionary<string, TzarGames.GameFramework.CharacteristicModificator> modificators;
        
        // Properties
        public static TzarGames.GameFramework.Item RequiredItemTemplate { get; set; }
        
        // Methods
        public static TzarGames.GameFramework.Item get_RequiredItemTemplate()
        {
            null = null;
            return (TzarGames.GameFramework.Item)TzarGames.Endless.ItemEnchancement.<RequiredItemTemplate>k__BackingField;
        }
        public static void set_RequiredItemTemplate(TzarGames.GameFramework.Item value)
        {
            null = null;
            TzarGames.Endless.ItemEnchancement.<RequiredItemTemplate>k__BackingField = X1;
        }
        public static void SetCostGrowRate(float rate)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2;
            var val_3;
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  rate);
            val_4 = null;
            val_4 = null;
            TzarGames.Endless.ItemEnchancement.costGrowRate = val_2;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_10 = val_3;
        }
        public static void SetArmorCostGrowRate(float rate)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2;
            var val_3;
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  rate);
            val_4 = null;
            val_4 = null;
            TzarGames.Endless.ItemEnchancement.armorCostGrowRate = val_2;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_30 = val_3;
        }
        public static void SetDamageCoefficient(float coeff)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2;
            var val_3;
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  coeff);
            val_4 = null;
            val_4 = null;
            TzarGames.Endless.ItemEnchancement.damageCoefficient = val_2;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_50 = val_3;
        }
        public static void SetDefenceCoefficient(float coeff)
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2;
            var val_3;
            var val_4;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  coeff);
            val_4 = null;
            val_4 = null;
            TzarGames.Endless.ItemEnchancement.defenceCoefficient = val_2;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_70 = val_3;
        }
        private static TzarGames.GameFramework.CharacteristicModificator createWeaponDamageModificator(uint level)
        {
            if(null != 0)
            {
                    typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_10 = 0;
            }
            else
            {
                    mem[16] = 0;
            }
            
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 1;
            TzarGames.Endless.ItemEnchancement.updateWeaponDamageModificator(modificator:  null, level:  300105728);
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.GameFramework.CharacteristicModificator();
        }
        private static void updateWeaponDamageModificator(TzarGames.GameFramework.CharacteristicModificator modificator, uint level)
        {
            float val_2 = 0.1f;
            val_2 = (float)(double)W2 * val_2;
            level.Value = val_2 + 1f;
        }
        public static float GetWeaponModificatorValue(uint level)
        {
            float val_1 = 0.1f;
            val_1 = (float)(double)W1 * val_1;
            val_1 = val_1 + 1f;
            return (float)val_1;
        }
        public static float GetWeaponDamageForNextLevel(TzarGames.GameFramework.ItemInstance instance)
        {
            TzarGames.GameFramework.ItemInstance val_9;
            TzarGames.GameFramework.Item val_1 = X1.GetTemplateInstance();
            val_9 = 0;
            uint val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            TzarGames.GameFramework.ItemInstance val_10 = null;
            val_9 = val_10;
            TzarGames.GameFramework.CharacteristicModificator val_3 = TzarGames.Endless.ItemEnchancement.getModificatorForItem(itemInstance:  val_9);
            val_9 = val_9 + 1;
            val_10 = 0.DamageModificator.HasModificator(modificator:  val_3);
            if(val_10 != true)
            {
                    0.DamageModificator.AddModificator(modificator:  val_3);
            }
            
            TzarGames.Endless.ItemEnchancement.updateWeaponDamageModificator(modificator:  null, level:  val_3);
            TzarGames.Endless.ItemEnchancement.updateWeaponDamageModificator(modificator:  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}), level:  val_3);
            return (float)0.Damage;
        }
        private static TzarGames.GameFramework.CharacteristicModificator createArmorDefenceModificator(uint level)
        {
            if(null != 0)
            {
                    typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_10 = 0;
            }
            else
            {
                    mem[16] = 0;
            }
            
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 1;
            TzarGames.Endless.ItemEnchancement.updateArmorDefenceModificator(modificator:  null, level:  300105728);
            return (TzarGames.GameFramework.CharacteristicModificator)new TzarGames.GameFramework.CharacteristicModificator();
        }
        private static void updateArmorDefenceModificator(TzarGames.GameFramework.CharacteristicModificator modificator, uint level)
        {
            float val_2 = 0.1f;
            val_2 = (float)(double)W2 * val_2;
            level.Value = val_2 + 1f;
        }
        public static float GetArmorModificatorValue(uint level)
        {
            float val_1 = 0.1f;
            val_1 = (float)(double)W1 * val_1;
            val_1 = val_1 + 1f;
            return (float)val_1;
        }
        public static float GetArmorDefenceForNextLevel(TzarGames.GameFramework.ItemInstance instance)
        {
            TzarGames.GameFramework.ItemInstance val_9;
            TzarGames.GameFramework.Item val_1 = X1.GetTemplateInstance();
            val_9 = 0;
            uint val_9 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            TzarGames.GameFramework.ItemInstance val_10 = null;
            val_9 = val_10;
            TzarGames.GameFramework.CharacteristicModificator val_3 = TzarGames.Endless.ItemEnchancement.getModificatorForItem(itemInstance:  val_9);
            val_9 = val_9 + 1;
            val_10 = 0.DefenceModificator.HasModificator(modificator:  val_3);
            if(val_10 != true)
            {
                    0.DefenceModificator.AddModificator(modificator:  val_3);
            }
            
            TzarGames.Endless.ItemEnchancement.updateArmorDefenceModificator(modificator:  null, level:  val_3);
            TzarGames.Endless.ItemEnchancement.updateArmorDefenceModificator(modificator:  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}), level:  val_3);
            return (float)0.Defence;
        }
        public static bool IsItemCanBeEnchanced(TzarGames.GameFramework.Item item)
        {
            var val_3 = 0;
            return (bool);
        }
        public static TzarGames.Endless.PurchaseStatus EnchanceItemForPlayer(TzarGames.GameFramework.ItemInstance itemInstance, TzarGames.Endless.EndlessPlayerCharacterTemplate playerTemplate, bool useRuby)
        {
            var val_21;
            var val_22;
            TzarGames.GameFramework.Item val_23;
            int val_24;
            int val_25;
            var val_26;
            var val_27;
            int val_28;
            int val_29;
            var val_30;
            var val_31;
            val_24 = playerTemplate.GetTemplateInstance();
            val_23 = null;
            if((TzarGames.Endless.ItemEnchancement.IsItemCanBeEnchanced(item:  val_23)) == false)
            {
                goto label_4;
            }
            
            val_24 = TzarGames.Endless.ItemEnchancement.GetCostForEnchancement(itemInstance:  null);
            val_25 = val_3.Gold;
            if(val_25 <= useRuby.Gold)
            {
                goto label_9;
            }
            
            val_26 = 3;
            return (TzarGames.Endless.PurchaseStatus)val_26;
            label_4:
            val_26 = 1;
            return (TzarGames.Endless.PurchaseStatus)val_26;
            label_9:
            val_27 = 0;
            val_25 = useRuby.Inventory.DefaultBag.GetConsumableItemCount(itemId:  TzarGames.Endless.ItemEnchancement.RequiredItemTemplate);
            if((W3 & 1) != 0)
            {
                    val_28 = val_3.RubyCostForHammerDiscount;
                val_29 = val_3.HammerCountWithDiscount;
            }
            else
            {
                    val_28 = 0;
                val_29 = val_3.HammerCount;
            }
            
            TzarGames.Endless.ICharacterInfo val_10 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_27 = 4;
            val_30 = val_10;
            if(val_10 < val_28)
            {
                    val_26 = 2;
                return (TzarGames.Endless.PurchaseStatus)val_26;
            }
            
            if(val_25 < val_29)
            {
                    val_26 = 4;
                return (TzarGames.Endless.PurchaseStatus)val_26;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_27 = 5;
            val_31 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            val_25 = useRuby.Inventory.DefaultBag;
            bool val_18 = val_25.RemoveConsumableItem(item:  TzarGames.Endless.ItemEnchancement.RequiredItemTemplate, count:  val_29);
            val_24 = val_3.Gold;
            useRuby.AddGold(goldAdd:  -val_24);
            TzarGames.GameFramework.Item val_19 = playerTemplate.GetTemplateInstance();
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Increment(input:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            mem2[0] = val_21;
            mem2[0] = val_22;
            TzarGames.Endless.ItemEnchancement.UpdateEnchancement(itemInstance:  val_20.currentCryptoKey);
            val_26 = 0;
            return (TzarGames.Endless.PurchaseStatus)val_26;
        }
        private static TzarGames.GameFramework.CharacteristicModificator getModificatorForItem(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            TzarGames.GameFramework.CharacteristicModificator val_13;
            var val_14;
            string val_15;
            TzarGames.GameFramework.CharacteristicModificator val_16;
            val_13 = X1;
            val_14 = null;
            val_14 = null;
            val_15 = val_13.GetInstanceID();
            if((TzarGames.Endless.ItemEnchancement.modificators.TryGetValue(key:  val_15, value: out  0)) != true)
            {
                    if(val_13.GetTemplateInstance() != null)
            {
                    val_16 = 0;
                return val_16;
            }
            
                val_16 = 0;
                return val_16;
            }
            
            val_16 = ;
            return val_16;
        }
        public static void UpdateEnchancement(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_10;
            TzarGames.GameFramework.Item val_1 = X1.GetTemplateInstance();
            if(val_1 == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_3 = TzarGames.Endless.ItemEnchancement.getModificatorForItem(itemInstance:  null);
            TzarGames.Endless.ItemEnchancement.updateArmorDefenceModificator(modificator:  CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false}), level:  val_3);
            val_10 = val_1.DefenceModificator;
            val_10.AddModificator(modificator:  val_3);
        }
        public static TzarGames.Endless.ItemEnchancementCost GetCostForEnchancement(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_17;
            float val_18;
            var val_19;
            TzarGames.GameFramework.Item val_1 = X1.GetOriginalTemplate();
            val_17 = null;
            val_17 = null;
            val_18 = 1f;
            if(val_1 != null)
            {
                    float val_3 = val_1.Defence;
                val_19 = null;
                val_19 = null;
                float val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false});
                val_18 =  * ;
            }
            
            TzarGames.GameFramework.Item val_7 = X1.GetTemplateInstance();
            uint val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
            uint val_10 = val_8 + 1;
            uint val_12 = val_8 + 2;
            val_12 = val_12 * val_10;
            float val_16 = (float)(double)val_12;
            val_16 = val_18 * val_16;
            val_16 = val_18 * val_16;
            val_16 = val_16 * (CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
            typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_10 = (int)val_16;
            if(val_10 <= 3)
            {
                    typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_14 = 0;
                typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_18 = 0;
                typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_1C = 0;
                return (TzarGames.Endless.ItemEnchancementCost)new System.Object();
            }
            
            if(val_10 <= 6)
            {
                    typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_14 = 1;
                typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_18 = 1;
                typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_1C = 0;
                return (TzarGames.Endless.ItemEnchancementCost)new System.Object();
            }
            
            uint val_13 = val_8 - 4;
            typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_14 = val_13;
            var val_15 = (val_13 < 0) ? (val_8 - 3) : (val_13);
            val_15 = val_15 >> 1;
            typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_18 = val_15;
            typeof(TzarGames.Endless.ItemEnchancementCost).__il2cppRuntimeField_1C = val_15;
            return (TzarGames.Endless.ItemEnchancementCost)new System.Object();
        }
        private static ItemEnchancement()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2;
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_5;
            var val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_8;
            var val_9;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_11;
            var val_12;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  20f);
            TzarGames.Endless.ItemEnchancement.costGrowRate = val_2;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_10 = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  20f);
            TzarGames.Endless.ItemEnchancement.armorCostGrowRate = val_5;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_30 = val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  1f);
            TzarGames.Endless.ItemEnchancement.damageCoefficient = val_8;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_50 = val_9;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  1f);
            TzarGames.Endless.ItemEnchancement.defenceCoefficient = val_11;
            TzarGames.Endless.ItemEnchancement.costGrowRate.__il2cppRuntimeField_70 = val_12;
            TzarGames.Endless.ItemEnchancement.modificators = new System.Collections.Generic.Dictionary<System.String, TzarGames.GameFramework.CharacteristicModificator>();
        }
    
    }

}
