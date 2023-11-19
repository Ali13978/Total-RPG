using UnityEngine;

namespace TzarGames.Endless.Items
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class ArmorSet : Armor
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Items.ArmorSetPrefab armorSetPrefab;
        
        // Properties
        public TzarGames.Endless.Items.ArmorSetPrefab ArmorSetPrefab { get; }
        
        // Methods
        public ArmorSet()
        {
        
        }
        public TzarGames.Endless.Items.ArmorSetPrefab get_ArmorSetPrefab()
        {
            return (TzarGames.Endless.Items.ArmorSetPrefab)this.armorSetPrefab;
        }
    
    }

}
