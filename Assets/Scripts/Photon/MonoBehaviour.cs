using UnityEngine;

namespace Photon
{
    public class MonoBehaviour : MonoBehaviour
    {
        // Fields
        private PhotonView pvCache;
        
        // Properties
        public PhotonView photonView { get; }
        
        // Methods
        public MonoBehaviour()
        {
        
        }
        public PhotonView get_photonView()
        {
            PhotonView val_4;
            bool val_1 = UnityEngine.Object.op_Equality(x:  0, y:  this.pvCache);
            if(val_1 != false)
            {
                    this.pvCache = PhotonView.Get(component:  val_1);
                return val_4;
            }
            
            val_4 = this.pvCache;
            return val_4;
        }
    
    }

}
