using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class InteractionUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button openShopButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button openForgeButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button openTaskListButton;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.ActionDetectorUI detectorUI;
        
        // Methods
        public InteractionUI()
        {
        
        }
        private void Start()
        {
            this.ShowOpenShopButton(show:  false);
            this.ShowOpenForgeButton(show:  false);
            this.ShowTaskListButton(show:  false);
        }
        public void ShowOpenShopButton(bool show)
        {
            this.openShopButton.gameObject.SetActive(value:  show);
        }
        public void ShowOpenForgeButton(bool show)
        {
            this.openForgeButton.gameObject.SetActive(value:  show);
        }
        public void ShowTaskListButton(bool show)
        {
            this.openTaskListButton.gameObject.SetActive(value:  show);
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            this.OnPlayerOwnerSet(owner:  owner);
            this.detectorUI.SetPlayerOwner(owner:  owner);
        }
    
    }

}
