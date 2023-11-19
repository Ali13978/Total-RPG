using UnityEngine;
private sealed class SpawnNpcOnStage.<Start>c__Iterator0.<Start>c__AnonStorey1
{
    // Fields
    internal TzarGames.Endless.WayChainObjectInfo chainObj;
    internal TzarGames.Endless.SpawnNpcOnStage.<Start>c__Iterator0 <>f__ref$0;
    
    // Methods
    public SpawnNpcOnStage.<Start>c__Iterator0.<Start>c__AnonStorey1()
    {
    
    }
    internal void <>m__0()
    {
        string val_1 = 0.name;
        string val_2 = 0 + "Spawning NPC in room ";
        UnityEngine.Debug.Log(message:  0);
        TzarGames.GameFramework.SpawnPoint val_14 = 0.CommonSpawnPoints[0];
        UnityEngine.Vector3 val_4 = val_14.Position;
        UnityEngine.Quaternion val_5 = val_14.Rotation;
        TzarGames.GameFramework.TzarBehaviour val_6 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
        TzarGames.TzarHero.CharacterAI val_7 = val_6.GetComponent<TzarGames.TzarHero.CharacterAI>();
        if(0 != val_7)
        {
                val_7.Target = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.AddAlly(character:  val_6);
        }
        
        val_6.gameObject.AddComponent<TzarGames.Endless.CharacterXpTransfer>().TargetCharacter = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
        this.<>f__ref$0.$this.onSpawned.Invoke();
    }

}
