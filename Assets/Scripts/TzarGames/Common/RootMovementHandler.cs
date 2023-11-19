using UnityEngine;

namespace TzarGames.Common
{
    public class RootMovementHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Animator cachedAnimator;
        public System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> OnAnimatorMoveEvent;
        
        // Properties
        public UnityEngine.Animator Animator { get; }
        
        // Methods
        public RootMovementHandler()
        {
        
        }
        private void Reset()
        {
            this.cachedAnimator = this.GetComponent<UnityEngine.Animator>();
        }
        public UnityEngine.Animator get_Animator()
        {
            return (UnityEngine.Animator)this.cachedAnimator;
        }
        private void OnAnimatorMove()
        {
            if(this.OnAnimatorMoveEvent == null)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_1 = this.cachedAnimator.deltaRotation;
            UnityEngine.Vector3 val_2 = this.cachedAnimator.deltaPosition;
            this.OnAnimatorMoveEvent.Invoke(arg1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, arg2:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
        }
    
    }

}
