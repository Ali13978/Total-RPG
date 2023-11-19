using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessGameManager_Deathmatch : EndlessStoryGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private float matchTime;
        [UnityEngine.SerializeField]
        private float respawnTime;
        [UnityEngine.SerializeField]
        private bool autoRestartMatch;
        private TzarGames.Endless.EndlessGameManager_Deathmatch.MatchState data;
        
        // Properties
        public float MatchTime { get; }
        public double CurrentMatchTime { get; }
        
        // Methods
        public EndlessGameManager_Deathmatch()
        {
            mem2[0] = 1133903872;
            this.data = new EndlessGameManager_Deathmatch.MatchState();
        }
        public float get_MatchTime()
        {
            return (float)this.matchTime;
        }
        public double get_CurrentMatchTime()
        {
            if(this.CurrentState == null)
            {
                    return (double)val_3;
            }
            
            this = this.data;
            double val_3 = this.data.MatchStartTime;
            val_3 = TzarGames.GameFramework.GameManagerNetSyncBase.NetworkTime - val_3;
            return (double)val_3;
        }
        public bool IsWaitingForMatch()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsInMatch()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsMatchEnded()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        protected override void OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            var val_3;
            this.OnCharacterDead(deadEventData:  deadEventData);
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameManager_Deathmatch.DeathmatchBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? (val_1) : 0;
            goto (StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameManager_Deathmatch.DeathmatchBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_3 ? val_1 : 0 + 400;
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            var val_3;
            this.PostSpawnPlayerObject(player:  player);
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameManager_Deathmatch.DeathmatchBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? (val_1) : 0;
            goto (StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameManager_Deathmatch.DeathmatchBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_3 ? val_1 : 0 + 448;
        }
        protected override System.Collections.IEnumerator HandlePlayerExit(TzarGames.GameFramework.Player player)
        {
            var val_2;
            var val_3;
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_2 = null;
                val_2 = null;
                val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + (EndlessGameManager_Deathmatch.DeathmatchBaseState.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_2) ? (val_1) : 0;
                return this.HandlePlayerExit(player:  player);
            }
            
            val_3 = 0;
            return this.HandlePlayerExit(player:  player);
        }
        protected override System.Collections.IEnumerator HandlePlayerEnter(TzarGames.GameFramework.Player player)
        {
            var val_3;
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameManager_Deathmatch.DeathmatchBaseState.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? (val_1) : 0;
            return this.HandlePlayerEnter(player:  player);
        }
        [TzarRPC]
        protected void client_match_start(byte[] matchData)
        {
            bool val_1 = this.OnServer;
            if(val_1 != false)
            {
                    return;
            }
            
            string val_3 = TzarGames.Common.Utils.GetStringFromBytes(bytes:  val_1);
            this.data = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            bool val_5 = this.GotoState<EndlessGameManager_Deathmatch.Match>(stateData:  0);
        }
        [TzarRPC]
        protected void client_match_end()
        {
            bool val_1 = this.GotoState<EndlessGameManager_Deathmatch.MatchEnd>(stateData:  0);
        }
        [TzarRPC]
        protected void client_set_player_score(TzarGames.GameFramework.NetworkPlayer networkPlayer, int score)
        {
            int val_6;
            TzarGames.GameFramework.NetworkPlayer val_7;
            val_6 = score;
            val_7 = networkPlayer;
            if(val_7 == null)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_2 = this.Net.GetPlayerByNetPlayer(netPlayer:  val_7);
            if(val_2 == null)
            {
                goto label_3;
            }
            
            val_7 = this.data.GetPlayerData(player:  val_2);
            if(val_7 != null)
            {
                goto label_5;
            }
            
            EndlessGameManager_Deathmatch.PlayerData val_4 = null;
            val_7 = val_4;
            val_4 = new EndlessGameManager_Deathmatch.PlayerData(player:  val_2);
            this.data.PlayerDatas.Add(item:  val_7);
            if(null == 0)
            {
                goto label_8;
            }
            
            label_5:
            typeof(EndlessGameManager_Deathmatch.PlayerData).__il2cppRuntimeField_14 = val_6;
            return;
            label_3:
            val_6 = 0 + "Failed to find player by networkPlayer: "("Failed to find player by networkPlayer: ");
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_8:
        }
        private void Update()
        {
            if(this.CurrentState == null)
            {
                
            }
        
        }
        [TzarGames.Common.ConsoleCommand]
        [UnityEngine.ContextMenu]
        public void RestartDeathmatch()
        {
            if(this.OnServer == false)
            {
                    return;
            }
            
            bool val_2 = this.GotoState<EndlessGameManager_Deathmatch.Match>(stateData:  0);
        }
    
    }

}
