using UnityEngine;

namespace TzarGames.GameFramework
{
    public class PoolableGroup : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private int initialCount;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject[] prefabs;
        
        // Properties
        public UnityEngine.GameObject[] Prefabs { get; }
        public int InitialCount { get; }
        
        // Methods
        public PoolableGroup()
        {
            this.initialCount = 10;
        }
        public UnityEngine.GameObject[] get_Prefabs()
        {
            return (UnityEngine.GameObject[])this.prefabs;
        }
        public int get_InitialCount()
        {
            return (int)this.initialCount;
        }
    
    }

}
