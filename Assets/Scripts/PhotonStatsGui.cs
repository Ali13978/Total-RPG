using UnityEngine;
public class PhotonStatsGui : MonoBehaviour
{
    // Fields
    public bool statsWindowOn;
    public bool statsOn;
    public bool healthStatsVisible;
    public bool trafficStatsOn;
    public bool buttonsOn;
    public UnityEngine.Rect statsRect;
    public int WindowId;
    
    // Methods
    public PhotonStatsGui()
    {
        this.statsWindowOn = true;
        this.statsOn = true;
        this.statsRect = 0;
        this.WindowId = 100;
    }
    public void Start()
    {
        if(S0 > 0f)
        {
                return;
        }
        
        this.statsRect.startFloat = (float)UnityEngine.Screen.width - S0;
    }
    public void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKey(key:  0)) == false)
        {
                return;
        }
        
        bool val_3 = this.statsWindowOn;
        this.statsOn = true;
        val_3 = val_3 ^ 1;
        this.statsWindowOn = val_3;
    }
    public void OnGUI()
    {
        UnityEngine.GUILayoutOption[] val_6;
        var val_7;
        bool val_8;
        var val_9;
        val_6 = 1152921504973725696;
        val_7 = null;
        val_7 = null;
        val_8 = this.statsOn;
        var val_2 = (val_8 == true) ? 1 : 0;
        val_2 = PhotonNetwork.networkingPeer.TrafficStatsEnabled ^ val_2;
        if(val_2 != false)
        {
                val_9 = null;
            val_9 = null;
            val_8 = this.statsOn;
            PhotonNetwork.networkingPeer.TrafficStatsEnabled = (val_8 == true) ? 1 : 0;
        }
        
        if(this.statsWindowOn == false)
        {
                return;
        }
        
        val_6 = "Messages (shift+tab)";
        UnityEngine.Rect val_5 = UnityEngine.GUILayout.Window(id:  0, screenRect:  new UnityEngine.Rect() {m_XMin = this.statsRect, m_YMin = V9.16B, m_Width = V10.16B, m_Height = V11.16B}, func:  this.WindowId, text:  new GUI.WindowFunction(object:  this, method:  public System.Void PhotonStatsGui::TrafficStatsWindow(int windowID)), options:  val_6);
        this.statsRect = val_5;
        mem[1152921512432839956] = val_5.m_YMin;
        mem[1152921512432839960] = val_5.m_Width;
        mem[1152921512432839964] = val_5.m_Height;
    }
    public void TrafficStatsWindow(int windowID)
    {
        var val_40;
        var val_41;
        UnityEngine.GUILayoutOption[] val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        UnityEngine.GUILayoutOption[] val_49;
        UnityEngine.GUILayoutOption[] val_50;
        var val_51;
        string val_52;
        UnityEngine.GUILayoutOption[] val_53;
        val_40 = null;
        val_40 = null;
        ExitGames.Client.Photon.TrafficStatsGameLevel val_1 = PhotonNetwork.networkingPeer.TrafficStatsGameLevel;
        var val_4 = ((PhotonNetwork.networkingPeer.TrafficStatsElapsedMs + 999) < 1999) ? 1 : 18446744073709551;
        UnityEngine.GUILayout.BeginHorizontal(options:  0);
        this.buttonsOn = UnityEngine.GUILayout.Toggle(value:  false, text:  this.buttonsOn, options:  "buttons");
        this.healthStatsVisible = UnityEngine.GUILayout.Toggle(value:  false, text:  this.healthStatsVisible, options:  "health");
        this.trafficStatsOn = UnityEngine.GUILayout.Toggle(value:  false, text:  this.trafficStatsOn, options:  "traffic");
        UnityEngine.GUILayout.EndHorizontal();
        int val_13 = val_1.TotalMessageCount;
        val_41 = 1152921504607592448;
        val_42 = System.String.Format(format:  0, arg0:  "Out {0,4} | In {1,4} | Sum {2,4}", arg1:  val_1.TotalOutgoingMessageCount, arg2:  val_1.TotalIncomingMessageCount);
        string val_15 = System.String.Format(format:  0, arg0:  "{0}sec average:");
        object val_40 = (long)val_1.TotalOutgoingMessageCount;
        val_40 = val_40 / val_4;
        object val_41 = (long)val_1.TotalIncomingMessageCount;
        val_41 = val_41 / val_4;
        var val_42 = (long)val_1.TotalMessageCount;
        val_42 = val_42 / val_4;
        string val_19 = System.String.Format(format:  0, arg0:  "Out {0,4} | In {1,4} | Sum {2,4}", arg1:  val_40, arg2:  val_41);
        val_43 = 1152921506036340832;
        UnityEngine.GUILayout.Label(text:  0, options:  val_42);
        UnityEngine.GUILayout.Label(text:  0, options:  val_15);
        UnityEngine.GUILayout.Label(text:  0, options:  val_19);
        if(this.buttonsOn != false)
        {
                UnityEngine.GUILayout.BeginHorizontal(options:  0);
            val_43 = val_43;
            this.statsOn = UnityEngine.GUILayout.Toggle(value:  false, text:  this.statsOn, options:  "stats on");
            if((UnityEngine.GUILayout.Button(text:  0, options:  "Reset")) != false)
        {
                val_44 = null;
            val_44 = null;
            PhotonNetwork.networkingPeer.TrafficStatsReset();
            PhotonNetwork.networkingPeer.TrafficStatsEnabled = true;
        }
        
            bool val_23 = UnityEngine.GUILayout.Button(text:  0, options:  "To Log");
            UnityEngine.GUILayout.EndHorizontal();
            val_42 = val_42;
        }
        
        val_45 = null;
        val_46 = 1152921504973725696;
        if(this.trafficStatsOn != false)
        {
                UnityEngine.GUILayout.Box(text:  0, options:  "Traffic Stats");
            val_47 = null;
            val_48 = 1152921504608284672;
            ExitGames.Client.Photon.TrafficStats val_24 = PhotonNetwork.networkingPeer.TrafficStatsIncoming;
            val_49 = 0 + "Incoming: \n"("Incoming: \n");
            ExitGames.Client.Photon.TrafficStats val_26 = PhotonNetwork.networkingPeer.TrafficStatsOutgoing;
            val_50 = 0 + "Outgoing: \n"("Outgoing: \n");
            UnityEngine.GUILayout.Label(text:  0, options:  val_49);
            val_41 = null;
            UnityEngine.GUILayout.Label(text:  0, options:  val_50);
            val_45 = null;
        }
        else
        {
                val_50 = System.String.Empty;
            val_48 = 1152921504608284672;
            val_49 = val_50;
        }
        
        if(this.healthStatsVisible != false)
        {
                UnityEngine.GUILayout.Box(text:  0, options:  "Health Stats");
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_1.LongestDeltaBetweenSending;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_1.LongestDeltaBetweenDispatching;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_1.LongestEventCallback;
            typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_1.LongestEventCallbackCode;
            typeof(System.Object[]).__il2cppRuntimeField_39 = 30571557;
            typeof(System.Object[]).__il2cppRuntimeField_40 = val_1.LongestOpResponseCallback;
            typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
            val_48 = 1152921504608284672;
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_1.LongestOpResponseCallbackOpCode;
            typeof(System.Object[]).__il2cppRuntimeField_49 = 30571589;
            val_51 = null;
            val_51 = null;
            typeof(System.Object[]).__il2cppRuntimeField_50 = PhotonNetwork.networkingPeer.RoundTripTime;
            typeof(System.Object[]).__il2cppRuntimeField_54 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_58 = PhotonNetwork.networkingPeer.RoundTripTimeVariance;
            typeof(System.Object[]).__il2cppRuntimeField_5C = 268435457;
            val_52 = val_42;
            typeof(System.Object[]).__il2cppRuntimeField_60 = PhotonNetwork.networkingPeer.ResentReliableCommands;
            typeof(System.Object[]).__il2cppRuntimeField_64 = 268435457;
            val_41 = null;
            val_53 = System.String.Format(format:  0, args:  "ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms");
            UnityEngine.GUILayout.Label(text:  0, options:  val_53);
        }
        else
        {
                val_52 = val_42;
            val_53 = System.String.Empty;
        }
        
        if((0 & 1) != 0)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = val_52;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_15;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_19;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_49;
            typeof(System.Object[]).__il2cppRuntimeField_40 = val_50;
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_53;
            string val_38 = System.String.Format(format:  0, args:  "{0}\n{1}\n{2}\n{3}\n{4}\n{5}");
            UnityEngine.Debug.Log(message:  0);
        }
        
        bool val_39 = UnityEngine.GUI.changed;
        UnityEngine.GUI.DragWindow();
    }

}
