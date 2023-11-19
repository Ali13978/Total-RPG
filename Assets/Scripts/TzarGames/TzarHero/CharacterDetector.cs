using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterDetector : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float range;
        [UnityEngine.SerializeField]
        private float updateInterval;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacterGroup> groupFilter;
        private float lastUpdateTime;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> charactersInRange;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent OnCharacterEnterRange;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterEvent OnCharacterExitRange;
        
        // Properties
        public int CharactersInRangeCount { get; }
        public TzarGames.TzarHero.TH_Character MainCharacter { get; set; }
        
        // Methods
        public CharacterDetector()
        {
            this.range = 10f;
            this.updateInterval = 7.346868E-41f;
            this.charactersInRange = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
        }
        public int get_CharactersInRangeCount()
        {
            if(this.charactersInRange != null)
            {
                    return this.charactersInRange.Count;
            }
            
            return this.charactersInRange.Count;
        }
        public TzarGames.TzarHero.TH_Character get_MainCharacter()
        {
            return (TzarGames.TzarHero.TH_Character)this.character;
        }
        public void set_MainCharacter(TzarGames.TzarHero.TH_Character value)
        {
            this.character = value;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void onDestroy(TzarGames.TzarHero.TH_InteractiveObject destroyed)
        {
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_6;
            var val_7;
            var val_8;
            val_6 = this.charactersInRange;
            List.Enumerator<T> val_1 = val_6.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(0 != val_2)
            {
                goto label_5;
            }
            
            bool val_4 = this.charactersInRange.Remove(item:  val_2);
            val_6 = null;
            val_6 = new TH_InteractiveObject.InteractiveObjectDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterDetector::onDestroy(TzarGames.TzarHero.TH_InteractiveObject destroyed));
            destroyed.remove_OnObjectDestroy(value:  val_6);
            label_2:
            val_7 = 0;
            val_8 = 1;
            0.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        private void Update()
        {
            var val_8;
            int val_22;
            if(0 == this.character)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 - this.lastUpdateTime;
            if(val_3 < this.updateInterval)
            {
                    return;
            }
            
            this.lastUpdateTime = UnityEngine.Time.time;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_5 = this.character.GetOtherCharactersInRadius(radius:  this.range);
            List.Enumerator<T> val_6 = val_5.GetEnumerator();
            do
            {
                label_19:
                if((0 & 1) == 0)
            {
                goto label_31;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = val_8.InitializationCallback;
            }
            while((this.charactersInRange.Contains(item:  val_9)) == true);
            
            if(this.groupFilter.Count != 0)
            {
                    if((this.groupFilter.Contains(item:  val_9.TemplateInstance.Group)) == false)
            {
                goto label_19;
            }
            
            }
            
            TH_InteractiveObject.InteractiveObjectDelegate val_16 = new TH_InteractiveObject.InteractiveObjectDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterDetector::onDestroy(TzarGames.TzarHero.TH_InteractiveObject destroyed));
            val_9.add_OnObjectDestroy(value:  null);
            this.charactersInRange.Add(item:  val_9);
            this.OnCharacterEnterRange.Invoke(arg0:  val_9);
            goto label_19;
            label_31:
            val_8.Dispose();
            val_22 = this.charactersInRange.Count - 1;
            if((val_22 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                TzarGames.TzarHero.TH_Character val_18 = this.charactersInRange.Item[val_22];
                if((val_5.Contains(item:  val_18)) != true)
            {
                    bool val_20 = this.charactersInRange.Remove(item:  val_18);
                val_18.remove_OnObjectDestroy(value:  new TH_InteractiveObject.InteractiveObjectDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterDetector::onDestroy(TzarGames.TzarHero.TH_InteractiveObject destroyed)));
                this.OnCharacterExitRange.Invoke(arg0:  val_18);
            }
            
                val_22 = val_22 - 1;
            }
            while((val_22 & 2147483648) == 0);
        
        }
    
    }

}
