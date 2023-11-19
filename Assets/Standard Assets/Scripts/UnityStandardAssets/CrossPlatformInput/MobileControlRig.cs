using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    [UnityEngine.ExecuteInEditMode]
    public class MobileControlRig : MonoBehaviour
    {
        // Methods
        public MobileControlRig()
        {
        
        }
        private void OnEnable()
        {
            this.EnableControlRig(enabled:  true);
        }
        private void Start()
        {
            if(0 == (UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>()))
            {
                    UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "EventSystem");
                if(null != 0)
            {
                    UnityEngine.EventSystems.EventSystem val_4 = AddComponent<UnityEngine.EventSystems.EventSystem>();
            }
            else
            {
                    UnityEngine.EventSystems.EventSystem val_5 = AddComponent<UnityEngine.EventSystems.EventSystem>();
            }
            
                UnityEngine.EventSystems.StandaloneInputModule val_6 = AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
            }
            
            this.EnableControlRig(enabled:  true);
        }
        private void CheckEnableControlRig()
        {
            this.EnableControlRig(enabled:  true);
        }
        private void EnableControlRig(bool enabled)
        {
            var val_11;
            var val_12;
            var val_13;
            System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
            label_17:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = val_2;
            if(((val_2 & 1) & 1) == 0)
            {
                goto label_26;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_2;
            0.gameObject.SetActive(value:  enabled);
            goto label_17;
            label_26:
            if(val_2 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = val_2;
            }
            
            if(0 == 77)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
    
    }

}
