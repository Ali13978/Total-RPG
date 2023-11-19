using UnityEngine;
[DefaultState]
private class GameUI.Empty : GameUI.UiBaseState
{
    // Methods
    public GameUI.Empty()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_16;
        var val_17;
        this.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        val_1.allMenus.AddRange(collection:  this.UI.GetComponentsInChildren<TzarGames.GameFramework.UI.GameUIBase>());
        TzarGames.Endless.UI.GameUI val_4 = this.UI;
        bool val_6 = val_4.allMenus.Remove(item:  this.UI);
        TzarGames.Endless.UI.GameUI val_7 = this.UI;
        TzarGames.Endless.UI.GameUI val_8 = this.UI;
        val_7.gameMenus.AddRange(collection:  val_8.allMenus);
        TzarGames.Endless.UI.GameUI val_9 = this.UI;
        int val_11 = val_9.gameMenus.RemoveAll(match:  new System.Predicate<TzarGames.GameFramework.UI.GameUIBase>(object:  this, method:  System.Boolean GameUI.Empty::<OnStateBegin>m__0(TzarGames.GameFramework.UI.GameUIBase x)));
        TzarGames.Endless.UI.GameUI val_12 = this.UI;
        List.Enumerator<T> val_13 = val_12.gameMenus.GetEnumerator();
        label_15:
        if((0 & 1) == 0)
        {
            goto label_13;
        }
        
        this.UI.showMenu(menu:  0.InitializationCallback, show:  false);
        goto label_15;
        label_13:
        val_16 = 0;
        val_17 = 1;
        0.Dispose();
        if((val_17 & 1) != 0)
        {
                return;
        }
        
        if(val_16 == 0)
        {
                return;
        }
    
    }
    private bool <OnStateBegin>m__0(TzarGames.GameFramework.UI.GameUIBase x)
    {
        TzarGames.Endless.UI.GameUI val_1 = this.UI;
        bool val_2 = x.CompareTag(tag:  val_1.uiWindowTag);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }

}
