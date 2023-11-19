using UnityEngine;
private class PlayerCharacterBase.ItemPrefabInstance<T>
{
    // Fields
    public TzarGames.GameFramework.ItemInstance Instance;
    public T PrefabInstance;
    
    // Methods
    public PlayerCharacterBase.ItemPrefabInstance<T>(TzarGames.GameFramework.ItemInstance itemInstance, T prefabInstance, TzarGames.Endless.PlayerCharacterBase playerCharacter)
    {
        var val_3;
        var val_4;
        val_1 = new System.Object();
        mem[1152921510764290160] = itemInstance;
        mem[1152921510764290168] = val_1;
        if(playerCharacter.OnEquipmentPrefabInstanceCreated == null)
        {
                return;
        }
        
        val_3 = 1152921504718241792;
        if(val_1 != null)
        {
                val_4 = val_1;
        }
        else
        {
                val_3 = 1152921504717283328;
        }
        
        playerCharacter.OnEquipmentPrefabInstanceCreated.Invoke(obj:  val_1.gameObject);
    }

}
