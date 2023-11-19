using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D, E, F, G, H, I, J> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D, E, F, G, H, I, J>(object object, IntPtr method)
        {
            mem[1152921511397729024] = object;
            mem[1152921511397729032] = method;
            mem[1152921511397729008] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j)
        {
            var val_8;
            var val_9;
            var val_15;
            TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J> val_17;
            object val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            object val_26;
            var val_27;
            object val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_17 = this;
            val_18 = h;
            val_19 = c;
            val_20 = b;
            if(this != null)
            {
                    val_17 = val_17;
            }
            
            val_21 = d;
            val_22 = e;
            val_23 = f;
            val_25 = mem[1152921511397886080];
            val_24 = mem[1152921511397886088];
            val_26 = g;
            val_27 = mem[mem[1152921511397886088] + 78];
            val_27 = mem[1152921511397886088] + 78;
            if(((val_24 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_27 != 10)
            {
                goto label_3;
            }
            
            val_27 = 65535;
            if((mem[1152921511397886088] + 76) == val_27)
            {
                goto label_7;
            }
            
            if(val_25 != 0)
            {
                    if(((mem[1152921511397886080] + 237) & 1) != 0)
            {
                goto label_7;
            }
            
            }
            
            if(mem[1152921511397886072] == 0)
            {
                goto label_7;
            }
            
            if((val_24 & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_24.LocalClientId & 1) == 0)
            {
                goto label_9;
            }
            
            var val_22 = val_25;
            if((mem[1152921511397886080] + 258) == 0)
            {
                goto label_10;
            }
            
            var val_11 = mem[1152921511397886080] + 152;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_12:
            if(((mem[1152921511397886080] + 152 + 8) + -8) == (mem[1152921511397886088] + 24))
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (mem[1152921511397886080] + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_29 = val_25;
            goto label_13;
            label_2:
            if(val_27 != 10)
            {
                    return;
            }
            
            val_28 = 0;
            goto label_26;
            label_3:
            val_27 = 65535;
            if((mem[1152921511397886088] + 76) == val_27)
            {
                goto label_19;
            }
            
            if(val_25 != 0)
            {
                    if(((mem[1152921511397886080] + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if(mem[1152921511397886072] == 0)
            {
                goto label_19;
            }
            
            long val_3 = val_24.LocalClientId;
            if((val_24 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            object val_24 = a;
            if((a + 258) == 0)
            {
                goto label_22;
            }
            
            var val_13 = a + 152;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_24:
            if(((a + 152 + 8) + -8) == (mem[1152921511397886088] + 24))
            {
                goto label_23;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (a + 258))
            {
                goto label_24;
            }
            
            label_22:
            val_30 = a;
            goto label_44;
            label_7:
            val_28 = val_25;
            goto label_26;
            label_19:
            val_28 = a;
            label_26:
            label_44:
            val_15 = ???;
            val_19 = ???;
            val_26 = ???;
            val_20 = ???;
            val_22 = ???;
            val_23 = ???;
            val_18 = ???;
            val_21 = ???;
            val_25 = ???;
            val_24 = ???;
            goto mem[1152921511397886064];
            label_8:
            if((val_28 & 1) == 0)
            {
                goto label_27;
            }
            
            if((val_25 + 258) == 0)
            {
                goto label_28;
            }
            
            var val_15 = val_25 + 152;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_30:
            if(((val_25 + 152 + 8) + -8) == val_24.LocalClientId)
            {
                goto label_29;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (val_25 + 258))
            {
                goto label_30;
            }
            
            label_28:
            val_31 = val_25;
            goto label_31;
            label_20:
            if((val_3 & 1) == 0)
            {
                goto label_32;
            }
            
            if((a + 258) == 0)
            {
                goto label_33;
            }
            
            var val_17 = a + 152;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_35:
            if(((a + 152 + 8) + -8) == val_24.LocalClientId)
            {
                goto label_34;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (a + 258))
            {
                goto label_35;
            }
            
            label_33:
            val_32 = a;
            goto label_36;
            label_9:
            var val_6 = val_25 + ((mem[1152921511397886088] + 76) << 4);
            val_33 = mem[(mem[1152921511397886080] + (mem[1152921511397886088] + 76) << 4) + 280];
            val_33 = (mem[1152921511397886080] + (mem[1152921511397886088] + 76) << 4) + 280;
            goto label_44;
            label_21:
            object val_7 = a + ((mem[1152921511397886088] + 76) << 4);
            goto label_44;
            label_27:
            var val_19 = val_25;
            val_19 = val_19 + (val_24 + 76);
            val_34 = mem[(val_25 + val_24 + 76) + 272 + 8];
            val_34 = (val_25 + val_24 + 76) + 272 + 8;
            goto label_39;
            label_32:
            object val_20 = a;
            val_20 = val_20 + (mem[1152921511397886088] + 76);
            val_35 = mem[(a + mem[1152921511397886088] + 76) + 272 + 8];
            val_35 = (a + mem[1152921511397886088] + 76) + 272 + 8;
            goto label_44;
            label_11:
            var val_21 = val_11;
            val_21 = val_21 + (mem[1152921511397886088] + 76);
            val_22 = val_22 + val_21;
            val_29 = val_22 + 272;
            label_13:
            val_33 = mem[((mem[1152921511397886080] + ((mem[1152921511397886080] + 152 + 8) + mem[1152921511397886088] + 76)) + 272) + 8];
            val_33 = ((mem[1152921511397886080] + ((mem[1152921511397886080] + 152 + 8) + mem[1152921511397886088] + 76)) + 272) + 8;
            goto label_44;
            label_23:
            var val_23 = val_13;
            val_23 = val_23 + (mem[1152921511397886088] + 76);
            val_24 = val_24 + val_23;
            val_30 = val_24 + 272;
            goto label_44;
            label_29:
            var val_25 = val_15;
            val_25 = val_25 + (val_24 + 76);
            val_25 = val_25 + val_25;
            val_31 = val_25 + 272;
            label_31:
            val_34 = mem[((val_25 + ((val_25 + 152 + 8) + val_24 + 76)) + 272) + 8];
            val_34 = ((val_25 + ((val_25 + 152 + 8) + val_24 + 76)) + 272) + 8;
            label_39:
            mem2[0] = val_34;
            mem2[0] = val_8;
            mem2[0] = val_9;
            mem2[0] = val_18;
            goto label_44;
            label_34:
            var val_26 = val_17;
            val_26 = val_26 + (mem[1152921511397886088] + 76);
            val_26 = a + val_26;
            val_32 = val_26 + 272;
            label_36:
            val_35 = mem[((a + ((a + 152 + 8) + mem[1152921511397886088] + 76)) + 272) + 8];
            val_35 = ((a + ((a + 152 + 8) + mem[1152921511397886088] + 76)) + 272) + 8;
            goto label_44;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
