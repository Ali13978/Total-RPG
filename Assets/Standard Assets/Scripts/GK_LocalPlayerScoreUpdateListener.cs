using UnityEngine;
public class GK_LocalPlayerScoreUpdateListener
{
    // Fields
    private int _RequestId;
    private bool _IsInternal;
    private string _leaderboardId;
    private string _ErrorData;
    private System.Collections.Generic.List<GK_Score> Scores;
    
    // Properties
    public int RequestId { get; }
    
    // Methods
    public GK_LocalPlayerScoreUpdateListener(int requestId, string leaderboardId, bool isInternal)
    {
        this.Scores = new System.Collections.Generic.List<GK_Score>();
        val_2 = new System.Object();
        this._IsInternal = isInternal;
        this._RequestId = requestId;
        this._leaderboardId = val_2;
    }
    public void ReportScoreUpdate(GK_Score score)
    {
        this.Scores.Add(item:  score);
        this.DispatchUpdate();
    }
    public void ReportScoreUpdateFail(string errorData)
    {
        ISN_Logger.Log(message:  0, logType:  "ReportScoreUpdateFail");
        this._ErrorData = errorData;
        this.Scores.Add(item:  0);
        this.DispatchUpdate();
    }
    public int get_RequestId()
    {
        return (int)this._RequestId;
    }
    private void DispatchUpdate()
    {
        var val_7;
        if(this.Scores.Count != 6)
        {
                return;
        }
        
        GK_Leaderboard val_2 = GameCenterManager.GetLeaderboard(id:  null);
        if(this._ErrorData != null)
        {
                SA.Common.Models.Result val_4 = null;
            val_7 = val_4;
            val_4 = new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  this._ErrorData));
        }
        else
        {
                val_2.UpdateCurrentPlayerScore(newScores:  this.Scores);
            SA.Common.Models.Result val_5 = null;
            val_7 = val_5;
            val_5 = new SA.Common.Models.Result();
        }
        
        typeof(GK_LeaderboardResult).__il2cppRuntimeField_18 = val_2;
        var val_6 = (this._IsInternal == true) ? 1 : 0;
        GameCenterManager.DispatchLeaderboardUpdateEvent(result:  null, isInternal:  false);
    }

}
