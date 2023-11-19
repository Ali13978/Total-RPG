using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class GraphRequest : MenuBase
    {
        // Fields
        private string apiQuery;
        private UnityEngine.Texture2D profilePic;
        
        // Methods
        public GraphRequest()
        {
            null = null;
            this.apiQuery = System.String.Empty;
        }
        protected override void GetGui()
        {
            var val_16;
            UnityEngine.Texture2D val_17;
            bool val_1 = UnityEngine.GUI.enabled;
            if(val_1 != false)
            {
                    val_16 = Facebook.Unity.FB.IsLoggedIn;
            }
            else
            {
                    val_16 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Basic Request - Me")) != false)
            {
                    Facebook.Unity.FB.API(query:  0, method:  "/me", callback:  0, formData:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            if((this.Button(label:  "Retrieve Profile Photo")) != false)
            {
                    Facebook.Unity.FB.API(query:  0, method:  "/me/picture", callback:  0, formData:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Facebook.Unity.Example.GraphRequest::ProfilePhotoCallback(Facebook.Unity.IGraphResult result)));
            }
            
            if((this.Button(label:  "Take and Upload screenshot")) != false)
            {
                    UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.TakeScreenshot());
            }
            
            this.LabelAndTextField(label:  "Request", text: ref  this.apiQuery);
            if((this.Button(label:  "Custom Request")) != false)
            {
                    Facebook.Unity.FB.API(query:  0, method:  this.apiQuery, callback:  0, formData:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            val_17 = this.profilePic;
            if(0 != val_17)
            {
                    val_17 = null;
                UnityEngine.GUILayout.Box(image:  0, options:  this.profilePic);
            }
            
            bool val_14 = val_1;
            UnityEngine.GUI.enabled = false;
        }
        private void ProfilePhotoCallback(Facebook.Unity.IGraphResult result)
        {
            var val_6;
            UnityEngine.Object val_7;
            var val_8;
            var val_9;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = result;
            val_7 = result;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_8 = result;
                val_7 = result;
                if(0 != val_7)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = result;
                this.profilePic = result;
            }
            
            }
            
            this.HandleResult(result:  result);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator TakeScreenshot()
        {
            typeof(GraphRequest.<TakeScreenshot>c__Iterator0).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new GraphRequest.<TakeScreenshot>c__Iterator0();
        }
    
    }

}
