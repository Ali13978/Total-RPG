using UnityEngine;

namespace TMPro.Examples
{
    public class ShaderPropAnimator : MonoBehaviour
    {
        // Fields
        private UnityEngine.Renderer m_Renderer;
        private UnityEngine.Material m_Material;
        public UnityEngine.AnimationCurve GlowCurve;
        public float m_frame;
        
        // Methods
        public ShaderPropAnimator()
        {
        
        }
        private void Awake()
        {
            UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
            this.m_Renderer = val_1;
            this.m_Material = val_1.material;
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateProperties());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator AnimateProperties()
        {
            typeof(ShaderPropAnimator.<AnimateProperties>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
