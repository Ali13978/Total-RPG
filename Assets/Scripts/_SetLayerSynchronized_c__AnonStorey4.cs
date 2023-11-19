using UnityEngine;
private sealed class PhotonAnimatorView.<SetLayerSynchronized>c__AnonStorey4
{
    // Fields
    internal int layerIndex;
    
    // Methods
    public PhotonAnimatorView.<SetLayerSynchronized>c__AnonStorey4()
    {
    
    }
    internal bool <>m__0(PhotonAnimatorView.SynchronizedLayer item)
    {
        return (bool)(item.LayerIndex == this.layerIndex) ? 1 : 0;
    }

}
