using UnityEngine;
public class GK_ScoreCollection
{
    // Fields
    public System.Collections.Generic.Dictionary<int, GK_Score> AllTimeScores;
    public System.Collections.Generic.Dictionary<int, GK_Score> WeekScores;
    public System.Collections.Generic.Dictionary<int, GK_Score> TodayScores;
    
    // Methods
    public GK_ScoreCollection()
    {
        this.AllTimeScores = new System.Collections.Generic.Dictionary<System.Int32, GK_Score>();
        this.WeekScores = new System.Collections.Generic.Dictionary<System.Int32, GK_Score>();
        this.TodayScores = new System.Collections.Generic.Dictionary<System.Int32, GK_Score>();
    }

}
