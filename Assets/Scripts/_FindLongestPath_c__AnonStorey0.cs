using UnityEngine;
private sealed class MazeGenerator.<FindLongestPath>c__AnonStorey0
{
    // Fields
    internal Satsuma.CustomGraph graph;
    internal System.Collections.Generic.Dictionary<long, int> nodesToCells;
    internal TzarGames.Endless.Maze.Maze maze;
    
    // Methods
    public MazeGenerator.<FindLongestPath>c__AnonStorey0()
    {
    
    }
    internal double <>m__0(Satsuma.Arc arc)
    {
        Satsuma.Node val_1 = this.graph.U(arc:  new Satsuma.Arc() {<Id>k__BackingField = arc.<Id>k__BackingField});
        Satsuma.Node val_2 = this.graph.V(arc:  new Satsuma.Arc() {<Id>k__BackingField = arc.<Id>k__BackingField});
        TzarGames.Endless.Maze.TG_MazeCell val_7 = this.maze.Cells.Item[this.nodesToCells.Item[val_1.<Id>k__BackingField.InitializationCallback]];
        TzarGames.Endless.Maze.TG_MazeCell val_8 = this.maze.Cells.Item[this.nodesToCells.Item[val_2.<Id>k__BackingField.InitializationCallback]];
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.Position, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_7.Position, y = V9.16B, z = V10.16B});
        return (double)(double)UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
    }

}
