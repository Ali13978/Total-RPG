using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeConnectionRequest : BaseReferenceHolder
    {
        // Methods
        internal NativeConnectionRequest(IntPtr pointer)
        {
        
        }
        internal string RemoteEndpointId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeConnectionRequest::<RemoteEndpointId>m__0(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string RemoteEndpointName()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeConnectionRequest::<RemoteEndpointName>m__1(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal byte[] Payload()
        {
            PInvokeUtilities.OutMethod<System.Byte> val_1 = new PInvokeUtilities.OutMethod<System.Byte>(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeConnectionRequest::<Payload>m__2(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToArray<System.Byte>(outMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionRequest_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Nearby.ConnectionRequest AsRequest()
        {
            GooglePlayGames.BasicApi.Nearby.ConnectionRequest val_0;
            string val_1 = this.RemoteEndpointId();
            string val_2 = this.RemoteEndpointName();
            string val_3 = GooglePlayGames.Native.PInvoke.NearbyConnectionsManager.ServiceId;
            System.Byte[] val_4 = this.Payload();
            val_0.mRemoteEndpoint.mEndpointId = 0;
            val_0.mRemoteEndpoint.mServiceId = 0;
            return val_0;
        }
        internal static GooglePlayGames.Native.PInvoke.NativeConnectionRequest FromPointer(IntPtr pointer)
        {
            if((System.IntPtr.op_Equality(value1:  0, value2:  X1)) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeConnectionRequest)0;
            }
            
            GooglePlayGames.Native.PInvoke.NativeConnectionRequest val_3 = null;
            0 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.NativeConnectionRequest(pointer:  X1);
            return (GooglePlayGames.Native.PInvoke.NativeConnectionRequest)0;
        }
        private UIntPtr <RemoteEndpointId>m__0(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionRequest_GetRemoteEndpointId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
        private UIntPtr <RemoteEndpointName>m__1(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionRequest_GetRemoteEndpointName(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
        private UIntPtr <Payload>m__2(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionRequest_GetPayload(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
    
    }

}
