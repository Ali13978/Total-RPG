using UnityEngine;

namespace TzarGames.GameFramework.Items.Attributes
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class InventoryBagAttribute : ItemAttribute
    {
        // Fields
        [UnityEngine.SerializeField]
        private string bagName;
        
        // Properties
        public string BagName { get; }
        
        // Methods
        public InventoryBagAttribute()
        {
            val_1 = new TzarGames.Common.Attributes.Attribute();
        }
        public string get_BagName()
        {
            return (string)this.bagName;
        }
    
    }

}
