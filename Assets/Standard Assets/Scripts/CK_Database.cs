using UnityEngine;
public class CK_Database
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<CK_RecordResult> ActionRecordSaved;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<CK_RecordResult> ActionRecordFetchComplete;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<CK_RecordDeleteResult> ActionRecordDeleted;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<CK_QueryResult> ActionQueryComplete;
    private static System.Collections.Generic.Dictionary<int, CK_Database> _Databases;
    private int _InternalId;
    private static System.Action<CK_RecordResult> <>f__am$cache0;
    private static System.Action<CK_RecordResult> <>f__am$cache1;
    private static System.Action<CK_RecordDeleteResult> <>f__am$cache2;
    private static System.Action<CK_QueryResult> <>f__am$cache3;
    
    // Properties
    public int InternalId { get; }
    
    // Methods
    public CK_Database(int internalId)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_5 = null;
        val_5 = null;
        if((CK_Database.<>f__am$cache0) == null)
        {
                val_6 = null;
            val_6 = null;
            CK_Database.<>f__am$cache0 = new System.Action<CK_RecordResult>(object:  0, method:  static System.Void CK_Database::<ActionRecordSaved>m__0(CK_RecordResult ));
            val_5 = null;
        }
        
        val_5 = null;
        this.ActionRecordSaved = CK_Database.<>f__am$cache0;
        val_7 = null;
        if((CK_Database.<>f__am$cache1) == null)
        {
                val_8 = null;
            val_8 = null;
            CK_Database.<>f__am$cache1 = new System.Action<CK_RecordResult>(object:  0, method:  static System.Void CK_Database::<ActionRecordFetchComplete>m__1(CK_RecordResult ));
            val_7 = null;
        }
        
        val_7 = null;
        this.ActionRecordFetchComplete = CK_Database.<>f__am$cache1;
        val_9 = null;
        if((CK_Database.<>f__am$cache2) == null)
        {
                val_10 = null;
            val_10 = null;
            CK_Database.<>f__am$cache2 = new System.Action<CK_RecordDeleteResult>(object:  0, method:  static System.Void CK_Database::<ActionRecordDeleted>m__2(CK_RecordDeleteResult ));
            val_9 = null;
        }
        
        val_9 = null;
        this.ActionRecordDeleted = CK_Database.<>f__am$cache2;
        val_11 = null;
        if((CK_Database.<>f__am$cache3) == null)
        {
                val_12 = null;
            val_12 = null;
            CK_Database.<>f__am$cache3 = new System.Action<CK_QueryResult>(object:  0, method:  static System.Void CK_Database::<ActionQueryComplete>m__3(CK_QueryResult ));
            val_11 = null;
        }
        
        val_11 = null;
        this.ActionQueryComplete = CK_Database.<>f__am$cache3;
        this._InternalId = internalId;
        CK_Database._Databases.Add(key:  internalId, value:  this);
    }
    public void add_ActionRecordSaved(System.Action<CK_RecordResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ActionRecordSaved);
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
        while(1152921510264889936 != this.ActionRecordSaved);
    
    }
    public void remove_ActionRecordSaved(System.Action<CK_RecordResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ActionRecordSaved);
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
        while(1152921510265026512 != this.ActionRecordSaved);
    
    }
    public void add_ActionRecordFetchComplete(System.Action<CK_RecordResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ActionRecordFetchComplete);
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
        while(1152921510265163096 != this.ActionRecordFetchComplete);
    
    }
    public void remove_ActionRecordFetchComplete(System.Action<CK_RecordResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ActionRecordFetchComplete);
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
        while(1152921510265299672 != this.ActionRecordFetchComplete);
    
    }
    public void add_ActionRecordDeleted(System.Action<CK_RecordDeleteResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ActionRecordDeleted);
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
        while(1152921510265436256 != this.ActionRecordDeleted);
    
    }
    public void remove_ActionRecordDeleted(System.Action<CK_RecordDeleteResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ActionRecordDeleted);
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
        while(1152921510265572832 != this.ActionRecordDeleted);
    
    }
    public void add_ActionQueryComplete(System.Action<CK_QueryResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ActionQueryComplete);
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
        while(1152921510265709416 != this.ActionQueryComplete);
    
    }
    public void remove_ActionQueryComplete(System.Action<CK_QueryResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ActionQueryComplete);
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
        while(1152921510265845992 != this.ActionQueryComplete);
    
    }
    public void SaveRecrod(CK_Record record)
    {
        int val_1;
        if(record != null)
        {
                record.UpdateRecord();
            val_1 = this._InternalId;
        }
        else
        {
                0.UpdateRecord();
            val_1 = this._InternalId;
        }
        
        ISN_CloudKit.SaveRecord(dbId:  0, recordId:  val_1);
    }
    public void FetchRecordWithID(CK_RecordID recordId)
    {
        ISN_CloudKit.FetchRecord(dbId:  0, recordId:  this._InternalId);
    }
    public void DeleteRecordWithID(CK_RecordID recordId)
    {
        ISN_CloudKit.DeleteRecord(dbId:  0, recordId:  this._InternalId);
    }
    public void PerformQuery(CK_Query query)
    {
        string val_1;
        if(query != null)
        {
                val_1 = query._Predicate;
        }
        else
        {
                val_1 = 11993091;
        }
        
        ISN_CloudKit.PerformQuery(dbId:  0, query:  this._InternalId, type:  val_1);
    }
    public int get_InternalId()
    {
        return (int)this._InternalId;
    }
    public static CK_Database GetDatabaseByInternalId(int id)
    {
        null = null;
        if(CK_Database._Databases != null)
        {
                return CK_Database._Databases.Item[W1];
        }
        
        return CK_Database._Databases.Item[W1];
    }
    public void FireSaveRecordResult(CK_RecordResult result)
    {
        result._Database = this;
        this.ActionRecordSaved.Invoke(obj:  result);
    }
    public void FireFetchRecordResult(CK_RecordResult result)
    {
        result._Database = this;
        this.ActionRecordFetchComplete.Invoke(obj:  result);
    }
    public void FireDeleteRecordResult(CK_RecordDeleteResult result)
    {
        result._Database = this;
        this.ActionRecordDeleted.Invoke(obj:  result);
    }
    public void FireQueryCompleteResult(CK_QueryResult result)
    {
        result._Database = this;
        this.ActionQueryComplete.Invoke(obj:  result);
    }
    private static CK_Database()
    {
        CK_Database._Databases = new System.Collections.Generic.Dictionary<System.Int32, CK_Database>();
    }
    private static void <ActionRecordSaved>m__0(CK_RecordResult )
    {
    
    }
    private static void <ActionRecordFetchComplete>m__1(CK_RecordResult )
    {
    
    }
    private static void <ActionRecordDeleted>m__2(CK_RecordDeleteResult )
    {
    
    }
    private static void <ActionQueryComplete>m__3(CK_QueryResult )
    {
    
    }

}
