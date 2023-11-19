using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Database<T> : CommonDatabase
    {
        // Fields
        [UnityEngine.HideInInspector]
        public int idCount;
        public System.Collections.Generic.List<T> items;
        
        // Methods
        public Database<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public T GetItemByID(int id)
        {
            var val_1;
            var val_2;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_7 = val_2.InitializationCallback;
            if(val_7.Clone() != id)
            {
                goto label_4;
            }
            
            val_8 = 0;
            val_9 = 89;
            goto label_6;
            label_2:
            val_8 = 0;
            val_7 = 0;
            val_9 = 82;
            label_6:
            val_2 = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 24 + 168 + 32 + 152;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_9:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258))
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            val_10 = ((__RuntimeMethodHiddenParam + 24 + 168 + 32) + (((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8)) << 4)) + 272;
            label_10:
            if(82 != 82)
            {
                    if(82 == 89)
            {
                    return (object)val_7;
            }
            
            }
            
            val_7 = 0;
            return (object)val_7;
        }
        public T[] GetAllItemsOfType(System.Type type)
        {
            var val_1;
            var val_2;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = type;
            val_9 = 0;
            if(val_8 == null)
            {
                    return (T[])val_9;
            }
            
            if(true == 0)
            {
                    return (T[])val_9;
            }
            
            label_11:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = val_2.InitializationCallback;
            if(((0 == val_3) || (val_3.GetType() != val_8)) || ((__RuntimeMethodHiddenParam + 24 + 168 + 40) != 0))
            {
                goto label_11;
            }
            
            goto label_11;
            label_4:
            val_8 = 0;
            val_10 = 124;
            val_2 = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258) == 0)
            {
                goto label_16;
            }
            
            var val_7 = __RuntimeMethodHiddenParam + 24 + 168 + 32 + 152;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_15:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            val_11 = ((__RuntimeMethodHiddenParam + 24 + 168 + 32) + (((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8)) << 4)) + 272;
            label_16:
            val_9 = __RuntimeMethodHiddenParam + 24 + 168 + 40;
            return (T[])val_9;
        }
        public T[] GetAllItemsThatContainsText(string text)
        {
            var val_2;
            var val_3;
            var val_11;
            do
            {
                label_9:
                if((0 & 1) == 0)
            {
                goto label_17;
            }
            
            }
            while((val_3.InitializationCallback.ToString().ToLower().Contains(value:  text.ToLower())) == false);
            
            if((__RuntimeMethodHiddenParam + 24 + 168 + 40) != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_17:
            val_3 = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            val_2 = val_3;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258) == 0)
            {
                goto label_13;
            }
            
            var val_10 = __RuntimeMethodHiddenParam + 24 + 168 + 32 + 152;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_12:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_11 = ((__RuntimeMethodHiddenParam + 24 + 168 + 32) + (((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8)) << 4)) + 272;
            label_13:
            if((__RuntimeMethodHiddenParam + 24 + 168 + 40) != 0)
            {
                    return (T[])__RuntimeMethodHiddenParam + 24 + 168 + 40;
            }
            
            return (T[])__RuntimeMethodHiddenParam + 24 + 168 + 40;
        }
        public override bool Check()
        {
            var val_2;
            var val_3;
            var val_10;
            var val_21;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_45;
            val_33 = __RuntimeMethodHiddenParam;
            bool val_1 = this.Check();
            if(val_1 == false)
            {
                goto label_2;
            }
            
            val_34 = 1152921504718028800;
            val_35 = 0;
            val_36 = 0;
            goto label_52;
            label_2:
            val_37 = 0;
            return (bool)val_37 & 1;
            label_13:
            if((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258) == 0)
            {
                goto label_9;
            }
            
            var val_29 = __RuntimeMethodHiddenParam + 24 + 168 + 32 + 152;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_8:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            val_39 = ((__RuntimeMethodHiddenParam + 24 + 168 + 32) + (((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8)) << 4)) + 272;
            label_9:
            val_35 = 0;
            val_36 = val_1;
            if(W25 == 403)
            {
                goto label_52;
            }
            
            val_36 = 0;
            val_35 = W25;
            if(val_1 == false)
            {
                goto label_52;
            }
            
            val_36 = 0;
            val_35 = W25;
            goto label_52;
            label_27:
            val_40 = 230;
            goto label_15;
            label_52:
            if((0 & 1) == 0)
            {
                goto label_95;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_3.InitializationCallback;
            if(0 != val_5)
            {
                goto label_19;
            }
            
            string val_7 = this.name;
            string val_8 = 0 + "Null item ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_52;
            label_19:
            label_41:
            if((0 & 1) == 0)
            {
                goto label_27;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_11 = val_10.InitializationCallback;
            if(0 != val_11)
            {
                goto label_30;
            }
            
            string val_13 = this.name;
            string val_14 = 0 + "Null item ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_41;
            label_30:
            if((val_11.Clone() != val_5.Clone()) || ((__RuntimeMethodHiddenParam + 24 + 168 + 40) != 0))
            {
                goto label_41;
            }
            
            goto label_41;
            label_15:
            if((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258) == 0)
            {
                goto label_46;
            }
            
            var val_31 = __RuntimeMethodHiddenParam + 24 + 168 + 32 + 152;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_45:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8) + -8) == null)
            {
                goto label_44;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258))
            {
                goto label_45;
            }
            
            goto label_46;
            label_44:
            val_41 = ((__RuntimeMethodHiddenParam + 24 + 168 + 32) + (((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8)) << 4)) + 272;
            label_46:
            if( == 230)
            {
                
            }
            else
            {
                    if((__RuntimeMethodHiddenParam + 24 + 168 + 40) != 0)
            {
                
            }
            
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 168 + 40) < 2)
            {
                goto label_52;
            }
            
            string val_19 = 0 + this.name;
            UnityEngine.Debug.LogError(message:  0);
            if((__RuntimeMethodHiddenParam + 24 + 168 + 40) != 0)
            {
                goto label_59;
            }
            
            goto label_59;
            label_86:
            label_59:
            if((0 & 1) == 0)
            {
                goto label_13;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_22 = val_21.InitializationCallback;
            val_42 = 0;
            string val_23 = val_22.name;
            if(val_23 != null)
            {
                    val_42 = mem[null + 48];
                if(val_23 == null)
            {
                    val_42 = 0;
            }
            
            }
            
            val_42 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_23;
            val_42 = mem[null + 48];
            if(" " == null)
            {
                    val_42 = 0;
            }
            
            val_42 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_28 = " ";
            val_43 = public System.String System.Object::ToString();
            string val_24 = val_22.ToString();
            if(val_24 != null)
            {
                    val_43 = mem[null + 48];
                if(val_24 == null)
            {
                    val_43 = 0;
            }
            
            }
            
            val_43 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_24;
            val_43 = mem[null + 48];
            if((" ID: ") == null)
            {
                    val_43 = 0;
            }
            
            val_43 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_38 = " ID: ";
            typeof(System.Object[]).__il2cppRuntimeField_40 = val_22.Clone();
            typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
            string val_26 = +0;
            UnityEngine.Debug.LogError(message:  0);
            goto label_86;
            label_95:
            val_33 = mem[__RuntimeMethodHiddenParam + 24 + 168 + 32];
            val_33 = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            val_3 = val_33;
            val_2 = val_3;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258) == 0)
            {
                goto label_92;
            }
            
            var val_33 = __RuntimeMethodHiddenParam + 24 + 168 + 32 + 152;
            var val_34 = 0;
            val_33 = val_33 + 8;
            label_91:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8) + -8) == null)
            {
                goto label_90;
            }
            
            val_34 = val_34 + 1;
            val_33 = val_33 + 16;
            if(val_34 < (__RuntimeMethodHiddenParam + 24 + 168 + 32 + 258))
            {
                goto label_91;
            }
            
            goto label_92;
            label_90:
            val_45 = (val_33 + (((__RuntimeMethodHiddenParam + 24 + 168 + 32 + 152 + 8)) << 4)) + 272;
            label_92:
            val_37 = 0;
            return (bool)val_37 & 1;
        }
    
    }

}
