using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D, E, F, G, H, I, J, K> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D, E, F, G, H, I, J, K>(object object, IntPtr method)
        {
            mem[1152921511398373632] = object;
            mem[1152921511398373640] = method;
            mem[1152921511398373616] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_16;
            TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J, K> val_18;
            object val_19;
            object val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            object val_28;
            object val_29;
            object val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_18 = this;
            val_19 = k;
            val_20 = h;
            val_21 = b;
            if(this != null)
            {
                    val_18 = val_18;
                val_19 = val_19;
            }
            
            val_22 = c;
            val_23 = d;
            val_24 = e;
            val_26 = mem[1152921511398534784];
            val_25 = mem[1152921511398534792];
            val_27 = f;
            val_28 = g;
            val_29 = mem[mem[1152921511398534792] + 78];
            val_29 = mem[1152921511398534792] + 78;
            if(((val_25 & 1) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_29 != 11)
            {
                goto label_3;
            }
            
            val_29 = val_19;
            if((mem[1152921511398534792] + 76) == 65535)
            {
                goto label_7;
            }
            
            if(val_26 != 0)
            {
                    if(((mem[1152921511398534784] + 237) & 1) != 0)
            {
                goto label_7;
            }
            
            }
            
            if(mem[1152921511398534776] == 0)
            {
                goto label_7;
            }
            
            if((val_25 & 1) == 0)
            {
                goto label_8;
            }
            
            if((val_25.LocalClientId & 1) == 0)
            {
                goto label_9;
            }
            
            var val_23 = val_26;
            if((mem[1152921511398534784] + 258) == 0)
            {
                goto label_10;
            }
            
            var val_12 = mem[1152921511398534784] + 152;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_12:
            if(((mem[1152921511398534784] + 152 + 8) + -8) == (mem[1152921511398534792] + 24))
            {
                goto label_11;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[1152921511398534784] + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_31 = val_26;
            goto label_13;
            label_2:
            if(val_29 != 11)
            {
                    return;
            }
            
            val_30 = 0;
            goto label_26;
            label_3:
            val_29 = val_19;
            if((mem[1152921511398534792] + 76) == 65535)
            {
                goto label_19;
            }
            
            if(val_26 != 0)
            {
                    if(((mem[1152921511398534784] + 237) & 1) != 0)
            {
                goto label_19;
            }
            
            }
            
            if(mem[1152921511398534776] == 0)
            {
                goto label_19;
            }
            
            long val_3 = val_25.LocalClientId;
            if((val_25 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_21;
            }
            
            object val_25 = a;
            if((a + 258) == 0)
            {
                goto label_22;
            }
            
            var val_14 = a + 152;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_24:
            if(((a + 152 + 8) + -8) == (mem[1152921511398534792] + 24))
            {
                goto label_23;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (a + 258))
            {
                goto label_24;
            }
            
            label_22:
            val_32 = a;
            goto label_44;
            label_7:
            val_30 = val_26;
            goto label_26;
            label_19:
            val_30 = a;
            label_26:
            label_44:
            val_16 = ???;
            val_23 = ???;
            val_21 = ???;
            val_20 = ???;
            val_27 = ???;
            val_28 = ???;
            val_22 = ???;
            val_24 = ???;
            val_26 = ???;
            val_25 = ???;
            goto mem[1152921511398534768];
            label_8:
            if((val_30 & 1) == 0)
            {
                goto label_27;
            }
            
            if((val_26 + 258) == 0)
            {
                goto label_28;
            }
            
            var val_16 = val_26 + 152;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_30:
            if(((val_26 + 152 + 8) + -8) == val_25.LocalClientId)
            {
                goto label_29;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (val_26 + 258))
            {
                goto label_30;
            }
            
            label_28:
            val_33 = val_26;
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
            
            var val_18 = a + 152;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_35:
            if(((a + 152 + 8) + -8) == val_25.LocalClientId)
            {
                goto label_34;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (a + 258))
            {
                goto label_35;
            }
            
            label_33:
            val_34 = a;
            goto label_36;
            label_9:
            var val_6 = val_26 + ((mem[1152921511398534792] + 76) << 4);
            val_35 = mem[(mem[1152921511398534784] + (mem[1152921511398534792] + 76) << 4) + 280];
            val_35 = (mem[1152921511398534784] + (mem[1152921511398534792] + 76) << 4) + 280;
            goto label_44;
            label_21:
            object val_7 = a + ((mem[1152921511398534792] + 76) << 4);
            goto label_44;
            label_27:
            var val_20 = val_26;
            val_20 = val_20 + (val_25 + 76);
            val_36 = mem[(val_26 + val_25 + 76) + 272 + 8];
            val_36 = (val_26 + val_25 + 76) + 272 + 8;
            goto label_39;
            label_32:
            object val_21 = a;
            val_21 = val_21 + (mem[1152921511398534792] + 76);
            val_37 = mem[(a + mem[1152921511398534792] + 76) + 272 + 8];
            val_37 = (a + mem[1152921511398534792] + 76) + 272 + 8;
            goto label_44;
            label_11:
            var val_22 = val_12;
            val_22 = val_22 + (mem[1152921511398534792] + 76);
            val_23 = val_23 + val_22;
            val_31 = val_23 + 272;
            label_13:
            val_35 = mem[((mem[1152921511398534784] + ((mem[1152921511398534784] + 152 + 8) + mem[1152921511398534792] + 76)) + 272) + 8];
            val_35 = ((mem[1152921511398534784] + ((mem[1152921511398534784] + 152 + 8) + mem[1152921511398534792] + 76)) + 272) + 8;
            goto label_44;
            label_23:
            var val_24 = val_14;
            val_24 = val_24 + (mem[1152921511398534792] + 76);
            val_25 = val_25 + val_24;
            val_32 = val_25 + 272;
            goto label_44;
            label_29:
            var val_26 = val_16;
            val_26 = val_26 + (val_25 + 76);
            val_26 = val_26 + val_26;
            val_33 = val_26 + 272;
            label_31:
            val_36 = mem[((val_26 + ((val_26 + 152 + 8) + val_25 + 76)) + 272) + 8];
            val_36 = ((val_26 + ((val_26 + 152 + 8) + val_25 + 76)) + 272) + 8;
            label_39:
            mem2[0] = val_36;
            mem2[0] = val_8;
            mem2[0] = val_9;
            mem2[0] = val_10;
            mem2[0] = val_20;
            goto label_44;
            label_34:
            var val_27 = val_18;
            val_27 = val_27 + (mem[1152921511398534792] + 76);
            val_27 = a + val_27;
            val_34 = val_27 + 272;
            label_36:
            val_37 = mem[((a + ((a + 152 + 8) + mem[1152921511398534792] + 76)) + 272) + 8];
            val_37 = ((a + ((a + 152 + 8) + mem[1152921511398534792] + 76)) + 272) + 8;
            goto label_44;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
