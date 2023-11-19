using UnityEngine;
[Serializable]
public class CharacterRigidbodyMovement.AdvancedSettings
{
    // Fields
    public float groundCheckDistance;
    public float stickToGroundHelperDistance;
    public float slowDownRate;
    public bool airControl;
    [UnityEngine.TooltipAttribute]
    public float shellOffset;
    
    // Methods
    public CharacterRigidbodyMovement.AdvancedSettings()
    {
        this.groundCheckDistance = 0.01f;
        this.stickToGroundHelperDistance = 0.5f;
        this.slowDownRate = 20f;
    }

}
