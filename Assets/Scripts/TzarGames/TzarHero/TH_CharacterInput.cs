using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_CharacterInput : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private string attackButtonName;
        [UnityEngine.SerializeField]
        protected string jumpButtonName;
        [UnityEngine.SerializeField]
        private bool useOnlyWhenOwnerByPlayer;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Character { get; }
        
        // Methods
        public TH_CharacterInput()
        {
            this.attackButtonName = "Fire1";
            this.useOnlyWhenOwnerByPlayer = true;
            this.jumpButtonName = "Jump";
        }
        public TzarGames.TzarHero.TH_Character get_Character()
        {
            return (TzarGames.TzarHero.TH_Character)this.character;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        protected UnityEngine.Vector3 getInputVector()
        {
            float val_7;
            float val_8;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_7 = val_1.x;
            val_8 = val_1.z;
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.AxisExists(name:  0)) != false)
            {
                    val_7 = UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis(name:  0);
            }
            
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.AxisExists(name:  0)) == false)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_1.y, z = val_8};
            }
            
            val_8 = UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetAxis(name:  0);
            return new UnityEngine.Vector3() {x = val_7, y = val_1.y, z = val_8};
        }
        protected virtual UnityEngine.Vector3 calculateMoveVector()
        {
            return this.getInputVector();
        }
        private void processMovement()
        {
            TzarGames.GameFramework.ICharacterMovement val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = this;
            if(this.character.movement == null)
            {
                    return;
            }
            
            if(S0 > 0f)
            {
                    if(this.character.IsMovingOnPath != false)
            {
                    this.character.StopMove();
            }
            
                State val_2 = this.character.CurrentState;
                bool val_3 = this.character.GotoState<Moving>(stateData:  0);
                this.character.CancelPendingState();
            }
            
            if(this.character.IsMovingOnPath != true)
            {
                    if(this.character.CurrentState != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_13 = this.character.movement;
            }
            
            }
            
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetButtonDown(name:  0)) != false)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_14 = this.character.movement;
            }
            
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetButtonUp(name:  0)) == false)
            {
                    return;
            }
            
            val_12 = this.character.movement;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = val_12;
        }
        protected virtual void Update()
        {
            if(this.useOnlyWhenOwnerByPlayer != false)
            {
                    if(this.character.PlayerOwner == null)
            {
                    return;
            }
            
                if(this.character.PlayerOwner.itsMe == false)
            {
                    return;
            }
            
            }
            
            this.processMovement();
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.GetButton(name:  0)) == false)
            {
                    return;
            }
            
            if(this.character.IsAttacking != false)
            {
                    return;
            }
            
            this.character.bAttackContinuosly = false;
            float val_7 = this.character.GetAttackRadius();
            val_7 = val_7 + this.character._minDistanceToWaypoint;
            this.character.targetObject = this.character.TryFindTargetForAttack(radius:  val_7);
            this.character.UseWeapon();
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}
