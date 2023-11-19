using UnityEngine;
public class GK_SavedGame
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<GK_SaveDataLoaded> ActionDataLoaded;
    private string _Id;
    private string _Name;
    private string _DeviceName;
    private System.DateTime _ModificationDate;
    private string _OriginalDateString;
    private byte[] _Data;
    private bool _IsDataLoaded;
    private static System.Action<GK_SaveDataLoaded> <>f__am$cache0;
    
    // Properties
    public string Id { get; }
    public string Name { get; }
    public string DeviceName { get; }
    public System.DateTime ModificationDate { get; }
    public string OriginalDateString { get; }
    public byte[] Data { get; }
    public bool IsDataLoaded { get; }
    
    // Methods
    public GK_SavedGame(string id, string name, string device, string dateString)
    {
        if((GK_SavedGame.<>f__am$cache0) == null)
        {
                GK_SavedGame.<>f__am$cache0 = new System.Action<GK_SaveDataLoaded>(object:  0, method:  static System.Void GK_SavedGame::<ActionDataLoaded>m__0(GK_SaveDataLoaded ));
            null = null;
        }
        
        this.ActionDataLoaded = GK_SavedGame.<>f__am$cache0;
        val_2 = new System.Object();
        this._Id = id;
        this._Name = name;
        this._DeviceName = device;
        this._OriginalDateString = val_2;
        System.DateTime val_3 = System.DateTime.Now;
        this._ModificationDate = val_3;
        mem[1152921510246335736] = val_3.kind;
        System.DateTime val_4 = System.DateTime.Parse(s:  0);
        this._ModificationDate = val_4;
        mem[1152921510246335736] = val_4.kind;
    }
    public void add_ActionDataLoaded(System.Action<GK_SaveDataLoaded> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ActionDataLoaded);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510246476368 != this.ActionDataLoaded);
    
    }
    public void remove_ActionDataLoaded(System.Action<GK_SaveDataLoaded> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ActionDataLoaded);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510246612944 != this.ActionDataLoaded);
    
    }
    public void LoadData()
    {
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.LoadSaveData(save:  this);
    }
    public void GenerateDataLoadEvent(string base64Data)
    {
        this._IsDataLoaded = true;
        this._Data = System.Convert.FromBase64String(s:  0);
        typeof(GK_SaveDataLoaded).__il2cppRuntimeField_18 = this;
        this.ActionDataLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    public void GenerateDataLoadFailedEvent(string erorrData)
    {
        this.ActionDataLoaded.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  erorrData)));
    }
    public string get_Id()
    {
        return (string)this._Id;
    }
    public string get_Name()
    {
        return (string)this._Name;
    }
    public string get_DeviceName()
    {
        return (string)this._DeviceName;
    }
    public System.DateTime get_ModificationDate()
    {
        return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this._ModificationDate}};
    }
    public string get_OriginalDateString()
    {
        return (string)this._OriginalDateString;
    }
    public byte[] get_Data()
    {
        return (System.Byte[])this._Data;
    }
    public bool get_IsDataLoaded()
    {
        return (bool)this._IsDataLoaded;
    }
    private static void <ActionDataLoaded>m__0(GK_SaveDataLoaded )
    {
    
    }

}
