using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessGameManager : TH_GameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClass defaultClass;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClassInfo playerClassInfo;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, byte[]> playersData;
        
        // Properties
        public static TzarGames.Endless.PlayerCharacter LocalPlayerCharacter { get; }
        public static TzarGames.Endless.EndlessGameState GameState { get; }
        
        // Methods
        public EndlessGameManager()
        {
            this.playersData = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, System.Byte[]>();
        }
        public static TzarGames.Endless.PlayerCharacter get_LocalPlayerCharacter()
        {
            UnityEngine.Object val_7;
            var val_8;
            val_7 = TzarGames.GameFramework.GameManager.Instance;
            val_8 = 0;
            if(0 == val_7)
            {
                    return (TzarGames.Endless.PlayerCharacter);
            }
            
            val_7 = TzarGames.GameFramework.GameManager.Instance.LocalPlayer;
            val_8 = 0;
            return (TzarGames.Endless.PlayerCharacter);
        }
        public TzarGames.Endless.ICharacterInfo GetCharacterInfoByPlayer(TzarGames.GameFramework.Player player)
        {
            TzarGames.Endless.EndlessGameState val_5;
            var val_6;
            val_5 = player;
            val_6 = 0;
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return (TzarGames.Endless.ICharacterInfo)val_6;
            }
            
            val_6 = 0;
            if(val_5.itsMe == false)
            {
                    return (TzarGames.Endless.ICharacterInfo)val_6;
            }
            
            val_5 = TzarGames.Endless.EndlessGameState._instance;
            if(null != 0)
            {
                    TzarGames.Endless.EndlessCharacterData val_4 = SelectedCharacter;
                return (TzarGames.Endless.ICharacterInfo)val_6;
            }
            
            val_6 = 0;
            return (TzarGames.Endless.ICharacterInfo)val_6;
        }
        public static TzarGames.Endless.PlayerCharacter GetPlayerCharacterByCharacterInfo(TzarGames.Endless.ICharacterInfo characterInfo)
        {
            return TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
        }
        public void AddRubyToPlayer(TzarGames.GameFramework.Player player, int count)
        {
            var val_5;
            var val_6;
            if(player.itsMe == false)
            {
                goto label_2;
            }
            
            if(null == 0)
            {
                goto label_5;
            }
            
            val_6 = SelectedCharacter;
            if(val_6 != null)
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            val_6 = 0;
            label_7:
            val_5 = 0;
            label_6:
            if(mem[282584257676929] == 0)
            {
                goto ((val_5 + ((mem[282584257676823] + 8) + 5)) + 272);
            }
            
            var val_4 = mem[282584257676823];
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_10:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < mem[282584257676929])
            {
                goto label_10;
            }
            
            goto ((val_5 + ((mem[282584257676823] + 8) + 5)) + 272);
            label_9:
            var val_6 = val_4;
            val_6 = val_6 + 5;
            val_5 = val_5 + val_6;
            val_5 = val_5 + 272;
            goto ((val_5 + ((mem[282584257676823] + 8) + 5)) + 272);
            label_2:
            System.NotImplementedException val_3 = new System.NotImplementedException();
        }
        public static TzarGames.Endless.EndlessGameState get_GameState()
        {
            return (TzarGames.Endless.EndlessGameState)TzarGames.Endless.EndlessGameState._instance;
        }
        protected override void Awake()
        {
            this.Awake();
            TzarGames.Endless.SocialSystem val_1 = TzarGames.Endless.SocialSystem.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            string val_3 = val_1.GetUserName();
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player.ChangeLogin(player:  0, newLogin:  this.LocalPlayer);
        }
        public static void SetHeroDataToGameState()
        {
            var val_2;
            TzarGames.Endless.EndlessHeroData val_2 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            val_2 = 0;
            TzarGames.Endless.EndlessGameState._instance.SetHeroData(data:  null);
        }
        public override void GetPlayerData(TzarGames.GameFramework.Player player, System.Action<byte[]> getDataMethod)
        {
            if(getDataMethod != null)
            {
                    this.getPlayerDataInternal(player:  player, getDataHandler:  getDataMethod);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        private void getPlayerDataInternal(TzarGames.GameFramework.Player player, System.Action<byte[]> getDataHandler)
        {
            TzarGames.GameFramework.Player val_17;
            TzarGames.Endless.EndlessHeroData val_18;
            var val_19;
            var val_20;
            val_17 = player;
            if(val_17.itsMe == false)
            {
                goto label_2;
            }
            
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                goto label_6;
            }
            
            val_18 = TzarGames.Endless.EndlessGameState._instance.GetHeroData();
            if(val_18 != null)
            {
                    if(val_3.IsInitialized == true)
            {
                goto label_10;
            }
            
            }
            
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_4 = this.playerClassInfo.GetClassTemplate(classType:  this.defaultClass);
            val_18 = TzarGames.Endless.EndlessHeroData.CreateDefault(classType:  0, template:  this.defaultClass);
            TzarGames.Endless.EndlessGameState._instance.SetHeroData(data:  val_18);
            label_10:
            if(this.Connected == false)
            {
                goto label_35;
            }
            
            val_19 = 0;
            goto label_20;
            label_2:
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.getOtherPlayerData(player:  val_17, getDataHandler:  getDataHandler));
            return;
            label_6:
            val_17 = player.PlayerComponent;
            if(val_17 == null)
            {
                goto label_22;
            }
            
            val_20 = null;
            val_20 = null;
            var val_10 = (((TzarGames.GameFramework.IPlayerComponent.__il2cppRuntimeField_typeHierarchy + TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_20) ? (val_17) : 0;
            val_18 = 0;
            val_18 = 0;
            goto label_35;
            label_22:
            UnityEngine.Debug.Log(message:  0);
            val_17 = this.playerClassInfo;
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_11 = val_17.GetClassTemplate(classType:  this.defaultClass);
            val_18 = TzarGames.Endless.EndlessHeroData.CreateDefault(classType:  0, template:  this.defaultClass);
            goto label_35;
            label_20:
            bool val_15 = UnityEngine.Object.op_Inequality(x:  0, y:  null);
            label_35:
            getDataHandler.Invoke(obj:  TzarGames.Endless.EndlessHeroData.GetBytesFromData(data:  0));
        }
        public override void SetPlayerData(TzarGames.GameFramework.Player player, byte[] data, System.Action completeCallback)
        {
            completeCallback.Invoke();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator getOtherPlayerData(TzarGames.GameFramework.Player player, System.Action<byte[]> getDataHandler)
        {
            if(null != 0)
            {
                    typeof(EndlessGameManager.<getOtherPlayerData>c__Iterator0).__il2cppRuntimeField_18 = player;
                typeof(EndlessGameManager.<getOtherPlayerData>c__Iterator0).__il2cppRuntimeField_20 = getDataHandler;
            }
            else
            {
                    mem[24] = player;
                mem[32] = getDataHandler;
            }
            
            typeof(EndlessGameManager.<getOtherPlayerData>c__Iterator0).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public override void HandleConnectedToServerEvent()
        {
            this.HandleConnectedToServerEvent();
            this.getPlayerDataInternal(player:  this.LocalPlayer, getDataHandler:  new System.Action<System.Byte[]>(object:  this, method:  System.Void TzarGames.Endless.EndlessGameManager::<HandleConnectedToServerEvent>m__0(byte[] data)));
        }
        protected override System.Collections.IEnumerator HandlePlayerExit(TzarGames.GameFramework.Player player)
        {
            System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, System.Byte[]> val_3 = this.playersData;
            if((val_3.ContainsKey(key:  player)) == false)
            {
                    return this.HandlePlayerExit(player:  player);
            }
            
            val_3 = this.playersData;
            bool val_2 = val_3.Remove(key:  player);
            return this.HandlePlayerExit(player:  player);
        }
        [TzarRPC]
        protected void server_sendPlayerData(byte[] playerData, TzarGames.GameFramework.INetworkMessageInfo messageInfo)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = messageInfo;
            TzarGames.GameFramework.Player val_3 = this.Net.GetPlayerByNetPlayer(netPlayer:  messageInfo);
            if(val_3 == null)
            {
                    return;
            }
            
            this.playersData.Add(key:  val_3, value:  playerData);
        }
        public void FinishTutorial()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.finishTutorialRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator finishTutorialRoutine()
        {
            typeof(EndlessGameManager.<finishTutorialRoutine>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void StopPlayerMovement()
        {
            TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.SetImmobilizedState(immobilized:  true);
        }
        public void ResumePlayerMovement()
        {
            TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.SetImmobilizedState(immobilized:  false);
        }
        public void SaveGameWithPlayerData()
        {
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
            TzarGames.Endless.EndlessGameState._instance.SaveGame();
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            var val_5;
            this.PostSpawnPlayerObject(player:  player);
            if(player.itsMe == false)
            {
                    return;
            }
            
            val_5 = 0;
            if(0 == )
            {
                    return;
            }
            
            add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.EndlessGameManager::OnPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        }
        protected override void OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            var val_14;
            TzarGames.Endless.EndlessGameState val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            this.OnCharacterDead(deadEventData:  deadEventData);
            val_14 = 1152921504721543168;
            val_15 = TzarGames.Endless.EndlessGameState._instance;
            if(0 == val_15)
            {
                    return;
            }
            
            val_15 = deadEventData.Killer;
            if(0 == val_15)
            {
                    return;
            }
            
            if(val_15 == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_4 = val_15.PlayerOwner;
            val_15 = val_4.GetCharacterInfoByPlayer(player:  val_4);
            if(val_15 == null)
            {
                    return;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = val_15;
            val_14 = val_15;
            if(val_14 != null)
            {
                
            }
            else
            {
                    val_14 = 20;
                val_17 = 1;
            }
            
            mem[20] = 2;
            TzarGames.GameFramework.CharacterTemplate val_7 = deadEventData.Victim.Template;
            if((val_7.HasTag(tag:  "Tag_Boss")) != false)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_18 = val_15;
                val_14 = val_15;
                if(val_14 != null)
            {
                
            }
            else
            {
                    val_14 = 24;
                val_17 = 7254272;
            }
            
                mem[24] = 7254273;
            }
            
            if((val_7.HasTag(tag:  "Tag_Chest")) != false)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_19 = val_15;
                val_14 = val_15;
                if(val_14 != null)
            {
                
            }
            else
            {
                    val_14 = 32;
                val_17 = 64;
            }
            
                mem[32] = 65;
            }
            
            if((val_7.HasTag(tag:  "Tag_Destroyable")) == false)
            {
                    return;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_20 = val_15;
            val_15 = val_15;
            if(val_15 != null)
            {
                
            }
            else
            {
                    val_15 = 28;
                val_21 = 0;
            }
            
            mem[28] = 1;
        }
        private void OnPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            var val_11;
            var val_12;
            var val_13;
            TzarGames.TzarHero.TH_Character val_14;
            var val_15;
            var val_16;
            var val_17;
            object val_18;
            var val_19;
            var val_20;
            val_11 = deadEventData;
            val_12 = 1152921504721543168;
            if(val_11 == null)
            {
                    return;
            }
            
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return;
            }
            
            val_13 = 0;
            if(0 == deadEventData.Victim)
            {
                    return;
            }
            
            val_14 = deadEventData.Victim;
            TzarGames.GameFramework.Player val_5 = val_14.PlayerOwner;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            val_15 = val_5.GetCharacterInfoByPlayer(player:  val_5);
            if(val_15 == null)
            {
                goto label_11;
            }
            
            val_12 = 1152921504863608832;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = 8;
            val_16 = val_15;
            goto label_15;
            label_10:
            val_17 = "Player owner is null";
            val_18 = 0;
            goto label_18;
            label_11:
            val_17 = "Faield to get character info";
            val_18 = 0;
            label_18:
            UnityEngine.Debug.LogError(message:  val_18);
            return;
            label_15:
            if((val_15 & 1) == 0)
            {
                    return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = 10;
            val_19 = val_15;
            TzarGames.Endless.EndlessGameState._instance.SaveGame();
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_20 = val_15;
            string val_10 = 0 + "HARDCORE DEAD: "("HARDCORE DEAD: ");
            UnityEngine.Debug.Log(message:  0);
        }
        public virtual void RespawnPlayer(TzarGames.GameFramework.Player player, float hitPointsMultiplier)
        {
            var val_15;
            var val_16;
            var val_17;
            TzarGames.Endless.ICharacterInfo val_1 = this.GetCharacterInfoByPlayer(player:  player);
            if(val_1 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_15 = val_1;
                if((val_1 & 1) != 0)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            }
            
            string val_3 = player.Login;
            string val_4 = 0 + "Respawning player ";
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Vector3 val_6 = player.PlayerObject.transform.position;
            UnityEngine.Quaternion val_8 = player.PlayerObject.transform.rotation;
            this.RespawnPlayerObject(player:  player, position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
            val_16 = 0;
            if(0 == )
            {
                    return;
            }
            
            val_17 = TemplateInstance;
            float val_14 = TemplateInstance.HitPoints;
            val_14 = val_14 * hitPointsMultiplier;
            ActualHitPoints = val_14;
        }
        public void TeleportPlayerObject(TzarGames.GameFramework.Player player, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
        {
            0.Position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            0.transform.rotation = new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w};
        }
        private void <HandleConnectedToServerEvent>m__0(byte[] data)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = data;
            this.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall<System.Byte[], TzarGames.GameFramework.INetworkMessageInfo>(object:  this, method:  System.Void TzarGames.Endless.EndlessGameManager::server_sendPlayerData(byte[] playerData, TzarGames.GameFramework.INetworkMessageInfo messageInfo)), rpcMode:  5, parameters:  null);
        }
    
    }

}
