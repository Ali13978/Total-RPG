using UnityEngine;
public class AuthenticationValues
{
    // Fields
    private CustomAuthenticationType authType;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <AuthGetParameters>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private object <AuthPostData>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <Token>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <UserId>k__BackingField;
    
    // Properties
    public CustomAuthenticationType AuthType { get; set; }
    public string AuthGetParameters { get; set; }
    public object AuthPostData { get; set; }
    public string Token { get; set; }
    public string UserId { get; set; }
    
    // Methods
    public AuthenticationValues()
    {
        this.authType = 255;
    }
    public AuthenticationValues(string userId)
    {
        this.authType = 255;
        this.<UserId>k__BackingField = userId;
    }
    public CustomAuthenticationType get_AuthType()
    {
        return (CustomAuthenticationType)this.authType;
    }
    public void set_AuthType(CustomAuthenticationType value)
    {
        this.authType = value;
    }
    public string get_AuthGetParameters()
    {
        return (string)this.<AuthGetParameters>k__BackingField;
    }
    public void set_AuthGetParameters(string value)
    {
        this.<AuthGetParameters>k__BackingField = value;
    }
    public object get_AuthPostData()
    {
        return (object)this.<AuthPostData>k__BackingField;
    }
    private void set_AuthPostData(object value)
    {
        this.<AuthPostData>k__BackingField = value;
    }
    public string get_Token()
    {
        return (string)this.<Token>k__BackingField;
    }
    public void set_Token(string value)
    {
        this.<Token>k__BackingField = value;
    }
    public string get_UserId()
    {
        return (string)this.<UserId>k__BackingField;
    }
    public void set_UserId(string value)
    {
        this.<UserId>k__BackingField = value;
    }
    public virtual void SetAuthPostData(string stringData)
    {
        this.<AuthPostData>k__BackingField = ((System.String.IsNullOrEmpty(value:  0)) != true) ? 0 : stringData;
    }
    public virtual void SetAuthPostData(byte[] byteData)
    {
        this.<AuthPostData>k__BackingField = byteData;
    }
    public virtual void SetAuthPostData(System.Collections.Generic.Dictionary<string, object> dictData)
    {
        this.<AuthPostData>k__BackingField = dictData;
    }
    public virtual void AddAuthParameter(string key, string value)
    {
        var val_5;
        var val_6;
        if((System.String.IsNullOrEmpty(value:  0)) != false)
        {
                val_5 = null;
            val_5 = null;
        }
        else
        {
                val_6 = "&";
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.<AuthGetParameters>k__BackingField;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_6;
        typeof(System.Object[]).__il2cppRuntimeField_30 = System.Uri.EscapeDataString(stringToEscape:  0);
        typeof(System.Object[]).__il2cppRuntimeField_38 = System.Uri.EscapeDataString(stringToEscape:  0);
        this.<AuthGetParameters>k__BackingField = System.String.Format(format:  0, args:  "{0}{1}{2}={3}");
    }
    public override string ToString()
    {
        var val_1 = ((this.<Token>k__BackingField) != null) ? 1 : 0;
        return (string)System.String.Format(format:  0, arg0:  "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", arg1:  this.<UserId>k__BackingField, arg2:  this.<AuthGetParameters>k__BackingField);
    }

}
