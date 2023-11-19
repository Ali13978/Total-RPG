using UnityEngine;
public class GK_LeaderboardSet
{
    // Fields
    public string Title;
    public string Identifier;
    public string GroupIdentifier;
    public System.Collections.Generic.List<GK_LeaderBoardInfo> _BoardsInfo;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<ISN_LoadSetLeaderboardsInfoResult> OnLoaderboardsInfoLoaded;
    private static System.Action<ISN_LoadSetLeaderboardsInfoResult> <>f__am$cache0;
    
    // Properties
    public System.Collections.Generic.List<GK_LeaderBoardInfo> BoardsInfo { get; }
    
    // Methods
    public GK_LeaderboardSet()
    {
        var val_3;
        this._BoardsInfo = new System.Collections.Generic.List<GK_LeaderBoardInfo>();
        val_3 = null;
        if((GK_LeaderboardSet.<>f__am$cache0) == null)
        {
                GK_LeaderboardSet.<>f__am$cache0 = new System.Action<ISN_LoadSetLeaderboardsInfoResult>(object:  0, method:  static System.Void GK_LeaderboardSet::<OnLoaderboardsInfoLoaded>m__0(ISN_LoadSetLeaderboardsInfoResult ));
            val_3 = null;
        }
        
        this.OnLoaderboardsInfoLoaded = GK_LeaderboardSet.<>f__am$cache0;
    }
    public void add_OnLoaderboardsInfoLoaded(System.Action<ISN_LoadSetLeaderboardsInfoResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnLoaderboardsInfoLoaded);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510239490944 != this.OnLoaderboardsInfoLoaded);
    
    }
    public void remove_OnLoaderboardsInfoLoaded(System.Action<ISN_LoadSetLeaderboardsInfoResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnLoaderboardsInfoLoaded);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510239627520 != this.OnLoaderboardsInfoLoaded);
    
    }
    public void LoadLeaderBoardsInfo()
    {
    
    }
    public void AddBoardInfo(GK_LeaderBoardInfo info)
    {
        this._BoardsInfo.Add(item:  info);
    }
    public void SendFailLoadEvent()
    {
        this.OnLoaderboardsInfoLoaded.Invoke(obj:  new ISN_LoadSetLeaderboardsInfoResult(lbset:  this, error:  new SA.Common.Models.Error()));
    }
    public void SendSuccessLoadEvent()
    {
        this.OnLoaderboardsInfoLoaded.Invoke(obj:  new ISN_LoadSetLeaderboardsInfoResult(lbset:  this));
    }
    public System.Collections.Generic.List<GK_LeaderBoardInfo> get_BoardsInfo()
    {
        return (System.Collections.Generic.List<GK_LeaderBoardInfo>)this._BoardsInfo;
    }
    private static void <OnLoaderboardsInfoLoaded>m__0(ISN_LoadSetLeaderboardsInfoResult )
    {
    
    }

}
