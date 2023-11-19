using UnityEngine;

namespace TzarGames.Common
{
    public class PrimeSearch
    {
        // Fields
        private int skip;
        private int currentPosition;
        private int maxElements;
        private int currentPrimeNum;
        private uint currentPriveValue;
        private int searches;
        private static int[] prime_array;
        
        // Properties
        private int currentPrimeValue { get; }
        
        // Methods
        public PrimeSearch(int elements)
        {
            this.init(elements:  elements, setSeed:  false, seed:  0);
        }
        public PrimeSearch(int elements, int seed)
        {
            this.init(elements:  elements, setSeed:  true, seed:  seed);
        }
        public bool Done()
        {
            return (bool)(this.searches == this.currentPrimeValue) ? 1 : 0;
        }
        public void Restart()
        {
            this.currentPosition = 0;
            this.searches = 0;
        }
        private void init(int elements, bool setSeed, int seed = 0)
        {
            this.maxElements = elements;
            State val_1 = UnityEngine.Random.state;
            if(setSeed != false)
            {
                    UnityEngine.Random.InitState(seed:  0);
            }
            
            int val_2 = UnityEngine.Random.Range(min:  0, max:  0);
            var val_15 = (long)val_2;
            val_15 = val_15 * 1321528399;
            val_15 = val_15 >> 63;
            val_15 = val_15 + ((val_15 >> 32) >> 2);
            val_15 = val_2 - (val_15 * 13);
            int val_5 = UnityEngine.Random.Range(min:  0, max:  0);
            var val_16 = (long)val_5;
            val_16 = val_16 * 1840653459;
            val_16 = val_16 >> 32;
            val_16 = val_16 + val_5;
            int val_6 = val_16 >> 2;
            val_16 = val_6 + (val_16 >> 31);
            val_6 = val_16 << 3;
            val_16 = val_6 - val_16;
            val_16 = val_5 - val_16;
            int val_8 = UnityEngine.Random.Range(min:  0, max:  0);
            var val_17 = (long)val_8;
            val_17 = val_17 * 1717986919;
            val_17 = val_17 >> 33;
            val_17 = val_17 + (val_17 >> 63);
            val_17 = val_17 + (val_17 << 2);
            val_17 = val_8 - val_17;
            if(setSeed != false)
            {
                    UnityEngine.Random.state = new State() {s2 = val_1.s0, s3 = val_1.s1};
            }
            
            int val_18 = this.maxElements;
            this.searches = 0;
            val_18 = (val_17 + 1) + (((val_16 + 1) + (val_18 * (val_15 + 1))) * val_18);
            val_18 = val_18 & 1073741823;
            this.skip = val_18;
            this.currentPosition = 0;
            this.currentPrimeNum = 0;
            goto label_2;
            label_3:
            val_18 = val_18 >> 32;
            val_18 = val_18 + 1;
            this.currentPrimeNum = val_18;
            label_2:
            if(this.currentPrimeValue < this.maxElements)
            {
                goto label_3;
            }
            
            int val_13 = this.currentPrimeValue;
            int val_14 = this.skip / val_13;
            val_14 = this.skip - (val_14 * val_13);
            if(val_14 != 0)
            {
                    return;
            }
            
            int val_19 = this.skip;
            val_19 = val_19 + 1;
            this.skip = val_19;
        }
        public int GetNext(bool restart = False)
        {
            int val_6;
            int val_7;
            if(restart != false)
            {
                    val_6 = 0;
                this.currentPosition = 0;
                this.searches = 0;
            }
            else
            {
                    val_6 = this.searches;
            }
            
            if(val_6 == this.currentPrimeValue)
            {
                    val_7 = 0;
                return val_7;
            }
            
            do
            {
                int val_3 = this.skip + this.currentPosition;
                int val_4 = this.currentPrimeValue;
                int val_6 = this.searches;
                val_7 = val_3 - ((val_3 / val_4) * val_4);
                val_6 = val_6 + 1;
                this.searches = val_6;
            }
            while(val_7 >= this.maxElements);
            
            this.currentPosition = val_7;
            return val_7;
        }
        private int get_currentPrimeValue()
        {
            null = null;
            System.Int32[] val_1 = TzarGames.Common.PrimeSearch.prime_array + ((this.currentPrimeNum) << 2);
            return (int)(TzarGames.Common.PrimeSearch.prime_array + (this.currentPrimeNum) << 2) + 32;
        }
        [TzarGames.Common.ConsoleCommand]
        private static void prime_search_test()
        {
            object val_1 = new System.Object();
            init(elements:  System.Single[].__il2cppRuntimeField_namespaze, setSeed:  false, seed:  0);
            var val_7 = 0;
            goto label_2;
            label_9:
            UnityEngine.Debug.Log(message:  0);
            label_2:
            val_7 = val_7 + 1;
            int val_2 = currentPrimeValue;
            typeof(TzarGames.Common.PrimeSearch).__il2cppRuntimeField_14 = 0;
            typeof(TzarGames.Common.PrimeSearch).__il2cppRuntimeField_24 = 0;
            int val_3 = GetNext(restart:  false);
            goto label_9;
            label_19:
            UnityEngine.Debug.Log(message:  0);
             =  + 1;
            int val_5 = currentPrimeValue;
            typeof(TzarGames.Common.PrimeSearch).__il2cppRuntimeField_14 = 0;
            typeof(TzarGames.Common.PrimeSearch).__il2cppRuntimeField_24 = 0;
            int val_6 = GetNext(restart:  false);
            goto label_19;
        }
        private static PrimeSearch()
        {
            TzarGames.Common.PrimeSearch.prime_array = null;
        }
    
    }

}
