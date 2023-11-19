using UnityEngine;
private sealed class MoveCharacterToPosition.<moveRoutine>c__Iterator1.<moveRoutine>c__AnonStorey2
{
    // Fields
    internal System.Action<bool> callback;
    internal TzarGames.Endless.MoveCharacterToPosition.<moveRoutine>c__Iterator1 <>f__ref$1;
    
    // Methods
    public MoveCharacterToPosition.<moveRoutine>c__Iterator1.<moveRoutine>c__AnonStorey2()
    {
    
    }
    internal void <>m__0(TzarGames.TzarHero.TH_Character ch, bool result)
    {
        TzarGames.TzarHero.CharacterEvent val_2;
        if(result == false)
        {
            goto label_3;
        }
        
        val_2 = this.<>f__ref$1.$this.onReachTargetPositionSuccess;
        if(val_2 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_2 = this.<>f__ref$1.$this.onReachTargetPositionFailed;
        if(val_2 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        val_2.Invoke(arg0:  ch);
        this.callback.Invoke(obj:  result);
    }

}
