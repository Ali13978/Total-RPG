using UnityEngine;
[Serializable]
public class PhotonTransformViewPositionModel
{
    // Fields
    public bool SynchronizeEnabled;
    public bool TeleportEnabled;
    public float TeleportIfDistanceGreaterThan;
    public PhotonTransformViewPositionModel.InterpolateOptions InterpolateOption;
    public float InterpolateMoveTowardsSpeed;
    public float InterpolateLerpSpeed;
    public float InterpolateMoveTowardsAcceleration;
    public float InterpolateMoveTowardsDeceleration;
    public UnityEngine.AnimationCurve InterpolateSpeedCurve;
    public PhotonTransformViewPositionModel.ExtrapolateOptions ExtrapolateOption;
    public float ExtrapolateSpeed;
    public bool ExtrapolateIncludingRoundTripTime;
    public int ExtrapolateNumberOfStoredPositions;
    public bool DrawErrorGizmo;
    
    // Methods
    public PhotonTransformViewPositionModel()
    {
        this.TeleportEnabled = true;
        this.TeleportIfDistanceGreaterThan = 3f;
        this.InterpolateOption = 2;
        this.InterpolateMoveTowardsSpeed = ;
        this.InterpolateLerpSpeed = ;
        this.InterpolateMoveTowardsAcceleration = 2f;
        this.InterpolateMoveTowardsDeceleration = 2f;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_20 = 0;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_30 = 0;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_40 = 0;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_50 = 0;
        this.InterpolateSpeedCurve = new UnityEngine.AnimationCurve(keys:  null);
        this.ExtrapolateSpeed = 1f;
        this.ExtrapolateIncludingRoundTripTime = true;
        this.ExtrapolateNumberOfStoredPositions = true;
        this.DrawErrorGizmo = true;
    }

}
