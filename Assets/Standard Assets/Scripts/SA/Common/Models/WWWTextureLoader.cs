using UnityEngine;

namespace SA.Common.Models
{
    public class WWWTextureLoader : MonoBehaviour
    {
        // Fields
        public static System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> LocalCache;
        private string _url;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.Texture2D> OnLoad;
        private static System.Action<UnityEngine.Texture2D> <>f__am$cache0;
        
        // Methods
        public WWWTextureLoader()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((SA.Common.Models.WWWTextureLoader.<>f__am$cache0) == null)
            {
                    val_3 = null;
                val_3 = null;
                SA.Common.Models.WWWTextureLoader.<>f__am$cache0 = new System.Action<UnityEngine.Texture2D>(object:  0, method:  static System.Void SA.Common.Models.WWWTextureLoader::<OnLoad>m__0(UnityEngine.Texture2D ));
                val_2 = null;
            }
            
            val_2 = null;
            this.OnLoad = SA.Common.Models.WWWTextureLoader.<>f__am$cache0;
        }
        public void add_OnLoad(System.Action<UnityEngine.Texture2D> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnLoad);
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
            while(1152921510490096832 != this.OnLoad);
        
        }
        public void remove_OnLoad(System.Action<UnityEngine.Texture2D> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnLoad);
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
            while(1152921510490233408 != this.OnLoad);
        
        }
        public static SA.Common.Models.WWWTextureLoader Create()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "WWWTextureLoader");
            if(null != 0)
            {
                    return AddComponent<SA.Common.Models.WWWTextureLoader>();
            }
            
            return AddComponent<SA.Common.Models.WWWTextureLoader>();
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void LoadTexture(string url)
        {
            string val_6;
            var val_7;
            var val_8;
            val_6 = url;
            this._url = val_6;
            val_7 = null;
            val_7 = null;
            val_6 = this._url;
            if((SA.Common.Models.WWWTextureLoader.LocalCache.ContainsKey(key:  val_6)) != false)
            {
                    val_8 = null;
                val_8 = null;
                this.OnLoad.Invoke(obj:  SA.Common.Models.WWWTextureLoader.LocalCache.Item[this._url]);
                UnityEngine.GameObject val_3 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.LoadCoroutin());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator LoadCoroutin()
        {
            typeof(WWWTextureLoader.<LoadCoroutin>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void UpdateLocalCache(string url, UnityEngine.Texture2D image)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((SA.Common.Models.WWWTextureLoader.LocalCache.ContainsKey(key:  image)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            SA.Common.Models.WWWTextureLoader.LocalCache.Add(key:  image, value:  X2);
        }
        private static WWWTextureLoader()
        {
            SA.Common.Models.WWWTextureLoader.LocalCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>();
        }
        private static void <OnLoad>m__0(UnityEngine.Texture2D )
        {
        
        }
    
    }

}
