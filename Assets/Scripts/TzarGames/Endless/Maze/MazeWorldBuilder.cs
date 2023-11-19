using UnityEngine;

namespace TzarGames.Endless.Maze
{
    internal class MazeWorldBuilder : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject finishPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject[] wallPrefabs;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject[] borderWallPrefabs;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject ColumnMesh;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject ExitWall;
        [UnityEngine.SerializeField]
        private TzarGames.Common.StringID exitWallArrowTag;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject EnterWall;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 StartHeightTranslation;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject FloorMesh;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessSpawner spawnerPrefab;
        [UnityEngine.SerializeField]
        private float enemySpawnerPercent;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject chestprefab;
        [UnityEngine.SerializeField]
        private float chestPercent;
        [UnityEngine.SerializeField]
        private float chestWallOffset;
        [UnityEngine.SerializeField]
        private int MazeHorizontalCellNum;
        [UnityEngine.SerializeField]
        private int MazeVerticalCellNum;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask navMeshLayers;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onMazeGenerated;
        private UnityEngine.Vector3 StartLocation;
        private UnityEngine.Vector3 FinishLocation;
        private float WallLength;
        private UnityEngine.Vector3 mazeStartOffset;
        private static readonly UnityEngine.Quaternion rot180;
        private UnityEngine.Vector2 MazeGlobalSize;
        private UnityEngine.Vector3 MazeGlobalCorner1;
        private UnityEngine.Vector3 MazeGlobalCorner2;
        private System.Collections.Generic.List<TzarGames.Endless.Maze.MazeBuildObject> walls;
        private UnityEngine.Transform mazeContainer;
        private TzarGames.Endless.EndlessPlayerSpawnPoint playerSpawnPoint;
        private UnityEngine.GameObject finishPoint;
        private TzarGames.Endless.Maze.MazeBuildObject exitWall;
        
        // Methods
        public MazeWorldBuilder()
        {
            this.enemySpawnerPercent = 10f;
            this.chestPercent = 10f;
            this.chestWallOffset = 0.15f;
            this.MazeHorizontalCellNum = 64424509455;
            this.MazeVerticalCellNum = 15;
            this.StartHeightTranslation = 0;
            mem[1152921510740561172] = 0;
            mem[1152921510740561176] = 0;
            this.walls = new System.Collections.Generic.List<TzarGames.Endless.Maze.MazeBuildObject>();
        }
        public TzarGames.Endless.EndlessPlayerSpawnPoint GetPlayerSpawnPoint()
        {
            return (TzarGames.Endless.EndlessPlayerSpawnPoint)this.playerSpawnPoint;
        }
        public UnityEngine.GameObject GetExitWall()
        {
            if(this.exitWall != null)
            {
                    return this.exitWall.gameObject;
            }
            
            return this.exitWall.gameObject;
        }
        [UnityEngine.ContextMenu]
        public void Generate()
        {
            this.ProcessMaze(horizontalCells:  this.MazeHorizontalCellNum, verticalCells:  this.MazeVerticalCellNum);
        }
        [UnityEngine.ContextMenu]
        public void Generate(int width, int height)
        {
            this.ProcessMaze(horizontalCells:  width, verticalCells:  height);
        }
        [UnityEngine.ContextMenu]
        public void CreateEasyMaze()
        {
            this.ProcessMaze(horizontalCells:  10, verticalCells:  10);
        }
        [UnityEngine.ContextMenu]
        public void CreateAverageMaze()
        {
            this.ProcessMaze(horizontalCells:  15, verticalCells:  15);
        }
        [UnityEngine.ContextMenu]
        public void CreateHardMaze()
        {
            this.ProcessMaze(horizontalCells:  20, verticalCells:  20);
        }
        private void destroyThing(UnityEngine.GameObject obj)
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
        private void ProcessMaze(int horizontalCells, int verticalCells)
        {
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            int val_51 = verticalCells;
            int val_52 = horizontalCells;
            if(0 != this.mazeContainer)
            {
                    UnityEngine.GameObject val_2 = this.mazeContainer.gameObject;
                val_2.destroyThing(obj:  val_2);
            }
            
            this.walls.Clear();
            this.playerSpawnPoint = 0;
            this.finishPoint = 0;
            TzarGames.Endless.Maze.Maze val_3 = new TzarGames.Endless.Maze.Maze();
            do
            {
                Add(item:  new System.Collections.Generic.List<System.Int32>());
                val_51 = 6 - 1;
            }
            while(val_51 != 0);
            
            int val_6 = val_51 * val_52;
            if(null != 0)
            {
                    typeof(TzarGames.Endless.Maze.Maze).__il2cppRuntimeField_18 = val_52;
            }
            else
            {
                    mem[24] = val_52;
            }
            
            typeof(TzarGames.Endless.Maze.Maze).__il2cppRuntimeField_1C = val_51;
            TzarGames.Endless.Maze.MazeGenerator.GenerateMaze(maze:  new System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>(), algorithm:  val_3);
            val_51 = val_6 - 1;
            bool val_8 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[0], firstCell:  263897088, secondCell:  0, Path:  val_51);
            val_6 = val_6 - val_52;
            bool val_10 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[1], firstCell:  263897088, secondCell:  0, Path:  val_6);
            val_52 = val_52 - 1;
            bool val_12 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[2], firstCell:  263897088, secondCell:  0, Path:  val_52);
            if(null != 0)
            {
                    bool val_14 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[3], firstCell:  263897088, secondCell:  val_52, Path:  val_51);
            }
            else
            {
                    bool val_16 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[3], firstCell:  263897088, secondCell:  val_52, Path:  val_51);
            }
            
            bool val_18 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[4], firstCell:  263897088, secondCell:  val_52, Path:  val_6);
            bool val_20 = TzarGames.Endless.Maze.MazeGenerator.FindLongestPath(maze:  Item[5], firstCell:  263897088, secondCell:  val_6, Path:  val_51);
            val_52 = 0;
            goto label_16;
            label_25:
            val_52 = 1;
            label_16:
            if(null == 0)
            {
                goto label_17;
            }
            
            val_53 = public System.Collections.Generic.List<System.Int32> System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>::get_Item(int index);
            if(val_52 < Count)
            {
                goto label_18;
            }
            
            goto label_20;
            label_17:
            val_51 = Count;
            val_53 = public System.Collections.Generic.List<System.Int32> System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>>::get_Item(int index);
            if(val_52 >= val_51)
            {
                goto label_20;
            }
            
            label_18:
            if(0 >= Item[1].Count)
            {
                goto label_25;
            }
            
            int val_26 = Item[1].Count;
            goto label_25;
            label_20:
            int val_28 = Item[0].Count;
            string val_29 = 0 + "MaxPath:"("MaxPath:");
            UnityEngine.Debug.Log(message:  0);
            typeof(TzarGames.Endless.Maze.Maze).__il2cppRuntimeField_20 = Item[0].Item[0];
            if(null != 0)
            {
                    val_54 = Item[0];
            }
            else
            {
                    val_54 = Item[0];
            }
            
            typeof(TzarGames.Endless.Maze.Maze).__il2cppRuntimeField_24 = val_54.Item[Item[0].Count - 1];
            this.BuildMaze(maze:  val_3);
            this.GenerateSpawners(maze:  val_3);
            this.GenerateChests(maze:  val_3);
            this.cleanUpPrefabs();
            UnityEngine.AI.NavMeshSurface val_39 = this.mazeContainer.gameObject.AddComponent<UnityEngine.AI.NavMeshSurface>();
            val_39.useGeometry = 1;
            if(val_39 != null)
            {
                    val_39.layerMask = new UnityEngine.LayerMask() {m_Mask = this.navMeshLayers};
            }
            else
            {
                    val_39.layerMask = new UnityEngine.LayerMask() {m_Mask = this.navMeshLayers};
            }
            
            val_39.BuildNavMesh();
            UnityEngine.GameObject val_40 = new UnityEngine.GameObject(name:  "Map bounds");
            transform.SetParent(parent:  this.mazeContainer);
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.zero;
            AddComponent<TzarGames.Endless.MapBounds>().CreateBoundsFromMinMax(min:  new UnityEngine.Vector3() {x = UnityEngine.Mathf.Min(a:  this.MazeGlobalCorner1, b:  this.MazeGlobalCorner2), y = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  this.MazeGlobalCorner1, b:  this.MazeGlobalCorner2), b:  this.MazeGlobalCorner2), z = UnityEngine.Mathf.Min(a:  val_44.z, b:  this.MazeGlobalCorner2)}, max:  new UnityEngine.Vector3() {x = val_44.x, y = UnityEngine.Mathf.Max(a:  this.MazeGlobalCorner1, b:  this.MazeGlobalCorner2), z = UnityEngine.Mathf.Max(a:  this.MazeGlobalCorner1, b:  this.MazeGlobalCorner2)});
            this.onMazeGenerated.Invoke();
            System.GC.Collect();
        }
        private void cleanUpPrefabs()
        {
            var val_17;
            var val_18;
            val_17 = this;
            val_18 = 0;
            goto label_1;
            label_14:
            val_18 = 1;
            label_1:
            if(val_18 >= this.wallPrefabs.Length)
            {
                goto label_3;
            }
            
            TzarGames.Endless.Maze.MazeBuildObject val_17 = this.wallPrefabs[1];
            UnityEngine.SceneManagement.Scene val_2 = val_17.gameObject.scene;
            if(((1840238936 & 1) == 0) || (val_17.ActivateByDistance == false))
            {
                goto label_14;
            }
            
            if(val_17 != null)
            {
                    val_17.enabled = false;
            }
            else
            {
                    0.enabled = false;
            }
            
            UnityEngine.GameObject val_4 = val_17.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_14;
            label_3:
            UnityEngine.SceneManagement.Scene val_6 = this.FloorMesh.gameObject.scene;
            if((1840238928 & 1) != 0)
            {
                    this.EnterWall.enabled = false;
                UnityEngine.GameObject val_7 = this.FloorMesh.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            UnityEngine.SceneManagement.Scene val_9 = this.ColumnMesh.gameObject.scene;
            if((1840238920 & 1) != 0)
            {
                    this.EnterWall.enabled = false;
                UnityEngine.GameObject val_10 = this.ColumnMesh.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            UnityEngine.SceneManagement.Scene val_12 = this.ExitWall.gameObject.scene;
            if((1840238912 & 1) != 0)
            {
                    this.EnterWall.enabled = false;
                UnityEngine.GameObject val_13 = this.ExitWall.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            UnityEngine.SceneManagement.Scene val_15 = this.EnterWall.gameObject.scene;
            if((1840238904 & 1) == 0)
            {
                    return;
            }
            
            this.EnterWall.enabled = false;
            val_17 = this.EnterWall.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        private TzarGames.Endless.Maze.MazeBuildObject spawnWall(TzarGames.Endless.Maze.MazeBuildObject[] prefabs, UnityEngine.Vector3 position, bool horizontal, bool randomRot = True)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            val_9 = position.z;
            val_10 = position.y;
            val_11 = position.x;
            if(horizontal != false)
            {
                    UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  0f, y:  90f, z:  0f);
            }
            else
            {
                    UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            }
            
            val_16 = val_4.x;
            val_17 = val_4.y;
            val_18 = val_4.z;
            val_19 = val_4.w;
            if(randomRot != false)
            {
                    if((UnityEngine.Random.Range(min:  0, max:  0)) >= 1)
            {
                    val_20 = null;
                UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_16, y = val_17, z = val_18, w = val_19}, rhs:  new UnityEngine.Quaternion() {x = TzarGames.Endless.Maze.MazeWorldBuilder.rot180, y = TzarGames.Endless.Maze.MazeWorldBuilder.rot180.__il2cppRuntimeField_4, z = TzarGames.Endless.Maze.MazeWorldBuilder.rot180.__il2cppRuntimeField_8, w = TzarGames.Endless.Maze.MazeWorldBuilder.rot180.__il2cppRuntimeField_C});
                val_10 = val_10;
                val_9 = val_9;
                val_11 = val_11;
                val_16 = val_6.x;
                val_17 = val_6.y;
                val_18 = val_6.z;
                val_19 = val_6.w;
            }
            
            }
            
            TzarGames.TzarHero.DamageInfluenceBehaviour val_8 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_11, y = val_10, z = val_9}, rotation:  new UnityEngine.Quaternion() {x = val_16, y = val_17, z = val_18, w = val_19}, parent:  prefabs[(long)UnityEngine.Random.Range(min:  0, max:  0)]);
            this.walls.Add(item:  val_8);
            return (TzarGames.Endless.Maze.MazeBuildObject)val_8;
        }
        private void processExitWall(TzarGames.Endless.Maze.MazeBuildObject wall, int wallDir)
        {
            var val_9;
            T val_10;
            val_9 = public T[] UnityEngine.Component::GetComponentsInChildren<TzarGames.Common.TagBehaviour>();
            var val_9 = 0;
            label_7:
            if(val_9 >= val_1.Length)
            {
                goto label_3;
            }
            
            if(val_9 >= val_1.Length)
            {
                    val_9 = 0;
            }
            
            val_10 = wall.GetComponentsInChildren<TzarGames.Common.TagBehaviour>()[0];
            val_9 = val_9 + 1;
            if((val_10.HasTag(tag:  this.exitWallArrowTag)) == false)
            {
                goto label_7;
            }
            
            goto label_8;
            label_3:
            val_10 = 0;
            label_8:
            if(wallDir > 1)
            {
                    return;
            }
            
            if(0 == val_10)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  0f, y:  180f, z:  0f);
            UnityEngine.Transform val_6 = val_10.transform;
            UnityEngine.Quaternion val_7 = val_6.rotation;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, rhs:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
            val_6.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        }
        private void BuildMaze(TzarGames.Endless.Maze.Maze maze)
        {
            float val_12;
            float val_13;
            UnityEngine.Object val_103;
            float val_105;
            var val_106;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            TzarGames.Endless.Maze.MazeBuildObject[] val_116;
            System.Collections.Generic.List<TzarGames.Endless.Maze.TG_MazeCell> val_117;
            TzarGames.Endless.Maze.MazeBuildObject[] val_118;
            var val_119;
            var val_120;
            float val_121;
            float val_122;
            float val_123;
            float val_124;
            float val_125;
            float val_126;
            float val_127;
            float val_128;
            float val_129;
            float val_130;
            float val_131;
            float val_132;
            var val_133;
            var val_134;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_103 = UnityEngine.GameObject.Find(name:  0);
            if(0 == val_103)
            {
                    UnityEngine.GameObject val_5 = null;
                val_103 = val_5;
                val_5 = new UnityEngine.GameObject(name:  "Maze");
            }
            
            this.mazeContainer = transform;
            TzarGames.Endless.Maze.MazeBuildObject val_99 = this.wallPrefabs[0];
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
            TzarGames.GameFramework.TzarBehaviour val_9 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
            UnityEngine.Bounds val_11 = val_9.MainRenderer.bounds;
            float val_100 = val_13;
            UnityEngine.GameObject val_14 = val_9.gameObject;
            val_14.destroyThing(obj:  val_14);
            val_100 = val_100 - val_100;
            float val_101 = System.Math.Abs(val_100);
            float val_105 = val_7.y;
            val_105 = val_7.z;
            this.WallLength = val_101;
            if(maze != null)
            {
                    float val_102 = (float)maze.HorizontalCells;
                val_102 = val_101 * val_102;
                this.MazeGlobalSize = val_102;
            }
            else
            {
                    float val_103 = 7254272f;
                val_103 = val_101 * val_103;
                this.MazeGlobalSize = val_103;
            }
            
            float val_104 = (float)maze.VerticalCells;
            val_104 = val_101 * val_104;
            mem[1152921510742991532] = val_104;
            this.MazeGlobalCorner1 = this.mazeStartOffset;
            mem[1152921510742991544] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            typeof(TzarGames.Endless.Maze.MazeBuildObject[]).__il2cppRuntimeField_20 = this.ExitWall;
            val_105 = val_105 - val_7.y;
            float val_106 = System.Math.Abs(val_105);
            float val_107 = System.Math.Abs(val_105 - val_7.z);
            typeof(TzarGames.Endless.Maze.MazeBuildObject[]).__il2cppRuntimeField_20 = this.EnterWall;
            float val_108 = -0.5f;
            val_108 = val_101 * val_108;
            float val_16 = val_101 * 0.5f;
            val_106 = 1152921504719839232;
            goto label_31;
            label_159:
            this.EnterWall.addColumnPosition(horizontal:  false, wallPos:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_7.z}, wallSize:  new UnityEngine.Vector3() {x = val_101, y = val_106, z = val_107}, columnPositions:  val_2);
            goto label_31;
            label_150:
            TzarGames.Endless.Maze.TG_MazeCell val_17 = maze.Cells.Item[this.EnterWall];
            var val_109 = 7254272;
            val_109 = this.EnterWall - ((this.EnterWall / val_109) * val_109);
            var val_111 = 0;
            float val_110 = (float)val_109;
            val_110 = val_101 * val_110;
            val_111 = val_111 + ((this.EnterWall == 0) ? 0 : ((val_109 == 0) ? 1 : 0));
            val_105 = (val_108 + 1152921504719839232.__il2cppRuntimeField_BC) - val_110;
            float val_112 = (float)val_111;
            float val_22 = val_16 + 1152921504719839232.__il2cppRuntimeField_C4;
            val_112 = val_101 * val_112;
            float val_23 = val_22 + val_112;
            if(this.EnterWall == (maze.Cells.Count - 1))
            {
                    val_22 = val_16 + val_23;
                mem[1152921510742991548] = val_105 - val_16;
                mem[1152921510742991556] = val_22;
            }
            
            typeof(System.Int32[]).__il2cppRuntimeField_20 = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_24 = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_28 = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_2C = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_20 = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_24 = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_28 = 0;
            TzarGames.Endless.Maze.MazeBuildObject val_27 = this.EnterWall + 1;
            val_109 = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_2C = 0;
            TzarGames.Endless.Maze.MazeBuildObject val_28 = this.EnterWall - 1;
            goto label_48;
            label_74:
            val_109 = 1;
            label_48:
            if(val_109 >= val_17.RemovedWalls.Count)
            {
                goto label_51;
            }
            
            if(val_17.RemovedWalls.Item[1] == val_28)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_20 = 1;
            }
            
            var val_113 = 7254272;
            val_113 = val_113 + this.EnterWall;
            if(val_17.RemovedWalls.Item[1] == val_113)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_24 = 1;
            }
            
            if(val_17.RemovedWalls.Item[1] == val_27)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_28 = 1;
            }
            
            var val_114 = 7254272;
            val_114 = this.EnterWall - val_114;
            if(val_17.RemovedWalls.Item[1] != val_114)
            {
                goto label_74;
            }
            
            typeof(System.Int32[]).__il2cppRuntimeField_2C = 1;
            goto label_74;
            label_51:
            val_110 = 0;
            goto label_75;
            label_103:
            val_110 = 1;
            label_75:
            TzarGames.Endless.Maze.TG_MazeCell val_34 = maze.Cells.Item[this.EnterWall];
            if(val_110 >= val_34.Walls.Count)
            {
                goto label_80;
            }
            
            if(val_17.Walls.Item[1] == val_28)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_20 = 1;
            }
            
            var val_115 = 7254272;
            val_115 = val_115 + this.EnterWall;
            if(val_17.Walls.Item[1] == val_115)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_24 = 1;
            }
            
            if(val_17.Walls.Item[1] == val_27)
            {
                    typeof(System.Int32[]).__il2cppRuntimeField_28 = 1;
            }
            
            var val_116 = 7254272;
            val_116 = this.EnterWall - val_116;
            if(val_17.Walls.Item[1] != val_116)
            {
                goto label_103;
            }
            
            typeof(System.Int32[]).__il2cppRuntimeField_2C = 1;
            goto label_103;
            label_80:
            TzarGames.Endless.Maze.MazeBuildObject val_40 = this.EnterWall / 7254272;
            val_40 = this.EnterWall - (val_40 * 7254272);
            if(val_40 == null)
            {
                goto label_105;
            }
            
            val_111 = 0;
            val_112 = 0;
            goto label_106;
            label_105:
            if(maze == null)
            {
                    var val_117 = 7254272;
            }
            
            float val_41 = val_16 + val_105;
            val_117 = this.EnterWall - ((this.EnterWall / val_117) * val_117);
            if(val_117 == null)
            {
                goto label_108;
            }
            
            label_161:
            TzarGames.Endless.Maze.MazeBuildObject val_43 = this.spawnWall(prefabs:  this.wallPrefabs, position:  new UnityEngine.Vector3() {x = val_41, y = V8.16B, z = val_23}, horizontal:  true, randomRot:  true);
            val_111 = 0;
            label_125:
            val_112 = 0;
            goto label_109;
            label_108:
            if(this.EnterWall != maze.FinishCellNum)
            {
                goto label_110;
            }
            
            val_112 = 1;
            TzarGames.Endless.Maze.MazeBuildObject val_44 = this.spawnWall(prefabs:  null, position:  new UnityEngine.Vector3() {x = val_41, y = V8.16B, z = val_23}, horizontal:  true, randomRot:  false);
            mem[1152921510742991592] = val_44;
            this.processExitWall(wall:  val_44, wallDir:  0);
            val_111 = 0;
            label_109:
            this.addColumnPosition(horizontal:  true, wallPos:  new UnityEngine.Vector3() {x = val_41, y = V8.16B, z = val_23}, wallSize:  new UnityEngine.Vector3() {x = val_101, y = val_106, z = val_107}, columnPositions:  val_2);
            label_106:
            if(maze != null)
            {
                    val_113 = 7254272;
            }
            else
            {
                    val_113 = 7254272;
            }
            
            if((val_113 + this.EnterWall) >= maze.Cells.Count)
            {
                goto label_114;
            }
            
            val_106 = 1152921504719839232;
            goto label_115;
            label_114:
            float val_47 = val_16 + val_23;
            var val_118 = 7254272;
            val_118 = maze.Cells.Count - val_118;
            if(this.EnterWall >= val_118)
            {
                goto label_118;
            }
            
            TzarGames.Endless.Maze.MazeBuildObject val_49 = this.spawnWall(prefabs:  this.wallPrefabs, position:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_47}, horizontal:  false, randomRot:  true);
            val_106 = 1152921504719839232;
            goto label_123;
            label_118:
            val_106 = 1152921504719839232;
            var val_50 = (this.EnterWall != maze.FinishCellNum) ? 1 : 0;
            val_50 = val_112 | val_50;
            if((val_50 & 1) == 0)
            {
                goto label_120;
            }
            
            var val_51 = (this.EnterWall != maze.StartCellNum) ? 1 : 0;
            val_51 = val_111 | val_51;
            if((val_51 & 1) == 0)
            {
                goto label_121;
            }
            
            val_114 = 0;
            val_115 = 1;
            val_116 = mem[1152921510742991368];
            goto label_122;
            label_120:
            TzarGames.Endless.Maze.MazeBuildObject val_52 = this.spawnWall(prefabs:  null, position:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_47}, horizontal:  false, randomRot:  false);
            mem[1152921510742991592] = val_52;
            val_112 = 1;
            this.processExitWall(wall:  val_52, wallDir:  1);
            goto label_123;
            label_110:
            if(this.EnterWall != maze.StartCellNum)
            {
                goto label_161;
            }
            
            TzarGames.Endless.Maze.MazeBuildObject val_53 = this.spawnWall(prefabs:  null, position:  new UnityEngine.Vector3() {x = val_41, y = V8.16B, z = val_23}, horizontal:  true, randomRot:  true);
            goto label_125;
            label_121:
            val_116 = null;
            val_111 = 1;
            val_115 = 1;
            val_114 = 0;
            label_122:
            label_123:
            this.spawnWall(prefabs:  val_116, position:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_47}, horizontal:  false, randomRot:  true).addColumnPosition(horizontal:  false, wallPos:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_47}, wallSize:  new UnityEngine.Vector3() {x = val_101, y = val_106, z = val_107}, columnPositions:  val_2);
            label_115:
            var val_119 = 7254272;
            val_119 = val_27 - ((val_27 / val_119) * val_119);
            if(val_119 != 0)
            {
                goto label_133;
            }
            
            var val_120 = 7254272;
            float val_56 = val_105 - val_16;
            val_120 = val_27 - ((val_27 / val_120) * val_120);
            if(val_120 == 0)
            {
                goto label_135;
            }
            
            label_139:
            label_160:
            TzarGames.Endless.Maze.MazeBuildObject val_58 = this.spawnWall(prefabs:  this.wallPrefabs, position:  new UnityEngine.Vector3() {x = val_56, y = V8.16B, z = val_23}, horizontal:  true, randomRot:  true);
            goto label_136;
            label_135:
            var val_59 = (this.EnterWall != maze.FinishCellNum) ? 1 : 0;
            val_59 = val_112 | val_59;
            if((val_59 & 1) == 0)
            {
                goto label_137;
            }
            
            var val_60 = (this.EnterWall != maze.StartCellNum) ? 1 : 0;
            val_60 = val_111 | val_60;
            if((val_60 & 1) == 0)
            {
                goto label_160;
            }
            
            goto label_139;
            label_137:
            val_112 = 1;
            TzarGames.Endless.Maze.MazeBuildObject val_61 = this.spawnWall(prefabs:  null, position:  new UnityEngine.Vector3() {x = val_56, y = V8.16B, z = val_23}, horizontal:  true, randomRot:  false);
            mem[1152921510742991592] = val_61;
            this.processExitWall(wall:  val_61, wallDir:  2);
            label_136:
            this.addColumnPosition(horizontal:  true, wallPos:  new UnityEngine.Vector3() {x = val_56, y = V8.16B, z = val_23}, wallSize:  new UnityEngine.Vector3() {x = val_101, y = val_106, z = val_107}, columnPositions:  val_2);
            label_133:
            var val_121 = 7254272;
            val_121 = this.EnterWall - val_121;
            if((val_121 & 2147483648) != 0)
            {
                goto label_147;
            }
            
            label_31:
            val_117 = maze.Cells;
            if(val_27 < val_117.Count)
            {
                goto label_150;
            }
            
            goto label_151;
            label_147:
            val_23 = val_108 + val_23;
            if(this.EnterWall >= 7254272)
            {
                goto label_153;
            }
            
            var val_63 = (this.EnterWall != maze.FinishCellNum) ? 1 : 0;
            val_63 = val_112 | val_63;
            if((val_63 & 1) == 0)
            {
                goto label_154;
            }
            
            var val_64 = (this.EnterWall != maze.StartCellNum) ? 1 : 0;
            val_64 = val_111 | val_64;
            if((val_64 & 1) == 0)
            {
                goto label_155;
            }
            
            val_118 = mem[1152921510742991368];
            goto label_156;
            label_153:
            val_118 = this.wallPrefabs;
            label_156:
            val_119 = 0;
            val_120 = 1;
            goto label_157;
            label_154:
            TzarGames.Endless.Maze.MazeBuildObject val_65 = this.spawnWall(prefabs:  null, position:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_23}, horizontal:  false, randomRot:  false);
            mem[1152921510742991592] = val_65;
            this.processExitWall(wall:  val_65, wallDir:  3);
            goto label_159;
            label_155:
            val_118 = null;
            val_119 = 0;
            val_120 = 1;
            label_157:
            TzarGames.Endless.Maze.MazeBuildObject val_66 = this.spawnWall(prefabs:  val_118, position:  new UnityEngine.Vector3() {x = val_105, y = V8.16B, z = val_23}, horizontal:  false, randomRot:  true);
            goto label_159;
            label_151:
            UnityEngine.GameObject val_67 = new UnityEngine.GameObject(name:  "Player spawn point");
            transform.SetParent(parent:  this.mazeContainer);
            UnityEngine.Vector3 val_70 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[1152921510742991488], y = mem[1152921510742991492], z = mem[1152921510742991496]}, b:  new UnityEngine.Vector3() {x = mem[1152921510742991408], y = mem[1152921510742991412], z = mem[1152921510742991416]});
            val_121 = val_70.y;
            val_122 = val_70.x;
            val_123 = val_121;
            val_124 = val_70.z;
            transform.position = new UnityEngine.Vector3() {x = val_122, y = val_123, z = val_124};
            mem[1152921510742991576] = AddComponent<TzarGames.Endless.EndlessPlayerSpawnPoint>();
            if(0 != mem[1152921510742991352])
            {
                    val_121 = mem[1152921510742991504];
                UnityEngine.Quaternion val_73 = UnityEngine.Quaternion.identity;
                val_122 = mem[1152921510742991500];
                val_123 = val_121;
                val_124 = mem[1152921510742991508];
                mem[1152921510742991584] = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_122, y = val_123, z = val_124}, rotation:  new UnityEngine.Quaternion() {x = val_73.x, y = val_73.y, z = val_73.z, w = val_73.w}, parent:  mem[1152921510742991352]);
            }
            
            UnityEngine.Vector3 val_75 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_76 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z}, d:  1000f);
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[1152921510742991488], y = mem[1152921510742991492], z = mem[1152921510742991496]}, b:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z});
            UnityEngine.Quaternion val_78 = UnityEngine.Quaternion.identity;
            val_125 = val_78.w;
            TzarGames.TzarHero.DamageInfluenceBehaviour val_79 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z}, rotation:  new UnityEngine.Quaternion() {x = val_78.x, y = val_78.y, z = val_78.z, w = val_125}, parent:  mem[1152921510742991424]);
            UnityEngine.Bounds val_81 = val_79.GetComponentInChildren<UnityEngine.Renderer>().bounds;
            float val_122 = val_13;
            UnityEngine.GameObject val_82 = val_79.gameObject;
            val_82.destroyThing(obj:  val_82);
            val_122 = val_122 - val_122;
            float val_123 = System.Math.Abs(val_122);
            val_126 = val_77.y;
            val_127 = System.Math.Abs(val_77.z - val_77.z);
            float val_124 = System.Math.Abs(this.MazeGlobalCorner1);
            val_128 = System.Math.Abs(mem[1152921510742991548]);
            val_124 = val_124 + val_128;
            val_129 = System.Math.Abs(mem[1152921510742991544]);
            val_130 = System.Math.Abs(mem[1152921510742991556]);
            val_124 = val_124 / val_123;
            val_131 = val_129 + val_130;
            int val_84 = UnityEngine.Mathf.CeilToInt(f:  val_124);
            val_132 = val_131 / val_127;
            int val_85 = UnityEngine.Mathf.CeilToInt(f:  val_132);
            UnityEngine.Vector3 val_86 = UnityEngine.Vector3.zero;
            if(val_84 >= 1)
            {
                    val_128 = mem[1152921510742991540];
                val_129 = mem[1152921510742991412];
                float val_125 = System.Math.Abs(val_126 - val_77.y);
                val_125 = val_128 - val_125;
                float val_126 = val_123;
                val_126 = val_125 + val_129;
                val_130 = 0.5f;
                val_126 = val_126 * val_130;
                var val_128 = 0;
                val_132 = val_127 * val_130;
                do
            {
                if(val_85 >= 1)
            {
                    do
            {
                float val_127 = 0f;
                val_127 = val_127 * val_127;
                val_131 = val_126 + ((val_123 * 0f) + mem[1152921510742991548]);
                UnityEngine.Quaternion val_92 = UnityEngine.Quaternion.identity;
                val_127 = val_92.y;
                val_125 = val_92.w;
                val_132 = val_131;
                val_128 = val_126;
                val_129 = (mem[1152921510742991556] - val_127) - val_132;
                val_130 = val_92.x;
                TzarGames.TzarHero.DamageInfluenceBehaviour val_93 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_132, y = val_128, z = val_129}, rotation:  new UnityEngine.Quaternion() {x = val_130, y = val_127, z = val_92.z, w = val_125}, parent:  mem[1152921510742991424]);
                val_117 = 0 + 1;
            }
            while(val_85 != val_117);
            
            }
            
                val_128 = val_128 + 1;
            }
            while(val_128 != val_84);
            
            }
            
            List.Enumerator<T> val_94 = GetEnumerator();
            label_201:
            if((0 & 1) == 0)
            {
                goto label_196;
            }
            
            UnityEngine.Quaternion val_95 = UnityEngine.Quaternion.identity;
            TzarGames.TzarHero.DamageInfluenceBehaviour val_96 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_129}, rotation:  new UnityEngine.Quaternion() {x = val_95.x, y = val_95.y, z = val_95.z, w = val_95.w}, parent:  mem[1152921510742991376]);
            goto label_201;
            label_196:
            val_133 = 0;
            val_134 = 1;
            val_13.Dispose();
            val_13 = mem[1152921510742991560].Count;
            string val_98 = 0 + "Walls count: "("Walls count: ");
            UnityEngine.Debug.Log(message:  0);
        }
        private void addColumnPosition(bool horizontal, UnityEngine.Vector3 wallPos, UnityEngine.Vector3 wallSize, System.Collections.Generic.List<UnityEngine.Vector3> columnPositions)
        {
            if(horizontal != false)
            {
                
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  0.5f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = wallPos.x, y = wallPos.y, z = wallPos.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = wallPos.x, y = wallPos.y, z = wallPos.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if((columnPositions.Contains(item:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != true)
            {
                    columnPositions.Add(item:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            }
            
            if((columnPositions.Contains(item:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == true)
            {
                    return;
            }
            
            columnPositions.Add(item:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        private void GenerateObstacles(int FillAmountInPercent, TzarGames.Endless.Maze.Maze maze)
        {
            var val_21;
            var val_22;
            var val_23;
            System.Collections.Generic.List<TzarGames.Endless.Maze.TG_MazeCell> val_24;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<System.Int32> val_2 = null;
            val_21 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
            float val_21 = 100f;
            val_21 = (float)maze.Cells.Count / val_21;
            val_21 = (float)FillAmountInPercent * val_21;
            int val_4 = maze.Cells.Count;
            int val_5 = UnityEngine.Mathf.Clamp(value:  0, min:  (int)val_21, max:  0);
            val_22 = 1152921509956145392;
            val_23 = 0;
            goto label_6;
            label_11:
            Add(item:  0);
            val_23 = 1;
            label_6:
            val_24 = maze.Cells;
            if(val_23 >= val_24.Count)
            {
                goto label_9;
            }
            
            if(null != 0)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            if(val_5 < 1)
            {
                    return;
            }
            
            int val_22 = val_5;
            do
            {
                int val_7 = Count;
                int val_8 = UnityEngine.Random.Range(min:  0, max:  0);
                val_24 = Item[val_8];
                if(val_24 != maze.StartCellNum)
            {
                    if(Item[val_8] != maze.FinishCellNum)
            {
                    val_24 = Item[val_8];
                Add(item:  val_24);
            }
            
            }
            
                RemoveAt(index:  val_8);
                val_22 = val_22 - 1;
            }
            while(val_22 != 0);
            
            if(val_5 < 1)
            {
                    return;
            }
            
            val_22 = 1152921510742770576;
            do
            {
                int val_12 = Item[0];
                float val_25 = this.WallLength;
                float val_24 = (float)val_12 - ((val_12 / maze.HorizontalCells) * maze.HorizontalCells);
                int val_23 = maze.VerticalCells;
                float val_27 = this.WallLength;
                UnityEngine.Vector3 val_29 = this.MazeGlobalCorner1;
                val_23 = Item[0] / val_23;
                float val_26 = (float)val_23;
                val_24 = val_25 * val_24;
                val_25 = val_25 * 0.5f;
                val_26 = val_27 * val_26;
                val_27 = val_27 * 0.5f;
                TzarGames.Endless.Maze.MazeBuildObject val_28 = this.wallPrefabs[0];
                val_24 = val_25 + val_24;
                val_29 = val_29 - val_24;
                UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
                val_24 = this.walls;
                val_24.Add(item:  UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_29, y = S10 + (-2f), z = S8 + (val_27 + val_26)}, rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}));
                val_21 = 0 + 1;
            }
            while(val_5 != val_21);
        
        }
        private void GenerateSpawners(TzarGames.Endless.Maze.Maze maze)
        {
            var val_22;
            var val_23;
            var val_24;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            double val_22 = 100;
            val_22 = (double)(float)maze.Cells.Count / val_22;
            double val_23 = (double)this.enemySpawnerPercent;
            val_23 = val_23 * val_22;
            int val_4 = maze.Cells.Count;
            val_22 = UnityEngine.Mathf.Clamp(value:  0, min:  (int)val_23, max:  0);
            val_23 = 0;
            goto label_6;
            label_11:
            Add(item:  0);
            val_23 = 1;
            label_6:
            if(val_23 >= maze.Cells.Count)
            {
                goto label_9;
            }
            
            if(null != 0)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            if(val_22 >= 1)
            {
                    do
            {
                int val_7 = Count;
                int val_8 = UnityEngine.Random.Range(min:  0, max:  0);
                if(Item[val_8] != maze.StartCellNum)
            {
                    if(Item[val_8] != maze.FinishCellNum)
            {
                    Add(item:  Item[val_8]);
            }
            
            }
            
                RemoveAt(index:  val_8);
                val_22 = val_22 - 1;
            }
            while(val_22 != 0);
            
            }
            
            val_24 = 0;
            goto label_23;
            label_35:
            UnityEngine.Debug.Log(message:  0);
            val_24 = 1;
            label_23:
            if(val_24 >= Count)
            {
                    return;
            }
            
            int val_13 = Item[1];
            int val_24 = maze.HorizontalCells;
            val_24 = val_13 - ((val_13 / val_24) * val_24);
            float val_15 = this.WallLength * (float)val_24;
            float val_16 = this.WallLength * 0.5f;
            val_16 = val_16 + val_15;
            var val_25 = Item[1];
            float val_27 = this.WallLength;
            val_25 = val_25 / maze.VerticalCells;
            UnityEngine.Vector3 val_28 = this.MazeGlobalCorner1;
            float val_26 = (float)val_25;
            val_26 = val_27 * val_26;
            val_27 = val_27 * 0.5f;
            val_28 = val_28 - val_16;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.identity;
            TzarGames.TzarHero.DamageInfluenceBehaviour val_21 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_28, y = val_15, z = S11 + (val_27 + val_26)}, rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, parent:  this.spawnerPrefab);
            goto label_35;
        }
        private void GenerateChests(TzarGames.Endless.Maze.Maze maze)
        {
            var val_25;
            var val_26;
            var val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            double val_25 = 100;
            val_25 = (double)(float)maze.Cells.Count / val_25;
            double val_26 = (double)this.chestPercent;
            val_26 = val_26 * val_25;
            int val_4 = maze.Cells.Count;
            float val_5 = 1f - this.chestWallOffset;
            val_25 = UnityEngine.Mathf.Clamp(value:  0, min:  (int)val_26, max:  0);
            val_26 = 0;
            goto label_6;
            label_11:
            Add(item:  0);
            val_26 = 1;
            label_6:
            if(val_26 >= maze.Cells.Count)
            {
                goto label_9;
            }
            
            if(null != 0)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            if(val_25 >= 1)
            {
                    do
            {
                int val_8 = Count;
                int val_9 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_10 = Item[val_9];
                int val_27 = maze.StartCellNum;
                if(val_10 != val_27)
            {
                    val_27 = val_27 >> 32;
                if(val_10 != val_27)
            {
                    Add(item:  val_10);
            }
            
            }
            
                RemoveAt(index:  val_9);
                val_25 = val_25 - 1;
            }
            while(val_25 != 0);
            
            }
            
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  0f, y:  90f, z:  0f);
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Euler(x:  0f, y:  -90f, z:  0f);
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(x:  0f, y:  180f, z:  0f);
            val_27 = 0;
            goto label_23;
            label_43:
            val_27 = 1;
            label_23:
            if(val_27 >= Count)
            {
                    return;
            }
            
            TzarGames.Endless.Maze.TG_MazeCell val_16 = maze.Cells.Item[Item[1]];
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
            int val_28 = val_16.LeftWall;
            if(val_28 != 2)
            {
                goto label_32;
            }
            
            val_28 = val_28 >> 32;
            if(val_28 != (-2))
            {
                goto label_33;
            }
            
            int val_29 = val_16.RightWall;
            val_29 = val_12.y;
            val_28 = val_12.x;
            val_30 = val_12.w;
            val_31 = val_12.z;
            val_32 = val_5;
            val_33 = 0.5f;
            if(val_29 != 2)
            {
                goto label_37;
            }
            
            val_29 = val_29 >> 32;
            if(val_29 == (-2))
            {
                goto label_43;
            }
            
            val_33 = val_5;
            val_28 = val_17.x;
            val_29 = val_17.y;
            val_31 = val_17.z;
            val_30 = val_17.w;
            goto label_36;
            label_32:
            val_32 = this.chestWallOffset;
            val_29 = val_11.y;
            val_28 = val_11.x;
            val_30 = val_11.w;
            val_31 = val_11.z;
            val_33 = 0.5f;
            goto label_37;
            label_33:
            val_33 = this.chestWallOffset;
            val_29 = val_13.y;
            val_28 = val_13.x;
            val_30 = val_13.w;
            val_31 = val_13.z;
            label_36:
            val_32 = 0.5f;
            label_37:
            int val_18 = Item[1];
            int val_30 = maze.HorizontalCells;
            float val_32 = this.WallLength;
            val_30 = val_18 - ((val_18 / val_30) * val_30);
            float val_31 = (float)val_30;
            val_31 = val_32 * val_31;
            val_32 = val_32 * val_32;
            float val_20 = val_32 + val_31;
            float val_34 = this.WallLength;
            var val_33 = Item[1];
            val_33 = val_33 / maze.VerticalCells;
            val_20 = this.MazeGlobalCorner1 - val_20;
            val_34 = val_34 * (float)val_33;
            val_34 = (val_33 * val_34) + val_34;
            TzarGames.TzarHero.DamageInfluenceBehaviour val_24 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_20, y = val_17.x, z = this.MazeGlobalCorner1 + val_34}, rotation:  new UnityEngine.Quaternion() {x = val_28, y = val_29, z = val_31, w = val_30}, parent:  this.chestprefab);
            goto label_43;
        }
        private static MazeWorldBuilder()
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(x:  0f, y:  180f, z:  0f);
            TzarGames.Endless.Maze.MazeWorldBuilder.rot180 = val_1.x;
            TzarGames.Endless.Maze.MazeWorldBuilder.rot180.__il2cppRuntimeField_4 = val_1.y;
            TzarGames.Endless.Maze.MazeWorldBuilder.rot180.__il2cppRuntimeField_8 = val_1.z;
            TzarGames.Endless.Maze.MazeWorldBuilder.rot180.__il2cppRuntimeField_C = val_1.w;
        }
    
    }

}
