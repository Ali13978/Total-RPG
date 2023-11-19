using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class LanguageData
    {
        // Fields
        public string Name;
        public string Code;
        public byte Flags;
        public bool Compressed;
        
        // Methods
        public LanguageData()
        {
        
        }
        public bool IsEnabled()
        {
            return (bool)((this.Flags & 1) != 0) ? 1 : 0;
        }
        public void SetEnabled(bool bEnabled)
        {
            byte val_3 = this.Flags;
            val_3 = val_3 & 254;
            this.Flags = (bEnabled != true) ? (val_3) : (val_3 | 1);
        }
        public bool IsLoaded()
        {
            return (bool)((this.Flags & 4) != 0) ? 1 : 0;
        }
        public bool CanBeUnloaded()
        {
            return (bool)((this.Flags & 2) != 0) ? 1 : 0;
        }
        public void SetLoaded(bool loaded)
        {
            byte val_3 = this.Flags;
            val_3 = val_3 & 251;
            this.Flags = (loaded != true) ? (val_3) : (val_3 | 4);
        }
        public void SetCanBeUnLoaded(bool allowUnloading)
        {
            byte val_3 = this.Flags;
            val_3 = val_3 & 253;
            this.Flags = (allowUnloading != true) ? (val_3) : (val_3 | 2);
        }
    
    }

}
