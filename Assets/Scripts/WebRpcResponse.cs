using UnityEngine;
public class WebRpcResponse
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <Name>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <ReturnCode>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <DebugMessage>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Collections.Generic.Dictionary<string, object> <Parameters>k__BackingField;
    
    // Properties
    public string Name { get; set; }
    public int ReturnCode { get; set; }
    public string DebugMessage { get; set; }
    public System.Collections.Generic.Dictionary<string, object> Parameters { get; set; }
    
    // Methods
    public WebRpcResponse(ExitGames.Client.Photon.OperationResponse response)
    {
        string val_11;
        int val_12;
        var val_13;
        string val_14;
        object val_1 = 0;
        bool val_2 = response.Parameters.TryGetValue(key:  209, value: out  val_1);
        if(val_1 != 0)
        {
                var val_3 = (1179403647 == null) ? (val_1) : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        this.<Name>k__BackingField = val_11;
        bool val_4 = response.Parameters.TryGetValue(key:  207, value: out  val_1);
        if(val_1 != 0)
        {
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_12 = 127;
        }
        else
        {
                val_12 = 0;
        }
        
        this.<ReturnCode>k__BackingField = val_12;
        bool val_6 = response.Parameters.TryGetValue(key:  208, value: out  val_1);
        val_13 = 0;
        this.<Parameters>k__BackingField = ;
        bool val_8 = response.Parameters.TryGetValue(key:  206, value: out  val_1);
        if(val_1 != 0)
        {
                var val_9 = (1179403647 == null) ? (val_1) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        this.<DebugMessage>k__BackingField = val_14;
    }
    public string get_Name()
    {
        return (string)this.<Name>k__BackingField;
    }
    private void set_Name(string value)
    {
        this.<Name>k__BackingField = value;
    }
    public int get_ReturnCode()
    {
        return (int)this.<ReturnCode>k__BackingField;
    }
    private void set_ReturnCode(int value)
    {
        this.<ReturnCode>k__BackingField = value;
    }
    public string get_DebugMessage()
    {
        return (string)this.<DebugMessage>k__BackingField;
    }
    private void set_DebugMessage(string value)
    {
        this.<DebugMessage>k__BackingField = value;
    }
    public System.Collections.Generic.Dictionary<string, object> get_Parameters()
    {
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.<Parameters>k__BackingField;
    }
    private void set_Parameters(System.Collections.Generic.Dictionary<string, object> value)
    {
        this.<Parameters>k__BackingField = value;
    }
    public string ToStringFull()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.<Name>k__BackingField;
        typeof(System.Object[]).__il2cppRuntimeField_28 = ExitGames.Client.Photon.SupportClass.DictionaryToString(dictionary:  0);
        typeof(System.Object[]).__il2cppRuntimeField_30 = this.<ReturnCode>k__BackingField;
        typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.<DebugMessage>k__BackingField;
        return (string)System.String.Format(format:  0, args:  "{0}={2}: {1} \"{3}\"");
    }

}
