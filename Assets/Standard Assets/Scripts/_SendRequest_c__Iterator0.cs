using UnityEngine;
private sealed class MarketExample.<SendRequest>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal string <base64string>__0;
    internal System.Collections.Generic.Dictionary<string, object> <OriginalJSON>__0;
    internal string <data>__0;
    internal byte[] <binaryData>__0;
    internal UnityEngine.WWW <www>__0;
    internal MarketExample $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MarketExample.<SendRequest>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_11;
        UnityEngine.WWW val_12;
        int val_11 = this.$PC;
        this.$PC = 0;
        val_11 = ((val_11 == 1) ? 1 : 0) << 2;
        var val_2 = (val_11 == 0) ? 3 : (val_11);
        if(val_2 != 4)
        {
                val_11 = 0;
            if(val_2 != 3)
        {
                return (bool)val_11;
        }
        
            this.<base64string>__0 = System.Convert.ToBase64String(inArray:  0);
            this.<OriginalJSON>__0 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Add(key:  "receipt-data", value:  this.<base64string>__0);
            this.<data>__0 = SA.Common.Data.Json.Serialize(obj:  0);
            System.Text.Encoding val_6 = System.Text.Encoding.UTF8;
            this.<binaryData>__0 = val_6;
            UnityEngine.WWW val_7 = null;
            val_12 = val_7;
            val_7 = new UnityEngine.WWW(url:  "https://sandbox.itunes.apple.com/verifyReceipt", postData:  val_6);
            val_11 = 1;
            this.<www>__0 = val_12;
            this.$current = val_12;
            if(this.$disposing == true)
        {
                return (bool)val_11;
        }
        
            this.$PC = val_11;
            return (bool)val_11;
        }
        
        val_12 = this.<www>__0.error;
        if(val_12 != null)
        {
                string val_9 = this.<www>__0.error;
        }
        else
        {
                string val_10 = this.<www>__0.text;
        }
        
        UnityEngine.Debug.Log(message:  0);
        val_11 = 0;
        this.$PC = 0;
        return (bool)val_11;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
