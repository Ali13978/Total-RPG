using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal abstract class BaseReferenceHolder : IDisposable
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Runtime.InteropServices.HandleRef, GooglePlayGames.Native.PInvoke.BaseReferenceHolder> _refs;
        private System.Runtime.InteropServices.HandleRef mSelfPointer;
        
        // Methods
        public BaseReferenceHolder(IntPtr pointer)
        {
            UnityEngine.Playables.PlayableOutput val_1 = new UnityEngine.Playables.PlayableOutput(handle:  new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = this, m_Version = pointer});
            System.Runtime.InteropServices.HandleRef val_2 = GooglePlayGames.Native.PInvoke.PInvokeUtilities.CheckNonNull(reference:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.m_Handle.m_Handle});
            this.mSelfPointer = val_2;
            mem[1152921512124128424] = val_2.handle;
        }
        protected bool IsDisposed()
        {
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(reference:  new System.Runtime.InteropServices.HandleRef() {handle = this.mSelfPointer});
        }
        protected System.Runtime.InteropServices.HandleRef SelfPtr()
        {
            if(this.IsDisposed() != true)
            {
                    return new System.Runtime.InteropServices.HandleRef() {wrapper = this.mSelfPointer};
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "Attempted to use object after it was cleaned up");
        }
        protected abstract void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer); // 0
        protected override void Finalize()
        {
            var val_7;
            var val_8;
            val_7 = this;
            val_8 = 1;
            this.Dispose(fromFinalizer:  true);
            this.Finalize();
            if((val_8 & 1) != 0)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            val_8 = ???;
        }
        public void Dispose()
        {
            this.Dispose(fromFinalizer:  false);
            System.GC.SuppressFinalize(obj:  0);
        }
        internal IntPtr AsPointer()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (IntPtr);
        }
        private void Dispose(bool fromFinalizer)
        {
            System.Runtime.InteropServices.HandleRef val_6;
            var val_7;
            var val_8;
            System.Collections.Generic.Dictionary<System.Runtime.InteropServices.HandleRef, GooglePlayGames.Native.PInvoke.BaseReferenceHolder> val_9;
            if(fromFinalizer != false)
            {
                    val_6 = this.mSelfPointer;
                val_7 = 1152921512124802648;
            }
            else
            {
                    val_8 = null;
                val_8 = null;
                val_6 = this;
                val_9 = GooglePlayGames.Native.PInvoke.BaseReferenceHolder._refs;
                val_7 = 1152921512124802640;
                if((val_9.ContainsKey(key:  new System.Runtime.InteropServices.HandleRef() {wrapper = this.mSelfPointer, handle = X22})) == true)
            {
                    return;
            }
            
            }
            
            val_9 = new System.Runtime.InteropServices.HandleRef();
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(reference:  new System.Runtime.InteropServices.HandleRef() {handle = val_9})) == true)
            {
                    return;
            }
            
            UnityEngine.Playables.PlayableOutput val_5 = new UnityEngine.Playables.PlayableOutput(handle:  new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = this});
            this.mSelfPointer = val_5.m_Handle.m_Handle;
            mem[1152921512124802648] = val_5.m_Handle.m_Version;
        }
        internal void ReferToMe()
        {
            null = null;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.PInvoke.BaseReferenceHolder._refs.set_Item(key:  new System.Runtime.InteropServices.HandleRef() {wrapper = val_1.wrapper, handle = val_1.handle}, value:  this);
        }
        internal void ForgetMe()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            if((GooglePlayGames.Native.PInvoke.BaseReferenceHolder._refs.ContainsKey(key:  new System.Runtime.InteropServices.HandleRef() {wrapper = val_1.wrapper, handle = val_1.handle})) == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            bool val_4 = GooglePlayGames.Native.PInvoke.BaseReferenceHolder._refs.Remove(key:  new System.Runtime.InteropServices.HandleRef() {wrapper = val_3.wrapper, handle = val_3.handle});
            this.Dispose(fromFinalizer:  false);
        }
        private static BaseReferenceHolder()
        {
            GooglePlayGames.Native.PInvoke.BaseReferenceHolder._refs = new System.Collections.Generic.Dictionary<System.Runtime.InteropServices.HandleRef, GooglePlayGames.Native.PInvoke.BaseReferenceHolder>();
        }
    
    }

}
