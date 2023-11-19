using UnityEngine;
private sealed class LocalizationManager.<GetAllLanguagesCode>c__AnonStorey3
{
    // Fields
    internal System.Collections.Generic.List<string> Languages;
    
    // Methods
    public LocalizationManager.<GetAllLanguagesCode>c__AnonStorey3()
    {
    
    }
    internal bool <>m__0(string x)
    {
        bool val_1 = this.Languages.Contains(item:  x);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }

}
