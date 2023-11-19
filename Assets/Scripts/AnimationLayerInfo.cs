using UnityEngine;
[Serializable]
private class TH_CharacterAnim.AnimationLayerInfo
{
    // Fields
    public string AnimationName;
    public int LayerIndex;
    public string Tag;
    
    // Properties
    public int AnimationNameHash { get; }
    
    // Methods
    public TH_CharacterAnim.AnimationLayerInfo()
    {
    
    }
    public int get_AnimationNameHash()
    {
        return UnityEngine.Animator.StringToHash(name:  0);
    }

}
