using UnityEngine;

namespace TzarGames.GameFramework.Items.Attributes
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class ItemColorAttribute : ItemAttribute
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Color _color;
        
        // Properties
        public UnityEngine.Color Color { get; }
        
        // Methods
        public ItemColorAttribute()
        {
            val_1 = new TzarGames.Common.Attributes.Attribute();
        }
        public UnityEngine.Color get_Color()
        {
            return new UnityEngine.Color() {r = this._color};
        }
    
    }

}
