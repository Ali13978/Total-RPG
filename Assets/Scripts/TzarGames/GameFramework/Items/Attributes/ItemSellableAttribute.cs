using UnityEngine;

namespace TzarGames.GameFramework.Items.Attributes
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class ItemSellableAttribute : ItemAttribute
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool isSellable;
        
        // Properties
        public bool IsSellable { get; }
        
        // Methods
        public ItemSellableAttribute()
        {
            val_1 = new TzarGames.Common.Attributes.Attribute();
        }
        public bool get_IsSellable()
        {
            return (bool)this.isSellable;
        }
    
    }

}
