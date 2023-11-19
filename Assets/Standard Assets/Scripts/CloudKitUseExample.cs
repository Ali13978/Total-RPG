using UnityEngine;
public class CloudKitUseExample : BaseIOSFeaturePreview
{
    // Methods
    public CloudKitUseExample()
    {
        mem[1152921510380798144] = 200;
        mem[1152921510380798148] = 75;
        mem[1152921510380798168] = 1130102784;
        mem[1152921510380798152] = ;
        mem[1152921510380798176] = 1112014848;
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void OnGUI()
    {
        IntPtr val_28;
        CK_Query val_29;
        mem[1152921510380958472] = ???;
        mem[1152921510380958476] = true;
        int val_1 = UnityEngine.Screen.width;
        val_28 = 1152921504742842368;
        float val_28 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_28, m_Width = 0f, m_Height = 0f}, text:  0, style:  "Cloud Kit");
        val_28 = val_28 + 0f;
        mem[1152921510380958472] = val_28;
        float val_29 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_29, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                if(null != 0)
        {
                SetObject(key:  "PostText", value:  "Sample point of interest");
        }
        else
        {
                SetObject(key:  "PostText", value:  "Sample point of interest");
        }
        
            SetObject(key:  "PostTitle", value:  "My favorite point of interest");
            val_29 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB;
            val_29.SaveRecrod(record:  new CK_Record(id:  new CK_RecordID(recordName:  "1"), type:  "Post"));
            val_29.add_ActionRecordSaved(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordSaved(CK_RecordResult res)));
        }
        
        val_29 = 0f + val_29;
        mem[1152921510380958476] = val_29;
        float val_30 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_30, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_29 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB;
            val_29.DeleteRecordWithID(recordId:  new CK_RecordID(recordName:  "1"));
            val_29.add_ActionRecordDeleted(value:  new System.Action<CK_RecordDeleteResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordDeleted(CK_RecordDeleteResult res)));
        }
        
        val_30 = 0f + val_30;
        mem[1152921510380958476] = val_30;
        float val_31 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_31, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_29 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB;
            val_29.FetchRecordWithID(recordId:  new CK_RecordID(recordName:  "1"));
            val_29.add_ActionRecordFetchComplete(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordFetchComplete(CK_RecordResult res)));
        }
        
        val_31 = 0f + val_31;
        mem[1152921510380958476] = val_31;
        float val_32 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_32, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                val_29 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB;
            val_29.FetchRecordWithID(recordId:  new CK_RecordID(recordName:  "1"));
            val_29.add_ActionRecordFetchComplete(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordFetchForUpdateComplete(CK_RecordResult res)));
        }
        
        val_32 = 0f + val_32;
        mem[1152921510380958476] = val_32;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        CK_Database val_25 = SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB;
        object val_26 = null;
        val_29 = val_26;
        val_26 = new System.Object();
        typeof(CK_Query).__il2cppRuntimeField_10 = "TRUEPREDICATE";
        typeof(CK_Query).__il2cppRuntimeField_18 = "Post";
        val_28 = System.Void CloudKitUseExample::Database_ActionQueryComplete(CK_QueryResult res);
        System.Action<CK_QueryResult> val_27 = new System.Action<CK_QueryResult>(object:  this, method:  val_28);
        if(val_25 != null)
        {
                val_25.add_ActionQueryComplete(value:  val_27);
        }
        else
        {
                0.add_ActionQueryComplete(value:  val_27);
        }
        
        val_25.PerformQuery(query:  val_29);
    }
    private void Database_ActionQueryComplete(CK_QueryResult res)
    {
        string val_13;
        if(res.IsSucceeded == false)
        {
            goto label_2;
        }
        
        int val_2 = res._Records.Count;
        ISN_Logger.Log(message:  0, logType:  0 + "Database_ActionQueryComplete, total records found: "("Database_ActionQueryComplete, total records found: "));
        List.Enumerator<T> val_4 = res._Records.GetEnumerator();
        label_17:
        if((0 & 1) == 0)
        {
            goto label_42;
        }
        
        UnityEngine.Debug.Log(message:  0);
        string val_6 = 0.InitializationCallback.GetObject(key:  "PostTitle");
        ISN_Logger.Log(message:  0, logType:  0 + "Post Title: "("Post Title: "));
        goto label_17;
        label_42:
        0.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if( == 0)
        {
                return;
        }
        
        return;
        label_2:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Database_ActionRecordFetchComplete, Error: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = res.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " / ";
        val_13 = res.Error.Message;
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_13;
        ISN_Logger.Log(message:  0, logType:  +0);
    }
    private void Database_ActionRecordFetchComplete(CK_RecordResult res)
    {
        res._Database.remove_ActionRecordFetchComplete(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordFetchComplete(CK_RecordResult res)));
        if(res.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  "Database_ActionRecordFetchComplete:");
            string val_3 = res._Record.GetObject(key:  "PostTitle");
            ISN_Logger.Log(message:  0, logType:  0 + "Post Title: "("Post Title: "));
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Database_ActionRecordFetchComplete, Error: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = res.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " / ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = res.Error.Message;
        ISN_Logger.Log(message:  0, logType:  +0);
    }
    private void Database_ActionRecordFetchForUpdateComplete(CK_RecordResult res)
    {
        res._Database.remove_ActionRecordFetchComplete(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordFetchForUpdateComplete(CK_RecordResult res)));
        if(res.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  "Database_ActionRecordFetchComplete:");
            string val_3 = res._Record.GetObject(key:  "PostTitle");
            ISN_Logger.Log(message:  0, logType:  0 + "Post Title: "("Post Title: "));
            ISN_Logger.Log(message:  0, logType:  "Updatting Title: ");
            res._Record.SetObject(key:  "PostTitle", value:  "My favorite point of interest - updated");
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB.SaveRecrod(record:  res._Record);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.PrivateDB.add_ActionRecordSaved(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordSaved(CK_RecordResult res)));
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Database_ActionRecordFetchComplete, Error: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = res.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " / ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = res.Error.Message;
        ISN_Logger.Log(message:  0, logType:  +0);
    }
    private void Database_ActionRecordDeleted(CK_RecordDeleteResult res)
    {
        res._Database.remove_ActionRecordDeleted(value:  new System.Action<CK_RecordDeleteResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordDeleted(CK_RecordDeleteResult res)));
        if(res.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  "Database_ActionRecordDeleted, Success: ");
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Database_ActionRecordDeleted, Error: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = res.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " / ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = res.Error.Message;
        ISN_Logger.Log(message:  0, logType:  +0);
    }
    private void Database_ActionRecordSaved(CK_RecordResult res)
    {
        res._Database.remove_ActionRecordSaved(value:  new System.Action<CK_RecordResult>(object:  this, method:  System.Void CloudKitUseExample::Database_ActionRecordSaved(CK_RecordResult res)));
        if(res.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  "Database_ActionRecordSaved:");
            string val_3 = res._Record.GetObject(key:  "PostTitle");
            ISN_Logger.Log(message:  0, logType:  0 + "Post Title: "("Post Title: "));
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Database_ActionRecordSaved, Error: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = res.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " / ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = res.Error.Message;
        ISN_Logger.Log(message:  0, logType:  +0);
    }

}
