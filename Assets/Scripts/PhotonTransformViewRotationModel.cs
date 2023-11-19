using UnityEngine;
[Serializable]
public class PhotonTransformViewRotationModel
{
    // Fields
    public bool SynchronizeEnabled;
    public PhotonTransformViewRotationModel.InterpolateOptions InterpolateOption;
    public float InterpolateRotateTowardsSpeed;
    public float InterpolateLerpSpeed;
    
    // Methods
    public PhotonTransformViewRotationModel()
    {
        this.InterpolateOption = 1;
        this.InterpolateRotateTowardsSpeed = 180f;
        this.InterpolateLerpSpeed = 5f;
    }

}
