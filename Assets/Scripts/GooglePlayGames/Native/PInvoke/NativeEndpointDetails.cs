using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeEndpointDetails : BaseReferenceHolder
    {
        // Methods
        internal NativeEndpointDetails(IntPtr pointer)
        {
        
        }
        internal string EndpointId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEndpointDetails::<EndpointId>m__0(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string Name()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEndpointDetails::<Name>m__1(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string ServiceId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEndpointDetails::<ServiceId>m__2(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.EndpointDetails_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Nearby.EndpointDetails ToDetails()
        {
            string val_1 = this.EndpointId();
            string val_2 = this.Name();
            string val_3 = this.ServiceId();
            val_0.mName = 0;
            val_0.mServiceId = 0;
            val_0.mEndpointId = 0;
        }
        internal static GooglePlayGames.Native.PInvoke.NativeEndpointDetails FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeEndpointDetails)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeEndpointDetails val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeEndpointDetails(pointer:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeEndpointDetails)val_2;
        }
        private UIntPtr <EndpointId>m__0(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.EndpointDetails_GetEndpointId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
        private UIntPtr <Name>m__1(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.EndpointDetails_GetName(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
        private UIntPtr <ServiceId>m__2(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.EndpointDetails_GetServiceId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
    
    }

}
