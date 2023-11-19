using UnityEngine;
public class PhotonLagSimulationGui : MonoBehaviour
{
    // Fields
    public UnityEngine.Rect WindowRect;
    public int WindowId;
    public bool Visible;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private ExitGames.Client.Photon.PhotonPeer <Peer>k__BackingField;
    
    // Properties
    public ExitGames.Client.Photon.PhotonPeer Peer { get; set; }
    
    // Methods
    public PhotonLagSimulationGui()
    {
        this.WindowId = 101;
        this.WindowRect = 0;
        this.Visible = true;
    }
    public ExitGames.Client.Photon.PhotonPeer get_Peer()
    {
        return (ExitGames.Client.Photon.PhotonPeer)this.<Peer>k__BackingField;
    }
    public void set_Peer(ExitGames.Client.Photon.PhotonPeer value)
    {
        this.<Peer>k__BackingField = value;
    }
    public void Start()
    {
        null = null;
        this.<Peer>k__BackingField = PhotonNetwork.networkingPeer;
    }
    public void OnGUI()
    {
        IntPtr val_3;
        if(this.Visible == false)
        {
                return;
        }
        
        if((this.<Peer>k__BackingField) != null)
        {
                val_3 = 1152921512406827088;
        }
        else
        {
                val_3 = 1152921512406828112;
        }
        
        UnityEngine.Rect val_2 = UnityEngine.GUILayout.Window(id:  0, screenRect:  new UnityEngine.Rect() {m_XMin = this.WindowRect, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, func:  this.WindowId, text:  new GUI.WindowFunction(object:  this, method:  val_3), options:  "Netw. Sim.");
        this.WindowRect = val_2;
        mem[1152921512406853260] = val_2.m_YMin;
        mem[1152921512406853264] = val_2.m_Width;
        mem[1152921512406853268] = val_2.m_Height;
    }
    private void NetSimHasNoPeerWindow(int windowId)
    {
        UnityEngine.GUILayout.Label(text:  0, options:  "No peer to communicate with. ");
    }
    private void NetSimWindow(int windowId)
    {
        int val_2 = this.<Peer>k__BackingField.RoundTripTimeVariance;
        UnityEngine.GUILayout.Label(text:  0, options:  System.String.Format(format:  0, arg0:  "Rtt:{0,4} +/-{1,3}", arg1:  this.<Peer>k__BackingField.RoundTripTime));
        ExitGames.Client.Photon.PhotonPeer val_4 = (this.<Peer>k__BackingField) & 1;
        bool val_5 = UnityEngine.GUILayout.Toggle(value:  false, text:  val_4, options:  "Simulate");
        if((((this.<Peer>k__BackingField) ^ val_5) & 1) != 0)
        {
                val_4 = val_5;
        }
        
        UnityEngine.GUILayout.Label(text:  0, options:  0 + "Lag ");
        this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingLag = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingLag, leftValue:  0f, rightValue:  500f, options:  0);
        this.<Peer>k__BackingField.NetworkSimulationSettings.OutgoingLag = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingLag, leftValue:  0f, rightValue:  500f, options:  0);
        UnityEngine.GUILayout.Label(text:  0, options:  0 + "Jit ");
        this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingJitter = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingJitter, leftValue:  0f, rightValue:  100f, options:  0);
        this.<Peer>k__BackingField.NetworkSimulationSettings.OutgoingJitter = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingJitter, leftValue:  0f, rightValue:  100f, options:  0);
        UnityEngine.GUILayout.Label(text:  0, options:  0 + "Loss ");
        this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage, leftValue:  0f, rightValue:  10f, options:  0);
        this.<Peer>k__BackingField.NetworkSimulationSettings.OutgoingLossPercentage = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<Peer>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage, leftValue:  0f, rightValue:  10f, options:  0);
        bool val_25 = UnityEngine.GUI.changed;
        UnityEngine.GUI.DragWindow();
    }

}
