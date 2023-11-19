using UnityEngine;
[UnityEngine.RequireComponent]
public class ManualPhotonViewAllocator : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Prefab;
    
    // Methods
    public ManualPhotonViewAllocator()
    {
    
    }
    public void AllocateManualPhotonView()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        PhotonView val_2 = Extensions.GetPhotonView(go:  0);
        if(0 == val_2)
        {
                UnityEngine.Debug.LogError(message:  0);
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = PhotonNetwork.AllocateViewID();
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        val_2.RPC(methodName:  "InstantiateRpc", target:  3, parameters:  null);
    }
    [TzarRPC]
    public void InstantiateRpc(int viewID)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = InputToEvent.inputHitPos, y = InputToEvent.inputHitPos.__il2cppRuntimeField_4, z = InputToEvent.inputHitPos.__il2cppRuntimeField_8}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        Extensions.GetPhotonView(go:  0).viewID = viewID;
        OnClickDestroy val_5 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}).GetComponent<OnClickDestroy>();
        val_5.DestroyByRpc = true;
    }

}
