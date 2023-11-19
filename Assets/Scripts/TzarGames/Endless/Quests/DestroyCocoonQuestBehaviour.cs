using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class DestroyCocoonQuestBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Canvas questCanvas;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestFinished;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> cocoons;
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        private TzarGames.Endless.ObjectDistanceIndicator _indicator;
        private bool isFinished;
        private int cocoonCounter;
        private int cocoonMaxCount;
        private TzarGames.Endless.PlayerCharacter localPlayerCharacter;
        
        // Methods
        public DestroyCocoonQuestBehaviour()
        {
        
        }
        private void Start()
        {
            var val_3;
            var val_34;
            TzarGames.Endless.ObjectDistanceIndicator val_35;
            var val_36;
            this.cocoonMaxCount = this.cocoonCounter;
            this.updateText();
            List.Enumerator<T> val_1 = this.cocoons.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            if(0 == val_4)
            {
                goto label_5;
            }
            
            TH_Character.dlgDeadEvent val_6 = new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::<Start>m__0(TzarGames.TzarHero.DeadEventData data));
            val_4.add_OnCharacterDead(value:  null);
            goto label_7;
            label_2:
            val_3.Dispose();
            if(0 == this.questCanvas)
            {
                    this.questCanvas = this.GetComponentInChildren<UnityEngine.Canvas>();
            }
            
            if(0 != TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter)
            {
                    TzarGames.Endless.PlayerCharacter val_11 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
                this.localPlayerCharacter = val_11;
                val_11.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::LocalPlayerCharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
                this.localPlayerCharacter.add_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::LocalPlayerCharacterOnOnCharacterAlive(TzarGames.TzarHero.TH_Character thCharacter)));
            }
            else
            {
                    TzarGames.GameFramework.GameManager.Instance.OnLocalPlayerObjectSpawned.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::onLocalPlayerObjectSpawned(TzarGames.GameFramework.Player player)));
            }
            
            val_34 = 0;
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    val_34 = 0;
                if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    val_34 = 0;
            }
            
            }
            
            this._notificationBehaviour = this.gameObject.AddComponent<TzarGames.Endless.UI.NotificationBehaviour>();
            if(0 != )
            {
                    this._notificationBehaviour.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            }
            else
            {
                    UnityEngine.Debug.LogWarning(message:  0);
            }
            
            val_35 = this.localPlayerCharacter.GetComponentInChildren<TzarGames.Endless.ObjectDistanceIndicator>();
            this._indicator = val_35;
            if(0 == val_35)
            {
                goto label_42;
            }
            
            if(0 == )
            {
                goto label_45;
            }
            
            val_36 = 0;
            this._indicator.<Icon>k__BackingField = (TzarGames.Endless.Quests.EndlessQuest.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.Quests.DestroyCocoonQuest.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_20 : 0 + 128;
            goto label_52;
            label_42:
            UnityEngine.Debug.LogError(message:  0);
            goto label_54;
            label_45:
            val_36 = 0;
            goto label_52;
            label_62:
            val_36 = 1;
            label_52:
            val_35 = this.cocoons;
            if(val_36 >= val_35.Count)
            {
                goto label_54;
            }
            
            TzarGames.TzarHero.TH_Character val_30 = this.cocoons.Item[1];
            if(0 == val_30)
            {
                goto label_62;
            }
            
            this._indicator.AddObservingObject(obj:  val_30.transform);
            val_30.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::<Start>m__1(TzarGames.TzarHero.DeadEventData data)));
            goto label_62;
            label_54:
            this.onQuestStarted.Invoke();
            return;
            label_5:
            val_3.Dispose();
        }
        private void onLocalPlayerObjectSpawned(TzarGames.GameFramework.Player player)
        {
            var val_4 = 0;
            add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::LocalPlayerCharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
            add_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::LocalPlayerCharacterOnOnCharacterAlive(TzarGames.TzarHero.TH_Character thCharacter)));
        }
        private void OnDestroy()
        {
            if(0 != this.localPlayerCharacter)
            {
                    this.localPlayerCharacter.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::LocalPlayerCharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
                this.localPlayerCharacter.remove_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::LocalPlayerCharacterOnOnCharacterAlive(TzarGames.TzarHero.TH_Character thCharacter)));
            }
            
            if(0 == TzarGames.GameFramework.GameManager.Instance)
            {
                    return;
            }
            
            TzarGames.GameFramework.GameManager.Instance.OnLocalPlayerObjectSpawned.RemoveListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCocoonQuestBehaviour::onLocalPlayerObjectSpawned(TzarGames.GameFramework.Player player)));
        }
        private void LocalPlayerCharacterOnOnCharacterAlive(TzarGames.TzarHero.TH_Character thCharacter)
        {
            if(0 == this.questCanvas)
            {
                    return;
            }
            
            this.questCanvas.gameObject.SetActive(value:  true);
        }
        private void LocalPlayerCharacterOnOnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            if(0 == this.questCanvas)
            {
                    return;
            }
            
            this.questCanvas.gameObject.SetActive(value:  false);
        }
        private void updateText()
        {
            int val_4 = this.cocoons.Count;
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().HUD.QuestInfoText.text = System.String.Format(format:  0, arg0:  "{0}/{1}", arg1:  this.cocoonCounter);
        }
        private void finishQuest()
        {
            var val_11;
            var val_12;
            var val_13;
            if(this.isFinished != false)
            {
                    return;
            }
            
            if(0 != this._indicator)
            {
                    this._indicator.<Icon>k__BackingField = 0;
            }
            
            val_11 = 0;
            if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    val_11 = 0;
            }
            
            TzarGames.Endless.ICharacterInfo val_6 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            if(0 != )
            {
                    mem2[0] = 1;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_12 = val_6;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = val_6;
            TzarGames.Endless.Quests.QuestUtils.SetStageQuestData(data:  val_6, stageNum:  val_6, quest:  val_6);
            this._notificationBehaviour.SetConstantMessage(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.onQuestFinished.Invoke();
        }
        private void <Start>m__0(TzarGames.TzarHero.DeadEventData data)
        {
            int val_6 = this.cocoonCounter;
            val_6 = val_6 + 1;
            this.cocoonCounter = val_6;
            this.updateText();
            List.Enumerator<T> val_1 = this.cocoons.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if((0 == val_2) || (val_2.isDead == true))
            {
                goto label_7;
            }
            
            0.Dispose();
            return;
            label_2:
            0.Dispose();
            this.finishQuest();
        }
        private void <Start>m__1(TzarGames.TzarHero.DeadEventData data)
        {
            this._indicator.RemoveObservingObject(obj:  data.Victim.transform);
        }
    
    }

}
