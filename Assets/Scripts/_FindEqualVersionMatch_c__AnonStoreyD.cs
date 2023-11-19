using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<FindEqualVersionMatch>c__AnonStoreyD
{
    // Fields
    internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    internal System.Action<bool> onFailure;
    internal System.Action<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> onVersionMatch;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<FindEqualVersionMatch>c__AnonStoreyD()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse response)
    {
        var val_12;
        GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_1 = response.Match();
        if(val_1 == null)
        {
            goto label_2;
        }
        
        System.Runtime.InteropServices.HandleRef val_2 = val_1.SelfPtr();
        if((GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Version(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper})) != this.match.Version)
        {
            goto label_4;
        }
        
        this.onVersionMatch.Invoke(obj:  val_1);
        goto label_13;
        label_2:
        string val_5 = this.match.MatchId;
        string val_6 = System.String.Format(format:  0, arg0:  "Could not find match {0}");
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        this.onFailure.Invoke(obj:  false);
        goto label_13;
        label_4:
        System.Runtime.InteropServices.HandleRef val_8 = val_1.SelfPtr();
        uint val_9 = GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Version(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_8.wrapper});
        string val_10 = System.String.Format(format:  0, arg0:  "Attempted to update a stale version of the match. Expected version was {0} but current version is {1}.", arg1:  this.match.Version);
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        this.onFailure.Invoke(obj:  false);
        label_13:
        if(val_1 != null)
        {
                var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_1;
        }
        
        if(167 == 167)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }

}
