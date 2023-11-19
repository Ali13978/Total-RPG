using UnityEngine;
public class GameCenterFriendLoadExample : MonoBehaviour
{
    // Fields
    private string ChallengeLeaderboard;
    private string ChallengeAchievement;
    public UnityEngine.GUIStyle headerStyle;
    public UnityEngine.GUIStyle boardStyle;
    private bool renderFriendsList;
    
    // Methods
    public GameCenterFriendLoadExample()
    {
        this.ChallengeLeaderboard = "your.leaderboard2.id.here";
        this.ChallengeAchievement = "your.achievement.id.here ";
    }
    private void Awake()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterFriendLoadExample::HandleOnAuthFinished(SA.Common.Models.Result result));
        GameCenterManager.add_OnAuthFinished(value:  null);
        GameCenterManager.Init();
    }
    private void OnGUI()
    {
        var val_16;
        object val_22;
        IntPtr val_23;
        float val_24;
        float val_25;
        var val_26;
        var val_27;
        val_22 = this;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Friend List Load Example");
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_23 = System.Void GameCenterFriendLoadExample::OnFriendsListLoaded(SA.Common.Models.Result result);
            System.Action<SA.Common.Models.Result> val_2 = new System.Action<SA.Common.Models.Result>(object:  this, method:  val_23);
            GameCenterManager.add_OnFriendsListLoaded(value:  null);
        }
        
        val_24 = 500f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GK_FriendRequest val_4 = new GK_FriendRequest();
            Send();
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GK_FriendRequest val_6 = new GK_FriendRequest();
            val_23 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "support@stansassets.com";
            typeof(System.String[]).__il2cppRuntimeField_28 = "test@test.com";
            if(null != 0)
        {
                addRecipientsWithEmailAddresses(emailAddresses:  val_23);
        }
        else
        {
                addRecipientsWithEmailAddresses(emailAddresses:  val_23);
        }
        
            Send();
        }
        
        if(this.renderFriendsList == false)
        {
                return;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                T[] val_9 = GameCenterManager.FriendsList.ToArray();
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                T[] val_12 = GameCenterManager.FriendsList.ToArray();
        }
        
        val_24 = 100f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "id");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "name");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "avatar ");
        List.Enumerator<T> val_14 = GameCenterManager.FriendsList.GetEnumerator();
        val_25 = 650f;
        val_26 = 1;
        val_23 = 70;
        goto label_41;
        label_67:
        val_25 = val_16;
        val_26 = 2;
        val_23 = 70;
        goto label_41;
        label_45:
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_17 = 0.InitializationCallback;
        if((GameCenterManager.GetPlayerById(playerID:  null)) != null)
        {
            goto label_44;
        }
        
        label_41:
        if((0 & 1) != 0)
        {
            goto label_45;
        }
        
        goto label_46;
        label_44:
        var val_19 = 140 + 90;
        val_16 = val_25;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  val_18._PlayerId);
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  val_18._Alias);
        if(0 != val_18._SmallPhoto)
        {
                var val_21 = 140 + 75;
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  0);
        }
        else
        {
                UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "no photo ");
        }
        
        bool val_22 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
            goto label_67;
        }
        
        goto label_67;
        label_46:
        val_22 = 0;
        val_27 = 1;
        0.Dispose();
        if((val_27 & 1) != 0)
        {
                return;
        }
        
        if(val_22 == 0)
        {
                return;
        }
    
    }
    private void HandleOnAuthFinished(SA.Common.Models.Result result)
    {
        if(result.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  "Player Authed");
            return;
        }
        
        IOSNativePopUpManager.showMessage(title:  0, message:  "Game Center ");
    }
    private void OnFriendsListLoaded(SA.Common.Models.Result result)
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameCenterFriendLoadExample::OnFriendsListLoaded(SA.Common.Models.Result result));
        GameCenterManager.remove_OnFriendsListLoaded(value:  null);
        if(result.IsSucceeded == false)
        {
                return;
        }
        
        this.renderFriendsList = true;
    }

}
