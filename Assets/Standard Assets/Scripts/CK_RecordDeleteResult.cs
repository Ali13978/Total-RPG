using UnityEngine;
public class CK_RecordDeleteResult : Result
{
    // Fields
    private CK_RecordID _RecordID;
    private CK_Database _Database;
    
    // Properties
    public CK_Database Database { get; }
    public CK_RecordID RecordID { get; }
    
    // Methods
    public CK_RecordDeleteResult(int recordId)
    {
        this._RecordID = CK_RecordID.GetRecordIdByInternalId(id:  237219840);
    }
    public CK_RecordDeleteResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public void SetDatabase(CK_Database database)
    {
        this._Database = database;
    }
    public CK_Database get_Database()
    {
        return (CK_Database)this._Database;
    }
    public CK_RecordID get_RecordID()
    {
        return (CK_RecordID)this._RecordID;
    }

}
