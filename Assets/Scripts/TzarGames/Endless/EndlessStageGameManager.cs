using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessStageGameManager : EndlessStoryGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool useDebugWayNumber;
        [UnityEngine.SerializeField]
        private int debugWayNumber;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private System.Collections.Generic.List<TzarGames.Endless.Way> ways;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <DisableWay>k__BackingField;
        private TzarGames.Endless.Way selectedWay;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, TzarGames.Endless.PlayerCharacter> playerCharacterMap;
        
        // Properties
        public bool DisableWay { get; set; }
        public System.Collections.Generic.List<TzarGames.Endless.Way> Ways { get; }
        public TzarGames.Endless.Way SelectedWay { get; }
        
        // Methods
        public EndlessStageGameManager()
        {
            this.playerCharacterMap = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, TzarGames.Endless.PlayerCharacter>();
            this = new TzarGames.Endless.EndlessGameManager();
        }
        public bool get_DisableWay()
        {
            return (bool)this.<DisableWay>k__BackingField;
        }
        public void set_DisableWay(bool value)
        {
            this.<DisableWay>k__BackingField = value;
        }
        public System.Collections.Generic.List<TzarGames.Endless.Way> get_Ways()
        {
            return (System.Collections.Generic.List<TzarGames.Endless.Way>)this.ways;
        }
        public TzarGames.Endless.Way get_SelectedWay()
        {
            return (TzarGames.Endless.Way)this.selectedWay;
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            this.PostSpawnPlayerObject(player:  player);
            TzarGames.Endless.PlayerCharacter val_1 = player.PlayerObject.GetComponent<TzarGames.Endless.PlayerCharacter>();
            this.playerCharacterMap.Add(key:  player, value:  val_1);
            TzarGames.Endless.EndlessPlayerSpawnPoint val_3 = this.selectedWay.PlayerSpawnPoint;
            val_1.PlayerCamera.CameraYaw = val_3.cameraYaw;
            val_1.PlayerCamera.ForceUpdatePosition();
        }
        protected override void PostPlayerExit(TzarGames.GameFramework.Player player)
        {
            this.PostPlayerExit(player:  player);
            bool val_1 = this.playerCharacterMap.Remove(key:  player);
        }
        protected override TzarGames.GameFramework.SpawnPoint GetSpawnPointForPlayer(TzarGames.GameFramework.Player player)
        {
            TzarGames.Endless.Way val_4;
            int val_1 = this.ways.Count;
            val_4 = this.ways.Item[UnityEngine.Random.Range(min:  0, max:  0)];
            this.selectedWay = val_4;
            if((this.<DisableWay>k__BackingField) != true)
            {
                    val_4.Activate();
                val_4 = this.selectedWay;
            }
            
            if(val_4 != null)
            {
                    return val_4.PlayerSpawnPoint;
            }
            
            return val_4.PlayerSpawnPoint;
        }
        public void FinishStage()
        {
            this.finishStageInternal(checkConditions:  false);
        }
        private void finishStageInternal(bool checkConditions)
        {
            if(checkConditions != false)
            {
                    if(this.selectedWay.IsWayFinished == false)
            {
                    return;
            }
            
            }
            
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    TzarGames.Endless.EndlessGameState.Instance.Paused = true;
                this.StopPlayerMovement();
                TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
                UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().ShowStageCompleteMenu(show:  true);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public void BlockAllGates(bool blocked)
        {
            goto label_3;
            label_9:
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            var val_3 = ((val_1[0x1][0] + 24) != 0) ? 1 : 0;
            val_3 = val_3 ^ blocked;
            if(val_3 == false)
            {
                goto label_9;
            }
            
            mem2[0] = blocked;
            UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1].invokeBlockedEvents();
            goto label_9;
        }
        public void ResetFinishTriggers()
        {
            List.Enumerator<T> val_1 = this.ways.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            val_2.FinishTrigger.OnEnterToTrigger.RemoveAllListeners();
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void TzarGames.Endless.EndlessStoryGameManager::SaveAndExitToLobby());
            val_2.FinishTrigger.OnEnterToTrigger.AddListener(call:  null);
            goto label_9;
            label_12:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public void ActivateFinishTriggers(bool activate)
        {
            List.Enumerator<T> val_1 = this.ways.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            0.InitializationCallback.FinishTrigger.gameObject.SetActive(value:  activate);
            goto label_6;
            label_9:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public void DisableAllRooms()
        {
            goto label_3;
            label_27:
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_6 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1];
            if(0 != (val_1[0x1][0] + 32))
            {
                    val_1[0x1][0] + 32 + 192.RemoveAllListeners();
                val_1[0x1][0] + 32.gameObject.SetActive(value:  false);
            }
            
            if(0 == (val_1[0x1][0] + 40))
            {
                goto label_27;
            }
            
            val_1[0x1][0] + 40 + 192.RemoveAllListeners();
            val_1[0x1][0] + 40.gameObject.SetActive(value:  false);
            goto label_27;
        }
        public void ActivateAllRooms()
        {
            var val_9;
            var val_10;
            T[] val_1 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>();
            val_9 = 0;
            goto label_3;
            label_21:
            val_9 = 1;
            label_3:
            if(val_9 >= val_1.Length)
            {
                goto label_5;
            }
            
            T val_9 = val_1[1];
            if(0 != (val_1[0x1][0] + 32))
            {
                    val_1[0x1][0] + 32 + 192.RemoveAllListeners();
            }
            
            if(0 == (val_1[0x1][0] + 40))
            {
                goto label_21;
            }
            
            val_1[0x1][0] + 40 + 192.RemoveAllListeners();
            goto label_21;
            label_5:
            val_10 = 0;
            goto label_22;
            label_41:
            val_10 = 1;
            label_22:
            if(val_10 >= val_1.Length)
            {
                goto label_24;
            }
            
            object val_4 = new System.Object();
            typeof(EndlessStageGameManager.<ActivateAllRooms>c__AnonStorey0).__il2cppRuntimeField_10 = val_1[1];
            if(0 != (val_1[0x1][0] + 32))
            {
                    val_1[0x1][0] + 32 + 192.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_4, method:  System.Void EndlessStageGameManager.<ActivateAllRooms>c__AnonStorey0::<>m__0()));
            }
            
            if(0 == (val_1[0x1][0] + 40))
            {
                goto label_41;
            }
            
            val_1[0x1][0] + 40 + 192.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_4, method:  System.Void EndlessStageGameManager.<ActivateAllRooms>c__AnonStorey0::<>m__1()));
            goto label_41;
            label_24:
            mem[1152921510672489256] = 1;
        }
    
    }

}
