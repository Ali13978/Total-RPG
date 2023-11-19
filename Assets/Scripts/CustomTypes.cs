using UnityEngine;
internal static class CustomTypes
{
    // Fields
    public static readonly byte[] memVector3;
    public static readonly byte[] memVector2;
    public static readonly byte[] memQuarternion;
    public static readonly byte[] memPlayer;
    private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache0;
    private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache1;
    private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache2;
    private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache3;
    private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache4;
    private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache5;
    private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache6;
    private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache7;
    
    // Methods
    internal static void Register()
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_17 = null;
        val_17 = null;
        if((CustomTypes.<>f__mg$cache0) == null)
        {
                val_18 = null;
            val_18 = null;
            CustomTypes.<>f__mg$cache0 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 CustomTypes::SerializeVector2(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
            val_17 = null;
        }
        
        val_17 = null;
        if((CustomTypes.<>f__mg$cache1) == null)
        {
                val_19 = null;
            val_19 = null;
            CustomTypes.<>f__mg$cache1 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object CustomTypes::DeserializeVector2(ExitGames.Client.Photon.StreamBuffer inStream, short length));
            val_17 = null;
        }
        
        val_17 = null;
        bool val_4 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  87, constructor:  CustomTypes.<>f__mg$cache0);
        val_20 = null;
        if((CustomTypes.<>f__mg$cache2) == null)
        {
                val_21 = null;
            val_21 = null;
            CustomTypes.<>f__mg$cache2 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 CustomTypes::SerializeVector3(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
            val_20 = null;
        }
        
        val_20 = null;
        if((CustomTypes.<>f__mg$cache3) == null)
        {
                val_22 = null;
            val_22 = null;
            CustomTypes.<>f__mg$cache3 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object CustomTypes::DeserializeVector3(ExitGames.Client.Photon.StreamBuffer inStream, short length));
            val_20 = null;
        }
        
        val_20 = null;
        bool val_8 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  86, constructor:  CustomTypes.<>f__mg$cache2);
        val_23 = null;
        if((CustomTypes.<>f__mg$cache4) == null)
        {
                val_24 = null;
            val_24 = null;
            CustomTypes.<>f__mg$cache4 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 CustomTypes::SerializeQuaternion(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
            val_23 = null;
        }
        
        val_23 = null;
        if((CustomTypes.<>f__mg$cache5) == null)
        {
                val_25 = null;
            val_25 = null;
            CustomTypes.<>f__mg$cache5 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object CustomTypes::DeserializeQuaternion(ExitGames.Client.Photon.StreamBuffer inStream, short length));
            val_23 = null;
        }
        
        val_23 = null;
        bool val_12 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  81, constructor:  CustomTypes.<>f__mg$cache4);
        val_26 = null;
        if((CustomTypes.<>f__mg$cache6) == null)
        {
                val_27 = null;
            val_27 = null;
            CustomTypes.<>f__mg$cache6 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 CustomTypes::SerializePhotonPlayer(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
            val_26 = null;
        }
        
        val_26 = null;
        if((CustomTypes.<>f__mg$cache7) == null)
        {
                val_28 = null;
            val_28 = null;
            CustomTypes.<>f__mg$cache7 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object CustomTypes::DeserializePhotonPlayer(ExitGames.Client.Photon.StreamBuffer inStream, short length));
            val_26 = null;
        }
        
        val_26 = null;
        bool val_16 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  80, constructor:  CustomTypes.<>f__mg$cache6);
    }
    private static short SerializeVector3(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
    {
        var val_6;
        var val_7;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_6 = null;
        val_6 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_7 = null;
        val_7 = null;
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2, target:  0, targetOffset: ref  CustomTypes.memVector3);
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2 + 4, target:  0, targetOffset: ref  CustomTypes.memVector3);
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2 + 8, target:  0, targetOffset: ref  CustomTypes.memVector3);
        System.Threading.Monitor.Exit(obj:  0);
        return 12;
    }
    private static object DeserializeVector3(ExitGames.Client.Photon.StreamBuffer inStream, short length)
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_8 = null;
        val_8 = null;
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memVector3);
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memVector3);
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memVector3);
        System.Threading.Monitor.Exit(obj:  0);
        return (object)0;
    }
    private static short SerializeVector2(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
    {
        var val_5;
        var val_6;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_5 = null;
        val_5 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_6 = null;
        val_6 = null;
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2, target:  0, targetOffset: ref  CustomTypes.memVector2);
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2 + 4, target:  0, targetOffset: ref  CustomTypes.memVector2);
        System.Threading.Monitor.Exit(obj:  0);
        return 8;
    }
    private static object DeserializeVector2(ExitGames.Client.Photon.StreamBuffer inStream, short length)
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_6 = null;
        val_6 = null;
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memVector2);
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memVector2);
        System.Threading.Monitor.Exit(obj:  0);
        return (object)0;
    }
    private static short SerializeQuaternion(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
    {
        var val_7;
        var val_8;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_7 = null;
        val_7 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_8 = null;
        val_8 = null;
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2 + 8 + 4, target:  0, targetOffset: ref  CustomTypes.memQuarternion);
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2, target:  0, targetOffset: ref  CustomTypes.memQuarternion);
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2 + 4, target:  0, targetOffset: ref  CustomTypes.memQuarternion);
        ExitGames.Client.Photon.Protocol.Serialize(value:  X2 + 8, target:  0, targetOffset: ref  CustomTypes.memQuarternion);
        System.Threading.Monitor.Exit(obj:  0);
        return 16;
    }
    private static object DeserializeQuaternion(ExitGames.Client.Photon.StreamBuffer inStream, short length)
    {
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_10 = null;
        val_10 = null;
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memQuarternion);
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memQuarternion);
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memQuarternion);
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  CustomTypes.memQuarternion);
        System.Threading.Monitor.Exit(obj:  0);
        return (object)0;
    }
    private static short SerializePhotonPlayer(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = X2;
        if(val_7 != 0)
        {
            
        }
        
        val_7 = 0;
        val_8 = null;
        val_8 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_9 = null;
        val_9 = null;
        ExitGames.Client.Photon.Protocol.Serialize(value:  0, target:  val_7.ID, targetOffset: ref  CustomTypes.memPlayer);
        System.Threading.Monitor.Exit(obj:  0);
        return 4;
    }
    private static object DeserializePhotonPlayer(ExitGames.Client.Photon.StreamBuffer inStream, short length)
    {
        var val_5;
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.Int32, PhotonPlayer> val_8;
        var val_9;
        var val_10;
        val_5 = null;
        val_5 = null;
        System.Threading.Monitor.Enter(obj:  0);
        val_6 = null;
        val_6 = null;
        ExitGames.Client.Photon.Protocol.Deserialize(value: out  0, source:  0, offset: ref  CustomTypes.memPlayer);
        System.Threading.Monitor.Exit(obj:  0);
        val_7 = null;
        val_7 = null;
        val_8 = mem[PhotonNetwork.networkingPeer + 424];
        val_8 = PhotonNetwork.networkingPeer.mActors;
        if((ContainsKey(key:  0)) != false)
        {
                val_9 = null;
            val_9 = null;
            val_8 = mem[PhotonNetwork.networkingPeer + 424];
            val_8 = PhotonNetwork.networkingPeer.mActors;
            PhotonPlayer val_4 = Item[0];
            return (object)val_10;
        }
        
        val_10 = 0;
        return (object)val_10;
    }
    private static CustomTypes()
    {
        CustomTypes.memVector3 = null;
        CustomTypes.memVector2 = null;
        CustomTypes.memQuarternion = null;
        CustomTypes.memPlayer = null;
    }

}
