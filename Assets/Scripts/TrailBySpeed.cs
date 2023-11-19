using UnityEngine;
public class TrailBySpeed : MonoBehaviour
{
    // Fields
    [UnityEngine.SerializeField]
    private float minSpeed;
    [UnityEngine.SerializeField]
    private UnityEngine.TrailRenderer trail;
    private UnityEngine.Vector3 lastPosition;
    private UnityEngine.Transform cachedTransform;
    private float defaultVertexDistance;
    private bool paused;
    
    // Methods
    public TrailBySpeed()
    {
        this.minSpeed = 1f;
    }
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.cachedTransform = val_1;
        UnityEngine.Vector3 val_2 = val_1.position;
        this.lastPosition = val_2;
        mem[1152921511445231196] = val_2.y;
        mem[1152921511445231200] = val_2.z;
        this.defaultVertexDistance = this.trail.time;
    }
    public void PauseEmit(float time)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.pauseEmitRoutine(time:  time));
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator pauseEmitRoutine(float time)
    {
        if(null != 0)
        {
                typeof(TrailBySpeed.<pauseEmitRoutine>c__Iterator0).__il2cppRuntimeField_10 = time;
        }
        else
        {
                mem[16] = time;
        }
        
        typeof(TrailBySpeed.<pauseEmitRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void setTrail(bool on)
    {
        var val_1;
        if(on != false)
        {
                val_1 = 1;
        }
        else
        {
                val_1 = 0;
        }
        
        this.trail.enabled = false;
    }
    private void Update()
    {
        var val_4;
        if(this.paused == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.cachedTransform.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.lastPosition, y = V11.16B, z = V10.16B});
        float val_4 = this.minSpeed;
        val_4 = val_4 * val_4;
        if(val_2.x < val_4)
        {
                val_4 = 0;
        }
        else
        {
                val_4 = 1;
        }
        
        this.trail.enabled = true;
        UnityEngine.Vector3 val_3 = this.cachedTransform.position;
        this.lastPosition = val_3;
        mem[1152921511445724252] = val_3.y;
        mem[1152921511445724256] = val_3.z;
    }

}
