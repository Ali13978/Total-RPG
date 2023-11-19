using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessStoryGameManager : EndlessGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset customStoryName;
        public const int RubyCostForRespawn = 1;
        private int adWatchCount;
        private const int maxAllowedAdvertRespawn = 5;
        
        // Properties
        public static int SpawnerLevelAddition { get; }
        
        // Methods
        public EndlessStoryGameManager()
        {
        
        }
        public string GetCustomStoryName()
        {
            if(0 == this.customStoryName)
            {
                    return 0;
            }
            
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public static int get_SpawnerLevelAddition()
        {
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            val_10 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 != val_10)
            {
                    val_10 = TzarGames.Endless.EndlessGameState.Instance;
                if(val_10.SelectedCharacter != null)
            {
                    val_10 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_11 = val_10;
                if(val_10 >= 16)
            {
                    if(val_10 < 31)
            {
                    return (int)val_12;
            }
            
                if(val_10 < 51)
            {
                    return (int)val_12;
            }
            
                if(val_10 < 76)
            {
                    return (int)val_12;
            }
            
                var val_9 = (val_10 > 100) ? 25 : 20;
                return (int)val_12;
            }
            
            }
            
            }
            
            val_12 = 0;
            return (int)val_12;
        }
        public bool CanLocalPlayerRespawnedByAdvert()
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = this;
            if(0 == TzarGames.Endless.EndlessGameManager.GameState)
            {
                    val_9 = 1;
            }
            else
            {
                    if(this.adWatchCount > 4)
            {
                    val_9 = 0;
            }
            else
            {
                    val_8 = TzarGames.Endless.EndlessGameManager.GameState.SelectedCharacter;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_10 = val_8;
                var val_8 = val_8;
                val_9 = val_8 ^ 1;
            }
            
            }
            
            val_8 = val_9 & 1;
            return (bool)val_8;
        }
        public bool CanRespawnLocalPlayerByRuby()
        {
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            var val_13;
            val_10 = TzarGames.Endless.EndlessGameManager.GameState;
            if(0 == val_10)
            {
                goto label_10;
            }
            
            val_10 = TzarGames.Endless.EndlessGameManager.GameState.SelectedCharacter;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = val_10;
            if(val_10 == null)
            {
                goto label_10;
            }
            
            val_10 = TzarGames.Endless.EndlessGameManager.GameState.SelectedCharacter;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = val_10;
            goto label_16;
            label_10:
            val_13 = 0;
            goto label_17;
            label_16:
            var val_11 = val_10;
            val_13 = val_11 ^ 1;
            label_17:
            val_11 = val_13 & 1;
            return (bool)val_11;
        }
        public void RespawnLocalPlayerByRuby()
        {
            var val_7;
            if(this.CanRespawnLocalPlayerByRuby() == false)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = TzarGames.Endless.EndlessGameManager.GameState.SelectedCharacter;
            TzarGames.Endless.EndlessGameManager.GameState.SaveGame();
            TzarGames.GameFramework.Player val_6 = this.LocalPlayer;
            goto typeof(TzarGames.Endless.EndlessStoryGameManager).__il2cppRuntimeField_280;
        }
        public void SaveAndExitToLobby()
        {
            TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
            TzarGames.Endless.EndlessGameState.Instance.SaveGame();
            TzarGames.Endless.EndlessGameState.Instance.ExitFromGame();
        }
        public void ExitToLobby()
        {
            this.StopPlayerMovement();
            TzarGames.Endless.EndlessGameState.Instance.ExitFromGame();
        }
        public void RespawnLocalPlayerByAdvert()
        {
            int val_6 = this.adWatchCount;
            if(val_6 > 4)
            {
                    return;
            }
            
            val_6 = (val_6 < 5) ? (val_6 + 4) : 0;
            this.adWatchCount = val_6 + 1;
            if(val_6 > 8)
            {
                    return;
            }
            
            var val_3 = val_6 & 65535;
            val_3 = 497 >> val_3;
            if((val_3 & 1) == 0)
            {
                    return;
            }
            
            string val_4 = 0 + "Respawing player by advert with health multiplier: "("Respawing player by advert with health multiplier: ");
            UnityEngine.Debug.Log(message:  0);
            TzarGames.GameFramework.Player val_5 = this.LocalPlayer;
        }
        public override void RespawnPlayer(TzarGames.GameFramework.Player player, float hitPointsMultiplier)
        {
            var val_7;
            this.RespawnPlayer(player:  player, hitPointsMultiplier:  hitPointsMultiplier);
            val_7 = 0;
            if(0 == )
            {
                    return;
            }
            
            add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.EndlessStoryGameManager::PlayerCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
            IgnoreDamage.AddModificator(owner:  this, value:  true, booleanOperator:  1);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.godModeRoutine(character:  null));
        }
        private void PlayerCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            var val_4;
            if(behaviour != null)
            {
                    val_4 = null;
                val_4 = null;
                var val_1 = (((TzarGames.GameFramework.TzarBehaviour.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_4) ? behaviour : 0;
            }
            
            0.IgnoreDamage.RemoveModificator(owner:  this);
            behaviour.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.EndlessStoryGameManager::PlayerCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator godModeRoutine(TzarGames.TzarHero.TH_Character character)
        {
            if(null != 0)
            {
                    typeof(EndlessStoryGameManager.<godModeRoutine>c__Iterator0).__il2cppRuntimeField_10 = character;
            }
            else
            {
                    mem[16] = character;
            }
            
            typeof(EndlessStoryGameManager.<godModeRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
