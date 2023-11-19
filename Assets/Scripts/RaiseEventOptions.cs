using UnityEngine;
public class RaiseEventOptions
{
    // Fields
    public static readonly RaiseEventOptions Default;
    public EventCaching CachingOption;
    public byte InterestGroup;
    public int[] TargetActors;
    public ReceiverGroup Receivers;
    public byte SequenceChannel;
    public bool ForwardToWebhook;
    public bool Encrypt;
    
    // Methods
    public RaiseEventOptions()
    {
    
    }
    public void Reset()
    {
        null = null;
        this.CachingOption = RaiseEventOptions.Default.CachingOption;
        this.InterestGroup = RaiseEventOptions.Default.InterestGroup;
        this.TargetActors = RaiseEventOptions.Default.TargetActors;
        this.Receivers = RaiseEventOptions.Default.Receivers;
        this.SequenceChannel = RaiseEventOptions.Default.SequenceChannel;
        this.ForwardToWebhook = RaiseEventOptions.Default.ForwardToWebhook;
        this.Encrypt = RaiseEventOptions.Default.Encrypt;
    }
    private static RaiseEventOptions()
    {
        RaiseEventOptions.Default = new System.Object();
    }

}
