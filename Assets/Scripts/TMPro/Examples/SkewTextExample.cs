using UnityEngine;

namespace TMPro.Examples
{
    public class SkewTextExample : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        public UnityEngine.AnimationCurve VertexCurve;
        public float CurveScale;
        public float ShearAmount;
        
        // Methods
        public SkewTextExample()
        {
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_20 = 0;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_30 = 0;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_40 = 0;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_50 = 0;
            typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_60 = 0;
            this.VertexCurve = new UnityEngine.AnimationCurve(keys:  null);
            this.CurveScale = 1f;
            this.ShearAmount = 1f;
        }
        private void Awake()
        {
            this.m_TextComponent = this.gameObject.GetComponent<TMPro.TMP_Text>();
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WarpText());
        }
        private UnityEngine.AnimationCurve CopyAnimationCurve(UnityEngine.AnimationCurve curve)
        {
            keys = curve.keys;
            return (UnityEngine.AnimationCurve)new UnityEngine.AnimationCurve();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator WarpText()
        {
            typeof(SkewTextExample.<WarpText>c__Iterator0).__il2cppRuntimeField_80 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
