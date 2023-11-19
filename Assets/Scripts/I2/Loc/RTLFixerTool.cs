using UnityEngine;

namespace I2.Loc
{
    internal class RTLFixerTool
    {
        // Fields
        internal static bool showTashkeel;
        internal static bool useHinduNumbers;
        
        // Methods
        public RTLFixerTool()
        {
        
        }
        internal static string RemoveTashkeel(string str, out System.Collections.Generic.List<I2.Loc.TashkeelLocation> tashkeelLocation)
        {
            var val_15;
            char val_16;
            var val_17;
            I2.Loc.TashkeelLocation val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            string val_24;
            mem2[0] = new System.Collections.Generic.List<I2.Loc.TashkeelLocation>();
            val_15 = 0;
            var val_19 = 0;
            goto label_2;
            label_67:
            val_15 = 1;
            label_2:
            if(val_15 >= val_2.Length)
            {
                goto label_4;
            }
            
            val_16 = tashkeelLocation.ToCharArray()[1];
            if(val_16 != 'ً')
            {
                goto label_6;
            }
            
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1611;
            goto label_58;
            label_6:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1612)
            {
                goto label_9;
            }
            
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1612;
            goto label_58;
            label_9:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1613)
            {
                goto label_12;
            }
            
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1613;
            goto label_58;
            label_12:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1614)
            {
                goto label_15;
            }
            
            int val_3 = val_19 - 1;
            if(val_16 < 1614)
            {
                goto label_19;
            }
            
            I2.Loc.TashkeelLocation val_4 = X2.Item[val_3];
            if(val_4.tashkeel != 'ّ')
            {
                goto label_19;
            }
            
            I2.Loc.TashkeelLocation val_5 = X2.Item[val_3];
            val_5.tashkeel = 'ﱠ';
            goto label_67;
            label_15:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1615)
            {
                goto label_24;
            }
            
            int val_6 = val_19 - 1;
            if(val_16 < 1615)
            {
                goto label_28;
            }
            
            I2.Loc.TashkeelLocation val_7 = X2.Item[val_6];
            if(val_7.tashkeel != 'ّ')
            {
                goto label_28;
            }
            
            I2.Loc.TashkeelLocation val_8 = X2.Item[val_6];
            val_8.tashkeel = 'ﱡ';
            goto label_67;
            label_19:
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1614;
            goto label_58;
            label_24:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1616)
            {
                goto label_34;
            }
            
            int val_9 = val_19 - 1;
            if(val_16 < 1616)
            {
                goto label_38;
            }
            
            I2.Loc.TashkeelLocation val_10 = X2.Item[val_9];
            if(val_10.tashkeel != 'ّ')
            {
                goto label_38;
            }
            
            label_65:
            I2.Loc.TashkeelLocation val_11 = X2.Item[val_9];
            val_11.tashkeel = 'ﱢ';
            goto label_67;
            label_28:
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1615;
            goto label_58;
            label_34:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1617)
            {
                goto label_44;
            }
            
            int val_12 = val_19 - 1;
            if(val_16 < 1617)
            {
                goto label_63;
            }
            
            I2.Loc.TashkeelLocation val_13 = X2.Item[val_12];
            val_20 = X2.Item[val_12];
            if(val_13.tashkeel != 'َ')
            {
                goto label_50;
            }
            
            val_21 = 64608;
            goto label_51;
            label_38:
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1616;
            goto label_58;
            label_44:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1618)
            {
                goto label_54;
            }
            
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1618;
            goto label_58;
            label_54:
            if(val_15 >= val_2.Length)
            {
                    val_16 = mem[val_2[0x1] + 32];
                val_16 = val_2[0x1] + 32;
            }
            
            if(val_16 != 1619)
            {
                goto label_67;
            }
            
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1619;
            goto label_58;
            label_50:
            val_20 = X2.Item[val_12];
            if(val_14.tashkeel != 'ُ')
            {
                goto label_61;
            }
            
            val_21 = 64609;
            label_51:
            val_15.tashkeel = 'ﱡ';
            goto label_67;
            label_61:
            if(val_15.tashkeel != 'ِ')
            {
                goto label_63;
            }
            
            if(X2 != 0)
            {
                goto label_65;
            }
            
            goto label_65;
            label_63:
            val_17 = mem[X2];
            val_17 = X2;
            val_18 = null;
            val_19 = 1617;
            label_58:
            val_18 = new I2.Loc.TashkeelLocation(tashkeel:  'ّ', position:  1);
            val_17.Add(item:  val_18);
            val_19 = val_19 + 1;
            goto label_67;
            label_4:
            val_22 = null;
            val_22 = null;
            val_23 = 0;
            val_24 = System.String.Empty;
            goto label_71;
            label_77:
            val_24 = 0 + val_24;
            val_23 = 1;
            label_71:
            if(val_23 >= val_17.Length)
            {
                    return (string)val_24;
            }
            
            string val_20 = tashkeelLocation.Split(separator:  null)[1];
            goto label_77;
        }
        internal static char[] ReturnTashkeel(char[] letters, System.Collections.Generic.List<I2.Loc.TashkeelLocation> tashkeelLocation)
        {
            var val_6;
            var val_8;
            int val_2 = W9 + X2.Count;
            val_8 = 0;
            var val_8 = 0;
            goto label_3;
            label_20:
            val_8 = 1;
            label_3:
            if(val_8 >= 1152921505017588960)
            {
                    return (System.Char[])null;
            }
            
            System.Collections.Generic.List<I2.Loc.TashkeelLocation> val_3 = tashkeelLocation + 2;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 1;
            List.Enumerator<T> val_4 = X2.GetEnumerator();
            goto label_10;
            label_16:
            typeof(System.Char[]).__il2cppRuntimeField_20 = 1;
            label_10:
            val_8 = val_8 + 1;
            label_13:
            if((0 & 1) == 0)
            {
                goto label_11;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_7 = val_6.InitializationCallback;
            if(0 != val_8)
            {
                goto label_13;
            }
            
            if(null != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_11:
            val_6.Dispose();
            goto label_20;
        }
        internal static string FixLine(string str)
        {
            var val_69;
            var val_70;
            int val_71;
            System.Collections.Generic.List<I2.Loc.TashkeelLocation> val_72;
            var val_73;
            var val_74;
            int val_75;
            char val_76;
            var val_77;
            var val_78;
            int val_79;
            char val_80;
            var val_81;
            char val_82;
            var val_84;
            System.Char[] val_85;
            char val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            val_69 = null;
            val_69 = null;
            val_70 = 1152921504969678848;
            string val_2 = I2.Loc.RTLFixerTool.RemoveTashkeel(str:  null, tashkeelLocation: out  X1);
            if(val_2 != null)
            {
                    val_71 = val_2.ToCharArray();
            }
            else
            {
                    val_71 = 0.ToCharArray();
            }
            
            val_72 = val_2.ToCharArray();
            val_73 = 0;
            goto label_7;
            label_13:
            val_73 = 1;
            mem2[0] = ???;
            label_7:
            if(val_73 >= val_4.Length)
            {
                goto label_9;
            }
            
            int val_7 = I2.Loc.ArabicTable.ArabicMapper.Convert(toBeConverted:  val_71[1]);
            if(val_73 < val_4.Length)
            {
                goto label_13;
            }
            
            goto label_13;
            label_9:
            val_74 = 0;
            goto label_14;
            label_123:
            val_74 = 1;
            label_14:
            if(val_74 >= val_4.Length)
            {
                goto label_16;
            }
            
            if(val_71[1] != 'ģ')
            {
                goto label_33;
            }
            
            val_75 = val_4.Length;
            if(val_74 >= (val_75 - 1))
            {
                goto label_33;
            }
            
            var val_9 = val_74 + 1;
            if(val_9 >= val_75)
            {
                    val_75 = val_4.Length;
            }
            
            val_76 = val_71[(long)val_9];
            if(val_76 != 'ﺇ')
            {
                goto label_21;
            }
            
            val_77 = 65271;
            goto label_31;
            label_21:
            if((long)val_9 >= val_75)
            {
                    val_76 = mem[val_4[(long)(int)((val_74 + 1))] + 32];
                val_76 = val_4[(long)(int)((val_74 + 1))] + 32;
                val_75 = val_4.Length;
            }
            
            if(val_76 != 65165)
            {
                goto label_25;
            }
            
            val_77 = 65273;
            goto label_31;
            label_25:
            if((long)val_9 >= val_75)
            {
                    val_76 = mem[val_4[(long)(int)((val_74 + 1))] + 32];
                val_76 = val_4[(long)(int)((val_74 + 1))] + 32;
                val_75 = val_4.Length;
            }
            
            if(val_76 != 65155)
            {
                goto label_29;
            }
            
            val_77 = 65269;
            goto label_31;
            label_29:
            if((long)val_9 >= val_75)
            {
                    val_76 = mem[val_4[(long)(int)((val_74 + 1))] + 32];
                val_76 = val_4[(long)(int)((val_74 + 1))] + 32;
            }
            
            if(val_76 != 65153)
            {
                goto label_33;
            }
            
            val_77 = 65267;
            label_31:
            mem2[0] = 65267;
            val_78 = 1;
            val_72[(long)val_9] = 65535;
            goto label_37;
            label_33:
            val_78 = 0;
            label_37:
            if((I2.Loc.RTLFixerTool.IsIgnoredCharacter(ch:  '怀')) == true)
            {
                goto label_59;
            }
            
            if((I2.Loc.RTLFixerTool.IsMiddleLetter(letters:  null, index:  val_71)) == false)
            {
                goto label_45;
            }
            
            val_79 = val_5.Length;
            val_80 = (val_4[0x1] + 32) + 3;
            goto label_56;
            label_45:
            if((I2.Loc.RTLFixerTool.IsFinishingLetter(letters:  null, index:  val_71)) == false)
            {
                goto label_52;
            }
            
            val_79 = val_5.Length;
            val_80 = (val_4[0x1] + 32) + 1;
            goto label_56;
            label_52:
            if((I2.Loc.RTLFixerTool.IsLeadingLetter(letters:  null, index:  val_71)) == false)
            {
                goto label_59;
            }
            
            val_79 = val_5.Length;
            val_80 = (val_4[0x1] + 32) + 2;
            label_56:
            val_72[1] = val_80;
            label_59:
            string val_16 = 0 + System.String.Empty + System.Convert.ToString(value:  0, toBase:  val_4[0x1] + 32)(System.Convert.ToString(value:  0, toBase:  val_4[0x1] + 32));
            val_81 = null;
            val_81 = null;
            val_74 = val_78 + val_74;
            if(I2.Loc.RTLFixerTool.useHinduNumbers == false)
            {
                goto label_123;
            }
            
            val_82 = val_71[(long)val_74];
            if(val_82 != '0')
            {
                goto label_75;
            }
            
            val_84 = 1632;
            goto label_118;
            label_75:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 49)
            {
                goto label_80;
            }
            
            val_84 = 1633;
            goto label_118;
            label_80:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 50)
            {
                goto label_85;
            }
            
            val_84 = 1634;
            goto label_118;
            label_85:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 51)
            {
                goto label_90;
            }
            
            val_84 = 1635;
            goto label_118;
            label_90:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 52)
            {
                goto label_95;
            }
            
            val_84 = 1636;
            goto label_118;
            label_95:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 53)
            {
                goto label_100;
            }
            
            val_84 = 1637;
            goto label_118;
            label_100:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 54)
            {
                goto label_105;
            }
            
            val_84 = 1638;
            goto label_118;
            label_105:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 55)
            {
                goto label_110;
            }
            
            val_84 = 1639;
            goto label_118;
            label_110:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 56)
            {
                goto label_115;
            }
            
            val_84 = 1640;
            goto label_118;
            label_115:
            if(val_74 >= val_4.Length)
            {
                    val_82 = mem[val_4[(long)(int)((val_78 + val_74))] + 32];
                val_82 = val_4[(long)(int)((val_78 + val_74))] + 32;
            }
            
            if(val_82 != 57)
            {
                goto label_123;
            }
            
            val_84 = 1641;
            label_118:
            val_72[(long)val_74] = '٩';
            goto label_123;
            label_16:
            val_85 = null;
            val_85 = null;
            if(I2.Loc.RTLFixerTool.showTashkeel != false)
            {
                    val_72 = I2.Loc.RTLFixerTool.ReturnTashkeel(letters:  val_85, tashkeelLocation:  val_72);
            }
            
            System.Collections.Generic.List<System.Char> val_18 = new System.Collections.Generic.List<System.Char>();
            System.Collections.Generic.List<System.Char> val_19 = new System.Collections.Generic.List<System.Char>();
            int val_20 = val_17.Length - 1;
            if((val_20 & 2147483648) != 0)
            {
                goto label_130;
            }
            
            val_70 = 1152921504608231424;
            goto label_286;
            label_284:
            if((long)val_20 < val_17.Length)
            {
                goto label_132;
            }
            
            label_281:
            label_282:
            val_86 = mem[X26];
            val_86 = X26;
            label_132:
            if(val_86 == 65535)
            {
                goto label_133;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[X26];
                val_86 = X26;
            }
            
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_136;
            label_286:
            char val_71 = val_72[(long)val_20];
            val_88 = (long)val_20 - 1;
            if(((long)val_20 < val_17.Length) || (((System.Char.IsPunctuation(c:  ' ')) ^ 1) == true))
            {
                goto label_153;
            }
            
            var val_72 = -4294967296;
            val_72 = val_72 + ((val_17.Length) << 32);
            if((long)val_20 >= (val_72 >> 32))
            {
                goto label_153;
            }
            
            char val_73 = val_72[(long)val_17.Length - 2];
            if((System.Char.IsPunctuation(c:  ' ')) == true)
            {
                goto label_148;
            }
            
            char val_74 = val_72[(long)val_17.Length];
            if((System.Char.IsPunctuation(c:  ' ')) == false)
            {
                goto label_153;
            }
            
            label_148:
            val_89 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
            val_89 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            if(val_89 != 40)
            {
                goto label_156;
            }
            
            val_90 = val_18;
            val_91 = 41;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_279;
            label_153:
            if(((long)val_20 < 1) || ((val_17[(long)(int)((val_17.Length - 1))] + 32) != 32))
            {
                goto label_192;
            }
            
            var val_75 = -4294967296;
            val_75 = val_75 + ((val_17.Length) << 32);
            if((long)val_20 >= (val_75 >> 32))
            {
                goto label_192;
            }
            
            char val_76 = val_72[(long)val_17.Length - 2];
            if((System.Char.IsLower(c:  ' ')) != true)
            {
                    if((System.Char.IsUpper(c:  ' ')) != true)
            {
                    if((System.Char.IsNumber(c:  ' ')) == false)
            {
                goto label_192;
            }
            
            }
            
            }
            
            char val_77 = val_72[(long)val_17.Length];
            if((System.Char.IsLower(c:  ' ')) != true)
            {
                    if((System.Char.IsUpper(c:  ' ')) != true)
            {
                    if((System.Char.IsNumber(c:  ' ')) == false)
            {
                goto label_192;
            }
            
            }
            
            }
            
            val_88 = val_88;
            if((long)val_20 >= val_17.Length)
            {
                goto label_194;
            }
            
            goto label_195;
            label_192:
            val_88 = val_88;
            if((((System.Char.IsNumber(c:  ' ')) != true) && ((System.Char.IsLower(c:  ' ')) != true)) && ((System.Char.IsUpper(c:  ' ')) != true))
            {
                    if((System.Char.IsSymbol(c:  ' ')) != true)
            {
                    if((System.Char.IsPunctuation(c:  ' ')) == false)
            {
                goto label_220;
            }
            
            }
            
            }
            
            val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
            val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            if(val_86 != 40)
            {
                goto label_223;
            }
            
            val_91 = 41;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_275;
            label_223:
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_86 != 41)
            {
                goto label_227;
            }
            
            val_91 = 40;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_275;
            label_227:
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_86 != 60)
            {
                goto label_231;
            }
            
            val_91 = 62;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_275;
            label_156:
            if((long)val_20 >= val_17.Length)
            {
                    val_89 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_89 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_89 != 41)
            {
                goto label_235;
            }
            
            val_90 = val_18;
            val_91 = 40;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_279;
            label_231:
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_86 != 62)
            {
                goto label_239;
            }
            
            val_91 = 60;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_275;
            label_235:
            if((long)val_20 >= val_17.Length)
            {
                    val_89 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_89 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_89 != 60)
            {
                goto label_243;
            }
            
            val_90 = val_18;
            val_91 = 62;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_279;
            label_239:
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_86 == 91)
            {
                goto label_247;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_86 == 93)
            {
                goto label_249;
            }
            
            goto label_263;
            label_243:
            if((long)val_20 >= val_17.Length)
            {
                    val_89 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_89 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_89 != 62)
            {
                goto label_252;
            }
            
            val_90 = val_18;
            val_91 = 60;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_279;
            label_220:
            val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
            val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            if((val_86 >> 11) < 27)
            {
                goto label_257;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if((val_86 >> 10) < 55)
            {
                goto label_263;
            }
            
            label_257:
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if((val_86 >> 10) < 55)
            {
                goto label_261;
            }
            
            if((long)val_20 >= val_17.Length)
            {
                    val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if((val_86 >> 13) <= 6)
            {
                goto label_263;
            }
            
            label_261:
            if(Count < 1)
            {
                goto label_265;
            }
            
            val_92 = 0;
            val_93 = 0;
            goto label_266;
            label_272:
            val_88.Add(item:  val_86);
            val_92 = 1;
            val_93 = -1;
            label_266:
            if(null == 0)
            {
                goto label_267;
            }
            
            if(val_92 >= Count)
            {
                goto label_270;
            }
            
            val_94 = Count;
            goto label_269;
            label_267:
            if(val_92 >= Count)
            {
                goto label_270;
            }
            
            val_94 = Count;
            label_269:
            char val_58 = Item[val_93 + val_94];
            if(null != 0)
            {
                goto label_272;
            }
            
            goto label_272;
            label_263:
            if((long)val_20 < val_17.Length)
            {
                goto label_273;
            }
            
            label_194:
            label_195:
            val_86 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
            val_86 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            label_273:
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            label_136:
            val_91 = val_86;
            goto label_275;
            label_252:
            if((long)val_20 >= val_17.Length)
            {
                    val_89 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_89 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_89 != 91)
            {
                goto label_277;
            }
            
            label_247:
            val_90 = val_18;
            val_91 = 93;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            goto label_279;
            label_270:
            Clear();
            label_265:
            if((long)val_20 >= val_17.Length)
            {
                goto label_281;
            }
            
            goto label_282;
            label_277:
            if((long)val_20 >= val_17.Length)
            {
                    val_89 = mem[val_17[(long)(int)((val_17.Length - 1))] + 32];
                val_89 = val_17[(long)(int)((val_17.Length - 1))] + 32;
            }
            
            if(val_89 != 93)
            {
                goto label_284;
            }
            
            label_249:
            val_90 = val_18;
            val_91 = 91;
            val_87 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
            label_279:
            label_275:
            Add(item:  '[');
            label_133:
            if((val_88 & 2147483648) == 0)
            {
                goto label_286;
            }
            
            label_130:
            if(Count < 1)
            {
                goto label_288;
            }
            
            val_70 = 1152921512326669616;
            val_95 = 0;
            val_96 = 0;
            goto label_289;
            label_295:
            Add(item:  val_72);
            val_95 = 1;
            val_96 = -1;
            label_289:
            if(null == 0)
            {
                goto label_290;
            }
            
            if(val_95 >= Count)
            {
                goto label_293;
            }
            
            val_97 = Count;
            goto label_292;
            label_290:
            if(val_95 >= Count)
            {
                goto label_293;
            }
            
            val_97 = Count;
            label_292:
            char val_65 = Item[val_96 + val_97];
            if(null != 0)
            {
                goto label_295;
            }
            
            goto label_295;
            label_293:
            Clear();
            label_288:
            int val_66 = Count;
            val_98 = 0;
            goto label_297;
            label_302:
            val_98 = 1;
            mem[1152921505017588990] = 1152921509801877920;
            label_297:
            char val_67 = Item[1];
            goto label_302;
        }
        internal static bool IsIgnoredCharacter(char ch)
        {
            var val_19;
            bool val_5 = System.Char.IsSymbol(c:  ' ');
            var val_6 = W1 + 1194;
            val_6 = val_6 & 65535;
            if(val_6 >= 61)
            {
                goto label_3;
            }
            
            val_6 = 1157425172953694209 >> val_6;
            if((val_6 & 1) != 0)
            {
                goto label_4;
            }
            
            label_3:
            var val_8 = ((W1 & 65535) == 64398) ? 1 : 0;
            goto label_5;
            label_4:
            val_19 = 1;
            label_5:
            var val_9 = W1 + 400;
            bool val_10 = (System.Char.IsPunctuation(c:  ' ')) | (System.Char.IsNumber(c:  ' '));
            val_9 = val_9 & 65535;
            var val_11 = W1 & 65535;
            val_10 = val_10 | (System.Char.IsLower(c:  ' '));
            val_19 = val_19 ^ 1;
            bool val_12 = val_10 | (System.Char.IsUpper(c:  ' '));
            var val_14 = W1 | 2;
            val_19 = ((val_9 > 143) ? 1 : 0) & val_19;
            val_14 = val_14 & 65535;
            val_12 = val_12 | val_5;
            val_19 = ((val_11 != 64508) ? 1 : 0) & val_19;
            val_19 = val_12 | val_19;
            val_19 = ((val_11 == 97) ? 1 : 0) | val_19;
            val_19 = ((val_14 == 62) ? 1 : 0) | val_19;
            val_19 = ((val_11 == 1563) ? 1 : 0) | val_19;
            val_5 = val_19;
            return (bool)val_5;
        }
        internal static bool IsLeadingLetter(char[] letters, int index)
        {
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            if(W2 == 0)
            {
                goto label_1;
            }
            
            int val_2 = index + (((long)(int)((W2 - 1))) << 1);
            val_25 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
            val_25 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            if(val_25 == 32)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_25 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_25 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_25 == 42)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_25 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_25 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_25 == 65)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_25 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_25 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if((System.Char.IsPunctuation(c:  ' ')) == false)
            {
                goto label_12;
            }
            
            label_1:
            if(index == 0)
            {
                goto label_13;
            }
            
            val_26 = 0;
            val_27 = 0;
            goto label_15;
            label_13:
            val_27 = 0;
            val_26 = 1;
            goto label_15;
            label_12:
            val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
            val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            if(val_28 == 62)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 60)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65165)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65193)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65195)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65197)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65199)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 64394)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65261)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65153)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 == 65155)
            {
                goto label_38;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_28 != 65159)
            {
                goto label_40;
            }
            
            label_38:
            label_98:
            val_26 = 0;
            label_15:
            int val_6 = index + (((long)(int)(W2)) << 1);
            val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
            val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            if(val_29 == 32)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65193)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65195)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65197)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65199)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 64394)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65165)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65155)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65159)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65153)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 == 65157)
            {
                goto label_62;
            }
            
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_29 != 65261)
            {
                goto label_64;
            }
            
            label_62:
            label_96:
            if(((index + 24) - 1) > W2)
            {
                    int val_9 = index + (((long)(int)((W2 + 1))) << 1);
                val_30 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
                val_30 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
                if(val_30 != 32)
            {
                    if(((long)W2 + 1) >= (index + 24))
            {
                    val_30 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
                val_30 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            }
            
                if((((System.Char.IsPunctuation(c:  ' ')) != true) && ((System.Char.IsNumber(c:  ' ')) != true)) && ((System.Char.IsSymbol(c:  ' ')) != true))
            {
                    if((System.Char.IsLower(c:  ' ')) != true)
            {
                    if((System.Char.IsUpper(c:  ' ')) == false)
            {
                goto label_91;
            }
            
            }
            
            }
            
            }
            
            }
            
            var val_25 = 1;
            label_94:
            var val_20 = (0 == 0) ? 1 : 0;
            val_20 = ((1 == 0) ? 1 : 0) | val_20;
            val_25 = val_20 | val_25;
            return (bool)val_25 ^ 1;
            label_91:
            var val_22 = (((index + ((long)(int)((W2 + 1))) << 1) + 32) == 384) ? 1 : 0;
            goto label_94;
            label_64:
            if((index + 24) <= W2)
            {
                    val_29 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_29 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            var val_23 = (val_29 != 65152) ? 1 : 0;
            goto label_96;
            label_40:
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_28 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_28 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            var val_24 = (val_28 == 65157) ? 1 : 0;
            goto label_98;
        }
        internal static bool IsFinishingLetter(char[] letters, int index)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            if(W2 == 0)
            {
                goto label_1;
            }
            
            int val_2 = index + (((long)(int)((W2 - 1))) << 1);
            val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
            val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            if(val_9 == 32)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65193)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65195)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65197)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65199)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 64394)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65261)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65165)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65153)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65155)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65159)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65157)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_9 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_9 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_9 == 65152)
            {
                goto label_40;
            }
            
            if((System.Char.IsPunctuation(c:  ' ')) == false)
            {
                goto label_32;
            }
            
            label_1:
            label_40:
            label_42:
            int val_5 = index + (((long)(int)(W2)) << 1);
            val_10 = mem[(index + ((long)(int)(W2)) << 1) + 32];
            val_10 = (index + ((long)(int)(W2)) << 1) + 32;
            if(val_10 == 32)
            {
                    val_11 = 1;
            }
            else
            {
                    if((index + 24) <= W2)
            {
                    val_10 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_10 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
                var val_6 = (val_10 == 65152) ? 1 : 0;
            }
            
            val_6 = 1 | val_6;
            return (bool)val_6 ^ 1;
            label_32:
            val_12 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
            val_12 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            if(val_12 == 62)
            {
                goto label_40;
            }
            
            if(((long)W2 - 1) >= (index + 24))
            {
                    val_12 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_12 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            var val_8 = (val_12 == 60) ? 1 : 0;
            goto label_42;
        }
        internal static bool IsMiddleLetter(char[] letters, int index)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_21 = W2;
            val_21 = index;
            if(val_21 == 0)
            {
                goto label_1;
            }
            
            int val_1 = val_21 + (((long)(int)(W2)) << 1);
            val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
            val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            if(val_22 == 65165)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65193)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65195)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65197)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65199)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 64394)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65261)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65153)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65155)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 == 65159)
            {
                goto label_22;
            }
            
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            if(val_22 != 65157)
            {
                goto label_24;
            }
            
            label_22:
            label_93:
            var val_3 = (0 == 0) ? 1 : 0;
            int val_4 = val_21 + (((long)(int)((W2 - 1))) << 1);
            val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
            val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            if(val_20 == 65165)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65193)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65195)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65197)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65199)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 64394)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65261)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65153)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65155)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65159)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65157)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_20 == 65152)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if((System.Char.IsPunctuation(c:  ' ')) == true)
            {
                goto label_52;
            }
            
            val_24 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
            val_24 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            if(val_24 == 62)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_24 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_24 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_24 == 60)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_24 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_24 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            if(val_24 == 32)
            {
                goto label_59;
            }
            
            if(((long)val_21 - 1) >= (index + 24))
            {
                    val_24 = mem[(index + ((long)(int)((W2 - 1))) << 1) + 32];
                val_24 = (index + ((long)(int)((W2 - 1))) << 1) + 32;
            }
            
            val_25 = 0;
            var val_7 = (val_24 != 42) ? 1 : 0;
            goto label_91;
            label_1:
            val_23 = 1;
            label_52:
            if(val_21 == 0)
            {
                goto label_91;
            }
            
            label_59:
            val_25 = 0;
            val_26 = 0;
            label_91:
            if(((index + 24) - 1) <= val_21)
            {
                goto label_85;
            }
            
            int val_10 = val_21 + (((long)(int)((W2 + 1))) << 1);
            val_20 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
            val_20 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            if(val_20 == 32)
            {
                goto label_85;
            }
            
            if(((long)val_21 + 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            }
            
            if(val_20 == 13)
            {
                goto label_85;
            }
            
            if(((long)val_21 + 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            }
            
            if(val_20 == 65152)
            {
                goto label_85;
            }
            
            if(((long)val_21 + 1) >= (index + 24))
            {
                    val_20 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
                val_20 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            }
            
            if((System.Char.IsNumber(c:  ' ')) == true)
            {
                goto label_85;
            }
            
            val_20 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
            val_20 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            if((System.Char.IsSymbol(c:  ' ')) == true)
            {
                goto label_85;
            }
            
            val_20 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
            val_20 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            if(((val_26 == 0) || (((System.Char.IsPunctuation(c:  ' ')) ^ 1) == false)) || (val_23 ^ 1 == 0))
            {
                goto label_85;
            }
            
            val_21 = val_21 + 1;
            int val_18 = val_21 + (((long)(int)((W2 + 1))) << 1);
            val_21 = mem[(index + ((long)(int)((W2 + 1))) << 1) + 32];
            val_21 = (index + ((long)(int)((W2 + 1))) << 1) + 32;
            val_27 = (~(System.Char.IsPunctuation(c:  ' '))) & 1;
            return (bool)val_27;
            label_24:
            if((index + 24) <= val_21)
            {
                    val_22 = mem[(index + ((long)(int)(W2)) << 1) + 32];
                val_22 = (index + ((long)(int)(W2)) << 1) + 32;
            }
            
            var val_20 = (val_22 != 65152) ? 1 : 0;
            goto label_93;
            label_85:
            val_27 = 0;
            return (bool)val_27;
        }
        private static RTLFixerTool()
        {
            I2.Loc.RTLFixerTool.showTashkeel = true;
        }
    
    }

}
