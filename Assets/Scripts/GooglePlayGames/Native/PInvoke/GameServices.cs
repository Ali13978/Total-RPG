using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class GameServices : BaseReferenceHolder
    {
        // Methods
        internal GameServices(IntPtr selfPointer)
        {
        
        }
        internal bool IsAuthenticated()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.GameServices.GameServices_IsAuthorized(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void SignOut()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.GameServices.GameServices_SignOut(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void StartAuthorizationUI()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.GameServices.GameServices_StartAuthorizationUI(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        public GooglePlayGames.Native.PInvoke.AchievementManager AchievementManager()
        {
            return (GooglePlayGames.Native.PInvoke.AchievementManager)new GooglePlayGames.Native.PInvoke.AchievementManager(services:  this);
        }
        public GooglePlayGames.Native.PInvoke.LeaderboardManager LeaderboardManager()
        {
            return (GooglePlayGames.Native.PInvoke.LeaderboardManager)new GooglePlayGames.Native.PInvoke.LeaderboardManager(services:  this);
        }
        public GooglePlayGames.Native.PInvoke.PlayerManager PlayerManager()
        {
            return (GooglePlayGames.Native.PInvoke.PlayerManager)new GooglePlayGames.Native.PInvoke.PlayerManager(services:  this);
        }
        public GooglePlayGames.Native.PInvoke.StatsManager StatsManager()
        {
            return (GooglePlayGames.Native.PInvoke.StatsManager)new GooglePlayGames.Native.PInvoke.StatsManager(services:  this);
        }
        internal System.Runtime.InteropServices.HandleRef AsHandle()
        {
            return this.SelfPtr();
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.GameServices.GameServices_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
    
    }

}
