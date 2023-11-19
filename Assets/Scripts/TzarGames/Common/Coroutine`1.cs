using UnityEngine;

namespace TzarGames.Common
{
    public class Coroutine<T>
    {
        // Fields
        private T returnVal;
        private System.Exception e;
        public UnityEngine.Coroutine coroutine;
        
        // Properties
        public T Value { get; }
        
        // Methods
        public Coroutine<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public T get_Value()
        {
            if(6178 == 0)
            {
                    return 6178;
            }
        
        }
        public bool HasException()
        {
            return (bool)(X8 != 0) ? 1 : 0;
        }
        public System.Exception GetException()
        {
            return (System.Exception)this;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator InternalRoutine(System.Collections.IEnumerator coroutine)
        {
            if((__RuntimeMethodHiddenParam + 24 + 168) != 0)
            {
                    mem2[0] = coroutine;
            }
            else
            {
                    mem[16] = coroutine;
            }
            
            mem2[0] = this;
            return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 24 + 168;
        }
        public static TzarGames.Common.Coroutine<T> StartCoroutine(UnityEngine.MonoBehaviour obj, System.Collections.IEnumerator coroutine)
        {
            mem2[0] = coroutine.StartCoroutine(routine:  X3 + 24 + 168 + 16);
            return (TzarGames.Common.Coroutine<T>)X3 + 24 + 168 + 16;
        }
    
    }

}
