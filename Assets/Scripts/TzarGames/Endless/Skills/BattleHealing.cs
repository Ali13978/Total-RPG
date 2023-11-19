using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class BattleHealing : EndlessCharacterSkill, ICommonSkillUpgrade
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.RangeAttribute]
        private float healingPercent;
        private TzarGames.GameFramework.CharacteristicModificator modificator;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset label;
        
        // Properties
        public TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public BattleHealing()
        {
            this.healingPercent = 20f;
            this.modificator = new TzarGames.GameFramework.CharacteristicModificator(value:  1f);
            this = new TzarGames.TzarHero.Skills.CharacterSkill();
        }
        public TzarGames.GameFramework.CharacteristicModificator get_Modificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.modificator;
        }
        public string GetUpgradeLabelWithBonus(float bonus)
        {
            var val_5;
            var val_6;
            if((TzarGames.Endless.EndlessUtils.FloatToPercent(val:  bonus)) > 0)
            {
                    val_5 = "+";
            }
            else
            {
                    val_6 = null;
                val_6 = null;
            }
            
            string val_2 = 0 + System.String.__il2cppRuntimeField_static_fields;
            return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        protected override void OnStarted()
        {
            typeof(BattleHealing.<OnStarted>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            this.OnStarted();
            float val_14 = 100f;
            val_14 = this.healingPercent / val_14;
            float val_4 = this.modificator.Value;
            val_4 = this.Character.BaseHealth * val_4;
            val_4 = val_14 * val_4;
            typeof(BattleHealing.<OnStarted>c__AnonStorey0).__il2cppRuntimeField_10 = val_4;
            this.Character.IncreaseHealth(amount:  typeof(BattleHealing.<OnStarted>c__AnonStorey0).__il2cppRuntimeField_10);
            UnityEngine.Vector3 val_7 = this.Character.Position;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}).transform.SetParent(parent:  this.Character.transform);
            this.Finish();
            Event.EventFunction<TzarGames.Endless.Skills.IBattleHealingEventHandler> val_13 = new Event.EventFunction<TzarGames.Endless.Skills.IBattleHealingEventHandler>(object:  new System.Object(), method:  System.Void BattleHealing.<OnStarted>c__AnonStorey0::<>m__0(TzarGames.Endless.Skills.IBattleHealingEventHandler receiver));
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.Execute(functor:  0);
        }
    
    }

}
