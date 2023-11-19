using UnityEngine;

namespace I2.Loc
{
    public class LocalizationReader
    {
        // Methods
        public LocalizationReader()
        {
        
        }
        public static System.Collections.Generic.Dictionary<string, string> ReadTextAsset(UnityEngine.TextAsset asset)
        {
            var val_20;
            System.Collections.Generic.IEqualityComparer<TKey> val_21;
            System.Collections.Generic.IEqualityComparer<TKey> val_22;
            string val_11 = 0;
            string val_10 = 0;
            if(X1 != 0)
            {
                    val_20 = X1.bytes;
            }
            else
            {
                    val_20 = 0.bytes;
            }
            
            System.Byte[] val_4 = X1.bytes;
            System.IO.StringReader val_7 = new System.IO.StringReader(s:  System.Text.Encoding.UTF8.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\r", newValue:  "\n"));
            val_21 = System.StringComparer.Ordinal;
            System.Collections.Generic.Dictionary<System.String, System.String> val_9 = null;
            val_22 = val_21;
            val_9 = new System.Collections.Generic.Dictionary<System.String, System.String>(comparer:  val_22);
            goto label_16;
            label_24:
            val_22 = val_21;
            set_Item(key:  val_22, value:  X22);
            goto label_16;
            label_21:
            val_22 = val_9;
            if((I2.Loc.LocalizationReader.TextAsset_ReadLine(line:  val_9, key: out  val_22, value: out  val_10, category: out  val_11, comment: out  0, termType: out  0)) == false)
            {
                goto label_16;
            }
            
            val_21 = val_10;
            val_22 = val_21;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_16;
            }
            
            val_22 = val_11;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_19;
            }
            
            label_16:
            if(null != 0)
            {
                goto label_21;
            }
            
            return val_9;
            label_19:
            if(null != 0)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
        {
            string val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            var val_28;
            var val_29;
            val_23 = 1152921512275477136;
            val_24 = 1152921512275469040;
            val_25 = 1152921504608284672;
            val_26 = null;
            val_26 = null;
            value = System.String.Empty;
            comment = System.String.Empty;
            termType = System.String.Empty;
            mem2[0] = System.String.Empty;
            category = System.String.Empty;
            string val_23 = "//";
            int val_1 = key.LastIndexOf(value:  val_23);
            if((val_1 & 2147483648) == 0)
            {
                    val_23 = val_1 + 2;
                val_25 = key.Substring(startIndex:  val_23);
                string val_3 = val_25.Trim();
                termType = val_3;
                termType = I2.Loc.LocalizationReader.DecodeString(str:  val_3);
                val_24 = key.Substring(startIndex:  0, length:  val_1);
            }
            
            val_27 = val_24.IndexOf(value:  "=");
            if((val_27 & 2147483648) == 0)
            {
                    value = val_24.Substring(startIndex:  0, length:  val_27).Trim();
                string val_11 = val_24.Substring(startIndex:  val_27 + 1).Trim();
                category = val_11;
                val_27 = "\n";
                string val_13 = val_11.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\n", newValue:  "\\n");
                category = val_13;
                category = I2.Loc.LocalizationReader.DecodeString(str:  val_13);
                val_23 = value;
                val_28 = val_23;
                if(val_28.Length >= 3)
            {
                    val_23 = value;
                val_28 = val_23;
                if((val_28.Chars[0] & 65535) == '[')
            {
                    val_28 = value;
                val_23 = val_28.IndexOf(value:  ']');
                if((val_23 & 2147483648) == 0)
            {
                    mem2[0] = value.Substring(startIndex:  1, length:  val_23 - 1);
                string val_22 = value.Substring(startIndex:  val_23 + 1);
                value = val_22;
            }
            
            }
            
            }
            
                I2.Loc.LocalizationReader.ValidateFullTerm(Term: ref  val_22);
                val_29 = 1;
                return (bool)val_29;
            }
            
            val_29 = 0;
            return (bool)val_29;
        }
        public static string ReadCSVfile(string Path, System.Text.Encoding encoding)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            System.IO.StreamReader val_5 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_3 = mem[null + 152];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_4 = new System.IO.StreamReader(path:  encoding, encoding:  X2);
            goto label_7;
            label_5:
            val_5 = val_5 + (((mem[null + 152] + 8)) << 4);
            label_7:
            string val_2 = Replace(oldValue:  "\r\n", newValue:  "\n");
            if(val_2 != null)
            {
                    return val_2.Replace(oldValue:  "\r", newValue:  "\n");
            }
            
            return val_2.Replace(oldValue:  "\r", newValue:  "\n");
        }
        public static System.Collections.Generic.List<string[]> ReadCSV(string Text, char Separator = '\x2c')
        {
            System.String[] val_5 = 0;
            goto label_1;
            label_6:
            Add(item:  val_5 = 0);
            val_5 = 0;
            label_1:
            int val_2 = Separator.Length;
            if(0 >= val_2)
            {
                    return (System.Collections.Generic.List<System.String[]>)new System.Collections.Generic.List<System.String[]>();
            }
            
            if((I2.Loc.LocalizationReader.ParseCSVline(Line:  val_2, iStart: ref  Separator, Separator:  '죜')) == null)
            {
                    return (System.Collections.Generic.List<System.String[]>)new System.Collections.Generic.List<System.String[]>();
            }
            
            if(null != 0)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
        {
            var val_17;
            char val_18;
            int val_19;
            var val_20;
            char val_21;
            var val_22;
            char val_23;
            char val_24;
            System.Collections.Generic.List<System.String> val_13 = new System.Collections.Generic.List<System.String>();
            val_17 = 1152921512276036160;
            int val_2 = iStart.Length;
            val_18 = mem[Separator];
            val_18 = Separator;
            if(val_18 >= val_2)
            {
                goto label_19;
            }
            
            label_18:
            if(iStart == 0)
            {
                    val_19 = mem[Separator];
                val_19 = Separator;
            }
            
            val_17 = 1152921512276036160;
            char val_3 = iStart.Chars[val_19];
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            val_19 = val_3 & 65535;
            if(val_19 != '"')
            {
                goto label_5;
            }
            
            val_20 = mem[Separator];
            val_20 = Separator;
            if((val_20 + 1) >= val_2)
            {
                goto label_17;
            }
            
            if(iStart == 0)
            {
                    val_20 = mem[Separator];
                val_20 = Separator;
            }
            
            val_17 = 1152921512276036160;
            val_20 = (iStart.Chars[val_20 + 1]) & 65535;
            if(val_20 != '"')
            {
                goto label_17;
            }
            
            val_21 = mem[Separator];
            val_21 = Separator;
            if((val_21 + 2) >= val_2)
            {
                goto label_11;
            }
            
            if(iStart == 0)
            {
                    val_22 = mem[Separator];
                val_22 = Separator;
            }
            
            val_17 = 1152921512276036160;
            val_23 = mem[Separator];
            val_23 = Separator;
            if(((iStart.Chars[val_22 + 2]) & 65535) != '"')
            {
                goto label_11;
            }
            
            val_23 = val_23 + 2;
            mem2[0] = val_23;
            goto label_17;
            label_4:
            char val_11 = val_3 & 65535;
            if((val_11 == '
            ') || (val_11 == W3))
            {
                goto label_14;
            }
            
            val_19 = val_3 & 65535;
            var val_12 = (val_19 == '"') ? 1 : 0;
            goto label_17;
            label_14:
            I2.Loc.LocalizationReader.AddCSVtoken(list: ref  val_3, Line: ref  val_13, iEnd:  -920793576, iWordStart: ref  Separator);
            if(val_11 == '
            ')
            {
                goto label_16;
            }
            
            goto label_17;
            label_11:
            val_21 = val_21 + 1;
            mem2[0] = val_21;
            label_5:
            label_17:
            val_24 = Separator + 1;
            mem2[0] = val_24;
            if(val_24 < val_2)
            {
                goto label_18;
            }
            
            goto label_19;
            label_16:
            val_24 = Separator + 1;
            mem2[0] = val_24;
            label_19:
            if(val_24 <= val_18)
            {
                    return (System.String[])ToArray();
            }
            
            I2.Loc.LocalizationReader.AddCSVtoken(list: ref  val_3, Line: ref  val_13, iEnd:  -920793576, iWordStart: ref  val_24);
            return (System.String[])ToArray();
        }
        private static void AddCSVtoken(ref System.Collections.Generic.List<string> list, ref string Line, int iEnd, ref int iWordStart)
        {
            var val_16;
            string val_17;
            val_16 = 1152921512276221504;
            mem2[0] = 1152921512276221505;
            val_17 = iEnd.Substring(startIndex:  X4, length:  val_16 - X4).Replace(oldValue:  "\"\"", newValue:  "\"");
            if((val_17.Length >= 2) && ((val_17.Chars[0] & 65535) == '"'))
            {
                    if(val_17 != null)
            {
                    val_16 = val_17.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                if(((val_17.Chars[val_16 - 1]) & 65535) == '"')
            {
                    if(val_17 != null)
            {
                    val_16 = val_17.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                val_17 = val_17.Substring(startIndex:  1, length:  val_16 - 2);
            }
            
            }
            
            Line.Add(item:  val_17);
        }
        public static System.Collections.Generic.List<string[]> ReadI2CSV(string Text)
        {
            var val_4;
            typeof(System.String[]).__il2cppRuntimeField_20 = "[*]";
            typeof(System.String[]).__il2cppRuntimeField_20 = "[ln]";
            val_4 = 0;
            goto label_10;
            label_16:
            Add(item:  null);
            val_4 = 1;
            label_10:
            if(val_4 >= val_2.Length)
            {
                    return (System.Collections.Generic.List<System.String[]>)new System.Collections.Generic.List<System.String[]>();
            }
            
            System.String[] val_3 = X1.Split(separator:  null, options:  0)[1].Split(separator:  null, options:  0);
            if(null != 0)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        public static void ValidateFullTerm(ref string Term)
        {
            int val_5;
            string val_1 = X1.Replace(oldChar:  '\', newChar:  '/');
            mem2[0] = val_1;
            int val_2 = val_1.IndexOf(value:  '/');
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            val_5 = mem[X1];
            val_5 = X1;
            goto label_3;
            label_7:
            val_5 = X22.Remove(startIndex:  val_5, count:  1);
            mem2[0] = val_5;
            label_3:
            if((val_5.LastIndexOf(value:  '/')) == val_2)
            {
                    return;
            }
            
            if(X1 != 0)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public static string EncodeString(string str)
        {
            var val_4;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_4 = null;
                val_4 = null;
                return (string)System.String.Empty;
            }
            
            string val_3 = X1.Replace(oldValue:  "\r\n", newValue:  "<\\n>").Replace(oldValue:  "\r", newValue:  "<\\n>");
            if(val_3 != null)
            {
                    return val_3.Replace(oldValue:  "\n", newValue:  "<\\n>");
            }
            
            return val_3.Replace(oldValue:  "\n", newValue:  "<\\n>");
        }
        public static string DecodeString(string str)
        {
            var val_2;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_2 = null;
                val_2 = null;
                return (string)System.String.Empty;
            }
            
            if(X1 != 0)
            {
                    return X1.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
            }
            
            return X1.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
        }
    
    }

}
