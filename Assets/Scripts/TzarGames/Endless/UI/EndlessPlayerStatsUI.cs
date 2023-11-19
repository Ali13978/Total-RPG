using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class EndlessPlayerStatsUI : CharacterStatsUI
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI blockChance;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject blockChanceContainer;
        private float lastBlockChance;
        
        // Methods
        public EndlessPlayerStatsUI()
        {
            this.lastBlockChance = -1.175494E-38f;
        }
        protected override void UpdateCharacterStats()
        {
            TzarGames.Common.UI.TextUI val_18;
            var val_19;
            UnityEngine.GameObject val_20;
            val_18 = this;
            this.UpdateCharacterStats();
            TzarGames.TzarHero.TH_Character val_1 = this.Character;
            if(val_1 != null)
            {
                    val_19 = null;
                val_19 = null;
                val_1 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_19) ? (val_1) : 0;
            }
            
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_2 = 0.PlayerTemplateInstance;
            val_20 = this.blockChanceContainer;
            if((val_2.CanWearItemType(t:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    if(0 != val_20)
            {
                    if(this.blockChanceContainer.activeSelf != true)
            {
                    this.blockChanceContainer.SetActive(value:  true);
            }
            
            }
            
                val_20 = this.blockChance;
                if(0 == val_20)
            {
                    return;
            }
            
                val_20 = this.blockChance.gameObject;
                if(val_20.activeInHierarchy == false)
            {
                    return;
            }
            
                float val_13 = val_2.BlockChance;
                if((System.Math.Abs(val_13 - this.lastBlockChance)) <= 0.0001f)
            {
                    return;
            }
            
                this.lastBlockChance = val_13;
                val_18 = this.blockChance;
                val_18.text = System.String.Format(format:  0, arg0:  "{0}%");
                return;
            }
            
            if(0 == val_20)
            {
                    return;
            }
            
            if(this.blockChanceContainer.activeSelf == false)
            {
                    return;
            }
            
            this.blockChanceContainer.SetActive(value:  false);
        }
    
    }

}
