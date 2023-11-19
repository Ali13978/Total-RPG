using UnityEngine;

namespace Facebook.Unity.Example
{
    internal sealed class MainMenu : MenuBase
    {
        // Methods
        public MainMenu()
        {
        
        }
        protected override bool ShowBackButton()
        {
            return false;
        }
        protected override void GetGui()
        {
            var val_40;
            var val_41;
            var val_42;
            UnityEngine.GUILayout.BeginVertical(options:  0);
            bool val_1 = UnityEngine.GUI.enabled;
            if((this.Button(label:  "FB.Init")) != false)
            {
                    Facebook.Unity.FB.Init(onInitComplete:  0, onHideUnity:  new Facebook.Unity.InitDelegate(object:  this, method:  System.Void Facebook.Unity.Example.MainMenu::OnInitComplete()), authResponse:  new Facebook.Unity.HideUnityDelegate(object:  this, method:  System.Void Facebook.Unity.Example.MainMenu::OnHideUnity(bool isGameShown)));
                string val_5 = Facebook.Unity.FB.AppId;
                this.Status = 0 + "FB.Init() called with ";
            }
            
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            if(val_1 != false)
            {
                    val_40 = Facebook.Unity.FB.IsInitialized;
            }
            else
            {
                    val_40 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Login")) != false)
            {
                    this.CallFBLogin();
                this.Status = "Login called";
            }
            
            bool val_10 = Facebook.Unity.FB.IsLoggedIn;
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Get publish_actions")) != false)
            {
                    this.CallFBLoginForPublish();
                this.Status = "Login (for publish_actions) called";
            }
            
            val_41 = null;
            val_41 = null;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MinWidth(minWidth:  (float)Facebook.Unity.Example.ConsoleBase.MarginFix);
            UnityEngine.GUILayout.Label(content:  0, options:  UnityEngine.GUIContent.none);
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MinWidth(minWidth:  (float)Facebook.Unity.Example.ConsoleBase.MarginFix);
            UnityEngine.GUILayout.Label(content:  0, options:  UnityEngine.GUIContent.none);
            UnityEngine.GUILayout.EndHorizontal();
            bool val_16 = this.Button(label:  "Logout");
            if(val_16 != false)
            {
                    val_16.CallFBLogout();
                this.Status = "Logout called";
            }
            
            if(val_1 != false)
            {
                    val_42 = Facebook.Unity.FB.IsInitialized;
            }
            else
            {
                    val_42 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Share Dialog")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            if((this.Button(label:  "App Requests")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            if((this.Button(label:  "Graph Request")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            if(Facebook.Unity.Constants.IsWeb != false)
            {
                    if((this.Button(label:  "Pay")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            }
            
            if((this.Button(label:  "App Events")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            if((this.Button(label:  "App Links")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    if((this.Button(label:  "App Invites")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            }
            
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    if((this.Button(label:  "Access Token")) != false)
            {
                    val_42 = null;
                this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            }
            
            }
            
            UnityEngine.GUILayout.EndVertical();
            bool val_37 = val_1;
            UnityEngine.GUI.enabled = false;
        }
        private void CallFBLogin()
        {
            if(null != 0)
            {
                    Add(item:  "public_profile");
                Add(item:  "email");
            }
            else
            {
                    Add(item:  "public_profile");
                Add(item:  "email");
            }
            
            Add(item:  "user_friends");
            Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> val_2 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
            Facebook.Unity.FB.LogInWithReadPermissions(permissions:  0, callback:  new System.Collections.Generic.List<System.String>());
        }
        private void CallFBLoginForPublish()
        {
            Add(item:  "publish_actions");
            Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> val_2 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
            Facebook.Unity.FB.LogInWithPublishPermissions(permissions:  0, callback:  new System.Collections.Generic.List<System.String>());
        }
        private void CallFBLogout()
        {
            Facebook.Unity.FB.LogOut();
        }
        private void OnInitComplete()
        {
            string val_8;
            var val_9;
            string val_10;
            this.Status = "Success - Check log for details";
            this.LastResponse = "Success Response: OnInitComplete Called\n";
            bool val_4 = Facebook.Unity.FB.IsInitialized;
            val_9 = System.String.Format(format:  0, arg0:  "OnInitCompleteCalled IsLoggedIn=\'{0}\' IsInitialized=\'{1}\'", arg1:  Facebook.Unity.FB.IsLoggedIn);
            val_8 = null;
            Facebook.Unity.Example.LogView.AddLog(log:  val_8);
            if(Facebook.Unity.AccessToken.CurrentAccessToken == null)
            {
                    return;
            }
            
            val_10 = Facebook.Unity.AccessToken.CurrentAccessToken;
            val_9 = val_10;
            val_10 = null;
            Facebook.Unity.Example.LogView.AddLog(log:  val_10);
        }
        private void OnHideUnity(bool isGameShown)
        {
            string val_4;
            this.Status = "Success - Check log for details";
            bool val_1 = isGameShown;
            this.LastResponse = System.String.Format(format:  0, arg0:  "Success Response: OnHideUnity Called {0}\n");
            string val_3 = 0 + "Is game shown: "("Is game shown: ");
            val_4 = null;
            Facebook.Unity.Example.LogView.AddLog(log:  val_4);
        }
    
    }

}
