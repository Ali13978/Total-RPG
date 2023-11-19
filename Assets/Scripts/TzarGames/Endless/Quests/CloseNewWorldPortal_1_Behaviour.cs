using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class CloseNewWorldPortal_1_Behaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PortalBehaviour[] portals;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.CloseNewWorldPortalQuest debugQuest;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestFinished;
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        private bool isFinished;
        private int destroyedPortalsCount;
        private TzarGames.Endless.Quests.CloseNewWorldPortalQuest quest;
        
        // Methods
        public CloseNewWorldPortal_1_Behaviour()
        {
        
        }
        private void Start()
        {
            var val_17;
            var val_18;
            TzarGames.Endless.Quests.CloseNewWorldPortalQuest val_20;
            var val_21;
            var val_22;
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 != val_1)
            {
                    if(val_1 != null)
            {
                    val_1.BlockAllGates(blocked:  false);
                val_1.DisableAllRooms();
            }
            else
            {
                    val_1.BlockAllGates(blocked:  false);
                val_1.DisableAllRooms();
            }
            
                val_1.DisableWay = true;
            }
            
            val_17 = 0;
            goto label_6;
            label_14:
            X22.SetActive(value:  false);
            X21.SetCrystalState(enable:  false);
            val_17 = 1;
            label_6:
            if(val_17 >= this.portals.Length)
            {
                goto label_8;
            }
            
            this.portals[1].gameObject.SetActive(value:  true);
            if(this.portals[0x1][0].enemySpawnTrigger != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_8:
            TzarGames.Endless.Quests.CloseNewWorldPortalQuest val_4 = this.getQuest();
            this.quest = val_4;
            if((val_4.<QuestCompleted>k__BackingField) == false)
            {
                goto label_16;
            }
            
            val_18 = 0;
            goto label_17;
            label_25:
            val_4.Invoke();
            val_18 = 1;
            label_17:
            if(val_18 >= this.portals.Length)
            {
                goto label_19;
            }
            
            TzarGames.Endless.PortalBehaviour val_18 = this.portals[1];
            this.portals[0x1][0].newWorldPortal.SetActive(value:  false);
            if(this.portals[0x1][0].portal.onDeactivated != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_19:
            if(0 != val_1)
            {
                    val_1.ActivateFinishTriggers(activate:  true);
            }
            
            TzarGames.Endless.PortalBehaviour val_19 = this.portals[(long)UnityEngine.Random.Range(min:  0, max:  0)];
            this.showMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            if((this.portals[(long)UnityEngine.Random.Range(min:  0, max:  0)]) == null)
            {
                goto label_37;
            }
            
            TzarGames.Endless.PlayerCharacter val_8 = TzarGames.Endless.EndlessGameManager.GetPlayerCharacterByCharacterInfo(characterInfo:  0);
            goto label_39;
            label_16:
            val_20 = this.quest;
            this.showMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            val_21 = 0;
            goto label_41;
            label_49:
            val_20.Invoke();
            val_21 = 1;
            label_41:
            if(val_21 >= this.portals.Length)
            {
                goto label_43;
            }
            
            TzarGames.Endless.PortalBehaviour val_20 = this.portals[1];
            this.portals[0x1][0].newWorldPortal.SetActive(value:  true);
            if(this.portals[0x1][0].portal.onDeactivated != null)
            {
                goto label_49;
            }
            
            goto label_49;
            label_43:
            if(0 == val_1)
            {
                goto label_54;
            }
            
            val_1.ActivateFinishTriggers(activate:  false);
            goto label_54;
            label_37:
            UnityEngine.Debug.Log(message:  0);
            label_39:
            TzarGames.GameFramework.GameManager val_12 = TzarGames.GameFramework.GameManager.Instance;
            val_20 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.PlayerOwner;
            UnityEngine.Vector3 val_14 = this.portals[(long)(int)(val_6)][0].portal.playerSpawnPosition.position;
            UnityEngine.Quaternion val_15 = this.portals[(long)(int)(val_6)][0].portal.playerSpawnPosition.rotation;
            if(val_12 != null)
            {
                    val_22 = null;
                val_22 = null;
                var val_16 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_22) ? (val_12) : 0;
            }
            
            0.TeleportPlayerObject(player:  val_20, position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, rotation:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w});
            label_54:
            this.onQuestStarted.Invoke();
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
        public void Teleport(TzarGames.TzarHero.TH_Character character)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(this.isFinished != false)
            {
                    return;
            }
            
            if(0 == this.quest)
            {
                    this.quest = this.getQuest();
            }
            
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                goto label_7;
            }
            
            TzarGames.Endless.ICharacterInfo val_6 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_6;
            goto label_13;
            label_7:
            val_13 = 0;
            goto label_14;
            label_13:
            val_13 = TzarGames.Endless.Quests.CloseNewWorldPortalQuest.GetSceneNumber(data:  val_6);
            label_14:
            if(val_13 >= this.quest.newWorldSceneNames.Length)
            {
                    UnityEngine.Debug.LogError(message:  0);
                val_13 = 0;
            }
            
            TzarGames.GameFramework.GameManager val_9 = TzarGames.GameFramework.GameManager.Instance;
            val_14 = val_9;
            if(val_14 != null)
            {
                    val_15 = null;
                val_15 = null;
                val_9 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_15) ? (val_14) : 0;
            }
            
            0.SaveGameWithPlayerData();
            if(character != null)
            {
                    val_14 = 1152921504871968768;
                val_16 = null;
                val_16 = null;
                var val_10 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_16) ? character : 0;
            }
            
            0.SetImmobilizedState(immobilized:  true);
            TzarGames.Endless.EndlessGameState.Instance.LoadSceneAsync(sceneName:  this.quest.newWorldSceneNames[0]);
        }
    
    }

}
