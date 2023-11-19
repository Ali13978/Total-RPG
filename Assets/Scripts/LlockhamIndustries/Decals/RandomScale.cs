using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class RandomScale : MonoBehaviour
    {
        // Fields
        public float minSize;
        public float maxSize;
        
        // Methods
        public RandomScale()
        {
            this.minSize = 0.5f;
            this.maxSize = 7.346868E-41f;
        }
        private void Awake()
        {
            float val_1 = UnityEngine.Random.Range(min:  this.minSize, max:  this.maxSize);
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}
