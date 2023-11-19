using UnityEngine;

namespace TzarGames.Endless
{
    public class NetProjectileHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Trap netTrapPrefab;
        [UnityEngine.SerializeField]
        private float freezeTime;
        
        // Methods
        public NetProjectileHandler()
        {
            this.freezeTime = 2f;
        }
        public void HandleCollider(UnityEngine.Collider collider)
        {
            TzarGames.TzarHero.TH_Character val_1 = collider.GetComponent<TzarGames.TzarHero.TH_Character>();
            if(0 == val_1)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = val_1.GroundPivotPosition;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}).ApplyToCharacter(character:  val_1, freezeTime:  this.freezeTime);
        }
    
    }

}
