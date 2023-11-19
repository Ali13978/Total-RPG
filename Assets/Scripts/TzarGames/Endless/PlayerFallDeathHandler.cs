using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayerFallDeathHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.ReturnCharacterToNavMesh navMeshReturner;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterTriggerEventHandler triggerHandler;
        private TzarGames.Endless.PlayerCharacter playerCharacter;
        private bool pendingCharacterAlive;
        
        // Methods
        public PlayerFallDeathHandler()
        {
        
        }
        public void OnPlayerObjectSpawned(TzarGames.GameFramework.Player player)
        {
            var val_4 = 0;
            this.playerCharacter = ;
            add_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.PlayerFallDeathHandler::PlayerCharacterOnOnCharacterAlive(TzarGames.TzarHero.TH_Character character)));
            this.playerCharacter.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.PlayerFallDeathHandler::PlayerCharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        }
        private void PlayerCharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            if(deadEventData.DamageType == null)
            {
                    return;
            }
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator waitForFixedUpdate(TzarGames.TzarHero.TH_Character character)
        {
            if(null != 0)
            {
                    typeof(PlayerFallDeathHandler.<waitForFixedUpdate>c__Iterator0).__il2cppRuntimeField_10 = character;
            }
            else
            {
                    mem[16] = character;
            }
            
            typeof(PlayerFallDeathHandler.<waitForFixedUpdate>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void returnCharacter(TzarGames.TzarHero.TH_Character character)
        {
            this.navMeshReturner.ReturnCharacter(other:  character);
            this.triggerHandler.enabled = true;
        }
        private void PlayerCharacterOnOnCharacterAlive(TzarGames.TzarHero.TH_Character character)
        {
            if(this.pendingCharacterAlive == false)
            {
                    return;
            }
            
            this.pendingCharacterAlive = false;
            if(UnityEngine.Time.inFixedTimeStep != false)
            {
                    this.returnCharacter(character:  character);
                return;
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.waitForFixedUpdate(character:  character));
        }
    
    }

}
