using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeConnectionResponse : BaseReferenceHolder
    {
        // Methods
        internal NativeConnectionResponse(IntPtr pointer)
        {
        
        }
        internal string RemoteEndpointId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeConnectionResponse::<RemoteEndpointId>m__0(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponse_ResponseCode ResponseCode()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal byte[] Payload()
        {
            PInvokeUtilities.OutMethod<System.Byte> val_1 = new PInvokeUtilities.OutMethod<System.Byte>(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeConnectionResponse::<Payload>m__1(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToArray<System.Byte>(outMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Nearby.ConnectionResponse AsResponse(long localClientId)
        {
            GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_0;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            ConnectionResponse_ResponseCode val_2 = GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
            if((((val_2 + 4) < 7) ? (val_2 + 7) : 0) > 9)
            {
                    return val_0;
            }
            
            var val_7 = 25808532 + (val_3 < 0x7 ? (val_2 + 7) : 0) << 2;
            val_7 = val_7 + 25808532;
            goto (25808532 + (val_3 < 0x7 ? (val_2 + 7) : 0) << 2 + 25808532);
        }
        internal static GooglePlayGames.Native.PInvoke.NativeConnectionResponse FromPointer(IntPtr pointer)
        {
            if((System.IntPtr.op_Equality(value1:  0, value2:  X1)) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeConnectionResponse)0;
            }
            
            GooglePlayGames.Native.PInvoke.NativeConnectionResponse val_3 = null;
            0 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.NativeConnectionResponse(pointer:  X1);
            return (GooglePlayGames.Native.PInvoke.NativeConnectionResponse)0;
        }
        private UIntPtr <RemoteEndpointId>m__0(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponse_GetRemoteEndpointId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
        private UIntPtr <Payload>m__1(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.ConnectionResponse_GetPayload(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
    
    }

}
