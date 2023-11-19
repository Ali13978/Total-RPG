using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class SnapshotMetadataChangeBuilder
    {
        // Methods
        internal static extern void SnapshotMetadataChange_Builder_SetDescription(System.Runtime.InteropServices.HandleRef self, string description)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr SnapshotMetadataChange_Builder_Construct()
        {
            if(25808612 != 0)
            {
                    return (IntPtr);
            }
        
        }
        internal static extern void SnapshotMetadataChange_Builder_SetPlayedTime(System.Runtime.InteropServices.HandleRef self, ulong played_time)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void SnapshotMetadataChange_Builder_SetCoverImageFromPngData(System.Runtime.InteropServices.HandleRef self, byte[] png_data, UIntPtr png_data_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (png_data_size == 0) ? 0 : (png_data_size + 32);
                return;
            }
        
        }
        internal static extern IntPtr SnapshotMetadataChange_Builder_Create(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void SnapshotMetadataChange_Builder_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
