using UnityEngine;
public class GK_FriendRequest
{
    // Fields
    private int _Id;
    private System.Collections.Generic.List<string> _PlayersIds;
    private System.Collections.Generic.List<string> _Emails;
    
    // Properties
    public int Id { get; }
    
    // Methods
    public GK_FriendRequest()
    {
        this._PlayersIds = new System.Collections.Generic.List<System.String>();
        this._Emails = new System.Collections.Generic.List<System.String>();
        this._Id = SA.Common.Util.IdFactory.NextId;
    }
    public void addRecipientsWithEmailAddresses(string[] emailAddresses)
    {
        goto label_1;
        label_8:
        0 = 1;
        label_1:
        if(0 >= emailAddresses.Length)
        {
                return;
        }
        
        string val_2 = emailAddresses[1];
        emailAddresses[1] = this._Emails.Contains(item:  val_2);
        if(emailAddresses[1] == true)
        {
            goto label_8;
        }
        
        this._Emails.Add(item:  val_2);
        goto label_8;
    }
    public void addRecipientPlayers(GK_Player[] players)
    {
        goto label_1;
        label_10:
        0 = 1;
        label_1:
        if(0 >= players.Length)
        {
                return;
        }
        
        GK_Player val_3 = players[1];
        if((this._PlayersIds.Contains(item:  players[0x1][0]._PlayerId)) == true)
        {
            goto label_10;
        }
        
        this._PlayersIds.Add(item:  players[0x1][0]._PlayerId);
        goto label_10;
    }
    public void Send()
    {
        GameCenterManager.SendFriendRequest(request:  null, emails:  this, players:  null);
    }
    public int get_Id()
    {
        return (int)this._Id;
    }

}
