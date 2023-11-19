using UnityEngine;

namespace TzarGames.Endless
{
    public class TeleportSkillAI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Skills.Teleport teleportSkill;
        [UnityEngine.SerializeField]
        private float usageInterval;
        private float lastUseTime;
        private UnityEngine.Coroutine crt;
        private bool isWaitingToUseTeleport;
        
        // Methods
        public TeleportSkillAI()
        {
            this.usageInterval = 3f;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
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
        public void NotifyTakeHit(TzarGames.TzarHero.ICharacterDamageInfo hit)
        {
            this.isWaitingToUseTeleport = true;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator updateFunc()
        {
            typeof(TeleportSkillAI.<updateFunc>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
