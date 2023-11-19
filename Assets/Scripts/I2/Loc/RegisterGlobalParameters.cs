using UnityEngine;

namespace I2.Loc
{
    public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
    {
        // Methods
        public RegisterGlobalParameters()
        {
        
        }
        public virtual void OnEnable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((I2.Loc.LocalizationManager.ParamManagers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            I2.Loc.LocalizationManager.ParamManagers.Add(item:  this);
            I2.Loc.LocalizationManager.LocalizeAll(Force:  I2.Loc.LocalizationManager.ParamManagers);
        }
        public virtual void OnDisable()
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.ParamManagers.Remove(item:  this);
        }
        public virtual string GetParameterValue(string ParamName)
        {
            return 0;
        }
    
    }

}
