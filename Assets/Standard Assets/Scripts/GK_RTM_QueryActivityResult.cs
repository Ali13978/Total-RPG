using UnityEngine;
public class GK_RTM_QueryActivityResult : Result
{
    // Fields
    private int _Activity;
    
    // Properties
    public int Activity { get; }
    
    // Methods
    public GK_RTM_QueryActivityResult(int activity)
    {
        this._Activity = activity;
    }
    public GK_RTM_QueryActivityResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public int get_Activity()
    {
        return (int)this._Activity;
    }

}
