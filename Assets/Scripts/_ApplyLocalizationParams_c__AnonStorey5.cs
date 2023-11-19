using UnityEngine;
private sealed class LocalizationManager.<ApplyLocalizationParams>c__AnonStorey5
{
    // Fields
    internal System.Collections.Generic.Dictionary<string, object> parameters;
    
    // Methods
    public LocalizationManager.<ApplyLocalizationParams>c__AnonStorey5()
    {
    
    }
    internal object <>m__0(string p)
    {
        object val_1 = 0;
        return (object)((this.parameters.TryGetValue(key:  p, value: out  val_1)) != true) ? (val_1) : 0;
    }

}
