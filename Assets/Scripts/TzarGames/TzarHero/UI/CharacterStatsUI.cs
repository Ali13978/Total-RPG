using UnityEngine;

namespace TzarGames.TzarHero.UI
{
    public class CharacterStatsUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private float updateInterval;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider health;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI healthNumeric;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI damage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI defence;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI speed;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI attackSpeed;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI critChance;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI critPower;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI hpRegen;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider xp;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI level;
        private uint lastCharacterLevel;
        private float lastCharacterDamage;
        private float lastCharacterDefence;
        private float lastCharacterSpeed;
        private float lastCharacterAttackSpeed;
        private float lastCharacterCritChance;
        private float lastCharacterHpRegen;
        private float lastCharacterCritPower;
        private float lastActualHp;
        private float lastMaxHp;
        private float lastUpdateTime;
        private System.Text.StringBuilder hpTextBuilder;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Character { get; }
        
        // Methods
        public CharacterStatsUI()
        {
            this.lastCharacterCritChance = ;
            this.updateInterval = 0.1f;
            this.lastCharacterLevel = 0;
            this.lastMaxHp = -1.175494E-38f;
            this.lastCharacterDamage = ;
            this.hpTextBuilder = new System.Text.StringBuilder(capacity:  256);
        }
        public TzarGames.TzarHero.TH_Character get_Character()
        {
            return (TzarGames.TzarHero.TH_Character)this.character;
        }
        private void OnEnable()
        {
            if(0 == this.character)
            {
                    return;
            }
            
            this = ???;
            goto typeof(TzarGames.TzarHero.UI.CharacterStatsUI).__il2cppRuntimeField_1A0;
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player player)
        {
            var val_9;
            UnityEngine.GameObject val_10;
            val_9 = this;
            val_10 = player.PlayerObject;
            if(0 == val_10)
            {
                    return;
            }
            
            this.character = player.PlayerObject.GetComponent<TzarGames.TzarHero.TH_Character>();
            val_9 = ???;
            val_10 = ???;
            goto typeof(TzarGames.TzarHero.UI.CharacterStatsUI).__il2cppRuntimeField_1A0;
        }
        protected virtual void UpdateCharacterStats()
        {
            string val_71;
            float val_72;
            var val_73;
            float val_74;
            string val_75;
            float val_76;
            float val_77;
            val_71 = this;
            TzarGames.TzarHero.TH_CharacterTemplate val_1 = this.character.TemplateInstance;
            if(val_1 != null)
            {
                    val_72 = val_1.ActualHitPoints;
                val_73 = val_1;
            }
            else
            {
                    val_72 = 0.ActualHitPoints;
                val_73 = 0;
            }
            
            float val_4 = val_73.HitPoints;
            if(0 != this.health)
            {
                    val_72 = val_72 / val_4;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_4 - val_72)) > val_74)
            {
                    val_74 = val_72;
            }
            
            }
            
            if(0 != this.xp)
            {
                    float val_8 = val_73.GetXpProgressNormalized();
                val_72 = val_8;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_8 - val_72)) > val_74)
            {
                    val_74 = val_72;
            }
            
            }
            
            if((0 != this.level) && (this.level.gameObject.activeInHierarchy != false))
            {
                    uint val_13 = this.character.Level;
                if(this.lastCharacterLevel != val_13)
            {
                    this.lastCharacterLevel = val_13;
                val_75;
                this.level.text = this.character.Level;
            }
            
            }
            
            if((0 == this.healthNumeric) || (this.healthNumeric.gameObject.activeInHierarchy == false))
            {
                goto label_51;
            }
            
            val_75 = 1152921504719998976;
            val_76 = this.lastActualHp;
            val_72 = 0.0001f;
            val_74 = System.Math.Abs(val_72 - val_76);
            if(val_74 <= val_72)
            {
                goto label_39;
            }
            
            val_77 = this.lastMaxHp;
            goto label_40;
            label_39:
            val_77 = val_71;
            val_76 = this.lastMaxHp;
            val_74 = System.Math.Abs(val_4 - val_76);
            if(val_74 <= val_72)
            {
                goto label_51;
            }
            
            label_40:
            this.lastMaxHp = val_4;
            this.lastActualHp = val_72;
            this.hpTextBuilder.Length = 0;
            System.Text.StringBuilder val_21 = this.hpTextBuilder.Append(value:  val_72.ToString(format:  "F1"));
            System.Text.StringBuilder val_22 = this.hpTextBuilder.Append(value:  '/');
            System.Text.StringBuilder val_24 = this.hpTextBuilder.Append(value:  val_4.ToString(format:  "F1"));
            val_75 = this.healthNumeric.text;
            if((val_75.Equals(value:  this.hpTextBuilder)) != true)
            {
                    val_75 = this.healthNumeric;
                val_75.text = this.hpTextBuilder;
            }
            
            label_51:
            if((0 != this.damage) && (this.damage.gameObject.activeInHierarchy != false))
            {
                    val_72 = val_73.Damage;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_72 - this.lastCharacterDamage)) > val_74)
            {
                    this.lastCharacterDamage = val_72;
                val_75 = val_72.ToString(format:  "F1");
                this.damage.text = val_75;
            }
            
            }
            
            if((0 != this.defence) && (this.defence.gameObject.activeInHierarchy != false))
            {
                    val_72 = val_73.Defence;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_72 - this.lastCharacterDefence)) > val_74)
            {
                    this.lastCharacterDefence = val_72;
                val_75 = val_72.ToString(format:  "F1");
                this.defence.text = val_75;
            }
            
            }
            
            if((0 != this.speed) && (this.speed.gameObject.activeInHierarchy != false))
            {
                    val_72 = val_73.WalkingSpeed;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_72 - this.lastCharacterSpeed)) > val_74)
            {
                    this.lastCharacterSpeed = val_72;
                val_75 = val_72.ToString(format:  "F1");
                this.speed.text = val_75;
            }
            
            }
            
            if((0 != this.attackSpeed) && (this.attackSpeed.gameObject.activeInHierarchy != false))
            {
                    val_72 = val_73.AttackSpeed;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_72 - this.lastCharacterAttackSpeed)) > val_74)
            {
                    this.lastCharacterAttackSpeed = val_72;
                val_75 = val_72.ToString(format:  "F2");
                this.attackSpeed.text = val_75;
            }
            
            }
            
            if((0 != this.critChance) && (this.critChance.gameObject.activeInHierarchy != false))
            {
                    val_72 = val_73.CritChance;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_72 - this.lastCharacterCritChance)) > val_74)
            {
                    this.lastCharacterCritChance = val_72;
                val_75 = System.String.Format(format:  0, arg0:  "{0}%");
                this.critChance.text = val_75;
            }
            
            }
            
            if((0 != this.critPower) && (this.critPower.gameObject.activeInHierarchy != false))
            {
                    val_72 = val_73.CritMultiplier;
                val_74 = 0.0001f;
                if((System.Math.Abs(val_72 - this.lastCharacterCritPower)) > val_74)
            {
                    this.lastCharacterCritPower = val_72;
                string val_63 = val_72.ToString(format:  "F2");
                val_75 = System.String.Format(format:  0, arg0:  "{0}");
                this.critPower.text = val_75;
            }
            
            }
            
            if(0 == this.hpRegen)
            {
                    return;
            }
            
            if(this.hpRegen.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            val_72 = val_73.HitPointsRegenerationSpeed;
            if((System.Math.Abs(val_72 - this.lastCharacterHpRegen)) <= 0.0001f)
            {
                    return;
            }
            
            this.lastCharacterHpRegen = val_72;
            val_71 = val_72.ToString(format:  "F2");
            this.hpRegen.text = val_71;
        }
        protected virtual void Update()
        {
            if(0 == this.character)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 - this.lastUpdateTime;
            if(val_3 < this.updateInterval)
            {
                    return;
            }
            
            this.lastUpdateTime = UnityEngine.Time.time;
            goto typeof(TzarGames.TzarHero.UI.CharacterStatsUI).__il2cppRuntimeField_1A0;
        }
    
    }

}
