using UnityEngine;
public class CrossPlatformInputManager.VirtualAxis
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <name>k__BackingField;
    private float m_Value;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <matchWithInputManager>k__BackingField;
    
    // Properties
    public string name { get; set; }
    public bool matchWithInputManager { get; set; }
    public float GetValue { get; }
    public float GetValueRaw { get; }
    
    // Methods
    public CrossPlatformInputManager.VirtualAxis(string name)
    {
        this.<matchWithInputManager>k__BackingField = true;
        this.<name>k__BackingField = name;
    }
    public CrossPlatformInputManager.VirtualAxis(string name, bool matchToInputSettings)
    {
        this.<matchWithInputManager>k__BackingField = matchToInputSettings;
        this.<name>k__BackingField = name;
    }
    public string get_name()
    {
        return (string)this.<name>k__BackingField;
    }
    private void set_name(string value)
    {
        this.<name>k__BackingField = value;
    }
    public bool get_matchWithInputManager()
    {
        return (bool)this.<matchWithInputManager>k__BackingField;
    }
    private void set_matchWithInputManager(bool value)
    {
        this.<matchWithInputManager>k__BackingField = value;
    }
    public void Remove()
    {
        UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.UnRegisterVirtualAxis(name:  null);
    }
    public void Update(float value)
    {
        this.m_Value = value;
    }
    public float get_GetValue()
    {
        return (float)this.m_Value;
    }
    public float get_GetValueRaw()
    {
        return (float)this.m_Value;
    }

}
