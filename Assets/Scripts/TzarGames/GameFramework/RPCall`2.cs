using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B>(object object, IntPtr method)
        {
            mem[1152921511393161984] = object;
            mem[1152921511393161992] = method;
            mem[1152921511393161968] = method;
        }
        public virtual void Invoke(A a, B b)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if(this != null)
            {
                    val_13 = b;
            }
            
            if(((X21 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if((X21 + 78) != 2)
            {
                goto label_3;
            }
            
            if((X21 + 76) == 65535)
            {
                goto label_7;
            }
            
            if(X22 != 0)
            {
                    if(((X22 + 237) & 1) != 0)
            {
                goto label_7;
            }
            
            }
            
            if((X22 + 237) == 0)
            {
                goto label_7;
            }
            
            long val_2 = X21.LocalClientId;
            if((X21 & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_2 & 1) == 0)
            {
                goto label_9;
            }
            
            var val_19 = X22;
            if((X22 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_11 = X22 + 152;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_12:
            if(((X22 + 152 + 8) + -8) == (X21 + 24))
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (X22 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_14 = X22;
            goto label_13;
            label_2:
            if((X21 + 78) != 2)
            {
                goto label_14;
            }
            
            goto label_15;
            label_3:
            if((X21 + 76) == 65535)
            {
                goto label_19;
            }
            
            if(X22 != 0)
            {
                    if(((X22 + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if((X22 + 237) == 0)
            {
                goto label_19;
            }
            
            long val_3 = X21.LocalClientId;
            if((X21 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = a;
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
            
            if((X22 + 258) == 0)
            {
                goto label_27;
            }
            
            var val_14 = X22 + 152;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_29:
            if(((X22 + 152 + 8) + -8) == X21.LocalClientId)
            {
                goto label_28;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (X22 + 258))
            {
                goto label_29;
            }
            
            label_27:
            val_16 = X22;
            goto label_42;
            label_20:
            if((val_3 & 1) == 0)
            {
                goto label_31;
            }
            
            long val_5 = X21.LocalClientId;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = a;
            val_13 = X21 + 76;
            goto label_43;
            label_9:
            var val_6 = X22 + ((X21 + 76) << 4);
            val_18 = mem[(X22 + (X21 + 76) << 4) + 280];
            val_18 = (X22 + (X21 + 76) << 4) + 280;
            goto label_42;
            label_21:
            object val_7 = 1152921504606900224 + ((X21 + 76) << 4);
            val_19 = mem[(1152921504606900224 + (X21 + 76) << 4) + 280];
            goto label_43;
            label_26:
            var val_17 = X22;
            val_17 = val_17 + (X21 + 76);
            goto label_42;
            label_31:
            object val_8 = 1152921504606900224 + (X21 + 76);
            goto label_43;
            label_11:
            var val_18 = val_11;
            val_18 = val_18 + (X21 + 76);
            val_19 = val_19 + val_18;
            val_14 = val_19 + 272;
            label_13:
            val_18 = mem[((X22 + ((X22 + 152 + 8) + X21 + 76)) + 272) + 8];
            val_18 = ((X22 + ((X22 + 152 + 8) + X21 + 76)) + 272) + 8;
            goto label_42;
            label_25:
            val_19 = mem[val_3 + 8];
            val_19 = val_3 + 8;
            goto label_43;
            label_28:
            var val_20 = val_14;
            val_20 = val_20 + (X21 + 76);
            val_20 = X22 + val_20;
            val_16 = val_20 + 272;
            goto label_42;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
