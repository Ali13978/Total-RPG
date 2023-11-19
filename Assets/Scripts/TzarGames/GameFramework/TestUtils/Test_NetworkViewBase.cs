using UnityEngine;

namespace TzarGames.GameFramework.TestUtils
{
    public class Test_NetworkViewBase : TzarBehaviour, ISerializeView
    {
        // Methods
        public Test_NetworkViewBase()
        {
        
        }
        [TzarRPC]
        private void to_server_reliable(string message)
        {
            string val_1 = 0 + "Message from client: "("Message from client: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_bytes(byte[] dataBytes)
        {
            UnityEngine.Debug.Log(message:  0);
            TestJsonData val_2 = Test_NetworkViewBase.TestJsonData.Deserialize(data:  TzarGames.Common.Utils.GetStringFromBytes(bytes:  0));
            string val_3 = 0 + "I: "("I: ");
            UnityEngine.Debug.Log(message:  0);
            string val_4 = 0 + "F: "("F: ");
            UnityEngine.Debug.Log(message:  0);
            string val_5 = 0 + "S: "("S: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_reliable(string message)
        {
            string val_1 = 0 + "Message from server: "("Message from server: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_player_empty()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_player_otherplayer(TzarGames.GameFramework.NetworkPlayer player)
        {
            string val_1 = 0 + "RPC for specific player from server with other player: "("RPC for specific player from server with other player: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_player(TzarGames.GameFramework.NetworkPlayer player)
        {
            string val_1 = 0 + "Player from server: "("Player from server: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_server_player(TzarGames.GameFramework.NetworkPlayer player)
        {
            string val_1 = 0 + "Player from client: "("Player from client: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_server_reliable_with_message(string message, TzarGames.GameFramework.INetworkMessageInfo info)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = info;
            TzarGames.GameFramework.Player val_4 = TzarGames.GameFramework.GameManager.Instance.Net.GetPlayerByNetPlayer(netPlayer:  info);
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Message from client: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = message;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " with message info ";
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = info;
            typeof(System.Object[]).__il2cppRuntimeField_38 = info;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " timestamp: ";
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = info;
            typeof(System.Object[]).__il2cppRuntimeField_48 = ???;
            typeof(System.Object[]).__il2cppRuntimeField_50 = " player ";
            typeof(System.Object[]).__il2cppRuntimeField_58 = val_4.<Login>k__BackingField;
            string val_7 = +0;
            UnityEngine.Debug.Log(message:  0);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = info;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Hello from server!";
            this.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.String>(object:  this, method:  System.Void TzarGames.GameFramework.TestUtils.Test_NetworkViewBase::answer_to_client_reliable(string message)), target:  info, parameters:  null);
        }
        [TzarRPC]
        private void answer_to_client_reliable(string message)
        {
            string val_1 = 0 + "Answer from server: "("Answer from server: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_reliable_with_message(string message, TzarGames.GameFramework.INetworkMessageInfo info)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = info;
            TzarGames.GameFramework.Player val_4 = TzarGames.GameFramework.GameManager.Instance.Net.GetPlayerByNetPlayer(netPlayer:  info);
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Message from server: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = message;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " with message info: ";
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = info;
            typeof(System.Object[]).__il2cppRuntimeField_38 = info;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " timestamp: ";
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = info;
            typeof(System.Object[]).__il2cppRuntimeField_48 = ???;
            typeof(System.Object[]).__il2cppRuntimeField_50 = " player ";
            typeof(System.Object[]).__il2cppRuntimeField_58 = val_4.<Login>k__BackingField;
            string val_7 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarRPC]
        private void to_client_double_with_message(double message, TzarGames.GameFramework.INetworkMessageInfo info)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = info;
            TzarGames.GameFramework.Player val_4 = TzarGames.GameFramework.GameManager.Instance.Net.GetPlayerByNetPlayer(netPlayer:  info);
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Double from server: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = message;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " with message info: ";
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = info;
            typeof(System.Object[]).__il2cppRuntimeField_38 = info;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " timestamp: ";
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = info;
            typeof(System.Object[]).__il2cppRuntimeField_48 = message;
            typeof(System.Object[]).__il2cppRuntimeField_50 = " player ";
            typeof(System.Object[]).__il2cppRuntimeField_58 = val_4.<Login>k__BackingField;
            string val_7 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        private void OnEnable()
        {
            this.MyNetworkView.RegisterSerializableComponent(serializedComponent:  this);
        }
        private void OnDisable()
        {
            this.MyNetworkView.UnregisterSerializableComponent(serializedComponent:  this);
        }
        public void OnSerializeEvent(TzarGames.GameFramework._IBitStream stream, TzarGames.GameFramework.INetworkMessageInfo messageInfo)
        {
            TzarGames.GameFramework._IBitStream val_13;
            TzarGames.GameFramework._IBitStream val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            float val_23;
            var val_24;
            var val_25;
            var val_26;
            float val_27;
            var val_28;
            var val_29;
            val_13 = stream;
            val_14 = 1152921504912384000;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = val_13;
            if((val_13 & 1) == 0)
            {
                goto label_6;
            }
            
            val_16 = 0;
            UnityEngine.Debug.Log(message:  0);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = 4;
            val_17 = val_13;
            goto label_13;
            label_6:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_18 = val_13;
            goto label_18;
            label_13:
            val_19 = 0;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_19 = 0;
            val_20 = val_13;
            goto label_23;
            label_18:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_21 = val_13;
            goto label_28;
            label_23:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = 1;
            val_22 = val_13;
            goto label_33;
            label_28:
            val_23 = V0.16B;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_24 = val_13;
            goto label_38;
            label_33:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_25 = val_13;
            goto label_43;
            label_38:
            val_14 = val_13;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_26 = val_13;
            goto label_48;
            label_43:
            val_23 = 0f;
            val_27 = 0f;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_28 = val_13;
            return;
            label_48:
            val_27 = V1.16B;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_29 = val_13;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_13;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_23;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_14;
            typeof(System.Object[]).__il2cppRuntimeField_38 = V0.16B;
            typeof(System.Object[]).__il2cppRuntimeField_40 = V0.16B;
            val_13 = System.String.Format(format:  0, args:  "Reading test stream: {0} {1} {2} {3} {4}");
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
