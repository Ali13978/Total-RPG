using UnityEngine;

namespace TzarGames.Endless
{
    public class GameBundleLoader : StateMachine
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool useLocalManifestFile;
        [UnityEngine.SerializeField]
        private bool appendAppVersionToUrl;
        [UnityEngine.SerializeField]
        private string localManifestPath;
        [UnityEngine.SerializeField]
        private string mainServerUrl;
        [UnityEngine.SerializeField]
        private string devServerUrl;
        public string sceneAssetBundle;
        public string sceneName;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI status;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI sizeOfFile;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase loadingUI;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase failedUI;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase userActionUI;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider loadingProgress;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI progressText;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset initMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset userActionMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset fileLoadingMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset initFailureMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset loadingFailureMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset unknownErrorMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset sizeOfFileMessage;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnLoadingStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnLoadingFailed;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnLoadingFinished;
        private bool initComplete;
        private long downloadSize;
        
        // Methods
        public GameBundleLoader()
        {
            this.appendAppVersionToUrl = true;
            this.localManifestPath = "/AssetBundles/";
            this.mainServerUrl = "http://127.0.0.1:7888/";
            this.devServerUrl = "http://127.0.0.1:7888/";
        }
        protected void InitializeSourceURL()
        {
            string val_6;
            string val_7;
            var val_8;
            val_6 = this.mainServerUrl;
            if(this.appendAppVersionToUrl != false)
            {
                    if((val_6.EndsWith(value:  "/")) != true)
            {
                    val_7 = 0 + val_6;
            }
            
                val_8 = 0 + val_7 + UnityEngine.Application.version;
            }
            
            AssetBundles.AssetBundleManager.SetSourceAssetBundleURL(absolutePath:  0);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator getDownloadSize()
        {
            typeof(GameBundleLoader.<getDownloadSize>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void TryAgain()
        {
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        public void ContinueLoading()
        {
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
    
    }

}
