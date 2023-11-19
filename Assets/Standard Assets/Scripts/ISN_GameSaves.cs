using UnityEngine;
public class ISN_GameSaves : Singleton<ISN_GameSaves>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_SaveRemoveResult> ActionSaveRemoved;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_SaveResult> ActionGameSaved;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_FetchResult> ActionSavesFetched;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_SavesResolveResult> ActionSavesResolved;
    private static System.Collections.Generic.Dictionary<string, GK_SavedGame> _CachedGameSaves;
    
    // Methods
    public ISN_GameSaves()
    {
    
    }
    public static void add_ActionSaveRemoved(System.Action<GK_SaveRemoveResult> value)
    {
        var val_3;
        System.Action<GK_SaveRemoveResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionSaveRemoved;
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
    public static void remove_ActionSaveRemoved(System.Action<GK_SaveRemoveResult> value)
    {
        var val_3;
        System.Action<GK_SaveRemoveResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionSaveRemoved;
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
    public static void add_ActionGameSaved(System.Action<GK_SaveResult> value)
    {
        var val_3;
        System.Action<GK_SaveResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionGameSaved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_GameSaves.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504841248776 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionGameSaved(System.Action<GK_SaveResult> value)
    {
        var val_3;
        System.Action<GK_SaveResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionGameSaved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_GameSaves.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504841248776 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionSavesFetched(System.Action<GK_FetchResult> value)
    {
        var val_3;
        System.Action<GK_FetchResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionSavesFetched;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_GameSaves.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504841248784 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionSavesFetched(System.Action<GK_FetchResult> value)
    {
        var val_3;
        System.Action<GK_FetchResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionSavesFetched;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_GameSaves.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504841248784 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionSavesResolved(System.Action<GK_SavesResolveResult> value)
    {
        var val_3;
        System.Action<GK_SavesResolveResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionSavesResolved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_GameSaves.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504841248792 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionSavesResolved(System.Action<GK_SavesResolveResult> value)
    {
        var val_3;
        System.Action<GK_SavesResolveResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = ISN_GameSaves.ActionSavesResolved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = ISN_GameSaves.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504841248792 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void SaveGame(byte[] data, string name)
    {
    
    }
    public void FetchSavedGames()
    {
    
    }
    public void DeleteSavedGame(string name)
    {
    
    }
    public void ResolveConflictingSavedGames(System.Collections.Generic.List<GK_SavedGame> conflicts, byte[] data)
    {
    
    }
    public void LoadSaveData(GK_SavedGame save)
    {
    
    }
    public void OnSaveSuccess(string data)
    {
        var val_3 = null;
        ISN_GameSaves.ActionGameSaved.Invoke(obj:  new GK_SaveResult(save:  this.DeserializeGameSave(serializedData:  data)));
    }
    public void OnSaveFailed(string erroData)
    {
        var val_2 = null;
        ISN_GameSaves.ActionGameSaved.Invoke(obj:  new GK_SaveResult(errorData:  erroData));
    }
    public void OnFetchSuccess(string data)
    {
        System.String[] val_7;
        var val_8;
        var val_9;
        val_7 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        val_8 = 0;
        goto label_6;
        label_16:
        Add(item:  val_7);
        val_8 = 1;
        label_6:
        if(val_8 >= val_2.Length)
        {
            goto label_12;
        }
        
        val_7 = data.Split(separator:  val_7, options:  0)[1];
        bool val_3 = System.String.op_Equality(a:  0, b:  val_7);
        if(val_3 == true)
        {
            goto label_12;
        }
        
        GK_SavedGame val_5 = val_3.DeserializeGameSave(serializedData:  val_2[0x1] + 32);
        if(null != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_12:
        val_9 = null;
        val_9 = null;
        ISN_GameSaves.ActionSavesFetched.Invoke(obj:  new GK_FetchResult(saves:  new System.Collections.Generic.List<GK_SavedGame>()));
    }
    public void OnFetchFailed(string errorData)
    {
        var val_2 = null;
        ISN_GameSaves.ActionSavesFetched.Invoke(obj:  new GK_FetchResult(errorData:  errorData));
    }
    public void OnResolveSuccess(string data)
    {
        System.String[] val_7;
        var val_8;
        var val_9;
        val_7 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        val_8 = 0;
        goto label_6;
        label_16:
        Add(item:  val_7);
        val_8 = 1;
        label_6:
        if(val_8 >= val_2.Length)
        {
            goto label_12;
        }
        
        val_7 = data.Split(separator:  val_7, options:  0)[1];
        bool val_3 = System.String.op_Equality(a:  0, b:  val_7);
        if(val_3 == true)
        {
            goto label_12;
        }
        
        GK_SavedGame val_5 = val_3.DeserializeGameSave(serializedData:  val_2[0x1] + 32);
        if(null != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_12:
        val_9 = null;
        val_9 = null;
        ISN_GameSaves.ActionSavesResolved.Invoke(obj:  new GK_SavesResolveResult(saves:  new System.Collections.Generic.List<GK_SavedGame>()));
    }
    public void OnResolveFailed(string errorData)
    {
        var val_2 = null;
        ISN_GameSaves.ActionSavesResolved.Invoke(obj:  new GK_SavesResolveResult(errorData:  errorData));
    }
    public void OnDeleteSuccess(string name)
    {
        var val_2 = null;
        ISN_GameSaves.ActionSaveRemoved.Invoke(obj:  new GK_SaveRemoveResult(name:  name));
    }
    public void OnDeleteFailed(string data)
    {
        int val_3;
        var val_4;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_3 = val_1.Length;
        if(val_3 == 0)
        {
                val_3 = val_1.Length;
        }
        
        val_4 = null;
        val_4 = null;
        ISN_GameSaves.ActionSaveRemoved.Invoke(obj:  new GK_SaveRemoveResult(name:  val_1[0], errorData:  val_1[1]));
    }
    private void OnSaveDataLoaded(string data)
    {
        int val_4;
        var val_5;
        var val_6;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_4 = val_1.Length;
        if(val_4 == 0)
        {
                val_4 = val_1.Length;
        }
        
        string val_4 = val_1[0];
        val_5 = null;
        val_5 = null;
        if((ISN_GameSaves._CachedGameSaves.ContainsKey(key:  val_4)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ISN_GameSaves._CachedGameSaves.Item[val_4].GenerateDataLoadEvent(base64Data:  val_1[1]);
    }
    private void OnSaveDataLoadFailed(string data)
    {
        int val_4;
        var val_5;
        var val_6;
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_1 = data.Split(separator:  null, options:  0);
        val_4 = val_1.Length;
        if(val_4 == 0)
        {
                val_4 = val_1.Length;
        }
        
        string val_4 = val_1[0];
        val_5 = null;
        val_5 = null;
        if((ISN_GameSaves._CachedGameSaves.ContainsKey(key:  val_4)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ISN_GameSaves._CachedGameSaves.Item[val_4].GenerateDataLoadFailedEvent(erorrData:  val_1[1]);
    }
    private GK_SavedGame DeserializeGameSave(string serializedData)
    {
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        string val_13;
        var val_14;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = serializedData.Split(separator:  null);
        val_9 = val_1.Length;
        if(val_9 == 0)
        {
                val_9 = val_1.Length;
        }
        
        if(val_9 <= 1)
        {
                val_9 = val_1.Length;
        }
        
        if(val_9 <= 2)
        {
                val_9 = val_1.Length;
        }
        
        GK_SavedGame val_2 = new GK_SavedGame(id:  val_1[0], name:  val_1[1], device:  val_1[2], dateString:  val_1[3]);
        val_10 = null;
        val_10 = null;
        val_11 = null;
        if((ISN_GameSaves._CachedGameSaves.ContainsKey(key:  Id)) != false)
        {
                val_12 = null;
            val_13 = Id;
            ISN_GameSaves._CachedGameSaves.set_Item(key:  val_13, value:  val_2);
            return val_2;
        }
        
        val_14 = null;
        val_13 = Id;
        ISN_GameSaves._CachedGameSaves.Add(key:  val_13, value:  val_2);
        return val_2;
    }
    private static ISN_GameSaves()
    {
        ISN_GameSaves.ActionSaveRemoved = new System.Action<GK_SaveRemoveResult>(object:  0, method:  static System.Void ISN_GameSaves::<ActionSaveRemoved>m__0(GK_SaveRemoveResult ));
        ISN_GameSaves.ActionGameSaved = new System.Action<GK_SaveResult>(object:  0, method:  static System.Void ISN_GameSaves::<ActionGameSaved>m__1(GK_SaveResult ));
        ISN_GameSaves.ActionSavesFetched = new System.Action<GK_FetchResult>(object:  0, method:  static System.Void ISN_GameSaves::<ActionSavesFetched>m__2(GK_FetchResult ));
        ISN_GameSaves.ActionSavesResolved = new System.Action<GK_SavesResolveResult>(object:  0, method:  static System.Void ISN_GameSaves::<ActionSavesResolved>m__3(GK_SavesResolveResult ));
        ISN_GameSaves._CachedGameSaves = new System.Collections.Generic.Dictionary<System.String, GK_SavedGame>();
    }
    private static void <ActionSaveRemoved>m__0(GK_SaveRemoveResult )
    {
    
    }
    private static void <ActionGameSaved>m__1(GK_SaveResult )
    {
    
    }
    private static void <ActionSavesFetched>m__2(GK_FetchResult )
    {
    
    }
    private static void <ActionSavesResolved>m__3(GK_SavesResolveResult )
    {
    
    }

}
