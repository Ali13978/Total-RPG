using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    internal static class Codecs
    {
        // Fields
        private static bool initialized;
        private const short NetworkPlayerSize = 4;
        private const short NetMessageSize = 12;
        private const short NetViewIdSize = 4;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache0;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache1;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache2;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache3;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache4;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache5;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache6;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache7;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache8;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache9;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cacheA;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cacheB;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cacheC;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cacheD;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cacheE;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cacheF;
        private static ExitGames.Client.Photon.SerializeStreamMethod <>f__mg$cache10;
        private static ExitGames.Client.Photon.DeserializeStreamMethod <>f__mg$cache11;
        
        // Methods
        public static void Initialize()
        {
            byte val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            val_38 = null;
            val_38 = null;
            if(TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.NetViewIdSize != 0)
            {
                    return;
            }
            
            val_39 = null;
            val_39 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache0) == null)
            {
                    val_40 = null;
                val_40 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache0 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteBitstream(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_39 = null;
            }
            
            val_39 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache1) == null)
            {
                    val_41 = null;
                val_41 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache1 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadBitstream(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_39 = null;
            }
            
            val_39 = null;
            bool val_4 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  255, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache0);
            val_42 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache2) == null)
            {
                    val_43 = null;
                val_43 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache2 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteBitstream(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_42 = null;
            }
            
            val_42 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache3) == null)
            {
                    val_44 = null;
                val_44 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache3 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadBitstream(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_42 = null;
            }
            
            val_42 = null;
            bool val_8 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  254, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache2);
            val_45 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache4) == null)
            {
                    val_46 = null;
                val_46 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache4 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteNetworkPlayer(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_45 = null;
            }
            
            val_45 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache5) == null)
            {
                    val_47 = null;
                val_47 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache5 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadNetworkPlayer(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_45 = null;
            }
            
            val_45 = null;
            bool val_12 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  253, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache4);
            val_48 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache6) == null)
            {
                    val_49 = null;
                val_49 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache6 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteNetworkPlayer(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_48 = null;
            }
            
            val_48 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache7) == null)
            {
                    val_50 = null;
                val_50 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache7 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadNetworkPlayer(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_48 = null;
            }
            
            val_48 = null;
            bool val_16 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  252, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache6);
            val_51 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache8) == null)
            {
                    val_52 = null;
                val_52 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache8 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteNetMessageInfo(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_51 = null;
            }
            
            val_51 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache9) == null)
            {
                    val_53 = null;
                val_53 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache9 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadNetMessageInfo(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_51 = null;
            }
            
            val_51 = null;
            bool val_20 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  251, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache8);
            val_54 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheA) == null)
            {
                    val_55 = null;
                val_55 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheA = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteNetMessageInfo(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_54 = null;
            }
            
            val_54 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheB) == null)
            {
                    val_56 = null;
                val_56 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheB = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadNetMessageInfo(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_54 = null;
            }
            
            val_54 = null;
            bool val_24 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  250, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheA);
            val_57 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheC) == null)
            {
                    val_58 = null;
                val_58 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheC = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteNetworkViewID(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_57 = null;
            }
            
            val_57 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheD) == null)
            {
                    val_59 = null;
                val_59 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheD = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadNetworkViewID(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_57 = null;
            }
            
            val_57 = null;
            bool val_28 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  249, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheC);
            val_60 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheE) == null)
            {
                    val_61 = null;
                val_61 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheE = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteNetworkViewID(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_60 = null;
            }
            
            val_60 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheF) == null)
            {
                    val_62 = null;
                val_62 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheF = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadNetworkViewID(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_60 = null;
            }
            
            val_60 = null;
            bool val_32 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), serializeMethod:  248, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cacheE);
            val_63 = null;
            val_37 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache10) == null)
            {
                    val_64 = null;
                val_64 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache10 = new ExitGames.Client.Photon.SerializeStreamMethod(object:  0, method:  static System.Int16 TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::WriteUint32(ExitGames.Client.Photon.StreamBuffer outStream, object customobject));
                val_63 = null;
            }
            
            val_63 = null;
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache11) == null)
            {
                    val_65 = null;
                val_65 = null;
                TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache11 = new ExitGames.Client.Photon.DeserializeStreamMethod(object:  0, method:  static System.Object TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs::ReadUint32(ExitGames.Client.Photon.StreamBuffer inStream, short length));
                val_63 = null;
            }
            
            val_63 = null;
            bool val_36 = ExitGames.Client.Photon.PhotonPeer.RegisterType(customType:  0, code:  val_37, serializeMethod:  247, constructor:  TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.<>f__mg$cache10);
            TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.NetViewIdSize = 1;
        }
        private static short WriteBitstream(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
        {
            UnityEngine.Debug.LogError(message:  0);
            return 0;
        }
        private static object ReadBitstream(ExitGames.Client.Photon.StreamBuffer inStream, short length)
        {
            UnityEngine.Debug.LogError(message:  0);
            return 0;
        }
        private static short WriteNetworkPlayer(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
        {
            TzarGames.GameFramework.NetworkPlayer val_2;
            System.Byte[] val_6;
            var val_7;
            val_6 = X2;
            val_7 = null;
            val_6 = 0;
            short val_5 = TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.WriteNetworkPlayer_Internal(player:  val_2, bytes: ref  val_6, index: ref  null);
            if(customobject != null)
            {
                    return 4;
            }
            
            return 4;
        }
        private static short WriteNetworkPlayer_Internal(TzarGames.GameFramework.NetworkPlayer player, ref byte[] bytes, ref int index)
        {
            var val_6;
            System.Byte[] val_7;
            val_6 = X3;
            val_7 = 1152921511040162864;
            PhotonPlayer val_1 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativeNetworkPlayer(player:  null);
            if(val_1 != null)
            {
                    if((val_1.ID & 2147483648) != 0)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
            }
            
                val_7 = val_1.ID;
                ExitGames.Client.Photon.Protocol.Serialize(value:  0, target:  val_7, targetOffset: ref  index);
                return 4;
            }
            
            val_6 = 0 + "Null native net player, net ID: "("Null native net player, net ID: ");
            UnityEngine.Debug.LogError(message:  0);
            return 4;
        }
        private static object ReadNetworkPlayer(ExitGames.Client.Photon.StreamBuffer inStream, short length)
        {
            var val_5;
            ExitGames.Client.Photon.Protocol.Deserialize(value: out  0, source:  0, offset: ref  null);
            if((TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativePlayerByID(id:  282587136)) != null)
            {
                    TzarGames.GameFramework.NetworkPlayer val_4 = TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  null);
                return (object)val_5;
            }
            
            val_5 = 0;
            return (object)val_5;
        }
        private static short WriteNetMessageInfo(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
        {
            System.Byte[] val_8;
            var val_9;
            var val_10;
            var val_11;
            TzarGames.GameFramework.NetworkPlayer val_12;
            var val_13;
            if(X2 == 0)
            {
                goto label_1;
            }
            
            val_8 = X2;
            if(val_8 == 0)
            {
                goto label_2;
            }
            
            val_9 = 0;
            val_10 = val_8;
            goto label_3;
            label_2:
            label_1:
            val_8 = 0;
            val_10 = 0;
            val_9 = 1;
            label_3:
            if(mem[282584257676929] == 0)
            {
                goto label_4;
            }
            
            var val_6 = mem[282584257676823];
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < mem[282584257676929])
            {
                goto label_6;
            }
            
            label_4:
            val_11 = val_10;
            goto label_7;
            label_5:
            val_10 = val_10 + (((mem[282584257676823] + 8)) << 4);
            val_11 = val_10 + 272;
            label_7:
            val_12 = val_8;
            val_12 = null;
            short val_4 = TzarGames.GameFramework.NetworkSubsystem_Photon.Codecs.WriteNetworkPlayer_Internal(player:  val_12, bytes: ref  val_12, index: ref  null);
            var val_11 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_11;
            }
            
            var val_8 = mem[282584257676823];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_13:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < mem[282584257676929])
            {
                goto label_13;
            }
            
            label_11:
            val_13 = val_10;
            goto label_14;
            label_12:
            var val_10 = val_8;
            val_10 = val_10 + 1;
            val_11 = val_11 + val_10;
            val_13 = val_11 + 272;
            label_14:
            ExitGames.Client.Photon.Protocol.Serialize(value:  (float)V0.16B, target:  0, targetOffset: ref  null);
            if(customobject != null)
            {
                    return 12;
            }
            
            return 12;
        }
        private static object ReadNetMessageInfo(ExitGames.Client.Photon.StreamBuffer inStream, short length)
        {
            ExitGames.Client.Photon.Protocol.Deserialize(value: out  0, source:  0, offset: ref  null);
            ExitGames.Client.Photon.Protocol.Deserialize(value: out  0f, source:  0, offset: ref  null);
            return (object)TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.CreateNetworkMessageInfo(player:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetOrCreatePlayerByNativeNetworkPlayer(nativePlayer:  TzarGames.GameFramework.NetworkSubsystem_Photon.Network_Photon.GetNativePlayerByID(id:  282587136)), timeStamp:  (double)0);
        }
        private static short WriteNetworkViewID(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
        {
            X2 = 0;
            ExitGames.Client.Photon.Protocol.Serialize(value:  0, target:  11993091, targetOffset: ref  null);
            if(customobject != null)
            {
                    return 4;
            }
            
            return 4;
        }
        private static object ReadNetworkViewID(ExitGames.Client.Photon.StreamBuffer inStream, short length)
        {
            ExitGames.Client.Photon.Protocol.Deserialize(value: out  0, source:  0, offset: ref  null);
            typeof(Network_Photon.NetworkViewID_Photon).__il2cppRuntimeField_10 = 0;
            return (object)new TzarGames.GameFramework.NetworkViewID();
        }
        private static short WriteUint32(ExitGames.Client.Photon.StreamBuffer outStream, object customobject)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if((System.BitConverter.GetBytes(value:  0)) != null)
            {
                    return (short)val_2.Length;
            }
            
            return (short)val_2.Length;
        }
        private static object ReadUint32(ExitGames.Client.Photon.StreamBuffer inStream, short length)
        {
            return (object)System.BitConverter.ToUInt32(value:  0, startIndex:  460851360);
        }
        private static Codecs()
        {
        
        }
    
    }

}
