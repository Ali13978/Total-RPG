using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class SocialWidgetUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase status;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase signIn;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase signOut;
        
        // Methods
        public SocialWidgetUI()
        {
        
        }
        public void OnSignOut()
        {
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.SocialSystem.Instance.SignOut();
        }
        public void OnSignIn()
        {
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.SocialSystem.Instance.Authenticate(callback:  new System.Action<System.Boolean, System.String>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.SocialWidgetUI::<OnSignIn>m__0(bool result, string message)));
        }
        private void Update()
        {
            var val_18;
            TzarGames.Common.UI.UIBase val_19;
            TzarGames.Common.UI.UIBase val_20;
            val_18 = this;
            TzarGames.Endless.SocialSystem val_1 = TzarGames.Endless.SocialSystem.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            val_19 = this.status;
            if(val_19.IsVisible == true)
            {
                    return;
            }
            
            val_19 = this.signIn;
            if(val_1.IsAuthenticated != false)
            {
                    if(this.signOut.IsVisible == true)
            {
                    return;
            }
            
                val_20 = this.signOut;
                if(val_20 != null)
            {
                goto label_14;
            }
            
            }
            else
            {
                    bool val_10 = val_19.IsVisible;
                if(this.signOut.IsVisible == false)
            {
                    return;
            }
            
                val_20 = this.signOut;
            }
            
            label_14:
            val_18 = ???;
            val_19 = ???;
            goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
        }
        private void <OnSignIn>m__0(bool result, string message)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Authentication result: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = result;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 24908747;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " message: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = message;
            string val_2 = +0;
            UnityEngine.Debug.Log(message:  0);
            if(this.status != null)
            {
                    return;
            }
        
        }
    
    }

}
