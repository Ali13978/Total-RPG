using UnityEngine;

namespace Mono.Xml
{
    internal class MiniParser
    {
        // Fields
        private static readonly int INPUT_RANGE;
        private static readonly ushort[] tbl;
        protected static string[] errors;
        protected int line;
        protected int col;
        protected int[] twoCharBuff;
        protected bool splitCData;
        
        // Methods
        public MiniParser()
        {
            this.line = 0;
            this.col = 0;
            this.twoCharBuff = null;
            this.splitCData = false;
        }
        public void Reset()
        {
            this.line = 0;
            this.col = 0;
        }
        protected static bool StrEquals(string str, System.Text.StringBuilder sb, int sbStart, int len)
        {
            var val_6;
            var val_7;
            if(sb.Length != W4)
            {
                goto label_5;
            }
            
            if(W4 < 1)
            {
                goto label_2;
            }
            
            val_6 = 0;
            label_6:
            if((sb.Chars[0] & 65535) != (sbStart.Chars[len + val_6]))
            {
                goto label_5;
            }
            
            val_6 = val_6 + 1;
            if(val_6 < W4)
            {
                goto label_6;
            }
            
            label_2:
            val_7 = 1;
            return (bool)val_7;
            label_5:
            val_7 = 0;
            return (bool)val_7;
        }
        protected void FatalErr(string descr)
        {
            System.Exception val_2 = new System.Exception(message:  descr);
            typeof(MiniParser.XMLError).__il2cppRuntimeField_60 = descr;
            typeof(MiniParser.XMLError).__il2cppRuntimeField_68 = this.line;
            typeof(MiniParser.XMLError).__il2cppRuntimeField_6C = this.line >> 32;
        }
        protected static int Xlat(int charCode, int state)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_6 = W2;
            val_7 = null;
            val_7 = null;
            val_6 = Mono.Xml.MiniParser.INPUT_RANGE * val_6;
            int val_3 = (System.Math.Min(val1:  0, val2:  Mono.Xml.MiniParser.tbl.Length - val_6)) - 1;
            if((val_3 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            label_10:
            val_8 = null;
            val_8 = null;
            System.UInt16[] val_4 = Mono.Xml.MiniParser.tbl + (((long)(int)((Mono.Xml.MiniParser.INPUT_RANGE * W2))) << 1);
            if((((Mono.Xml.MiniParser.tbl + ((long)(int)((Mono.Xml.MiniParser.INPUT_RANGE * W2))) << 1) + 32) >> 12) == state)
            {
                goto label_9;
            }
            
            val_6 = val_6 + 1;
            val_3 = val_3 - 1;
            if((val_3 & 2147483648) == 0)
            {
                goto label_10;
            }
            
            label_4:
            val_9 = 4095;
            return (int)val_9;
            label_9:
            val_9 = ((Mono.Xml.MiniParser.tbl + ((long)(int)((Mono.Xml.MiniParser.INPUT_RANGE * W2))) << 1) + 32) & 4095;
            return (int)val_9;
        }
        public void Parse(Mono.Xml.MiniParser.IReader reader, Mono.Xml.MiniParser.IHandler handler)
        {
            int val_36;
            var val_93;
            Mono.Xml.MiniParser val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            var val_101;
            var val_103;
            var val_109;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            int val_115;
            var val_116;
            var val_117;
            var val_119;
            var val_121;
            var val_122;
            int val_123;
            var val_124;
            var val_125;
            var val_126;
            var val_127;
            var val_128;
            char val_130;
            var val_133;
            var val_134;
            System.FormatException val_135;
            var val_136;
            var val_137;
            var val_138;
            int val_139;
            string val_142;
            var val_144;
            var val_145;
            var val_146;
            var val_147;
            val_93 = handler;
            val_94 = this;
            if(reader == null)
            {
                goto label_1;
            }
            
            if(val_93 == null)
            {
                    object val_1 = null;
                val_93 = val_1;
                val_1 = new System.Object();
            }
            
            MiniParser.AttrListImpl val_2 = new MiniParser.AttrListImpl(initialCapacity:  0);
            System.Collections.Stack val_3 = new System.Collections.Stack();
            this.line = 1;
            this.col = 0;
            System.Text.StringBuilder val_4 = new System.Text.StringBuilder();
            MiniParser.HandlerAdapter val_91 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_89 = mem[null + 152];
            var val_90 = 0;
            val_89 = val_89 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_90 = val_90 + 1;
            val_89 = val_89 + 16;
            if(val_90 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_95 = val_93;
            goto label_7;
            label_5:
            val_91 = val_91 + (((mem[null + 152] + 8)) << 4);
            label_7:
            val_96 = mem[.ctor() + 8];
            val_97 = 0;
            val_98 = 0;
            goto label_215;
            label_217:
            val_97 = val_3;
            val_98 = W23;
            label_215:
            int val_92 = this.col;
            val_92 = val_92 + 1;
            this.col = val_92;
            var val_93 = 0;
            val_93 = val_93 + 1;
            val_96 = 0;
            val_99 = reader;
            if(reader == 1)
            {
                goto label_13;
            }
            
            val_100 = "<>/?=&\'\"![ ]\t\r\n";
            if(("<>/?=&\'\"![ ]\t\r\n") == null)
            {
                    val_100 = "<>/?=&\'\"![ ]\t\r\n";
            }
            
            val_101 = (IndexOf(value:  reader)) & 15;
            if(val_101 == 13)
            {
                goto label_215;
            }
            
            if(val_101 == 12)
            {
                goto label_16;
            }
            
            if(val_101 != 14)
            {
                goto label_17;
            }
            
            int val_94 = this.line;
            val_94 = val_94 + 1;
            this.line = val_94;
            this.col = 0;
            label_16:
            val_101 = 10;
            label_17:
            int val_7 = Mono.Xml.MiniParser.Xlat(charCode:  296484864, state:  10);
            int val_8 = val_7 & 255;
            if(reader != 10)
            {
                goto label_20;
            }
            
            val_98 = val_8;
            if((val_7 & 254) == 14)
            {
                goto label_215;
            }
            
            label_20:
            if(val_8 >= 128)
            {
                goto label_22;
            }
            
            int val_10 = val_7 >> 8;
            if(((val_10 < 14) ? (val_10 + 22) : 0) > 35)
            {
                    return;
            }
            
            var val_95 = 25811560;
            val_95 = (25811560 + (val_10 < 14 ? ((val_7 >> 8) + 22) : 0) << 2) + val_95;
            goto (25811560 + (val_10 < 14 ? ((val_7 >> 8) + 22) : 0) << 2 + 25811560);
            label_34:
             =  + 1;
            val_103 = val_8;
            if(reader != 93)
            {
                goto label_29;
            }
            
            var val_98 = 0;
            val_98 = val_98 + 1;
            goto label_34;
            label_61:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_60;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[null + 258]))
            {
                goto label_61;
            }
            
            val_109 = val_93;
            goto label_62;
            label_29:
            if(reader != 62)
            {
                goto label_68;
            }
            
            if(( - 2) < 1)
            {
                goto label_69;
            }
            
            var val_105 = 2;
            do
            {
                System.Text.StringBuilder val_20 = Append(value:  ']');
                val_105 = val_105 + 1;
            }
            while( != val_105);
            
            val_103 = val_103;
            goto label_95;
            label_87:
            val_111 = 1;
            if(val_111 >= Length)
            {
                goto label_81;
            }
            
            var val_106 = 0;
            val_106 = val_106 + 1;
            val_112 = reader;
            if(reader == Chars[1])
            {
                goto label_87;
            }
            
            int val_107 = this.col;
            val_113 = val_2;
            val_114 = val_4;
            val_107 = val_111 + val_107;
            val_115 = val_107 + 1;
            this.col = val_115;
            goto label_88;
            label_68:
            var val_108 = 0;
            goto label_92;
            label_94:
            System.Text.StringBuilder val_29 = Append(value:  ']');
            label_92:
            val_108 = val_108 + 1;
            if(val_108 < )
            {
                goto label_94;
            }
            
            System.Text.StringBuilder val_30 = Append(value:  reader);
            val_103 = 18;
            goto label_95;
            label_102:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_101;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[null + 258]))
            {
                goto label_102;
            }
            
            val_116 = 2;
            val_117 = val_93;
            goto label_217;
            label_60:
            var val_112 = ;
            val_112 = val_112 + 3;
             =  + val_112;
            label_62:
            System.Text.StringBuilder val_35 = new System.Text.StringBuilder();
            goto label_217;
            label_101:
            var val_114 = ;
            val_114 = val_114 + 2;
             =  + val_114;
            goto label_217;
            label_123:
            val_119 = 12;
            int val_37 = (0 > 6) ? (val_36) : 0;
            label_130:
            val_36 = val_37;
            label_128:
            int val_42 = (reader.IndexOf(value:  'က')) & 15;
            if(val_42 == 15)
            {
                goto label_131;
            }
            
            System.Text.StringBuilder val_43 = Append(value:  'က');
            val_121 = "Ｕ㾏侏ཟｸ⊙ｏ";
            if("Ｕ㾏侏ཟｸ⊙ｏ" == null)
            {
                    val_121 = "Ｕ㾏侏ཟｸ⊙ｏ";
            }
            
            int val_117 = Chars[val_42];
            char val_45 = val_117 & 65535;
            var val_116 = 0;
            val_116 = val_116 + 1;
            val_122 = reader;
            val_123 = val_8 + 1;
            if(((uint)(val_45 >> 4) & 15) != 15)
            {
                    if(reader == (reader.Chars[(uint)(val_45 >> 4) & 15]))
            {
                goto label_123;
            }
            
            }
            
            val_117 = val_117 & 15;
            if(val_117 != '')
            {
                    if(reader == reader.Chars[val_117])
            {
                goto label_126;
            }
            
            }
            
            var val_49 = (reader != 59) ? 1 : 0;
            val_49 = val_49 | (((val_119 == 0) ? 1 : 0) | ((val_37 == 15) ? 1 : 0));
            if(val_49 != 1)
            {
                goto label_127;
            }
            
            if(reader != 59)
            {
                goto label_128;
            }
            
            goto label_131;
            label_126:
            var val_50 = (((uint)(val_45 >> 8) & 15) > 13) ? (val_36) : ((uint)(val_45 >> 8) & 15);
            goto label_130;
            label_127:
            var val_118 = val_119;
            val_118 = val_45 >> val_118;
            val_118 = val_118 & 15;
            if(val_118 != '')
            {
                goto label_131;
            }
            
            val_94 = val_94;
            int val_119 = this.col;
            val_119 = val_123 - val_119;
            if((val_119 - 2) > 3)
            {
                goto label_147;
            }
            
            int val_52 = val_119 - 1;
            if((((Mono.Xml.MiniParser.StrEquals(str:  null, sb:  "amp", sbStart:  48295936, len:  null)) != true) && ((Mono.Xml.MiniParser.StrEquals(str:  null, sb:  "apos", sbStart:  48295936, len:  null)) != true)) && ((Mono.Xml.MiniParser.StrEquals(str:  null, sb:  "quot", sbStart:  48295936, len:  null)) != true))
            {
                    if((Mono.Xml.MiniParser.StrEquals(str:  null, sb:  "lt", sbStart:  48295936, len:  null)) != true)
            {
                    if((Mono.Xml.MiniParser.StrEquals(str:  null, sb:  "gt", sbStart:  48295936, len:  null)) == false)
            {
                goto label_147;
            }
            
            }
            
            }
            
            Length = ;
            System.Text.StringBuilder val_63 = Append(value:  Chars[val_36]);
            goto label_151;
            label_155:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_154;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[null + 258]))
            {
                goto label_155;
            }
            
            val_124 = val_93;
            goto label_156;
            label_154:
            var val_122 = ;
            val_122 = val_122 + 1;
             =  + val_122;
            label_156:
            val_125 = val_2;
            if(reader != 47)
            {
                goto label_157;
            }
            
            MiniParser.HandlerAdapter val_130 = null;
            val_126 = val_3;
            if((mem[null + 258]) == 0)
            {
                goto label_159;
            }
            
            var val_124 = mem[null + 152];
            var val_125 = 0;
            val_124 = val_124 + 8;
            label_161:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_160;
            }
            
            val_125 = val_125 + 1;
            val_124 = val_124 + 16;
            if(val_125 < (mem[null + 258]))
            {
                goto label_161;
            }
            
            label_159:
            val_125 = 2;
            val_127 = val_93;
            goto label_162;
            label_157:
            val_126 = val_3;
            if(null != 0)
            {
                goto label_164;
            }
            
            goto label_164;
            label_173:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_172;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[null + 258]))
            {
                goto label_173;
            }
            
            val_128 = val_93;
            goto label_174;
            label_160:
            var val_129 = val_124;
            val_129 = val_129 + 2;
            val_130 = val_130 + val_129;
            label_162:
            label_164:
            Clear();
            goto label_217;
            label_69:
            label_95:
            int val_131 = this.col;
            val_131 = val_131 + ;
            this.col = val_131;
            goto label_215;
            label_81:
            val_114 = val_4;
            val_113 = val_2;
            val_115 = this.col;
            label_88:
            this.col = Length + val_115;
            goto label_215;
            label_203:
            val_130 = reader;
            val_123 =  + 1;
            if((System.Char.IsNumber(c:  ' ')) == true)
            {
                goto label_193;
            }
            
            val_134 = "abcdef";
            if("abcdef" == null)
            {
                    val_134 = "abcdef";
            }
            
            val_133 = ( == 16) ? 515 : 7;
            if((IndexOf(value:  System.Char.ToLower(c:  ' '))) == 1)
            {
                goto label_198;
            }
            
            label_193:
            int val_75 = System.Int32.Parse(s:  0, style:  0.CreateString(c:  val_130, count:  1));
            if(val_75 == 1)
            {
                goto label_198;
            }
            
            char val_133 = 0;
            val_133 = val_75 + (val_133 * );
            var val_134 = 0;
            val_134 = val_134 + 1;
            val_36 = 1;
            goto label_203;
            label_198:
            if(( < 1) || (val_130 != 59))
            {
                goto label_207;
            }
            
            System.Text.StringBuilder val_77 = Append(value:  val_133);
            label_151:
            this.col = val_123;
            goto label_215;
            label_172:
            var val_136 = ;
            val_136 = val_136 + 3;
             =  + val_136;
            label_174:
            System.Text.StringBuilder val_79 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_80 = Append(value:  reader);
            goto label_217;
            label_13:
            if(val_98 != 0)
            {
                goto label_218;
            }
            
            MiniParser.HandlerAdapter val_141 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_220;
            }
            
            var val_138 = mem[null + 152];
            var val_139 = 0;
            val_138 = val_138 + 8;
            label_222:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_221;
            }
            
            val_139 = val_139 + 1;
            val_138 = val_138 + 16;
            if(val_139 < (mem[null + 258]))
            {
                goto label_222;
            }
            
            label_220:
            val_96 = 4;
            val_136 = val_93;
            goto label_223;
            label_221:
            var val_140 = val_138;
            val_140 = val_140 + 4;
            val_141 = val_141 + val_140;
            label_223:
            label_131:
            val_137 = null;
            val_137 = null;
            val_138 = mem[Mono.Xml.MiniParser.errors + 88];
            val_138 = Mono.Xml.MiniParser.errors + 88;
            val_139 = mem[val_81 + 16];
            val_139 = val_81 + 16;
            goto label_229;
            label_22:
            var val_142 = val_8;
            if(val_8 != 255)
            {
                goto label_233;
            }
            
            val_142 = "State dispatch error.";
            goto label_257;
            label_233:
            val_144 = null;
            val_144 = null;
            val_142 = val_142 ^ 128;
            System.String[] val_84 = Mono.Xml.MiniParser.errors + ((((val_7 & 255) ^ 128)) << 3);
            val_138 = mem[(Mono.Xml.MiniParser.errors + (((val_7 & 255) ^ 128)) << 3) + 32];
            val_138 = (Mono.Xml.MiniParser.errors + (((val_7 & 255) ^ 128)) << 3) + 32;
            goto label_253;
            label_1:
            System.ArgumentNullException val_85 = null;
            val_145 = val_85;
            val_85 = new System.ArgumentNullException(paramName:  "reader");
            val_146 = 1152921511246407536;
            goto label_259;
            label_218:
            val_142 = "Unexpected EOF";
            goto label_257;
            label_147:
            val_147 = null;
            val_147 = null;
            val_138 = mem[Mono.Xml.MiniParser.errors + 88];
            val_138 = Mono.Xml.MiniParser.errors + 88;
            goto label_253;
            label_207:
            val_142 = "Bad char ref";
            goto label_257;
            label_259:
            val_135 = null;
            mem[8] = val_135;
            val_142 = "Invalid comment";
            label_257:
            label_253:
            val_139 = this.line;
            label_229:
            System.Exception val_88 = null;
            val_145 = val_88;
            val_88 = new System.Exception(message:  val_142);
            typeof(MiniParser.XMLError).__il2cppRuntimeField_60 = val_142;
            typeof(MiniParser.XMLError).__il2cppRuntimeField_68 = val_139;
            typeof(MiniParser.XMLError).__il2cppRuntimeField_6C = val_139 >> 32;
            val_146 = 1152921511245898512;
            goto label_259;
        }
        private static MiniParser()
        {
            Mono.Xml.MiniParser.INPUT_RANGE = 13;
            Mono.Xml.MiniParser.tbl = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "Expected element";
            typeof(System.String[]).__il2cppRuntimeField_28 = "Invalid character in tag";
            typeof(System.String[]).__il2cppRuntimeField_30 = "No \'=\'";
            typeof(System.String[]).__il2cppRuntimeField_38 = "Invalid character entity";
            typeof(System.String[]).__il2cppRuntimeField_40 = "Invalid attr value";
            typeof(System.String[]).__il2cppRuntimeField_48 = "Empty tag";
            typeof(System.String[]).__il2cppRuntimeField_50 = "No end tag";
            typeof(System.String[]).__il2cppRuntimeField_58 = "Bad entity ref";
            Mono.Xml.MiniParser.errors = null;
        }
    
    }

}
