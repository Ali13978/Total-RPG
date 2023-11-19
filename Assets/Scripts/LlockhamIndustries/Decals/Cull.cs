using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.RequireComponent]
    public class Cull : Modifier
    {
        // Fields
        public float cullTime;
        private LlockhamIndustries.Decals.ProjectionRenderer projection;
        private float timeElapsed;
        
        // Methods
        public Cull()
        {
            this.cullTime = 4f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void Awake()
        {
            this.projection = this.GetComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
        }
        protected override void Begin()
        {
            this.timeElapsed = 0f;
        }
        public override void Perform()
        {
            float val_3 = this.cullTime;
            if(this.timeElapsed >= 0)
            {
                goto label_0;
            }
            
            if(W8 != 1)
            {
                goto label_1;
            }
            
            val_3 = 0.1f;
            goto label_5;
            label_0:
            this.projection.Destroy();
            return;
            label_1:
            if(W8 == 2)
            {
                    val_3 = 1f;
            }
            else
            {
                    float val_1 = UnityEngine.Time.deltaTime;
            }
            
            label_5:
            val_1 = this.timeElapsed + val_1;
            this.timeElapsed = val_1;
            if(this.projection.meshRenderer.isVisible == false)
            {
                    return;
            }
            
            this.timeElapsed = 0f;
        }
    
    }

}
