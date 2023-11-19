using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class EndlessCharacterData : ICharacterInfo
    {
        // Fields
        [UnityEngine.SerializeField]
        private string name;
        [UnityEngine.SerializeField]
        private bool isTutorialCompleted;
        [UnityEngine.SerializeField]
        private uint currentPromoStage;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt currentStage;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt maxStage;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredULong ruby;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool isHardcore;
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool isDead;
        [UnityEngine.SerializeField]
        private TzarGames.Common.SerializableData data;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.CharacterStatistics statistics;
        public TzarGames.Endless.EndlessHeroData HeroData;
        
        // Properties
        public TzarGames.Endless.CharacterStatistics Statistics { get; }
        public TzarGames.Common.SerializableData Data { get; }
        public ulong Ruby { get; }
        public string Name { get; }
        public bool IsTutorialCompleted { get; set; }
        public uint CurrentStage { get; set; }
        public uint CurrentPromoStage { get; set; }
        public uint MaxStage { get; }
        public bool IsHardcore { get; }
        public bool Dead { get; set; }
        
        // Methods
        public EndlessCharacterData(string characterName, uint stage, bool hardcore, TzarGames.Endless.EndlessHeroData heroData)
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_3;
            var val_5;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_6;
            var val_8;
            var val_9;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_10;
            bool val_17;
            var val_19;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921510658158592] = val_2;
            this.currentStage = val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_4 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921510658158612] = val_5;
            this.maxStage = val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_7 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            mem[1152921510658158648] = val_8;
            mem[1152921510658158632] = val_9;
            this.ruby = val_10;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_11 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isHardcore = val_11;
            mem[1152921510658158664] = val_11.inited;
            mem[1152921510658158665] = val_11.fakeValue;
            mem[1152921510658158666] = val_11.fakeValueActive;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_12 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isDead = val_12;
            mem[1152921510658158676] = val_12.inited;
            mem[1152921510658158677] = val_12.fakeValue;
            mem[1152921510658158678] = val_12.fakeValueActive;
            this.data = new TzarGames.Common.SerializableData();
            this.statistics = new System.Object();
            val_15 = new System.Object();
            this.HeroData = val_15;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_16 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            bool val_18 = hardcore;
            fakeValueActive = val_17;
            mem2[0] = val_19;
            this.name = characterName;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            mem[1152921510658158656] = val_20.currentCryptoKey;
            mem[1152921510658158664] = val_20.inited;
            mem[1152921510658158665] = val_20.fakeValue;
            mem[1152921510658158666] = val_20.fakeValueActive;
        }
        public TzarGames.Endless.CharacterStatistics get_Statistics()
        {
            return (TzarGames.Endless.CharacterStatistics)this.statistics;
        }
        public TzarGames.Common.SerializableData get_Data()
        {
            return (TzarGames.Common.SerializableData)this.data;
        }
        public TzarGames.Endless.IHeroData GetHeroData()
        {
            return (TzarGames.Endless.IHeroData)this.HeroData;
        }
        public ulong get_Ruby()
        {
            return (ulong)CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredULong() {inited = false, fakeValueActive = false});
        }
        public void AddRuby(int rubyAdd)
        {
            bool val_4;
            bool val_5;
            var val_6;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_11;
            if((rubyAdd & 2147483648) == 0)
            {
                    ulong val_2 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredULong() {inited = false, fakeValueActive = false})) + (rubyAdd << );
                CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_3 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
                fakeValueActive = val_4;
                inited = val_5;
                mem2[0] = val_6;
                return;
            }
            
            val_11 = this.ruby;
            ulong val_9 = (CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredULong() {inited = false, fakeValueActive = false})) - ((UnityEngine.Mathf.Abs(value:  0)) << );
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_10 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            fakeValueActive = val_4;
            inited = val_5;
            mem2[0] = val_6;
        }
        public string get_Name()
        {
            return (string)this.name;
        }
        public bool get_IsTutorialCompleted()
        {
            return (bool)this.isTutorialCompleted;
        }
        public void set_IsTutorialCompleted(bool value)
        {
            this.isTutorialCompleted = true;
        }
        public uint get_CurrentStage()
        {
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
        }
        public void set_CurrentStage(uint value)
        {
            var val_2;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            mem[1152921510659339792] = val_2;
            this.currentStage = val_3;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false})) <= (CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false})))
            {
                    return;
            }
            
            fakeValueActive = this.currentStage.fakeValueActive;
            mem2[0] = this.currentStage.currentCryptoKey;
        }
        public uint get_CurrentPromoStage()
        {
            return (uint)this.currentPromoStage;
        }
        public void set_CurrentPromoStage(uint value)
        {
            this.currentPromoStage = value;
        }
        public uint get_MaxStage()
        {
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
        }
        public bool get_IsHardcore()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isHardcore, fakeValue = this.isHardcore, fakeValueActive = this.isHardcore});
        }
        public bool get_Dead()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isDead, fakeValue = this.isDead, fakeValueActive = this.isDead});
        }
        public void set_Dead(bool value)
        {
            value = value;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isDead = val_1;
            mem[1152921510660011876] = val_1.inited;
            mem[1152921510660011877] = val_1.fakeValue;
            mem[1152921510660011878] = val_1.fakeValueActive;
        }
    
    }

}
