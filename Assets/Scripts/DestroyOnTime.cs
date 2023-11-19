using UnityEngine;
public class DestroyOnTime : MonoBehaviour
{
    // Fields
    public float destroyTime;
    
    // Methods
    public DestroyOnTime()
    {
        this.destroyTime = 5f;
    }
    public void SetDestroyTime(float time)
    {
        this.destroyTime = time;
    }
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.destroy());
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator destroy()
    {
        typeof(DestroyOnTime.<destroy>c__Iterator0).__il2cppRuntimeField_18 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
