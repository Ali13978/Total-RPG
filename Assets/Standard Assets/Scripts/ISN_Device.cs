using UnityEngine;
public class ISN_Device
{
    // Fields
    private static ISN_Device _CurrentDevice;
    private string _Name;
    private string _SystemName;
    private string _Model;
    private string _LocalizedModel;
    private string _SystemVersion;
    private int _MajorSystemVersion;
    private string _PreferredLanguage_ISO639_1;
    private ISN_InterfaceIdiom _InterfaceIdiom;
    private ISN_DeviceGUID _GUID;
    
    // Properties
    public string Name { get; }
    public string SystemName { get; }
    public string Model { get; }
    public string LocalizedModel { get; }
    public string SystemVersion { get; }
    public int MajorSystemVersion { get; }
    public ISN_InterfaceIdiom InterfaceIdiom { get; }
    public ISN_DeviceGUID GUID { get; }
    public string PreferredLanguageCode { get; }
    public string PreferredLanguage_ISO639_1 { get; }
    public string AdvertisingIdentifier { get; }
    public bool AdvertisingTrackingEnabled { get; }
    public static ISN_Device CurrentDevice { get; }
    
    // Methods
    public ISN_Device()
    {
        var val_2;
        this._Name = "Test Name";
        this._SystemName = "iPhone OS";
        this._Model = "iPhone";
        this._LocalizedModel = "iPhone";
        this._MajorSystemVersion = 9;
        this._SystemVersion = "9.0.0";
        this._PreferredLanguage_ISO639_1 = "en-US";
        val_2 = null;
        val_2 = null;
        this._GUID = new ISN_DeviceGUID(data:  System.String.Empty);
    }
    public ISN_Device(string deviceData)
    {
        var val_6;
        this._Name = "Test Name";
        this._SystemName = "iPhone OS";
        this._Model = "iPhone";
        this._LocalizedModel = "iPhone";
        this._MajorSystemVersion = 9;
        this._SystemVersion = "9.0.0";
        this._PreferredLanguage_ISO639_1 = "en-US";
        val_6 = null;
        val_6 = null;
        this._GUID = new ISN_DeviceGUID(data:  System.String.Empty);
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_2 = deviceData.Split(separator:  null);
        this._Name = val_2[0];
        this._SystemName = val_2[1];
        this._Model = val_2[2];
        this._LocalizedModel = val_2[3];
        this._SystemVersion = val_2[4];
        string val_11 = val_2[5];
        this._MajorSystemVersion = System.Convert.ToInt32(value:  0);
        string val_12 = val_2[6];
        this._InterfaceIdiom = System.Convert.ToInt32(value:  0);
        this._GUID = new ISN_DeviceGUID(data:  val_2[7]);
        this._PreferredLanguage_ISO639_1 = val_2[8];
    }
    public string get_Name()
    {
        return (string)this._Name;
    }
    public string get_SystemName()
    {
        return (string)this._SystemName;
    }
    public string get_Model()
    {
        return (string)this._Model;
    }
    public string get_LocalizedModel()
    {
        return (string)this._LocalizedModel;
    }
    public string get_SystemVersion()
    {
        return (string)this._SystemVersion;
    }
    public int get_MajorSystemVersion()
    {
        return (int)this._MajorSystemVersion;
    }
    public ISN_InterfaceIdiom get_InterfaceIdiom()
    {
        return (ISN_InterfaceIdiom)this._InterfaceIdiom;
    }
    public ISN_DeviceGUID get_GUID()
    {
        return (ISN_DeviceGUID)this._GUID;
    }
    public string get_PreferredLanguageCode()
    {
        if(this._PreferredLanguage_ISO639_1 != null)
        {
                return this._PreferredLanguage_ISO639_1.Substring(startIndex:  0, length:  2);
        }
        
        return this._PreferredLanguage_ISO639_1.Substring(startIndex:  0, length:  2);
    }
    public string get_PreferredLanguage_ISO639_1()
    {
        return (string)this._PreferredLanguage_ISO639_1;
    }
    public string get_AdvertisingIdentifier()
    {
        return "00000000-0000-0000-0000-000000000000";
    }
    public bool get_AdvertisingTrackingEnabled()
    {
        return false;
    }
    public static ISN_Device get_CurrentDevice()
    {
        ISN_Device val_2;
        ISN_Device val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(ISN_Device._CurrentDevice == null)
        {
                val_2 = val_3;
            val_3 = new ISN_Device();
            val_4 = null;
            val_4 = null;
            ISN_Device._CurrentDevice = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (ISN_Device)ISN_Device._CurrentDevice;
    }
    private static ISN_Device()
    {
    
    }

}
