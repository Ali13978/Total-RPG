using UnityEngine;

namespace TzarGames.Endless
{
    public class ActivatePathHelper : MonoBehaviour
    {
        // Methods
        public ActivatePathHelper()
        {
        
        }
        public void Activate(bool active)
        {
            bool val_10;
            bool val_11;
            val_10 = active;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_11 = val_10;
                typeof(ActivatePathHelper.<Activate>c__AnonStorey0).__il2cppRuntimeField_10 = val_11;
                typeof(ActivatePathHelper.<Activate>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            }
            else
            {
                    val_10 = 16;
                mem[16] = val_10;
                mem[24] = this;
                val_11 = mem[16];
            }
            
            val_11 = val_1.tryActivate(active:  (val_11 == true) ? 1 : 0);
            if(val_11 != false)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.BoundTooltipItem val_5 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 != val_5)
            {
                    val_5.OnLocalPlayerObjectSpawned.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  val_1, method:  System.Void ActivatePathHelper.<Activate>c__AnonStorey0::<>m__0(TzarGames.GameFramework.Player player)));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        private bool tryActivate(bool active)
        {
            var val_6;
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 == val_1)
            {
                    val_6 = 0;
                return (bool)val_6;
            }
            
            val_1.gameObject.SetActive(value:  active);
            val_6 = 1;
            return (bool)val_6;
        }
    
    }

}
