using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class EndlessHeroData : IHeroData
    {
        // Fields
        public bool IsInitialized;
        public TzarGames.Endless.PlayerClass Class;
        public bool IsLevelRestrictionDisabled;
        public string ArmorSetId;
        public string WeaponId;
        public string SecondWeaponId;
        public string ShieldId;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt XP;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredULong Gold;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredLong ConsumedLevelXpPoints;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt AdditionalXpPoints;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt DamageUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt DefenceUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt SpeedUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt AttackSpeedUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt HpUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt HpRegenUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt CritChanceUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt CritMultiplierUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt BlockChanceUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt InfluenceResistanceUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredInt CritResistanceUpgradeLevel;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredBool Net_IsDead;
        public CodeStage.AntiCheat.ObscuredTypes.ObscuredString Net_PlayerName;
        public UnityEngine.Vector3 Net_Position;
        public float Net_Yaw;
        public TzarGames.Common.SerializableData Data;
        public System.Collections.Generic.List<TzarGames.Endless.EndlessHeroData.SkillUpgradeInfo> SkillUpgrades;
        public System.Collections.Generic.List<TzarGames.Endless.EndlessBagSerializationInfo> InventoryBags;
        
        // Methods
        public EndlessHeroData(TzarGames.Endless.PlayerClass classType, string armorSetId, string weaponId, string secondWeaponId, uint xp, bool levelRestrictionDisabled)
        {
            var val_2;
            var val_3;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_4;
            bool val_9;
            var val_10;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredULong val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredULong.op_Implicit(value:  0);
            mem[1152921510660722728] = val_2;
            mem[1152921510660722712] = val_3;
            this.Gold = val_4;
            this.SkillUpgrades = new System.Collections.Generic.List<SkillUpgradeInfo>();
            this.InventoryBags = new System.Collections.Generic.List<TzarGames.Endless.EndlessBagSerializationInfo>();
            val_7 = new System.Object();
            this.Class = classType;
            this.ArmorSetId = armorSetId;
            this.WeaponId = val_7;
            this.SecondWeaponId = secondWeaponId;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt val_8 = CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  0);
            fakeValueActive = val_9;
            mem2[0] = val_10;
            this.IsLevelRestrictionDisabled = levelRestrictionDisabled;
        }
        public static TzarGames.Endless.EndlessHeroData CreateDefault(TzarGames.Endless.PlayerClass classType, TzarGames.Endless.EndlessPlayerCharacterTemplate template)
        {
            var val_15;
            string val_16;
            TzarGames.GameFramework.ItemInstance val_1 = new TzarGames.GameFramework.ItemInstance();
            GenerateID();
            TzarGames.GameFramework.ItemInstance val_2 = new TzarGames.GameFramework.ItemInstance();
            GenerateID();
            val_15 = 0;
            if(template == 1)
            {
                    TzarGames.GameFramework.ItemInstance val_3 = null;
                val_15 = val_3;
                val_3 = new TzarGames.GameFramework.ItemInstance();
                GenerateID();
            }
            
            val_16 = 0;
            if(null != 0)
            {
                    val_16 = GetInstanceID();
            }
            
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_10 = 1;
            typeof(TzarGames.Endless.EndlessItemInstanceSerializationInfo).__il2cppRuntimeField_10 = X2 + 336;
            typeof(TzarGames.Endless.EndlessItemInstanceSerializationInfo).__il2cppRuntimeField_18 = GetInstanceID();
            Add(item:  new TzarGames.GameFramework.NonConsumableItemInstanceSerializationInfo());
            typeof(TzarGames.Endless.EndlessItemInstanceSerializationInfo).__il2cppRuntimeField_10 = X2 + 344;
            typeof(TzarGames.Endless.EndlessItemInstanceSerializationInfo).__il2cppRuntimeField_18 = GetInstanceID();
            Add(item:  new TzarGames.GameFramework.NonConsumableItemInstanceSerializationInfo());
            if(null != 0)
            {
                    typeof(TzarGames.Endless.EndlessItemInstanceSerializationInfo).__il2cppRuntimeField_10 = X2 + 344;
                typeof(TzarGames.Endless.EndlessItemInstanceSerializationInfo).__il2cppRuntimeField_18 = GetInstanceID();
                Add(item:  new TzarGames.GameFramework.NonConsumableItemInstanceSerializationInfo());
            }
            
            typeof(TzarGames.Endless.EndlessHeroData).__il2cppRuntimeField_1D0.Add(item:  new TzarGames.Endless.EndlessBagSerializationInfo(bagName:  "Default"));
            return (TzarGames.Endless.EndlessHeroData)new TzarGames.Endless.EndlessHeroData(classType:  template, armorSetId:  GetInstanceID(), weaponId:  GetInstanceID(), secondWeaponId:  val_16, xp:  0, levelRestrictionDisabled:  false);
        }
        public static TzarGames.Endless.EndlessHeroData GetDataFromBytes(byte[] bytes)
        {
            string val_1 = TzarGames.Common.Utils.GetStringFromBytes(bytes:  0);
            string val_2 = TzarGames.SaveManager.GetDecryptedString(encrypted:  0);
            return UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
        }
        public static byte[] GetBytesFromData(TzarGames.Endless.EndlessHeroData data)
        {
            string val_1 = UnityEngine.JsonUtility.ToJson(obj:  0);
            string val_2 = TzarGames.SaveManager.GetEncryptedString(original:  0);
            return TzarGames.Common.Utils.GetBytesFromString(str:  0);
        }
        public uint GetXP()
        {
            return (uint)CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt() {inited = true, fakeValue = 268435457, fakeValueActive = false});
        }
        public TzarGames.Endless.PlayerClass GetPlayerClass()
        {
            return (TzarGames.Endless.PlayerClass)this.Class;
        }
    
    }

}
