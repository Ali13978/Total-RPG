using UnityEngine;
public class TypedLobby
{
    // Fields
    public string Name;
    public LobbyType Type;
    public static readonly TypedLobby Default;
    
    // Properties
    public bool IsDefault { get; }
    
    // Methods
    public TypedLobby()
    {
        null = null;
        this.Type = 0;
        this.Name = System.String.Empty;
    }
    public TypedLobby(string name, LobbyType type)
    {
        this.Type = type;
        this.Name = name;
    }
    public bool get_IsDefault()
    {
        if(this.Type == 0)
        {
                return System.String.IsNullOrEmpty(value:  0);
        }
        
        return false;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  0, arg0:  "lobby \'{0}\'[{1}]", arg1:  this.Name);
    }
    private static TypedLobby()
    {
        TypedLobby.Default = new TypedLobby();
    }

}
