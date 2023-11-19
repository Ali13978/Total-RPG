using UnityEngine;

namespace TzarGames.Endless.Maze
{
    public class TG_MazeCell
    {
        // Fields
        public int Num;
        public System.Collections.Generic.List<int> Neighbors;
        public System.Collections.Generic.List<int> RemovedWalls;
        public System.Collections.Generic.List<int> Walls;
        public bool bVisited;
        public UnityEngine.Vector3 Position;
        public int LeftWall;
        public int TopWall;
        public int RightWall;
        public int BottomWall;
        
        // Methods
        public TG_MazeCell()
        {
            this.LeftWall = 0;
            this.TopWall = 0;
            this.RightWall = 0;
            this.BottomWall = 0;
        }
    
    }

}
