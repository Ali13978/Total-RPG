using UnityEngine;
private class GameUI.UiBaseState : StateMachine.State
{
    // Properties
    public TzarGames.Endless.UI.GameUI UI { get; }
    
    // Methods
    public GameUI.UiBaseState()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_6;
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        int val_3 = val_1.stateHistory.RemoveAll(match:  new System.Predicate<UiBaseState>(object:  this, method:  System.Boolean GameUI.UiBaseState::<OnStateBegin>m__0(TzarGames.Endless.UI.GameUI.UiBaseState x)));
        TzarGames.Endless.UI.GameUI val_4 = this.UI;
        val_4.stateHistory.Add(item:  this);
        if((this & 1) == 0)
        {
                return;
        }
        
        TzarGames.GameFramework.GameManager val_5 = TzarGames.GameFramework.GameManager.Instance;
        if(val_5 != null)
        {
                val_6 = null;
            val_6 = null;
            val_5 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_6) ? (val_5) : 0;
        }
        
        0.StopPlayerMovement();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        var val_2;
        nextState.OnStateEnd(nextState:  nextState);
        if((this & 1) == 0)
        {
                return;
        }
        
        TzarGames.GameFramework.GameManager val_1 = TzarGames.GameFramework.GameManager.Instance;
        if(val_1 != null)
        {
                val_2 = null;
            val_2 = null;
            val_1 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_2) ? (val_1) : 0;
        }
        
        0.ResumePlayerMovement();
    }
    protected virtual bool shouldStopPlayerMovement()
    {
        return false;
    }
    public TzarGames.Endless.UI.GameUI get_UI()
    {
        if(this.Owner == null)
        {
                return (TzarGames.Endless.UI.GameUI);
        }
        
        0 = 0;
        return (TzarGames.Endless.UI.GameUI);
    }
    public void ShowOnlyThisMenu(TzarGames.GameFramework.UI.GameUIBase menuToShow)
    {
        var val_7;
        var val_8;
        this.UI.showMenu(menu:  menuToShow, show:  true);
        TzarGames.Endless.UI.GameUI val_2 = this.UI;
        List.Enumerator<T> val_3 = val_2.gameMenus.GetEnumerator();
        label_9:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = 0.InitializationCallback;
        if(0 == val_4)
        {
            goto label_9;
        }
        
        this.UI.showMenu(menu:  val_4, show:  false);
        goto label_9;
        label_4:
        val_7 = 0;
        val_8 = 1;
        0.Dispose();
        if((val_8 & 1) != 0)
        {
                return;
        }
        
        if(val_7 == 0)
        {
                return;
        }
    
    }
    private bool <OnStateBegin>m__0(TzarGames.Endless.UI.GameUI.UiBaseState x)
    {
        return (bool)(x == this) ? 1 : 0;
    }

}
