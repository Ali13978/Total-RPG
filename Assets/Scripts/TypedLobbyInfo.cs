using UnityEngine;
public class TypedLobbyInfo : TypedLobby
{
    // Fields
    public int PlayerCount;
    public int RoomCount;
    
    // Methods
    public TypedLobbyInfo()
    {
    
    }
    public override string ToString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_20 = ???;
        typeof(System.Object[]).__il2cppRuntimeField_28 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_30 = this.RoomCount;
        typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_38 = this.PlayerCount;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        return (string)System.String.Format(format:  0, args:  "TypedLobbyInfo \'{0}\'[{1}] rooms: {2} players: {3}");
    }

}
