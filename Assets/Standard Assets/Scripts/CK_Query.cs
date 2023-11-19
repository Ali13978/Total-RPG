using UnityEngine;
public class CK_Query
{
    // Fields
    private string _Predicate;
    private string _RecordType;
    
    // Properties
    public string Predicate { get; }
    public string RecordType { get; }
    
    // Methods
    public CK_Query(string predicate, string recordType)
    {
        val_1 = new System.Object();
        this._Predicate = predicate;
        this._RecordType = val_1;
    }
    public string get_Predicate()
    {
        return (string)this._Predicate;
    }
    public string get_RecordType()
    {
        return (string)this._RecordType;
    }

}
