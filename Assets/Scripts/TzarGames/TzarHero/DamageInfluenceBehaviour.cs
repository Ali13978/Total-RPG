using UnityEngine;

namespace TzarGames.TzarHero
{
    public class DamageInfluenceBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.DamageInfluenceBehaviour.DamageType damageType;
        [UnityEngine.SerializeField]
        private float damage;
        [UnityEngine.SerializeField]
        private bool ignoreDefence;
        [UnityEngine.SerializeField]
        private float damageInterval;
        private System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, TzarGames.TzarHero.Influences.DamageInfluence> appliedInfluences;
        
        // Methods
        public DamageInfluenceBehaviour()
        {
            this.damage = 10f;
            this.damageInterval = 0.5f;
            this.appliedInfluences = new System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, TzarGames.TzarHero.Influences.DamageInfluence>();
        }
        public void ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, TzarGames.TzarHero.Influences.DamageInfluence> val_8;
            float val_9;
            if(this.enabled == false)
            {
                    return;
            }
            
            val_8 = this.appliedInfluences;
            if((val_8.ContainsKey(key:  character)) != false)
            {
                    return;
            }
            
            if(this.damageType == 1)
            {
                    float val_5 = character.TemplateInstance.HitPoints;
                val_5 = val_5 * 0.01f;
                val_9 = val_5 * this.damage;
            }
            else
            {
                    val_9 = this.damage;
            }
            
            object val_6 = new System.Object();
            typeof(TzarGames.TzarHero.Influences.DamageInfluence).__il2cppRuntimeField_10 = val_9;
            typeof(TzarGames.TzarHero.Influences.DamageInfluence).__il2cppRuntimeField_14 = this.damageInterval;
            typeof(TzarGames.TzarHero.Influences.DamageInfluence).__il2cppRuntimeField_18 = 0;
            typeof(TzarGames.TzarHero.Influences.DamageInfluence).__il2cppRuntimeField_1C = this.ignoreDefence;
            character.AddInfluence(influence:  val_6);
            this.appliedInfluences.Add(key:  character, value:  val_6);
        }
        public void RemoveFromCharacter(TzarGames.TzarHero.TH_Character character)
        {
            System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, TzarGames.TzarHero.Influences.DamageInfluence> val_4;
            TzarGames.TzarHero.Influences.DamageInfluence val_1 = 0;
            val_4 = this.appliedInfluences;
            if((val_4.TryGetValue(key:  character, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_4 = val_1;
            character.RemoveInfluence(influence:  val_4);
            bool val_3 = this.appliedInfluences.Remove(key:  character);
        }
        public void RemoveAllInfluences()
        {
            var val_4;
            var val_5;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.appliedInfluences.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            val_2.m_Handle.InitializationCallback.RemoveInfluence(influence:  val_2.m_Handle);
            goto label_4;
            label_2:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            this.appliedInfluences.Clear();
        }
    
    }

}
