using UnityEngine;

namespace I2.Loc
{
    public class HindiFixer
    {
        // Fields
        private static System.Func<char, bool> <>f__am$cache0;
        
        // Methods
        public HindiFixer()
        {
        
        }
        internal static string Fix(string text)
        {
            var val_10;
            var val_11;
            int val_12;
            System.Func<System.Char, System.Boolean> val_13;
            string val_14;
            System.Char[] val_1 = X1.ToCharArray();
            val_10 = 0;
            goto label_2;
            label_67:
            val_10 = 1;
            label_2:
            var val_2 = val_10 + 1;
            if(val_2 >= val_1.Length)
            {
                goto label_4;
            }
            
            if(val_1[(long)val_2] == 'ि')
            {
                    char val_20 = val_1[1];
                if((System.Char.IsWhiteSpace(c:  ' ')) != true)
            {
                    val_11 = mem[val_1[0x1] + 32];
                val_11 = val_1[0x1] + 32;
                if(val_11 != 0)
            {
                    val_12 = val_1.Length;
                if(val_10 >= val_12)
            {
                    val_11 = mem[val_1[0x1] + 32];
                val_11 = val_1[0x1] + 32;
                val_12 = val_1.Length;
            }
            
                mem2[0] = val_11;
                mem2[0] = 2367;
            }
            
            }
            
            }
            
            if(val_2 == (val_1.Length - 1))
            {
                goto label_67;
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2311)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2316;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2371)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2372;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2305)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2384;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2315)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2400;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2312)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2401;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2367)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2402;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) == 2368)
            {
                    if((val_1[(long)val_10 + 2]) == '़')
            {
                    mem2[0] = 2403;
                mem2[0] = 0;
            }
            
            }
            
            if((val_1[(long)(int)((val_10 + 1))] + 32) != 2404)
            {
                goto label_67;
            }
            
            if((val_1[(long)val_10 + 2]) != '़')
            {
                goto label_67;
            }
            
            mem2[0] = 2365;
            mem2[0] = 0;
            goto label_67;
            label_4:
            if((0 & 1) != 0)
            {
                    val_13 = I2.Loc.HindiFixer.<>f__am$cache0;
                if(val_13 == null)
            {
                    I2.Loc.HindiFixer.<>f__am$cache0 = new System.Func<System.Char, System.Boolean>(object:  0, method:  static System.Boolean I2.Loc.HindiFixer::<Fix>m__0(char x));
                val_13 = I2.Loc.HindiFixer.<>f__am$cache0;
            }
            
                System.Collections.Generic.IEnumerable<TSource> val_15 = System.Linq.Enumerable.Where<System.Char>(source:  0, predicate:  val_1);
                val_14 = 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  0));
                bool val_18 = System.String.op_Equality(a:  0, b:  val_14);
                return (string)val_14;
            }
            
            val_14 = X1;
            return (string)val_14;
        }
        private static bool <Fix>m__0(char x)
        {
            return (bool)(W1 != 65535) ? 1 : 0;
        }
    
    }

}
