using UnityEngine;
private class TH_CharacterAnim_Legacy.CustomAnimData
{
    // Fields
    public string AnimName;
    public bool ReturnAfterFinish;
    
    // Methods
    public TH_CharacterAnim_Legacy.CustomAnimData(string animName, bool returnAfterFinish)
    {
        this.ReturnAfterFinish = returnAfterFinish;
        this.AnimName = animName;
    }

}
