using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    public class NativeIOSCloudSaveProvider : ICloudSaveGameProvider
    {
        // Fields
        private const string saveGamesDataKey = "IOSNATIVE_SAVEGAME_LIST";
        private const string metaFilesKey = "IOSNATIVE_METADATA";
        private bool initialized;
        private System.Collections.Generic.List<System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult>> getSavesCallbacks;
        private System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> processingWriteCallback;
        private System.Action<iCloudData> onCloudKeyDataReceived;
        private System.Collections.Generic.List<TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider.WriteCallbackinfo> pendingWriteCallbackinfos;
        private const int metadata_size_offset = 4;
        private System.Collections.Generic.List<GK_SavedGame> lastSavedGames;
        private System.Collections.Generic.List<TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider.KeyRequestInfo> _requestInfos;
        
        // Methods
        public NativeIOSCloudSaveProvider()
        {
            this.getSavesCallbacks = new System.Collections.Generic.List<System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult>>();
            this.pendingWriteCallbackinfos = new System.Collections.Generic.List<WriteCallbackinfo>();
            this._requestInfos = new System.Collections.Generic.List<KeyRequestInfo>();
        }
        public void GetSaveGames(System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> callback)
        {
            object val_1 = new System.Object();
            UnityEngine.Debug.Log(message:  0);
            this.getSavesCallbacks.Add(item:  callback);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.FetchSavedGames();
        }
        public void Write(string file, System.TimeSpan playedTime, string description, byte[] data, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> callback)
        {
            string val_8;
            object val_1 = null;
            val_8 = val_1;
            val_1 = new System.Object();
            typeof(NativeIOSCloudSaveProvider.<Write>c__AnonStorey0).__il2cppRuntimeField_10 = file;
            if(this.processingWriteCallback == null)
            {
                goto label_2;
            }
            
            if(null == 0)
            {
                goto label_3;
            }
            
            typeof(NativeIOSCloudSaveProvider.WriteCallbackinfo).__il2cppRuntimeField_10 = callback;
            typeof(NativeIOSCloudSaveProvider.WriteCallbackinfo).__il2cppRuntimeField_18 = typeof(NativeIOSCloudSaveProvider.<Write>c__AnonStorey0).__il2cppRuntimeField_10;
            typeof(NativeIOSCloudSaveProvider.WriteCallbackinfo).__il2cppRuntimeField_20 = playedTime._ticks;
            typeof(NativeIOSCloudSaveProvider.WriteCallbackinfo).__il2cppRuntimeField_28 = description;
            goto label_4;
            label_2:
            this.processingWriteCallback = callback;
            object val_3 = new System.Object();
            typeof(NativeIOSCloudSaveProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_18 = val_8;
            object val_4 = new System.Object();
            typeof(TzarGames.Endless.CloudSaveSystem.SaveData).__il2cppRuntimeField_18 = description;
            typeof(NativeIOSCloudSaveProvider.<Write>c__AnonStorey1).__il2cppRuntimeField_10 = UnityEngine.JsonUtility.ToJson(obj:  0);
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SaveGame(data:  data, name:  typeof(NativeIOSCloudSaveProvider.<Write>c__AnonStorey0).__il2cppRuntimeField_10);
            System.Action<iCloudData> val_7 = new System.Action<iCloudData>(object:  null, method:  System.Void NativeIOSCloudSaveProvider.<Write>c__AnonStorey1::<>m__0(iCloudData cloudData));
            this.read_key(key:  "IOSNATIVE_METADATA", callback:  null);
            return;
            label_3:
            mem[16] = callback;
            val_8 = typeof(NativeIOSCloudSaveProvider.<Write>c__AnonStorey0).__il2cppRuntimeField_10;
            mem[24] = val_8;
            mem[32] = playedTime._ticks;
            mem[40] = description;
            label_4:
            typeof(NativeIOSCloudSaveProvider.WriteCallbackinfo).__il2cppRuntimeField_30 = data;
            this.pendingWriteCallbackinfos.Add(item:  new System.Object());
        }
        private void processWriteCallbacks(TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult result)
        {
            System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> val_3;
            string val_4;
            var val_5;
            string val_6;
            System.Byte[] val_7;
            if(this.pendingWriteCallbackinfos.Count < 1)
            {
                goto label_2;
            }
            
            val_3 = this.pendingWriteCallbackinfos.Item[0];
            this.pendingWriteCallbackinfos.RemoveAt(index:  0);
            if(val_3 == null)
            {
                goto label_5;
            }
            
            this.processingWriteCallback = val_2.Callback;
            val_4 = mem[val_2 + 16 + 8];
            val_4 = val_2 + 16 + 8;
            val_5 = mem[val_2 + 16 + 8 + 8];
            val_5 = val_2 + 16 + 8 + 8;
            val_6 = mem[val_2 + 16 + 24];
            val_6 = val_2 + 16 + 24;
            val_7 = mem[val_2 + 16 + 24 + 8];
            val_7 = val_2 + 16 + 24 + 8;
            goto label_6;
            label_2:
            this.processingWriteCallback = 0;
            return;
            label_5:
            val_3 = 16;
            this.processingWriteCallback = 11993091;
            val_4 = 7254272;
            val_5 = 64;
            val_6 = 34460624;
            val_7 = 0;
            label_6:
            this.Write(file:  val_4, playedTime:  new System.TimeSpan() {_ticks = 64}, description:  val_6, data:  val_7, callback:  val_3);
        }
        public void Read(string file, System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> callback)
        {
            var val_5;
            System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> val_17;
            System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> val_19;
            var val_20;
            object val_1 = null;
            val_17 = val_1;
            val_1 = new System.Object();
            typeof(NativeIOSCloudSaveProvider.<Read>c__AnonStorey3).__il2cppRuntimeField_10 = callback;
            if(this.lastSavedGames == null)
            {
                    UnityEngine.Debug.Log(message:  0);
                object val_2 = new System.Object();
                typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_10 = 0;
                typeof(NativeIOSCloudSaveProvider.<Read>c__AnonStorey3).__il2cppRuntimeField_10.Invoke(obj:  null);
            }
            
            List.Enumerator<T> val_3 = 0.GetEnumerator();
            label_26:
            label_13:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.InitializationCallback;
            if((System.String.op_Equality(a:  0, b:  val_6.Name)) == false)
            {
                goto label_13;
            }
            
            if(val_6.IsDataLoaded == false)
            {
                goto label_15;
            }
            
            object val_10 = new System.Object();
            typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_10 = 1;
            typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_18 = val_6.Data;
            typeof(NativeIOSCloudSaveProvider.<Read>c__AnonStorey3).__il2cppRuntimeField_10.Invoke(obj:  null);
            goto label_26;
            label_15:
            object val_12 = new System.Object();
            if(null != 0)
            {
                    typeof(NativeIOSCloudSaveProvider.<Read>c__AnonStorey2).__il2cppRuntimeField_18 = val_17;
            }
            else
            {
                    mem[24] = val_17;
            }
            
            typeof(NativeIOSCloudSaveProvider.<Read>c__AnonStorey2).__il2cppRuntimeField_10 = val_6;
            System.Action<GK_SaveDataLoaded> val_13 = new System.Action<GK_SaveDataLoaded>(object:  null, method:  System.Void NativeIOSCloudSaveProvider.<Read>c__AnonStorey2::<>m__0(GK_SaveDataLoaded loaded));
            val_6.add_ActionDataLoaded(value:  null);
            val_6.LoadData();
            goto label_26;
            label_9:
            val_19 = 0;
            val_20 = 242;
            val_5.Dispose();
            if(((0 & 1) & 1) != 0)
            {
                    return;
            }
            
            string val_15 = 0 + "Saved game not found ";
            UnityEngine.Debug.Log(message:  0);
            object val_16 = new System.Object();
            typeof(TzarGames.Endless.CloudSaveSystem.DefaultReadResult).__il2cppRuntimeField_10 = 0;
            val_19 = typeof(NativeIOSCloudSaveProvider.<Read>c__AnonStorey3).__il2cppRuntimeField_10;
            val_19.Invoke(obj:  null);
        }
        public bool IsReady()
        {
            return true;
        }
        public void Initialize()
        {
            UnityEngine.Debug.Log(message:  0);
            System.Action<GK_SaveResult> val_1 = new System.Action<GK_SaveResult>(object:  this, method:  System.Void TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider::IsnGameSavesOnActionGameSaved(GK_SaveResult gkSaveResult));
            ISN_GameSaves.add_ActionGameSaved(value:  0);
            System.Action<GK_FetchResult> val_2 = new System.Action<GK_FetchResult>(object:  this, method:  System.Void TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider::IsnGameSavesOnActionSavesFetched(GK_FetchResult gkFetchResult));
            ISN_GameSaves.add_ActionSavesFetched(value:  0);
            System.Action<iCloudData> val_3 = new System.Action<iCloudData>(object:  this, method:  System.Void TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider::ICloudManagerOnOnCloudDataReceivedAction(iCloudData iCloudData));
            iCloudManager.add_OnCloudDataReceivedAction(value:  0);
        }
        private void ICloudManagerOnOnCloudDataReceivedAction(iCloudData iCloudData)
        {
            System.Action<iCloudData> val_6;
            bool val_2 = iCloudData.IsEmpty;
            string val_3 = 0 + "Data received: "("Data received: ");
            UnityEngine.Debug.Log(message:  0);
            val_6 = this.onCloudKeyDataReceived;
            this.onCloudKeyDataReceived = 0;
            val_6.Invoke(obj:  iCloudData);
            if(this._requestInfos.Count < 1)
            {
                    return;
            }
            
            this._requestInfos.RemoveAt(index:  0);
            if(this._requestInfos.Item[0] != null)
            {
                    val_6 = val_5.Key;
            }
            else
            {
                    val_6 = 11993091;
            }
            
            this.read_key(key:  val_6, callback:  val_5.callback);
        }
        private void read_key(string key, System.Action<iCloudData> callback)
        {
            if(this.onCloudKeyDataReceived == null)
            {
                goto label_1;
            }
            
            if(null == 0)
            {
                goto label_2;
            }
            
            typeof(NativeIOSCloudSaveProvider.KeyRequestInfo).__il2cppRuntimeField_10 = key;
            goto label_3;
            label_1:
            this.onCloudKeyDataReceived = callback;
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RequestDataForKey(key:  key);
            return;
            label_2:
            mem[16] = key;
            label_3:
            typeof(NativeIOSCloudSaveProvider.KeyRequestInfo).__il2cppRuntimeField_18 = callback;
            this._requestInfos.Add(item:  new System.Object());
        }
        private void processGetSaveGameCallbacks(TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult result)
        {
            var val_3;
            var val_7;
            var val_8;
            List.Enumerator<T> val_1 = this.getSavesCallbacks.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_3.InitializationCallback.Invoke(obj:  result);
            goto label_9;
            label_2:
            val_7 = 0;
            val_8 = 1;
            val_3.Dispose();
            this.getSavesCallbacks.Clear();
        }
        private void IsnGameSavesOnActionSavesFetched(GK_FetchResult gkFetchResult)
        {
            var val_7;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4).__il2cppRuntimeField_10 = gkFetchResult;
            }
            else
            {
                    val_7 = 16;
                mem[16] = gkFetchResult;
            }
            
            typeof(NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4).__il2cppRuntimeField_20 = this;
            UnityEngine.Debug.Log(message:  0);
            typeof(NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4).__il2cppRuntimeField_18 = new System.Object();
            if(val_7.IsFailed != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = mem[16].Error;
                UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Failed to get file dictionary. Error: {0}");
                typeof(TzarGames.Endless.CloudSaveSystem.DefaultSaveGameListResult).__il2cppRuntimeField_10 = 0;
                this.processGetSaveGameCallbacks(result:  typeof(NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4).__il2cppRuntimeField_18);
                return;
            }
            
            this.lastSavedGames = mem[16].SavedGames;
            UnityEngine.Debug.Log(message:  0);
            this.read_key(key:  "IOSNATIVE_METADATA", callback:  new System.Action<iCloudData>(object:  val_1, method:  System.Void NativeIOSCloudSaveProvider.<IsnGameSavesOnActionSavesFetched>c__AnonStorey4::<>m__0(iCloudData data)));
        }
        private void IsnGameSavesOnActionGameSaved(GK_SaveResult gkSaveResult)
        {
            object val_1 = new System.Object();
            if(gkSaveResult.IsFailed != false)
            {
                    typeof(TzarGames.Endless.CloudSaveSystem.DefaultWriteResult).__il2cppRuntimeField_10 = 0;
            }
            else
            {
                    typeof(TzarGames.Endless.CloudSaveSystem.DefaultWriteResult).__il2cppRuntimeField_10 = 1;
            }
            
            this.processWriteCallbacks(result:  0);
        }
    
    }

}
