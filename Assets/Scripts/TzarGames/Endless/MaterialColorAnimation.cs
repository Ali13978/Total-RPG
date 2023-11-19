using UnityEngine;

namespace TzarGames.Endless
{
    public class MaterialColorAnimation : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Material material;
        [UnityEngine.SerializeField]
        private UnityEngine.Color initColor;
        [UnityEngine.SerializeField]
        private UnityEngine.Color targetColor;
        [UnityEngine.SerializeField]
        private string paramName;
        [UnityEngine.SerializeField]
        private float transitionTime;
        private float timer;
        private bool reverse;
        [UnityEngine.SerializeField]
        private UnityEngine.Renderer[] renderers;
        private UnityEngine.Material copy;
        private bool stopped;
        
        // Methods
        public MaterialColorAnimation()
        {
            this.transitionTime = 1f;
            this.paramName = "Color";
        }
        private void Start()
        {
            var val_2;
            UnityEngine.Material val_1 = new UnityEngine.Material(source:  this.material);
            val_2 = 0;
            this.copy = val_1;
            goto label_1;
            label_6:
            this.material.sharedMaterial = val_1;
            val_2 = 1;
            label_1:
            if(val_2 >= this.renderers.Length)
            {
                    return;
            }
            
            if(this.renderers[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private void OnDestroy()
        {
            if(0 == this.copy)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void Reset()
        {
            this.renderers = this.GetComponentsInChildren<UnityEngine.Renderer>();
        }
        public void StopAndResetToTargetColor()
        {
            this.stopped = true;
            this.timer = 0f;
            this.copy.SetColor(name:  this.paramName, value:  new UnityEngine.Color() {r = this.targetColor, g = V10.16B, b = V9.16B, a = V8.16B});
        }
        private void Update()
        {
            bool val_4;
            float val_5;
            UnityEngine.Color val_6;
            UnityEngine.Color val_10;
            var val_11;
            var val_12;
            var val_13;
            if(this.stopped != false)
            {
                    return;
            }
            
            float val_3 = this.transitionTime;
            val_4 = this.reverse;
            val_5 = this.timer + UnityEngine.Time.deltaTime;
            this.timer = val_5;
            if(val_5 >= val_3)
            {
                    val_4 = val_4 ^ 1;
                val_5 = 0f;
                this.timer = 0f;
                this.reverse = val_4;
            }
            
            if(val_4 != false)
            {
                    val_6 = this.targetColor;
                val_10 = this.initColor;
                val_11 = 1152921510731592212;
                val_12 = 1152921510731592216;
                val_13 = 1152921510731592220;
            }
            else
            {
                    val_6 = this.initColor;
                val_10 = this.targetColor;
                val_11 = 1152921510731592228;
                val_12 = 1152921510731592232;
                val_13 = 1152921510731592236;
            }
            
            val_3 = val_5 / val_3;
            UnityEngine.Color val_2 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_6}, b:  new UnityEngine.Color() {r = this.targetColor.r, g = 1.793426E-29f, b = 1.793426E-29f, a = 1.793426E-29f}, t:  val_3);
            this.copy.SetColor(name:  this.paramName, value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        }
    
    }

}
