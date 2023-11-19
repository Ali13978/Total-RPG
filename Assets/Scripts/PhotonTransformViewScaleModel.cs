using UnityEngine;
[Serializable]
public class PhotonTransformViewScaleModel
{
    // Fields
    public bool SynchronizeEnabled;
    public PhotonTransformViewScaleModel.InterpolateOptions InterpolateOption;
    public float InterpolateMoveTowardsSpeed;
    public float InterpolateLerpSpeed;
    
    // Methods
    public PhotonTransformViewScaleModel()
    {
        this.InterpolateMoveTowardsSpeed = 1f;
    }

}
