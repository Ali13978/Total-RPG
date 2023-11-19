using UnityEngine;
public class TransformTracker
{
    // Fields
    private UnityEngine.Transform targetTransform;
    private bool recordPos;
    private bool recordRot;
    private bool recordScale;
    public System.Collections.Generic.List<UnityEngine.Vector3> posDataList;
    public System.Collections.Generic.List<UnityEngine.Quaternion> rotDataList;
    public System.Collections.Generic.List<UnityEngine.Vector3> scaleDataList;
    
    // Methods
    public TransformTracker(UnityEngine.Transform targetObj, bool trackPos, bool trackRot, bool trackScale)
    {
        bool val_4 = trackRot;
        this.targetTransform = targetObj;
        if(trackPos != false)
        {
                this.posDataList = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.recordPos = true;
        }
        
        if(val_4 != false)
        {
                System.Collections.Generic.List<UnityEngine.Quaternion> val_2 = null;
            val_4 = val_2;
            val_2 = new System.Collections.Generic.List<UnityEngine.Quaternion>();
            this.rotDataList = val_4;
            this.recordRot = true;
        }
        
        if(trackScale == false)
        {
                return;
        }
        
        this.scaleDataList = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.recordScale = true;
    }
    public void recordFrame()
    {
        bool val_5;
        if((this.recordPos & 255) != false)
        {
                UnityEngine.Vector3 val_2 = this.targetTransform.localPosition;
            this.posDataList.Add(item:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_5 = this.recordRot;
        }
        else
        {
                val_5 = this.recordPos >> 8;
        }
        
        if(val_5 != false)
        {
                UnityEngine.Quaternion val_3 = this.targetTransform.localRotation;
            this.rotDataList.Add(item:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        }
        
        if(this.recordScale == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.targetTransform.localScale;
        this.scaleDataList.Add(item:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }

}
