using UnityEngine;

namespace TzarGames.TzarHero.Skills
{
    public class BasicSkillAI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.Skills.CharacterSkill skill;
        [UnityEngine.SerializeField]
        private bool autoAddSkill;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float firstUsageDelay;
        [UnityEngine.SerializeField]
        private bool randomizeFirstUsageDelay;
        [UnityEngine.SerializeField]
        private float usageInterval;
        [UnityEngine.SerializeField]
        private float levelSubtractCoefficient;
        [UnityEngine.SerializeField]
        private float minimumUsageInterval;
        [UnityEngine.SerializeField]
        private bool useOnlyWhenHaveTarget;
        [UnityEngine.SerializeField]
        private bool useOnlyWhenEnemyWithinMinimalRadius;
        [UnityEngine.SerializeField]
        private bool useMinimumRadius;
        [UnityEngine.SerializeField]
        private float minimumRadius;
        [UnityEngine.SerializeField]
        private bool useMaximumRadius;
        [UnityEngine.SerializeField]
        private float maximumRadius;
        [UnityEngine.SerializeField]
        private int minimumLevel;
        private UnityEngine.Coroutine skillCoroutine;
        
        // Methods
        public BasicSkillAI()
        {
            this.autoAddSkill = true;
            this.randomizeFirstUsageDelay = true;
            this.usageInterval = 10f;
            this.levelSubtractCoefficient = 7.346868E-41f;
            this.minimumUsageInterval = 5f;
            this.firstUsageDelay = 10f;
            this.minimumRadius = 10f;
            this.maximumRadius = 15f;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void Start()
        {
            if(this.autoAddSkill == false)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_CharacterTemplate val_1 = this.character.TemplateInstance;
            this = ???;
            goto typeof(TzarGames.TzarHero.TH_CharacterTemplate).__il2cppRuntimeField_200;
        }
        private void OnEnable()
        {
            if(this.skillCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.skillCoroutine);
            }
            
            this.skillCoroutine = this.StartCoroutine(routine:  this.skillUsage());
        }
        private void OnDisable()
        {
            if(this.skillCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.skillCoroutine);
            this.skillCoroutine = 0;
        }
        private bool isEnemyInRadius(float radius)
        {
            var val_13;
            var val_14;
            val_13 = this;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_1 = this.character.GetOtherCharactersInRadius(radius:  radius);
            if((val_1 == null) || (val_1.Count == 0))
            {
                goto label_15;
            }
            
            List.Enumerator<T> val_3 = val_1.GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = 0.InitializationCallback;
            if((val_4.isDead == true) || ((val_4.TemplateInstance.Group.IsFriendly(group:  this.character.TemplateInstance.Group)) == true))
            {
                goto label_12;
            }
            
            0.Dispose();
            val_14 = 1;
            return (bool)val_14;
            label_4:
            0.Dispose();
            label_15:
            val_14 = 0;
            return (bool)val_14;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator skillUsage()
        {
            typeof(BasicSkillAI.<skillUsage>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
