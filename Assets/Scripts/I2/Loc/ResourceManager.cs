using UnityEngine;

namespace I2.Loc
{
    public class ResourceManager : MonoBehaviour
    {
        // Fields
        private static I2.Loc.ResourceManager mInstance;
        public System.Collections.Generic.List<I2.Loc.IResourceManager_Bundles> mBundleManagers;
        public UnityEngine.Object[] Assets;
        private readonly System.Collections.Generic.Dictionary<string, UnityEngine.Object> mResourcesCache;
        private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> <>f__mg$cache0;
        
        // Properties
        public static I2.Loc.ResourceManager pInstance { get; }
        
        // Methods
        public ResourceManager()
        {
            this.mBundleManagers = new System.Collections.Generic.List<I2.Loc.IResourceManager_Bundles>();
            this.mResourcesCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Object>(comparer:  System.StringComparer.Ordinal);
        }
        public static I2.Loc.ResourceManager get_pInstance()
        {
            var val_18;
            I2.Loc.ResourceManager val_19;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_20;
            val_18 = UnityEngine.Object.op_Equality(x:  0, y:  I2.Loc.ResourceManager.mInstance);
            if(0 == I2.Loc.ResourceManager.mInstance)
            {
                    System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.Object val_4 = UnityEngine.Object.FindObjectOfType(type:  0);
                val_19 = 0;
                if(val_4 != null)
            {
                    val_19 = val_4;
                val_19 = 0;
            }
            
                I2.Loc.ResourceManager.mInstance = val_19;
            }
            
            if(0 == I2.Loc.ResourceManager.mInstance)
            {
                    typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.GameObject val_9 = null;
                val_20 = val_9;
                val_9 = new UnityEngine.GameObject(name:  "I2ResourceManager", components:  null);
                if(null != 0)
            {
                    hideFlags = hideFlags | 61;
            }
            else
            {
                    0.hideFlags = 0.hideFlags | 61;
            }
            
                I2.Loc.ResourceManager.mInstance = GetComponent<I2.Loc.ResourceManager>();
                if((I2.Loc.ResourceManager.<>f__mg$cache0) == null)
            {
                    UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_15 = null;
                val_20 = val_15;
                val_15 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  0, method:  public static System.Void I2.Loc.ResourceManager::MyOnLevelWasLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
                I2.Loc.ResourceManager.<>f__mg$cache0 = val_20;
            }
            
                UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
            }
            
            if(val_18 == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
            }
            
            val_18 = I2.Loc.ResourceManager.mInstance.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            return (I2.Loc.ResourceManager)I2.Loc.ResourceManager.mInstance;
        }
        public static void MyOnLevelWasLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            I2.Loc.ResourceManager.pInstance.CleanResourceCache();
            bool val_2 = I2.Loc.LocalizationManager.UpdateSources();
        }
        public T GetAsset<T>(string Name)
        {
            UnityEngine.Object val_5;
            UnityEngine.Object val_1 = this.FindAsset(Name:  Name);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(val_5 == null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(0 != val_5)
            {
                    return (object)val_5;
            }
            
            val_5 = this;
            return (object)val_5;
        }
        private UnityEngine.Object FindAsset(string Name)
        {
            UnityEngine.Object[] val_4;
            UnityEngine.Object[] val_5;
            UnityEngine.Object val_6;
            val_4 = this.Assets;
            if((val_4 == null) || (this.Assets.Length < 1))
            {
                    return 0;
            }
            
            var val_5 = 0;
            goto label_3;
            label_15:
            val_5 = this.Assets;
            label_3:
            val_6 = val_5[val_5];
            if(0 == val_6)
            {
                goto label_8;
            }
            
            val_6 = this.Assets[val_5].name;
            if((System.String.op_Equality(a:  0, b:  val_6)) == true)
            {
                goto label_14;
            }
            
            label_8:
            val_5 = val_5 + 1;
            if(val_5 < (long)this.Assets.Length)
            {
                goto label_15;
            }
            
            return 0;
            label_14:
            UnityEngine.Object val_6 = this.Assets[val_5];
            return 0;
        }
        public bool HasAsset(UnityEngine.Object Obj)
        {
            var val_3;
            if(this.Assets != null)
            {
                    var val_2 = ((System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  this.Assets)) >= 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public T LoadFromResources<T>(string Path)
        {
            string val_22;
            UnityEngine.Object val_23;
            UnityEngine.Object val_24;
            var val_25;
            val_22 = Path;
            val_23 = this;
            UnityEngine.Object val_2 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_3;
            }
            
            label_58:
            val_24 = 0;
            return (object)val_24;
            label_3:
            if(((this.mResourcesCache.TryGetValue(key:  val_22, value: out  val_2)) == false) || (0 == val_2))
            {
                goto label_9;
            }
            
            val_23 = mem[__RuntimeMethodHiddenParam + 48];
            val_23 = __RuntimeMethodHiddenParam + 48;
            if(val_2 == 0)
            {
                goto label_58;
            }
            
            val_24 = val_2;
            if(val_24 != 0)
            {
                    return (object)val_24;
            }
            
            goto label_58;
            label_9:
            if((val_22.EndsWith(value:  "]", comparisonType:  5)) == false)
            {
                goto label_14;
            }
            
            int val_7 = val_22.LastIndexOf(value:  "[", comparisonType:  5);
            var val_24 = -2;
            val_24 = val_24 - val_7;
            val_22 = val_22.Substring(startIndex:  0, length:  val_7);
            if(7254272 < 1)
            {
                goto label_31;
            }
            
            var val_13 = 0 + 32;
            label_27:
            if(((0 + 32) + 0.name.Equals(value:  val_22.Substring(startIndex:  val_7 + 1, length:  val_24 + val_22.Length))) == true)
            {
                goto label_26;
            }
            
            val_25 = 0 + 1;
            if(val_25 < 7254272)
            {
                goto label_27;
            }
            
            goto label_31;
            label_14:
            System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_25 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  val_22);
            if(val_25 == null)
            {
                goto label_31;
            }
            
            val_24 = val_25;
            if(val_24 != null)
            {
                goto label_61;
            }
            
            label_31:
            val_24 = 0;
            label_61:
            if(0 == val_24)
            {
                    val_24 = val_23;
            }
            
            if(0 == this)
            {
                    return (object)val_24;
            }
            
            this.mResourcesCache.set_Item(key:  val_22, value:  this);
            return (object)val_24;
            label_26:
            var val_23 = 0 + 32;
            goto label_61;
        }
        public T LoadFromBundle<T>(string path)
        {
            var val_9;
            var val_10;
            UnityEngine.Object val_11;
            int val_1 = this.mBundleManagers.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_9 = 0;
            label_18:
            if(this.mBundleManagers.Item[0] == null)
            {
                goto label_4;
            }
            
            I2.Loc.IResourceManager_Bundles val_3 = this.mBundleManagers.Item[0];
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_10 = val_3;
            if(val_3 == null)
            {
                goto label_13;
            }
            
            val_11 = val_3;
            if(val_11 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_11 = 0;
            label_14:
            if(0 != val_11)
            {
                    return (object)val_11;
            }
            
            label_4:
            val_9 = val_9 + 1;
            if(val_9 < val_1)
            {
                goto label_18;
            }
            
            label_2:
            val_11 = 0;
            return (object)val_11;
        }
        public void CleanResourceCache()
        {
            this.mResourcesCache.Clear();
            UnityEngine.AsyncOperation val_1 = UnityEngine.Resources.UnloadUnusedAssets();
            this.CancelInvoke();
        }
    
    }

}
