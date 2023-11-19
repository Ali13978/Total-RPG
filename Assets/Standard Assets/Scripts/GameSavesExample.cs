using UnityEngine;
public class GameSavesExample : BaseIOSFeaturePreview
{
    // Fields
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<GK_SavedGame>> GameSaves;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<GK_SavedGame>> SavesConflicts;
    private string test_name;
    private string test_name_2;
    
    // Methods
    public GameSavesExample()
    {
        this.GameSaves = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<GK_SavedGame>>();
        this.SavesConflicts = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<GK_SavedGame>>();
        this.test_name = "savedgame1";
        this.test_name_2 = "savedgame2";
    }
    private void Awake()
    {
    
    }
    private void OnGUI()
    {
        this.UpdateToStartPos();
        int val_1 = UnityEngine.Screen.width;
        float val_11 = 0f;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_11, m_Width = 0f, m_Height = 0f}, text:  0, style:  "GameCenter Game Saves");
        val_11 = val_11 + 0f;
        mem[1152921510382372104] = val_11;
        float val_12 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_12, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                System.Action<SA.Common.Models.Result> val_3 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameSavesExample::HandleOnAuthFinished(SA.Common.Models.Result result));
            GameCenterManager.add_OnAuthFinished(value:  null);
            GameCenterManager.Init();
        }
        
        val_12 = val_12 + 0f;
        mem[1152921510382372104] = val_12;
        float val_13 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_13, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.Save(name:  this.test_name);
        }
        
        val_13 = 0f + val_13;
        mem[1152921510382372108] = val_13;
        float val_14 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_14, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.Save(name:  this.test_name_2);
        }
        
        val_14 = 0f + val_14;
        mem[1152921510382372108] = "Save Game 2";
        mem[1152921510382372104] = val_14;
        float val_15 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_15, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.Fetch();
        }
        
        val_15 = 0f + val_15;
        mem[1152921510382372108] = val_15;
        float val_16 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_16, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.Load();
        }
        
        val_16 = 0f + val_16;
        mem[1152921510382372108] = "Load Saved Game";
        mem[1152921510382372104] = val_16;
        float val_17 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_17, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.Delete(name:  this.test_name);
        }
        
        val_17 = 0f + val_17;
        mem[1152921510382372108] = val_17;
        float val_18 = 0f;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_18, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.Delete(name:  this.test_name_2);
        }
        
        val_18 = 0f + val_18;
        mem[1152921510382372108] = "Delete Saved Game 2";
        mem[1152921510382372104] = val_18;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        this.ResolveConflicts();
    }
    private void Save(string name)
    {
        ISN_Logger.Log(message:  0, logType:  "Start to save game!");
        System.Action<GK_SaveResult> val_1 = new System.Action<GK_SaveResult>(object:  this, method:  System.Void GameSavesExample::HandleActionGameSaved(GK_SaveResult res));
        ISN_GameSaves.add_ActionGameSaved(value:  0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SaveGame(data:  System.Text.Encoding.UTF8, name:  name);
    }
    private void Fetch()
    {
        ISN_Logger.Log(message:  0, logType:  "Start to fetch games!");
        System.Action<GK_FetchResult> val_1 = new System.Action<GK_FetchResult>(object:  this, method:  System.Void GameSavesExample::HandleActionSavesFetched(GK_FetchResult res));
        ISN_GameSaves.add_ActionSavesFetched(value:  0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FetchSavedGames();
    }
    private void Delete(string name)
    {
        ISN_Logger.Log(message:  0, logType:  "Start to delete game by name!");
        System.Action<GK_SaveRemoveResult> val_1 = new System.Action<GK_SaveRemoveResult>(object:  this, method:  System.Void GameSavesExample::HandleActionSaveRemoved(GK_SaveRemoveResult res));
        ISN_GameSaves.add_ActionSaveRemoved(value:  0);
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.DeleteSavedGame(name:  name);
    }
    private void Load()
    {
        ISN_Logger.Log(message:  0, logType:  "Start to load game!");
        GK_SavedGame val_1 = this.GetLoadedSave(saveGameName:  this.test_name);
        if(val_1 != null)
        {
                val_1.add_ActionDataLoaded(value:  new System.Action<GK_SaveDataLoaded>(object:  this, method:  System.Void GameSavesExample::HandleActionDataLoaded(GK_SaveDataLoaded res)));
            val_1.LoadData();
            return;
        }
        
        ISN_Logger.Log(message:  0, logType:  "You don\'t have any saved game!");
    }
    private void ResolveConflicts()
    {
        ISN_Logger.Log(message:  0, logType:  "Trying to fix conflicts");
        System.Collections.Generic.List<GK_SavedGame> val_1 = this.GetConflict();
        if(val_1 != null)
        {
                System.Action<GK_SavesResolveResult> val_2 = new System.Action<GK_SavesResolveResult>(object:  this, method:  System.Void GameSavesExample::HandleActionSavesResolved(GK_SavesResolveResult res));
            ISN_GameSaves.add_ActionSavesResolved(value:  0);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.ResolveConflictingSavedGames(conflicts:  val_1, data:  System.Text.Encoding.UTF8);
            return;
        }
        
        ISN_Logger.Log(message:  0, logType:  "You don\'t have any conflicts!");
    }
    private GK_SavedGame GetLoadedSave(string saveGameName)
    {
        string val_4;
        var val_5;
        val_4 = saveGameName;
        if((this.GameSaves.ContainsKey(key:  val_4)) != false)
        {
                val_4 = this.GameSaves.Item[val_4];
            GK_SavedGame val_3 = val_4.Item[0];
            return (GK_SavedGame)val_5;
        }
        
        val_5 = 0;
        return (GK_SavedGame)val_5;
    }
    private System.Collections.Generic.List<GK_SavedGame> GetConflict()
    {
        var val_3;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.SavesConflicts.Values.GetEnumerator();
        if((0 & 1) != 0)
        {
                val_3 = ;
        }
        else
        {
                val_3 = 0;
        }
        
        return (System.Collections.Generic.List<GK_SavedGame>)val_3;
    }
    private int GetConflictsCount()
    {
        int val_1 = this.SavesConflicts.Count;
        ISN_Logger.Log(message:  0, logType:  0 + "The total number of duplicates ="("The total number of duplicates ="));
        return (int)this.SavesConflicts.Count;
    }
    private void CheckSavesOnDuplicates()
    {
        int val_3;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<GK_SavedGame>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<GK_SavedGame>>(dictionary:  this.GameSaves);
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        do
        {
            label_9:
            if((0 & 1) == 0)
        {
            goto label_16;
        }
        
            UnityEngine.Playables.PlayableHandle val_5 = val_3.GetHandle();
        }
        while(val_5.m_Handle.Count < 2);
        
        if((this.SavesConflicts.ContainsKey(key:  val_5.m_Handle.InitializationCallback)) != true)
        {
                this.SavesConflicts.Add(key:  val_5.m_Handle.InitializationCallback, value:  val_5.m_Handle);
        }
        
        bool val_12 = this.GameSaves.Remove(key:  val_5.m_Handle.InitializationCallback);
        goto label_9;
        label_16:
        val_3.Dispose();
        ISN_Logger.Log(message:  0, logType:  "------------------------------------------");
        val_3 = this.SavesConflicts.Count;
        ISN_Logger.Log(message:  0, logType:  0 + "Duplicates ");
        int val_15 = this.GameSaves.Count;
        ISN_Logger.Log(message:  0, logType:  0 + "Unique saves ");
        ISN_Logger.Log(message:  0, logType:  "------------------------------------------");
    }
    private void HandleOnAuthFinished(SA.Common.Models.Result result)
    {
        System.Action<SA.Common.Models.Result> val_1 = new System.Action<SA.Common.Models.Result>(object:  this, method:  System.Void GameSavesExample::HandleOnAuthFinished(SA.Common.Models.Result result));
        GameCenterManager.remove_OnAuthFinished(value:  null);
        if(result.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  "Player Authed");
            return;
        }
        
        IOSNativePopUpManager.showMessage(title:  0, message:  "Game Center ");
    }
    private void HandleActionGameSaved(GK_SaveResult res)
    {
        string val_9;
        object val_10;
        UnityEngine.LogType val_11;
        System.Action<GK_SaveResult> val_1 = new System.Action<GK_SaveResult>(object:  this, method:  System.Void GameSavesExample::HandleActionGameSaved(GK_SaveResult res));
        ISN_GameSaves.remove_ActionGameSaved(value:  0);
        if(res == null)
        {
            goto label_3;
        }
        
        if(res.IsSucceeded == true)
        {
            goto label_4;
        }
        
        goto label_6;
        label_3:
        if(0.IsSucceeded == false)
        {
            goto label_6;
        }
        
        label_4:
        val_9 = res._SavedGame._Name;
        ISN_Logger.Log(message:  0, logType:  0 + "Saved game with name ");
        val_10 = 0;
        val_11 = "------------------------------------------";
        goto label_10;
        label_6:
        val_9 = res.Error.Message;
        val_11 = 0 + "Failed: "("Failed: ");
        val_10 = 0;
        label_10:
        ISN_Logger.Log(message:  val_10, logType:  val_11);
    }
    private void HandleActionSaveRemoved(GK_SaveRemoveResult res)
    {
        string val_9;
        object val_10;
        UnityEngine.LogType val_11;
        System.Action<GK_SaveRemoveResult> val_1 = new System.Action<GK_SaveRemoveResult>(object:  this, method:  System.Void GameSavesExample::HandleActionSaveRemoved(GK_SaveRemoveResult res));
        ISN_GameSaves.remove_ActionSaveRemoved(value:  0);
        if(res == null)
        {
            goto label_3;
        }
        
        if(res.IsSucceeded == true)
        {
            goto label_4;
        }
        
        goto label_6;
        label_3:
        if(0.IsSucceeded == false)
        {
            goto label_6;
        }
        
        label_4:
        val_9 = res._SaveName;
        ISN_Logger.Log(message:  0, logType:  0 + "Deleted game with name ");
        val_10 = 0;
        val_11 = "------------------------------------------";
        goto label_9;
        label_6:
        val_9 = res.Error.Message;
        val_11 = 0 + "Failed: "("Failed: ");
        val_10 = 0;
        label_9:
        ISN_Logger.Log(message:  val_10, logType:  val_11);
    }
    private void HandleActionDataLoaded(GK_SaveDataLoaded res)
    {
        res._SavedGame.remove_ActionDataLoaded(value:  new System.Action<GK_SaveDataLoaded>(object:  this, method:  System.Void GameSavesExample::HandleActionDataLoaded(GK_SaveDataLoaded res)));
        if(res.IsSucceeded != false)
        {
                ISN_Logger.Log(message:  0, logType:  0 + "Data loaded. data Length: "("Data loaded. data Length: "));
            return;
        }
        
        string val_5 = res.Error.Message;
        ISN_Logger.Log(message:  0, logType:  0 + "Failed: "("Failed: "));
    }
    private void HandleActionSavesFetched(GK_FetchResult res)
    {
        int val_7;
        var val_21;
        System.Action<GK_FetchResult> val_1 = new System.Action<GK_FetchResult>(object:  this, method:  System.Void GameSavesExample::HandleActionSavesFetched(GK_FetchResult res));
        ISN_GameSaves.remove_ActionSavesFetched(value:  0);
        if(res.IsSucceeded == false)
        {
            goto label_4;
        }
        
        ISN_Logger.Log(message:  0, logType:  0 + "Received " + res._SavedGames.Count);
        List.Enumerator<T> val_5 = res._SavedGames.GetEnumerator();
        label_15:
        if((0 & 1) == 0)
        {
            goto label_11;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_8 = val_7.InitializationCallback;
        ISN_Logger.Log(message:  0, logType:  0 + "The name of the save game ");
        goto label_15;
        label_4:
        typeof(System.Object[]).__il2cppRuntimeField_20 = "Failed: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = res.Error.Message;
        val_21 = " with code ";
        typeof(System.Object[]).__il2cppRuntimeField_30 = val_21;
        val_7 = res.Error.Code;
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_7;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        ISN_Logger.Log(message:  0, logType:  +0);
        return;
        label_11:
        val_7.Dispose();
        ISN_Logger.Log(message:  0, logType:  "------------------------------------------");
        this.GameSaves.Clear();
        List.Enumerator<T> val_15 = res._SavedGames.GetEnumerator();
        label_52:
        if((0 & 1) == 0)
        {
            goto label_55;
        }
        
        if((this.GameSaves.ContainsKey(key:  1152921510384520416)) != true)
        {
                System.Collections.Generic.List<GK_SavedGame> val_19 = new System.Collections.Generic.List<GK_SavedGame>();
            this.GameSaves.Add(key:  1152921510384520416, value:  null);
        }
        
        this.GameSaves.Item[1152921510384520416].Add(item:  val_7.InitializationCallback);
        goto label_52;
        label_55:
        val_7.Dispose();
        ISN_Logger.Log(message:  0, logType:  "Check the saves on duplicates");
        this.CheckSavesOnDuplicates();
    }
    private void HandleActionSavesResolved(GK_SavesResolveResult res)
    {
        int val_5;
        var val_22;
        var val_23;
        var val_24;
        System.Action<GK_SavesResolveResult> val_1 = null;
        val_22 = val_1;
        val_1 = new System.Action<GK_SavesResolveResult>(object:  this, method:  System.Void GameSavesExample::HandleActionSavesResolved(GK_SavesResolveResult res));
        ISN_GameSaves.remove_ActionSavesResolved(value:  0);
        if(res.IsSucceeded == false)
        {
            goto label_4;
        }
        
        ISN_Logger.Log(message:  0, logType:  "The conflict is resolved");
        List.Enumerator<T> val_3 = res._ResolvedSaves.GetEnumerator();
        label_18:
        if((0 & 1) == 0)
        {
            goto label_7;
        }
        
        bool val_7 = this.SavesConflicts.Remove(key:  X23);
        if((this.GameSaves.ContainsKey(key:  X23)) == true)
        {
            goto label_18;
        }
        
        System.Collections.Generic.List<GK_SavedGame> val_10 = new System.Collections.Generic.List<GK_SavedGame>();
        this.GameSaves.Add(key:  X23, value:  null);
        this.GameSaves.Item[X23].Add(item:  val_5.InitializationCallback);
        goto label_18;
        label_4:
        val_23 = res.Error.Message;
        ISN_Logger.Log(message:  0, logType:  0 + "Failed: "("Failed: "));
        return;
        label_7:
        val_5.Dispose();
        ISN_Logger.Log(message:  0, logType:  "------------------------------------------");
        val_5 = this.SavesConflicts.Count;
        val_22 = val_5;
        ISN_Logger.Log(message:  0, logType:  0 + "Duplicates ");
        int val_17 = this.GameSaves.Count;
        ISN_Logger.Log(message:  0, logType:  0 + "Unique saves ");
        ISN_Logger.Log(message:  0, logType:  "------------------------------------------");
        List.Enumerator<T> val_19 = res._ResolvedSaves.GetEnumerator();
        label_36:
        if((0 & 1) == 0)
        {
            goto label_32;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_20 = 0.InitializationCallback;
        ISN_Logger.Log(message:  0, logType:  0 + "The name of the save game ");
        goto label_36;
        label_32:
        val_23 = 0;
        val_24 = 1;
        0.Dispose();
        if((val_24 & 1) != 0)
        {
                return;
        }
        
        if(val_23 == 0)
        {
                return;
        }
    
    }

}
