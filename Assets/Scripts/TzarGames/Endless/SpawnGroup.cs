using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class SpawnGroup
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private string name;
        [UnityEngine.SerializeField]
        private float delayBetweenObjects;
        [UnityEngine.SerializeField]
        private uint minimumStage;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ObjectSpawnInfo[] objects;
        
        // Properties
        public uint MinimumStage { get; }
        public string Name { get; }
        public TzarGames.Endless.ObjectSpawnInfo[] Objects { get; }
        public float DelayBetweenObjects { get; }
        
        // Methods
        public SpawnGroup()
        {
        
        }
        public uint get_MinimumStage()
        {
            return (uint)this.minimumStage;
        }
        public string get_Name()
        {
            return (string)this.name;
        }
        public TzarGames.Endless.ObjectSpawnInfo[] get_Objects()
        {
            return (TzarGames.Endless.ObjectSpawnInfo[])this.objects;
        }
        public float get_DelayBetweenObjects()
        {
            return (float)this.delayBetweenObjects;
        }
    
    }

}
