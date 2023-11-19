using UnityEngine;
public class MecanimForceAnimTime : MonoBehaviour
{
    // Fields
    public UnityEngine.Animator animator;
    private float currentTime;
    private float lastCheckTime;
    
    // Methods
    public MecanimForceAnimTime()
    {
    
    }
    private void Start()
    {
        this.lastCheckTime = UnityEngine.Time.realtimeSinceStartup;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 - this.lastCheckTime;
        this.currentTime = val_1;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_2 = val_2 - this.lastCheckTime;
        if(val_2 >= 1f)
        {
                this.lastCheckTime = UnityEngine.Time.realtimeSinceStartup;
        }
        
        if(0 == this.animator)
        {
                return;
        }
        
        UnityEngine.AnimatorStateInfo val_5 = this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        this;
        this.animator.Play(stateNameHash:  -2059311600, layer:  0, normalizedTime:  this.currentTime);
    }

}
