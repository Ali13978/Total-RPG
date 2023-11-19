using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class DestroyCrystalsQuestBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PortalBehaviour[] portals;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onQuestFinished;
        private TzarGames.Endless.UI.NotificationBehaviour _notificationBehaviour;
        private TzarGames.Endless.ObjectDistanceIndicator _indicator;
        private bool isFinished;
        private int destroyedPortalsCount;
        
        // Methods
        public DestroyCrystalsQuestBehaviour()
        {
        
        }
        private void Start()
        {
            var val_17;
            var val_18;
            string val_19;
            var val_20;
            var val_21;
            val_17 = 0;
            goto label_1;
            label_7:
            SetActive(value:  true);
            val_17 = 1;
            label_1:
            if(val_17 >= this.portals.Length)
            {
                goto label_3;
            }
            
            if(this.portals[1].gameObject != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_3:
            val_18 = 0;
            if(TzarGames.Endless.EndlessGameState.Instance.CurrentQuest != null)
            {
                    val_18 = 0;
            }
            
            TzarGames.Endless.UI.NotificationBehaviour val_6 = this.gameObject.AddComponent<TzarGames.Endless.UI.NotificationBehaviour>();
            this._notificationBehaviour = val_6;
            val_19 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            val_6.SetConstantMessage(message:  val_19);
            TzarGames.Endless.ObjectDistanceIndicator val_9 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.GetComponentInChildren<TzarGames.Endless.ObjectDistanceIndicator>();
            this._indicator = val_9;
            if(0 == val_9)
            {
                goto label_18;
            }
            
            val_19 = mem[(TzarGames.Endless.Quests.EndlessQuest.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.Quests.DestroyCrystalQuest.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_3 : 0 + 128];
            val_19 = (TzarGames.Endless.Quests.EndlessQuest.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.Quests.DestroyCrystalQuest.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_3 : 0 + 128;
            this._indicator.<Icon>k__BackingField = val_19;
            val_20 = 0;
            goto label_23;
            label_29:
            val_19.AddObservingObject(obj:  null);
            val_20 = 1;
            label_23:
            if(val_20 >= val_11.Length)
            {
                goto label_25;
            }
            
            UnityEngine.Transform val_12 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1].transform;
            if(this._indicator != null)
            {
                goto label_29;
            }
            
            goto label_29;
            label_18:
            UnityEngine.Debug.LogError(message:  0);
            label_25:
            val_21 = 0;
            goto label_34;
            label_42:
            val_21 = 1;
            mem2[0] = val_19;
            label_34:
            if(val_21 >= val_13.Length)
            {
                goto label_36;
            }
            
            T val_19 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1];
            System.Action<TzarGames.Endless.EndlessSpawner> val_14 = new System.Action<TzarGames.Endless.EndlessSpawner>(object:  this, method:  System.Void TzarGames.Endless.Quests.DestroyCrystalsQuestBehaviour::Spawner_OnWaveFinished(TzarGames.Endless.EndlessSpawner obj));
            if(((System.Delegate.Combine(a:  0, b:  val_13[0x1][0] + 200)) == null) || (null == null))
            {
                goto label_42;
            }
            
            goto label_42;
            label_36:
            this.onQuestStarted.Invoke();
        }
        private void Spawner_OnWaveFinished(TzarGames.Endless.EndlessSpawner obj)
        {
            uint val_8;
            var val_9;
            val_8 = obj;
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_4 = val_1.SelectedCharacter;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = val_4;
            if(val_4 != null)
            {
                    mem2[0] = null;
            }
            else
            {
                    mem[36] = 1;
            }
            
            if(36 >= val_8.WaveCount)
            {
                    return;
            }
            
            val_8 = val_8.WaveCount;
            mem2[0] = val_8;
        }
        public void NotifyPortalDestroyed(TzarGames.Endless.Quests.CrystalPortal portal)
        {
            TzarGames.Endless.ObjectDistanceIndicator val_5 = this._indicator;
            if(0 != val_5)
            {
                    val_5 = this._indicator;
                val_5.RemoveObservingObject(obj:  portal.transform);
            }
            
            bool val_4 = this.isFinished;
            if((val_4 & 255) == true)
            {
                    return;
            }
            
            val_4 = val_4 >> 32;
            val_5 = val_4 + 1;
            this.destroyedPortalsCount = val_5;
            if(val_5 < this.portals.Length)
            {
                    return;
            }
            
            this.finishQuest();
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
            
            this.isFinished = true;
            if(0 != this._indicator)
            {
                    this._indicator.<Icon>k__BackingField = 0;
                this._indicator = 0;
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
    
    }

}
