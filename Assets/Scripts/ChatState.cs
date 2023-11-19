using UnityEngine;
private class ChatUI.ChatState : StateMachine.State
{
    // Properties
    public TzarGames.Endless.UI.Chat.ChatUI UI { get; }
    
    // Methods
    public ChatUI.ChatState()
    {
    
    }
    public TzarGames.Endless.UI.Chat.ChatUI get_UI()
    {
        if(this.Owner == null)
        {
                return (TzarGames.Endless.UI.Chat.ChatUI);
        }
        
        0 = 0;
        return (TzarGames.Endless.UI.Chat.ChatUI);
    }

}
