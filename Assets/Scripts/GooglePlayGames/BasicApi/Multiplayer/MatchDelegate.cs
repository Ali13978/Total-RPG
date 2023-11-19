using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public sealed class MatchDelegate : MulticastDelegate
    {
        // Methods
        public MatchDelegate(object object, IntPtr method)
        {
            mem[1152921511868760064] = object;
            mem[1152921511868760072] = method;
            mem[1152921511868760048] = method;
        }
        public virtual void Invoke(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool shouldAutoLaunch)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            if(this != null)
            {
                    val_23 = shouldAutoLaunch;
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
            
            var val_29 = X22;
            if((X22 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_21 = X22 + 152;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_12:
            if(((X22 + 152 + 8) + -8) == (X21 + 24))
            {
                goto label_11;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (X22 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_24 = X22;
            goto label_13;
            label_2:
            if((X21 + 78) != 2)
            {
                goto label_14;
            }
            
            bool val_3 = shouldAutoLaunch;
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
            
            long val_4 = X21.LocalClientId;
            if((X21 & 1) == 0)
            {
                goto label_20;
            }
            
            if((val_4 & 1) == 0)
            {
                goto label_21;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = match;
            goto label_25;
            label_14:
            bool val_5 = shouldAutoLaunch;
            label_7:
            bool val_6 = shouldAutoLaunch;
            label_15:
            label_42:
            label_19:
            bool val_7 = shouldAutoLaunch;
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
            
            var val_24 = X22 + 152;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_29:
            if(((X22 + 152 + 8) + -8) == X21.LocalClientId)
            {
                goto label_28;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < (X22 + 258))
            {
                goto label_29;
            }
            
            label_27:
            val_26 = X22;
            goto label_30;
            label_20:
            if((val_4 & 1) == 0)
            {
                goto label_31;
            }
            
            long val_9 = X21.LocalClientId;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = match;
            val_23 = X21 + 76;
            goto label_35;
            label_9:
            var val_10 = X22 + ((X21 + 76) << 4);
            val_28 = mem[(X22 + (X21 + 76) << 4) + 280];
            val_28 = (X22 + (X21 + 76) << 4) + 280;
            goto label_36;
            label_21:
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_11 = 1152921504939646976 + ((X21 + 76) << 4);
            val_29 = mem[(1152921504939646976 + (X21 + 76) << 4) + 280];
            goto label_37;
            label_26:
            var val_27 = X22;
            bool val_12 = shouldAutoLaunch;
            val_27 = val_27 + (X21 + 76);
            goto label_42;
            label_31:
            bool val_13 = shouldAutoLaunch;
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_14 = 1152921504939646976 + (X21 + 76);
            goto label_43;
            label_11:
            var val_28 = val_21;
            val_28 = val_28 + (X21 + 76);
            val_29 = val_29 + val_28;
            val_24 = val_29 + 272;
            label_13:
            val_28 = mem[((X22 + ((X22 + 152 + 8) + X21 + 76)) + 272) + 8];
            val_28 = ((X22 + ((X22 + 152 + 8) + X21 + 76)) + 272) + 8;
            label_36:
            bool val_15 = shouldAutoLaunch;
            goto label_42;
            label_25:
            val_29 = mem[val_4 + 8];
            val_29 = val_4 + 8;
            label_37:
            bool val_17 = shouldAutoLaunch;
            goto label_43;
            label_28:
            var val_30 = val_24;
            val_30 = val_30 + (X21 + 76);
            val_30 = X22 + val_30;
            val_26 = val_30 + 272;
            label_30:
            bool val_18 = shouldAutoLaunch;
            goto label_42;
            label_35:
            bool val_20 = shouldAutoLaunch;
            goto label_43;
        }
        public virtual System.IAsyncResult BeginInvoke(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool shouldAutoLaunch, System.AsyncCallback callback, object object)
        {
            bool val_1 = shouldAutoLaunch;
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
