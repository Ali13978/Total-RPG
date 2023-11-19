using UnityEngine;
public class CK_Record
{
    // Fields
    private static System.Collections.Generic.Dictionary<int, CK_Record> _Records;
    private CK_RecordID _Id;
    private string _Type;
    private System.Collections.Generic.Dictionary<string, string> _Data;
    private int _internalId;
    
    // Properties
    public CK_RecordID Id { get; }
    public string Type { get; }
    public int Internal_Id { get; }
    
    // Methods
    public CK_Record(CK_RecordID id, string type)
    {
        null = null;
        this._Type = System.String.Empty;
        this._Data = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_2 = new System.Object();
        this._Id = id;
        this._Type = val_2;
        this.IndexRecord();
    }
    public CK_Record(string name, string template)
    {
        var val_7;
        System.Char[] val_8;
        int val_9;
        val_7 = null;
        val_7 = null;
        this._Type = System.String.Empty;
        this._Data = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_2 = new System.Object();
        this._Id = new CK_RecordID(recordName:  name);
        val_8 = null;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_4 = val_2.Split(separator:  val_8);
        this._Type = val_4[0];
        if(val_4.Length < 2)
        {
            goto label_12;
        }
        
        label_16:
        val_8 = val_4[1];
        if((System.String.op_Equality(a:  0, b:  val_8)) == true)
        {
            goto label_12;
        }
        
        val_9 = val_4.Length;
        if(1 >= val_9)
        {
                val_9 = val_4.Length;
        }
        
        val_8 = mem[val_4[0x1] + 32];
        val_8 = val_4[0x1] + 32;
        var val_7 = 1 + 1;
        this.SetObject(key:  val_8, value:  val_4[(long)val_7]);
        val_7 = (long)val_7 + 1;
        if(val_7 < val_4.Length)
        {
            goto label_16;
        }
        
        label_12:
        this.IndexRecord();
    }
    public void SetObject(string key, string value)
    {
        if((this._Data.ContainsKey(key:  key)) != false)
        {
                this._Data.set_Item(key:  key, value:  value);
            return;
        }
        
        this._Data.Add(key:  key, value:  value);
    }
    public string GetObject(string key)
    {
        string val_3;
        string val_4;
        var val_5;
        val_3 = key;
        if((this._Data.ContainsKey(key:  val_3)) != false)
        {
                string val_2 = this._Data.Item[val_3];
            return val_4;
        }
        
        val_3 = 1152921504608284672;
        val_5 = null;
        val_5 = null;
        val_4 = System.String.Empty;
        return val_4;
    }
    public CK_RecordID get_Id()
    {
        return (CK_RecordID)this._Id;
    }
    public string get_Type()
    {
        return (string)this._Type;
    }
    private void IndexRecord()
    {
        int val_2;
        var val_3;
        val_2 = SA.Common.Util.IdFactory.NextId;
        this._internalId = val_2;
        val_3 = null;
        val_3 = null;
        val_2 = this._internalId;
        CK_Record._Records.Add(key:  val_2, value:  this);
    }
    public void UpdateRecord()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        Dictionary.Enumerator<TKey, TValue> val_3 = this._Data.GetEnumerator();
        label_5:
        if((0 & 1) == 0)
        {
            goto label_11;
        }
        
        UnityEngine.Playables.PlayableHandle val_4 = 0.GetHandle();
        Add(item:  val_4.m_Handle.InitializationCallback);
        Add(item:  val_4.m_Handle);
        goto label_5;
        label_11:
        0.Dispose();
        ISN_CloudKit.UpdateRecord_Object(ID:  0, type:  this._internalId, keys:  this._Type, values:  SA.Common.Data.Converter.SerializeArray(array:  0, splitter:  ToArray()), recordId:  SA.Common.Data.Converter.SerializeArray(array:  0, splitter:  ToArray()));
    }
    public int get_Internal_Id()
    {
        return (int)this._internalId;
    }
    public static CK_Record GetRecordByInternalId(int id)
    {
        null = null;
        if(CK_Record._Records != null)
        {
                return CK_Record._Records.Item[W1];
        }
        
        return CK_Record._Records.Item[W1];
    }
    private static CK_Record()
    {
        CK_Record._Records = new System.Collections.Generic.Dictionary<System.Int32, CK_Record>();
    }

}
