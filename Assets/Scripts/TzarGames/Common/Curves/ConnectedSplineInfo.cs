using UnityEngine;

namespace TzarGames.Common.Curves
{
    [Serializable]
    public class ConnectedSplineInfo
    {
        // Fields
        public int SplineId;
        public bool IsTail;
        
        // Methods
        public ConnectedSplineInfo(int id, bool isTail)
        {
            this.IsTail = isTail;
            this.SplineId = id;
        }
    
    }

}
