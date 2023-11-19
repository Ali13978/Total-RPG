using UnityEngine;

namespace TzarGames.Endless.Masks
{
    public class MaskRewardInfo : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Masks.MaskRewardInfo.MaskGroup[] maskGroups;
        
        // Properties
        public TzarGames.Endless.Masks.MaskRewardInfo.MaskGroup[] MaskGroups { get; }
        
        // Methods
        public MaskRewardInfo()
        {
        
        }
        public TzarGames.Endless.Masks.MaskRewardInfo.MaskGroup[] get_MaskGroups()
        {
            return (MaskGroup[])this.maskGroups;
        }
        public TzarGames.Endless.Masks.MaskRewardInfo.MaskGroup GetGroupOfMask(TzarGames.Endless.Masks.MaskItem targetMask)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            goto label_0;
            label_6:
            val_1 = 1;
            label_0:
            if(val_1 >= this.maskGroups.Length)
            {
                    return (MaskGroup)this.maskGroups[1];
            }
            
            if(val_1 >= this.maskGroups.Length)
            {
                    val_2 = 0;
            }
            
            var val_3 = 0;
            label_10:
            if(val_3 >= this.maskGroups[0x1][0].Masks.Length)
            {
                goto label_6;
            }
            
            if(val_3 >= this.maskGroups[0x1][0].Masks.Length)
            {
                    val_2 = 0;
            }
            
            val_3 = val_3 + 1;
            if(this.maskGroups[0x1][0].Masks[0] != targetMask)
            {
                goto label_10;
            }
            
            return (MaskGroup)this.maskGroups[1];
        }
    
    }

}
