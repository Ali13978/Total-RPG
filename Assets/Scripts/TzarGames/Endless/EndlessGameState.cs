using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessGameState : StateMachine
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessSaveManager saveManager;
        [UnityEngine.SerializeField]
        private string tutorialSceneName;
        [UnityEngine.SerializeField]
        private string mainMenuSceneName;
        [UnityEngine.SerializeField]
        private string lobbySceneName;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.SceneInfo[] promoLevels;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.FloorSceneInfo[] stages;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.EpicBossQuest[] bossQuests;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool doGenuineCheck;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <GenuineCheckFailed>k__BackingField;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private string bundleVersion;
        private static TzarGames.Endless.EndlessGameState _instance;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static bool <IsLoading>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnLoadingStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnLoadingSceneReady;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnLoadingFinished;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnInitializationFinished;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnStageStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnNeedPurchaseFullGame;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnGameContinued;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnMainMenuLoaded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnLobbyLoaded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnGenuineCheckFailed;
        private object lastAttemptGameStateData;
        private System.Type lastAttemptGameStateType;
        private TzarGames.Endless.EndlessSaveData currentSaveGame;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.Quests.EndlessQuest <CurrentQuest>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnGameSaved;
        private bool paused;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <MaxEnemySpawnCount>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredBool GenuineCheckFailed { get; set; }
        public static bool IsLoading { get; set; }
        public TzarGames.Endless.Quests.EndlessQuest CurrentQuest { get; set; }
        public bool Paused { get; set; }
        public static TzarGames.Endless.EndlessGameState Instance { get; }
        public static string MultiplayerVersion { get; }
        public string Version { get; }
        public TzarGames.Endless.ICharacterInfo SelectedCharacter { get; }
        public int MaxLengthOfCharacterName { get; }
        public TzarGames.Endless.ICharacterInfo[] Characters { get; }
        public int CharacterCount { get; }
        public TzarGames.Common.SerializableData CommonSaveGameData { get; }
        public bool IsTutorialCompleted { get; }
        public uint MinimumStageToGoDown { get; }
        public int MaxEnemySpawnCount { get; set; }
        
        // Methods
        public EndlessGameState()
        {
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.doGenuineCheck = val_1;
            mem[1152921510612609312] = val_1.inited;
            mem[1152921510612609313] = val_1.fakeValue;
            mem[1152921510612609314] = val_1.fakeValueActive;
        }
        public static CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_GenuineCheckFailed()
        {
            return new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField, hiddenValue = TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField, inited = TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField.__il2cppRuntimeField_8>>0&0xFF, fakeValue = TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField.__il2cppRuntimeField_8>>8&0xFF, fakeValueActive = TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField.__il2cppRuntimeField_8>>16&0xFF};
        }
        private static void set_GenuineCheckFailed(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value)
        {
            TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField = value.inited;
            TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField.__il2cppRuntimeField_0 = value.fakeValue;
            TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField.__il2cppRuntimeField_1 = value.fakeValueActive;
            TzarGames.Endless.EndlessGameState.<GenuineCheckFailed>k__BackingField.__il2cppRuntimeField_8 = X2;
        }
        public static bool get_IsLoading()
        {
            return (bool)TzarGames.Endless.EndlessGameState.<IsLoading>k__BackingField;
        }
        private static void set_IsLoading(bool value)
        {
            TzarGames.Endless.EndlessGameState.<IsLoading>k__BackingField = W1 & 1;
        }
        public static void add_OnLoadingStarted(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnLoadingStarted);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855776 != TzarGames.Endless.EndlessGameState.OnLoadingStarted);
        
        }
        public static void remove_OnLoadingStarted(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnLoadingStarted);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855776 != TzarGames.Endless.EndlessGameState.OnLoadingStarted);
        
        }
        public static void add_OnLoadingSceneReady(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnLoadingSceneReady);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855784 != TzarGames.Endless.EndlessGameState.OnLoadingSceneReady);
        
        }
        public static void remove_OnLoadingSceneReady(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnLoadingSceneReady);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855784 != TzarGames.Endless.EndlessGameState.OnLoadingSceneReady);
        
        }
        public static void add_OnLoadingFinished(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnLoadingFinished);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855792 != TzarGames.Endless.EndlessGameState.OnLoadingFinished);
        
        }
        public static void remove_OnLoadingFinished(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnLoadingFinished);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855792 != TzarGames.Endless.EndlessGameState.OnLoadingFinished);
        
        }
        public static void add_OnInitializationFinished(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnInitializationFinished);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855800 != TzarGames.Endless.EndlessGameState.OnInitializationFinished);
        
        }
        public static void remove_OnInitializationFinished(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnInitializationFinished);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855800 != TzarGames.Endless.EndlessGameState.OnInitializationFinished);
        
        }
        public static void add_OnStageStarted(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnStageStarted);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855808 != TzarGames.Endless.EndlessGameState.OnStageStarted);
        
        }
        public static void remove_OnStageStarted(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnStageStarted);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855808 != TzarGames.Endless.EndlessGameState.OnStageStarted);
        
        }
        public static void add_OnNeedPurchaseFullGame(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnNeedPurchaseFullGame);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855816 != TzarGames.Endless.EndlessGameState.OnNeedPurchaseFullGame);
        
        }
        public static void remove_OnNeedPurchaseFullGame(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnNeedPurchaseFullGame);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855816 != TzarGames.Endless.EndlessGameState.OnNeedPurchaseFullGame);
        
        }
        public static void add_OnGameContinued(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnGameContinued);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855824 != TzarGames.Endless.EndlessGameState.OnGameContinued);
        
        }
        public static void remove_OnGameContinued(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnGameContinued);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855824 != TzarGames.Endless.EndlessGameState.OnGameContinued);
        
        }
        public static void add_OnMainMenuLoaded(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnMainMenuLoaded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855832 != TzarGames.Endless.EndlessGameState.OnMainMenuLoaded);
        
        }
        public static void remove_OnMainMenuLoaded(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnMainMenuLoaded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855832 != TzarGames.Endless.EndlessGameState.OnMainMenuLoaded);
        
        }
        public static void add_OnLobbyLoaded(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnLobbyLoaded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855840 != TzarGames.Endless.EndlessGameState.OnLobbyLoaded);
        
        }
        public static void remove_OnLobbyLoaded(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnLobbyLoaded);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855840 != TzarGames.Endless.EndlessGameState.OnLobbyLoaded);
        
        }
        public static void add_OnGenuineCheckFailed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.EndlessGameState.OnGenuineCheckFailed);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855848 != TzarGames.Endless.EndlessGameState.OnGenuineCheckFailed);
        
        }
        public static void remove_OnGenuineCheckFailed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.EndlessGameState.OnGenuineCheckFailed);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504861855848 != TzarGames.Endless.EndlessGameState.OnGenuineCheckFailed);
        
        }
        public TzarGames.Endless.Quests.EndlessQuest get_CurrentQuest()
        {
            return (TzarGames.Endless.Quests.EndlessQuest)this.<CurrentQuest>k__BackingField;
        }
        private void set_CurrentQuest(TzarGames.Endless.Quests.EndlessQuest value)
        {
            this.<CurrentQuest>k__BackingField = value;
        }
        public void add_OnGameSaved(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnGameSaved);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510615989712 != this.OnGameSaved);
        
        }
        public void remove_OnGameSaved(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnGameSaved);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510616126288 != this.OnGameSaved);
        
        }
        public bool get_Paused()
        {
            return (bool)this.paused;
        }
        public void set_Paused(bool value)
        {
            this.paused = value;
            if(value != false)
            {
                    UnityEngine.Time.timeScale = 0f;
                return;
            }
            
            UnityEngine.Time.timeScale = 1f;
        }
        public static TzarGames.Endless.EndlessGameState get_Instance()
        {
            return (TzarGames.Endless.EndlessGameState)TzarGames.Endless.EndlessGameState._instance;
        }
        public static string get_MultiplayerVersion()
        {
            return "5";
        }
        public string get_Version()
        {
            string val_2 = System.String.Format(format:  0, arg0:  " ({0})");
            return 0 + UnityEngine.Application.version;
        }
        public TzarGames.Endless.ICharacterInfo get_SelectedCharacter()
        {
            if(this.currentSaveGame == null)
            {
                    return 0;
            }
            
            return (TzarGames.Endless.ICharacterInfo)this.currentSaveGame.SelectedCharacter;
        }
        public int GetCharacterNumber(TzarGames.Endless.ICharacterInfo characterInfo)
        {
            if(this.currentSaveGame != null)
            {
                    return this.currentSaveGame.GetNumberOfCharacter(characterInfo:  characterInfo);
            }
            
            return this.currentSaveGame.GetNumberOfCharacter(characterInfo:  characterInfo);
        }
        public void SelectCharacter(int num)
        {
            State val_1 = this.CurrentState;
            UnityEngine.Debug.LogError(message:  0);
        }
        public int get_MaxLengthOfCharacterName()
        {
            return 12;
        }
        public int CreateCharacter(string name, TzarGames.Endless.PlayerClass classType, bool hardcore)
        {
            var val_9;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return 0;
            }
            
            if(name.Length > 12)
            {
                    return 0;
            }
            
            val_9 = this.currentSaveGame.Characters;
            var val_10 = 0;
            label_13:
            if(val_10 >= val_4.Length)
            {
                goto label_8;
            }
            
            TzarGames.Endless.EndlessCharacterData val_9 = val_9[0];
            val_10 = val_10 + 1;
            if((System.String.op_Equality(a:  0, b:  val_4[0x0][0].name)) == false)
            {
                goto label_13;
            }
            
            return 0;
            label_8:
            hardcore = hardcore;
            TzarGames.Endless.EndlessCharacterData val_7 = this.saveManager.CreateDefaultCharacterData(name:  name, classType:  classType, hardcore:  hardcore);
            int val_8 = this.currentSaveGame.AddCharacter(characterData:  val_7);
            val_7.CurrentStage = 1;
            return 0;
        }
        public void DeleteCharacter(int num)
        {
            TzarGames.Endless.ICharacterInfo val_5;
            TzarGames.Endless.EndlessSaveData val_6;
            int val_7;
            if(this.currentSaveGame.SelectedCharacterNumber == num)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            TzarGames.Endless.EndlessSaveManager.BackupSaveData(withDate:  false);
            val_5 = 0;
            if(this.currentSaveGame == null)
            {
                goto label_5;
            }
            
            val_6 = this.currentSaveGame;
            val_5 = this.currentSaveGame.SelectedCharacter;
            if(val_6 != null)
            {
                goto label_6;
            }
            
            label_5:
            val_6 = 0;
            label_6:
            val_6.RemoveCharacterAt(number:  num);
            if(this.currentSaveGame != null)
            {
                    val_7 = this.currentSaveGame.GetNumberOfCharacter(characterInfo:  val_5);
            }
            else
            {
                    val_7 = this.currentSaveGame.GetNumberOfCharacter(characterInfo:  val_5);
            }
            
            this.currentSaveGame.SelectedCharacterNumber = val_7;
            this.SaveGame();
        }
        public void DeleteAllCharacters()
        {
            goto label_0;
            label_3:
            X21.RemoveCharacterAt(number:  0);
            0 = 1;
            label_0:
            if(0 < this.currentSaveGame.CharacterCount)
            {
                goto label_3;
            }
            
            this.currentSaveGame.SelectedCharacterNumber = 0;
        }
        public TzarGames.Endless.ICharacterInfo[] get_Characters()
        {
            if(this.currentSaveGame != null)
            {
                    return this.currentSaveGame.Characters;
            }
            
            return this.currentSaveGame.Characters;
        }
        public int get_CharacterCount()
        {
            if(this.currentSaveGame != null)
            {
                    return this.currentSaveGame.CharacterCount;
            }
            
            return this.currentSaveGame.CharacterCount;
        }
        public TzarGames.Common.SerializableData get_CommonSaveGameData()
        {
            if(this.currentSaveGame != null)
            {
                    return this.currentSaveGame.Data;
            }
            
            return this.currentSaveGame.Data;
        }
        public bool get_IsTutorialCompleted()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if(this.currentSaveGame.SelectedCharacter != null)
            {
                    val_4 = this.currentSaveGame.SelectedCharacter;
                var val_3 = (val_2.isTutorialCompleted == true) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public uint get_MinimumStageToGoDown()
        {
            return 1;
        }
        public int get_MaxEnemySpawnCount()
        {
            return (int)this.<MaxEnemySpawnCount>k__BackingField;
        }
        internal void set_MaxEnemySpawnCount(int value)
        {
            this.<MaxEnemySpawnCount>k__BackingField = value;
        }
        public bool CanGoToLowerStage()
        {
            var val_4;
            var val_5;
            if(this.currentSaveGame == null)
            {
                goto label_1;
            }
            
            val_5 = this.currentSaveGame.SelectedCharacter;
            if(val_5 != null)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            val_5 = 0;
            label_3:
            val_4 = 0;
            label_2:
            if(mem[282584257676929] == 0)
            {
                    return (bool)(val_5 > 1) ? 1 : 0;
            }
            
            var val_3 = mem[282584257676823];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < mem[282584257676929])
            {
                goto label_6;
            }
            
            return (bool)(val_5 > 1) ? 1 : 0;
            label_5:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_4 = val_4 + val_5;
            val_4 = val_4 + 272;
            return (bool)(val_5 > 1) ? 1 : 0;
        }
        public bool CanGoToStage(uint stageNumber)
        {
            var val_3;
            var val_4;
            val_3 = stageNumber;
            if(val_3 != 0)
            {
                    return true;
            }
            
            if(this.currentSaveGame != null)
            {
                    val_3 = this.currentSaveGame.SelectedCharacter;
                if(val_3 != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_4 = val_3;
                return true;
            }
            
            }
        
        }
        public bool IsInPromoGameState()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsInGameState()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsInitializing()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsInLobby()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsInMainMenu()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public bool IsInTutorial()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (bool);
        }
        public void SetTutorialCompleted()
        {
            TzarGames.Endless.EndlessCharacterData val_1 = this.currentSaveGame.SelectedCharacter;
            val_1.isTutorialCompleted = true;
        }
        public TzarGames.Endless.EndlessHeroData GetHeroData()
        {
            if(this.currentSaveGame.SelectedCharacter != null)
            {
                    return (TzarGames.Endless.EndlessHeroData)val_1.HeroData;
            }
            
            return (TzarGames.Endless.EndlessHeroData)val_1.HeroData;
        }
        public void SetHeroData(TzarGames.Endless.EndlessHeroData data)
        {
            TzarGames.Endless.EndlessCharacterData val_1 = this.currentSaveGame.SelectedCharacter;
            val_1.HeroData = data;
        }
        public bool IsItSafeStateToSaveGame()
        {
            if(this.IsInLobby() == false)
            {
                    return this.IsInMainMenu();
            }
            
            return true;
        }
        public void ReplaceSaveGameAndReload(TzarGames.Endless.EndlessSaveData saveData)
        {
            this.currentSaveGame = saveData;
            this.SaveGame();
            this.ReloadGame();
        }
        public void SaveGame()
        {
            this.saveManager.SaveData(data:  this.currentSaveGame);
            if(this.OnGameSaved == null)
            {
                    return;
            }
            
            this.OnGameSaved.Invoke();
        }
        public void CompleteCurrentStageAndExitToLobby()
        {
            State val_1 = this.CurrentState;
            UnityEngine.Debug.LogError(message:  0);
        }
        public void RestartCurrentPromoLevel()
        {
            bool val_1 = this.GotoState<EndlessGameState.TransitionState>(stateData:  0);
            bool val_2 = this.GotoState<EndlessGameState.PromoGame>(stateData:  0);
        }
        public void CompleteCurrentPromoStageAndLoadNextLevel()
        {
            State val_1 = this.CurrentState;
            UnityEngine.Debug.LogError(message:  0);
        }
        public void GotoStage(uint stage, bool toLobby)
        {
            State val_1 = this.CurrentState;
            UnityEngine.Debug.LogError(message:  0);
        }
        public void ExitFromGame()
        {
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        public bool CanGoToLobby()
        {
            var val_4;
            var val_5;
            if(this.currentSaveGame == null)
            {
                goto label_1;
            }
            
            val_5 = this.currentSaveGame.SelectedCharacter;
            if(val_5 != null)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            val_5 = 0;
            label_3:
            val_4 = 0;
            label_2:
            if(mem[282584257676929] == 0)
            {
                    return (bool)(val_5 > 1) ? 1 : 0;
            }
            
            var val_3 = mem[282584257676823];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < mem[282584257676929])
            {
                goto label_6;
            }
            
            return (bool)(val_5 > 1) ? 1 : 0;
            label_5:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_4 = val_4 + val_5;
            val_4 = val_4 + 272;
            return (bool)(val_5 > 1) ? 1 : 0;
        }
        public void LoadGameOrLobbyScene()
        {
            var val_5;
            object val_6;
            if(this.CanGoToLobby() == false)
            {
                goto label_1;
            }
            
            val_5 = 1152921510620467776;
            val_6 = 0;
            goto label_8;
            label_1:
            TzarGames.Endless.EndlessCharacterData val_2 = this.currentSaveGame.SelectedCharacter;
            if(val_2.isTutorialCompleted == false)
            {
                goto label_5;
            }
            
            val_6 = 0;
            if(this.ShouldLoadPromoStage() == false)
            {
                goto label_6;
            }
            
            val_5 = 1152921510620610496;
            goto label_8;
            label_5:
            val_5 = 1152921510621314240;
            val_6 = 0;
            goto label_8;
            label_6:
            val_5 = 1152921510620735808;
            label_8:
            bool val_4 = this.GotoState<EndlessGameState.StageGame>(stateData:  val_6);
        }
        public bool ShouldLoadPromoStage()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = this;
            if(this.currentSaveGame == null)
            {
                goto label_1;
            }
            
            val_8 = this.currentSaveGame.SelectedCharacter;
            if(val_8 != null)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            val_8 = 0;
            label_3:
            val_7 = 0;
            label_2:
            if(mem[282584257676929] == 0)
            {
                goto label_7;
            }
            
            var val_5 = mem[282584257676823];
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < mem[282584257676929])
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            var val_7 = val_5;
            val_7 = val_7 + 3;
            val_7 = val_7 + val_7;
            val_7 = val_7 + 272;
            label_7:
            if((val_8 > 1) || (this.promoLevels.Length < 1))
            {
                goto label_10;
            }
            
            if(this.currentSaveGame == null)
            {
                goto label_13;
            }
            
            val_6 = this.currentSaveGame.SelectedCharacter;
            if(val_6 == null)
            {
                goto label_13;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = val_6;
            return (bool)(this.promoLevels.Length > val_6) ? 1 : 0;
            label_10:
            val_10 = 0;
            return (bool)(this.promoLevels.Length > val_6) ? 1 : 0;
            label_13:
        }
        public void ReloadGame()
        {
            bool val_1 = this.GotoState<EndlessGameState.Reloading>(stateData:  0);
        }
        public void ExitToMainMenu()
        {
            bool val_1 = this.GotoState<EndlessGameState.MainMenu>(stateData:  0);
        }
        protected override void Awake()
        {
            this.Awake();
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    TzarGames.Endless.EndlessGameState._instance = this;
                UnityEngine.GameObject val_2 = this.gameObject;
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_3 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void TzarGames.Endless.EndlessGameState::<Awake>m__0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
                UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
                return;
            }
            
            System.Type val_4 = this.GetType();
            string val_5 = 0 + "Не допускается использование больше одного ";
            UnityEngine.Debug.LogError(message:  0);
            UnityEngine.GameObject val_6 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void OnDestroy()
        {
            if(0 != TzarGames.Endless.EndlessGameState._instance)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState._instance = 0;
        }
        public void LoadSceneAsync(string sceneName)
        {
            var val_3;
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_3 = null;
            }
            
            val_3 = null;
            val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameState.GameStateBase.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? (val_1) : 0;
            goto (StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameState.GameStateBase.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_3 ? val_1 : 0 + 400;
        }
        public void LoadCurrentStageLevel()
        {
            TzarGames.Endless.SceneInfo val_1 = this.getCurrentStageInfo();
            this.LoadSceneAsync(sceneName:  val_1.SceneName);
        }
        public void NotifyGameAdsWatched()
        {
        
        }
        public void TryContinueGame()
        {
            if(this.lastAttemptGameStateType != null)
            {
                    bool val_1 = this.GotoState(stateType:  this.lastAttemptGameStateType, stateData:  this.lastAttemptGameStateData);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public void CancelGameContinue()
        {
            this.lastAttemptGameStateData = 0;
            this.lastAttemptGameStateType = 0;
        }
        private void beginLoadGame()
        {
            this.saveManager.LoadSaveData(completeCallback:  new System.Action<TzarGames.Endless.EndlessSaveData>(object:  this, method:  System.Void TzarGames.Endless.EndlessGameState::<beginLoadGame>m__1(TzarGames.Endless.EndlessSaveData saveData)));
        }
        public bool IsBossDefeated(TzarGames.Endless.Quests.EpicBossQuest bossQuest)
        {
            TzarGames.Common.SerializableData val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            bool val_4 = false;
            TzarGames.Endless.Quests.QuestStatus val_7 = 0;
            if(this.currentSaveGame == null)
            {
                goto label_1;
            }
            
            val_13 = this.currentSaveGame.SelectedCharacter;
            if(val_13 != null)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            val_13 = 0;
            label_3:
            val_12 = 0;
            label_2:
            if(mem[282584257676929] == 0)
            {
                goto label_7;
            }
            
            var val_10 = mem[282584257676823];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < mem[282584257676929])
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            var val_12 = val_10;
            val_12 = val_12 + 6;
            val_12 = val_12 + val_12;
            val_12 = val_12 + 272;
            label_7:
            TzarGames.Endless.Quests.IQuestInfo val_2 = TzarGames.Endless.Quests.QuestUtils.GetQuestData(dataSource:  0, questId:  0);
            if(val_2 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_14 = val_2;
                val_11 = val_2;
                if((bossQuest.GetBossStateFromSerializedData(data:  val_11, killed: out  val_4)) != false)
            {
                    if(val_4 != 0)
            {
                    val_15 = 1;
                return (bool)val_15;
            }
            
                var val_14 = 0;
                val_14 = val_14 + 1;
                val_16 = val_2;
                if((bossQuest.GetStatusFromSerializedData(data:  val_2, status: out  val_7)) != false)
            {
                    var val_9 = (val_7 == 1) ? 1 : 0;
                return (bool)val_15;
            }
            
            }
            
            }
            
            val_15 = 0;
            return (bool)val_15;
        }
        public TzarGames.Endless.Quests.EpicBossQuest GetBossQuestForStage(uint stageNum)
        {
            var val_2;
            TzarGames.Endless.Quests.EpicBossQuest val_3;
            val_2 = 0;
            label_4:
            if(val_2 >= this.bossQuests.Length)
            {
                goto label_1;
            }
            
            val_3 = this.bossQuests[0];
            val_2 = val_2 + 1;
            if((long)val_3.Stage != stageNum)
            {
                goto label_4;
            }
            
            return (TzarGames.Endless.Quests.EpicBossQuest)val_3;
            label_1:
            val_3 = 0;
            return (TzarGames.Endless.Quests.EpicBossQuest)val_3;
        }
        public bool IsCurrentStageWithBoss()
        {
            var val_3;
            var val_4;
            if(this.currentSaveGame == null)
            {
                goto label_1;
            }
            
            val_4 = this.currentSaveGame.SelectedCharacter;
            if(val_4 != null)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            val_4 = 0;
            label_3:
            val_3 = 0;
            label_2:
            if(mem[282584257676929] == 0)
            {
                    return this.IsStageWithBoss(stage:  0);
            }
            
            var val_2 = mem[282584257676823];
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_6:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < mem[282584257676929])
            {
                goto label_6;
            }
            
            return this.IsStageWithBoss(stage:  0);
            label_5:
            var val_4 = val_2;
            val_4 = val_4 + 1;
            val_3 = val_3 + val_4;
            val_3 = val_3 + 272;
            return this.IsStageWithBoss(stage:  0);
        }
        public bool IsStageWithBoss(uint stage)
        {
            var val_4;
            TzarGames.Endless.Quests.EpicBossQuest val_1 = this.GetBossQuestForStage(stageNum:  stage);
            if(0 != val_1)
            {
                    if((this.IsBossDefeated(bossQuest:  val_1)) == false)
            {
                goto label_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_4:
            val_4 = 1;
            return (bool)val_4;
        }
        private TzarGames.Endless.SceneInfo getCurrentStageInfo()
        {
            var val_3;
            State val_1 = this.CurrentState;
            val_3 = 0;
            return (TzarGames.Endless.SceneInfo)this.stages[(long)val_3.GetStageSceneNum()];
        }
        public void StartMultiplayer()
        {
            State val_1 = this.CurrentState;
            UnityEngine.Debug.LogError(message:  0);
        }
        public void StartQuest(TzarGames.Endless.Quests.EndlessQuest task)
        {
            if(0 == task)
            {
                    return;
            }
            
            if(this.CurrentState == null)
            {
                    return;
            }
        
        }
        public bool CanContinueGame()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = this;
            if(this.CanGoToLobby() == false)
            {
                    return true;
            }
            
            if(this.currentSaveGame == null)
            {
                goto label_2;
            }
            
            val_8 = this.currentSaveGame.SelectedCharacter;
            if(val_8 != null)
            {
                goto label_3;
            }
            
            goto label_4;
            label_2:
            val_8 = 0;
            label_4:
            val_7 = 0;
            label_3:
            if(mem[282584257676929] == 0)
            {
                goto label_8;
            }
            
            var val_4 = mem[282584257676823];
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_7:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < mem[282584257676929])
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_6 = val_4;
            val_6 = val_6 + 1;
            val_7 = val_7 + val_6;
            val_7 = val_7 + 272;
            label_8:
            if(this.currentSaveGame == null)
            {
                goto label_9;
            }
            
            val_6 = this.currentSaveGame.SelectedCharacter;
            if(val_6 != null)
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            val_6 = 0;
            label_11:
            val_9 = 0;
            label_10:
            if(mem[282584257676929] == 0)
            {
                    return true;
            }
            
            var val_7 = mem[282584257676823];
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_14:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < mem[282584257676929])
            {
                goto label_14;
            }
            
            return true;
            label_13:
            var val_9 = val_7;
            val_9 = val_9 + 3;
            val_9 = val_9 + val_9;
            val_9 = val_9 + 272;
            return true;
        }
        public void SetGamePurchased(bool saveGame = True)
        {
            this.currentSaveGame.IsGamePurchased = true;
            if(saveGame == false)
            {
                    return;
            }
            
            this.SaveGame();
        }
        public bool IsGamePurchased()
        {
            return true;
        }
        private void <Awake>m__0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            var val_4;
            State val_1 = this.CurrentState;
            if(val_1 != null)
            {
                    val_4 = null;
            }
            
            val_4 = null;
            int val_3 = scene.m_Handle & 4294967295;
            val_1 = (((StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameState.GameStateBase.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_4) ? (val_1) : 0;
            goto (StateMachine.State.__il2cppRuntimeField_typeHierarchy + EndlessGameState.GameStateBase.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_4 ? val_1 : 0 + 416;
        }
        private void <beginLoadGame>m__1(TzarGames.Endless.EndlessSaveData saveData)
        {
            TzarGames.Endless.EndlessSaveData val_6;
            var val_7;
            if(saveData == null)
            {
                goto label_1;
            }
            
            UnityEngine.Debug.Log(message:  0);
            this.currentSaveGame = saveData;
            if(((saveData.IsTutorialCompleted & 255) == false) || (saveData.IsTutorialCompleted > true))
            {
                goto label_5;
            }
            
            UnityEngine.Debug.Log(message:  0);
            this.currentSaveGame.OldTutorialCompletedFlagInitialized = true;
            val_7 = 0;
            goto label_10;
            label_22:
            val_7 = 1;
            mem2[0] = true;
            label_10:
            if(val_7 >= val_4.Length)
            {
                goto label_12;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_4[0x1][0].name;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Setting IsTutorialCompleted flag for {0}");
            if(this.currentSaveGame.Characters[1] != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_1:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_12:
            val_6 = this.currentSaveGame;
            this.saveManager.SaveData(data:  val_6);
            label_5:
            bool val_5 = this.GotoState<EndlessGameState.MainMenu>(stateData:  0);
        }
    
    }

}
