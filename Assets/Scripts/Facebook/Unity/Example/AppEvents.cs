using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class AppEvents : MenuBase
    {
        // Methods
        public AppEvents()
        {
        
        }
        protected override void GetGui()
        {
            if((this.Button(label:  "Log FB App Event")) == false)
            {
                    return;
            }
            
            mem[1152921511839455512] = "Logged FB.AppEvent";
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            Add(key:  "fb_description", value:  "Clicked \'Log AppEvent\' button");
            Facebook.Unity.FB.LogAppEvent(logEvent:  0, valueToSum:  new System.Nullable<System.Single>() {HasValue = true}, parameters:  0);
            string val_3 = Facebook.Unity.FB.AppId;
            string val_4 = 0 + "You may see results showing up at https://www.facebook.com/analytics/"("You may see results showing up at https://www.facebook.com/analytics/");
            Facebook.Unity.Example.LogView.AddLog(log:  0);
        }
    
    }

}
