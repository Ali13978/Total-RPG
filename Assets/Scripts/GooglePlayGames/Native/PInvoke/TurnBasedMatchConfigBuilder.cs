using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class TurnBasedMatchConfigBuilder : BaseReferenceHolder
    {
        // Methods
        private TurnBasedMatchConfigBuilder(IntPtr selfPointer)
        {
        
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder PopulateFromUIResponse(GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse response)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            IntPtr val_2 = response.AsPointer();
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_PopulateFromPlayerSelectUIResponse(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, response:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder SetVariant(uint variant)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_SetVariant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, variant:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder AddInvitedPlayer(string playerId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_AddPlayerToInvite(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, player_id:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder SetExclusiveBitMask(ulong bitmask)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_SetExclusiveBitMask(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, exclusive_bit_mask:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder SetMinimumAutomatchingPlayers(uint minimum)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_SetMinimumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, minimum_automatching_players:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder SetMaximumAutomatchingPlayers(uint maximum)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_SetMaximumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, maximum_automatching_players:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig Build()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig)new GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_Create(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder Create()
        {
            return (GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder)new GooglePlayGames.Native.PInvoke.TurnBasedMatchConfigBuilder(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfigBuilder.TurnBasedMatchConfig_Builder_Construct());
        }
    
    }

}
