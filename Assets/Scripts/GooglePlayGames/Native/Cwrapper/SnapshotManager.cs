using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class SnapshotManager
    {
        // Methods
        internal static extern void SnapshotManager_FetchAll(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.SnapshotManager.FetchAllCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotManager_ShowSelectUIOperation(System.Runtime.InteropServices.HandleRef self, bool allow_create, bool allow_delete, uint max_snapshots, string title, GooglePlayGames.Native.Cwrapper.SnapshotManager.SnapshotSelectUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    bool val_2 = allow_delete;
                uint val_3 = max_snapshots & 1;
                return;
            }
        
        }
        internal static extern void SnapshotManager_Read(System.Runtime.InteropServices.HandleRef self, IntPtr snapshot_metadata, GooglePlayGames.Native.Cwrapper.SnapshotManager.ReadCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotManager_Commit(System.Runtime.InteropServices.HandleRef self, IntPtr snapshot_metadata, IntPtr metadata_change, byte[] data, UIntPtr data_size, GooglePlayGames.Native.Cwrapper.SnapshotManager.CommitCallback callback, IntPtr callback_arg)
        {
            UIntPtr val_3 = data_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void SnapshotManager_Open(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string file_name, GooglePlayGames.Native.Cwrapper.Types.SnapshotConflictPolicy conflict_policy, GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotManager_ResolveConflict(System.Runtime.InteropServices.HandleRef self, string conflict_id, IntPtr snapshot_metadata, IntPtr metadata_change, GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotManager_ResolveConflict(System.Runtime.InteropServices.HandleRef self, string conflict_id, IntPtr snapshot_metadata, IntPtr metadata_change, byte[] data, UIntPtr data_size, GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback callback, IntPtr callback_arg)
        {
            UIntPtr val_3 = data_size;
            if(25808612 != 0)
            {
                    val_3 = (val_3 == 0) ? 0 : (val_3 + 32);
                return;
            }
        
        }
        internal static extern void SnapshotManager_ResolveConflict(System.Runtime.InteropServices.HandleRef self, string conflict_id, IntPtr snapshot_metadata, GooglePlayGames.Native.Cwrapper.SnapshotManager.OpenCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotManager_Delete(System.Runtime.InteropServices.HandleRef self, IntPtr snapshot_metadata)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotManager_FetchAllResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus SnapshotManager_FetchAllResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr SnapshotManager_FetchAllResponse_GetData_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr SnapshotManager_FetchAllResponse_GetData_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern void SnapshotManager_OpenResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.SnapshotOpenStatus SnapshotManager_OpenResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (CommonErrorStatus.SnapshotOpenStatus)X2;
            }
        
        }
        internal static extern IntPtr SnapshotManager_OpenResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern UIntPtr SnapshotManager_OpenResponse_GetConflictId(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern IntPtr SnapshotManager_OpenResponse_GetConflictOriginal(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern IntPtr SnapshotManager_OpenResponse_GetConflictUnmerged(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void SnapshotManager_CommitResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus SnapshotManager_CommitResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr SnapshotManager_CommitResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void SnapshotManager_ReadResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus SnapshotManager_ReadResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr SnapshotManager_ReadResponse_GetData(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern void SnapshotManager_SnapshotSelectUIResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus SnapshotManager_SnapshotSelectUIResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIStatus)X2;
            }
        
        }
        internal static extern IntPtr SnapshotManager_SnapshotSelectUIResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
    
    }

}
