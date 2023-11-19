using UnityEngine;

namespace TzarGames.TzarHero
{
    [Serializable]
    public class ItemActivationInfo
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool _isActive;
        [UnityEngine.SerializeField]
        private int _slot;
        
        // Properties
        public bool IsActive { get; }
        public int Slot { get; }
        
        // Methods
        public ItemActivationInfo(bool isActive, int slot)
        {
            this._slot = slot;
            this._isActive = isActive;
        }
        public bool get_IsActive()
        {
            return (bool)this._isActive;
        }
        public int get_Slot()
        {
            return (int)this._slot;
        }
    
    }

}
