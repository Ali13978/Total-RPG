using UnityEngine;
[Serializable]
public class CharacterRigidbodyMovement.MovementSettings
{
    // Fields
    public float ForwardSpeed;
    public float BackwardSpeed;
    public float StrafeSpeed;
    public float RunMultiplier;
    public UnityEngine.KeyCode RunKey;
    public float JumpForce;
    public UnityEngine.AnimationCurve SlopeCurveModifier;
    [UnityEngine.HideInInspector]
    public float CurrentTargetSpeed;
    
    // Methods
    public CharacterRigidbodyMovement.MovementSettings()
    {
        this.ForwardSpeed = ;
        this.BackwardSpeed = ;
        this.StrafeSpeed = 4f;
        this.RunMultiplier = 2f;
        this.RunKey = 304;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_20 = 0;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_30 = 0;
        typeof(UnityEngine.Keyframe[]).__il2cppRuntimeField_40 = 0;
        this.SlopeCurveModifier = new UnityEngine.AnimationCurve(keys:  null);
        this.CurrentTargetSpeed = 8f;
    }
    public void UpdateDesiredTargetSpeed(UnityEngine.Vector2 input)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = input.x, y = input.y}, rhs:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) == true)
        {
                return;
        }
        
        if((input.x != 0f) && (input.x <= _TYPE_MAX_))
        {
                this.CurrentTargetSpeed = this.StrafeSpeed;
        }
        
        if(input.y < 0)
        {
                this.CurrentTargetSpeed = this.BackwardSpeed;
        }
        
        if(input.y <= 0f)
        {
                return;
        }
        
        this.CurrentTargetSpeed = this.ForwardSpeed;
    }

}
