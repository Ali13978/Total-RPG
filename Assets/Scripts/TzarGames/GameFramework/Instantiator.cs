using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Instantiator : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Instantiator.PrefabInfo[] prefabs;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.PoolableGroup[] prefabGroups;
        private System.Collections.Generic.List<TzarGames.GameFramework.Instantiator.PrefabInfo> prefabList;
        [UnityEngine.SerializeField]
        private bool dontDestroyOnLoad;
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, TzarGames.Common.InstancePool<UnityEngine.GameObject>> instancePools;
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, TzarGames.GameFramework.Instantiator.InstanceInfo> instanceInfos;
        private System.Collections.Generic.List<UnityEngine.GameObject> instantiatedObjects;
        private static TzarGames.GameFramework.Instantiator instance;
        private UnityEngine.SceneManagement.Scene activeScene;
        private static TzarGames.Common.InstancePool.CreateInstanceDeleagate<UnityEngine.GameObject> <>f__mg$cache0;
        
        // Methods
        public Instantiator()
        {
            this.dontDestroyOnLoad = true;
            this.prefabList = new System.Collections.Generic.List<PrefabInfo>();
            this.instancePools = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, TzarGames.Common.InstancePool<UnityEngine.GameObject>>();
            this.instanceInfos = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, InstanceInfo>();
            this.instantiatedObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
        private void Awake()
        {
            var val_12;
            var val_19;
            UnityEngine.Object val_32;
            var val_33;
            var val_34;
            TzarGames.GameFramework.PoolableGroup[] val_35;
            var val_36;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            string val_42;
            var val_43;
            val_32 = 1152921504909668352;
            if(0 != TzarGames.GameFramework.Instantiator.instance)
            {
                    UnityEngine.Debug.LogError(message:  0);
                val_33 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            TzarGames.GameFramework.Instantiator.instance = this;
            UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            this.activeScene = val_3;
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_4 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  this, method:  System.Void TzarGames.GameFramework.Instantiator::SceneManager_SceneUnloaded(UnityEngine.SceneManagement.Scene scene));
            UnityEngine.SceneManagement.SceneManager.add_sceneUnloaded(value:  0);
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TzarGames.GameFramework.Instantiator::SceneManager_SceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
            if(this.dontDestroyOnLoad != false)
            {
                    UnityEngine.Transform val_9 = this.transform;
                if(0 == this.gameObject.transform.root)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  0);
            }
            
            }
            
            val_34 = 0;
            goto label_17;
            label_22:
            val_9.Add(item:  val_9.gameObject);
            val_34 = 1;
            label_17:
            if(val_34 >= this.prefabs.Length)
            {
                goto label_19;
            }
            
            PrefabInfo val_32 = this.prefabs[1];
            if(this.prefabList != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_19:
            val_35 = this.prefabGroups;
            val_32 = 0;
            goto label_23;
            label_30:
            val_35 = val_35;
            val_32 = val_12 + 1;
            label_23:
            if(val_32 >= (this.prefabGroups + 24))
            {
                goto label_25;
            }
            
            TzarGames.GameFramework.PoolableGroup[] val_13 = val_35 + (((long)(int)((val_12 + 1))) << 3);
            val_12 = val_32;
            val_36 = 0;
            goto label_28;
            label_36:
            val_34.Add(item:  this.prefabs);
            val_36 = 1;
            label_28:
            if(val_36 >= val_14.Length)
            {
                goto label_30;
            }
            
            null = new System.Object();
            int val_16 = (this.prefabGroups + ((long)(int)((val_12 + 1))) << 3) + 32.InitialCount;
            if(null != 0)
            {
                    typeof(Instantiator.PrefabInfo).__il2cppRuntimeField_18 = val_16;
            }
            else
            {
                    mem[24] = val_16;
            }
            
            typeof(Instantiator.PrefabInfo).__il2cppRuntimeField_10 = (this.prefabGroups + ((long)(int)((val_12 + 1))) << 3) + 32.Prefabs[1];
            if(this.prefabList != null)
            {
                goto label_36;
            }
            
            goto label_36;
            label_25:
            List.Enumerator<T> val_17 = this.prefabList.GetEnumerator();
            val_12 = 0;
            label_76:
            label_51:
            if((0 & 1) == 0)
            {
                goto label_38;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_20 = val_19.InitializationCallback;
            if(val_20 != null)
            {
                    if(0 != val_32)
            {
                goto label_42;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  0);
            goto label_51;
            label_42:
            if((this.instancePools.ContainsKey(key:  this.prefabs)) == true)
            {
                goto label_47;
            }
            
            if((TzarGames.GameFramework.Instantiator.<>f__mg$cache0) == null)
            {
                    InstancePool.CreateInstanceDeleagate<UnityEngine.GameObject> val_23 = new InstancePool.CreateInstanceDeleagate<UnityEngine.GameObject>(object:  0, method:  static UnityEngine.GameObject TzarGames.GameFramework.Instantiator::createObjectHandler(UnityEngine.GameObject original));
                TzarGames.GameFramework.Instantiator.<>f__mg$cache0 = null;
            }
            
            TzarGames.Common.InstancePool<UnityEngine.GameObject> val_24 = new TzarGames.Common.InstancePool<UnityEngine.GameObject>(original:  this.prefabs, createObjectCallback:  TzarGames.GameFramework.Instantiator.<>f__mg$cache0, maxCount:  2147483647);
            this.instancePools.Add(key:  TzarGames.GameFramework.Instantiator.<>f__mg$cache0, value:  null);
            CreateObjects(count:  val_20);
            goto label_51;
            label_47:
            val_38 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Already contains key ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_20;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
            bool val_25 = UnityEngine.Object.op_Equality(x:  0, y:  this.prefabs);
            val_12 = (val_25 != true) ? (val_12) : (val_38);
            if(val_25 != false)
            {
                    val_39 = null;
                val_39 = null;
                val_40 = 3;
                val_41 = val_38;
                val_42 = System.String.Empty;
            }
            else
            {
                    val_42 = val_20.name;
                val_41 = (val_25 != true) ? 0 : (val_38);
                val_38 = val_12;
                val_40 = (val_25 != true) ? 0 : 3;
            }
            
            var val_30 = val_41 + (((long)(int)(val_25 != true ? 0 : 3)) << 3);
            mem2[0] = val_42;
            string val_31 = +0;
            UnityEngine.Debug.LogWarning(message:  0);
            goto label_76;
            label_38:
            val_33 = 0;
            val_43 = 1;
            val_19.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private static UnityEngine.GameObject createObjectHandler(UnityEngine.GameObject original)
        {
            var val_7;
            T[] val_8;
            Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            if(TzarGames.GameFramework.Instantiator.instance.dontDestroyOnLoad != false)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  0);
            }
            
            object val_2 = new System.Object();
            T[] val_3 = val_1.GetComponentsInChildren<TzarGames.GameFramework.IPoolable>();
            if(null != 0)
            {
                    val_7 = val_2;
                typeof(Instantiator.InstanceInfo).__il2cppRuntimeField_18 = val_3;
            }
            else
            {
                    val_7 = 24;
                mem[24] = val_3;
            }
            
            if(val_7 == 0)
            {
                goto label_14;
            }
            
            if(null == 0)
            {
                    val_8 = mem[24];
            }
            
            val_7 = 0;
            goto label_12;
            label_21:
            val_7 = 1;
            label_12:
            if(val_7 >= (val_3 + 24))
            {
                goto label_14;
            }
            
            T[] val_4 = val_8 + 8;
            var val_9 = (val_3 + 8) + 32;
            if(((val_3 + 8) + 32 + 258) == 0)
            {
                goto label_21;
            }
            
            var val_7 = (val_3 + 8) + 32 + 152;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_19:
            if((((val_3 + 8) + 32 + 152 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < ((val_3 + 8) + 32 + 258))
            {
                goto label_19;
            }
            
            goto label_21;
            label_18:
            val_9 = val_9 + ((((val_3 + 8) + 32 + 152 + 8)) << 4);
            var val_5 = val_9 + 272;
            goto label_21;
            label_14:
            typeof(Instantiator.InstanceInfo).__il2cppRuntimeField_10 = Item[X1];
            Add(key:  val_1, value:  val_2);
            return (UnityEngine.GameObject)val_1;
        }
        private void SceneManager_SceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1)
        {
            this.activeScene = arg0;
        }
        public static void CleanupPoolableObjects()
        {
            var val_8;
            var val_13;
            TzarGames.GameFramework.Instantiator val_14;
            UnityEngine.Object val_15;
            var val_16;
            val_13 = 1152921504909668352;
            val_14 = TzarGames.GameFramework.Instantiator.instance;
            if(0 == val_14)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            val_14 = mem[TzarGames.GameFramework.Instantiator.instance + 72];
            val_14 = TzarGames.GameFramework.Instantiator.instance.instantiatedObjects;
            int val_3 = Count - 1;
            if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
            label_32:
            UnityEngine.GameObject val_4 = Item[val_3];
            val_15 = 0;
            if(val_15 != val_4)
            {
                goto label_13;
            }
            
            InstanceInfo val_6 = Item[val_4];
            Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
            label_20:
            if((0 & 1) == 0)
            {
                goto label_18;
            }
            
            UnityEngine.Playables.PlayableHandle val_10 = val_8.GetHandle();
            if( != val_6.Pool)
            {
                goto label_20;
            }
            
            val_16 = val_10.m_Handle.InitializationCallback;
            goto label_21;
            label_18:
            val_16 = 0;
            label_21:
            val_8.Dispose();
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_16.name;
            val_15 = 0;
            UnityEngine.Debug.LogErrorFormat(format:  val_15, args:  "Null poolable instance found {0}");
            val_13 = 1152921504909668352;
            label_13:
            TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  val_15);
            val_3 = val_3 - 1;
            if((val_3 & 2147483648) == 0)
            {
                goto label_32;
            }
        
        }
        private void SceneManager_SceneUnloaded(UnityEngine.SceneManagement.Scene scene)
        {
            int val_6 = scene.m_Handle;
            int val_1 = val_6 & 4294967295;
            if((UnityEngine.SceneManagement.Scene.op_Inequality(lhs:  new UnityEngine.SceneManagement.Scene(), rhs:  new UnityEngine.SceneManagement.Scene() {m_Handle = this.activeScene})) == true)
            {
                    return;
            }
            
            string val_4 = val_6.name;
            val_6 = 0 + "Cleaning all poolable objects in scene ";
            UnityEngine.Debug.Log(message:  0);
            TzarGames.GameFramework.Instantiator.CleanupPoolableObjects();
        }
        private void OnDestroy()
        {
            if(0 == TzarGames.GameFramework.Instantiator.instance)
            {
                    TzarGames.GameFramework.Instantiator.instance = 0;
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  this, method:  System.Void TzarGames.GameFramework.Instantiator::SceneManager_SceneUnloaded(UnityEngine.SceneManagement.Scene scene));
            UnityEngine.SceneManagement.SceneManager.remove_sceneUnloaded(value:  0);
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TzarGames.GameFramework.Instantiator::SceneManager_SceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1));
            UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  0);
        }
        public static UnityEngine.GameObject InstantiateFromPool(UnityEngine.GameObject originalObject, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
        {
            UnityEngine.Object val_17;
            object val_18;
            var val_19;
            val_17 = X2;
            if(0 != TzarGames.GameFramework.Instantiator.instance)
            {
                goto label_3;
            }
            
            val_18 = 0;
            goto label_6;
            label_3:
            if((TryGetValue(key:  parent, value: out  0)) == false)
            {
                goto label_9;
            }
            
            UnityEngine.GameObject val_4 = val_2.Get();
            if(0 != val_4)
            {
                goto label_13;
            }
            
            val_17 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = parent;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Failed to get instance from pool for object: {0}");
            return 0;
            label_9:
            string val_6 = parent.name;
            val_17 = 0 + "No pool found for prefab: "("No pool found for prefab: ");
            val_18 = 0;
            label_6:
            UnityEngine.Debug.LogError(message:  val_18);
            return 0;
            label_13:
            val_4.transform.SetPositionAndRotation(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
            if((((TryGetValue(key:  val_4, value: out  0)) == false) || (7254272 == 0)) || ((-2012873628) < 1))
            {
                goto label_35;
            }
            
            var val_21 = 0;
            label_44:
            var val_11 = 7254272 + 0;
            var val_20 = (7254272 + 0) + 32;
            if(((7254272 + 0) + 32 + 258) == 0)
            {
                goto label_40;
            }
            
            var val_17 = (7254272 + 0) + 32 + 152;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_42:
            if((((7254272 + 0) + 32 + 152 + 8) + -8) == null)
            {
                goto label_41;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < ((7254272 + 0) + 32 + 258))
            {
                goto label_42;
            }
            
            label_40:
            val_19 = (7254272 + 0) + 32;
            goto label_43;
            label_41:
            var val_19 = val_17;
            val_19 = val_19 + 1;
            val_20 = val_20 + val_19;
            val_19 = val_20 + 272;
            label_43:
            val_21 = val_21 + 1;
            if(val_21 != (-2012873628))
            {
                goto label_44;
            }
            
            label_35:
            if(val_4.activeSelf != true)
            {
                    if(parent.activeSelf != false)
            {
                    val_4.SetActive(value:  true);
            }
            
            }
            
            if(0 != val_17)
            {
                    val_4.transform.SetParent(parent:  val_17);
            }
            
            Add(item:  val_4);
            return 0;
        }
        public static bool IsPoolableInstance(UnityEngine.GameObject instanceObject)
        {
            if(0 == TzarGames.GameFramework.Instantiator.instance)
            {
                    return false;
            }
            
            if(null != 0)
            {
                    return ContainsKey(key:  X1);
            }
            
            return ContainsKey(key:  X1);
        }
        public static bool IsPoolablePrefab(UnityEngine.GameObject prefab)
        {
            var val_7;
            var val_8;
            val_7 = 1152921504909668352;
            if(0 == TzarGames.GameFramework.Instantiator.instance)
            {
                goto label_6;
            }
            
            val_7 = Count;
            if(val_7 < 1)
            {
                goto label_6;
            }
            
            var val_7 = 0;
            label_12:
            PrefabInfo val_4 = Item[0];
            if(0 == val_4.Prefab)
            {
                goto label_11;
            }
            
            val_7 = val_7 + 1;
            if(val_7 < val_7)
            {
                goto label_12;
            }
            
            label_6:
            val_8 = 0;
            return (bool)val_8;
            label_11:
            val_8 = 1;
            return (bool)val_8;
        }
        public static void PushToPool(UnityEngine.GameObject instanceObject)
        {
            UnityEngine.GameObject val_12;
            UnityEngine.Object val_13;
            var val_14;
            val_12 = X1;
            val_13 = 1152921504909668352;
            if((Contains(item:  val_12)) == false)
            {
                    return;
            }
            
            if((TryGetValue(key:  val_12, value: out  0)) == false)
            {
                goto label_6;
            }
            
            bool val_4 = 11993091.Set(pooledObject:  val_12);
            bool val_5 = Remove(item:  val_12);
            if((7254272 == 0) || ((-2012873628) < 1))
            {
                goto label_15;
            }
            
            var val_15 = 0;
            label_24:
            var val_6 = 7254272 + 0;
            var val_14 = (7254272 + 0) + 32;
            if(((7254272 + 0) + 32 + 258) == 0)
            {
                goto label_20;
            }
            
            var val_12 = (7254272 + 0) + 32 + 152;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_22:
            if((((7254272 + 0) + 32 + 152 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < ((7254272 + 0) + 32 + 258))
            {
                goto label_22;
            }
            
            label_20:
            val_14 = (7254272 + 0) + 32;
            goto label_23;
            label_21:
            val_14 = val_14 + ((((7254272 + 0) + 32 + 152 + 8)) << 4);
            val_14 = val_14 + 272;
            label_23:
            val_15 = val_15 + 1;
            if(val_15 != (-2012873628))
            {
                goto label_24;
            }
            
            label_15:
            UnityEngine.Transform val_7 = val_12.transform;
            val_13 = val_7.parent;
            if(0 != val_13)
            {
                    val_7.SetParent(parent:  0);
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            return;
            label_6:
            string val_10 = val_12.name;
            val_12 = 0 + "No pool found for object: "("No pool found for object: ");
            UnityEngine.Debug.LogError(message:  0);
        }
    
    }

}
