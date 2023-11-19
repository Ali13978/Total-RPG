using UnityEngine;

namespace TzarGames.TzarHero
{
    [Serializable]
    public class CharacterDamageInfo : DamageInfoBase, ICharacterDamageInfo, IDamageInfo
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <CriticalDamage>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsCritical>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IgnoreDefence>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsAuthoritative>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Instigator>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Victim>k__BackingField;
        
        // Properties
        public float CriticalDamage { get; set; }
        public bool IsCritical { get; set; }
        public bool IgnoreDefence { get; set; }
        public bool IsAuthoritative { get; set; }
        public TzarGames.TzarHero.TH_Character Instigator { get; set; }
        public TzarGames.TzarHero.TH_Character Victim { get; set; }
        
        // Methods
        public CharacterDamageInfo(float damage, UnityEngine.Vector3 force, TzarGames.GameFramework.IDamageType damageType, TzarGames.TzarHero.TH_Character instigator, TzarGames.TzarHero.TH_Character victim, bool isAuthoritative, TzarGames.GameFramework.IHit hitInfo)
        {
            this.<Instigator>k__BackingField = instigator;
            this.<Victim>k__BackingField = victim;
            this.<IsAuthoritative>k__BackingField = isAuthoritative;
        }
        public float get_CriticalDamage()
        {
            return (float)this.<CriticalDamage>k__BackingField;
        }
        public void set_CriticalDamage(float value)
        {
            this.<CriticalDamage>k__BackingField = value;
        }
        public bool get_IsCritical()
        {
            return (bool)this.<IsCritical>k__BackingField;
        }
        public void set_IsCritical(bool value)
        {
            this.<IsCritical>k__BackingField = value;
        }
        public bool get_IgnoreDefence()
        {
            return (bool)this.<IgnoreDefence>k__BackingField;
        }
        public void set_IgnoreDefence(bool value)
        {
            this.<IgnoreDefence>k__BackingField = value;
        }
        public bool get_IsAuthoritative()
        {
            return (bool)this.<IsAuthoritative>k__BackingField;
        }
        private void set_IsAuthoritative(bool value)
        {
            this.<IsAuthoritative>k__BackingField = value;
        }
        public TzarGames.TzarHero.TH_Character get_Instigator()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Instigator>k__BackingField;
        }
        private void set_Instigator(TzarGames.TzarHero.TH_Character value)
        {
            this.<Instigator>k__BackingField = value;
        }
        public TzarGames.TzarHero.TH_Character get_Victim()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Victim>k__BackingField;
        }
        private void set_Victim(TzarGames.TzarHero.TH_Character value)
        {
            this.<Victim>k__BackingField = value;
        }
    
    }

}
