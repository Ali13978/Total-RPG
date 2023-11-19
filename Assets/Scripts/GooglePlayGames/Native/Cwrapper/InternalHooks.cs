using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class InternalHooks
    {
        // Methods
        internal static extern void InternalHooks_ConfigureForUnityPlugin(System.Runtime.InteropServices.HandleRef builder, string unity_version)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr InternalHooks_GetApiClient(System.Runtime.InteropServices.HandleRef services)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
    
    }

}
