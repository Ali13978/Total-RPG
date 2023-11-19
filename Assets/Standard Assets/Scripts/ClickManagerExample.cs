using UnityEngine;
public class ClickManagerExample : MonoBehaviour
{
    // Methods
    public ClickManagerExample()
    {
    
    }
    private void Awake()
    {
        System.Action<GK_Player, System.Byte[]> val_1 = new System.Action<GK_Player, System.Byte[]>(object:  this, method:  System.Void ClickManagerExample::HandleActionDataReceived(GK_Player player, byte[] data));
        GameCenter_RTM.add_ActionDataReceived(value:  0);
    }
    private void Update()
    {
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Camera.main.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        PTPGameController.instance.createGreenSphere(pos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = 1f});
        ObjectCreatePackage val_5 = new ObjectCreatePackage(x:  val_4.x, y:  val_4.y);
        NetworkManagerExample.send(pack:  0);
    }
    private void HandleActionDataReceived(GK_Player player, byte[] data)
    {
        PTPGameController val_7;
        object val_1 = new System.Object();
        typeof(ByteBuffer).__il2cppRuntimeField_10 = data;
        int val_2 = readInt();
        if(val_2 != 1)
        {
            goto label_2;
        }
        
        ISN_Logger.Log(message:  0, logType:  "Sphere pack");
        if(null == 0)
        {
            goto label_3;
        }
        
        float val_3 = readFloat();
        goto label_4;
        label_2:
        val_7 = val_2;
        ISN_Logger.Log(message:  0, logType:  0 + "Got pack wit id: "("Got pack wit id: "));
        return;
        label_3:
        label_4:
        val_7 = PTPGameController.instance;
        val_7.createRedSphere(pos:  new UnityEngine.Vector3() {x = readFloat(), y = readFloat(), z = 0f});
    }

}
