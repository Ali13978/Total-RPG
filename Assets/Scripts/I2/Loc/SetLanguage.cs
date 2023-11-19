using UnityEngine;

namespace I2.Loc
{
    [UnityEngine.AddComponentMenu]
    public class SetLanguage : MonoBehaviour
    {
        // Fields
        public string _Language;
        
        // Methods
        public SetLanguage()
        {
        
        }
        private void OnClick()
        {
            this.ApplyLanguage();
        }
        public void ApplyLanguage()
        {
            if((I2.Loc.LocalizationManager.HasLanguage(Language:  null, AllowDiscartingRegion:  this._Language, Initialize:  true, SkipDisabled:  true)) == false)
            {
                    return;
            }
            
            I2.Loc.LocalizationManager.CurrentLanguage = null;
        }
    
    }

}
