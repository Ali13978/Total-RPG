using UnityEngine;
private sealed class LocalizationManager.<GetAllLanguages>c__AnonStorey2
{
    // Fields
    internal System.Collections.Generic.List<string> Languages;
    
    // Methods
    public LocalizationManager.<GetAllLanguages>c__AnonStorey2()
    {
    
    }
    internal bool <>m__0(string x)
    {
        bool val_1 = this.Languages.Contains(item:  x);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }

}
