using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeSnapshotMetadataChange : BaseReferenceHolder
    {
        // Methods
        internal NativeSnapshotMetadataChange(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.SnapshotMetadataChange.SnapshotMetadataChange_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange)val_2;
        }
    
    }

}
