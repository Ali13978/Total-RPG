using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeAchievement : BaseReferenceHolder
    {
        // Fields
        private const ulong MinusOne = 18446744073709551615;
        
        // Methods
        internal NativeAchievement(IntPtr selfPointer)
        {
        
        }
        internal uint CurrentSteps()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_CurrentSteps(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string Description()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeAchievement::<Description>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeAchievement::<Id>m__1(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string Name()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeAchievement::<Name>m__2(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal GooglePlayGames.Native.Cwrapper.Types.AchievementState State()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_State(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal uint TotalSteps()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_TotalSteps(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.AchievementType Type()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Type(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal ulong LastModifiedTime()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == false)
            {
                    return 0;
            }
            
            System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_LastModifiedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper});
        }
        internal ulong getXP()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_XP(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string getRevealedImageUrl()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeAchievement::<getRevealedImageUrl>m__3(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string getUnlockedImageUrl()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeAchievement::<getUnlockedImageUrl>m__4(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Achievement AsAchievement()
        {
            var val_25;
            Id = this.Id();
            Name = this.Name();
            Description = this.Description();
            ulong val_5 = this.LastModifiedTime();
            var val_6 = (val_5 == 1) ? 0 : ((double)val_5);
            LastModifiedTime = new System.DateTime() {ticks = new System.TimeSpan() {}};
            System.Runtime.InteropServices.HandleRef val_7 = this.SelfPtr();
            Points = GooglePlayGames.Native.Cwrapper.Achievement.Achievement_XP(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_7.wrapper});
            RevealedImageUrl = this.getRevealedImageUrl();
            UnlockedImageUrl = this.getUnlockedImageUrl();
            System.Runtime.InteropServices.HandleRef val_11 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Type(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_11.wrapper})) == 2)
            {
                    IsIncremental = true;
                System.Runtime.InteropServices.HandleRef val_13 = this.SelfPtr();
                CurrentSteps = GooglePlayGames.Native.Cwrapper.Achievement.Achievement_CurrentSteps(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_13.wrapper});
                System.Runtime.InteropServices.HandleRef val_15 = this.SelfPtr();
                TotalSteps = GooglePlayGames.Native.Cwrapper.Achievement.Achievement_TotalSteps(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_15.wrapper});
            }
            
            System.Runtime.InteropServices.HandleRef val_17 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.Achievement.Achievement_State(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_17.wrapper})) == 2)
            {
                    val_25 = 1;
            }
            else
            {
                    System.Runtime.InteropServices.HandleRef val_19 = this.SelfPtr();
            }
            
            IsRevealed = ((GooglePlayGames.Native.Cwrapper.Achievement.Achievement_State(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_19.wrapper})) == 3) ? 1 : 0;
            System.Runtime.InteropServices.HandleRef val_22 = this.SelfPtr();
            IsUnlocked = ((GooglePlayGames.Native.Cwrapper.Achievement.Achievement_State(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_22.wrapper})) == 3) ? 1 : 0;
            return (GooglePlayGames.BasicApi.Achievement)new GooglePlayGames.BasicApi.Achievement();
        }
        private UIntPtr <Description>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Description(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <Id>m__1(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <Name>m__2(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_Name(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <getRevealedImageUrl>m__3(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_RevealedIconUrl(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <getUnlockedImageUrl>m__4(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Achievement.Achievement_UnlockedIconUrl(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
