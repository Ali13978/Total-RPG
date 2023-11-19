using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D, E, F, G> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D, E, F, G>(object object, IntPtr method)
        {
            mem[1152921511395893504] = object;
            mem[1152921511395893512] = method;
            mem[1152921511395893488] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d, E e, F f, G g)
        {
            var val_13;
            object val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_14 = g;
            val_15 = f;
            val_16 = e;
            val_17 = d;
            val_18 = c;
            val_19 = b;
            val_20 = a;
            if(((X26 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if((X26 + 78) != 7)
            {
                goto label_3;
            }
            
            if((X26 + 76) == 65535)
            {
                goto label_26;
            }
            
            if(X27 != 0)
            {
                    if(((X27 + 237) & 1) != 0)
            {
                goto label_26;
            }
            
            }
            
            if((X27 + 237) == 0)
            {
                goto label_26;
            }
            
            long val_2 = X26.LocalClientId;
            if((X26 & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_2 & 1) == 0)
            {
                goto label_9;
            }
            
            var val_17 = X27;
            if((X27 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_11 = X27 + 152;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_12:
            if(((X27 + 152 + 8) + -8) == (X26 + 24))
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (X27 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_22 = X27;
            goto label_13;
            label_2:
            if((X26 + 78) != 7)
            {
                    return;
            }
            
            goto label_26;
            label_3:
            if((X26 + 76) == 65535)
            {
                goto label_19;
            }
            
            if(X27 != 0)
            {
                    if(((X27 + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if((X27 + 237) == 0)
            {
                goto label_19;
            }
            
            val_23 = X26;
            long val_3 = X26.LocalClientId;
            if((val_23 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            val_24 = 0;
            val_24 = val_24 + 1;
            val_25 = val_20;
            goto label_25;
            label_19:
            label_26:
            label_43:
            label_8:
            val_26 = mem[X26 + 76];
            val_26 = X26 + 76;
            if((val_2 & 1) == 0)
            {
                goto label_27;
            }
            
            val_27 = mem[X27];
            val_27 = X27;
            if((X27 + 258) == 0)
            {
                goto label_28;
            }
            
            var val_13 = 0;
            val_24 = (X27 + 152) + 8;
            label_30:
            if(((X27 + 152 + 8) + -8) == X26.LocalClientId)
            {
                goto label_29;
            }
            
            val_13 = val_13 + 1;
            val_24 = val_24 + 16;
            if(val_13 < (X27 + 258))
            {
                goto label_30;
            }
            
            label_28:
            val_28 = X27;
            goto label_31;
            label_20:
            val_23 = mem[X26 + 76];
            val_23 = X26 + 76;
            if((val_3 & 1) == 0)
            {
                goto label_32;
            }
            
            long val_5 = X26.LocalClientId;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_29 = val_20;
            goto label_43;
            label_9:
            var val_6 = X27 + ((X26 + 76) << 4);
            val_30 = mem[(X27 + (X26 + 76) << 4) + 280];
            val_30 = (X27 + (X26 + 76) << 4) + 280;
            goto label_43;
            label_21:
            object val_7 = 1152921504606900224 + ((X26 + 76) << 4);
            val_31 = mem[(1152921504606900224 + (X26 + 76) << 4) + 280];
            goto label_38;
            label_27:
            var val_15 = X27;
            val_15 = val_15 + val_26;
            val_27 = mem[(X27 + X26 + 76) + 272];
            val_27 = (X27 + X26 + 76) + 272;
            goto label_40;
            label_32:
            object val_8 = 1152921504606900224 + val_23;
            val_27 = mem[(1152921504606900224 + X26 + 76) + 272];
            goto label_40;
            label_11:
            var val_16 = val_11;
            val_16 = val_16 + (X26 + 76);
            val_17 = val_17 + val_16;
            val_22 = val_17 + 272;
            label_13:
            val_30 = mem[((X27 + ((X27 + 152 + 8) + X26 + 76)) + 272) + 8];
            val_30 = ((X27 + ((X27 + 152 + 8) + X26 + 76)) + 272) + 8;
            goto label_43;
            label_25:
            val_31 = mem[val_3 + 8];
            val_31 = val_3 + 8;
            label_38:
            val_27 = mem[val_3 + 8];
            val_27 = val_31;
            label_40:
            val_13 = ???;
            val_15 = ???;
            val_14 = ???;
            val_17 = ???;
            val_16 = ???;
            val_19 = ???;
            val_18 = ???;
            val_20 = ???;
            val_26 = ???;
            val_32 = ???;
            goto val_3 + 8;
            label_29:
            val_24 = val_24 + val_26;
            val_24 = val_27 + val_24;
            val_28 = val_24 + 272;
            label_31:
            mem2[0] = ((val_3 + 8 + (val_24 + val_26)) + 272) + 8;
            goto label_43;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, E e, F f, G g, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
