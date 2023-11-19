using UnityEngine;

namespace UnityEngine.Purchasing
{
    [UnityEngine.AddComponentMenu]
    public class DemoInventory : MonoBehaviour
    {
        // Methods
        public DemoInventory()
        {
        
        }
        public void Fulfill(string productId)
        {
            string val_3;
            object val_4;
            val_3 = productId;
            if((val_3 != null) && ((System.String.op_Equality(a:  0, b:  val_3)) != false))
            {
                    val_4 = 0;
            }
            else
            {
                    val_3 = System.String.Format(format:  0, arg0:  "Unrecognized productId \"{0}\"");
                val_4 = 0;
            }
            
            UnityEngine.Debug.Log(message:  val_4);
        }
    
    }

}
