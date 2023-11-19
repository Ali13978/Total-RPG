using UnityEngine;
public interface IGooglePlayObbDownloader
{
    // Properties
    public abstract string PublicKey { get; set; }
    
    // Methods
    public abstract string get_PublicKey(); // 0
    public abstract void set_PublicKey(string value); // 0
    public abstract string GetExpansionFilePath(); // 0
    public abstract string GetMainOBBPath(); // 0
    public abstract string GetPatchOBBPath(); // 0
    public abstract void FetchOBB(); // 0

}
