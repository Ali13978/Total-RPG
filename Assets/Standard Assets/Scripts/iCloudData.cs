using UnityEngine;
public class iCloudData
{
    // Fields
    private string m_key;
    private string m_val;
    private bool m_IsEmpty;
    
    // Properties
    [System.ObsoleteAttribute]
    public string key { get; }
    public string Key { get; }
    public bool IsEmpty { get; }
    [System.ObsoleteAttribute]
    public string stringValue { get; }
    public string StringValue { get; }
    [System.ObsoleteAttribute]
    public float floatValue { get; }
    public float FloatValue { get; }
    [System.ObsoleteAttribute]
    public byte[] bytesValue { get; }
    public byte[] BytesValue { get; }
    public System.Collections.Generic.List<object> ListValue { get; }
    public System.Collections.Generic.Dictionary<string, object> DictionaryValue { get; }
    public int IntValue { get; }
    public long LongValue { get; }
    public ulong UlongValue { get; }
    
    // Methods
    public iCloudData(string k, string v)
    {
        val_1 = new System.Object();
        this.m_key = k;
        this.m_val = val_1;
        if((val_1.Equals(value:  "null")) == false)
        {
                return;
        }
        
        IOSNativeSettings val_3 = IOSNativeSettings.Instance;
        if(val_3.DisablePluginLogs != true)
        {
                ISN_Logger.Log(message:  0, logType:  "ISN iCloud Empty set");
        }
        
        this.m_IsEmpty = true;
    }
    public T GetObject<T>()
    {
        string val_1 = this.StringValue;
        goto __RuntimeMethodHiddenParam + 48;
    }
    public string get_key()
    {
        return (string)this.m_key;
    }
    public string get_Key()
    {
        return (string)this.m_key;
    }
    public bool get_IsEmpty()
    {
        return (bool)this.m_IsEmpty;
    }
    public string get_stringValue()
    {
        if(this.m_IsEmpty == false)
        {
                return (string)this.m_val;
        }
        
        return 0;
    }
    public string get_StringValue()
    {
        if(this.m_IsEmpty == false)
        {
                return (string)this.m_val;
        }
        
        return 0;
    }
    public float get_floatValue()
    {
        return this.FloatValue;
    }
    public float get_FloatValue()
    {
        if(this.m_IsEmpty == false)
        {
                return System.Convert.ToSingle(value:  0);
        }
        
        return 0f;
    }
    public byte[] get_bytesValue()
    {
        return this.BytesValue;
    }
    public byte[] get_BytesValue()
    {
        if(this.m_IsEmpty == false)
        {
                return System.Convert.FromBase64String(s:  0);
        }
        
        return 0;
    }
    public System.Collections.Generic.List<object> get_ListValue()
    {
        var val_5;
        if(this.m_IsEmpty != false)
        {
                System.Collections.Generic.List<System.Object> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.List<System.Object>();
            return (System.Collections.Generic.List<System.Object>)val_5;
        }
        
        object val_2 = SA.Common.Data.Json.Deserialize(json:  0);
        val_5 = 0;
        if(val_2 == null)
        {
                return (System.Collections.Generic.List<System.Object>)val_5;
        }
        
        val_5 = val_2;
        val_5 = 0;
        return (System.Collections.Generic.List<System.Object>)val_5;
    }
    public System.Collections.Generic.Dictionary<string, object> get_DictionaryValue()
    {
        var val_5;
        if(this.m_IsEmpty != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_5;
        }
        
        object val_2 = SA.Common.Data.Json.Deserialize(json:  0);
        val_5 = 0;
        if(val_2 == null)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_5;
        }
        
        val_5 = val_2;
        val_5 = 0;
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_5;
    }
    public int get_IntValue()
    {
        if(this.m_IsEmpty == false)
        {
                return System.Convert.ToInt32(value:  0);
        }
        
        return 0;
    }
    public long get_LongValue()
    {
        if(this.m_IsEmpty == false)
        {
                return System.Convert.ToInt64(value:  0);
        }
        
        return 0;
    }
    public ulong get_UlongValue()
    {
        if(this.m_IsEmpty == false)
        {
                return System.Convert.ToUInt64(value:  0);
        }
        
        return 0;
    }

}
