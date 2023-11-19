using UnityEngine;

namespace CodeStage.AntiCheat.Utils
{
    internal class xxHash
    {
        // Fields
        private const uint PRIME32_1 = 2654435761;
        private const uint PRIME32_2 = 2246822519;
        private const uint PRIME32_3 = 3266489917;
        private const uint PRIME32_4 = 668265263;
        private const uint PRIME32_5 = 374761393;
        
        // Methods
        public xxHash()
        {
        
        }
        public static uint CalculateHash(byte[] buf, int len, uint seed)
        {
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_45;
            val_35 = 31153;
            if()
            {
                    val_36 = 0;
                val_37 = W3 + 374761393;
            }
            else
            {
                    var val_4 = W3 + 1640531535;
                do
            {
                val_38 = mem[len + 24];
                val_38 = len + 24;
                if(0 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_6 = len + 0;
                var val_8 = 0 + 1;
                if(val_8 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_9 = len + ((long)0 + 1);
                var val_11 = val_8 + 1;
                if(val_11 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_12 = len + ((long)0 + 2);
                var val_14 = val_11 + 1;
                if(val_14 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_15 = len + ((long)0 + 3);
                var val_61 = W3 + 606290984;
                val_14 = val_14 + 1;
                val_61 = val_61 + (((len + 0) + 32) * 2246822519);
                val_61 = val_61 >> 19;
                val_35 = 31153;
                val_61 = val_61 * 2654435761;
                if(val_14 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_17 = len + ((long)0 + 4);
                var val_19 = val_14 + 1;
                if(val_19 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_20 = len + ((long)0 + 5);
                val_19 = val_19 + 1;
                if(val_19 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_22 = len + ((long)0 + 6);
                var val_24 = val_19 + 1;
                if(val_24 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_25 = len + ((long)0 + 7);
                var val_26 = (W3 + 2246822519) + (((len + (long)(int)((0 + 4))) + 32) * 2246822519);
                val_26 = val_26 >> 19;
                val_19 = val_24 + 1;
                val_26 = val_26 * 2654435761;
                if(val_19 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_28 = len + ((long)0 + 8);
                var val_63 = (len + (long)(int)((0 + 8))) + 32;
                val_19 = val_19 + 1;
                if(val_19 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_30 = len + ((long)0 + 9);
                val_19 = val_19 + 1;
                if(val_19 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_32 = len + ((long)0 + 10);
                var val_34 = val_19 + 1;
                if(val_34 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_35 = len + ((long)0 + 11);
                var val_62 = ???;
                val_39 = 51831;
                val_62 = val_62 + (val_63 * 2246822519);
                val_63 = val_62 >> 19;
                var val_37 = val_34 + 1;
                val_62 = val_63 * 2654435761;
                if(val_37 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_38 = len + ((long)0 + 12);
                val_37 = val_37 + 1;
                if(val_37 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_40 = len + ((long)0 + 13);
                val_37 = val_37 + 1;
                if(val_37 >= val_38)
            {
                    val_38 = mem[len + 24];
                val_38 = len + 24;
            }
            
                int val_42 = len + ((long)0 + 14);
                val_37 = val_37 + 1;
                int val_43 = len + ((long)0 + 15);
                var val_64 = val_4;
                val_64 = val_64 + (((len + (long)(int)((0 + 12))) + 32) * 2246822519);
                val_64 = val_64 >> 19;
                val_4 = val_64 * 2654435761;
            }
            while((val_37 + 1) <= (seed - 16));
            
                val_64 = val_64 * 3871604736;
                var val_45 = val_61 * 1013904226;
                val_45 = (val_26 * 465361024) + val_45;
                val_45 = val_45 + (val_63 * 2006650880);
                val_36 = 0 + 16;
                val_37 = val_45 + val_64;
            }
            
            val_41 = val_37 + seed;
            val_42 = seed - 4;
            if(val_36 > val_42)
            {
                    val_43 = val_36;
                if(val_43 < seed)
            {
                    val_40 = (len + (val_43 << )) + 32;
                val_45 = 51831;
                val_42 = 26545;
                do
            {
                var val_65 = val_40;
                val_43 = val_43 + 1;
                val_65 = val_41 + (val_65 * 374761393);
                val_65 = val_65 >> 21;
                val_41 = val_65 * 2654435761;
            }
            while(seed != val_43);
            
            }
            else
            {
                    val_45 = 51831;
            }
            
                var val_66 = 0;
                val_66 = val_66 * 2246822519;
                return 0;
            }
        
        }
    
    }

}
