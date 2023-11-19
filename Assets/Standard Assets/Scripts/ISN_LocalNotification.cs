using UnityEngine;
public class ISN_LocalNotification
{
    // Fields
    private int _Id;
    private System.DateTime _Date;
    private string _Message;
    private bool _UseSound;
    private int _Badges;
    private string _Data;
    private string _SoundName;
    private const string DATA_SPLITTER = "|||";
    
    // Properties
    public int Id { get; }
    public System.DateTime Date { get; }
    public bool IsFired { get; }
    public string Message { get; }
    public bool UseSound { get; }
    public int Badges { get; }
    public string Data { get; }
    public string SoundName { get; }
    public string SerializedString { get; }
    
    // Methods
    public ISN_LocalNotification(System.DateTime time, string message, bool useSound = True)
    {
        null = null;
        this._UseSound = true;
        this._Message = System.String.Empty;
        this._Data = System.String.Empty;
        this._SoundName = System.String.Empty;
        val_1 = new System.Object();
        this._Id = SA.Common.Util.IdFactory.NextId;
        this._Date = time;
        mem[1152921510296367648] = time.kind;
        this._UseSound = useSound;
        this._Message = val_1;
    }
    public ISN_LocalNotification(string serializaedNotificationData)
    {
        null = null;
        this._UseSound = true;
        this._Message = System.String.Empty;
        this._Data = System.String.Empty;
        this._SoundName = System.String.Empty;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|||";
        System.String[] val_1 = serializaedNotificationData.Split(separator:  null, options:  0);
        string val_7 = val_1[0];
        this._Id = System.Convert.ToInt32(value:  0);
        string val_8 = val_1[1];
        this._UseSound = System.Convert.ToBoolean(value:  0);
        string val_9 = val_1[2];
        this._Badges = System.Convert.ToInt32(value:  0);
        this._Data = val_1[3];
        this._SoundName = val_1[4];
        string val_12 = val_1[5];
        long val_6 = System.Convert.ToInt64(value:  0);
        this._Date = 0;
        mem[1152921510296549360] = 0;
    }
    public void SetId(int id)
    {
        this._Id = id;
    }
    public void SetData(string data)
    {
        this._Data = data;
    }
    public void SetSoundName(string soundName)
    {
        this._SoundName = soundName;
    }
    public void SetBadgesNumber(int badges)
    {
        this._Badges = badges;
    }
    public void Schedule()
    {
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    public int get_Id()
    {
        return (int)this._Id;
    }
    public System.DateTime get_Date()
    {
        return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this._Date}};
    }
    public bool get_IsFired()
    {
        System.DateTime val_1 = System.DateTime.Now;
        return (bool)(val_1.ticks._ticks.Ticks > this._Date.Ticks) ? 1 : 0;
    }
    public string get_Message()
    {
        return (string)this._Message;
    }
    public bool get_UseSound()
    {
        return (bool)this._UseSound;
    }
    public int get_Badges()
    {
        return (int)this._Badges;
    }
    public string get_Data()
    {
        return (string)this._Data;
    }
    public string get_SoundName()
    {
        return (string)this._SoundName;
    }
    public string get_SerializedString()
    {
        System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
        typeof(System.String[]).__il2cppRuntimeField_20 = ;
        typeof(System.String[]).__il2cppRuntimeField_28 = "|||";
        typeof(System.String[]).__il2cppRuntimeField_30 = ;
        typeof(System.String[]).__il2cppRuntimeField_38 = "|||";
        typeof(System.String[]).__il2cppRuntimeField_40 = ;
        typeof(System.String[]).__il2cppRuntimeField_48 = "|||";
        typeof(System.String[]).__il2cppRuntimeField_50 = this._Data;
        typeof(System.String[]).__il2cppRuntimeField_58 = "|||";
        typeof(System.String[]).__il2cppRuntimeField_60 = this._SoundName;
        typeof(System.String[]).__il2cppRuntimeField_68 = "|||";
        long val_2 = this._Date.Ticks;
        typeof(System.String[]).__il2cppRuntimeField_70 = ;
        string val_3 = +0;
        return (string)System.Convert.ToBase64String(inArray:  0);
    }

}
