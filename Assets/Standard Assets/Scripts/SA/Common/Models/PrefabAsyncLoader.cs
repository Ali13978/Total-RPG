using UnityEngine;

namespace SA.Common.Models
{
    public class PrefabAsyncLoader : MonoBehaviour
    {
        // Fields
        private string PrefabPath;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.GameObject> ObjectLoadedAction;
        private static System.Action<UnityEngine.GameObject> <>f__am$cache0;
        
        // Methods
        public PrefabAsyncLoader()
        {
            if((SA.Common.Models.PrefabAsyncLoader.<>f__am$cache0) == null)
            {
                    SA.Common.Models.PrefabAsyncLoader.<>f__am$cache0 = new System.Action<UnityEngine.GameObject>(object:  0, method:  static System.Void SA.Common.Models.PrefabAsyncLoader::<ObjectLoadedAction>m__0(UnityEngine.GameObject ));
                null = null;
            }
            
            this.ObjectLoadedAction = SA.Common.Models.PrefabAsyncLoader.<>f__am$cache0;
        }
        public void add_ObjectLoadedAction(System.Action<UnityEngine.GameObject> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ObjectLoadedAction);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510486118240 != this.ObjectLoadedAction);
        
        }
        public void remove_ObjectLoadedAction(System.Action<UnityEngine.GameObject> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ObjectLoadedAction);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510486254816 != this.ObjectLoadedAction);
        
        }
        public static SA.Common.Models.PrefabAsyncLoader Create()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "PrefabAsyncLoader");
            if(null != 0)
            {
                    return AddComponent<SA.Common.Models.PrefabAsyncLoader>();
            }
            
            return AddComponent<SA.Common.Models.PrefabAsyncLoader>();
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void LoadAsync(string name)
        {
            this.PrefabPath = name;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.Load());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Load()
        {
            typeof(PrefabAsyncLoader.<Load>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void <ObjectLoadedAction>m__0(UnityEngine.GameObject )
        {
        
        }
    
    }

}
