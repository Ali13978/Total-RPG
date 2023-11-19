using UnityEngine;

namespace XUPorterJSON
{
    public class MiniJSON
    {
        // Fields
        private const int TOKEN_NONE = 0;
        private const int TOKEN_CURLY_OPEN = 1;
        private const int TOKEN_CURLY_CLOSE = 2;
        private const int TOKEN_SQUARED_OPEN = 3;
        private const int TOKEN_SQUARED_CLOSE = 4;
        private const int TOKEN_COLON = 5;
        private const int TOKEN_COMMA = 6;
        private const int TOKEN_STRING = 7;
        private const int TOKEN_NUMBER = 8;
        private const int TOKEN_TRUE = 9;
        private const int TOKEN_FALSE = 10;
        private const int TOKEN_NULL = 11;
        private const int BUILDER_CAPACITY = 2000;
        protected static int lastErrorIndex;
        protected static string lastDecode;
        
        // Methods
        public MiniJSON()
        {
        
        }
        public static object jsonDecode(string json)
        {
            var val_5;
            System.Char[] val_6;
            var val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            XUPorterJSON.MiniJSON.lastDecode = X1;
            if(X1 == 0)
            {
                goto label_3;
            }
            
            val_6 = null;
            val_7 = XUPorterJSON.MiniJSON.parseValue(json:  val_6, index: ref  X1.ToCharArray(), success: ref  false);
            if(1 == 0)
            {
                goto label_6;
            }
            
            val_8 = null;
            val_8 = null;
            XUPorterJSON.MiniJSON.lastErrorIndex = 0;
            return (object)val_7;
            label_3:
            val_7 = 0;
            return (object)val_7;
            label_6:
            val_9 = null;
            val_9 = null;
            XUPorterJSON.MiniJSON.lastErrorIndex = 0;
            return (object)val_7;
        }
        public static string jsonEncode(object json)
        {
            System.Text.StringBuilder val_7 = X1;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(capacity:  208);
            if((XUPorterJSON.MiniJSON.serializeValue(value:  null, builder:  val_7 = X1)) == false)
            {
                    return 0;
            }
            
            val_7 = ???;
            goto mem[null + 320];
        }
        public static bool lastDecodeSuccessful()
        {
            null = null;
            return (bool)(XUPorterJSON.MiniJSON.lastErrorIndex == 1) ? 1 : 0;
        }
        public static int getLastErrorIndex()
        {
            null = null;
            return (int)XUPorterJSON.MiniJSON.lastErrorIndex;
        }
        public static string getLastErrorSnippet()
        {
            var val_7;
            int val_9;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_7 = null;
            val_7 = null;
            val_9 = XUPorterJSON.MiniJSON.lastErrorIndex;
            if(val_9 != 1)
            {
                    val_7 = null;
                val_9 = XUPorterJSON.MiniJSON.lastErrorIndex;
                int val_1 = val_9 - 5;
                int val_2 = (val_1 < 0) ? 0 : (val_1);
                val_11 = val_9 + 15;
                if(val_11 >= XUPorterJSON.MiniJSON.lastDecode.Length)
            {
                    val_12 = null;
                val_12 = null;
                val_11 = XUPorterJSON.MiniJSON.lastDecode.Length - 1;
            }
            
                val_13 = null;
                val_13 = null;
                var val_6 = 1;
                val_6 = val_6 - val_2;
                return XUPorterJSON.MiniJSON.lastDecode.Substring(startIndex:  val_2, length:  val_6 + val_11);
            }
            
            val_14 = null;
            val_14 = null;
            return (string)System.String.Empty;
        }
        protected static System.Collections.Hashtable parseObject(char[] json, ref int index)
        {
            var val_16;
            goto label_20;
            label_23:
            label_20:
            int val_6 = XUPorterJSON.MiniJSON.lookAhead(json:  XUPorterJSON.MiniJSON.nextToken(json:  XUPorterJSON.MiniJSON.nextToken(json:  null, index: ref  1152921510130716160), index: ref  1152921510130716160), index:  1228901888);
            if(val_6 == 6)
            {
                goto label_23;
            }
            
            val_16 = 0;
            if(val_6 == 0)
            {
                    return (System.Collections.Hashtable)val_16;
            }
            
            if(val_6 == 2)
            {
                goto label_8;
            }
            
            if(((XUPorterJSON.MiniJSON.parseString(json:  null, index: ref  1152921510130716160)) == null) || ((XUPorterJSON.MiniJSON.nextToken(json:  null, index: ref  1152921510130716160)) != 5))
            {
                goto label_17;
            }
            
            object val_13 = XUPorterJSON.MiniJSON.parseValue(json:  null, index: ref  1152921510130716160, success: ref  X2);
            if(1 == 0)
            {
                goto label_17;
            }
            
            goto label_20;
            label_17:
            val_16 = 0;
            return (System.Collections.Hashtable)val_16;
            label_8:
            int val_15 = XUPorterJSON.MiniJSON.nextToken(json:  null, index: ref  1152921510130716160);
            val_16 = new System.Collections.Hashtable();
            return (System.Collections.Hashtable)val_16;
        }
        protected static System.Collections.ArrayList parseArray(char[] json, ref int index)
        {
            var val_12;
            goto label_14;
            label_17:
            label_14:
            int val_6 = XUPorterJSON.MiniJSON.lookAhead(json:  XUPorterJSON.MiniJSON.nextToken(json:  XUPorterJSON.MiniJSON.nextToken(json:  null, index: ref  1152921510130922208), index: ref  1152921510130922208), index:  1229107936);
            if(val_6 == 6)
            {
                goto label_17;
            }
            
            val_12 = 0;
            if(val_6 == 0)
            {
                    return (System.Collections.ArrayList)val_12;
            }
            
            if(val_6 == 4)
            {
                goto label_8;
            }
            
            object val_9 = XUPorterJSON.MiniJSON.parseValue(json:  null, index: ref  1152921510130922208, success: ref  X2);
            if(1 == 0)
            {
                goto label_11;
            }
            
            goto label_14;
            label_8:
            int val_11 = XUPorterJSON.MiniJSON.nextToken(json:  null, index: ref  1152921510130922208);
            val_12 = new System.Collections.ArrayList();
            return (System.Collections.ArrayList)val_12;
            label_11:
            val_12 = 0;
            return (System.Collections.ArrayList)val_12;
        }
        protected static object parseValue(char[] json, ref int index, ref bool success)
        {
            System.Char[] val_2 = null;
            if((XUPorterJSON.MiniJSON.lookAhead(json:  val_2 = null, index:  1229309840)) <= 11)
            {
                    if((25976928 + (val_1) << 2) > 13)
            {
                    return (object)val_2;
            }
            
                var val_2 = 25976764 + (25976928 + (val_1) << 2) << 2;
                val_2 = val_2 + 25976764;
            }
            else
            {
                    val_2 = 0;
                mem2[0] = 0;
                return (object)val_2;
            }
        
        }
        protected static string parseString(char[] json, ref int index)
        {
            null = null;
            XUPorterJSON.MiniJSON.eatWhitespace(json:  null, index: ref  1152921510131338464);
            mem2[0] = X2 + 1;
            if(X2 < mem[1152921510131338488])
            {
                goto label_25;
            }
            
            goto label_25;
            label_14:
            string val_3 = 0 + System.String.Empty;
            goto label_25;
            label_35:
            mem2[0] = X2 + 1;
            var val_5 = 1152921510131338464 + ((X2) << 1);
            if(((index + (X2) << 1) + 32) == 92)
            {
                goto label_10;
            }
            
            if(((index + (X2) << 1) + 32) == 34)
            {
                    return 0;
            }
            
            goto label_14;
            label_10:
            if(X2 == mem[1152921510131338488])
            {
                    return 0;
            }
            
            mem2[0] = X2 + 1;
            var val_7 = 1152921510131338464 + ((X2) << 1);
            if(((index + (X2) << 1) + 32) > 97)
            {
                goto label_17;
            }
            
            if((((index + (X2) << 1) + 32) == 34) || (((index + (X2) << 1) + 32) == 47))
            {
                goto label_14;
            }
            
            if(((index + (X2) << 1) + 32) != 92)
            {
                goto label_25;
            }
            
            goto label_14;
            label_17:
            if((((index + (X2) << 1) + 32) - 110) > 7)
            {
                goto label_22;
            }
            
            var val_11 = 25976860;
            val_11 = (25976860 + (((index + (X2) << 1) + 32 - 110)) << 2) + val_11;
            goto (25976860 + (((index + (X2) << 1) + 32 - 110)) << 2 + 25976860);
            label_22:
            if(((index + (X2) << 1) + 32) == 98)
            {
                goto label_14;
            }
            
            if(((index + (X2) << 1) + 32) != 102)
            {
                goto label_25;
            }
            
            goto label_14;
            label_25:
            if(X2 != mem[1152921510131338488])
            {
                goto label_35;
            }
            
            return 0;
        }
        protected static double parseNumber(char[] json, ref int index)
        {
            XUPorterJSON.MiniJSON.eatWhitespace(json:  null, index: ref  1152921510131552704);
            int val_2 = XUPorterJSON.MiniJSON.getLastIndexOfNumber(json:  null, index:  1229738432);
            var val_6 = X2;
            val_6 = val_2 - val_6;
            int val_3 = val_6 + 1;
            System.Array.Copy(sourceArray:  0, sourceIndex:  1229738432, destinationArray:  X2, destinationIndex:  410741984, length:  0);
            mem2[0] = val_2 + 1;
            string val_5 = 0.CreateString(val:  null);
            return System.Double.Parse(s:  0);
        }
        protected static int getLastIndexOfNumber(char[] json, int index)
        {
            char val_4;
            var val_5;
            var val_6;
            val_5 = W2 - 1;
            goto label_1;
            label_6:
            val_5 = val_5 + 1;
            label_1:
            if((val_5 + 1) >= (index + 24))
            {
                    return (int)val_5;
            }
            
            int val_2 = index + (((long)(int)((((W2 - 1) + 1) + 1))) << 1);
            val_4 = mem[(index + ((long)(int)((((W2 - 1) + 1) + 1))) << 1) + 32];
            val_4 = (index + ((long)(int)((((W2 - 1) + 1) + 1))) << 1) + 32;
            val_6 = "0123456789+-.eE";
            if(("0123456789+-.eE") == null)
            {
                    val_6 = "0123456789+-.eE";
            }
            
            if((IndexOf(value:  val_4)) != 1)
            {
                goto label_6;
            }
            
            return (int)val_5;
        }
        protected static void eatWhitespace(char[] json, ref int index)
        {
            char val_3;
            var val_4;
            goto label_1;
            label_6:
            var val_3 = X2;
            val_3 = val_3 + 1;
            mem2[0] = val_3;
            label_1:
            val_3 = mem[X2];
            val_3 = X2;
            if(val_3 >= mem[1152921510131936424])
            {
                    return;
            }
            
            var val_1 = 1152921510131936400 + ((X2) << 1);
            val_3 = mem[(index + (X2) << 1) + 32];
            val_3 = (index + (X2) << 1) + 32;
            val_4 = " \t\n\r";
            if(" \t\n\r" == null)
            {
                    val_4 = " \t\n\r";
            }
            
            if((IndexOf(value:  val_3)) != 1)
            {
                goto label_6;
            }
        
        }
        protected static int lookAhead(char[] json, int index)
        {
            return (int)XUPorterJSON.MiniJSON.nextToken(json:  null, index: ref  index);
        }
        protected static int nextToken(char[] json, ref int index)
        {
            var val_25;
            var val_26;
            var val_27;
            XUPorterJSON.MiniJSON.eatWhitespace(json:  null, index: ref  1152921510132315888);
            val_26 = mem[X2];
            val_26 = X2;
            if(val_26 == mem[1152921510132315912])
            {
                goto label_51;
            }
            
            val_25 = (long)val_26;
            if(val_26 >= mem[1152921510132315912])
            {
                    val_26 = mem[X2];
                val_26 = X2;
            }
            
            var val_2 = 1152921510132315888 + (((long)(int)(X2)) << 1);
            mem2[0] = val_26 + 1;
            if((((index + ((long)(int)(X2)) << 1) + 32) - 44) > 14)
            {
                goto label_6;
            }
            
            val_27 = 6;
            if((25976976 + (((index + ((long)(int)(X2)) << 1) + 32 - 44)) << 2) > 9)
            {
                    return (int)val_27;
            }
            
            var val_24 = 25976820 + (25976976 + (((index + ((long)(int)(X2)) << 1) + 32 - 44)) << 2) << 2;
            val_24 = val_24 + 25976820;
            goto (25976820 + (25976976 + (((index + ((long)(int)(X2)) << 1) + 32 - 44)) << 2) << 2 + 25976820);
            label_6:
            var val_7 = ((((index + ((long)(int)(X2)) << 1) + 32) - 91) < 3) ? (((index + ((long)(int)(X2)) << 1) + 32) - 80) : 0;
            if(val_7 == 0)
            {
                goto label_8;
            }
            
            if(val_7 == 13)
            {
                goto label_9;
            }
            
            if(val_7 != 12)
            {
                goto label_10;
            }
            
            label_8:
            var val_10 = ((((index + ((long)(int)(X2)) << 1) + 32) - 123) < 3) ? (((index + ((long)(int)(X2)) << 1) + 32) - 108) : 0;
            if(val_10 == 0)
            {
                goto label_11;
            }
            
            if(val_10 == 17)
            {
                goto label_12;
            }
            
            if(val_10 != 16)
            {
                goto label_13;
            }
            
            label_11:
            if(((index + ((long)(int)(X2)) << 1) + 32) != 34)
            {
                goto label_14;
            }
            
            val_27 = 7;
            return (int)val_27;
            label_9:
            val_27 = 4;
            return (int)val_27;
            label_10:
            val_27 = 3;
            return (int)val_27;
            label_12:
            val_27 = 2;
            return (int)val_27;
            label_13:
            val_27 = 1;
            return (int)val_27;
            label_14:
            mem2[0] = val_26;
            val_25 = mem[1152921510132315912] - val_26;
            if(val_25 > 4)
            {
                    var val_11 = 1152921510132315888 + (((long)(int)(X2)) << 1);
                if(((index + ((long)(int)(X2)) << 1) + 32) == 102)
            {
                    var val_25 = X2;
                val_25 = val_25 + 1;
                var val_12 = 1152921510132315888 + (((long)(int)((X2 + 1))) << 1);
                if(((index + ((long)(int)((X2 + 1))) << 1) + 32) == 97)
            {
                    var val_26 = X2;
                val_26 = val_26 + 2;
                var val_13 = 1152921510132315888 + (((long)(int)((X2 + 2))) << 1);
                if(((index + ((long)(int)((X2 + 2))) << 1) + 32) == 108)
            {
                    var val_27 = X2;
                val_27 = val_27 + 3;
                var val_14 = 1152921510132315888 + (((long)(int)((X2 + 3))) << 1);
                if(((index + ((long)(int)((X2 + 3))) << 1) + 32) == 115)
            {
                    var val_28 = X2;
                val_28 = val_28 + 4;
                var val_15 = 1152921510132315888 + (((long)(int)((X2 + 4))) << 1);
                if(((index + ((long)(int)((X2 + 4))) << 1) + 32) == 101)
            {
                    var val_29 = X2;
                val_27 = 10;
                val_29 = val_29 + 5;
                mem2[0] = val_29;
                return (int)val_27;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            if(val_25 >= 4)
            {
                    var val_16 = 1152921510132315888 + ((X2) << 1);
                if(((index + (X2) << 1) + 32) == 116)
            {
                    var val_30 = X2;
                val_30 = val_30 + 1;
                var val_17 = 1152921510132315888 + (((long)(int)((X2 + 1))) << 1);
                if(((index + ((long)(int)((X2 + 1))) << 1) + 32) == 114)
            {
                    var val_31 = X2;
                val_31 = val_31 + 2;
                var val_18 = 1152921510132315888 + (((long)(int)((X2 + 2))) << 1);
                if(((index + ((long)(int)((X2 + 2))) << 1) + 32) == 117)
            {
                    var val_32 = X2;
                val_32 = val_32 + 3;
                val_25 = (long)val_32;
                var val_19 = 1152921510132315888 + (((long)(int)((X2 + 3))) << 1);
                if(((index + ((long)(int)((X2 + 3))) << 1) + 32) == 101)
            {
                    var val_33 = X2;
                val_27 = 9;
                val_33 = val_33 + 4;
                mem2[0] = val_33;
                return (int)val_27;
            }
            
            }
            
            }
            
            }
            
                val_25 = mem[X2];
                val_25 = X2;
                var val_20 = 1152921510132315888 + ((X2) << 1);
                if(((index + (X2) << 1) + 32) == 110)
            {
                    var val_34 = X2;
                val_34 = val_34 + 1;
                val_25 = (long)val_34;
                var val_21 = 1152921510132315888 + (((long)(int)((X2 + 1))) << 1);
                if(((index + ((long)(int)((X2 + 1))) << 1) + 32) == 117)
            {
                    var val_35 = X2;
                val_35 = val_35 + 2;
                val_25 = (long)val_35;
                var val_22 = 1152921510132315888 + (((long)(int)((X2 + 2))) << 1);
                if(((index + ((long)(int)((X2 + 2))) << 1) + 32) == 108)
            {
                    var val_36 = X2;
                val_36 = val_36 + 3;
                val_25 = (long)val_36;
                var val_23 = 1152921510132315888 + (((long)(int)((X2 + 3))) << 1);
                if(((index + ((long)(int)((X2 + 3))) << 1) + 32) == 108)
            {
                    var val_37 = X2;
                val_27 = 11;
                val_37 = val_37 + 4;
                mem2[0] = val_37;
                return (int)val_27;
            }
            
            }
            
            }
            
            }
            
            }
            
            label_51:
            val_27 = 0;
            return (int)val_27;
        }
        protected static bool serializeObjectOrArray(object objectOrArray, System.Text.StringBuilder builder)
        {
            var val_5;
            var val_6;
            var val_8;
            var val_11;
            val_6 = builder;
            if(val_6 != null)
            {
                    val_8 = null;
                val_5 = 1152921504617709568;
                val_11 = null;
            }
            
            var val_5 = 0;
            val_5 = val_5 & 1;
            return (bool)val_5;
        }
        protected static bool serializeObject(System.Collections.Hashtable anObject, System.Text.StringBuilder builder)
        {
            System.Text.StringBuilder val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Text.StringBuilder val_1 = X2.Append(value:  "{");
            label_25:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = builder;
            if(((builder & 1) & 1) == 0)
            {
                goto label_8;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = builder;
            val_10 = builder;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = builder;
            if(((1 & 1) & 1) == 0)
            {
                    System.Text.StringBuilder val_7 = X2.Append(value:  ", ");
            }
            
            XUPorterJSON.MiniJSON.serializeString(aString:  null, builder:  val_10);
            val_14 = 0;
            if((XUPorterJSON.MiniJSON.serializeValue(value:  X2.Append(value:  ":"), builder:  builder)) == true)
            {
                goto label_25;
            }
            
            return (bool)val_14;
            label_8:
            System.Text.StringBuilder val_10 = X2.Append(value:  "}");
            val_14 = 1;
            return (bool)val_14;
        }
        protected static bool serializeDictionary(System.Collections.Generic.Dictionary<string, string> dict, System.Text.StringBuilder builder)
        {
            System.Text.StringBuilder val_1 = X2.Append(value:  "{");
            Dictionary.Enumerator<TKey, TValue> val_2 = builder.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_13;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            if(((1 & 1) & 1) == 0)
            {
                    System.Text.StringBuilder val_5 = X2.Append(value:  ", ");
            }
            
            XUPorterJSON.MiniJSON.serializeString(aString:  null, builder:  val_3.m_Handle.InitializationCallback);
            System.Text.StringBuilder val_7 = X2.Append(value:  ":");
            XUPorterJSON.MiniJSON.serializeString(aString:  val_3.m_Handle, builder:  val_3.m_Handle);
            goto label_9;
            label_13:
            0.Dispose();
            System.Text.StringBuilder val_8 = X2.Append(value:  "}");
            return true;
        }
        protected static bool serializeArray(System.Collections.ArrayList anArray, System.Text.StringBuilder builder)
        {
            var val_5;
            var val_6;
            var val_7;
            System.Text.StringBuilder val_1 = X2.Append(value:  "[");
            val_5 = 0;
            val_6 = 1;
            label_8:
            if(val_5 >= builder)
            {
                goto label_3;
            }
            
            if(((val_6 & 1) & 1) == 0)
            {
                    System.Text.StringBuilder val_3 = X2.Append(value:  ", ");
            }
            
            val_6 = 0;
            val_7 = 0;
            val_5 = val_5 + 1;
            if((XUPorterJSON.MiniJSON.serializeValue(value:  null, builder:  builder)) == true)
            {
                goto label_8;
            }
            
            return (bool)val_7;
            label_3:
            System.Text.StringBuilder val_5 = X2.Append(value:  "]");
            val_7 = 1;
            return (bool)val_7;
        }
        protected static bool serializeValue(object value, System.Text.StringBuilder builder)
        {
            System.Collections.ArrayList val_21;
            var val_22;
            System.Collections.ICollection val_23;
            var val_26;
            var val_28;
            var val_30;
            var val_32;
            string val_33;
            System.Text.StringBuilder val_34;
            var val_35;
            val_22 = builder;
            if(val_22 == null)
            {
                goto label_1;
            }
            
            if(val_22.GetType().IsArray == false)
            {
                goto label_3;
            }
            
            val_21 = null;
            val_23 = val_22;
            if(val_23 == null)
            {
                    val_23 = 0;
            }
            
            val_21 = new System.Collections.ArrayList(c:  val_23);
            bool val_5 = XUPorterJSON.MiniJSON.serializeArray(anArray:  null, builder:  val_21);
            return true;
            label_1:
            label_58:
            System.Text.StringBuilder val_6 = X2.Append(value:  "null");
            return true;
            label_3:
            val_21 = 1152921504608284672;
            if(null == null)
            {
                goto label_10;
            }
            
            val_21 = 1152921504608231424;
            if(null == null)
            {
                goto label_11;
            }
            
            val_26 = null;
            val_28 = null;
            val_30 = null;
            val_32 = null;
            if(null != val_32)
            {
                goto label_18;
            }
            
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(null == null)
            {
                goto label_19;
            }
            
            if(X2 != 0)
            {
                goto label_58;
            }
            
            goto label_58;
            label_10:
            val_33 = null;
            if(null == null)
            {
                goto label_31;
            }
            
            val_34 = 0;
            goto label_31;
            label_11:
            val_35 = 1152921504655142912;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_34 = System.Convert.ToString(value:  ' ');
            val_33 = null;
            label_31:
            XUPorterJSON.MiniJSON.serializeString(aString:  val_33, builder:  val_34);
            return true;
            label_19:
            val_32 = null;
            label_18:
            if(null != val_32)
            {
                goto label_47;
            }
            
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y});
            if(null == null)
            {
                goto label_48;
            }
            
            label_47:
            if(val_22.GetType().IsPrimitive == false)
            {
                    return true;
            }
            
            XUPorterJSON.MiniJSON.serializeNumber(number:  System.Convert.ToDouble(value:  0), builder:  null);
            return true;
            label_48:
            if(X2 != 0)
            {
                goto label_58;
            }
            
            goto label_58;
            label_63:
            goto label_63;
        }
        protected static void serializeString(string aString, System.Text.StringBuilder builder)
        {
            var val_11;
            string val_12;
            var val_13;
            System.Text.StringBuilder val_1 = X2.Append(value:  "\"");
            val_11 = 0;
            goto label_3;
            label_35:
            val_11 = 1;
            label_3:
            if(val_11 >= val_2.Length)
            {
                goto label_5;
            }
            
            char val_11 = builder.ToCharArray()[1];
            builder.ToCharArray()[1] = val_11 - 8;
            if(builder.ToCharArray()[1] > '')
            {
                goto label_7;
            }
            
            var val_12 = 25976892 + ((val_2[0x1][0] - 8)) << 2;
            val_12 = val_12 + 25976892;
            goto (25976892 + ((val_2[0x1][0] - 8)) << 2 + 25976892);
            label_7:
            if(val_11 == '\')
            {
                goto label_10;
            }
            
            if(val_11 != '"')
            {
                goto label_11;
            }
            
            val_12 = "\\\"";
            goto label_25;
            label_11:
            int val_3 = System.Convert.ToInt32(value:  ' ');
            if((val_3 - 32) <= 94)
            {
                goto label_16;
            }
            
            string val_6 = System.Convert.ToString(value:  0, toBase:  val_3).PadLeft(totalWidth:  4, paddingChar:  '0');
            val_13 = 0 + "\\u";
            goto label_23;
            label_10:
            val_12 = "\\\\";
            label_25:
            label_23:
            System.Text.StringBuilder val_8 = X2.Append(value:  val_12);
            goto label_35;
            label_16:
            System.Text.StringBuilder val_9 = X2.Append(value:  val_11);
            goto label_35;
            label_5:
            System.Text.StringBuilder val_10 = X2.Append(value:  "\"");
        }
        protected static void serializeNumber(double number, System.Text.StringBuilder builder)
        {
            System.Text.StringBuilder val_2 = X1.Append(value:  System.Convert.ToString(value:  number));
        }
        private static MiniJSON()
        {
            var val_1;
            XUPorterJSON.MiniJSON.lastErrorIndex = 0;
            val_1 = null;
            val_1 = null;
            XUPorterJSON.MiniJSON.lastDecode = System.String.Empty;
        }
    
    }

}
