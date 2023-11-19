using UnityEngine;

namespace TzarGames.Endless
{
    public class MatchLogicInfinityWaves : GameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterWaveSpawner waveSpawner;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, TzarGames.TzarHero.TH_Character> playerCharacterMap;
        
        // Methods
        public MatchLogicInfinityWaves()
        {
            this.playerCharacterMap = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.Player, TzarGames.TzarHero.TH_Character>();
        }
        public void RestartGame()
        {
            this.waveSpawner.StopAndDestroyAllSpawnedObjects();
            this.waveSpawner.RestartWaves();
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.playerCharacterMap.Keys.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            UnityEngine.Transform val_4 = this.GetRandomSpawnPoint().transform;
            UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Quaternion val_6 = val_4.rotation;
            this.RespawnPlayerObject(player:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
            goto label_9;
            label_12:
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            this.PostSpawnPlayerObject(player:  player);
            TzarGames.TzarHero.TH_Character val_1 = player.PlayerObject.GetComponent<TzarGames.TzarHero.TH_Character>();
            this.playerCharacterMap.Add(key:  player, value:  val_1);
            val_1.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.MatchLogicInfinityWaves::onPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
            if(this.waveSpawner.IsRunning != false)
            {
                    return;
            }
            
            this.waveSpawner.StopAndDestroyAllSpawnedObjects();
            this.waveSpawner.RestartWaves();
        }
        protected override void PostPlayerExit(TzarGames.GameFramework.Player player)
        {
            this.PostPlayerExit(player:  player);
            bool val_1 = this.playerCharacterMap.Remove(key:  player);
        }
        private void onPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
        
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Dictionary.Enumerator<TKey, TValue> val_1 = this.playerCharacterMap.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            TH_Character.dlgDeadEvent val_3 = new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.Endless.MatchLogicInfinityWaves::onPlayerCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData));
            val_2.m_Handle.remove_OnCharacterDead(value:  null);
            goto label_4;
            label_7:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(val_2.m_Handle == 0)
            {
                    return;
            }
        
        }
    
    }

}
