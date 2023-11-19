using UnityEngine;

namespace AssetBundles
{
    public abstract class AssetBundleLoadOperation : IEnumerator
    {
        // Properties
        public object Current { get; }
        
        // Methods
        protected AssetBundleLoadOperation()
        {
        
        }
        public object get_Current()
        {
            return 0;
        }
        public bool MoveNext()
        {
            return false;
        }
        public void Reset()
        {
        
        }
        public abstract bool Update(); // 0
        public abstract bool IsDone(); // 0
        public virtual void Clean()
        {
        
        }
        public abstract bool HasError(); // 0
        public abstract string GetLastError(); // 0
        public virtual float GetProgress()
        {
            return 0f;
        }
    
    }

}
