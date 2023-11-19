using UnityEngine;
[DefaultState]
private class ChatUI.Chat : ChatUI.ChatState
{
    // Methods
    public ChatUI.Chat()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.Chat.ChatUI val_1 = this.UI;
        if(val_1.chatWindow == null)
        {
            
        }
    
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.Chat.ChatUI val_1 = this.UI;
        if(val_1.chatWindow == null)
        {
            
        }
    
    }
    public override void Update()
    {
        var val_5;
        TzarGames.Common.UI.UIBase val_6;
        this.Update();
        TzarGames.Endless.UI.Chat.ChatUI val_1 = this.UI;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = val_1.chatProvider;
        bool val_3 = val_1.chatWindow.IsVisible;
        if(val_1.chatProvider == null)
        {
            goto label_9;
        }
        
        if(val_3 == false)
        {
                return;
        }
        
        val_6 = val_1.chatWindow;
        if(val_6 != null)
        {
            goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
        }
        
        goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
        label_9:
        if(val_3 != false)
        {
                return;
        }
        
        val_6 = val_1.chatWindow;
        goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
    }

}
