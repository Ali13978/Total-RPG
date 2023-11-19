using UnityEngine;

namespace TzarGames.TzarHero.DamageTypes
{
    public class DamageType_Magic : TH_DamageType
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.DamageTypes.MagicElemental <Elemental>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.DamageTypes.MagicElemental Elemental { get; set; }
        
        // Methods
        public DamageType_Magic(TzarGames.TzarHero.DamageTypes.MagicElemental elemental, TzarGames.GameFramework.ISurfaceType surfaceType)
        {
            this.<Elemental>k__BackingField = elemental;
        }
        public TzarGames.TzarHero.DamageTypes.MagicElemental get_Elemental()
        {
            return (TzarGames.TzarHero.DamageTypes.MagicElemental)this.<Elemental>k__BackingField;
        }
        private void set_Elemental(TzarGames.TzarHero.DamageTypes.MagicElemental value)
        {
            this.<Elemental>k__BackingField = value;
        }
    
    }

}
