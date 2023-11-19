using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class CloseNewWorldPortal_2_Behaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.TzarBehaviour[] crystals;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.CloseNewWorldPortalQuest debugQuest;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestCompleted;
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        private TzarGames.Endless.ObjectDistanceIndicator _indicator;
        private bool isFinished;
        private int destroyedCrystalCount;
        
        // Methods
        public CloseNewWorldPortal_2_Behaviour()
        {
        
        }
        private void Start()
        {
            goto label_1;
            label_6:
            add_OnComponentDestroy(value:  X21);
            0 = 1;
            label_1:
            if(0 >= this.crystals.Length)
            {
                goto label_3;
            }
            
            null = new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.Quests.CloseNewWorldPortal_2_Behaviour::Crystal_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
            if(this.crystals[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            TzarGames.Endless.Quests.CloseNewWorldPortalQuest val_2 = this.getQuest();
            this.showMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        private void Crystal_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            TzarGames.GameFramework.dlgTzarDestroy val_15;
            UnityEngine.Object val_16;
            var val_17;
            var val_18;
            var val_19;
            TzarGames.GameFramework.dlgTzarDestroy val_1 = null;
            val_15 = val_1;
            val_1 = new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.Quests.CloseNewWorldPortal_2_Behaviour::Crystal_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
            behaviour.remove_OnComponentDestroy(value:  val_15);
            bool val_14 = this.isFinished;
            if((val_14 & 255) == true)
            {
                    return;
            }
            
            val_14 = val_14 >> 32;
            val_15 = val_14 + 1;
            this.destroyedCrystalCount = val_15;
            if(val_15 < this.crystals.Length)
            {
                    return;
            }
            
            this.isFinished = true;
            TzarGames.Endless.Quests.CloseNewWorldPortalQuest val_3 = this.getQuest();
            val_3.<QuestCompleted>k__BackingField = true;
            val_16 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 != val_16)
            {
                    val_16 = val_16.SelectedCharacter;
                var val_15 = 0;
                val_15 = val_15 + 1;
                val_17 = val_16;
                int val_8 = TzarGames.Endless.Quests.CloseNewWorldPortalQuest.GetSceneNumber(data:  val_16);
                var val_10 = ((val_8 + 1) >= val_3.newWorldSceneNames.Length) ? 0 : (val_8 + 1);
                TzarGames.Endless.Quests.CloseNewWorldPortalQuest.SetSceneNumber(data:  val_8, num:  val_16);
                var val_16 = 0;
                val_16 = val_16 + 1;
                val_18 = val_16;
                var val_17 = 0;
                val_17 = val_17 + 1;
                val_19 = val_16;
                TzarGames.Endless.Quests.QuestUtils.SetStageQuestData(data:  val_16, stageNum:  val_16, quest:  val_16);
            }
            
            this.showMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.onQuestCompleted.Invoke();
        }
        private TzarGames.Endless.Quests.CloseNewWorldPortalQuest getQuest()
        {
            TzarGames.Endless.Quests.CloseNewWorldPortalQuest val_8;
            var val_9;
            val_8 = this;
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    val_8 = TzarGames.Endless.EndlessGameState.Instance;
                val_9 = 0;
                if(val_8.CurrentQuest == null)
            {
                    return (TzarGames.Endless.Quests.CloseNewWorldPortalQuest);
            }
            
                val_9 = 0;
                return (TzarGames.Endless.Quests.CloseNewWorldPortalQuest);
            }
            
            val_9 = 0;
            if(0 == this.debugQuest)
            {
                    return (TzarGames.Endless.Quests.CloseNewWorldPortalQuest);
            }
            
            val_8 = this.debugQuest;
            val_9 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            return (TzarGames.Endless.Quests.CloseNewWorldPortalQuest);
        }
        private void showMessage(string message)
        {
            TzarGames.Endless.UI.NotificationBehaviour val_5 = this._notificationBehaviour;
            if(0 == val_5)
            {
                    val_5 = this.gameObject.AddComponent<TzarGames.Endless.UI.NotificationBehaviour>();
                this._notificationBehaviour = val_5;
                val_5.SetConstantMessage(message:  message);
            }
            
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().ShowAlert(message:  message);
        }
        public void Teleport()
        {
            var val_4;
            if(this.isFinished == false)
            {
                goto label_1;
            }
            
            TzarGames.GameFramework.GameManager val_1 = TzarGames.GameFramework.GameManager.Instance;
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_4 = null;
            val_4 = null;
            val_1 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_4) ? (val_1) : 0;
            goto label_8;
            label_1:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_4:
            label_8:
            0.SaveGameWithPlayerData();
            TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.SetImmobilizedState(immobilized:  true);
            TzarGames.Endless.EndlessGameState.Instance.LoadCurrentStageLevel();
        }
    
    }

}
