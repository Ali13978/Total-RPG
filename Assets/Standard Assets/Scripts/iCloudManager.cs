using UnityEngine;
public class iCloudManager : Singleton<iCloudManager>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<SA.Common.Models.Result> OnCloudInitAction;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<iCloudData> OnCloudDataReceivedAction;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<System.Collections.Generic.List<iCloudData>> OnStoreDidChangeExternally;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Action<iCloudData>>> s_requestDataCallbacks;
    
    // Methods
    public iCloudManager()
    {
        this.s_requestDataCallbacks = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Action<iCloudData>>>();
    }
    public static void add_OnCloudInitAction(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = iCloudManager.OnCloudInitAction;
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void remove_OnCloudInitAction(System.Action<SA.Common.Models.Result> value)
    {
        var val_3;
        System.Action<SA.Common.Models.Result> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = iCloudManager.OnCloudInitAction;
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void add_OnCloudDataReceivedAction(System.Action<iCloudData> value)
    {
        var val_3;
        System.Action<iCloudData> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = iCloudManager.OnCloudDataReceivedAction;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = iCloudManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504843804680 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnCloudDataReceivedAction(System.Action<iCloudData> value)
    {
        var val_3;
        System.Action<iCloudData> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = iCloudManager.OnCloudDataReceivedAction;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = iCloudManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504843804680 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_OnStoreDidChangeExternally(System.Action<System.Collections.Generic.List<iCloudData>> value)
    {
        var val_3;
        System.Action<System.Collections.Generic.List<iCloudData>> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = iCloudManager.OnStoreDidChangeExternally;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = iCloudManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504843804688 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_OnStoreDidChangeExternally(System.Action<System.Collections.Generic.List<iCloudData>> value)
    {
        var val_3;
        System.Action<System.Collections.Generic.List<iCloudData>> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = iCloudManager.OnStoreDidChangeExternally;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = iCloudManager.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504843804688 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    [System.ObsoleteAttribute]
    public void setString(string key, string val)
    {
    
    }
    public void SetString(string key, string val)
    {
    
    }
    [System.ObsoleteAttribute]
    public void setFloat(string key, float val)
    {
    
    }
    public void SetFloat(string key, float val)
    {
    
    }
    [System.ObsoleteAttribute]
    public void setData(string key, byte[] val)
    {
    
    }
    public void SetData(string key, byte[] val)
    {
    
    }
    public void SetObject(string key, object val)
    {
        string val_1 = UnityEngine.JsonUtility.ToJson(obj:  0);
    }
    public void SetInt(string key, int val)
    {
        string val_1 = System.Convert.ToString(value:  0);
    }
    public void SetLong(string key, long val)
    {
        string val_1 = System.Convert.ToString(value:  0);
    }
    public void SetUlong(string key, ulong val)
    {
        string val_1 = System.Convert.ToString(value:  0);
    }
    public void SetArray(string key, System.Collections.Generic.List<object> val)
    {
        string val_1 = SA.Common.Data.Json.Serialize(obj:  0);
    }
    public void SetDictionary(string key, System.Collections.Generic.Dictionary<object, object> val)
    {
        string val_1 = SA.Common.Data.Json.Serialize(obj:  0);
    }
    public void SetStringDictionary(string key, System.Collections.Generic.Dictionary<string, object> val)
    {
        string val_1 = SA.Common.Data.Json.Serialize(obj:  0);
    }
    [System.ObsoleteAttribute]
    public void requestDataForKey(string key)
    {
    
    }
    public void RequestDataForKey(string key)
    {
    
    }
    public void RequestDataForKey(string key, System.Action<iCloudData> callback)
    {
        if(callback == null)
        {
                return;
        }
        
        if((this.s_requestDataCallbacks.ContainsKey(key:  key)) != false)
        {
                this.s_requestDataCallbacks.Item[key].Add(item:  callback);
            return;
        }
        
        Add(item:  callback);
        this.s_requestDataCallbacks.Add(key:  key, value:  new System.Collections.Generic.List<System.Action<iCloudData>>());
    }
    private void OnCloudInit()
    {
        var val_2 = null;
        iCloudManager.OnCloudInitAction.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnCloudInitFail()
    {
        var val_3 = null;
        iCloudManager.OnCloudInitAction.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error()));
    }
    private void OnCloudDataChanged(string data)
    {
        System.Char[] val_8;
        iCloudData val_9;
        int val_10;
        var val_11;
        val_8 = null;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_2 = data.Split(separator:  val_8);
        val_9 = 0;
        goto label_4;
        label_15:
        Add(item:  val_9);
        val_9 = W28 + 1;
        label_4:
        if(val_9 >= val_2.Length)
        {
            goto label_10;
        }
        
        val_8 = val_2[(long)val_9];
        if((System.String.op_Equality(a:  0, b:  val_8)) == true)
        {
            goto label_10;
        }
        
        val_10 = val_2.Length;
        if(val_9 >= val_10)
        {
                val_10 = val_2.Length;
        }
        
        null = new iCloudData(k:  val_2[(long)(int)((W28 + 1))] + 32, v:  val_2[(long)val_9 + 1]);
        if(null != 0)
        {
            goto label_15;
        }
        
        goto label_15;
        label_10:
        val_11 = null;
        val_11 = null;
        iCloudManager.OnStoreDidChangeExternally.Invoke(obj:  new System.Collections.Generic.List<iCloudData>());
    }
    private void OnCloudData(string array)
    {
        int val_8;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Action<iCloudData>>> val_9;
        var val_10;
        var val_11;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = array.Split(separator:  null);
        val_8 = val_1.Length;
        if(val_8 == 0)
        {
                val_8 = val_1.Length;
        }
        
        iCloudData val_2 = new iCloudData(k:  val_1[0], v:  val_1[1]);
        val_9 = this.s_requestDataCallbacks;
        if((val_9.ContainsKey(key:  iCloudData.__il2cppRuntimeField_name)) == false)
        {
            goto label_19;
        }
        
        bool val_5 = this.s_requestDataCallbacks.Remove(key:  iCloudData.__il2cppRuntimeField_name);
        List.Enumerator<T> val_6 = this.s_requestDataCallbacks.Item[iCloudData.__il2cppRuntimeField_name].GetEnumerator();
        label_16:
        if((0 & 1) == 0)
        {
            goto label_14;
        }
        
        0.InitializationCallback.Invoke(obj:  val_2);
        goto label_16;
        label_14:
        val_10 = 0;
        val_9 = 1;
        0.Dispose();
        label_19:
        val_11 = null;
        val_11 = null;
        iCloudManager.OnCloudDataReceivedAction.Invoke(obj:  val_2);
    }
    private void OnCloudDataEmpty(string array)
    {
        var val_3;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        val_3 = null;
        val_3 = null;
        iCloudManager.OnCloudDataReceivedAction.Invoke(obj:  new iCloudData(k:  array.Split(separator:  null)[0], v:  "null"));
    }
    private static iCloudManager()
    {
        iCloudManager.OnCloudInitAction = new System.Action<SA.Common.Models.Result>(object:  0, method:  static System.Void iCloudManager::<OnCloudInitAction>m__0(SA.Common.Models.Result ));
        iCloudManager.OnCloudDataReceivedAction = new System.Action<iCloudData>(object:  0, method:  static System.Void iCloudManager::<OnCloudDataReceivedAction>m__1(iCloudData ));
        iCloudManager.OnStoreDidChangeExternally = new System.Action<System.Collections.Generic.List<iCloudData>>(object:  0, method:  static System.Void iCloudManager::<OnStoreDidChangeExternally>m__2(System.Collections.Generic.List<iCloudData> ));
    }
    private static void <OnCloudInitAction>m__0(SA.Common.Models.Result )
    {
    
    }
    private static void <OnCloudDataReceivedAction>m__1(iCloudData )
    {
    
    }
    private static void <OnStoreDidChangeExternally>m__2(System.Collections.Generic.List<iCloudData> )
    {
    
    }

}
