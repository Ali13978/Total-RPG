using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class TabNavigationHelper : MonoBehaviour
    {
        // Fields
        private UnityEngine.EventSystems.EventSystem _system;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Selectable[] NavigationPath;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Extensions.NavigationMode NavigationMode;
        
        // Methods
        public TabNavigationHelper()
        {
        
        }
        private void Start()
        {
            UnityEngine.EventSystems.EventSystem val_1 = this.GetComponent<UnityEngine.EventSystems.EventSystem>();
            this._system = val_1;
            if(0 != val_1)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public void Update()
        {
            UnityEngine.EventSystems.EventSystem val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            UnityEngine.UI.Selectable[] val_26;
            UnityEngine.UI.Selectable val_27;
            if(((UnityEngine.Input.GetKeyDown(key:  0)) == false) || ((UnityEngine.Input.GetKey(key:  0)) == false))
            {
                goto label_6;
            }
            
            val_21 = this._system;
            val_22 = UnityEngine.Object.op_Inequality(x:  0, y:  this._system.currentSelectedGameObject);
            if(val_22 == false)
            {
                goto label_44;
            }
            
            val_23 = val_21.currentSelectedGameObject.GetComponent<UnityEngine.UI.Selectable>();
            if(val_23 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_6:
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                goto label_17;
            }
            
            val_21 = this._system;
            val_22 = UnityEngine.Object.op_Inequality(x:  0, y:  this._system.currentSelectedGameObject);
            if(val_22 == false)
            {
                goto label_44;
            }
            
            val_23 = val_21.currentSelectedGameObject.GetComponent<UnityEngine.UI.Selectable>();
            label_14:
            val_24 = val_23;
            goto label_25;
            label_17:
            if(this.NavigationMode != 1)
            {
                goto label_26;
            }
            
            val_25 = 0;
            goto label_27;
            label_36:
            val_25 = 1;
            label_27:
            if(val_25 >= this.NavigationPath.Length)
            {
                goto label_52;
            }
            
            UnityEngine.GameObject val_13 = this.NavigationPath[1].gameObject;
            if(0 != this._system.currentSelectedGameObject)
            {
                goto label_36;
            }
            
            val_26 = this.NavigationPath;
            if(val_26 == null)
            {
                goto label_37;
            }
            
            int val_24 = this.NavigationPath.Length;
            val_24 = val_25 - val_24;
            if(val_24 != 1)
            {
                goto label_38;
            }
            
            goto label_48;
            label_26:
            val_27 = 0;
            if(0 != this._system.currentSelectedGameObject)
            {
                goto label_52;
            }
            
            val_21 = this._system;
            label_44:
            label_25:
            val_27 = val_21.firstSelectedGameObject.GetComponent<UnityEngine.UI.Selectable>();
            label_52:
            this.selectGameObject(selectable:  val_27);
            return;
            label_37:
            val_26 = this.NavigationPath;
            if(val_26 == null)
            {
                    val_26 = 0;
            }
            
            if((val_25 - this.NavigationPath.Length) == 1)
            {
                goto label_48;
            }
            
            label_38:
            var val_21 = val_25 + 1;
            var val_22 = val_26 + (((long)(int)((val_25 + 1))) << 3);
            goto label_52;
            label_48:
            UnityEngine.UI.Selectable val_25 = val_26[0];
            goto label_52;
        }
        private void selectGameObject(UnityEngine.UI.Selectable selectable)
        {
            if(0 == selectable)
            {
                    return;
            }
            
            if(0 != (selectable.GetComponent<UnityEngine.UI.InputField>()))
            {
                    UnityEngine.EventSystems.PointerEventData val_4 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  this._system);
            }
            
            this._system.SetSelectedGameObject(selected:  selectable.gameObject, pointer:  new UnityEngine.EventSystems.BaseEventData(eventSystem:  this._system));
        }
    
    }

}
