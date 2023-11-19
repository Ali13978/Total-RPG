using UnityEngine;
[UnityEngine.RequireComponent]
public class OnClickDestroy : MonoBehaviour
{
    // Fields
    public bool DestroyByRpc;
    
    // Methods
    public OnClickDestroy()
    {
    
    }
    public void OnClick()
    {
        if(this.DestroyByRpc != false)
        {
                this.photonView.RPC(methodName:  "DestroyRpc", target:  3, parameters:  null);
            return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        PhotonNetwork.Destroy(targetGo:  0);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    [TzarRPC]
    public System.Collections.IEnumerator DestroyRpc()
    {
        typeof(OnClickDestroy.<DestroyRpc>c__Iterator0).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
