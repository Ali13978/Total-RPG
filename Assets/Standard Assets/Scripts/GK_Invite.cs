using UnityEngine;
public class GK_Invite
{
    // Fields
    private string _Id;
    private GK_Player _Sender;
    private int _PlayerGroup;
    private int _PlayerAttributes;
    
    // Properties
    public string Id { get; }
    public GK_Player Sender { get; }
    public int PlayerGroup { get; }
    public int PlayerAttributes { get; }
    
    // Methods
    public GK_Invite(string inviteData)
    {
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = inviteData.Split(separator:  null);
        this._Id = val_1[0];
        string val_6 = val_1[1];
        this._Sender = GameCenterManager.GetPlayerById(playerID:  null);
        string val_7 = val_1[2];
        this._PlayerGroup = System.Convert.ToInt32(value:  0);
        string val_8 = val_1[3];
        this._PlayerAttributes = System.Convert.ToInt32(value:  0);
    }
    public string get_Id()
    {
        return (string)this._Id;
    }
    public GK_Player get_Sender()
    {
        return (GK_Player)this._Sender;
    }
    public int get_PlayerGroup()
    {
        return (int)this._PlayerGroup;
    }
    public int get_PlayerAttributes()
    {
        return (int)this._PlayerAttributes;
    }

}
