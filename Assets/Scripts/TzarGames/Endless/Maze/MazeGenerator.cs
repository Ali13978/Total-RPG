using UnityEngine;

namespace TzarGames.Endless.Maze
{
    internal class MazeGenerator
    {
        // Methods
        public MazeGenerator()
        {
        
        }
        public static void GenerateMaze(TzarGames.Endless.Maze.Maze maze, TzarGames.Endless.Maze.MazeGenAlgorithms algorithm = 0)
        {
            if(W8 < 1)
            {
                    return;
            }
            
            if((X8 >> 32) < 1)
            {
                    return;
            }
            
            TzarGames.Endless.Maze.MazeGenerator.depthFirstSearchAlgoritm(maze: ref  TzarGames.Endless.Maze.Maze val_2 = maze, algorithm:  algorithm);
        }
        private static void depthFirstSearchAlgoritm(ref TzarGames.Endless.Maze.Maze maze, TzarGames.Endless.Maze.MazeGenAlgorithms algorithm)
        {
            var val_31;
            var val_32;
            var val_34;
            var val_35;
            var val_53;
            int val_54;
            var val_55;
            int val_56;
            var val_57;
            var val_58;
            int val_59;
            int val_60;
            int val_61;
            int val_62;
            val_31 = 1152921509955881712;
            null = new System.Collections.Generic.List<System.Int32>();
            val_32 = 1152921504870637568;
            if(null == 0)
            {
                    if(null == 0)
            {
                goto label_2;
            }
            
            }
            
            typeof(TzarGames.Endless.Maze.MazeGenAlgorithms).__il2cppRuntimeField_10 = new System.Collections.Generic.List<TzarGames.Endless.Maze.TG_MazeCell>(capacity:  (typeof(TzarGames.Endless.Maze.MazeGenAlgorithms).__il2cppRuntimeField_1C * TzarGames.Endless.Maze.MazeGenAlgorithms.__il2cppRuntimeField_namespaze));
            val_34 = 0;
            val_35 = 0;
            goto label_7;
            label_13:
            (typeof(TzarGames.Endless.Maze.MazeGenAlgorithms).__il2cppRuntimeField_1C * TzarGames.Endless.Maze.MazeGenAlgorithms.__il2cppRuntimeField_namespaze).Add(item:  1152921504870637568);
            val_35 = 1;
            label_7:
            typeof(TzarGames.Endless.Maze.TG_MazeCell).__il2cppRuntimeField_40 = 0;
            typeof(TzarGames.Endless.Maze.TG_MazeCell).__il2cppRuntimeField_48 = 0;
            null = new System.Object();
            typeof(TzarGames.Endless.Maze.TG_MazeCell).__il2cppRuntimeField_34 = 0;
            typeof(TzarGames.Endless.Maze.TG_MazeCell).__il2cppRuntimeField_38 = 0;
            typeof(TzarGames.Endless.Maze.TG_MazeCell).__il2cppRuntimeField_3C = 0;
            if(null != 0)
            {
                goto label_13;
            }
            
            goto label_13;
            label_105:
            Add(item:  null);
            if(Count == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    val_53 = Count;
            }
            else
            {
                    val_53 = Count;
            }
            
            int val_25 = Item[val_53 - 1];
            TzarGames.Endless.Maze.TG_MazeCell val_26 = Item[val_25];
            if(val_26.Neighbors.Count < 1)
            {
                goto label_69;
            }
            
            int val_28 = val_26.Neighbors.Count;
            int val_30 = val_26.Neighbors.Item[UnityEngine.Random.Range(min:  0, max:  0)];
            val_54 = Item[val_30];
            if(val_31.bVisited == true)
            {
                goto label_115;
            }
            
            val_31.bVisited = true;
            Add(item:  val_30);
            val_26.RemovedWalls.Add(item:  val_30);
            val_31.RemovedWalls.Add(item:  val_25);
            bool val_32 = val_26.Walls.Remove(item:  val_30);
            bool val_33 = val_31.Walls.Remove(item:  val_25);
            if(val_26 == null)
            {
                goto label_86;
            }
            
            val_55 = val_26;
            if(val_26.LeftWall == val_30)
            {
                goto label_94;
            }
            
            val_55 = val_26;
            if(val_26.RightWall == val_30)
            {
                goto label_94;
            }
            
            if((val_26.LeftWall >> 32) != val_30)
            {
                goto label_89;
            }
            
            val_56 = val_26.TopWall;
            goto label_90;
            label_69:
            if(null != 0)
            {
                    val_57 = Count;
            }
            else
            {
                    val_57 = Count;
            }
            
            int val_37 = val_57 - 1;
            goto label_105;
            label_86:
            val_55 = 64;
            if(0 == val_30)
            {
                goto label_94;
            }
            
            val_55 = 72;
            if(mem[72] != val_30)
            {
                goto label_95;
            }
            
            label_94:
            mem[72] = -2;
            label_113:
            if(val_54 == null)
            {
                goto label_96;
            }
            
            val_58 = val_54;
            if(val_31.LeftWall == val_25)
            {
                goto label_101;
            }
            
            val_58 = val_54;
            if(val_31.RightWall == val_25)
            {
                goto label_101;
            }
            
            if((val_31.LeftWall >> 32) != val_25)
            {
                goto label_99;
            }
            
            val_59 = val_31.TopWall;
            goto label_100;
            label_96:
            val_58 = 64;
            if(0 == val_25)
            {
                goto label_101;
            }
            
            val_58 = 72;
            if((-2) != val_25)
            {
                goto label_102;
            }
            
            label_101:
            mem[72] = -2;
            label_115:
            if(val_26.Neighbors != null)
            {
                goto label_105;
            }
            
            goto label_105;
            label_95:
            val_56 = val_26;
            if(val_26.TopWall != val_30)
            {
                goto label_106;
            }
            
            label_90:
            mem2[0] = -2;
            goto label_113;
            label_102:
            val_59 = val_54;
            if(val_31.TopWall != val_25)
            {
                goto label_108;
            }
            
            label_100:
            mem2[0] = -2;
            goto label_115;
            label_89:
            val_60 = val_26.RightWall >> 32;
            val_61 = val_26.BottomWall;
            goto label_110;
            label_99:
            val_62 = val_31.RightWall >> 32;
            val_54 = val_31.BottomWall;
            goto label_111;
            label_106:
            val_61 = val_26;
            val_60 = val_26.BottomWall;
            label_110:
            if(val_60 != val_30)
            {
                goto label_113;
            }
            
            mem2[0] = -2;
            goto label_113;
            label_108:
            val_62 = val_31.BottomWall;
            label_111:
            if(val_62 != val_25)
            {
                goto label_115;
            }
            
            mem2[0] = -2;
            goto label_115;
            label_2:
        }
        private static void dumpMazeInfo(TzarGames.Endless.Maze.Maze maze)
        {
            object val_20;
            var val_21;
            var val_22;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_20 = 0;
            goto label_1;
            label_37:
            System.Text.StringBuilder val_2 = Append(value:  ")\n");
            val_20 = 1;
            label_1:
            if(val_20 >= (X1 + 16.Count))
            {
                    return;
            }
            
            System.Text.StringBuilder val_4 = AppendFormat(format:  "Cell {0} Removed: (", arg0:  val_20);
            val_21 = 0;
            goto label_6;
            label_19:
            System.Text.StringBuilder val_5 = Append(value:  X23);
            val_21 = 1;
            label_6:
            TzarGames.Endless.Maze.TG_MazeCell val_6 = X1 + 16.Item[1];
            if(val_21 >= val_6.RemovedWalls.Count)
            {
                goto label_11;
            }
            
            TzarGames.Endless.Maze.TG_MazeCell val_8 = X1 + 16.Item[1];
            string val_10 = 0 + val_8.RemovedWalls.Item[1];
            if(null != 0)
            {
                goto label_19;
            }
            
            goto label_19;
            label_11:
            if(null != 0)
            {
                    System.Text.StringBuilder val_11 = Append(value:  ")");
            }
            else
            {
                    System.Text.StringBuilder val_12 = Append(value:  ")");
            }
            
            System.Text.StringBuilder val_13 = Append(value:  "Walls: (");
            val_22 = 0;
            goto label_22;
            label_35:
            System.Text.StringBuilder val_14 = Append(value:  val_6.RemovedWalls);
            val_22 = 1;
            label_22:
            TzarGames.Endless.Maze.TG_MazeCell val_15 = X1 + 16.Item[1];
            if(val_22 >= val_15.Walls.Count)
            {
                goto label_27;
            }
            
            TzarGames.Endless.Maze.TG_MazeCell val_17 = X1 + 16.Item[1];
            string val_19 = 0 + val_17.Walls.Item[1];
            if(null != 0)
            {
                goto label_35;
            }
            
            goto label_35;
            label_27:
            if(null != 0)
            {
                goto label_37;
            }
            
            goto label_37;
        }
        public static bool FindLongestPath(TzarGames.Endless.Maze.Maze maze, int firstCell, int secondCell, System.Collections.Generic.List<int> Path)
        {
            var val_43;
            var val_44;
            var val_45;
            long val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            typeof(MazeGenerator.<FindLongestPath>c__AnonStorey0).__il2cppRuntimeField_20 = firstCell;
            typeof(MazeGenerator.<FindLongestPath>c__AnonStorey0).__il2cppRuntimeField_10 = new Satsuma.CustomGraph();
            typeof(MazeGenerator.<FindLongestPath>c__AnonStorey0).__il2cppRuntimeField_18 = new System.Collections.Generic.Dictionary<System.Int64, System.Int32>();
            System.Collections.Generic.Dictionary<System.Int32, Satsuma.Node> val_4 = new System.Collections.Generic.Dictionary<System.Int32, Satsuma.Node>();
            val_43 = 1152921510734425424;
            val_44 = 0;
            goto label_4;
            label_21:
            val_44 = 1;
            label_4:
            if(val_44 >= (firstCell + 16.Count))
            {
                goto label_9;
            }
            
            Satsuma.Node val_6 = AddNode();
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_7 = val_6.<Id>k__BackingField.InitializationCallback;
            Add(key:  val_7, value:  1);
            if((ContainsKey(key:  1)) != true)
            {
                    Add(key:  1, value:  new Satsuma.Node() {<Id>k__BackingField = val_6.<Id>k__BackingField});
            }
            
            val_45 = 0;
            goto label_15;
            label_42:
            Satsuma.Arc val_10 = X27.AddArc(u:  new Satsuma.Node() {<Id>k__BackingField = X28}, v:  new Satsuma.Node() {<Id>k__BackingField = val_7}, directedness:  1);
            val_45 = 1;
            label_15:
            TzarGames.Endless.Maze.TG_MazeCell val_11 = firstCell + 16.Item[1];
            if(val_45 >= val_11.RemovedWalls.Count)
            {
                goto label_21;
            }
            
            TzarGames.Endless.Maze.TG_MazeCell val_13 = firstCell + 16.Item[1];
            int val_14 = val_13.RemovedWalls.Item[1];
            if((ContainsKey(key:  val_14)) != true)
            {
                    Satsuma.Node val_17 = AddNode();
                if((ContainsKey(key:  val_17.<Id>k__BackingField.InitializationCallback)) != true)
            {
                    Add(key:  val_17.<Id>k__BackingField.InitializationCallback, value:  val_14);
            }
            
                if((ContainsKey(key:  val_14)) != true)
            {
                    Add(key:  val_14, value:  new Satsuma.Node() {<Id>k__BackingField = val_17.<Id>k__BackingField});
            }
            
            }
            
            if(null != 0)
            {
                    Satsuma.Node val_24 = Item[1];
            }
            else
            {
                    Satsuma.Node val_25 = Item[1];
            }
            
            Satsuma.Node val_26 = Item[val_14];
            if(null != 0)
            {
                goto label_42;
            }
            
            goto label_42;
            label_9:
            Satsuma.Dijkstra val_28 = new Satsuma.Dijkstra(graph:  typeof(MazeGenerator.<FindLongestPath>c__AnonStorey0).__il2cppRuntimeField_10, cost:  new System.Func<Satsuma.Arc, System.Double>(object:  new System.Object(), method:  System.Double MazeGenerator.<FindLongestPath>c__AnonStorey0::<>m__0(Satsuma.Arc arc)), mode:  0);
            if(null != 0)
            {
                    Satsuma.Node val_29 = Item[secondCell];
                val_46 = val_29.<Id>k__BackingField;
            }
            else
            {
                    Satsuma.Node val_30 = Item[secondCell];
                val_46 = val_30.<Id>k__BackingField;
            }
            
            Satsuma.Node val_31 = Item[Path];
            if(null != 0)
            {
                    AddSource(node:  new Satsuma.Node() {<Id>k__BackingField = val_46});
                Satsuma.Node val_32 = RunUntilFixed(target:  new Satsuma.Node() {<Id>k__BackingField = val_31.<Id>k__BackingField});
            }
            else
            {
                    AddSource(node:  new Satsuma.Node() {<Id>k__BackingField = val_46});
                Satsuma.Node val_33 = RunUntilFixed(target:  new Satsuma.Node() {<Id>k__BackingField = val_31.<Id>k__BackingField});
            }
            
            Satsuma.IPath val_34 = GetPath(node:  new Satsuma.Node() {<Id>k__BackingField = val_31.<Id>k__BackingField});
            if(val_34 != null)
            {
                    var val_43 = 0;
                val_43 = val_43 + 1;
                val_47 = val_34;
            }
            else
            {
                    val_48 = 0;
                return (bool)val_48;
            }
            
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_49 = val_34;
            label_72:
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_50 = val_34;
            if(((val_34 & 1) & 1) == 0)
            {
                goto label_80;
            }
            
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_51 = val_34;
            ???.Add(item:  Item[val_34.InitializationCallback]);
            goto label_72;
            label_80:
            if(val_34 != null)
            {
                    var val_47 = 0;
                val_47 = val_47 + 1;
                val_52 = val_34;
            }
            
            val_48 = 1;
            if(0 == 492)
            {
                    return (bool)val_48;
            }
            
            if( == 0)
            {
                    return (bool)val_48;
            }
            
            val_48 = 1;
            return (bool)val_48;
        }
    
    }

}
