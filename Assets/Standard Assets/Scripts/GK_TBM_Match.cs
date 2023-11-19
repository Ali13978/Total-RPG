using UnityEngine;
public class GK_TBM_Match
{
    // Fields
    public string Id;
    public string Message;
    public GK_TBM_Participant CurrentParticipant;
    public System.DateTime CreationTimestamp;
    public byte[] Data;
    public GK_TurnBasedMatchStatus Status;
    public System.Collections.Generic.List<GK_TBM_Participant> Participants;
    
    // Properties
    public string UTF8StringData { get; }
    public GK_TBM_Participant LocalParticipant { get; }
    
    // Methods
    public GK_TBM_Match()
    {
    
    }
    public void SetData(string val)
    {
        this.Data = System.Convert.FromBase64String(s:  0);
    }
    public string get_UTF8StringData()
    {
        var val_6;
        if(this.Data != null)
        {
                if(System.Text.Encoding.UTF8 != null)
        {
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_270;
        }
        
        }
        else
        {
                val_6 = null;
            val_6 = null;
            return (string)System.String.Empty;
        }
    
    }
    public GK_TBM_Participant GetParticipantByPlayerId(string playerId)
    {
        string val_8;
        var val_9;
        var val_10;
        val_9 = playerId;
        List.Enumerator<T> val_1 = this.Participants.GetEnumerator();
        label_11:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        val_10 = 0.InitializationCallback;
        if(val_10.Player == null)
        {
            goto label_4;
        }
        
        GK_Player val_4 = val_10.Player;
        val_8 = val_4._PlayerId;
        if((val_9.Equals(value:  val_8)) == false)
        {
            goto label_11;
        }
        
        goto label_9;
        label_4:
        if(val_9.Length != 0)
        {
            goto label_11;
        }
        
        label_9:
        0.Dispose();
        return (GK_TBM_Participant)val_10;
        label_2:
        0.Dispose();
        val_10 = 0;
        return (GK_TBM_Participant)val_10;
    }
    public GK_TBM_Participant get_LocalParticipant()
    {
        var val_6;
        List.Enumerator<T> val_1 = this.Participants.GetEnumerator();
        label_10:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        val_6 = 0.InitializationCallback;
        if(val_6.Player == null)
        {
            goto label_10;
        }
        
        GK_Player val_4 = GameCenterManager.Player;
        if((Equals(value:  val_4._PlayerId)) == false)
        {
            goto label_10;
        }
        
        0.Dispose();
        return (GK_TBM_Participant)val_6;
        label_2:
        0.Dispose();
        val_6 = 0;
        return (GK_TBM_Participant)val_6;
    }

}
