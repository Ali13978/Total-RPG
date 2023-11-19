using UnityEngine;
private sealed class InternetTime.<GetNISTDate>c__AnonStorey0
{
    // Fields
    internal System.Action<System.DateTime> callback;
    
    // Methods
    public InternetTime.<GetNISTDate>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        System.DateTime val_1 = TzarGames.Common.InternetTime.GetFastestNISTDate();
        this.callback.Invoke(obj:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = val_1.ticks._ticks}, kind = val_1.kind});
    }

}
