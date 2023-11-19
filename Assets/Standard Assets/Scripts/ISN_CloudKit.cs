using UnityEngine;
public class ISN_CloudKit : Singleton<ISN_CloudKit>
{
    // Fields
    private CK_Database _PrivateDB;
    private CK_Database _PublicDB;
    private const int PUBLIC_DB_KEY = -1;
    private const int PRIVATE_DB_KEY = -2;
    
    // Properties
    public CK_Database PrivateDB { get; }
    public CK_Database PublicDB { get; }
    
    // Methods
    public ISN_CloudKit()
    {
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        this._PublicDB = new CK_Database(internalId:  0);
        this._PrivateDB = new CK_Database(internalId:  -2);
    }
    public CK_Database get_PrivateDB()
    {
        return (CK_Database)this._PrivateDB;
    }
    public CK_Database get_PublicDB()
    {
        return (CK_Database)this._PublicDB;
    }
    private void OnSaveRecordSuccess(string data)
    {
        System.String[] val_1 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  data);
        string val_6 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        string val_7 = val_1[1];
        CK_Database.GetDatabaseByInternalId(id:  0).FireSaveRecordResult(result:  new CK_RecordResult(recordId:  System.Convert.ToInt32(value:  0)));
    }
    private void OnSaveRecordFailed(string data)
    {
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        string val_5 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        CK_Database.GetDatabaseByInternalId(id:  0).FireSaveRecordResult(result:  new CK_RecordResult(errorData:  val_1[1]));
    }
    private void OnDeleteRecordSuccess(string data)
    {
        System.String[] val_1 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  data);
        string val_6 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        string val_7 = val_1[1];
        CK_Database.GetDatabaseByInternalId(id:  0).FireDeleteRecordResult(result:  new CK_RecordDeleteResult(recordId:  System.Convert.ToInt32(value:  0)));
    }
    private void OnDeleteRecordFailed(string data)
    {
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        string val_5 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        CK_Database.GetDatabaseByInternalId(id:  0).FireDeleteRecordResult(result:  new CK_RecordDeleteResult(errorData:  val_1[1]));
    }
    private void OnPerformQuerySuccess(string data)
    {
        CK_Record val_11;
        int val_12;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        string val_10 = val_1[0];
        val_11 = 1;
        goto label_12;
        label_23:
        Add(item:  val_11);
        val_11 = (System.Convert.ToInt32(value:  0)) + 1;
        label_12:
        if(val_11 >= val_1.Length)
        {
            goto label_18;
        }
        
        if((System.String.op_Equality(a:  0, b:  val_1[(long)val_11])) == true)
        {
            goto label_18;
        }
        
        val_12 = val_1.Length;
        if(val_11 >= val_12)
        {
                val_12 = val_1.Length;
        }
        
        null = new CK_Record(name:  val_1[(long)(int)((val_2 + 1))] + 32, template:  val_1[(long)val_11 + 1]);
        if(null != 0)
        {
            goto label_23;
        }
        
        goto label_23;
        label_18:
        CK_Database.GetDatabaseByInternalId(id:  0).FireQueryCompleteResult(result:  new CK_QueryResult(records:  new System.Collections.Generic.List<CK_Record>()));
    }
    private void OnPerformQueryFailed(string data)
    {
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        string val_5 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        CK_Database.GetDatabaseByInternalId(id:  0).FireQueryCompleteResult(result:  new CK_QueryResult(errorData:  val_1[1]));
    }
    private void OnFetchRecordSuccess(string data)
    {
        int val_7;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        string val_7 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        val_7 = val_1.Length;
        if(val_7 <= 1)
        {
                val_7 = val_1.Length;
        }
        
        CK_Record val_4 = new CK_Record(name:  val_1[1], template:  val_1[2]);
        CK_Database.GetDatabaseByInternalId(id:  0).FireFetchRecordResult(result:  new CK_RecordResult(recordId:  Internal_Id));
    }
    private void OnFetchRecordFailed(string data)
    {
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        string val_5 = val_1[0];
        int val_2 = System.Convert.ToInt32(value:  0);
        CK_Database.GetDatabaseByInternalId(id:  0).FireFetchRecordResult(result:  new CK_RecordResult(errorData:  val_1[1]));
    }
    public static void CreateRecordId_Object(int recordId, string name)
    {
    
    }
    public static void UpdateRecord_Object(int ID, string type, string keys, string values, int recordId)
    {
    
    }
    public static void SaveRecord(int dbId, int recordId)
    {
    
    }
    public static void DeleteRecord(int dbId, int recordId)
    {
    
    }
    public static void FetchRecord(int dbId, int recordId)
    {
    
    }
    public static void PerformQuery(int dbId, string query, string type)
    {
    
    }

}
