using UnityEngine;
private abstract class WaveSpawner.WaveSpawnerBaseState : StateMachine.State
{
    // Properties
    public TzarGames.GameFramework.WaveSpawner Spawner { get; }
    
    // Methods
    protected WaveSpawner.WaveSpawnerBaseState()
    {
    
    }
    public TzarGames.GameFramework.WaveSpawner get_Spawner()
    {
        if(this.Owner == null)
        {
                return (TzarGames.GameFramework.WaveSpawner);
        }
        
        0 = 0;
        return (TzarGames.GameFramework.WaveSpawner);
    }

}
