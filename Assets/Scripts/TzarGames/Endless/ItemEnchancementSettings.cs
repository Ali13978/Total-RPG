using UnityEngine;

namespace TzarGames.Endless
{
    public class ItemEnchancementSettings : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat costGrowRate;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat armorCostGrowRate;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat damageCoefficient;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat defenceCoefficient;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item requiredItemTemplate;
        
        // Methods
        public ItemEnchancementSettings()
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_6;
            var val_8;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_9;
            var val_11;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_12;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  20f);
            mem[1152921510698926536] = val_2;
            this.costGrowRate = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  20f);
            mem[1152921510698926568] = val_5;
            this.armorCostGrowRate = val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  1f);
            mem[1152921510698926600] = val_8;
            this.damageCoefficient = val_9;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  1f);
            mem[1152921510698926632] = val_11;
            this.defenceCoefficient = val_12;
        }
        private void Start()
        {
            TzarGames.Endless.ItemEnchancement.SetCostGrowRate(rate:  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
            TzarGames.Endless.ItemEnchancement.SetArmorCostGrowRate(rate:  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
            TzarGames.Endless.ItemEnchancement.SetDamageCoefficient(coeff:  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
            TzarGames.Endless.ItemEnchancement.SetDefenceCoefficient(coeff:  CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), inited = false, fakeValueActive = false}));
            TzarGames.Endless.ItemEnchancement.RequiredItemTemplate = 0f;
        }
    
    }

}
