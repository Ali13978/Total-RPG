using UnityEngine;

namespace TzarGames.GameFramework
{
    public class WeaponObject : MonoBehaviour, IWeaponObject
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform[] muzzleFlashPositions;
        
        // Properties
        public UnityEngine.Transform[] FireSources { get; }
        
        // Methods
        public WeaponObject()
        {
        
        }
        public UnityEngine.Transform[] get_FireSources()
        {
            return (UnityEngine.Transform[])this.muzzleFlashPositions;
        }
        private void Reset()
        {
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_20 = this.transform;
            this.muzzleFlashPositions = null;
        }
        public void Unparent()
        {
            this.transform.SetParent(parent:  0);
        }
    
    }

}
