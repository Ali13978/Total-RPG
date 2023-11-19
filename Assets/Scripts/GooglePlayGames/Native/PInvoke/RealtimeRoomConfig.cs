using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class RealtimeRoomConfig : BaseReferenceHolder
    {
        // Methods
        internal RealtimeRoomConfig(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.RealTimeRoomConfig.RealTimeRoomConfig_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.RealtimeRoomConfig FromPointer(IntPtr selfPointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfig)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.RealtimeRoomConfig val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.RealtimeRoomConfig(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.RealtimeRoomConfig)val_2;
        }
    
    }

}
