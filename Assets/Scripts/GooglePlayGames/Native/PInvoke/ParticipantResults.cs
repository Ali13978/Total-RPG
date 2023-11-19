using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class ParticipantResults : BaseReferenceHolder
    {
        // Methods
        internal ParticipantResults(IntPtr selfPointer)
        {
        
        }
        internal bool HasResultsForParticipant(string participantId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ParticipantResults.ParticipantResults_HasResultsForParticipant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, participant_id:  val_1.handle);
        }
        internal uint PlacingForParticipant(string participantId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ParticipantResults.ParticipantResults_PlaceForParticipant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, participant_id:  val_1.handle);
        }
        internal GooglePlayGames.Native.Cwrapper.Types.MatchResult ResultsForParticipant(string participantId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ParticipantResults.ParticipantResults_MatchResultForParticipant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, participant_id:  val_1.handle);
        }
        internal GooglePlayGames.Native.PInvoke.ParticipantResults WithResult(string participantId, uint placing, GooglePlayGames.Native.Cwrapper.Types.MatchResult result)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.ParticipantResults)new GooglePlayGames.Native.PInvoke.ParticipantResults(selfPointer:  GooglePlayGames.Native.Cwrapper.ParticipantResults.ParticipantResults_WithResult(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, participant_id:  val_1.handle, placing:  participantId, result:  placing));
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.ParticipantResults.ParticipantResults_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
    
    }

}
