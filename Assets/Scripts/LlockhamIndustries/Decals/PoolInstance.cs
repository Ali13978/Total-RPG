using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public class PoolInstance
    {
        // Fields
        public int id;
        public string title;
        public int[] limits;
        
        // Methods
        public PoolInstance(string Title, LlockhamIndustries.Decals.PoolInstance[] CurrentInstances)
        {
            System.Int32[] val_4;
            var val_5;
            var val_6;
            this.title = Title;
            this.id = this.UniqueID(CurrentInstances:  CurrentInstances);
            val_4 = null;
            val_5 = 0;
            this.limits = val_4;
            val_6 = 400;
            goto label_1;
            label_6:
            var val_2 = val_4 + ((X24) << 2);
            mem2[0] = 400;
            val_4 = this.limits;
            val_6 = 800;
            val_5 = W23;
            label_1:
            if(val_5 >= this.limits.Length)
            {
                    return;
            }
            
            var val_3 = val_5 + 1;
            if(val_5 < this.limits.Length)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private int UniqueID(LlockhamIndustries.Decals.PoolInstance[] CurrentInstances)
        {
            var val_2;
            var val_3;
            LlockhamIndustries.Decals.PoolInstance val_4;
            val_2 = 0;
            if(CurrentInstances == null)
            {
                    return (int)val_2;
            }
            
            label_7:
            val_2 = val_2 + 1;
            val_3 = 1;
            if(CurrentInstances.Length < 1)
            {
                goto label_1;
            }
            
            label_6:
            val_4 = CurrentInstances[0];
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(0 < CurrentInstances.Length)
            {
                goto label_4;
            }
            
            val_4 = mem[CurrentInstances[0x0] + 32];
            val_4 = CurrentInstances[0x0] + 32;
            if(val_4 == 0)
            {
                goto label_5;
            }
            
            label_4:
            label_3:
            if((0 + 1) < CurrentInstances.Length)
            {
                goto label_6;
            }
            
            label_1:
            if((((val_2 == (CurrentInstances[0x0] + 32 + 16)) ? 0 : (val_3)) & 1) == 0)
            {
                goto label_7;
            }
            
            return (int)val_2;
            label_5:
        }
    
    }

}
