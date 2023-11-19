using UnityEngine;
public class CK_RecordID
{
    // Fields
    private int _internalId;
    private string _Name;
    private static System.Collections.Generic.Dictionary<int, CK_RecordID> _Ids;
    
    // Properties
    public string Name { get; }
    public int Internal_Id { get; }
    
    // Methods
    public CK_RecordID(string recordName)
    {
        var val_2;
        int val_1 = SA.Common.Util.IdFactory.NextId;
        this._internalId = val_1;
        this._Name = recordName;
        ISN_CloudKit.CreateRecordId_Object(recordId:  0, name:  val_1);
        val_2 = null;
        val_2 = null;
        CK_RecordID._Ids.Add(key:  this._internalId, value:  this);
    }
    public string get_Name()
    {
        return (string)this._Name;
    }
    public int get_Internal_Id()
    {
        return (int)this._internalId;
    }
    public static CK_RecordID GetRecordIdByInternalId(int id)
    {
        null = null;
        if(CK_RecordID._Ids != null)
        {
                return CK_RecordID._Ids.Item[W1];
        }
        
        return CK_RecordID._Ids.Item[W1];
    }
    private static CK_RecordID()
    {
        CK_RecordID._Ids = new System.Collections.Generic.Dictionary<System.Int32, CK_RecordID>();
    }

}
