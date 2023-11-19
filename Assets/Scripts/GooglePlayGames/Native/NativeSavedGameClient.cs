using UnityEngine;

namespace GooglePlayGames.Native
{
    internal class NativeSavedGameClient : ISavedGameClient
    {
        // Fields
        private static readonly System.Text.RegularExpressions.Regex ValidFilenameRegex;
        private readonly GooglePlayGames.Native.PInvoke.SnapshotManager mSnapshotManager;
        
        // Methods
        internal NativeSavedGameClient(GooglePlayGames.Native.PInvoke.SnapshotManager manager)
        {
            this.mSnapshotManager = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        public void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            GooglePlayGames.BasicApi.SavedGame.ConflictCallback val_10;
            var val_11;
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_12;
            string val_13;
            GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy val_14;
            val_10 = conflictCallback;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_11 = val_1;
                typeof(NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0).__il2cppRuntimeField_10 = resolutionStrategy;
            }
            else
            {
                    val_11 = 16;
                mem[16] = resolutionStrategy;
            }
            
            typeof(NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0).__il2cppRuntimeField_18 = completedCallback;
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            if(null != 0)
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            else
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            
            val_12 = typeof(NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0).__il2cppRuntimeField_18;
            typeof(NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0).__il2cppRuntimeField_18 = GooglePlayGames.Native.NativeSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Object>(toConvert:  0);
            if(val_10 == null)
            {
                    val_12 = System.Void NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0::<>m__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData);
                GooglePlayGames.BasicApi.SavedGame.ConflictCallback val_6 = null;
                val_10 = val_6;
                val_6 = new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  val_1, method:  val_12);
            }
            
            string val_10 = null;
            val_13 = val_10;
            val_10 = GooglePlayGames.Native.NativeSavedGameClient.IsValidFilename(filename:  val_13);
            if(val_10 == false)
            {
                goto label_10;
            }
            
            if(null == 0)
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            string val_9 = 0 + "Received invalid filename: "("Received invalid filename: ");
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            typeof(NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0).__il2cppRuntimeField_18.Invoke(arg1:  -4, arg2:  0);
            return;
            label_11:
            val_14 = mem[16];
            label_12:
            prefetchDataOnConflict = prefetchDataOnConflict;
            this.InternalOpen(filename:  filename, source:  source, resolutionStrategy:  val_14, prefetchDataOnConflict:  prefetchDataOnConflict, conflictCallback:  val_6.ToOnGameThread(conflictCallback:  val_10), completedCallback:  typeof(NativeSavedGameClient.<OpenWithAutomaticConflictResolution>c__AnonStorey0).__il2cppRuntimeField_18);
        }
        public void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            this.OpenWithAutomaticConflictResolution(filename:  filename, source:  source, resolutionStrategy:  resolutionStrategy, prefetchDataOnConflict:  false, conflictCallback:  0, completedCallback:  completedCallback);
        }
        private GooglePlayGames.BasicApi.SavedGame.ConflictCallback ToOnGameThread(GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback)
        {
            typeof(NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1).__il2cppRuntimeField_10 = conflictCallback;
            return (GooglePlayGames.BasicApi.SavedGame.ConflictCallback)new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  new System.Object(), method:  System.Void NativeSavedGameClient.<ToOnGameThread>c__AnonStorey1::<>m__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData));
        }
        public void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            System.Action<T1, T2> val_5 = GooglePlayGames.Native.NativeSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Object>(toConvert:  0);
            if((GooglePlayGames.Native.NativeSavedGameClient.IsValidFilename(filename:  val_5)) != false)
            {
                    this.InternalOpen(filename:  filename, source:  source, resolutionStrategy:  3, prefetchDataOnConflict:  prefetchDataOnConflict, conflictCallback:  GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0).ToOnGameThread(conflictCallback:  conflictCallback), completedCallback:  val_5);
                return;
            }
            
            string val_9 = 0 + "Received invalid filename: "("Received invalid filename: ");
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_5.Invoke(arg1:  -4, arg2:  0);
        }
        private void InternalOpen(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy val_6;
            var val_7;
            var val_8;
            var val_9;
            string val_10;
            val_6 = resolutionStrategy;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3).__il2cppRuntimeField_10 = completedCallback;
                val_7 = val_1;
                val_8 = val_1;
                typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3).__il2cppRuntimeField_18 = filename;
                typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3).__il2cppRuntimeField_20 = source;
                NativeSavedGameClient.<InternalOpen>c__AnonStorey3.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_4 = val_6;
                NativeSavedGameClient.<InternalOpen>c__AnonStorey3.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_8 = prefetchDataOnConflict;
                NativeSavedGameClient.<InternalOpen>c__AnonStorey3.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_10 = conflictCallback;
                NativeSavedGameClient.<InternalOpen>c__AnonStorey3.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_18 = this;
            }
            else
            {
                    mem[16] = completedCallback;
                val_7 = 24;
                mem[24] = filename;
                val_8 = 32;
                mem[32] = source;
                typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3).__il2cppRuntimeField_24 = val_6;
                mem[40] = prefetchDataOnConflict;
                mem[48] = conflictCallback;
                mem[56] = this;
                val_6 = typeof(NativeSavedGameClient.<InternalOpen>c__AnonStorey3).__il2cppRuntimeField_24;
            }
            
            if(val_6 <= 5)
            {
                    val_9 = mem[25808736 + (resolutionStrategy) << 2];
                val_9 = 25808736 + (resolutionStrategy) << 2;
            }
            else
            {
                    val_9 = 0;
            }
            
            var val_4 = val_9 & 255;
            val_4 = 249 >> val_4;
            if((val_4 & 1) == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    val_10 = mem[24];
            }
            else
            {
                    val_10 = mem[24];
            }
            
            this.mSnapshotManager.Open(fileName:  val_10, source:  GooglePlayGames.Native.NativeSavedGameClient.AsDataSource(source:  null), conflictPolicy:  4, callback:  new System.Action<OpenResponse>(object:  val_1, method:  System.Void NativeSavedGameClient.<InternalOpen>c__AnonStorey3::<>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.OpenResponse response)));
        }
        public void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> completedCallback)
        {
            object val_1 = new System.Object();
            typeof(NativeSavedGameClient.<ReadBinaryData>c__AnonStorey5).__il2cppRuntimeField_10 = completedCallback;
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            if(null != 0)
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            else
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            
            typeof(NativeSavedGameClient.<ReadBinaryData>c__AnonStorey5).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Object>(toConvert:  0);
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            typeof(NativeSavedGameClient.<ReadBinaryData>c__AnonStorey5).__il2cppRuntimeField_10.Invoke(arg1:  -4, arg2:  0);
        }
        public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            typeof(NativeSavedGameClient.<ShowSelectSavedGameUI>c__AnonStorey6).__il2cppRuntimeField_10 = callback;
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            if(null != 0)
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            else
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            
            typeof(NativeSavedGameClient.<ShowSelectSavedGameUI>c__AnonStorey6).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, System.Object>(toConvert:  0);
            if(maxDisplayedSavedGames != 0)
            {
                    this.mSnapshotManager.SnapshotSelectUI(allowCreate:  showCreateSaveUI, allowDelete:  showDeleteSaveUI, maxSnapshots:  maxDisplayedSavedGames, uiTitle:  uiTitle, callback:  new System.Action<SnapshotSelectUIResponse>(object:  new System.Object(), method:  System.Void NativeSavedGameClient.<ShowSelectSavedGameUI>c__AnonStorey6::<>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.SnapshotSelectUIResponse response)));
                return;
            }
            
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            typeof(NativeSavedGameClient.<ShowSelectSavedGameUI>c__AnonStorey6).__il2cppRuntimeField_10.Invoke(arg1:  -4, arg2:  0);
        }
        public void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            object val_1 = new System.Object();
            typeof(NativeSavedGameClient.<CommitUpdate>c__AnonStorey7).__il2cppRuntimeField_10 = callback;
            GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            if(null != 0)
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_4 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            else
            {
                    GooglePlayGames.BasicApi.IPlayGamesClient val_5 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            
            typeof(NativeSavedGameClient.<CommitUpdate>c__AnonStorey7).__il2cppRuntimeField_10 = GooglePlayGames.Native.NativeSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Object>(toConvert:  0);
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            typeof(NativeSavedGameClient.<CommitUpdate>c__AnonStorey7).__il2cppRuntimeField_10.Invoke(arg1:  -4, arg2:  0);
        }
        public void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback)
        {
            var val_7;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(NativeSavedGameClient.<FetchAllSavedGames>c__AnonStorey8).__il2cppRuntimeField_10 = callback;
                GooglePlayGames.BasicApi.IPlayGamesClient val_2 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            else
            {
                    val_7 = 16;
                mem[16] = callback;
                GooglePlayGames.BasicApi.IPlayGamesClient val_3 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            }
            
            System.Action<T1, T2> val_4 = GooglePlayGames.Native.NativeSavedGameClient.ToOnGameThread<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Object>(toConvert:  0);
            mem[16] = val_4;
            this.mSnapshotManager.FetchAll(source:  GooglePlayGames.Native.NativeSavedGameClient.AsDataSource(source:  val_4), callback:  new System.Action<FetchAllResponse>(object:  val_1, method:  System.Void NativeSavedGameClient.<FetchAllSavedGames>c__AnonStorey8::<>m__0(GooglePlayGames.Native.PInvoke.SnapshotManager.FetchAllResponse response)));
        }
        public void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata)
        {
            GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
            metadata = 0;
            this.mSnapshotManager.Delete(metadata:  metadata);
        }
        internal static bool IsValidFilename(string filename)
        {
            var val_1;
            if(X1 == 0)
            {
                    return false;
            }
            
            val_1 = null;
            val_1 = null;
            if(GooglePlayGames.Native.NativeSavedGameClient.ValidFilenameRegex != null)
            {
                    return GooglePlayGames.Native.NativeSavedGameClient.ValidFilenameRegex.IsMatch(input:  X1);
            }
            
            return GooglePlayGames.Native.NativeSavedGameClient.ValidFilenameRegex.IsMatch(input:  X1);
        }
        private static GooglePlayGames.Native.Cwrapper.Types.SnapshotConflictPolicy AsConflictPolicy(GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy strategy)
        {
            var val_5;
            var val_2 = (W1 < 3) ? (W1 + 3) : 0;
            if(val_2 == 3)
            {
                goto label_1;
            }
            
            if(val_2 == 5)
            {
                goto label_2;
            }
            
            if(val_2 != 4)
            {
                goto label_3;
            }
            
            val_5 = 3;
            return (SnapshotConflictPolicy)val_5;
            label_1:
            val_5 = 2;
            return (SnapshotConflictPolicy)val_5;
            label_2:
            val_5 = 4;
            return (SnapshotConflictPolicy)val_5;
            label_3:
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  0 + "Found unhandled strategy: "("Found unhandled strategy: "));
        }
        private static GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus AsRequestStatus(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.SnapshotOpenStatus status)
        {
            var val_5;
            var val_6;
            val_5 = W1;
            var val_3 = ((val_5 + 5) < 3) ? (val_5 + 8) : 0;
            if(val_3 == 3)
            {
                goto label_1;
            }
            
            if(val_3 == 5)
            {
                goto label_2;
            }
            
            if(val_5 != 1)
            {
                goto label_3;
            }
            
            val_6 = 1;
            return (GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus)val_6;
            label_1:
            val_6 = 0;
            return (GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus)val_6;
            label_2:
            val_6 = -3;
            return (GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus)val_6;
            label_3:
            val_5 = 0 + "Encountered unknown status: "("Encountered unknown status: ");
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_6 = -2;
            return (GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus)val_6;
        }
        private static GooglePlayGames.Native.Cwrapper.Types.DataSource AsDataSource(GooglePlayGames.BasicApi.DataSource source)
        {
            var val_3;
            if(W1 == 0)
            {
                goto label_1;
            }
            
            if(W1 != 1)
            {
                goto label_2;
            }
            
            val_3 = 2;
            return (DataSource)val_3;
            label_1:
            val_3 = 1;
            return (DataSource)val_3;
            label_2:
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  0 + "Found unhandled DataSource: "("Found unhandled DataSource: "));
        }
        private static GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus AsRequestStatus(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus status)
        {
            var val_3;
            var val_4;
            val_3 = W1;
            if((val_3 + 5) > 7)
            {
                goto label_2;
            }
            
            var val_3 = 25808800 + ((W1 + 5)) << 2;
            val_3 = val_3 - 3;
            if(val_3 > 5)
            {
                goto label_2;
            }
            
            var val_4 = 25808428 + ((25808800 + ((W1 + 5)) << 2 - 3)) << 2;
            val_4 = val_4 + 25808428;
            goto (25808428 + ((25808800 + ((W1 + 5)) << 2 - 3)) << 2 + 25808428);
            label_2:
            val_3 = 0 + "Unknown status: "("Unknown status: ");
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_4 = -2;
            return (GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus);
        }
        private static GooglePlayGames.BasicApi.SavedGame.SelectUIStatus AsUIStatus(GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus uiStatus)
        {
            var val_3;
            var val_4;
            val_3 = W1;
            if((val_3 + 6) > 7)
            {
                goto label_2;
            }
            
            var val_3 = 25808832 + ((W1 + 6)) << 2;
            val_3 = val_3 - 3;
            if(val_3 > 5)
            {
                goto label_2;
            }
            
            var val_4 = 25808452 + ((25808832 + ((W1 + 6)) << 2 - 3)) << 2;
            val_4 = val_4 + 25808452;
            goto (25808452 + ((25808832 + ((W1 + 6)) << 2 - 3)) << 2 + 25808452);
            label_2:
            val_3 = 0 + "Encountered unknown UI Status: "("Encountered unknown UI Status: ");
            GooglePlayGames.OurUtils.Logger.e(msg:  0);
            val_4 = 0;
            return (GooglePlayGames.BasicApi.SavedGame.SelectUIStatus)val_4;
        }
        private static GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange AsMetadataChange(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate update)
        {
            System.Byte[] val_10;
            NativeSnapshotMetadataChange.Builder val_1 = new NativeSnapshotMetadataChange.Builder();
            if(X1.EnableSavedGames != false)
            {
                    val_10 = X1.LocalClientId;
                NativeSnapshotMetadataChange.Builder val_4 = SetCoverImageFromPngData(pngData:  val_10);
            }
            
            if(X1.EnableSavedGames != false)
            {
                    val_10 = X1;
                System.Runtime.InteropServices.HandleRef val_6 = SelfPtr();
                GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetDescription(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper}, description:  val_6.handle);
            }
            
            if((X1 & 1) == 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange)Build();
            }
            
            System.Collections.Generic.KeyValuePair<TKey, TValue> val_7 = X1.Current;
            System.Runtime.InteropServices.HandleRef val_8 = SelfPtr();
            GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetPlayedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_8.wrapper}, played_time:  val_8.handle);
            return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange)Build();
        }
        private static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert)
        {
            mem2[0] = __RuntimeMethodHiddenParam;
            return (System.Action<T1, T2>)X2 + 48 + 16 + 8;
        }
        private static NativeSavedGameClient()
        {
            GooglePlayGames.Native.NativeSavedGameClient.ValidFilenameRegex = new System.Text.RegularExpressions.Regex(pattern:  "\\A[a-zA-Z0-9-._~]{1,100}\\Z");
        }
    
    }

}
