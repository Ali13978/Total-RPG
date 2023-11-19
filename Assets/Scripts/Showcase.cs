using UnityEngine;
protected class TH_CharacterAnim_Legacy.Showcase : TH_CharacterAnim_Legacy.CharacterAnimState
{
    // Methods
    public TH_CharacterAnim_Legacy.Showcase()
    {
    
    }
    public override void Update()
    {
        this.Animation.CrossfadeMovement(fadeLength:  0.2f);
    }

}
