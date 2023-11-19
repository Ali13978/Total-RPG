using UnityEngine;
public class BehaviourEventHandler : MonoBehaviour
{
    // Fields
    [UnityEngine.SerializeField]
    private UnityEngine.Events.UnityEvent onEnable;
    [UnityEngine.SerializeField]
    private UnityEngine.Events.UnityEvent onDisable;
    [UnityEngine.SerializeField]
    private float startDelay;
    [UnityEngine.SerializeField]
    private UnityEngine.Events.UnityEvent onStart;
    
    // Methods
    public BehaviourEventHandler()
    {
    
    }
    private void OnEnable()
    {
        this.onEnable.Invoke();
    }
    private void OnDisable()
    {
        this.onDisable.Invoke();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator Start()
    {
        typeof(BehaviourEventHandler.<Start>c__Iterator0).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
