using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class ModificatorGroup
    {
        // Fields
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> DamageModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> HitPointsModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> HitPointsRegenModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> AttackSpeedModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> WalkingSpeedModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> DefenceModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> XpRateModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> CritChanceModificators;
        public System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> CritMultipliierModificators;
        
        // Methods
        public ModificatorGroup()
        {
        
        }
        public void ApplyToTemplate(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            var val_19;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_20;
            var val_21;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_22;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_23;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_24;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_25;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_26;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_27;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_28;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_29;
            val_20 = this.DamageModificators;
            if(val_20 == null)
            {
                goto label_4;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_2;
            label_8:
            X23.AddModificator(modificator:  val_20);
            val_20 = this.DamageModificators;
            val_19 = 1;
            label_2:
            if(val_19 >= val_20.Count)
            {
                goto label_4;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_2 = this.DamageModificators.Item[1];
            if(X23 != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_4:
            val_22 = this.HitPointsModificators;
            if(val_22 == null)
            {
                goto label_12;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_10;
            label_16:
            X23.AddModificator(modificator:  val_22);
            val_22 = this.HitPointsModificators;
            val_19 = 1;
            label_10:
            if(val_19 >= val_22.Count)
            {
                goto label_12;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_4 = this.HitPointsModificators.Item[1];
            if(X23 != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_12:
            val_23 = this.HitPointsRegenModificators;
            if(val_23 == null)
            {
                goto label_20;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_18;
            label_24:
            X23.AddModificator(modificator:  val_23);
            val_23 = this.HitPointsRegenModificators;
            val_19 = 1;
            label_18:
            if(val_19 >= val_23.Count)
            {
                goto label_20;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_6 = this.HitPointsRegenModificators.Item[1];
            if(X23 != 0)
            {
                goto label_24;
            }
            
            goto label_24;
            label_20:
            val_24 = this.AttackSpeedModificators;
            if(val_24 == null)
            {
                goto label_28;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_26;
            label_32:
            X23.AddModificator(modificator:  val_24);
            val_24 = this.AttackSpeedModificators;
            val_19 = 1;
            label_26:
            if(val_19 >= val_24.Count)
            {
                goto label_28;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_8 = this.AttackSpeedModificators.Item[1];
            if(X23 != 0)
            {
                goto label_32;
            }
            
            goto label_32;
            label_28:
            val_25 = this.WalkingSpeedModificators;
            if(val_25 == null)
            {
                goto label_36;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_34;
            label_40:
            X23.AddModificator(modificator:  val_25);
            val_25 = this.WalkingSpeedModificators;
            val_19 = 1;
            label_34:
            if(val_19 >= val_25.Count)
            {
                goto label_36;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_10 = this.WalkingSpeedModificators.Item[1];
            if(X23 != 0)
            {
                goto label_40;
            }
            
            goto label_40;
            label_36:
            val_26 = this.DefenceModificators;
            if(val_26 == null)
            {
                goto label_44;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_42;
            label_48:
            X23.AddModificator(modificator:  val_26);
            val_26 = this.DefenceModificators;
            val_19 = 1;
            label_42:
            if(val_19 >= val_26.Count)
            {
                goto label_44;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_12 = this.DefenceModificators.Item[1];
            if(X23 != 0)
            {
                goto label_48;
            }
            
            goto label_48;
            label_44:
            val_27 = this.XpRateModificators;
            if(val_27 == null)
            {
                goto label_52;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_50;
            label_56:
            X23.AddModificator(modificator:  val_27);
            val_27 = this.XpRateModificators;
            val_19 = 1;
            label_50:
            if(val_19 >= val_27.Count)
            {
                goto label_52;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_14 = this.XpRateModificators.Item[1];
            if(X23 != 0)
            {
                goto label_56;
            }
            
            goto label_56;
            label_52:
            val_28 = this.CritChanceModificators;
            if(val_28 == null)
            {
                goto label_60;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_58;
            label_64:
            X23.AddModificator(modificator:  val_28);
            val_28 = this.CritChanceModificators;
            val_19 = 1;
            label_58:
            if(val_19 >= val_28.Count)
            {
                goto label_60;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_16 = this.CritChanceModificators.Item[1];
            if(X23 != 0)
            {
                goto label_64;
            }
            
            goto label_64;
            label_60:
            val_29 = this.CritMultipliierModificators;
            if(val_29 == null)
            {
                    return;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_66;
            label_72:
            X23.AddModificator(modificator:  val_29);
            val_29 = this.CritMultipliierModificators;
            val_19 = 1;
            label_66:
            if(val_19 >= val_29.Count)
            {
                    return;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_18 = this.CritMultipliierModificators.Item[1];
            if(X23 != 0)
            {
                goto label_72;
            }
            
            goto label_72;
        }
        public void RemoveFromTemplate(TzarGames.TzarHero.TH_CharacterTemplate template)
        {
            var val_19;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_20;
            var val_21;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_22;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_23;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_24;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_25;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_26;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_27;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_28;
            System.Collections.Generic.List<TzarGames.GameFramework.CharacteristicModificator> val_29;
            val_20 = this.DamageModificators;
            if(val_20 == null)
            {
                goto label_4;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_2;
            label_8:
            X23.UnregisterModificator(modificator:  val_20);
            val_20 = this.DamageModificators;
            val_19 = 1;
            label_2:
            if(val_19 >= val_20.Count)
            {
                goto label_4;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_2 = this.DamageModificators.Item[1];
            if(X23 != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_4:
            val_22 = this.HitPointsModificators;
            if(val_22 == null)
            {
                goto label_12;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_10;
            label_16:
            X23.UnregisterModificator(modificator:  val_22);
            val_22 = this.HitPointsModificators;
            val_19 = 1;
            label_10:
            if(val_19 >= val_22.Count)
            {
                goto label_12;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_4 = this.HitPointsModificators.Item[1];
            if(X23 != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_12:
            val_23 = this.HitPointsRegenModificators;
            if(val_23 == null)
            {
                goto label_20;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_18;
            label_24:
            X23.UnregisterModificator(modificator:  val_23);
            val_23 = this.HitPointsRegenModificators;
            val_19 = 1;
            label_18:
            if(val_19 >= val_23.Count)
            {
                goto label_20;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_6 = this.HitPointsRegenModificators.Item[1];
            if(X23 != 0)
            {
                goto label_24;
            }
            
            goto label_24;
            label_20:
            val_24 = this.AttackSpeedModificators;
            if(val_24 == null)
            {
                goto label_28;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_26;
            label_32:
            X23.UnregisterModificator(modificator:  val_24);
            val_24 = this.AttackSpeedModificators;
            val_19 = 1;
            label_26:
            if(val_19 >= val_24.Count)
            {
                goto label_28;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_8 = this.AttackSpeedModificators.Item[1];
            if(X23 != 0)
            {
                goto label_32;
            }
            
            goto label_32;
            label_28:
            val_25 = this.WalkingSpeedModificators;
            if(val_25 == null)
            {
                goto label_36;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_34;
            label_40:
            X23.UnregisterModificator(modificator:  val_25);
            val_25 = this.WalkingSpeedModificators;
            val_19 = 1;
            label_34:
            if(val_19 >= val_25.Count)
            {
                goto label_36;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_10 = this.WalkingSpeedModificators.Item[1];
            if(X23 != 0)
            {
                goto label_40;
            }
            
            goto label_40;
            label_36:
            val_26 = this.DefenceModificators;
            if(val_26 == null)
            {
                goto label_44;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_42;
            label_48:
            X23.UnregisterModificator(modificator:  val_26);
            val_26 = this.DefenceModificators;
            val_19 = 1;
            label_42:
            if(val_19 >= val_26.Count)
            {
                goto label_44;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_12 = this.DefenceModificators.Item[1];
            if(X23 != 0)
            {
                goto label_48;
            }
            
            goto label_48;
            label_44:
            val_27 = this.XpRateModificators;
            if(val_27 == null)
            {
                goto label_52;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_50;
            label_56:
            X23.UnregisterModificator(modificator:  val_27);
            val_27 = this.XpRateModificators;
            val_19 = 1;
            label_50:
            if(val_19 >= val_27.Count)
            {
                goto label_52;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_14 = this.XpRateModificators.Item[1];
            if(X23 != 0)
            {
                goto label_56;
            }
            
            goto label_56;
            label_52:
            val_28 = this.CritChanceModificators;
            if(val_28 == null)
            {
                goto label_60;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_58;
            label_64:
            X23.UnregisterModificator(modificator:  val_28);
            val_28 = this.CritChanceModificators;
            val_19 = 1;
            label_58:
            if(val_19 >= val_28.Count)
            {
                goto label_60;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_16 = this.CritChanceModificators.Item[1];
            if(X23 != 0)
            {
                goto label_64;
            }
            
            goto label_64;
            label_60:
            val_29 = this.CritMultipliierModificators;
            if(val_29 == null)
            {
                    return;
            }
            
            val_21 = 1152921510945706944;
            val_19 = 0;
            goto label_66;
            label_72:
            X23.UnregisterModificator(modificator:  val_29);
            val_29 = this.CritMultipliierModificators;
            val_19 = 1;
            label_66:
            if(val_19 >= val_29.Count)
            {
                    return;
            }
            
            TzarGames.GameFramework.CharacteristicModificator val_18 = this.CritMultipliierModificators.Item[1];
            if(X23 != 0)
            {
                goto label_72;
            }
            
            goto label_72;
        }
    
    }

}
