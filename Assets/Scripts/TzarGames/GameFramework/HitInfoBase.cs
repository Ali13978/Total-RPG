using UnityEngine;

namespace TzarGames.GameFramework
{
    public class HitInfoBase : IDamageHit
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IDamageInfo <DamageInfo>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ISurfaceType <HitSurfaceType>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.IDamageInfo DamageInfo { get; set; }
        public TzarGames.GameFramework.ISurfaceType HitSurfaceType { get; set; }
        
        // Methods
        public HitInfoBase(TzarGames.GameFramework.IDamageInfo damageInfo, TzarGames.GameFramework.ISurfaceType hitSurfType)
        {
            this.<DamageInfo>k__BackingField = damageInfo;
            this.<HitSurfaceType>k__BackingField = hitSurfType;
        }
        public TzarGames.GameFramework.IDamageInfo get_DamageInfo()
        {
            return (TzarGames.GameFramework.IDamageInfo)this.<DamageInfo>k__BackingField;
        }
        public void set_DamageInfo(TzarGames.GameFramework.IDamageInfo value)
        {
            this.<DamageInfo>k__BackingField = value;
        }
        public TzarGames.GameFramework.ISurfaceType get_HitSurfaceType()
        {
            return (TzarGames.GameFramework.ISurfaceType)this.<HitSurfaceType>k__BackingField;
        }
        public void set_HitSurfaceType(TzarGames.GameFramework.ISurfaceType value)
        {
            this.<HitSurfaceType>k__BackingField = value;
        }
    
    }

}
