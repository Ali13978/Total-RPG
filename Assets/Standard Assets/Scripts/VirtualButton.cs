using UnityEngine;
public class CrossPlatformInputManager.VirtualButton
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private string <name>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <matchWithInputManager>k__BackingField;
    private int m_LastPressedFrame;
    private int m_ReleasedFrame;
    private bool m_Pressed;
    
    // Properties
    public string name { get; set; }
    public bool matchWithInputManager { get; set; }
    public bool GetButton { get; }
    public bool GetButtonDown { get; }
    public bool GetButtonUp { get; }
    
    // Methods
    public CrossPlatformInputManager.VirtualButton(string name)
    {
        this.m_LastPressedFrame = -17179869189;
        this.m_ReleasedFrame = -5;
        this.<matchWithInputManager>k__BackingField = true;
        this.<name>k__BackingField = name;
    }
    public CrossPlatformInputManager.VirtualButton(string name, bool matchToInputSettings)
    {
        this.m_LastPressedFrame = -17179869189;
        this.m_ReleasedFrame = -5;
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
    public void Pressed()
    {
        if(this.m_Pressed == true)
        {
                return;
        }
        
        this.m_Pressed = true;
        this.m_LastPressedFrame = UnityEngine.Time.frameCount;
    }
    public void Released()
    {
        this.m_Pressed = false;
        this.m_ReleasedFrame = UnityEngine.Time.frameCount;
    }
    public void Remove()
    {
        UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.UnRegisterVirtualButton(name:  null);
    }
    public bool get_GetButton()
    {
        return (bool)this.m_Pressed;
    }
    public bool get_GetButtonDown()
    {
        return (bool)((this.m_LastPressedFrame - UnityEngine.Time.frameCount) == 1) ? 1 : 0;
    }
    public bool get_GetButtonUp()
    {
        return (bool)(this.m_ReleasedFrame == (UnityEngine.Time.frameCount - 1)) ? 1 : 0;
    }

}
