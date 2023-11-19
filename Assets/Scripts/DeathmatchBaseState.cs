using UnityEngine;
private class EndlessGameManager_Deathmatch.DeathmatchBaseState : StateMachine.State
{
    // Properties
    public TzarGames.Endless.EndlessGameManager_Deathmatch Game { get; }
    
    // Methods
    public EndlessGameManager_Deathmatch.DeathmatchBaseState()
    {
    
    }
    public TzarGames.Endless.EndlessGameManager_Deathmatch get_Game()
    {
        if(this.Owner == null)
        {
                return (TzarGames.Endless.EndlessGameManager_Deathmatch);
        }
        
        0 = 0;
        return (TzarGames.Endless.EndlessGameManager_Deathmatch);
    }
    public virtual void OnCharacterDead(TzarGames.TzarHero.DeadEventData eventData)
    {
    
    }
    public virtual void OnPlayerEnter(TzarGames.GameFramework.Player player)
    {
    
    }
    public virtual void OnPlayerExit(TzarGames.GameFramework.Player player)
    {
    
    }
    public virtual void OnPlayerObjectSpawn(TzarGames.GameFramework.Player player)
    {
    
    }

}
