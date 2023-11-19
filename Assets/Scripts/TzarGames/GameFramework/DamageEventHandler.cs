using UnityEngine;

namespace TzarGames.GameFramework
{
    public class DamageEventHandler : MonoBehaviour, IDamageReceiver
    {
        // Fields
        [UnityEngine.SerializeField]
        private string surface;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.DamageEvent OnDamageTaken;
        private TzarGames.GameFramework.ISurfaceType surfaceType;
        
        // Methods
        public DamageEventHandler()
        {
            this.surface = "Default";
        }
        public TzarGames.GameFramework.ISurfaceType GetSurfaceType()
        {
            return (TzarGames.GameFramework.ISurfaceType)this.surfaceType;
        }
        private void Awake()
        {
            this.surfaceType = TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  0);
        }
        private void OnEnable()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.AddHandler(obj:  0);
        }
        private void OnDisable()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.RemoveHandler(obj:  0);
        }
        public void TakeDamage(TzarGames.GameFramework.IDamageInfo damageInfo)
        {
            this.OnDamageTaken.Invoke(arg0:  damageInfo);
        }
    
    }

}
