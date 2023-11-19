using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ActionDetectorUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image icon;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject container;
        private TzarGames.GameFramework.ActionObjectDetector detector;
        private TzarGames.GameFramework.IObjectAction currentAction;
        private TzarGames.Endless.PlayerCharacter playerCharacter;
        
        // Methods
        public ActionDetectorUI()
        {
        
        }
        public void SetPlayerOwner(TzarGames.GameFramework.Player owner)
        {
            this.playerCharacter = 0;
            TzarGames.GameFramework.ActionObjectDetector val_1 = 0.ActionDetector;
            this.detector = val_1;
            val_1.add_OnActionsChanged(value:  new System.Action<TzarGames.GameFramework.ActionObjectDetector>(object:  this, method:  System.Void TzarGames.Endless.UI.ActionDetectorUI::DetectorOnOnActionsChanged(TzarGames.GameFramework.ActionObjectDetector obj)));
            this.updateActions(detector:  this.detector);
        }
        private void DetectorOnOnActionsChanged(TzarGames.GameFramework.ActionObjectDetector obj)
        {
            this.updateActions(detector:  obj);
        }
        private void updateActions(TzarGames.GameFramework.ActionObjectDetector detector)
        {
            var val_3;
            TzarGames.GameFramework.IObjectAction[] val_1 = detector.GetActions();
            if((val_1 != null) && (val_1.Length != 0))
            {
                    TzarGames.GameFramework.IObjectAction val_3 = val_1[0];
                this.currentAction = val_3;
                var val_4 = 0;
                val_4 = val_4 + 1;
                val_3 = val_3;
            }
            else
            {
                    this.icon.sprite = 0;
                this.container.SetActive(value:  false);
                this.currentAction = 0;
                return;
            }
            
            this.icon.sprite = val_3;
            this.container.SetActive(value:  true);
        }
        public void OnUsePressed()
        {
            var val_3;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this.currentAction;
            TzarGames.GameFramework.IObjectActionResult val_2 = this.currentAction.DoAction(action:  this.currentAction, performer:  this.playerCharacter);
            this.updateActions(detector:  this.detector);
        }
    
    }

}
