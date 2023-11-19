using UnityEngine;

namespace TzarGames.Endless
{
    public class HealingSkillAI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Skills.Healing healingSkill;
        [UnityEngine.SerializeField]
        [UnityEngine.RangeAttribute]
        private float minHealthPercent;
        [UnityEngine.SerializeField]
        private float usageInterval;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterAI characterAI;
        private float lastUseTime;
        private UnityEngine.Coroutine crt;
        
        // Methods
        public HealingSkillAI()
        {
            this.minHealthPercent = 50f;
            this.usageInterval = 3f;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
            this.characterAI = this.GetComponent<TzarGames.TzarHero.CharacterAI>();
        }
        private void OnEnable()
        {
            if(this.crt != null)
            {
                    this.StopCoroutine(routine:  this.crt);
            }
            
            this.crt = this.StartCoroutine(routine:  this.updateFunc());
        }
        private void OnDisable()
        {
            if(this.crt == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.crt);
            this.crt = 0;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator updateFunc()
        {
            typeof(HealingSkillAI.<updateFunc>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private bool heal(TzarGames.TzarHero.TH_Character target)
        {
            var val_4;
            if(this.character.IsAttacking != false)
            {
                    this.character.StopAttack();
            }
            
            this.character.Target = target;
            if((this.character.UseSkill(skill:  this.healingSkill)) != false)
            {
                    val_4 = 1;
                this.lastUseTime = UnityEngine.Time.time;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private bool shouldHealCharacter(TzarGames.TzarHero.TH_Character target)
        {
            float val_5;
            if(target != null)
            {
                    val_5 = target.ActualHealth;
            }
            else
            {
                    val_5 = 0.ActualHealth;
            }
            
            float val_3 = target.BaseHealth;
            float val_5 = this.minHealthPercent;
            val_5 = val_5 / 100f;
            val_3 = val_3 * val_5;
            return (bool)(val_5 <= val_3) ? 1 : 0;
        }
    
    }

}
