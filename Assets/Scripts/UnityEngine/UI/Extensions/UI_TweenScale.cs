using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UI_TweenScale : MonoBehaviour
    {
        // Fields
        public UnityEngine.AnimationCurve animCurve;
        [UnityEngine.TooltipAttribute]
        public float speed;
        [UnityEngine.TooltipAttribute]
        public bool isLoop;
        [UnityEngine.TooltipAttribute]
        public bool playAtAwake;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public bool isUniform;
        public UnityEngine.AnimationCurve animCurveY;
        private UnityEngine.Vector3 initScale;
        private UnityEngine.Transform myTransform;
        private UnityEngine.Vector3 newScale;
        
        // Methods
        public UI_TweenScale()
        {
            this.speed = 1f;
            this.isUniform = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            this.newScale = val_1;
            mem[1152921512803916732] = val_1.y;
            mem[1152921512803916736] = val_1.z;
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.myTransform = val_1;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            this.initScale = val_2;
            mem[1152921512804032804] = val_2.y;
            mem[1152921512804032808] = val_2.z;
            if(this.playAtAwake == false)
            {
                    return;
            }
            
            this.Play();
        }
        public void Play()
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "Tween");
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Tween()
        {
            typeof(UI_TweenScale.<Tween>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void ResetTween()
        {
            this.StopCoroutine(methodName:  "Tween");
            this.myTransform.localScale = new UnityEngine.Vector3() {x = this.initScale, y = V9.16B, z = V10.16B};
        }
    
    }

}
