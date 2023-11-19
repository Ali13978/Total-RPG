using UnityEngine;
public class CK_QueryResult : Result
{
    // Fields
    private CK_Database _Database;
    private System.Collections.Generic.List<CK_Record> _Records;
    
    // Properties
    public CK_Database Database { get; }
    public System.Collections.Generic.List<CK_Record> Records { get; }
    
    // Methods
    public CK_QueryResult(System.Collections.Generic.List<CK_Record> records)
    {
        this._Records = new System.Collections.Generic.List<CK_Record>();
        this._Records = records;
    }
    public CK_QueryResult(string errorData)
    {
        this._Records = new System.Collections.Generic.List<CK_Record>();
        SA.Common.Models.Error val_2 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public void SetDatabase(CK_Database database)
    {
        this._Database = database;
    }
    public CK_Database get_Database()
    {
        return (CK_Database)this._Database;
    }
    public System.Collections.Generic.List<CK_Record> get_Records()
    {
        return (System.Collections.Generic.List<CK_Record>)this._Records;
    }

}
