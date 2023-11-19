using UnityEngine;
private class PlayerCharacterBase.ItemModificatorInfo
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.GameFramework.ItemInstance <ItemInstance>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.GameFramework.CharacteristicModificator <Modificator>k__BackingField;
    
    // Properties
    public TzarGames.GameFramework.ItemInstance ItemInstance { get; set; }
    public TzarGames.GameFramework.CharacteristicModificator Modificator { get; set; }
    
    // Methods
    public PlayerCharacterBase.ItemModificatorInfo(TzarGames.GameFramework.ItemInstance instance, TzarGames.GameFramework.CharacteristicModificator modificator)
    {
        val_1 = new System.Object();
        this.<ItemInstance>k__BackingField = instance;
        this.<Modificator>k__BackingField = val_1;
    }
    public TzarGames.GameFramework.ItemInstance get_ItemInstance()
    {
        return (TzarGames.GameFramework.ItemInstance)this.<ItemInstance>k__BackingField;
    }
    private void set_ItemInstance(TzarGames.GameFramework.ItemInstance value)
    {
        this.<ItemInstance>k__BackingField = value;
    }
    public TzarGames.GameFramework.CharacteristicModificator get_Modificator()
    {
        return (TzarGames.GameFramework.CharacteristicModificator)this.<Modificator>k__BackingField;
    }
    private void set_Modificator(TzarGames.GameFramework.CharacteristicModificator value)
    {
        this.<Modificator>k__BackingField = value;
    }

}
