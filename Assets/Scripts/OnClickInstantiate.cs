using UnityEngine;
public class OnClickInstantiate : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Prefab;
    public int InstantiateType;
    private string[] InstantiateTypeNames;
    public bool showGui;
    
    // Methods
    public OnClickInstantiate()
    {
        typeof(System.String[]).__il2cppRuntimeField_20 = "Mine";
        typeof(System.String[]).__il2cppRuntimeField_28 = "Scene";
        this.InstantiateTypeNames = null;
    }
    private void OnClick()
    {
        byte val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        val_10 = this;
        if(PhotonNetwork.inRoom == false)
        {
                return;
        }
        
        if(this.InstantiateType != 1)
        {
                if(this.InstantiateType != 0)
        {
                return;
        }
        
            val_10 = this.Prefab.name;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = InputToEvent.inputHitPos, y = InputToEvent.inputHitPos.__il2cppRuntimeField_4, z = InputToEvent.inputHitPos.__il2cppRuntimeField_8}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_11 = val_3.x;
            val_12 = val_3.z;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            val_13 = val_4.y;
            val_14 = val_4.z;
            UnityEngine.GameObject val_5 = PhotonNetwork.Instantiate(prefabName:  null, position:  new UnityEngine.Vector3() {x = val_11, y = val_3.y, z = val_12}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_13, z = val_14, w = val_4.w}, group:  val_10);
            return;
        }
        
        val_10 = this.Prefab.name;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = InputToEvent.inputHitPos, y = InputToEvent.inputHitPos.__il2cppRuntimeField_4, z = InputToEvent.inputHitPos.__il2cppRuntimeField_8}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_11 = val_7.x;
        val_12 = val_7.z;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_13 = val_8.y;
        val_14 = val_8.z;
        UnityEngine.GameObject val_9 = PhotonNetwork.InstantiateSceneObject(prefabName:  null, position:  new UnityEngine.Vector3() {x = val_11, y = val_7.y, z = val_12}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_13, z = val_14, w = val_8.w}, group:  val_10, data:  0);
    }
    private void OnGUI()
    {
        if(this.showGui == false)
        {
                return;
        }
        
        int val_2 = UnityEngine.Screen.width - 180;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
        this.InstantiateType = UnityEngine.GUILayout.Toolbar(selected:  0, texts:  this.InstantiateType, options:  this.InstantiateTypeNames);
        UnityEngine.GUILayout.EndArea();
    }

}
