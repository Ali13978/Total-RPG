using UnityEngine;

namespace TzarGames.Common
{
    public class AnimatorParameterLinker : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Animator targetAnimator;
        
        // Methods
        public AnimatorParameterLinker()
        {
        
        }
        private void Reset()
        {
            this.targetAnimator = this.GetComponentInChildren<UnityEngine.Animator>();
        }
        public void SetParameterToFalse(string parameter)
        {
            this.targetAnimator.SetBool(name:  parameter, value:  false);
        }
        public void SetParameterToTrue(string parameter)
        {
            this.targetAnimator.SetBool(name:  parameter, value:  true);
        }
    
    }

}
