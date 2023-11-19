using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class EndlessAnalyticsEvent : CustomAnalyticsEvent
    {
        // Fields
        private const string user_key = "user_name";
        private const string stage_key = "stage";
        private const string level_key = "character_level";
        private const string class_key = "character_class";
        private const string hardcore_key = "isHardcore";
        private const string ruby_key = "ruby";
        private const string gold_key = "gold";
        private const string facebookid_key = "facebook_id";
        [UnityEngine.SerializeField]
        private bool sendRubyCount;
        [UnityEngine.SerializeField]
        private bool sendGoldCount;
        
        // Methods
        public EndlessAnalyticsEvent()
        {
        
        }
        public override System.Collections.Generic.IDictionary<string, object> GetParamaters()
        {
            var val_27;
            var val_28;
            var val_29;
            object val_30;
            var val_31;
            var val_32;
            object val_33;
            object val_34;
            var val_35;
            object val_36;
            var val_37;
            var val_38;
            val_27 = 0;
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_27;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
            val_27 = val_2;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(null == 0)
            {
                goto label_6;
            }
            
            val_28 = 0;
            if(SelectedCharacter == null)
            {
                goto label_11;
            }
            
            if(null == 0)
            {
                goto label_8;
            }
            
            val_30 = SelectedCharacter;
            if(val_30 != null)
            {
                goto label_9;
            }
            
            goto label_10;
            label_6:
            val_28 = 0;
            goto label_11;
            label_8:
            val_30 = 0;
            label_10:
            val_29 = 0;
            label_9:
            val_31 = 1152921504863608832;
            if(mem[282584257676929] == 0)
            {
                goto label_15;
            }
            
            var val_23 = mem[282584257676823];
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_14:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < mem[282584257676929])
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            val_29 = val_29 + (((mem[282584257676823] + 8)) << 4);
            val_29 = val_29 + 272;
            label_15:
            string val_5 = UnityEngine.SystemInfo.deviceModel;
            val_28 = System.String.Format(format:  0, arg0:  "{0}_{1}", arg1:  val_30);
            if(null == 0)
            {
                goto label_19;
            }
            
            val_33 = SelectedCharacter;
            if(val_33 != null)
            {
                goto label_20;
            }
            
            goto label_21;
            label_19:
            val_33 = 0;
            label_21:
            val_32 = 0;
            label_20:
            if(mem[282584257676929] == 0)
            {
                goto label_25;
            }
            
            var val_25 = mem[282584257676823];
            var val_26 = 0;
            val_25 = val_25 + 8;
            label_24:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25 + 16;
            if(val_26 < mem[282584257676929])
            {
                goto label_24;
            }
            
            goto label_25;
            label_23:
            var val_27 = val_25;
            val_27 = val_27 + 1;
            val_32 = val_32 + val_27;
            val_32 = val_32 + 272;
            label_25:
            val_34 = val_33;
            Add(key:  "stage", value:  val_33);
            if(this.sendRubyCount == false)
            {
                goto label_27;
            }
            
            if(null == 0)
            {
                goto label_29;
            }
            
            val_36 = SelectedCharacter;
            if(val_36 != null)
            {
                goto label_30;
            }
            
            goto label_31;
            label_29:
            val_36 = 0;
            label_31:
            val_35 = 0;
            label_30:
            if(mem[282584257676929] == 0)
            {
                goto label_35;
            }
            
            var val_28 = mem[282584257676823];
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_34:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_33;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < mem[282584257676929])
            {
                goto label_34;
            }
            
            goto label_35;
            label_33:
            var val_30 = val_28;
            val_30 = val_30 + 4;
            val_35 = val_35 + val_30;
            val_35 = val_35 + 272;
            label_35:
            val_34 = val_36;
            Add(key:  "ruby", value:  val_36);
            label_27:
            if(null == 0)
            {
                goto label_38;
            }
            
            val_38 = SelectedCharacter;
            if(val_38 != null)
            {
                goto label_39;
            }
            
            goto label_40;
            label_38:
            val_38 = 0;
            label_40:
            val_37 = 0;
            label_39:
            if(mem[282584257676929] == 0)
            {
                goto label_44;
            }
            
            var val_31 = mem[282584257676823];
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_43:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < mem[282584257676929])
            {
                goto label_43;
            }
            
            goto label_44;
            label_42:
            var val_33 = val_31;
            val_33 = val_33 + 8;
            val_37 = val_37 + val_33;
            val_37 = val_37 + 272;
            label_44:
            Add(key:  "isHardcore", value:  false);
            label_11:
            TzarGames.Endless.PlayerCharacter val_10 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 != val_10)
            {
                    val_31 = 1152921509093701200;
                Add(key:  "character_level", value:  val_10.Level);
                val_34 = val_10.PlayerTemplateInstance;
                if(0 != val_34)
            {
                    TzarGames.Endless.PlayerClass val_16 = val_10.PlayerTemplateInstance.Class;
                val_34 = val_16;
                Add(key:  "character_class", value:  val_16);
            }
            
                if(this.sendGoldCount != false)
            {
                    Add(key:  "gold", value:  val_10.Gold);
            }
            
            }
            
            TzarGames.Endless.SocialSystem val_18 = TzarGames.Endless.SocialSystem.Instance;
            if(0 != val_18)
            {
                    if(val_18.IsAuthenticated != false)
            {
                    val_28 = val_18.GetUserName();
            }
            
            }
            
            bool val_22 = System.String.IsNullOrEmpty(value:  0);
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_27;
        }
    
    }

}
