using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class EventNodeCharacterEvents : EventNode, ICharacterEvents
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outDead;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outAlive;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outPlayerSpawn;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outCharacter;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outKiller;
        
        // Methods
        public EventNodeCharacterEvents()
        {
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.AddHandler(obj:  0);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.RemoveHandler(obj:  0);
        }
        protected override void Init()
        {
            this.Init();
            this.outDead = this.AddOutputSlot(slotName:  "Dead");
            this.outAlive = this.AddOutputSlot(slotName:  "Alive");
            this.outPlayerSpawn = this.AddOutputSlot(slotName:  "Player character spawned");
            this.outCharacter = this.AddVariableOutputSlot(slotName:  "Character");
            this.outKiller = this.AddVariableOutputSlot(slotName:  "Killer");
        }
        public void OnCharacterDead(TzarGames.TzarHero.TH_Character deadCharacter, TzarGames.TzarHero.TH_Character killer)
        {
            object val_4;
            this.outCharacter.VariableImpulse(variable:  deadCharacter.gameObject);
            val_4 = 0;
            if(0 != killer)
            {
                    val_4 = killer.gameObject;
            }
            
            this.outKiller.VariableImpulse(variable:  val_4);
            this.outDead.Impulse();
        }
        public void OnCharacterAlive(TzarGames.TzarHero.TH_Character character)
        {
            this.outCharacter.VariableImpulse(variable:  character.gameObject);
            this.outAlive.Impulse();
        }
        public void OnPlayerCharacterSpawn(TzarGames.TzarHero.TH_Character character)
        {
            this.outCharacter.VariableImpulse(variable:  character.gameObject);
            this.outPlayerSpawn.Impulse();
        }
    
    }

}
