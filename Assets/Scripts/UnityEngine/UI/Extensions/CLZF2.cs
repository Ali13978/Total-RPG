using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public static class CLZF2
    {
        // Fields
        private static readonly uint HLOG;
        private static readonly uint HSIZE;
        private static readonly uint MAX_LIT;
        private static readonly uint MAX_OFF;
        private static readonly uint MAX_REF;
        private static readonly long[] HashTable;
        
        // Methods
        public static byte[] Compress(byte[] inputBytes)
        {
            System.Byte[] val_4;
            var val_1 = (X1 + 24) << 1;
            val_4 = null;
            goto label_2;
            label_5:
            val_1 = val_1 << 1;
            val_4 = null;
            label_2:
            val_4 = null;
            if((UnityEngine.UI.Extensions.CLZF2.lzf_compress(input:  val_4, output: ref  X1)) == 0)
            {
                goto label_5;
            }
            
            System.Buffer.BlockCopy(src:  0, srcOffset:  460851360, dst:  0, dstOffset:  460851360, count:  0);
            return (System.Byte[])null;
        }
        public static byte[] Decompress(byte[] inputBytes)
        {
            System.Byte[] val_4;
            var val_1 = (X1 + 24) << 1;
            val_4 = null;
            goto label_2;
            label_5:
            val_1 = val_1 << 1;
            val_4 = null;
            label_2:
            val_4 = null;
            if((UnityEngine.UI.Extensions.CLZF2.lzf_decompress(input:  val_4, output: ref  X1)) == 0)
            {
                goto label_5;
            }
            
            System.Buffer.BlockCopy(src:  0, srcOffset:  460851360, dst:  0, dstOffset:  460851360, count:  0);
            return (System.Byte[])null;
        }
        public static int lzf_compress(byte[] input, ref byte[] output)
        {
            var val_1;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            uint val_62;
            var val_63;
            var val_64;
            uint val_65;
            var val_66;
            uint val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_75;
            val_49 = 1152921504994385920;
            val_50 = null;
            val_50 = null;
            System.Array.Clear(array:  0, index:  UnityEngine.UI.Extensions.CLZF2.HashTable, length:  0);
            val_51 = mem[1152921512777691432];
            if(val_51 == 0)
            {
                    val_51 = mem[1152921512777691432];
            }
            
            var val_70 = -8589934592;
            val_70 = val_70 + ((mem[1152921512777691432]) << 32);
            val_70 = val_70 >> 32;
            val_52 = 0;
            goto label_94;
            label_51:
            var val_71 = val_1;
            val_71 = 0 + val_71;
            val_49 = 1152921504994385920;
            label_94:
            var val_72 = 0;
            goto label_37;
            label_29:
            val_49 = 1152921504994385920;
            goto label_32;
            label_37:
            val_53 = mem[1152921512777691441];
            val_54 = val_72;
            if(val_52 >= val_70)
            {
                goto label_11;
            }
            
            var val_3 = 1152921512777691408 + ((long)val_52 + 2);
            val_55 = null;
            var val_4 = ((output + (long)(int)((val_52 + 2))) + 32) + (((output + (long)(int)((val_52 + 2))) + 32) << 2);
            val_4 = 24 - val_4;
            uint val_5 = val_4 - UnityEngine.UI.Extensions.CLZF2.HLOG;
            val_5 = val_5 & 31;
            val_5 = 0 >> val_5;
            uint val_7 = val_5 & (UnityEngine.UI.Extensions.CLZF2.HSIZE - 1);
            System.Int64[] val_8 = UnityEngine.UI.Extensions.CLZF2.HashTable + ((((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 31)) & (UnityEngine.UI.Extensions.CLZF2.HSIZE -) << 3);
            System.Int64[] val_9 = UnityEngine.UI.Extensions.CLZF2.HashTable + ((((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 31)) & (UnityEngine.UI.Extensions.CLZF2.HSIZE -) << 3);
            (UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3.__unknownFiledOffset_20 = val_52;
            var val_11 = (val_52 - ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32)) - 1;
            if((val_11 >= UnityEngine.UI.Extensions.CLZF2.MAX_OFF) || (((val_52 + 4) >= (long)mem[1152921512777691432]) || (((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32) < 1)))
            {
                goto label_32;
            }
            
            val_57 = mem[1152921512777691432];
            if(((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32) >= val_57)
            {
                    val_57 = mem[1152921512777691432];
            }
            
            var val_13 = 1152921512777691408 + ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32);
            if(((output + (UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2 + 32) != mem[1152921512777691440])
            {
                goto label_29;
            }
            
            val_58 = mem[1152921512777691432];
            var val_14 = ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32) + 1;
            if(val_14 >= val_58)
            {
                    val_58 = mem[1152921512777691432];
            }
            
            var val_15 = 1152921512777691408 + val_14;
            var val_17 = 1152921512777691408 + ((long)val_52 + 1);
            if(((output + ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF + 32) != ((output + (long)(int)((val_52 + 1))) + 32))
            {
                goto label_29;
            }
            
            val_59 = mem[1152921512777691432];
            var val_18 = ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32) + 2;
            if(val_18 >= val_59)
            {
                    val_59 = mem[1152921512777691432];
            }
            
            var val_19 = 1152921512777691408 + val_18;
            val_60 = 1152921504994385920;
            if(((output + ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF + 32) != ((output + (long)(int)((val_52 + 2))) + 32))
            {
                goto label_32;
            }
            
            goto label_33;
            label_11:
            val_56 = val_53;
            if(val_52 == (long)mem[1152921512777691432])
            {
                goto label_34;
            }
            
            label_32:
            val_72 = val_54 + 1;
            val_52 = val_52 + 1;
            val_61 = null;
            val_62 = UnityEngine.UI.Extensions.CLZF2.MAX_LIT;
            if((long)val_72 != val_62)
            {
                goto label_37;
            }
            
            val_63 = val_71;
            val_64 =  + 1;
            if(( + val_64) >= ((long)??? + 24))
            {
                goto label_96;
            }
            
            val_1 = val_54;
            val_65 = UnityEngine.UI.Extensions.CLZF2.MAX_LIT;
            var val_22 = (???) + ;
            mem2[0] = val_65 + 255;
            var val_23 =  + 2;
            do
            {
                var val_25 = 1152921512777691408 + (0 + val_52);
                var val_26 = val_64 + 1;
                var val_27 = (???) + val_64;
                mem2[0] = (output + (0 + (val_52 + 1))) + 32;
            }
            while((0 + 1) != 0);
            
            goto label_51;
            label_33:
            val_66 = null;
            var val_73 = mem[1152921512777691432];
            val_1 = val_54;
            val_73 = val_73 - val_52;
            val_67 = val_73 - 2;
            val_66 = null;
            if(val_67 > UnityEngine.UI.Extensions.CLZF2.MAX_REF)
            {
                    val_67 = UnityEngine.UI.Extensions.CLZF2.MAX_REF;
            }
            
            var val_75 = 0;
            long val_74 = 0;
            val_74 = val_74 + val_23;
            val_68 = val_23;
            val_74 = val_74 + 4;
            if(val_74 >= ((long)??? + 24))
            {
                    return (int)val_75;
            }
            
            label_63:
            val_69 = val_75;
            val_75 = val_69 + 3;
            if(val_75 >= )
            {
                goto label_59;
            }
            
            var val_76 = val_75;
            val_70 = mem[1152921512777691432];
            val_76 = val_76 + ((UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 3 + 32);
            if(val_76 >= val_70)
            {
                    val_70 = mem[1152921512777691432];
            }
            
            var val_29 = 1152921512777691408 + val_76;
            var val_30 = val_52 + val_69;
            val_30 = val_30 + 3;
            var val_31 = 1152921512777691408 + (long)val_30;
            var val_32 = val_69 + 1;
            if(((output + ((val_69 + 3) + (UnityEngine.UI.Extensions.CLZF2.HashTable + (((0 >> (((24 - ((output + (long)(int)((val_52 + 2))) + 32 + ((output + (long)(int)((val_52 + 2))) + 32) << 2)) - UnityEngine.UI. + 32) == ((output + (long)(int)(((val_52 + val_69) + 3))) + 32))
            {
                goto label_63;
            }
            
            label_59:
            if(val_1 != 0)
            {
                    var val_33 = val_68 + 1;
                var val_77 = val_23;
                val_77 = (???) + val_77;
                mem2[0] = val_1 + 255;
                do
            {
                var val_36 = 1152921512777691408 + (0 + val_52);
                var val_37 = val_33 + 1;
                var val_38 = (???) + val_33;
                mem2[0] = (output + (0 + val_52)) + 32;
            }
            while((0 + 1) != 0);
            
                val_71 = 1152921504994385920;
                val_68 = val_33 + val_1;
                val_69 = val_69;
            }
            
            var val_41 = val_68 + 1;
            var val_42 = val_11 >> 8;
            if((val_69 + 1) <= 6)
            {
                    var val_44 = (???) + val_68;
                mem2[0] = 32 + val_42;
                val_72 = val_41;
            }
            else
            {
                    var val_46 = (???) + val_68;
                mem2[0] = val_42 + 224;
                var val_49 = (???) + val_41;
                val_69 = val_69;
                val_72 = val_68 + 2;
                mem2[0] = val_69 + 250;
            }
            
            var val_50 = val_52 + val_69;
            var val_51 = (???) + val_72;
            var val_52 = val_50 + 1;
            mem2[0] = val_11;
            val_73 = mem[1152921512777691432];
            if(val_52 >= val_73)
            {
                    val_73 = mem[1152921512777691432];
            }
            
            val_50 = 1152921512777691408 + val_52;
            var val_53 = val_52 + val_69;
            val_53 = val_53 + 2;
            if(val_53 >= val_73)
            {
                    val_73 = mem[1152921512777691432];
            }
            
            val_53 = 1152921512777691408 + (long)val_53;
            var val_56 = 1152921512777691408 + ((long)(val_52 + val_69) + 3);
            val_1 = (long)val_53;
            var val_57 = ((output + (long)(int)(((val_52 + val_69) + 3))) + 32) + (((output + (long)(int)(((val_52 + val_69) + 3))) + 32) << 2);
            val_57 = 24 - val_57;
            val_57 = val_57 - UnityEngine.UI.Extensions.CLZF2.HLOG;
            var val_78 = 0;
            val_57 = val_57 & 31;
            val_78 = val_78 >> val_57;
            val_78 = val_78 & (UnityEngine.UI.Extensions.CLZF2.HSIZE - 1);
            System.Int64[] val_59 = UnityEngine.UI.Extensions.CLZF2.HashTable + (((long)(int)(((0 >> (((24 - ((output + (long)(int)(((val_52 + val_69) + 3))) + 32 + ((output + (long)(int)(((val_52 + val_69) + 3))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 31)) & (UnityEngine.UI.Ex)) << 3);
            (UnityEngine.UI.Extensions.CLZF2.HashTable + ((long)(int)(((0 >> (((24 - ((output + (long)(int)(((val_52 + val_69) + 3))) + 32 + ((output + (long)(int)(((val_52 + val_69) + 3))) + 32) << 2)) - UnityEn.__unknownFiledOffset_20 = val_52;
            var val_79 = val_69;
            val_79 = val_52 + val_79;
            val_79 = val_79 + 4;
            val_79 = 1152921512777691408 + (long)val_79;
            var val_80 = val_72;
            var val_60 = ((output + (long)(int)(((val_52 + val_69) + 4))) + 32) + (((output + (long)(int)(((val_52 + val_69) + 4))) + 32) << 2);
            val_60 = 24 - val_60;
            val_80 = val_80 + 1;
            val_60 = val_60 - UnityEngine.UI.Extensions.CLZF2.HLOG;
            var val_81 = 0;
            val_60 = val_60 & 31;
            val_81 = val_81 >> val_60;
            val_81 = val_81 & (UnityEngine.UI.Extensions.CLZF2.HSIZE - 1);
            System.Int64[] val_63 = UnityEngine.UI.Extensions.CLZF2.HashTable + (((long)(int)(((0 >> (((24 - ((output + (long)(int)(((val_52 + val_69) + 4))) + 32 + ((output + (long)(int)(((val_52 + val_69) + 4))) + 32) << 2)) - UnityEngine.UI.Extensions.CLZF2.HLOG) & 31)) & (UnityEngine.UI.Ex)) << 3);
            (UnityEngine.UI.Extensions.CLZF2.HashTable + ((long)(int)(((0 >> (((24 - ((output + (long)(int)(((val_52 + val_69) + 4))) + 32 + ((output + (long)(int)(((val_52 + val_69) + 4))) + 32) << 2)) - UnityEn.__unknownFiledOffset_20 =  & 4294967295;
            goto label_94;
            label_34:
            if(val_54 == 0)
            {
                goto label_95;
            }
            
            long val_82 = 0;
            val_82 = val_82 + val_80;
            val_64 = val_80;
            val_82 = val_82 + 1;
            if(val_82 >= ((long)??? + 24))
            {
                goto label_96;
            }
            
            var val_65 = (???) + val_64;
            val_64 = val_54 + val_80;
            var val_66 = val_80 + 1;
            mem2[0] = val_54 + 255;
            do
            {
                var val_83 = ???;
                val_54 = 0;
                var val_68 = 1152921512777691408 + (val_54 + (long)mem[1152921512777691432]);
                val_52 = val_66;
                val_83 = val_83 + val_52;
                val_53 = val_66 + 1;
                mem2[0] = (output + (val_54 + (long)(int)(mem[1152921512777691432]))) + 32;
            }
            while((val_54 + 1) != 0);
            
            val_75 = val_64 + 1;
            return (int)val_75;
            label_95:
            val_75 = val_80;
            return (int)val_75;
            label_96:
            val_75 = 0;
            return (int)val_75;
        }
        public static int lzf_decompress(byte[] input, ref byte[] output)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_18 = 0;
            label_27:
            val_19 = 0 + 1;
            val_20 = 0;
            bool val_23 = mem[1152921512777885200];
            if(val_23 > true)
            {
                goto label_4;
            }
            
            bool val_1 = val_23 + val_18;
            val_1 = val_1 + 1;
            if(val_1 > (X2 + 24))
            {
                goto label_5;
            }
            
            var val_21 = ~val_23;
            do
            {
                var val_3 = 1152921512777885168 + val_19;
                val_20 = mem[(output + (0 + 1)) + 32];
                val_20 = (output + (0 + 1)) + 32;
                val_21 = val_18 + 1;
                val_19 = val_19 + 1;
                val_22 = val_18;
                var val_4 = X2 + val_22;
                val_21 = val_21 + 1;
                mem2[0] = val_20;
            }
            while(val_21 != 0);
            
            var val_22 = 0;
            val_22 = val_22 + val_23;
            val_23 = val_22 + 2;
            val_18 = (val_18 + 1) + val_23;
            goto label_11;
            label_4:
            val_22 = val_23 >> 5;
            if(val_22 == true)
            {
                    var val_6 = 1152921512777885168 + val_19;
                val_19 = 0 + 2;
                val_22 = ((output + (0 + 1)) + 32) + 7;
            }
            
            val_20 = val_19;
            var val_7 = val_18 + val_22;
            val_24 = 0;
            val_7 = val_7 + 2;
            if(val_7 > (X2 + 24))
            {
                    return (int)val_24;
            }
            
            var val_8 = 1152921512777885168 + val_20;
            var val_9 = val_18 - 1;
            val_8 = val_9 - val_8;
            val_20 = val_8 - ((output + (0 + 2)) + 32);
            if((val_20 & 2147483648) != 0)
            {
                    return (int)val_24;
            }
            
            val_25 = mem[X2 + 24];
            val_25 = X2 + 24;
            if(val_20 >= val_25)
            {
                    val_25 = mem[X2 + 24];
                val_25 = X2 + 24;
            }
            
            val_9 = X2 + (long)val_20;
            var val_10 = X2 + val_18;
            mem2[0] = (X2 + (long)(int)((((val_18 - 1) - (output + (0 + 2))) - (output + (0 + 2)) + 32))) + 32;
            var val_11 = val_20 + 1;
            val_26 = mem[X2 + 24];
            val_26 = X2 + 24;
            if(val_11 >= val_26)
            {
                    val_26 = mem[X2 + 24];
                val_26 = X2 + 24;
            }
            
            var val_13 = X2 + (long)val_11;
            var val_16 = X2 + (val_18 + 1);
            mem2[0] = (X2 + (long)(int)(((((val_18 - 1) - (output + (0 + 2))) - (output + (0 + 2)) + 32) + 1))) + 32;
            var val_24 = -((output + (0 + 2)) + 32);
            val_23 = val_24 - ((val_23 & 31) << 8);
            var val_18 = val_18 + 1;
            do
            {
                var val_19 = val_23 + val_18;
                val_27 = mem[X2 + 24];
                val_27 = X2 + 24;
                val_20 = val_18 + 1;
                if(val_19 >= val_27)
            {
                    val_27 = mem[X2 + 24];
                val_27 = X2 + 24;
            }
            
                val_24 = X2 + (long)val_19;
                val_21 = mem[(X2 + (long)(int)((((output + (0 + 2)) + 32 - ((mem[1152921512777885200] & 31)) << 8) + (val_18 + 1)))) + 32];
                val_21 = (X2 + (long)(int)((((output + (0 + 2)) + 32 - ((mem[1152921512777885200] & 31)) << 8) + (val_18 + 1)))) + 32;
                var val_20 = X2 + val_20;
                val_22 = val_22 - 1;
                val_18 = val_18 + 1;
                mem2[0] = val_21;
            }
            while(val_22 != 0);
            
            val_23 = val_19 + 1;
            val_18 = (val_22 + 2) + val_18;
            label_11:
            val_24 = val_18;
            if(val_23 < (long)mem[1152921512777885192])
            {
                goto label_27;
            }
            
            return (int)val_24;
            label_5:
            val_24 = 0;
            return (int)val_24;
        }
        private static CLZF2()
        {
            UnityEngine.UI.Extensions.CLZF2.HLOG = 14;
            UnityEngine.UI.Extensions.CLZF2.HSIZE = 16384;
            UnityEngine.UI.Extensions.CLZF2.MAX_LIT = 32;
            UnityEngine.UI.Extensions.CLZF2.MAX_OFF = 8192;
            UnityEngine.UI.Extensions.CLZF2.MAX_REF = 264;
            UnityEngine.UI.Extensions.CLZF2.HashTable = null;
        }
    
    }

}
