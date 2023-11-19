using UnityEngine;

namespace Unitycoding.UIWidgets
{
    [UnityEngine.RequireComponent]
    public class Tab : MonoBehaviour
    {
        // Fields
        public Unitycoding.UIWidgets.Tab.TabEvent onSelect;
        public Unitycoding.UIWidgets.Tab.TabEvent onDeselect;
        private UnityEngine.UI.Button m_Button;
        
        // Methods
        public Tab()
        {
            this.onSelect = new UnityEngine.Events.UnityEvent();
            this.onDeselect = new UnityEngine.Events.UnityEvent();
        }
        private void Start()
        {
            UnityEngine.UI.Button val_1 = this.GetComponent<UnityEngine.UI.Button>();
            this.m_Button = val_1;
            val_1.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void Unitycoding.UIWidgets.Tab::Select()));
        }
        public void Select()
        {
            this.m_Button.transform.parent.BroadcastMessage(methodName:  "Deselect", parameter:  this, options:  1);
            this.onSelect.Invoke();
        }
        private void Deselect(Unitycoding.UIWidgets.Tab exceptTab)
        {
            if(0 == this)
            {
                    return;
            }
            
            this.onDeselect.Invoke();
        }
    
    }

}
