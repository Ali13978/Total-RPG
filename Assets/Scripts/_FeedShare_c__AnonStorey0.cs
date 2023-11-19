using UnityEngine;
private sealed class FacebookPlatform.<FeedShare>c__AnonStorey0
{
    // Fields
    internal System.Action<bool> shareResult;
    internal System.Uri link;
    
    // Methods
    public FacebookPlatform.<FeedShare>c__AnonStorey0()
    {
    
    }
    internal void <>m__0(bool x)
    {
        if(x != false)
        {
                TzarGames.Endless.FacebookPlatform.feed(link:  null, shareResultCallback:  this.link);
            return;
        }
        
        if(this.shareResult == null)
        {
                return;
        }
        
        this.shareResult.Invoke(obj:  false);
    }

}
