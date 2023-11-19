using UnityEngine;

namespace TzarGames.Endless.Items.Attributes
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class PlayerClassItemAttribute : ItemAttribute
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClass _class;
        
        // Properties
        public TzarGames.Endless.PlayerClass Class { get; }
        
        // Methods
        public PlayerClassItemAttribute()
        {
        
        }
        public TzarGames.Endless.PlayerClass get_Class()
        {
            return (TzarGames.Endless.PlayerClass)this._class;
        }
    
    }

}
