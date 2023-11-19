using UnityEngine;

namespace TzarGames.Endless
{
    public class TrailFxInfo : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Color color;
        
        // Properties
        public UnityEngine.Color Color { get; }
        
        // Methods
        public TrailFxInfo()
        {
        
        }
        public UnityEngine.Color get_Color()
        {
            return new UnityEngine.Color() {r = this.color};
        }
    
    }

}
