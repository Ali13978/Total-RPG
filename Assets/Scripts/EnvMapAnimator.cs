using UnityEngine;
public class EnvMapAnimator : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 RotationSpeeds;
    private TMPro.TMP_Text m_textMeshPro;
    private UnityEngine.Material m_material;
    
    // Methods
    public EnvMapAnimator()
    {
    
    }
    private void Awake()
    {
        TMPro.TMP_Text val_1 = this.GetComponent<TMPro.TMP_Text>();
        this.m_textMeshPro = val_1;
        this.m_material = val_1;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator Start()
    {
        typeof(EnvMapAnimator.<Start>c__Iterator0).__il2cppRuntimeField_50 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
