using UnityEngine;
public class SessionInfo
{
    // Fields
    public readonly int id;
    public int playerCount;
    
    // Methods
    public SessionInfo(int id, int playerCount)
    {
        this.id = id;
        this.playerCount = playerCount;
    }

}
