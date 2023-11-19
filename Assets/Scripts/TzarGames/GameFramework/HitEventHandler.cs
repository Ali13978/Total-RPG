using UnityEngine;

namespace TzarGames.GameFramework
{
    public class HitEventHandler : MonoBehaviour, IHittable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.HitEvent OnHit;
        
        // Methods
        public HitEventHandler()
        {
        
        }
        public void NotifyHit(TzarGames.GameFramework.IHit hit)
        {
            this.OnHit.Invoke(arg0:  hit);
        }
        private void OnEnable()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.AddHandler(obj:  0);
        }
        private void OnDisable()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.RemoveHandler(obj:  0);
        }
    
    }

}
