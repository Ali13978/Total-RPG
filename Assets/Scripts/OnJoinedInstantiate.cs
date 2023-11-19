using UnityEngine;
public class OnJoinedInstantiate : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform SpawnPosition;
    public float PositionOffset;
    public UnityEngine.GameObject[] PrefabsToInstantiate;
    
    // Methods
    public OnJoinedInstantiate()
    {
        this.PositionOffset = 2f;
    }
    public void OnJoinedRoom()
    {
        UnityEngine.Transform val_12;
        float val_13;
        float val_14;
        float val_15;
        if(this.PrefabsToInstantiate == null)
        {
                return;
        }
        
        if(this.PrefabsToInstantiate.Length < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.GameObject val_13 = this.PrefabsToInstantiate[0];
            string val_1 = val_13.name;
            string val_2 = 0 + "Instantiating: "("Instantiating: ");
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            val_12 = this.SpawnPosition;
            val_13 = val_3.x;
            val_14 = val_3.y;
            val_15 = val_3.z;
            if(0 != val_12)
        {
                val_12 = this.SpawnPosition;
            UnityEngine.Vector3 val_5 = val_12.position;
            val_13 = val_5.x;
            val_14 = val_5.y;
            val_15 = val_5.z;
        }
        
            UnityEngine.Vector3 val_6 = UnityEngine.Random.insideUnitSphere;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  this.PositionOffset, a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_11 = PhotonNetwork.Instantiate(prefabName:  null, position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, group:  val_13.name);
        }
        while((0 + 1) < this.PrefabsToInstantiate.Length);
    
    }

}
