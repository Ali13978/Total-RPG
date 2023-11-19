using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D, E, F, G, H> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D, E, F, G, H>(object object, IntPtr method)
        {
            mem[1152921511396488960] = object;
            mem[1152921511396488968] = method;
            mem[1152921511396488944] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d, E e, F f, G g, H h)
        {
            var val_12;
            object val_14;
            object val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            object val_25;
            object val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_14 = h;
            val_15 = g;
            val_16 = f;
            val_17 = e;
            val_18 = d;
            val_19 = c;
            val_20 = b;
            object val_1 = a & 1;
            if((val_1 & 1) == 0)
            {
                goto label_2;
            }
            
            if(W9 != 8)
            {
                goto label_3;
            }
            
            if(val_1 == 65535)
            {
                goto label_26;
            }
            
            if(X28 != 0)
            {
                    if(((X28 + 237) & 1) != 0)
            {
                goto label_26;
            }
            
            }
            
            if((X28 + 237) == 0)
            {
                goto label_26;
            }
            
            long val_2 = a.LocalClientId;
            if((a & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_2 & 1) == 0)
            {
                goto label_9;
            }
            
            val_23 = mem[X28];
            val_23 = X28;
            if((X28 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_8 = X28 + 152;
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_12:
            if(((X28 + 152 + 8) + -8) == a)
            {
                goto label_11;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (X28 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_25 = X28;
            goto label_13;
            label_2:
            if(W9 != 8)
            {
                    return;
            }
            
            goto label_26;
            label_3:
            if(val_1 == 65535)
            {
                goto label_19;
            }
            
            if(X28 != 0)
            {
                    if(((X28 + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if((X28 + 237) == 0)
            {
                goto label_19;
            }
            
            long val_3 = a.LocalClientId;
            if((a & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            object val_20 = a;
            if((a + 258) == 0)
            {
                goto label_22;
            }
            
            var val_10 = a + 152;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_24:
            if(((a + 152 + 8) + -8) == a)
            {
                goto label_23;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (a + 258))
            {
                goto label_24;
            }
            
            label_22:
            val_26 = a;
            goto label_43;
            label_19:
            label_26:
            label_43:
            label_8:
            if((val_2 & 1) == 0)
            {
                goto label_27;
            }
            
            if((X28 + 258) == 0)
            {
                goto label_28;
            }
            
            var val_12 = X28 + 152;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_30:
            if(((X28 + 152 + 8) + -8) == a.LocalClientId)
            {
                goto label_29;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (X28 + 258))
            {
                goto label_30;
            }
            
            label_28:
            val_27 = X28;
            goto label_43;
            label_20:
            if((val_3 & 1) == 0)
            {
                goto label_32;
            }
            
            if((a + 258) == 0)
            {
                goto label_33;
            }
            
            var val_14 = a + 152;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_35:
            if(((a + 152 + 8) + -8) == a.LocalClientId)
            {
                goto label_34;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (a + 258))
            {
                goto label_35;
            }
            
            label_33:
            val_28 = a;
            goto label_43;
            label_9:
            var val_6 = X28 + ((X28 + 237) << 4);
            val_29 = mem[(X28 + (X28 + 237) << 4) + 280];
            val_29 = (X28 + (X28 + 237) << 4) + 280;
            goto label_37;
            label_21:
            object val_7 = a + ((X28 + 237) << 4);
            val_30 = mem[(a + (X28 + 237) << 4) + 280];
            val_30 = (a + (X28 + 237) << 4) + 280;
            goto label_43;
            label_27:
            var val_16 = X28;
            val_16 = val_16 + a;
            goto label_43;
            label_32:
            object val_17 = a;
            val_24 = val_19;
            val_17 = val_17 + a;
            val_12 = ???;
            val_15 = ???;
            val_17 = ???;
            val_16 = ???;
            val_19 = ???;
            val_18 = ???;
            val_20 = ???;
            val_14 = ???;
            val_22 = ???;
            val_21 = ???;
            label_11:
            var val_18 = X10;
            val_18 = val_18 + val_24;
            val_17 = val_17 + val_18;
            val_25 = val_17 + 272;
            label_13:
            label_37:
            mem2[0] = val_25;
            mem2[0] = val_14;
            goto label_43;
            label_23:
            var val_19 = val_10;
            val_19 = val_19 + val_20;
            val_20 = val_20 + val_19;
            val_26 = val_20 + 272;
            goto label_43;
            label_29:
            var val_21 = val_12;
            val_21 = val_21 + a;
            val_21 = X28 + val_21;
            val_27 = val_21 + 272;
            goto label_43;
            label_34:
            var val_22 = val_14;
            val_22 = val_22 + a;
            val_22 = a + val_22;
            val_28 = val_22 + 272;
            goto label_43;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, E e, F f, G g, H h, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
