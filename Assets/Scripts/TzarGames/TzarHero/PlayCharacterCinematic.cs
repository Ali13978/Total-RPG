using UnityEngine;

namespace TzarGames.TzarHero
{
    public class PlayCharacterCinematic : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterCinematic cinematic;
        [UnityEngine.SerializeField]
        private bool playOnStart;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onFinished;
        
        // Methods
        public PlayCharacterCinematic()
        {
        
        }
        private void Start()
        {
            if(this.playOnStart == false)
            {
                    return;
            }
            
            this.Play();
        }
        public void Play()
        {
            this.character.PlayCinematic(cinematic:  this.cinematic, finishedCallback:  new System.Action<TzarGames.TzarHero.TH_Character>(object:  this, method:  System.Void TzarGames.TzarHero.PlayCharacterCinematic::onCinematicFinished(TzarGames.TzarHero.TH_Character character)));
        }
        private void onCinematicFinished(TzarGames.TzarHero.TH_Character character)
        {
            this.onFinished.Invoke();
        }
    
    }

}
