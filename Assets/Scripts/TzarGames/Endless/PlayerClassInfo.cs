using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayerClassInfo : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClassInfo.PlayerClassEntry[] classes;
        
        // Methods
        public PlayerClassInfo()
        {
        
        }
        public string GetClassLocalizedName(TzarGames.Endless.PlayerClass classType)
        {
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_1 = this.GetClassTemplate(classType:  classType);
            if(0 == val_1)
            {
                    return 0;
            }
            
            if(val_1 != null)
            {
                    return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public TzarGames.Endless.EndlessPlayerCharacterTemplate GetClassTemplate(TzarGames.Endless.PlayerClass classType)
        {
            var val_1;
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_2;
            val_1 = 0;
            label_5:
            if(val_1 >= this.classes.Length)
            {
                goto label_1;
            }
            
            PlayerClassEntry val_1 = this.classes[0];
            val_1 = val_1 + 1;
            if(this.classes[0x0][0].Class != classType)
            {
                goto label_5;
            }
            
            val_2 = this.classes[0x0][0].Template;
            return (TzarGames.Endless.EndlessPlayerCharacterTemplate)val_2;
            label_1:
            val_2 = 0;
            return (TzarGames.Endless.EndlessPlayerCharacterTemplate)val_2;
        }
    
    }

}
