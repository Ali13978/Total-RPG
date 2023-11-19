using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class PrivacyUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase mainWindow;
        [UnityEngine.SerializeField]
        private string nextSceneName;
        [UnityEngine.SerializeField]
        private float nextSceneLoadDelay;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset privacyPolicyUrl;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject loadingMessage;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject fadeScreen;
        
        // Methods
        public PrivacyUI()
        {
            this.nextSceneLoadDelay = 1f;
        }
        private void Start()
        {
            if(TzarGames.Common.Privacy.PrivacyAnswerGiven != false)
            {
                    UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.loadScene(withDelay:  false));
                return;
            }
            
            if(this.mainWindow == null)
            {
                
            }
        
        }
        public void Accept()
        {
            TzarGames.Common.Privacy.CanCollectData = false;
            TzarGames.Common.Privacy.PrivacyAnswerGiven = false;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.loadScene(withDelay:  true));
        }
        public void Decline()
        {
            TzarGames.Common.Privacy.CanCollectData = false;
            TzarGames.Common.Privacy.PrivacyAnswerGiven = false;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.loadScene(withDelay:  true));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator loadScene(bool withDelay)
        {
            if(null != 0)
            {
                    typeof(PrivacyUI.<loadScene>c__Iterator0).__il2cppRuntimeField_10 = withDelay;
            }
            else
            {
                    mem[16] = withDelay;
            }
            
            typeof(PrivacyUI.<loadScene>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OpenPrivacyPolicy()
        {
            string val_1 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            UnityEngine.Application.OpenURL(url:  0);
        }
    
    }

}
