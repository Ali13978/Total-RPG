using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class NonConsumableItemInstanceSerializationInfo
    {
        // Fields
        public int ItemID;
        public string InstanceID;
        public uint Level;
        public bool Activated;
        public TzarGames.Common.SerializableData Data;
        
        // Methods
        public NonConsumableItemInstanceSerializationInfo()
        {
        
        }
    
    }

}
