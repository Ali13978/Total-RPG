using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeSnapshotMetadata : BaseReferenceHolder, ISavedGameMetadata
    {
        // Properties
        public bool IsOpen { get; }
        public string Filename { get; }
        public string Description { get; }
        public string CoverImageURL { get; }
        public System.TimeSpan TotalTimePlayed { get; }
        public System.DateTime LastModifiedTimestamp { get; }
        
        // Methods
        internal NativeSnapshotMetadata(IntPtr selfPointer)
        {
        
        }
        public bool get_IsOpen()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_IsOpen(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        public string get_Filename()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata::<get_Filename>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public string get_Description()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata::<get_Description>m__1(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public string get_CoverImageURL()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeSnapshotMetadata::<get_CoverImageURL>m__2(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public System.TimeSpan get_TotalTimePlayed()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            if(((GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_PlayedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) & 9223372036854775808) != 0)
            {
                    return System.TimeSpan.FromMilliseconds(value:  0);
            }
            
            return System.TimeSpan.FromMilliseconds(value:  0);
        }
        public System.DateTime get_LastModifiedTimestamp()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            long val_2 = GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_LastModifiedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.FromMillisSinceUnixEpoch(millisSinceEpoch:  0);
        }
        public override string ToString()
        {
            var val_11;
            var val_12;
            if(this.IsDisposed() != false)
            {
                    val_12 = "[NativeSnapshotMetadata: DELETED]";
                return (string)System.String.Format(format:  0, args:  "[NativeSnapshotMetadata: IsOpen={0}, Filename={1}, Description={2}, CoverImageUrl={3}, TotalTimePlayed={4}, LastModifiedTimestamp={5}]");
            }
            
            val_11 = null;
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            typeof(System.Object[]).__il2cppRuntimeField_20 = GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_IsOpen(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper});
            typeof(System.Object[]).__il2cppRuntimeField_21 = 29529535;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.Filename;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.Description;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.CoverImageURL;
            System.TimeSpan val_8 = this.TotalTimePlayed;
            typeof(System.Object[]).__il2cppRuntimeField_40 = val_8;
            System.DateTime val_9 = this.LastModifiedTimestamp;
            typeof(System.Object[]).__il2cppRuntimeField_48 = val_9;
            return (string)System.String.Format(format:  0, args:  "[NativeSnapshotMetadata: IsOpen={0}, Filename={1}, Description={2}, CoverImageUrl={3}, TotalTimePlayed={4}, LastModifiedTimestamp={5}]");
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        private UIntPtr <get_Filename>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_FileName(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <get_Description>m__1(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_Description(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <get_CoverImageURL>m__2(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.SnapshotMetadata.SnapshotMetadata_CoverImageURL(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
