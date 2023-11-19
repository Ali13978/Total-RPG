using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class RestoreFailedSaveDataUI : UIBase
    {
        // Fields
        private const string hostUrl = "http://total-rpg-web-services.azurewebsites.net/";
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase resultScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase waitingScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase crashRestoreScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI resultTextUI;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset resultTextFormat;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase crashWarningScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase crashSuccessScreen;
        private TzarGames.Endless.EndlessSaveData currentCrashSaveData;
        private const string REPLACED_KEY = "REPLACED_";
        private UnityEngine.Coroutine loadCoroutine;
        
        // Methods
        public RestoreFailedSaveDataUI()
        {
        
        }
        protected override void OnVisible()
        {
            this.OnVisible();
            this.StopAllCoroutines();
        }
        protected override void OnHidden()
        {
            this.OnHidden();
            this.currentCrashSaveData = 0;
        }
        private void showResultScreen(TzarGames.Endless.UI.MainMenu.RestoreFailedSaveDataUI.Status status)
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.showResultScreen(status:  status.ToString());
        }
        private void showResultScreen(string status)
        {
            this.resultTextUI.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        [TzarGames.Common.ConsoleCommand]
        public void UploadInvalidSaveData()
        {
            if(this.loadCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.loadCoroutine);
            }
            
            this.loadCoroutine = this.StartCoroutine(routine:  this.uploadInvalidSaveDataRoutine());
        }
        [TzarGames.Common.ConsoleCommand]
        public void DownloadFixedSaveData()
        {
            if(this.loadCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.loadCoroutine);
            }
            
            this.loadCoroutine = this.StartCoroutine(routine:  this.downloadFixedSaveDataRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator uploadInvalidSaveDataRoutine()
        {
            typeof(RestoreFailedSaveDataUI.<uploadInvalidSaveDataRoutine>c__Iterator0).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator downloadFixedSaveDataRoutine()
        {
            typeof(RestoreFailedSaveDataUI.<downloadFixedSaveDataRoutine>c__Iterator1).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void ConfirmRestoreCrashed()
        {
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            TzarGames.Endless.EndlessGameState.Instance.ReplaceSaveGameAndReload(saveData:  this.currentCrashSaveData);
            this.currentCrashSaveData = 0;
        }
        public void CancelRestoreCrashed()
        {
            this.currentCrashSaveData = 0;
            if(this.crashWarningScreen == null)
            {
                
            }
        
        }
    
    }

}
