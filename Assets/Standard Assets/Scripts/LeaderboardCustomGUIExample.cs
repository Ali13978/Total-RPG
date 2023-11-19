using UnityEngine;
public class LeaderboardCustomGUIExample : MonoBehaviour
{
    // Fields
    private string leaderboardId_1;
    public int hiScore;
    public UnityEngine.GUIStyle headerStyle;
    public UnityEngine.GUIStyle boardStyle;
    private GK_Leaderboard loadedLeaderboard;
    private GK_CollectionType displayCollection;
    
    // Methods
    public LeaderboardCustomGUIExample()
    {
        this.hiScore = 100;
        this.leaderboardId_1 = "your.ios.leaderbord1.id";
    }
    private void Awake()
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void LeaderboardCustomGUIExample::OnAuthFinished(SA.Common.Models.Result res));
        GameCenterManager.add_OnAuthFinished(value:  0);
        System.Action<GK_LeaderboardResult> val_2 = new System.Action<GK_LeaderboardResult>(object:  this, method:  System.Void LeaderboardCustomGUIExample::OnScoresListLoaded(SA.Common.Models.Result res));
        GameCenterManager.add_OnScoresListLoaded(value:  0);
        GameCenterManager.Init();
    }
    private void OnGUI()
    {
        float val_19;
        float val_24;
        float val_25;
        GK_Leaderboard val_26;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Custom Leaderboard GUI Example");
        val_19 = 50f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GameCenterManager.LoadScore(leaderboardId:  0, startIndex:  this.leaderboardId_1, length:  1, timeSpan:  10, collection:  2);
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                GameCenterManager.LoadScore(leaderboardId:  0, startIndex:  this.leaderboardId_1, length:  1, timeSpan:  20, collection:  2);
        }
        
        UnityEngine.Color val_3 = UnityEngine.GUI.color;
        if(this.displayCollection == 1)
        {
                UnityEngine.Color val_4 = UnityEngine.Color.green;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            val_19 = val_19;
        }
        
        val_24 = 800f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.displayCollection = 1;
        }
        
        UnityEngine.GUI.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        if(this.displayCollection == 0)
        {
                UnityEngine.Color val_6 = UnityEngine.Color.green;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            val_19 = val_19;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.displayCollection = 0;
        }
        
        UnityEngine.GUI.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        val_25 = 90f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "rank");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "score");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "playerId");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "name ");
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "avatar ");
        val_26 = this.loadedLeaderboard;
        if(val_26 == null)
        {
                return;
        }
        
        val_25 = 650f;
        val_24 = 10f;
        goto label_30;
        label_53:
        val_26 = this.loadedLeaderboard;
        label_30:
        GK_Score val_8 = val_26.GetScore(rank:  1, timeSpan:  2, collection:  this.displayCollection);
        if(val_8 != null)
        {
                UnityEngine.GUIStyle val_20 = 1;
            val_20 = val_20 * 70;
            val_20 = val_20 + 90;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  1);
            UnityEngine.GUIStyle val_21 = 1;
            val_21 = val_21 * 70;
            val_21 = val_21 + 90;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  val_8.LongScore);
            UnityEngine.GUIStyle val_22 = 1;
            val_22 = val_22 * 70;
            val_22 = val_22 + 90;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  val_8.PlayerId);
            string val_11 = val_8.PlayerId;
            val_26 = GameCenterManager.GetPlayerById(playerID:  0);
            if(val_26 != null)
        {
                UnityEngine.GUIStyle val_23 = 1;
            val_23 = val_23 * 70;
            val_23 = val_23 + 90;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  val_26.Alias);
            UnityEngine.GUIStyle val_24 = 1;
            if(0 != val_26.SmallPhoto)
        {
                val_24 = val_24 * 70;
            val_24 = val_24 + 75;
            val_26 = val_26.SmallPhoto;
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  0);
        }
        else
        {
                val_24 = val_24 * 70;
            val_24 = val_24 + 90;
            val_26 = this.boardStyle;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  "no photo ");
        }
        
        }
        
            UnityEngine.GUIStyle val_25 = 1;
            val_25 = val_25 * 70;
            val_25 = val_25 + 90;
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_26 = this.leaderboardId_1;
            string val_18 = val_8.PlayerId;
            GameCenterManager.IssueLeaderboardChallenge(leaderboardId:  0, message:  val_26, playerId:  "Your message here");
        }
        
        }
        
        if((1 + 1) <= 9)
        {
            goto label_53;
        }
    
    }
    private void OnScoresListLoaded(SA.Common.Models.Result res)
    {
        var val_4;
        string val_5;
        var val_6;
        val_4 = res;
        bool val_1 = val_4.IsSucceeded;
        if(val_1 != false)
        {
                this.loadedLeaderboard = GameCenterManager.GetLeaderboard(id:  0);
            val_5 = "Success";
            val_6 = "Scores loaded";
        }
        else
        {
                val_5 = "Fail";
            val_6 = "Failed to load scores";
        }
        
        IOSMessage val_3 = IOSMessage.Create(title:  val_1, message:  val_5);
    }
    private void OnAuthFinished(SA.Common.Models.Result res)
    {
        if(res.IsSucceeded == false)
        {
                return;
        }
        
        string val_5 = GameCenterManager.Player.DisplayName;
        string val_6 = 0 + "ID: "("ID: ") + GameCenterManager.Player.Id + "\nName: "("\nName: ");
    }

}
