using UnityEngine;
public class ReplayKitVideoShareResult
{
    // Fields
    private string[] _Sources;
    
    // Properties
    public string[] Sources { get; }
    
    // Methods
    public ReplayKitVideoShareResult(string[] sourcesArray)
    {
        this._Sources = null;
        this._Sources = sourcesArray;
    }
    public string[] get_Sources()
    {
        return (System.String[])this._Sources;
    }

}
