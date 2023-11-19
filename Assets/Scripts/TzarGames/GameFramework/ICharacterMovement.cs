using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface ICharacterMovement
    {
        // Properties
        public abstract float CurrentMoveSpeed { get; }
        public abstract float Height { get; }
        public abstract float Radius { get; }
        public abstract UnityEngine.Vector3 Velocity { get; }
        public abstract UnityEngine.Vector3 InputVector { get; set; }
        public abstract bool SyncRotationFromServer { get; set; }
        public abstract float MaxSpeed { get; set; }
        public abstract bool EnableMovement { get; set; }
        public abstract bool IsGrounded { get; }
        
        // Methods
        public abstract void AddPreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler); // 0
        public abstract void RemovePreMovementUpdateHandler(TzarGames.Common.TG_VoidDelegate handler); // 0
        public abstract float get_CurrentMoveSpeed(); // 0
        public abstract float get_Height(); // 0
        public abstract float get_Radius(); // 0
        public abstract UnityEngine.Vector3 get_Velocity(); // 0
        public abstract void NotifyPositionChange(UnityEngine.Vector3 position); // 0
        public abstract UnityEngine.Vector3 get_InputVector(); // 0
        public abstract void set_InputVector(UnityEngine.Vector3 value); // 0
        public abstract void Jump(); // 0
        public abstract void StopJumping(); // 0
        public abstract bool get_SyncRotationFromServer(); // 0
        public abstract void set_SyncRotationFromServer(bool value); // 0
        public abstract float get_MaxSpeed(); // 0
        public abstract void set_MaxSpeed(float value); // 0
        public abstract bool get_EnableMovement(); // 0
        public abstract void set_EnableMovement(bool value); // 0
        public abstract bool get_IsGrounded(); // 0
        public abstract void SetPlayerOwner(TzarGames.GameFramework.Player player); // 0
        public abstract void LockSpeedOverride(object locker, float speed); // 0
        public abstract void UnlockSpeedOverride(object locker); // 0
        public abstract void ZeroMovement(); // 0
        public abstract void HandleRootMotion(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation); // 0
    
    }

}
