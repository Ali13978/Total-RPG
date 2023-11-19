using UnityEngine;
private sealed class SocialSystem.<authRoutine>c__Iterator0.<authRoutine>c__AnonStorey3
{
    // Fields
    internal bool authResult;
    internal string authMessage;
    internal TzarGames.Endless.SocialSystem.<authRoutine>c__Iterator0 <>f__ref$0;
    
    // Methods
    public SocialSystem.<authRoutine>c__Iterator0.<authRoutine>c__AnonStorey3()
    {
    
    }
    internal void <>m__0(bool result, string message)
    {
        if((this.<>f__ref$0.$this.LogDebugInfo) != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "Authentication result: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = result;
            typeof(System.Object[]).__il2cppRuntimeField_29 = 24379785;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " message: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = message;
            string val_2 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        
        this.<>f__ref$0.$this.authInProcess = false;
        this.authResult = result;
        this.authMessage = message;
    }

}
