using UnityEngine;
public class TvOSInAppsExample : MonoBehaviour
{
    // Methods
    public TvOSInAppsExample()
    {
    
    }
    public void Init()
    {
        UnityEngine.Debug.Log(message:  0);
        PaymentManagerExample.init();
    }
    public void Buy()
    {
        PaymentManagerExample.buyItem(productId:  0);
    }

}
