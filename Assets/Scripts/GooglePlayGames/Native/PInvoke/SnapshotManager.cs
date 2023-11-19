using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class SnapshotManager
    {
        // Fields
        private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse> <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.FetchAllCallback <>f__mg$cache1;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse> <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotSelectUICallback <>f__mg$cache3;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse> <>f__mg$cache4;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback <>f__mg$cache5;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse> <>f__mg$cache6;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback <>f__mg$cache7;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse> <>f__mg$cache8;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback <>f__mg$cache9;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse> <>f__mg$cacheA;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback <>f__mg$cacheB;
        private static System.Func<IntPtr, GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse> <>f__mg$cacheC;
        private static GooglePlayGames.Native.Cwrapper.SnapshotManager.ReadCallback <>f__mg$cacheD;
        
        // Methods
        internal SnapshotManager(GooglePlayGames.Native.PInvoke.GameServices services)
        {
            this.mServices = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        internal void FetchAll(GooglePlayGames.Native.Cwrapper.Types.DataSource source, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse> callback)
        {
            var val_5;
            SnapshotManager.FetchAllCallback val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            val_5 = null;
            val_7 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache1;
            if(val_7 == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache1 = new SnapshotManager.FetchAllCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalFetchAllCallback(IntPtr response, IntPtr data));
                val_5 = null;
                val_7 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache1;
            }
            
            if(GooglePlayGames.Native.PInvoke.SnapshotManager.__il2cppRuntimeField_static_fields == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache0 = new System.Func<System.IntPtr, FetchAllResponse>(object:  0, method:  static FetchAllResponse SnapshotManager.FetchAllResponse::FromPointer(IntPtr pointer));
                val_5 = null;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_FetchAll(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, data_source:  val_1.handle, callback:  source, callback_arg:  val_7);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalFetchAllCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "SnapshotManager#FetchAllCallback", response:  1, userData:  data);
        }
        internal void SnapshotSelectUI(bool allowCreate, bool allowDelete, uint maxSnapshots, string uiTitle, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse> callback)
        {
            System.Func<System.IntPtr, T> val_7;
            SnapshotSelectUICallback val_8;
            string val_9;
            uint val_10;
            bool val_11;
            IntPtr val_12;
            IntPtr val_13;
            SnapshotManager.SnapshotSelectUICallback val_15;
            val_7 = callback;
            val_8 = uiTitle;
            val_9 = maxSnapshots;
            val_10 = allowDelete;
            val_11 = allowCreate;
            System.Runtime.InteropServices.HandleRef val_1 = this.mServices.AsHandle();
            val_12 = val_1.wrapper;
            val_13 = val_1.handle;
            val_15 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache3;
            if(val_15 == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache3 = new SnapshotManager.SnapshotSelectUICallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalSnapshotSelectUICallback(IntPtr response, IntPtr data));
                val_15 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache3;
            }
            
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache2) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache2 = new System.Func<System.IntPtr, SnapshotSelectUIResponse>(object:  0, method:  static SnapshotSelectUIResponse SnapshotManager.SnapshotSelectUIResponse::FromPointer(IntPtr pointer));
                val_8 = val_8;
                val_9 = val_9;
                val_10 = val_10;
                val_11 = val_11;
                val_7 = val_7;
                val_12 = val_12;
                val_13 = val_13;
            }
            
            IntPtr val_4 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  val_7);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ShowSelectUIOperation(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_12}, allow_create:  val_13, allow_delete:  val_11, max_snapshots:  val_10, title:  val_9, callback:  val_8, callback_arg:  val_15);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalSnapshotSelectUICallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "SnapshotManager#SnapshotSelectUICallback", response:  1, userData:  data);
        }
        internal void Open(string fileName, GooglePlayGames.Native.Cwrapper.Types.DataSource source, GooglePlayGames.Native.Cwrapper.Types.SnapshotConflictPolicy conflictPolicy, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse> callback)
        {
            SnapshotManager.OpenCallback val_8;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_3 = this.mServices.AsHandle();
            val_8 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache5;
            if(val_8 == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache5 = new SnapshotManager.OpenCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalOpenCallback(IntPtr response, IntPtr data));
                val_8 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache5;
            }
            
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache4) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache4 = new System.Func<System.IntPtr, OpenResponse>(object:  0, method:  static OpenResponse SnapshotManager.OpenResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_6 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Open(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}, data_source:  val_3.handle, file_name:  source, conflict_policy:  fileName, callback:  conflictPolicy, callback_arg:  val_8);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalOpenCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "SnapshotManager#OpenCallback", response:  1, userData:  data);
        }
        internal void Commit(GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata metadata, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange metadataChange, byte[] updatedData, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.CommitResponse> callback)
        {
            System.Func<System.IntPtr, T> val_9;
            UIntPtr val_10;
            IntPtr val_11;
            IntPtr val_12;
            IntPtr val_13;
            System.Byte[] val_14;
            CommitCallback val_15;
            var val_16;
            SnapshotManager.CommitCallback val_18;
            val_9 = callback;
            val_10 = updatedData;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_3 = this.mServices.AsHandle();
            val_11 = val_3.wrapper;
            val_12 = val_3.handle;
            val_13 = metadata.AsPointer();
            val_14 = metadataChange.AsPointer();
            val_15 = 0;
            val_16 = null;
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache7) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache7 = new SnapshotManager.CommitCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalCommitCallback(IntPtr response, IntPtr data));
                val_16 = null;
            }
            
            val_18 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache7;
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache6) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache6 = new System.Func<System.IntPtr, CommitResponse>(object:  0, method:  static CommitResponse SnapshotManager.CommitResponse::FromPointer(IntPtr pointer));
                val_9 = val_9;
                val_11 = val_11;
                val_12 = val_12;
                val_13 = val_13;
                val_14 = val_14;
                val_15 = val_15;
                val_10 = val_10;
                val_18 = val_18;
            }
            
            IntPtr val_8 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  val_9);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Commit(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_11}, snapshot_metadata:  val_12, metadata_change:  val_13, data:  val_14, data_size:  val_10, callback:  val_15, callback_arg:  val_18);
        }
        internal void Resolve(GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata metadata, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange metadataChange, string conflictId, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse> callback)
        {
            SnapshotManager.OpenCallback val_11;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_4 = this.mServices.AsHandle();
            val_11 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache9;
            if(val_11 == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache9 = new SnapshotManager.OpenCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalOpenCallback(IntPtr response, IntPtr data));
                val_11 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache9;
            }
            
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache8) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cache8 = new System.Func<System.IntPtr, OpenResponse>(object:  0, method:  static OpenResponse SnapshotManager.OpenResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_9 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ResolveConflict(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper}, conflict_id:  val_4.handle, snapshot_metadata:  conflictId, metadata_change:  metadata.AsPointer(), callback:  metadataChange.AsPointer(), callback_arg:  val_11);
        }
        internal void Resolve(GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata metadata, GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange metadataChange, string conflictId, byte[] updatedData, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse> callback)
        {
            var val_11;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_5 = this.mServices.AsHandle();
            val_11 = null;
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheB) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheB = new SnapshotManager.OpenCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalOpenCallback(IntPtr response, IntPtr data));
                val_11 = null;
            }
            
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheA) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheA = new System.Func<System.IntPtr, OpenResponse>(object:  0, method:  static OpenResponse SnapshotManager.OpenResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_10 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_ResolveConflict(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}, conflict_id:  val_5.handle, snapshot_metadata:  conflictId, metadata_change:  metadata.AsPointer(), data:  metadataChange.AsPointer(), data_size:  updatedData, callback:  0, callback_arg:  GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheB);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalCommitCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "SnapshotManager#CommitCallback", response:  1, userData:  data);
        }
        internal void Delete(GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata metadata)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_2 = this.mServices.AsHandle();
            IntPtr val_3 = metadata.AsPointer();
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Delete(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, snapshot_metadata:  val_2.handle);
        }
        internal void Read(GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata metadata, System.Action<GooglePlayGames.Native.PInvoke.SnapshotManager.ReadResponse> callback)
        {
            SnapshotManager.ReadCallback val_9;
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Runtime.InteropServices.HandleRef val_3 = this.mServices.AsHandle();
            val_9 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheD;
            if(val_9 == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheD = new SnapshotManager.ReadCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.SnapshotManager::InternalReadCallback(IntPtr response, IntPtr data));
                val_9 = GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheD;
            }
            
            if((GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheC) == null)
            {
                    GooglePlayGames.Native.PInvoke.SnapshotManager.<>f__mg$cacheC = new System.Func<System.IntPtr, ReadResponse>(object:  0, method:  static ReadResponse SnapshotManager.ReadResponse::FromPointer(IntPtr pointer));
            }
            
            IntPtr val_7 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr<GooglePlayGames.Native.PInvoke.IsCaptureAvailableResponse>(callback:  0, conversionFunction:  callback);
            GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotManager_Read(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}, snapshot_metadata:  val_3.handle, callback:  metadata.AsPointer(), callback_arg:  val_9);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        internal static void InternalReadCallback(IntPtr response, IntPtr data)
        {
            GooglePlayGames.Native.PInvoke.Callbacks.PerformInternalCallback(callbackName:  0, callbackType:  "SnapshotManager#ReadCallback", response:  1, userData:  data);
        }
    
    }

}
