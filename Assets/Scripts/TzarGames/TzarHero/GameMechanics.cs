using UnityEngine;

namespace TzarGames.TzarHero
{
    public static class GameMechanics
    {
        // Methods
        public static bool CheckCriticalChance(float chance)
        {
            return (bool)((UnityEngine.Random.Range(min:  0f, max:  100f)) <= chance) ? 1 : 0;
        }
    
    }

}
