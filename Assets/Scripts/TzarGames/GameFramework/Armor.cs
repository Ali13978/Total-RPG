using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Armor : Item
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator defence;
        [UnityEngine.SerializeField]
        private string surfaceTypeName;
        
        // Properties
        public string SurfaceTypeName { get; }
        public float Defence { get; }
        public TzarGames.GameFramework.CharacteristicModificator DefenceModificator { get; }
        
        // Methods
        public Armor()
        {
            this.surfaceTypeName = "Metal";
        }
        public string get_SurfaceTypeName()
        {
            return (string)this.surfaceTypeName;
        }
        public float get_Defence()
        {
            if(this.defence != null)
            {
                    return this.defence.Value;
            }
            
            return this.defence.Value;
        }
        public TzarGames.GameFramework.CharacteristicModificator get_DefenceModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.defence;
        }
    
    }

}
