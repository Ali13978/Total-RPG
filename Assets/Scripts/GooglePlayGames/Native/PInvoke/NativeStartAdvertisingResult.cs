using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeStartAdvertisingResult : BaseReferenceHolder
    {
        // Methods
        internal NativeStartAdvertisingResult(IntPtr pointer)
        {
        
        }
        internal int GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.StartAdvertisingResult_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string LocalEndpointName()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult::<LocalEndpointName>m__0(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.StartAdvertisingResult_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Nearby.AdvertisingResult AsResult()
        {
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            int val_3 = GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.StartAdvertisingResult_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper});
            object val_4 = System.Enum.ToObject(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            string val_5 = this.LocalEndpointName();
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return new GooglePlayGames.BasicApi.Nearby.AdvertisingResult();
        }
        internal static GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult FromPointer(IntPtr pointer)
        {
            if((System.IntPtr.op_Equality(value1:  0, value2:  X1)) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult)0;
            }
            
            GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult val_3 = null;
            0 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult(pointer:  X1);
            return (GooglePlayGames.Native.PInvoke.NativeStartAdvertisingResult)0;
        }
        private UIntPtr <LocalEndpointName>m__0(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.StartAdvertisingResult_GetLocalEndpointName(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
    
    }

}
