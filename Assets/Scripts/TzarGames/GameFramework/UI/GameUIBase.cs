using UnityEngine;

namespace TzarGames.GameFramework.UI
{
    public class GameUIBase : StateMachine
    {
        // Fields
        private TzarGames.GameFramework.Player owner;
        
        // Properties
        public TzarGames.GameFramework.Player PlayerOwner { get; }
        
        // Methods
        public GameUIBase()
        {
        
        }
        public virtual void NotifyShown()
        {
        
        }
        public virtual void NotifyHidden()
        {
        
        }
        public void SetPlayerOwner(TzarGames.GameFramework.Player player)
        {
            if(this.owner == player)
            {
                    return;
            }
            
            this.owner = player;
            goto typeof(TzarGames.GameFramework.UI.GameUIBase).__il2cppRuntimeField_190;
        }
        protected virtual void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
        
        }
        public TzarGames.GameFramework.Player get_PlayerOwner()
        {
            return (TzarGames.GameFramework.Player)this.owner;
        }
    
    }

}
