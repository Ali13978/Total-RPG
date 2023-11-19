using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D>(object object, IntPtr method)
        {
            mem[1152921511394205440] = object;
            mem[1152921511394205448] = method;
            mem[1152921511394205424] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if(((X23 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if((X23 + 78) != 4)
            {
                goto label_3;
            }
            
            if((X23 + 76) == 65535)
            {
                goto label_7;
            }
            
            if(X24 != 0)
            {
                    if(((X24 + 237) & 1) != 0)
            {
                goto label_7;
            }
            
            }
            
            if((X24 + 237) == 0)
            {
                goto label_7;
            }
            
            long val_2 = X23.LocalClientId;
            if((X23 & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_2 & 1) == 0)
            {
                goto label_9;
            }
            
            var val_19 = X24;
            if((X24 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_11 = X24 + 152;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_12:
            if(((X24 + 152 + 8) + -8) == (X23 + 24))
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (X24 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_13 = X24;
            goto label_13;
            label_2:
            if((X23 + 78) != 4)
            {
                goto label_14;
            }
            
            goto label_15;
            label_3:
            if((X23 + 76) == 65535)
            {
                goto label_19;
            }
            
            if(X24 != 0)
            {
                    if(((X24 + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if((X24 + 237) == 0)
            {
                goto label_19;
            }
            
            long val_3 = X23.LocalClientId;
            if((X23 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = a;
            goto label_25;
            label_14:
            label_7:
            label_15:
            label_42:
            label_19:
            label_43:
            label_8:
            if((val_2 & 1) == 0)
            {
                goto label_26;
            }
            
            if((X24 + 258) == 0)
            {
                goto label_27;
            }
            
            var val_14 = X24 + 152;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_29:
            if(((X24 + 152 + 8) + -8) == X23.LocalClientId)
            {
                goto label_28;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (X24 + 258))
            {
                goto label_29;
            }
            
            label_27:
            val_15 = X24;
            goto label_42;
            label_20:
            if((val_3 & 1) == 0)
            {
                goto label_31;
            }
            
            long val_5 = X23.LocalClientId;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = a;
            goto label_43;
            label_9:
            var val_6 = X24 + ((X23 + 76) << 4);
            val_17 = mem[(X24 + (X23 + 76) << 4) + 280];
            val_17 = (X24 + (X23 + 76) << 4) + 280;
            goto label_42;
            label_21:
            object val_7 = 1152921504606900224 + ((X23 + 76) << 4);
            val_18 = mem[(1152921504606900224 + (X23 + 76) << 4) + 280];
            goto label_43;
            label_26:
            var val_17 = X24;
            val_17 = val_17 + (X23 + 76);
            goto label_42;
            label_31:
            object val_8 = 1152921504606900224 + (X23 + 76);
            goto label_43;
            label_11:
            var val_18 = val_11;
            val_18 = val_18 + (X23 + 76);
            val_19 = val_19 + val_18;
            val_13 = val_19 + 272;
            label_13:
            val_17 = mem[((X24 + ((X24 + 152 + 8) + X23 + 76)) + 272) + 8];
            val_17 = ((X24 + ((X24 + 152 + 8) + X23 + 76)) + 272) + 8;
            goto label_42;
            label_25:
            val_18 = mem[val_3 + 8];
            val_18 = val_3 + 8;
            goto label_43;
            label_28:
            var val_20 = val_14;
            val_20 = val_20 + (X23 + 76);
            val_20 = X24 + val_20;
            val_15 = val_20 + 272;
            goto label_42;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
