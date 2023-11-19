using UnityEngine;
public class NetworkManagerExample
{
    // Methods
    public NetworkManagerExample()
    {
    
    }
    public static void send(BasePackage pack)
    {
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SendDataToAll(data:  X1.getBytes(), dataMode:  0);
    }

}
