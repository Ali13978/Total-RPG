using UnityEngine;

namespace TzarGames.TzarHero
{
    public abstract class TH_DamageType : IDamageType
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ISurfaceType <SurfaceType>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.ISurfaceType SurfaceType { get; set; }
        
        // Methods
        public TH_DamageType(TzarGames.GameFramework.ISurfaceType surfaceType)
        {
            this.<SurfaceType>k__BackingField = surfaceType;
        }
        public TzarGames.GameFramework.ISurfaceType get_SurfaceType()
        {
            return (TzarGames.GameFramework.ISurfaceType)this.<SurfaceType>k__BackingField;
        }
        public void set_SurfaceType(TzarGames.GameFramework.ISurfaceType value)
        {
            this.<SurfaceType>k__BackingField = value;
        }
    
    }

}
