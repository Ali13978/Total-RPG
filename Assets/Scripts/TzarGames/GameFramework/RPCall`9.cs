using UnityEngine;

namespace TzarGames.GameFramework
{
    public sealed class RPCall<A, B, C, D, E, F, G, H, I> : MulticastDelegate
    {
        // Methods
        public RPCall<A, B, C, D, E, F, G, H, I>(object object, IntPtr method)
        {
            mem[1152921511397100800] = object;
            mem[1152921511397100808] = method;
            mem[1152921511397100784] = method;
        }
        public virtual void Invoke(A a, B b, C c, D d, E e, F f, G g, H h, I i)
        {
            var val_13;
            object val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            object val_1 = a & 1;
            if((val_1 & 1) == 0)
            {
                goto label_2;
            }
            
            if(W9 != 9)
            {
                goto label_3;
            }
            
            if(val_1 == 65535)
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
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = i;
            goto label_13;
            label_2:
            if(W9 != 9)
            {
                    return;
            }
            
            goto label_26;
            label_3:
            if(val_1 == 65535)
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
                goto label_44;
            }
            
            object val_19 = a;
            if((a + 258) == 0)
            {
                goto label_22;
            }
            
            var val_12 = a + 152;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_24:
            if(((a + 152 + 8) + -8) == a)
            {
                goto label_23;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (a + 258))
            {
                goto label_24;
            }
            
            label_22:
            val_14 = a;
            goto label_44;
            label_19:
            label_26:
            label_44:
            label_8:
            if((val_2 & 1) == 0)
            {
                goto label_27;
            }
            
            long val_4 = a.LocalClientId;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = i;
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
            
            var val_15 = a + 152;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_35:
            if(((a + 152 + 8) + -8) == a.LocalClientId)
            {
                goto label_34;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (a + 258))
            {
                goto label_35;
            }
            
            label_33:
            val_16 = a;
            goto label_44;
            label_9:
            val_17 = mem[(1152921504606900224 + (typeof(System.Object).__il2cppRuntimeField_ED) << 4) + 280];
            goto label_44;
            label_27:
            object val_8 = 1152921504606900224 + a;
            val_18 = mem[(1152921504606900224 + a) + 272 + 8];
            goto label_44;
            label_32:
            object val_17 = a;
            val_17 = val_17 + a;
            goto label_44;
            label_13:
            val_17 = mem[val_2 + 8];
            val_17 = val_2 + 8;
            goto label_44;
            label_23:
            var val_18 = val_12;
            val_18 = val_18 + b;
            val_19 = val_19 + val_18;
            val_14 = val_19 + 272;
            goto label_44;
            label_31:
            val_18 = mem[val_4 + 8];
            val_18 = val_4 + 8;
            goto label_44;
            label_34:
            var val_20 = val_15;
            val_20 = val_20 + a;
            val_20 = a + val_20;
            val_16 = val_20 + 272;
            goto label_44;
        }
        public virtual System.IAsyncResult BeginInvoke(A a, B b, C c, D d, E e, F f, G g, H h, I i, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
