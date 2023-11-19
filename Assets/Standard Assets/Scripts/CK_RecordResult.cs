using UnityEngine;
public class CK_RecordResult : Result
{
    // Fields
    private CK_Record _Record;
    private CK_Database _Database;
    
    // Properties
    public CK_Record Record { get; }
    public CK_Database Database { get; }
    
    // Methods
    public CK_RecordResult(int recordId)
    {
        this._Record = CK_Record.GetRecordByInternalId(id:  237166592);
    }
    public CK_RecordResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public void SetDatabase(CK_Database database)
    {
        this._Database = database;
    }
    public CK_Record get_Record()
    {
        return (CK_Record)this._Record;
    }
    public CK_Database get_Database()
    {
        return (CK_Database)this._Database;
    }

}
