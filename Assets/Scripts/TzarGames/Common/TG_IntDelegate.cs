using UnityEngine;

namespace TzarGames.Common
{
    public sealed class TG_IntDelegate : MulticastDelegate
    {
        // Methods
        public TG_IntDelegate(object object, IntPtr method)
        {
            mem[1152921511239052032] = object;
            mem[1152921511239052040] = method;
            mem[1152921511239052016] = method;
        }
        public virtual void Invoke(int result)
        {
            var val_7;
            var val_8;
            var val_9;
            if(((X21 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if((X21 + 76) == 1)
            {
                goto label_6;
            }
            
            if(X20 != 0)
            {
                    if(((X20 + 237) & 1) != 0)
            {
                goto label_6;
            }
            
            }
            
            if((X20 + 237) == 0)
            {
                goto label_6;
            }
            
            long val_2 = X21.LocalClientId;
            if((X21 & 1) == 0)
            {
                goto label_7;
            }
            
            if((val_2 & 1) == 0)
            {
                goto label_8;
            }
            
            var val_11 = X20;
            if((X20 + 258) == 0)
            {
                goto label_9;
            }
            
            var val_5 = X20 + 152;
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_11:
            if(((X20 + 152 + 8) + -8) == (X21 + 24))
            {
                goto label_10;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < (X20 + 258))
            {
                goto label_11;
            }
            
            label_9:
            val_7 = X20;
            goto label_12;
            label_2:
            if((X21 + 78) != 1)
            {
                goto label_13;
            }
            
            goto label_14;
            label_6:
            label_14:
            label_23:
            label_13:
            label_7:
            if((val_2 & 1) == 0)
            {
                goto label_15;
            }
            
            if((X20 + 258) == 0)
            {
                goto label_16;
            }
            
            var val_7 = X20 + 152;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_18:
            if(((X20 + 152 + 8) + -8) == X21.LocalClientId)
            {
                goto label_17;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (X20 + 258))
            {
                goto label_18;
            }
            
            label_16:
            val_8 = X20;
            goto label_23;
            label_8:
            var val_4 = X20 + ((X21 + 76) << 4);
            val_9 = mem[(X20 + (X21 + 76) << 4) + 280];
            val_9 = (X20 + (X21 + 76) << 4) + 280;
            goto label_23;
            label_15:
            var val_9 = X20;
            val_9 = val_9 + (X21 + 76);
            goto label_23;
            label_10:
            var val_10 = val_5;
            val_10 = val_10 + (X21 + 76);
            val_11 = val_11 + val_10;
            val_7 = val_11 + 272;
            label_12:
            val_9 = mem[((X20 + ((X20 + 152 + 8) + X21 + 76)) + 272) + 8];
            val_9 = ((X20 + ((X20 + 152 + 8) + X21 + 76)) + 272) + 8;
            goto label_23;
            label_17:
            var val_12 = val_7;
            val_12 = val_12 + (X21 + 76);
            val_12 = X20 + val_12;
            val_8 = val_12 + 272;
            goto label_23;
        }
        public virtual System.IAsyncResult BeginInvoke(int result, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
