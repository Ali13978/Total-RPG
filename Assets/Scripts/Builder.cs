using UnityEngine;
internal class NativeSnapshotMetadataChange.Builder : BaseReferenceHolder
{
    // Methods
    internal NativeSnapshotMetadataChange.Builder()
    {
        IntPtr val_1 = GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_Construct();
    }
    protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
    {
        GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange.Builder SetDescription(string description)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetDescription(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, description:  val_1.handle);
        return (NativeSnapshotMetadataChange.Builder)this;
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange.Builder SetPlayedTime(ulong playedTime)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetPlayedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, played_time:  val_1.handle);
        return (NativeSnapshotMetadataChange.Builder)this;
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange.Builder SetCoverImageFromPngData(byte[] pngData)
    {
        GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
        long val_3 = pngData.LongLength;
        GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetCoverImageFromPngData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, png_data:  val_2.handle, png_data_size:  pngData);
        return (NativeSnapshotMetadataChange.Builder)this;
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange.Builder From(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate update)
    {
        System.Byte[] val_8;
        if(update.mDescriptionUpdated.EnableSavedGames != false)
        {
                val_8 = 1152921512168263344;
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetDescription(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, description:  val_2.handle);
        }
        
        if(update.mDescriptionUpdated.EnableSavedGames != false)
        {
                val_8 = update.mDescriptionUpdated.LocalClientId;
            this = this.SetCoverImageFromPngData(pngData:  val_8);
        }
        
        if((1152921512168263344 & 1) == 0)
        {
                return (NativeSnapshotMetadataChange.Builder)this;
        }
        
        System.Collections.Generic.KeyValuePair<TKey, TValue> val_6 = update.mDescriptionUpdated.Current;
        System.Runtime.InteropServices.HandleRef val_7 = this.SelfPtr();
        GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_SetPlayedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_7.wrapper}, played_time:  val_7.handle);
        return (NativeSnapshotMetadataChange.Builder)this;
    }
    internal GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange Build()
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
        return GooglePlayGames.Native.PInvoke.NativeSnapshotMetadataChange.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.SnapshotMetadataChangeBuilder.SnapshotMetadataChange_Builder_Create(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
    }

}
