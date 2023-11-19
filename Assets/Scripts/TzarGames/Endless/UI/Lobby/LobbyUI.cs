using UnityEngine;

namespace TzarGames.Endless.UI.Lobby
{
    public class LobbyUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.Lobby.StageSelectionUI stageSelectionPanel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase gotoNextStageDialog;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase gotoBossStageDialog;
        private System.Collections.Generic.List<TzarGames.Common.UI.UIBase> allMenus;
        
        // Methods
        public LobbyUI()
        {
            this.allMenus = new System.Collections.Generic.List<TzarGames.Common.UI.UIBase>();
        }
        protected override void Awake()
        {
            this.Awake();
            this.allMenus.AddRange(collection:  this.GetComponentsInChildren<TzarGames.Common.UI.UIBase>());
        }
        private void showMenu(TzarGames.Common.UI.UIBase menuToShow)
        {
            var val_4;
            var val_5;
            List.Enumerator<T> val_1 = this.allMenus.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(0 != val_2)
            {
                goto label_5;
            }
            
            val_2.GetObjectData(info:  1, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            goto label_9;
            label_5:
            val_2.GetObjectData(info:  0, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            goto label_9;
            label_2:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        public void OnGotoCurrentStageAccepted()
        {
            var val_2;
            TzarGames.GameFramework.GameManager val_1 = TzarGames.GameFramework.GameManager.Instance;
            if(val_1 != null)
            {
                    val_2 = null;
                val_2 = null;
                val_1 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessLobbyGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_2) ? (val_1) : 0;
            }
            
            0.GotoMaxStage();
            this.HideStageSelectionPanel();
        }
        public void ShowLowerStageSelectionPanel()
        {
            this.stageSelectionPanel.SetLowerStageMode();
            this.showMenu(menuToShow:  this.stageSelectionPanel);
        }
        public void ShowUpperStageSelectionPanel()
        {
            var val_9;
            var val_10;
            TzarGames.Common.UI.UIBase val_11;
            TzarGames.Endless.ICharacterInfo val_2 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = val_2;
            TzarGames.Endless.ICharacterInfo val_5 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = val_5;
            if(val_2 != val_5)
            {
                goto label_13;
            }
            
            if(TzarGames.Endless.EndlessGameState.Instance.IsCurrentStageWithBoss() == false)
            {
                goto label_15;
            }
            
            val_11 = this.gotoBossStageDialog;
            goto label_18;
            label_13:
            this.stageSelectionPanel.SetUpperStageMode();
            val_11 = this.stageSelectionPanel;
            goto label_18;
            label_15:
            val_11 = this.gotoNextStageDialog;
            label_18:
            this.showMenu(menuToShow:  val_11);
        }
        public void HideStageSelectionPanel()
        {
            if(this.gotoBossStageDialog == null)
            {
                
            }
        
        }
    
    }

}
