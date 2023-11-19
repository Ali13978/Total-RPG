using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class GameServicesBuilder : BaseReferenceHolder
    {
        // Fields
        private static GooglePlayGames.Native.Cwrapper.Builder.OnAuthActionFinishedCallback <>f__mg$cache0;
        private static GooglePlayGames.Native.Cwrapper.Builder.OnAuthActionStartedCallback <>f__mg$cache1;
        private static GooglePlayGames.Native.Cwrapper.Builder.OnTurnBasedMatchEventCallback <>f__mg$cache2;
        private static GooglePlayGames.Native.Cwrapper.Builder.OnMultiplayerInvitationEventCallback <>f__mg$cache3;
        
        // Methods
        private GameServicesBuilder(IntPtr selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.InternalHooks.InternalHooks_ConfigureForUnityPlugin(builder:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, unity_version:  val_1.handle);
        }
        internal void SetOnAuthFinishedCallback(GooglePlayGames.Native.PInvoke.GameServicesBuilder.AuthFinishedCallback callback)
        {
            Builder.OnAuthActionFinishedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache0;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache0 = new Builder.OnAuthActionFinishedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.GameServicesBuilder::InternalAuthFinishedCallback(GooglePlayGames.Native.Cwrapper.Types.AuthOperation op, GooglePlayGames.Native.Cwrapper.CommonErrorStatus.AuthStatus status, IntPtr data));
                val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache0;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_SetOnAuthActionFinished(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
        }
        internal void EnableSnapshots()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_EnableSnapshots(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal void AddOauthScope(string scope)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_AddOauthScope(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, scope:  val_1.handle);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalAuthFinishedCallback(GooglePlayGames.Native.Cwrapper.Types.AuthOperation op, GooglePlayGames.Native.Cwrapper.CommonErrorStatus.AuthStatus status, IntPtr data)
        {
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(operation:  status, status:  data);
        }
        internal void SetOnAuthStartedCallback(GooglePlayGames.Native.PInvoke.GameServicesBuilder.AuthStartedCallback callback)
        {
            Builder.OnAuthActionStartedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache1;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache1 = new Builder.OnAuthActionStartedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.GameServicesBuilder::InternalAuthStartedCallback(GooglePlayGames.Native.Cwrapper.Types.AuthOperation op, IntPtr data));
                val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache1;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_SetOnAuthActionStarted(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalAuthStartedCallback(GooglePlayGames.Native.Cwrapper.Types.AuthOperation op, IntPtr data)
        {
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.Invoke(operation:  data);
        }
        internal void SetShowConnectingPopup(bool flag)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            bool val_2 = flag;
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_SetShowConnectingPopup(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, flag:  val_1.handle);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnTurnBasedMatchEventCallback(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData)
        {
            var val_5;
            var val_6;
            GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_12;
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_18;
            val_13 = static System.Action<MultiplayerEvent, System.String, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> GooglePlayGames.Native.PInvoke.Callbacks::IntPtrToPermanentCallback<System.Action<MultiplayerEvent, System.String, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>>(IntPtr handle);
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_2 = GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch.FromPointer(selfPointer:  val_1);
            if(val_1 != null)
            {
                    val_13 = match;
                val_1.Invoke(arg1:  matchId, arg2:  val_13, arg3:  val_2);
            }
            
            val_14 = 0;
            val_15 = 74;
            label_20:
            if(val_2 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = 0;
                val_16 = val_2;
            }
            
            if(74 == 74)
            {
                    return;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
            
            val_17 = 0;
            val_18 = 1152921504961531904;
            if(val_17 != 1)
            {
                goto label_19;
            }
            
            goto label_20;
            label_19:
            val_9 = val_9;
            val_10 = val_17;
            val_7 = val_18;
            val_8 = val_8;
            val_5 = val_5;
            val_6 = val_6;
            GooglePlayGames.Native.PInvoke.GameServicesBuilder.InternalOnMultiplayerInvitationEventCallback(eventType:  0, matchId:  val_18, match:  0, userData:  null);
            if(val_12 == 0)
            {
                    return;
            }
        
        }
        internal void SetOnTurnBasedMatchEventCallback(System.Action<GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent, string, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> callback)
        {
            Builder.OnTurnBasedMatchEventCallback val_4;
            IntPtr val_1 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache2;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache2 = new Builder.OnTurnBasedMatchEventCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.GameServicesBuilder::InternalOnTurnBasedMatchEventCallback(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData));
                val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache2;
            }
            
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_SetOnTurnBasedMatchEvent(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, callback:  val_2.handle, callback_arg:  val_4);
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnMultiplayerInvitationEventCallback(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            GooglePlayGames.Native.PInvoke.MultiplayerInvitation val_2 = GooglePlayGames.Native.PInvoke.MultiplayerInvitation.FromPointer(selfPointer:  val_1);
            if(val_1 != null)
            {
                    val_1.Invoke(arg1:  matchId, arg2:  match, arg3:  val_2);
            }
            
            val_13 = 0;
            val_14 = 74;
            label_20:
            if(val_2 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_15 = val_2;
            }
            
            if(74 == 74)
            {
                    return;
            }
            
            if(val_13 == 0)
            {
                    return;
            }
            
            val_16 = 0;
            val_17 = 1152921504960253952;
            if(val_16 != 1)
            {
                goto label_19;
            }
            
            goto label_20;
            label_19:
        }
        internal void SetOnMultiplayerInvitationEventCallback(System.Action<GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent, string, GooglePlayGames.Native.PInvoke.MultiplayerInvitation> callback)
        {
            Builder.OnMultiplayerInvitationEventCallback val_4;
            IntPtr val_1 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  null);
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache3;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache3 = new Builder.OnMultiplayerInvitationEventCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.GameServicesBuilder::InternalOnMultiplayerInvitationEventCallback(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, IntPtr match, IntPtr userData));
                val_4 = GooglePlayGames.Native.PInvoke.GameServicesBuilder.<>f__mg$cache3;
            }
            
            GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_SetOnMultiplayerInvitationEvent(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}, callback:  val_2.handle, callback_arg:  val_4);
        }
        internal GooglePlayGames.Native.PInvoke.GameServices Build(GooglePlayGames.Native.PInvoke.PlatformConfiguration configRef)
        {
            System.Runtime.InteropServices.HandleRef val_1 = configRef.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_2 = configRef.AsHandle();
            IntPtr val_3 = System.Runtime.InteropServices.HandleRef.ToIntPtr(value:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper});
            if(((-1061859720) & 1) == 0)
            {
                    return (GooglePlayGames.Native.PInvoke.GameServices)new GooglePlayGames.Native.PInvoke.GameServices(selfPointer:  GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_Create(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, platform:  val_1.handle));
            }
            
            System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  "There was an error creating a GameServices object. Check for log errors from GamesNativeSDK");
        }
        internal static GooglePlayGames.Native.PInvoke.GameServicesBuilder Create()
        {
            return (GooglePlayGames.Native.PInvoke.GameServicesBuilder)new GooglePlayGames.Native.PInvoke.GameServicesBuilder(selfPointer:  GooglePlayGames.Native.Cwrapper.Builder.GameServices_Builder_Construct());
        }
    
    }

}
