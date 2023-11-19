using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class RealtimeRoomConfigBuilder : BaseReferenceHolder
    {
        // Methods
        internal RealtimeRoomConfigBuilder(IntPtr selfPointer)
        {
        
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder PopulateFromUIResponse(GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse response)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            IntPtr val_2 = response.AsPointer();
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_PopulateFromPlayerSelectUIResponse(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, response:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder SetVariant(uint variantValue)
        {
            var val_1 = (variantValue == 0) ? 0 : variantValue;
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_SetVariant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, variant:  val_2.handle);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder AddInvitedPlayer(string playerId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_AddPlayerToInvite(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, player_id:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder SetExclusiveBitMask(ulong bitmask)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_SetExclusiveBitMask(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, exclusive_bit_mask:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder SetMinimumAutomatchingPlayers(uint minimum)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_SetMinimumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, minimum_automatching_players:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder SetMaximumAutomatchingPlayers(uint maximum)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_SetMaximumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, maximum_automatching_players:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.RealtimeRoomConfig Build()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfig)new GooglePlayGames.Native.PInvoke.RealtimeRoomConfig(selfPointer:  GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_Create(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder Create()
        {
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder)new GooglePlayGames.Native.PInvoke.RealtimeRoomConfigBuilder(selfPointer:  GooglePlayGames.Native.Cwrapper.RealTimeRoomConfigBuilder.RealTimeRoomConfig_Builder_Construct());
        }
    
    }

}
