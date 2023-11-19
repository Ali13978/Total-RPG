using UnityEngine;
private sealed class AutoCompleteComboBox.<PruneItems>c__AnonStorey1
{
    // Fields
    internal string currText;
    
    // Methods
    public AutoCompleteComboBox.<PruneItems>c__AnonStorey1()
    {
    
    }
    internal bool <>m__0(string x)
    {
        string val_1 = x.ToLower();
        if(val_1 != null)
        {
                return val_1.Contains(value:  this.currText.ToLower());
        }
        
        return val_1.Contains(value:  this.currText.ToLower());
    }
    internal bool <>m__1(string x)
    {
        string val_1 = x.ToLower();
        if(val_1 != null)
        {
                return val_1.Contains(value:  this.currText);
        }
        
        return val_1.Contains(value:  this.currText);
    }

}
