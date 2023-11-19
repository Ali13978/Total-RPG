using UnityEngine;

namespace I2.Loc
{
    [UnityEngine.AddComponentMenu]
    public class CustomLocalizeCallback : MonoBehaviour
    {
        // Fields
        public UnityEngine.Events.UnityEvent _OnLocalize;
        
        // Methods
        public CustomLocalizeCallback()
        {
            this._OnLocalize = new UnityEngine.Events.UnityEvent();
        }
        public void Enable()
        {
            LocalizationManager.OnLocalizeCallback val_1 = new LocalizationManager.OnLocalizeCallback(object:  this, method:  public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize());
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  0);
            LocalizationManager.OnLocalizeCallback val_2 = new LocalizationManager.OnLocalizeCallback(object:  this, method:  public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize());
            I2.Loc.LocalizationManager.add_OnLocalizeEvent(value:  0);
        }
        public void OnDisable()
        {
            LocalizationManager.OnLocalizeCallback val_1 = new LocalizationManager.OnLocalizeCallback(object:  this, method:  public System.Void I2.Loc.CustomLocalizeCallback::OnLocalize());
            I2.Loc.LocalizationManager.remove_OnLocalizeEvent(value:  0);
        }
        public void OnLocalize()
        {
            this._OnLocalize.Invoke();
        }
    
    }

}
