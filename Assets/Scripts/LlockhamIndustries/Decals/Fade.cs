using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.RequireComponent]
    public class Fade : Modifier
    {
        // Fields
        public LlockhamIndustries.Decals.FadeType type;
        public LlockhamIndustries.Decals.FadeWrapMode wrapMode;
        public UnityEngine.AnimationCurve fade;
        public float fadeLength;
        private LlockhamIndustries.Decals.ProjectionRenderer projection;
        private float timeElapsed;
        private bool executing;
        private float originalAlpha;
        private UnityEngine.Vector3 originalScale;
        
        // Methods
        public Fade()
        {
            this.fadeLength = 1f;
            this.fade = UnityEngine.AnimationCurve.EaseInOut(timeStart:  0f, valueStart:  1f, timeEnd:  1f, valueEnd:  0f);
            this = new UnityEngine.MonoBehaviour();
        }
        private void Awake()
        {
            this.projection = this.GetComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
        }
        protected override void Begin()
        {
            this.timeElapsed = 0f;
            this.executing = true;
            this.originalAlpha = this.GetAlpha(Projection:  this.projection);
            UnityEngine.Vector3 val_3 = this.projection.transform.localScale;
            this.originalScale = val_3;
            mem[1152921511810879744] = val_3.y;
            mem[1152921511810879748] = val_3.z;
            if(this.wrapMode <= 3)
            {
                    if((25815636 + (this.wrapMode) << 2) > 5)
            {
                    return;
            }
            
                var val_8 = 25815128 + (25815636 + (this.wrapMode) << 2) << 2;
                val_8 = val_8 + 25815128;
            }
            else
            {
                    ???.ApplyFade(Projection:  ??? + 56, Time:  0f);
            }
        
        }
        public override void Perform()
        {
            float val_2;
            if(this.executing == false)
            {
                    return;
            }
            
            if(this.fade == null)
            {
                    return;
            }
            
            if(this.wrapMode > 1)
            {
                goto label_3;
            }
            
            val_2 = this.fadeLength;
            if(this.timeElapsed <= val_2)
            {
                goto label_3;
            }
            
            if(this.wrapMode != 1)
            {
                goto label_4;
            }
            
            this.ApplyFade(Projection:  this.projection, Time:  1f);
            if(this.wrapMode != 0)
            {
                goto label_5;
            }
            
            label_4:
            this.projection.Destroy();
            label_5:
            this.executing = false;
            return;
            label_3:
            if(this.wrapMode == 1)
            {
                    val_2 = 0.1f;
            }
            else
            {
                    if(this.wrapMode == 2)
            {
                    val_2 = 1f;
            }
            else
            {
                    float val_1 = UnityEngine.Time.deltaTime;
            }
            
            }
            
            val_1 = this.timeElapsed + val_1;
            this.timeElapsed = val_1;
            val_1 = val_1 / this.fadeLength;
            this.ApplyFade(Projection:  this.projection, Time:  val_1);
        }
        private void ApplyFade(LlockhamIndustries.Decals.ProjectionRenderer Projection, float Time)
        {
            float val_1 = this.fade.Evaluate(time:  Time);
            if(this.type == 2)
            {
                goto label_2;
            }
            
            if(this.type == 1)
            {
                goto label_3;
            }
            
            if(this.type != 0)
            {
                    return;
            }
            
            float val_3 = this.originalAlpha;
            val_3 = val_1 * val_3;
            this.fade.SetAlpha(Projection:  Projection, Alpha:  val_3);
            return;
            label_2:
            float val_4 = this.originalAlpha;
            val_4 = val_1 * val_4;
            this.fade.SetAlpha(Projection:  Projection, Alpha:  val_4);
            label_3:
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originalScale, y = V10.16B, z = V9.16B}, d:  val_1);
            this.SetScale(Projection:  Projection, Scale:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        private float GetAlpha(LlockhamIndustries.Decals.ProjectionRenderer Projection)
        {
            LlockhamIndustries.Decals.ProjectionRenderer val_1 = Projection;
            LlockhamIndustries.Decals.ProjectionProperty val_1 = Projection.properties[1];
            if(val_1 != 0)
            {
                    if(val_1 != 2)
            {
                    if(val_1 != 1)
            {
                    return 1f;
            }
            
            }
            
                val_1 = Projection.properties;
                LlockhamIndustries.Decals.ProjectionProperty val_2 = val_1[4];
                return 1f;
            }
            
            val_1 = Projection.properties;
            LlockhamIndustries.Decals.ProjectionProperty val_3 = val_1[3];
            return 1f;
        }
        private void SetAlpha(LlockhamIndustries.Decals.ProjectionRenderer Projection, float Alpha)
        {
            LlockhamIndustries.Decals.ProjectionProperty val_2 = Projection.properties[1];
            if((val_2 - 1) < 2)
            {
                    Projection.SetFloat(PropertyIndex:  0, Float:  Alpha);
            }
            else
            {
                    if(val_2 == 0)
            {
                    Projection.SetColor(PropertyIndex:  0, Color:  new UnityEngine.Color() {r = Projection.properties[2], g = Projection.properties[2], b = Projection.properties[3], a = Alpha});
            }
            
            }
            
            Projection.UpdateProperties();
        }
        private void SetScale(LlockhamIndustries.Decals.ProjectionRenderer Projection, UnityEngine.Vector3 Scale)
        {
            Projection.transform.localScale = new UnityEngine.Vector3() {x = Scale.x, y = Scale.y, z = Scale.z};
        }
    
    }

}
