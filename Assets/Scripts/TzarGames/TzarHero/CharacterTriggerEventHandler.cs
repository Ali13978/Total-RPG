using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterTriggerEventHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool triggerOnce;
        [UnityEngine.SerializeField]
        private string[] tags;
        [UnityEngine.SerializeField]
        private bool callEventsOnUpdate;
        [UnityEngine.SerializeField]
        private bool triggerOnlyPlayerOwner;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent onTriggerEnter;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent onTriggerExit;
        private bool triggered;
        private UnityEngine.Collider lastTouchedCollider;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> enteredCharacters;
        private System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, UnityEngine.Collider> characterColliders;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> pendingEnterCharacters;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> pendingExitCharacters;
        
        // Properties
        public TzarGames.TzarHero.CharacterEvent OnTriggerEnterEvent { get; }
        public TzarGames.TzarHero.CharacterEvent OnTriggerExitEvent { get; }
        
        // Methods
        public CharacterTriggerEventHandler()
        {
            this.callEventsOnUpdate = true;
            this.triggerOnce = true;
            this.enteredCharacters = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
            this.characterColliders = new System.Collections.Generic.Dictionary<TzarGames.TzarHero.TH_Character, UnityEngine.Collider>();
            this.pendingEnterCharacters = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
            this.pendingExitCharacters = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
        }
        public TzarGames.TzarHero.CharacterEvent get_OnTriggerEnterEvent()
        {
            return (TzarGames.TzarHero.CharacterEvent)this.onTriggerEnter;
        }
        public TzarGames.TzarHero.CharacterEvent get_OnTriggerExitEvent()
        {
            return (TzarGames.TzarHero.CharacterEvent)this.onTriggerExit;
        }
        private void Update()
        {
            var val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_25;
            var val_26;
            var val_27;
            if(this.callEventsOnUpdate == false)
            {
                    return;
            }
            
            if(this.pendingEnterCharacters.Count < 1)
            {
                goto label_3;
            }
            
            val_22 = 1152921510746858704;
            val_23 = 1152921504718028800;
            val_24 = 0;
            goto label_4;
            label_14:
            val_24 = 1;
            label_4:
            val_25 = this.pendingEnterCharacters;
            if(val_24 >= this.pendingEnterCharacters.Count)
            {
                goto label_7;
            }
            
            this.onTriggerEnter.Invoke(arg0:  val_25.Item[1]);
            goto label_14;
            label_7:
            val_25.Clear();
            label_3:
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_22 = this.enteredCharacters;
            val_22 = val_22.Count - 1;
            if((val_22 & 2147483648) != 0)
            {
                goto label_16;
            }
            
            val_22 = 1152921510548295440;
            val_23 = 1152921510683239904;
            label_39:
            val_25 = this.enteredCharacters.Item[val_22];
            if(0 == val_25)
            {
                    this.enteredCharacters.RemoveAt(index:  val_22);
                val_25 = this.characterColliders;
                bool val_7 = val_25.Remove(key:  0);
            }
            else
            {
                    UnityEngine.Collider val_8 = this.characterColliders.Item[val_25];
                if(0 != val_8)
            {
                    if(val_8.enabled == true)
            {
                goto label_37;
            }
            
            }
            
                string val_13 = 0 + "Handle trg exit ";
                UnityEngine.Debug.Log(message:  0);
                this.handleCharacterTriggerExit(character:  val_25);
                bool val_14 = this.enteredCharacters.Remove(item:  val_25);
                bool val_15 = this.characterColliders.Remove(key:  val_25);
                if((this.pendingExitCharacters._version.Contains(item:  val_25)) != false)
            {
                    bool val_18 = this.pendingExitCharacters._version.Remove(item:  val_25);
            }
            
            }
            
            label_37:
            val_22 = val_22 - 1;
            if((val_22 & 2147483648) == 0)
            {
                goto label_39;
            }
            
            label_16:
            if(this.pendingExitCharacters._version.Count <= 0)
            {
                    return;
            }
            
            val_27 = 0;
            goto label_42;
            label_45:
            this.handleCharacterTriggerExit(character:  val_25.Item[0]);
            val_27 = 1;
            label_42:
            if(val_27 < this.pendingExitCharacters._version.Count)
            {
                goto label_45;
            }
            
            this.pendingExitCharacters._version.Clear();
            return;
            label_46:
            val_26 = 4396;
            mem[8] = ???;
            goto label_46;
        }
        private bool isColliderPassTagFilter(UnityEngine.Collider other)
        {
            System.String[] val_2;
            var val_3;
            var val_4;
            val_2 = this.tags;
            if((val_2 == null) || (this.tags.Length == 0))
            {
                goto label_1;
            }
            
            val_3 = 0;
            goto label_2;
            label_8:
            val_2 = this.tags;
            val_3 = 1;
            label_2:
            if(val_3 >= this.tags.Length)
            {
                goto label_4;
            }
            
            val_2 = this.tags[1];
            this.tags[1] = other.CompareTag(tag:  val_2);
            if(this.tags[1] == false)
            {
                goto label_8;
            }
            
            label_1:
            val_4 = 1;
            return (bool)val_4;
            label_4:
            val_4 = 0;
            return (bool)val_4;
        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            UnityEngine.Object val_10;
            UnityEngine.Object val_11;
            if(this.enabled == false)
            {
                    return;
            }
            
            if((this.isColliderPassTagFilter(other:  other)) == false)
            {
                    return;
            }
            
            if(this.triggerOnce != false)
            {
                    if(this.triggered == true)
            {
                    return;
            }
            
                val_10 = other.GetComponent<TzarGames.TzarHero.TH_Character>();
                if(0 == val_10)
            {
                    return;
            }
            
                if(((this.triggerOnlyPlayerOwner != false) && (this.triggerOnlyPlayerOwner != false)) && ((this.triggerOnlyPlayerOwner + 24) != 0))
            {
                    if(((this.triggerOnlyPlayerOwner + 24) & 1) == 0)
            {
                    return;
            }
            
            }
            
                this.lastTouchedCollider = other;
                this.triggered = true;
            }
            else
            {
                    val_10 = 0;
            }
            
            val_11 = val_10;
            if(0 == val_11)
            {
                    val_10 = other.GetComponent<TzarGames.TzarHero.TH_Character>();
                val_11 = val_10;
                if(0 == val_11)
            {
                    return;
            }
            
            }
            
            if(((this.triggerOnlyPlayerOwner != false) && (this.triggerOnlyPlayerOwner != false)) && ((this.triggerOnlyPlayerOwner + 24) != 0))
            {
                    if(((this.triggerOnlyPlayerOwner + 24) & 1) == 0)
            {
                    return;
            }
            
            }
            
            if((this.enteredCharacters.Contains(item:  val_10)) != false)
            {
                    this.handleCharacterTriggerExit(character:  val_10);
            }
            else
            {
                    this.enteredCharacters.Add(item:  val_10);
                this.characterColliders.Add(key:  val_10, value:  other);
            }
            
            if(this.callEventsOnUpdate != false)
            {
                    this.pendingEnterCharacters.Add(item:  val_10);
                return;
            }
            
            this.onTriggerEnter.Invoke(arg0:  val_10);
        }
        private void OnTriggerExit(UnityEngine.Collider other)
        {
            UnityEngine.Collider val_9;
            if((this.isColliderPassTagFilter(other:  other)) == false)
            {
                    return;
            }
            
            if(this.triggerOnce != false)
            {
                    val_9 = this.lastTouchedCollider;
                if(0 != val_9)
            {
                    return;
            }
            
                this.lastTouchedCollider = 0;
            }
            
            TzarGames.TzarHero.TH_Character val_4 = other.GetComponent<TzarGames.TzarHero.TH_Character>();
            if(0 == val_4)
            {
                    return;
            }
            
            val_9 = this.enteredCharacters;
            if((val_9.Contains(item:  val_4)) == false)
            {
                    return;
            }
            
            bool val_7 = this.enteredCharacters.Remove(item:  val_4);
            bool val_8 = this.characterColliders.Remove(key:  val_4);
            if(this.callEventsOnUpdate != false)
            {
                    this.pendingExitCharacters.Add(item:  val_4);
                return;
            }
            
            this.onTriggerExit.Invoke(arg0:  val_4);
        }
        private void handleCharacterTriggerExit(TzarGames.TzarHero.TH_Character character)
        {
            this.onTriggerExit.Invoke(arg0:  character);
        }
        private void OnDisable()
        {
            var val_4;
            this.pendingEnterCharacters.Clear();
            if(this.enteredCharacters.Count <= 0)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_4;
            label_7:
            this.handleCharacterTriggerExit(character:  X21.Item[0]);
            val_4 = 1;
            label_4:
            if(val_4 < this.enteredCharacters.Count)
            {
                goto label_7;
            }
            
            this.enteredCharacters.Clear();
            this.characterColliders.Clear();
        }
    
    }

}
