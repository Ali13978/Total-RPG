using UnityEngine;
public class GK_UserInfoLoadResult : Result
{
    // Fields
    private string _playerId;
    private GK_Player _tpl;
    
    // Properties
    public string playerId { get; }
    public GK_Player playerTemplate { get; }
    
    // Methods
    public GK_UserInfoLoadResult(GK_Player tpl)
    {
        this._tpl = tpl;
    }
    public GK_UserInfoLoadResult(string id)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(code:  0, message:  "unknown erro");
        this._playerId = id;
    }
    public string get_playerId()
    {
        return (string)this._playerId;
    }
    public GK_Player get_playerTemplate()
    {
        return (GK_Player)this._tpl;
    }

}
