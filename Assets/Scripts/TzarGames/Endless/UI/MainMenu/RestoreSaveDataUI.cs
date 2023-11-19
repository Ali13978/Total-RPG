using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class RestoreSaveDataUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase warningScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase listScreen;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button loadButton;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase resultScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase waitingScreen;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI warningTextUI;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedString warningTextTemplate;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform saveListContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.SaveGameEntryUI saveEntryPrefab;
        private TzarGames.Endless.UI.MainMenu.SaveGameEntryUI latestEntryUI;
        private TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile currentFile;
        
        // Methods
        public RestoreSaveDataUI()
        {
            this.warningTextTemplate = TzarGames.Common.LocalizedString.op_Implicit(text:  0);
        }
        protected override void OnVisible()
        {
            var val_2;
            this.OnVisible();
            if(0 != this.latestEntryUI)
            {
                    val_2 = 1;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.loadButton.interactable = false;
        }
        public void StartRestoring()
        {
            this.currentFile = 0;
            TzarGames.Common.Utils.DestroyAllChilds(transform:  0);
            System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult> val_1 = new System.Action<TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI::<StartRestoring>m__0(TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult result));
            TzarGames.Endless.CloudSaveSystem.CloudSaveGame.GetSaveGames(callback:  0);
        }
        public void RestoreSelected()
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this.currentFile;
            this.warningTextUI.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedString.op_Implicit(text:  0));
            if(this.warningScreen == null)
            {
                
            }
        
        }
        private void EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.SaveGameEntryUI saveGameEntryUi)
        {
            TzarGames.Endless.UI.MainMenu.SaveGameEntryUI val_3;
            var val_4;
            val_3 = this.latestEntryUI;
            if(0 != val_3)
            {
                    val_3 = this.latestEntryUI;
                val_3.Highlight = false;
            }
            
            this.latestEntryUI = saveGameEntryUi;
            if(saveGameEntryUi != null)
            {
                    this.currentFile = saveGameEntryUi.<SaveFile>k__BackingField;
            }
            else
            {
                    this.currentFile = 1;
            }
            
            saveGameEntryUi.Highlight = true;
            if(0 != this.latestEntryUI)
            {
                    val_4 = 1;
            }
            else
            {
                    val_4 = 0;
            }
            
            this.loadButton.interactable = false;
        }
        public void CancenRestore()
        {
            if(this.warningScreen == null)
            {
                
            }
        
        }
        protected override void OnHidden()
        {
            this.OnHidden();
            this.currentFile = 0;
        }
        public void ConfirmRestore()
        {
            var val_5;
            var val_6;
            object val_1 = new System.Object();
            typeof(RestoreSaveDataUI.<ConfirmRestore>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            if(this.currentFile == null)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.BoundTooltipItem val_2 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(null != 0)
            {
                    val_5 = val_1;
                typeof(RestoreSaveDataUI.<ConfirmRestore>c__AnonStorey0).__il2cppRuntimeField_10 = val_2;
            }
            else
            {
                    val_5 = 16;
                mem[16] = val_2;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = this.currentFile;
            val_5.RestoreSaveDataFromCloud(fileName:  this.currentFile, callback:  new System.Action<TzarGames.Endless.EndlessSaveData>(object:  val_1, method:  System.Void RestoreSaveDataUI.<ConfirmRestore>c__AnonStorey0::<>m__0(TzarGames.Endless.EndlessSaveData saveData)));
        }
        private void showResultScreen()
        {
            if(this.resultScreen == null)
            {
                
            }
        
        }
        private void <StartRestoring>m__0(TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult result)
        {
            object val_15;
            TzarGames.Common.UI.UIBase val_16;
            var val_17;
            var val_18;
            IntPtr val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_15 = this;
            val_16 = this.waitingScreen;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_17 = result;
            if((result & 1) != 0)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_18 = result;
            }
            else
            {
                    this.showResultScreen();
                return;
            }
            
            val_16 = 0 + "Saved files count: "("Saved files count: ");
            val_19 = 0;
            UnityEngine.Debug.Log(message:  0);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_19 = 1;
            val_20 = result;
            val_21 = 0;
            goto label_24;
            label_46:
            X24.text = X23;
            mem2[0] = 1152921504858763264;
            System.Action<TzarGames.Endless.UI.MainMenu.SaveGameEntryUI> val_5 = null;
            val_19 = System.Void TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI::EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.SaveGameEntryUI saveGameEntryUi);
            val_5 = new System.Action<TzarGames.Endless.UI.MainMenu.SaveGameEntryUI>(object:  this, method:  val_19);
            val_16.add_OnSelected(value:  val_5);
            val_16.Highlight = false;
            val_21 = 1;
            label_24:
            if(val_21 >= 1152921510979293360)
            {
                goto label_26;
            }
            
            TzarGames.Endless.CloudSaveSystem.ICloudGetSaveGameListResult val_6 = result + 8;
            UnityEngine.Transform val_8 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform;
            val_8.SetParent(parent:  this.saveListContainer, worldPositionStays:  false);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_22 = System.Void TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI::EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.SaveGameEntryUI saveGameEntryUi);
            val_8.text = System.Void TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI::EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.SaveGameEntryUI saveGameEntryUi);
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_23 = System.Void TzarGames.Endless.UI.MainMenu.RestoreSaveDataUI::EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.SaveGameEntryUI saveGameEntryUi);
            if(val_8 != null)
            {
                goto label_46;
            }
            
            goto label_46;
            label_26:
            val_15 = this.listScreen;
        }
    
    }

}
