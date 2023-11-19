using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal abstract class PlatformConfiguration : BaseReferenceHolder
    {
        // Methods
        protected PlatformConfiguration(IntPtr selfPointer)
        {
        
        }
        internal System.Runtime.InteropServices.HandleRef AsHandle()
        {
            return this.SelfPtr();
        }
    
    }

}
