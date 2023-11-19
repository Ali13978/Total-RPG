using UnityEngine;
public class PTPGameController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject pref;
    private DisconnectButton d;
    private ConnectionButton b;
    private ClickManagerExample m;
    public static PTPGameController instance;
    private System.Collections.Generic.List<UnityEngine.GameObject> spheres;
    
    // Methods
    public PTPGameController()
    {
        this.spheres = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }
    private void Awake()
    {
        PTPGameController.instance = this;
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void PTPGameController::OnAuthFinished(SA.Common.Models.Result res));
        GameCenterManager.add_OnAuthFinished(value:  0);
        GameCenterManager.Init();
        ConnectionButton val_3 = this.gameObject.AddComponent<ConnectionButton>();
        this.b = val_3;
        val_3.enabled = false;
        DisconnectButton val_5 = this.gameObject.AddComponent<DisconnectButton>();
        this.d = val_5;
        val_5.enabled = false;
        ClickManagerExample val_7 = this.gameObject.GetComponent<ClickManagerExample>();
        this.m = val_7;
        val_7.enabled = false;
        System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match> val_8 = new System.Action<GK_Player, GK_PlayerConnectionState, GK_RTM_Match>(object:  this, method:  System.Void PTPGameController::HandleActionPlayerStateChanged(GK_Player player, GK_PlayerConnectionState state, GK_RTM_Match macth));
        GameCenter_RTM.add_ActionPlayerStateChanged(value:  0);
        System.Action<GK_RTM_MatchStartedResult> val_9 = new System.Action<GK_RTM_MatchStartedResult>(object:  this, method:  System.Void PTPGameController::HandleActionMatchStarted(GK_RTM_MatchStartedResult result));
        GameCenter_RTM.add_ActionMatchStarted(value:  0);
    }
    public void createRedSphere(UnityEngine.Vector3 pos)
    {
        var val_12;
        Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
        val_1.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        val_1.GetComponent<UnityEngine.Renderer>().enabled = true;
        if(val_1 != null)
        {
                val_12 = val_1.GetComponent<UnityEngine.Renderer>();
        }
        else
        {
                val_12 = val_1.GetComponent<UnityEngine.Renderer>();
        }
        
        val_12.material = new UnityEngine.Material(source:  val_1.GetComponent<UnityEngine.Renderer>().material);
        UnityEngine.Color val_11 = UnityEngine.Color.red;
        val_1.GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        this.spheres.Add(item:  val_1);
    }
    public void createGreenSphere(UnityEngine.Vector3 pos)
    {
        var val_12;
        Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
        val_1.transform.position = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        val_1.GetComponent<UnityEngine.Renderer>().enabled = true;
        if(val_1 != null)
        {
                val_12 = val_1.GetComponent<UnityEngine.Renderer>();
        }
        else
        {
                val_12 = val_1.GetComponent<UnityEngine.Renderer>();
        }
        
        val_12.material = new UnityEngine.Material(source:  val_1.GetComponent<UnityEngine.Renderer>().material);
        UnityEngine.Color val_11 = UnityEngine.Color.green;
        val_1.GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        this.spheres.Add(item:  val_1);
    }
    private void OnAuthFinished(SA.Common.Models.Result res)
    {
        if(res.IsSucceeded == false)
        {
                return;
        }
        
        string val_5 = GameCenterManager.Player.DisplayName;
        string val_6 = 0 + "ID: "("ID: ") + GameCenterManager.Player.Id + "\nName: "("\nName: ");
        IOSNativePopUpManager.showMessage(title:  0, message:  "Player Authed ");
        this.cleanUpScene();
    }
    private void HandleActionPlayerStateChanged(GK_Player player, GK_PlayerConnectionState state, GK_RTM_Match macth)
    {
        if(state == 2)
        {
                IOSNativePopUpManager.showMessage(title:  0, message:  "Disconnect");
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.Disconnect();
            this.cleanUpScene();
            return;
        }
        
        this.CheckMatchState(macth:  macth);
    }
    private void HandleActionMatchStarted(GK_RTM_MatchStartedResult result)
    {
        var val_7;
        if(result == null)
        {
            goto label_1;
        }
        
        if(result.IsSucceeded == false)
        {
            goto label_4;
        }
        
        goto label_3;
        label_1:
        val_7 = 0.IsSucceeded;
        if(val_7 == false)
        {
            goto label_4;
        }
        
        label_3:
        this.CheckMatchState(macth:  result.Match);
        return;
        label_4:
        string val_6 = result.Error.Message;
        IOSNativePopUpManager.showMessage(title:  0, message:  "Match Start Error");
    }
    private void CheckMatchState(GK_RTM_Match macth)
    {
        var val_6;
        var val_7 = this;
        IOSNativePopUpManager.dismissCurrentAlert();
        if(macth == null)
        {
                return;
        }
        
        val_6 = macth.ExpectedPlayerCount;
        if(val_6 != 0)
        {
                val_7 = macth.ExpectedPlayerCount;
            string val_3 = 0 + "Macth.ExpectedPlayerCount): "("Macth.ExpectedPlayerCount): ");
            IOSNativePopUpManager.showMessage(title:  0, message:  "Match Created");
            return;
        }
        
        string val_4 = 0 + "let\'s play now\n   Macth.ExpectedPlayerCount): "("let\'s play now\n   Macth.ExpectedPlayerCount): ");
        IOSNativePopUpManager.showMessage(title:  0, message:  "Match Started");
        this.m.enabled = true;
        this.b.enabled = false;
        this.d.enabled = true;
        ISN_Logger.Log(message:  0, logType:  "Sending HelloPackage ");
        HelloPackage val_5 = null;
        val_7 = val_5;
        val_5 = new HelloPackage();
        send();
    }
    private void cleanUpScene()
    {
        var val_3;
        var val_4;
        this.b.enabled = true;
        this.m.enabled = false;
        this.d.enabled = false;
        List.Enumerator<T> val_1 = this.spheres.GetEnumerator();
        label_8:
        if((0 & 1) == 0)
        {
            goto label_5;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
        UnityEngine.Object.Destroy(obj:  0);
        goto label_8;
        label_5:
        val_3 = 0;
        val_4 = 1;
        0.Dispose();
        this.spheres.Clear();
    }

}
