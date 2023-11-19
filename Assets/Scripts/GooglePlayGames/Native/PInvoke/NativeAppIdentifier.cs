using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeAppIdentifier : BaseReferenceHolder
    {
        // Methods
        internal NativeAppIdentifier(IntPtr pointer)
        {
        
        }
        internal static extern IntPtr NearbyUtils_ConstructAppIdentifier(string appId)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X1;
            }
        
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeAppIdentifier::<Id>m__0(byte[] out_arg, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.AppIdentifier_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.NativeAppIdentifier FromString(string appId)
        {
            return (GooglePlayGames.Native.PInvoke.NativeAppIdentifier)new GooglePlayGames.Native.PInvoke.NativeAppIdentifier(pointer:  GooglePlayGames.Native.PInvoke.NativeAppIdentifier.NearbyUtils_ConstructAppIdentifier(appId:  16921));
        }
        private UIntPtr <Id>m__0(byte[] out_arg, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.NearbyConnectionTypes.AppIdentifier_GetIdentifier(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_arg);
        }
    
    }

}
