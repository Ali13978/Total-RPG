using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
    internal class BitconverterExt
    {
        // Methods
        public BitconverterExt()
        {
        
        }
        public static byte[] GetBytes(decimal dec)
        {
            var val_4;
            System.Collections.Generic.List<System.Byte> val_2 = new System.Collections.Generic.List<System.Byte>();
            val_4 = 0;
            goto label_3;
            label_10:
            AddRange(collection:  34816000);
            val_4 = 1;
            label_3:
            if(val_4 >= val_1.Length)
            {
                goto label_5;
            }
            
            int val_4 = System.Decimal.GetBits(d:  new System.Decimal() {lo = dec.lo, mid = dec.mid})[1];
            System.Byte[] val_3 = System.BitConverter.GetBytes(value:  0);
            if(null != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_5:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        public static decimal ToDecimal(byte[] bytes)
        {
            if((X1 + 24) == 16)
            {
                    var val_6 = 0;
                do
            {
                var val_3 = (val_6 < 0) ? (val_6 + 3) : (val_6);
                val_3 = val_3 >> 2;
                var val_4 = null + (((long)(int)((0 < 0x0 ? (0 + 3) : 0 >> 2))) << 2);
                val_6 = val_6 + 4;
                mem2[0] = System.BitConverter.ToInt32(value:  0, startIndex:  X1);
            }
            while(val_6 < 16);
            
                return new System.Decimal();
            }
            
            System.Exception val_5 = new System.Exception(message:  "[ACTk] A decimal must be created from exactly 16 bytes");
            public static System.Decimal CodeStage.AntiCheat.ObscuredTypes.BitconverterExt::ToDecimal(byte[] bytes).__il2cppRuntimeField_FFFFFFFFFFFFFFFF = null;
            public static System.Decimal CodeStage.AntiCheat.ObscuredTypes.BitconverterExt::ToDecimal(byte[] bytes).__il2cppRuntimeField_4 = typeof(System.Exception).__il2cppRuntimeField_4;
            public static System.Decimal CodeStage.AntiCheat.ObscuredTypes.BitconverterExt::ToDecimal(byte[] bytes).__il2cppRuntimeField_8 = System.Exception.__il2cppRuntimeField_gc_desc;
            public static System.Decimal CodeStage.AntiCheat.ObscuredTypes.BitconverterExt::ToDecimal(byte[] bytes).__il2cppRuntimeField_C = typeof(System.Exception).__il2cppRuntimeField_9;
            public static System.Decimal CodeStage.AntiCheat.ObscuredTypes.BitconverterExt::ToDecimal(byte[] bytes).__il2cppRuntimeField_10 = typeof(System.Exception).__il2cppRuntimeField_A;
            return new System.Decimal() {flags = 3035136, hi = 268435456, lo = 1190062512, mid = 268435457};
        }
    
    }

}
