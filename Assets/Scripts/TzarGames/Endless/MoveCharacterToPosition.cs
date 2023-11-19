using UnityEngine;

namespace TzarGames.Endless
{
    public class MoveCharacterToPosition : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent onReachTargetPositionSuccess;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent onReachTargetPositionFailed;
        private UnityEngine.Coroutine moveCoroutine;
        
        // Methods
        public MoveCharacterToPosition()
        {
        
        }
        public void SetCharacter(TzarGames.TzarHero.TH_Character targetCharacter)
        {
            this.character = targetCharacter;
        }
        public void MoveToPosition(UnityEngine.Transform position)
        {
            UnityEngine.Vector3 val_1 = position.position;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.moveRoutine(currentCharacter:  this.character, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, callback:  0));
        }
        public void CancelMoveToPosition()
        {
            var val_4;
            if(this.moveCoroutine == null)
            {
                    return;
            }
            
            if(0 != this.character)
            {
                    this.character.StopMove();
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = this.character.Movement;
            }
            
            this.StopCoroutine(routine:  this.moveCoroutine);
            this.moveCoroutine = 0;
        }
        public void MoveCharacter(TzarGames.TzarHero.TH_Character ch, UnityEngine.Transform position, System.Action<bool> callback)
        {
            this.CancelMoveToPosition();
            UnityEngine.Vector3 val_1 = position.position;
            this.moveCoroutine = this.StartCoroutine(routine:  this.moveRoutine(currentCharacter:  ch, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, callback:  callback));
        }
        public void TeleportToPosition(UnityEngine.Transform position, System.Action finishCallback)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.teleportRoutine(position:  position, callback:  finishCallback));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator teleportRoutine(UnityEngine.Transform position, System.Action callback)
        {
            if(null != 0)
            {
                    typeof(MoveCharacterToPosition.<teleportRoutine>c__Iterator0).__il2cppRuntimeField_10 = position;
                typeof(MoveCharacterToPosition.<teleportRoutine>c__Iterator0).__il2cppRuntimeField_18 = callback;
            }
            else
            {
                    mem[16] = position;
                mem[24] = callback;
            }
            
            typeof(MoveCharacterToPosition.<teleportRoutine>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator moveRoutine(TzarGames.TzarHero.TH_Character currentCharacter, UnityEngine.Vector3 position, System.Action<bool> callback)
        {
            if(null != 0)
            {
                    typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1).__il2cppRuntimeField_10 = currentCharacter;
            }
            else
            {
                    mem[16] = currentCharacter;
            }
            
            typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1).__il2cppRuntimeField_18 = position.x;
            typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1).__il2cppRuntimeField_1C = position.y;
            typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1).__il2cppRuntimeField_20 = position.z;
            if(null != 0)
            {
                    typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1).__il2cppRuntimeField_28 = callback;
            }
            else
            {
                    mem[40] = callback;
            }
            
            typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
