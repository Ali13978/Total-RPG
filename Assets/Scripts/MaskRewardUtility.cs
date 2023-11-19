using UnityEngine;
private static class MaskInventoryUI.MaskRewardUtility
{
    // Methods
    public static void RewardPlayer(TzarGames.GameFramework.Player player, TzarGames.Endless.Masks.MaskRewardInfo.MaskGroup group)
    {
        string val_14;
        var val_15;
        val_14 = "MASKS_BAG";
        var val_14 = 0;
        label_18:
        if(val_14 >= (X2 + 16 + 24))
        {
            goto label_12;
        }
        
        if(val_14 >= (X2 + 16 + 24))
        {
                val_14 = 0;
        }
        
        var val_7 = (X2 + 16) + 0;
        val_14 = val_14 + 1;
        if((0.TemplateInstance.Inventory.GetBagByName(bagName:  val_14).ContainsNonConsumableWithId(id:  (X2 + 16 + 0) + 32)) == true)
        {
            goto label_18;
        }
        
        return;
        label_12:
        0.TemplateInstance.Inventory.HiddenBag.AddNonconsumableItem(itemInstance:  X2 + 24.CreateItemInstance());
        if(0 != TzarGames.Endless.Rewarder.Instance)
        {
                TzarGames.Endless.Rewarder.Instance.RewardRubies(rubyCount:  10);
        }
        
        TzarGames.GameFramework.GameManager val_13 = 0.MyGameManager;
        if(val_13 != null)
        {
                val_15 = null;
            val_15 = null;
            val_13 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_15) ? (val_13) : 0;
        }
        
        0.SaveGameWithPlayerData();
    }

}
