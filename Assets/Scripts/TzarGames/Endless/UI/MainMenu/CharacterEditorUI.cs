using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class CharacterEditorUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.CreateCharacterUI createCharacterUi;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase waitingWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform listContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.CharacterEntryUI characterEntryPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button loadButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button deleteButton;
        private System.Collections.Generic.Dictionary<TzarGames.Endless.UI.MainMenu.CharacterEntryUI, TzarGames.Endless.ICharacterInfo> infos;
        private TzarGames.Endless.UI.MainMenu.CharacterEntryUI lastSelected;
        
        // Methods
        public CharacterEditorUI()
        {
            this.infos = new System.Collections.Generic.Dictionary<TzarGames.Endless.UI.MainMenu.CharacterEntryUI, TzarGames.Endless.ICharacterInfo>();
        }
        protected override void OnVisible()
        {
            this.OnVisible();
            this.refreshList();
        }
        private void refreshList()
        {
            var val_11;
            var val_12;
            TzarGames.Common.Utils.DestroyAllChilds(transform:  0);
            this.infos.Clear();
            this.lastSelected = 0;
            this.loadButton.interactable = false;
            this.deleteButton.interactable = false;
            val_11 = 0;
            goto label_5;
            label_24:
            X23.Add(key:  X22, value:  X21);
            val_11 = 1;
            label_5:
            if(val_11 >= val_2.Length)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_11 = TzarGames.Endless.EndlessGameState.Instance.Characters[1];
            Unitycoding.UIWidgets.RadialMenuItem val_3 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_11;
            X24.text = val_11;
            val_3.transform.SetParent(parent:  this.listContainer, worldPositionStays:  false);
            TzarGames.Endless.ICharacterInfo val_7 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            if(val_3 != null)
            {
                    val_3.Selected = (val_11 == val_7) ? 1 : 0;
            }
            else
            {
                    val_3.Selected = (val_11 == val_7) ? 1 : 0;
            }
            
            if(null != null)
            {
                    this.lastSelected = val_3;
            }
            
            val_3.add_OnSelected(value:  new System.Action<TzarGames.Endless.UI.MainMenu.CharacterEntryUI>(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.CharacterEditorUI::EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.CharacterEntryUI characterEntryUi)));
            if(this.infos != null)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        private void EntryOnOnSelected(TzarGames.Endless.UI.MainMenu.CharacterEntryUI characterEntryUi)
        {
            TzarGames.Endless.UI.MainMenu.CharacterEntryUI val_5;
            UnityEngine.UI.Button val_6;
            var val_7;
            val_5 = this.lastSelected;
            if(0 != val_5)
            {
                    val_5 = this.lastSelected;
                val_5.Selected = false;
            }
            
            this.lastSelected = characterEntryUi;
            characterEntryUi.Selected = true;
            if(this.infos.Item[this.lastSelected] != TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter)
            {
                    this.loadButton.interactable = true;
                val_6 = this.deleteButton;
                val_7 = 1;
            }
            else
            {
                    this.loadButton.interactable = false;
                val_6 = this.deleteButton;
                val_7 = 0;
            }
            
            val_6.interactable = false;
        }
        public void CreateCharacter()
        {
            this.createCharacterUi.SetCancelState(enable:  true);
            this.createCharacterUi.add_OnGoToNextScene(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.CharacterEditorUI::CreateCharacterUi_OnGoToNextScene()));
            this.createCharacterUi.nextMenu = this;
            this.createCharacterUi.<AutoSelectCharacter>k__BackingField = false;
            if(this.createCharacterUi == null)
            {
                
            }
        
        }
        private void CreateCharacterUi_OnGoToNextScene()
        {
            this.createCharacterUi.remove_OnGoToNextScene(value:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.UI.MainMenu.CharacterEditorUI::CreateCharacterUi_OnGoToNextScene()));
            if(((this.createCharacterUi.<LastCreatedCharacterNum>k__BackingField) & 2147483648) != 0)
            {
                    return;
            }
            
            this.loadCharacter(number:  this.createCharacterUi.<LastCreatedCharacterNum>k__BackingField);
        }
        public void LoadSelectedCharacter()
        {
            if(0 == this.lastSelected)
            {
                    return;
            }
            
            int val_5 = TzarGames.Endless.EndlessGameState.Instance.GetCharacterNumber(characterInfo:  this.infos.Item[this.lastSelected]);
            if(val_5 == 1)
            {
                    return;
            }
            
            this.loadCharacter(number:  val_5);
        }
        private void loadCharacter(int number)
        {
            TzarGames.Endless.EndlessGameState.Instance.SelectCharacter(num:  number);
            TzarGames.Endless.EndlessGameState.Instance.SaveGame();
            TzarGames.Endless.EndlessGameState.Instance.ReloadGame();
            if(this.waitingWindow == null)
            {
                
            }
        
        }
        public void ConfirmDeleteSelectedCharacter()
        {
            if(0 == this.lastSelected)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_3 = this.infos.Item[this.lastSelected];
            if(TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter == val_3)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.DeleteCharacter(num:  TzarGames.Endless.EndlessGameState.Instance.GetCharacterNumber(characterInfo:  val_3));
            this.refreshList();
        }
    
    }

}
