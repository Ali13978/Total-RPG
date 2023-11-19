using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NearbyConnectionsManagerBuilder : BaseReferenceHolder
    {
        // Fields
        private static GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.OnInitializationFinishedCallback <>f__mg$cache0;
        
        // Methods
        internal NearbyConnectionsManagerBuilder()
        {
            IntPtr val_1 = GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.NearbyConnections_Builder_Construct();
        }
        internal GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder SetOnInitializationFinished(System.Action<GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus> callback)
        {
            NearbyConnectionsBuilder.OnInitializationFinishedCallback val_4;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_4 = GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder.<>f__mg$cache0;
            if(val_4 == null)
            {
                    GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder.<>f__mg$cache0 = new NearbyConnectionsBuilder.OnInitializationFinishedCallback(object:  0, method:  static System.Void GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder::InternalOnInitializationFinishedCallback(GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus status, IntPtr userData));
                val_4 = GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder.<>f__mg$cache0;
            }
            
            IntPtr val_3 = GooglePlayGames.Native.PInvoke.Callbacks.ToIntPtr(callback:  0);
            GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.NearbyConnections_Builder_SetOnInitializationFinished(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, callback:  val_1.handle, callback_arg:  val_4);
            return (GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder)this;
        }
        [AOT.MonoPInvokeCallbackAttribute]
        private static void InternalOnInitializationFinishedCallback(GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus status, IntPtr userData)
        {
            InitializationStatus val_4;
            string val_7;
            val_4 = userData;
            System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean> val_1 = GooglePlayGames.Native.PInvoke.Callbacks.IntPtrToPermanentCallback<System.Action<GooglePlayGames.Native.PInvoke.NativeRealTimeRoom, GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.Byte[], System.Boolean>>(handle:  0);
            if(val_1 != null)
            {
                    val_1.Invoke(obj:  val_4);
                return;
            }
            
            val_4 = 0 + "Callback for Initialization is null. Received status: "("Callback for Initialization is null. Received status: ");
            val_7 = null;
            GooglePlayGames.OurUtils.Logger.w(msg:  val_7);
        }
        internal GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder SetLocalClientId(long localClientId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.NearbyConnections_Builder_SetClientId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, client_id:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder SetDefaultLogLevel(GooglePlayGames.Native.Cwrapper.Types.LogLevel minLevel)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.NearbyConnections_Builder_SetDefaultOnLog(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, min_level:  val_1.handle);
            return (GooglePlayGames.Native.PInvoke.NearbyConnectionsManagerBuilder)this;
        }
        internal GooglePlayGames.Native.PInvoke.NearbyConnectionsManager Build(GooglePlayGames.Native.PInvoke.PlatformConfiguration configuration)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            IntPtr val_2 = configuration.AsPointer();
            return (GooglePlayGames.Native.PInvoke.NearbyConnectionsManager)new GooglePlayGames.Native.PInvoke.NearbyConnectionsManager(selfPointer:  GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.NearbyConnections_Builder_Create(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, platform:  val_1.handle));
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnectionsBuilder.NearbyConnections_Builder_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
    
    }

}
