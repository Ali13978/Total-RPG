using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D, E, F> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D, E, F>(object object, IntPtr method)
        {
            mem[1152921511395314432] = object;
            mem[1152921511395314440] = method;
            mem[1152921511395314416] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d, E e, F f)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_13 = f;
            val_14 = e;
            val_15 = d;
            val_16 = c;
            val_17 = b;
            val_18 = a;
            if(((X25 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if((X25 + 78) != 6)
            {
                goto label_3;
            }
            
            if((X25 + 76) == 65535)
            {
                goto label_7;
            }
            
            if(X26 != 0)
            {
                    if(((X26 + 237) & 1) != 0)
            {
                goto label_7;
            }
            
            }
            
            if((X26 + 237) == 0)
            {
                goto label_7;
            }
            
            val_20 = X25;
            long val_2 = X25.LocalClientId;
            if((val_20 & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_2 & 1) == 0)
            {
                goto label_9;
            }
            
            var val_16 = X26;
            if((X26 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_10 = 0;
            val_21 = (X26 + 152) + 8;
            label_12:
            if(((X26 + 152 + 8) + -8) == (X25 + 24))
            {
                goto label_11;
            }
            
            val_10 = val_10 + 1;
            val_21 = val_21 + 16;
            if(val_10 < (X26 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_22 = X26;
            goto label_13;
            label_2:
            if((X25 + 78) != 6)
            {
                    return;
            }
            
            goto label_15;
            label_3:
            if((X25 + 76) == 65535)
            {
                goto label_19;
            }
            
            if(X26 != 0)
            {
                    if(((X26 + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if((X26 + 237) == 0)
            {
                goto label_19;
            }
            
            long val_3 = X25.LocalClientId;
            if((X25 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            val_24 = mem[X25 + 76];
            val_24 = X25 + 76;
            var val_11 = 0;
            val_21 = 1152921504606937096;
            val_11 = val_11 + 1;
            val_25 = val_18;
            goto label_42;
            label_7:
            label_15:
            label_41:
            label_19:
            label_42:
            label_8:
            val_20 = mem[X25 + 76];
            val_20 = X25 + 76;
            if((val_2 & 1) == 0)
            {
                goto label_26;
            }
            
            if((X26 + 258) == 0)
            {
                goto label_27;
            }
            
            var val_12 = X26 + 152;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_29:
            if(((X26 + 152 + 8) + -8) == X25.LocalClientId)
            {
                goto label_28;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (X26 + 258))
            {
                goto label_29;
            }
            
            label_27:
            val_26 = X26;
            goto label_41;
            label_20:
            if((val_3 & 1) == 0)
            {
                goto label_31;
            }
            
            long val_5 = X25.LocalClientId;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_27 = val_18;
            goto label_42;
            label_9:
            var val_6 = X26 + ((X25 + 76) << 4);
            val_28 = mem[(X26 + (X25 + 76) << 4) + 280];
            val_28 = (X26 + (X25 + 76) << 4) + 280;
            goto label_36;
            label_21:
            object val_7 = 1152921504606900224 + ((X25 + 76) << 4);
            val_29 = mem[(1152921504606900224 + (X25 + 76) << 4) + 280];
            goto label_42;
            label_26:
            val_24 = val_17;
            val_23 = X26 + val_20;
            val_30 = mem[(X26 + X25 + 76) + 272];
            val_30 = (X26 + X25 + 76) + 272;
            goto label_38;
            label_31:
            object val_8 = 1152921504606900224 + (X25 + 76);
            goto label_42;
            label_11:
            var val_15 = val_21;
            val_15 = val_15 + (X25 + 76);
            val_16 = val_16 + val_15;
            val_22 = val_16 + 272;
            label_13:
            val_28 = mem[((X26 + ((X26 + 152 + 8) + X25 + 76)) + 272) + 8];
            val_28 = ((X26 + ((X26 + 152 + 8) + X25 + 76)) + 272) + 8;
            label_36:
            val_23 = val_28;
            val_30 = mem[((X26 + ((X26 + 152 + 8) + X25 + 76)) + 272) + 8];
            val_30 = val_23;
            val_24 = val_17;
            label_38:
            val_14 = ???;
            val_13 = ???;
            val_16 = ???;
            val_15 = ???;
            val_18 = ???;
            val_17 = ???;
            val_19 = ???;
            goto ((X26 + ((X26 + 152 + 8) + X25 + 76)) + 272) + 8;
            label_28:
            var val_18 = val_12;
            val_18 = val_18 + val_20;
            val_18 = X26 + val_18;
            val_26 = val_18 + 272;
            goto label_41;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, E e, F f, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
