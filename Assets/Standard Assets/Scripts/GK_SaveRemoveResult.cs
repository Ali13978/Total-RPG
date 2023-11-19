using UnityEngine;
public class GK_SaveRemoveResult : Result
{
    // Fields
    private string _SaveName;
    
    // Properties
    public string SaveName { get; }
    
    // Methods
    public GK_SaveRemoveResult(string name)
    {
        null = null;
        this._SaveName = System.String.Empty;
        this._SaveName = name;
    }
    public GK_SaveRemoveResult(string name, string errorData)
    {
        null = null;
        this._SaveName = System.String.Empty;
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
        this._SaveName = name;
    }
    public string get_SaveName()
    {
        return (string)this._SaveName;
    }

}
