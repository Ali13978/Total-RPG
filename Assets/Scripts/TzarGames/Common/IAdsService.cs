using UnityEngine;

namespace TzarGames.Common
{
    public interface IAdsService
    {
        // Methods
        public abstract bool IsReady(TzarGames.Common.Ad ad); // 0
        public abstract void Show(TzarGames.Common.Ad ad, System.Action<TzarGames.Common.ShowResult> callback); // 0
        public abstract void Initialize(); // 0
    
    }

}
