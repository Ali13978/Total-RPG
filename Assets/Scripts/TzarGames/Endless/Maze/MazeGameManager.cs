using UnityEngine;

namespace TzarGames.Endless.Maze
{
    public class MazeGameManager : EndlessStoryGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeWorldBuilder mazeGenerator;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeObjectActivator activator;
        [UnityEngine.SerializeField]
        private FollowGameObject playerLight;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject reflectionProbe;
        
        // Methods
        public MazeGameManager()
        {
        
        }
        protected override void Awake()
        {
            this.Awake();
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 != val_1)
            {
                    TzarGames.Endless.Quests.EndlessQuest val_3 = val_1.CurrentQuest;
            }
            
            this.mazeGenerator.ProcessMaze(horizontalCells:  this.mazeGenerator.MazeHorizontalCellNum, verticalCells:  this.mazeGenerator.MazeVerticalCellNum);
            mem[this.mazeGenerator] + 264.gameObject.GetComponentInChildren<TzarGames.TzarHero.CharacterTriggerEventHandler>().OnTriggerEnterEvent.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.TzarHero.TH_Character>(object:  this, method:  System.Void TzarGames.Endless.Maze.MazeGameManager::onEnterFinishTrigger(TzarGames.TzarHero.TH_Character character)));
        }
        private void onEnterFinishTrigger(TzarGames.TzarHero.TH_Character character)
        {
            var val_11;
            if(character == null)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                    return;
            }
            
            if(val_1.CurrentQuest == null)
            {
                    return;
            }
            
            val_11 = 1152921504871170048;
        }
        protected override TzarGames.GameFramework.SpawnPoint GetSpawnPointForPlayer(TzarGames.GameFramework.Player player)
        {
            if(this.mazeGenerator != null)
            {
                    return (TzarGames.GameFramework.SpawnPoint)this.mazeGenerator.playerSpawnPoint;
            }
            
            return (TzarGames.GameFramework.SpawnPoint)this.mazeGenerator.playerSpawnPoint;
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            this.PostSpawnPlayerObject(player:  player);
            this.playerLight.objectToFollow = player.PlayerObject.transform;
            UnityEngine.Vector3 val_4 = player.PlayerObject.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.reflectionProbe.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.reflectionProbe.SetActive(value:  true);
            this.activator.<Target>k__BackingField = player.PlayerObject.transform;
            this.activator.StartWork();
        }
    
    }

}
