using UnityEngine;

namespace I2.Loc
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class I2Utils
    {
        // Fields
        private static System.Func<char, bool> <>f__am$cache0;
        
        // Methods
        public static string ReverseText(string source)
        {
            var val_5;
            var val_6;
            val_5 = X1.Length;
            val_6 = val_5 - 1;
            if()
            {
                    return 0.CreateString(val:  null);
            }
            
            do
            {
                var val_3 = null + (((long)(int)((val_1 - 1))) << 1);
                val_6 = val_6 - 1;
                val_5 = 0 + 1;
                mem2[0] = X1.Chars[0];
            }
            while(val_6 != 1);
            
            return 0.CreateString(val:  null);
        }
        public static string RemoveNonASCII(string text, bool allowCategory = False)
        {
            typeof(I2Utils.<RemoveNonASCII>c__AnonStorey0).__il2cppRuntimeField_10 = W2 & 1;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return (string)allowCategory;
            }
            
            System.Func<System.Char, System.Char> val_6 = new System.Func<System.Char, System.Char>(object:  new System.Object(), method:  System.Char I2Utils.<RemoveNonASCII>c__AnonStorey0::<>m__0(char c));
            System.Collections.Generic.IEnumerable<TResult> val_7 = System.Linq.Enumerable.Select<System.Char, System.Char>(source:  0, selector:  allowCategory.ToCharArray());
            return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  0));
        }
        public static string SplitLine(string line, int maxCharacters)
        {
            IntPtr val_9;
            var val_10;
            System.Func<System.Char, System.Boolean> val_11;
            char val_12;
            System.Func<System.Char, System.Boolean> val_13;
            val_9 = W2;
            if(val_9 < 1)
            {
                    return (string)maxCharacters;
            }
            
            if(maxCharacters.Length < val_9)
            {
                    return (string)maxCharacters;
            }
            
            System.Char[] val_2 = maxCharacters.ToCharArray();
            var val_10 = 0;
            val_10 = 0;
            val_11 = 1;
            goto label_5;
            label_31:
            val_10 = 1;
            label_5:
            if(val_10 >= val_2.Length)
            {
                goto label_7;
            }
            
            if((val_11 & 1) == 0)
            {
                goto label_8;
            }
            
            val_10 = val_10 + 1;
            val_12 = val_2[1];
            if(((val_12 == '
            ') ? 0 : (val_10)) < val_9)
            {
                goto label_31;
            }
            
            if(val_10 >= val_2.Length)
            {
                    val_12 = mem[val_2[0x1] + 32];
                val_12 = val_2[0x1] + 32;
            }
            
            if((System.Char.IsWhiteSpace(c:  ' ')) == false)
            {
                goto label_31;
            }
            
            mem2[0] = 10;
            goto label_31;
            label_8:
            char val_11 = val_2[1];
            if((System.Char.IsWhiteSpace(c:  ' ')) == false)
            {
                goto label_31;
            }
            
            if((val_2[0x1] + 32) != 10)
            {
                goto label_24;
            }
            
            if(((0 & 1) & 1) == 0)
            {
                goto label_25;
            }
            
            goto label_31;
            label_24:
            mem2[0] = 0;
            goto label_31;
            label_25:
            mem2[0] = 0;
            goto label_31;
            label_7:
            val_13 = I2.Loc.I2Utils.<>f__am$cache0;
            if(val_13 == null)
            {
                    val_9 = static System.Boolean I2.Loc.I2Utils::<SplitLine>m__0(char c);
                System.Func<System.Char, System.Boolean> val_7 = null;
                val_11 = val_7;
                val_7 = new System.Func<System.Char, System.Boolean>(object:  0, method:  val_9);
                I2.Loc.I2Utils.<>f__am$cache0 = val_11;
                val_13 = I2.Loc.I2Utils.<>f__am$cache0;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_8 = System.Linq.Enumerable.Where<System.Char>(source:  0, predicate:  val_2);
            return 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  0));
        }
        public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
        {
            int val_15;
            int val_16;
            int val_17;
            var val_18;
            var val_19;
            int val_20;
            val_15 = 1152921512319579504;
            goto label_0;
            label_18:
            var val_13 = X4;
            val_15 = val_13 + 1;
            label_0:
            tagEnd = 0;
            mem2[0] = 0;
            int val_1 = iStart.Length;
            tagEnd = val_15;
            if(val_15 >= val_1)
            {
                goto label_2;
            }
            
            label_9:
            if(iStart == 0)
            {
                    val_16 = tagEnd;
            }
            
            val_13 = iStart.Chars[val_16] & 65535;
            if(((val_13 == '[') || ((iStart.Chars[tagEnd] & 65535) == '(')) || ((iStart.Chars[tagEnd] & 65535) == '{'))
            {
                goto label_8;
            }
            
            int val_7 = tagEnd + 1;
            tagEnd = val_7;
            if(val_7 < val_1)
            {
                goto label_9;
            }
            
            label_8:
            val_17 = tagEnd;
            label_2:
            if(val_17 == val_1)
            {
                goto label_17;
            }
            
            val_18 = 0;
            val_19 = 0;
            val_20 = val_17 + 1;
            mem2[0] = val_20;
            if(val_20 >= val_1)
            {
                    return (bool)val_19;
            }
            
            label_16:
            if(iStart == 0)
            {
                    val_20 = mem[X4];
                val_20 = X4;
            }
            
            char val_8 = iStart.Chars[val_20];
            char val_9 = val_8 & 65535;
            if(((val_9 == ')') || (val_9 == '}')) || (val_9 == ']'))
            {
                goto label_15;
            }
            
            val_18 = val_18 | (((val_8 & 65535) > 'ÿ') ? 1 : 0);
            var val_12 = X4 + 1;
            mem2[0] = val_12;
            if(val_12 < val_1)
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            if((val_18 & 1) != 0)
            {
                goto label_18;
            }
            
            val_19 = 1;
            return (bool)val_19;
            label_17:
            val_19 = 0;
            return (bool)val_19;
        }
        public static bool IsPlaying()
        {
            return UnityEngine.Application.isPlaying;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static string GetPath(UnityEngine.Transform tr)
        {
            UnityEngine.Transform val_1 = X1.parent;
            bool val_2 = UnityEngine.Object.op_Equality(x:  0, y:  X1);
            if(val_2 != false)
            {
                    if(X1 != 0)
            {
                    return X1.name;
            }
            
                return X1.name;
            }
            
            string val_3 = X1.name;
            return 0 + val_2 + "/"("/");
        }
        public static UnityEngine.Transform FindObject(string objectPath)
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            return I2.Loc.I2Utils.FindObject(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_1.m_Handle}, objectPath:  val_1.m_Handle & 4294967295);
        }
        public static UnityEngine.Transform FindObject(UnityEngine.SceneManagement.Scene scene, string objectPath)
        {
            var val_13;
            var val_14;
            string val_15;
            val_13;
            val_14 = 0;
            label_13:
            if(val_14 >= (???))
            {
                goto label_2;
            }
            
            val_15 = ???.transform;
            if((System.String.op_Equality(a:  0, b:  val_15.name)) == true)
            {
                    return (UnityEngine.Transform)val_15;
            }
            
            val_14 = val_14 + 1;
            if((X2.StartsWith(value:  0 + val_15.name)) == false)
            {
                goto label_13;
            }
            
            val_13 = val_15.name.Length;
            val_15 = I2.Loc.I2Utils.FindObject(root:  X2.Substring(startIndex:  val_13 + 1), objectPath:  val_15);
            return (UnityEngine.Transform)val_15;
            label_2:
            val_15 = 0;
            return (UnityEngine.Transform)val_15;
        }
        public static UnityEngine.Transform FindObject(UnityEngine.Transform root, string objectPath)
        {
            var val_12;
            var val_13;
            var val_14;
            val_12 = X2;
            val_13 = objectPath;
            goto label_0;
            label_17:
            objectPath = val_13 + 1;
            val_12 = val_12.Substring(startIndex:  objectPath);
            val_13 = X22;
            label_0:
            var val_12 = 0;
            do
            {
                val_14 = 0;
                if(val_12 >= val_13.childCount)
            {
                    return (UnityEngine.Transform)val_14;
            }
            
                val_14 = val_13.GetChild(index:  0);
                if((System.String.op_Equality(a:  0, b:  val_14.name)) == true)
            {
                    return (UnityEngine.Transform)val_14;
            }
            
                val_12 = val_12 + 1;
            }
            while((val_12.StartsWith(value:  0 + val_14.name)) == false);
            
            int val_11 = val_14.name.Length;
            if(val_12 != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        public static H FindInParents<H>(UnityEngine.Transform tr)
        {
            var val_8;
            var val_9;
            val_8 = __RuntimeMethodHiddenParam;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_3;
            }
            
            val_9 = val_8;
            goto label_5;
            label_14:
            val_8 = val_8.parent;
            label_5:
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return (object)val_9;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return (object)val_9;
            }
            
            if(val_8 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_3:
            val_9 = 0;
            return (object)val_9;
        }
        public static string GetCaptureMatch(System.Text.RegularExpressions.Match match)
        {
            int val_5;
            var val_6;
            val_5 = X1;
            int val_5 = val_5;
            val_5 = val_5.Count - 1;
            label_6:
            if((val_5 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            val_5 = val_5 - 1;
            if(val_5.Item[val_5].Success == false)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            val_5 = val_5.Item[val_5];
            val_6 = public System.String System.Text.RegularExpressions.Capture::ToString();
            goto X1 + 320;
            label_3:
            val_6 = mem[X1 + 320];
            val_6 = X1 + 320;
            goto X1 + 320;
        }
        private static bool <SplitLine>m__0(char c)
        {
            return (bool)(W1 != 65535) ? 1 : 0;
        }
    
    }

}
