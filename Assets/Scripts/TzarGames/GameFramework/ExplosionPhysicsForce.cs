using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ExplosionPhysicsForce : MonoBehaviour
    {
        // Fields
        public float ExplosionForce;
        public float Radius;
        public UnityEngine.LayerMask ExplosionLayer;
        
        // Methods
        public ExplosionPhysicsForce()
        {
            this.ExplosionForce = 4f;
            this.Radius = 10f;
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.explode());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator explode()
        {
            typeof(ExplosionPhysicsForce.<explode>c__Iterator0).__il2cppRuntimeField_48 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
