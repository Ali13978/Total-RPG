using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ItemInstanceManager : MonoBehaviour
    {
        // Fields
        private static TzarGames.GameFramework.ItemInstanceManager managerInstance;
        private const string managerObjectName = "bc173-5fbf-46bf-a9b7-dda8372398c6";
        
        // Properties
        public static TzarGames.GameFramework.ItemInstanceManager Get { get; }
        
        // Methods
        protected ItemInstanceManager()
        {
        
        }
        public static TzarGames.GameFramework.ItemInstanceManager get_Get()
        {
            null = null;
            return (TzarGames.GameFramework.ItemInstanceManager)TzarGames.GameFramework.ItemInstanceManager.managerObjectName;
        }
        public static void Initialize()
        {
            null = null;
            if(0 != TzarGames.GameFramework.ItemInstanceManager.managerObjectName)
            {
                    return;
            }
            
            TzarGames.GameFramework.ItemInstanceManager.managerObjectName = TzarGames.GameFramework.ItemInstanceManager.createInstance();
        }
        private static TzarGames.GameFramework.ItemInstanceManager createInstance()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "bc173-5fbf-46bf-a9b7-dda8372398c6");
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            if(null != 0)
            {
                    hideFlags = 1;
                return AddComponent<TzarGames.GameFramework.ItemInstanceManager>();
            }
            
            hideFlags = 1;
            return AddComponent<TzarGames.GameFramework.ItemInstanceManager>();
        }
        public static void RemoveInstance(TzarGames.GameFramework.Item item)
        {
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void Update()
        {
            var val_16;
            object val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_16 = null;
            val_16 = null;
            val_17 = TzarGames.GameFramework.ItemInstance.locker;
            System.Threading.Monitor.Enter(obj:  0);
            val_18 = null;
            val_18 = null;
            val_19 = 1152921510747401040;
            if(TzarGames.GameFramework.ItemInstance.InstancesToRemove.Count < 1)
            {
                goto label_10;
            }
            
            val_20 = null;
            val_20 = null;
            System.Collections.Generic.List<TzarGames.GameFramework.Item> val_16 = TzarGames.GameFramework.ItemInstance.InstancesToRemove;
            val_21 = 1152921510747402064;
            val_22 = 1152921511359104016;
            val_16 = val_16.Count - 1;
            label_22:
            if((val_16 & 2147483648) != 0)
            {
                goto label_10;
            }
            
            val_23 = null;
            val_23 = null;
            if(0 != TzarGames.GameFramework.ItemInstance.InstancesToRemove.Item[val_16])
            {
                    UnityEngine.Object.Destroy(obj:  0);
            }
            
            val_24 = null;
            val_24 = null;
            int val_5 = val_16 - 1;
            TzarGames.GameFramework.ItemInstance.InstancesToRemove.RemoveAt(index:  val_16);
            goto label_22;
            label_10:
            System.Threading.Monitor.Exit(obj:  0);
        }
        private static ItemInstanceManager()
        {
        
        }
    
    }

}
