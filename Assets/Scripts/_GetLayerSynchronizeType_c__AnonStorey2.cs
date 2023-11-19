using UnityEngine;
private sealed class PhotonAnimatorView.<GetLayerSynchronizeType>c__AnonStorey2
{
    // Fields
    internal int layerIndex;
    
    // Methods
    public PhotonAnimatorView.<GetLayerSynchronizeType>c__AnonStorey2()
    {
    
    }
    internal bool <>m__0(PhotonAnimatorView.SynchronizedLayer item)
    {
        return (bool)(item.LayerIndex == this.layerIndex) ? 1 : 0;
    }

}
