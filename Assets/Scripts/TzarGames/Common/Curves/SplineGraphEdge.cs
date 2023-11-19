using UnityEngine;

namespace TzarGames.Common.Curves
{
    internal class SplineGraphEdge
    {
        // Fields
        public int SourceId;
        public int TargetId;
        
        // Methods
        public SplineGraphEdge(int s, int t)
        {
            this.SourceId = s;
            this.TargetId = t;
        }
    
    }

}
