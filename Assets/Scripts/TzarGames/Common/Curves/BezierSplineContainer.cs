using UnityEngine;

namespace TzarGames.Common.Curves
{
    [UnityEngine.ExecuteInEditMode]
    public class BezierSplineContainer : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.Curves.Connection> connections;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.Curves.SplineEntity> splineEntities;
        [UnityEngine.SerializeField]
        private int currentSplineId;
        private TzarGames.Common.Curves.SplineGraph graph;
        
        // Properties
        public System.Collections.Generic.List<TzarGames.Common.Curves.SplineEntity> Splines { get; }
        
        // Methods
        public BezierSplineContainer()
        {
        
        }
        public System.Collections.Generic.List<TzarGames.Common.Curves.SplineEntity> get_Splines()
        {
            return (System.Collections.Generic.List<TzarGames.Common.Curves.SplineEntity>)this.splineEntities;
        }
        private void updateGraph()
        {
            var val_7;
            int val_10;
            int val_23;
            var val_24;
            var val_25;
            int val_26;
            int val_27;
            var val_29;
            if(this.splineEntities == null)
            {
                    return;
            }
            
            val_23 = 1152921511087842224;
            if(this.splineEntities.Count == 0)
            {
                    return;
            }
            
            val_24 = 0;
            goto label_3;
            label_9:
            X21.Compile(curveInterpolationStepCount:  -2108939344);
            val_24 = 1;
            label_3:
            if(val_24 >= this.splineEntities.Count)
            {
                goto label_5;
            }
            
            TzarGames.Common.Curves.SplineEntity val_3 = this.splineEntities.Item[1];
            if(val_3.Spline != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_5:
            if(this.graph == null)
            {
                goto label_10;
            }
            
            this.graph.Clear();
            val_25 = 0;
            goto label_12;
            label_10:
            val_25 = 0;
            this.graph = new TzarGames.Common.Curves.SplineGraph();
            goto label_12;
            label_18:
            AddNode(nodeId:  W22);
            val_25 = 1;
            label_12:
            if(val_25 >= this.splineEntities.Count)
            {
                goto label_14;
            }
            
            TzarGames.Common.Curves.SplineEntity val_6 = this.splineEntities.Item[1];
            if(this.graph != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_14:
            val_23 = 0;
            goto label_19;
            label_26:
            val_23 = val_7 + 1;
            label_19:
            if(val_23 >= this.connections.Count)
            {
                    return;
            }
            
            val_7 = val_23;
            TzarGames.Common.Curves.Connection val_9 = this.connections.Item[val_23];
            val_26 = 0;
            goto label_23;
            label_32:
            val_26 = val_10;
            label_23:
            if(val_26 >= (val_9.ConnectedSplines.Count - 1))
            {
                goto label_26;
            }
            
            TzarGames.Common.Curves.ConnectedSplineInfo val_13 = val_9.ConnectedSplines.Item[val_26];
            val_27 = val_26 + 1;
            val_10 = val_27;
            goto label_29;
            label_54:
            val_27 = val_27 + 1;
            label_29:
            if(val_27 >= val_9.ConnectedSplines.Count)
            {
                goto label_32;
            }
            
            TzarGames.Common.Curves.ConnectedSplineInfo val_15 = val_9.ConnectedSplines.Item[val_27];
            if((this.graph.HasNode(nodeId:  val_15.SplineId)) == false)
            {
                goto label_37;
            }
            
            if((this.graph.HasNode(nodeId:  val_13.SplineId)) == false)
            {
                goto label_40;
            }
            
            bool val_20 = this.graph.AddEdge(node1:  val_15.SplineId, node2:  val_13.SplineId);
            bool val_21 = this.graph.AddEdge(node1:  val_13.SplineId, node2:  val_15.SplineId);
            goto label_54;
            label_37:
            val_29 = null;
            goto label_48;
            label_40:
            val_29 = null;
            label_48:
            string val_22 = 0 + "Vertex with id " + val_15.SplineId;
            UnityEngine.Debug.LogError(message:  0);
            goto label_54;
        }
        public int[] CalculateShortestPath(int firstSplineId, int secondSplineId)
        {
            System.Int32[] val_2;
            typeof(SplineGraph.EdgeCostFunc).__il2cppRuntimeField_20 = this;
            typeof(SplineGraph.EdgeCostFunc).__il2cppRuntimeField_28 = System.Double TzarGames.Common.Curves.BezierSplineContainer::calcEdgeDistance(int sourceNodeId, int targetNodeId);
            typeof(SplineGraph.EdgeCostFunc).__il2cppRuntimeField_10 = System.Double TzarGames.Common.Curves.BezierSplineContainer::calcEdgeDistance(int sourceNodeId, int targetNodeId);
            if((this.graph.ShortestPath(startNode:  firstSplineId, endNode:  secondSplineId, edgeCostHandler:  null)) != null)
            {
                    val_2 = val_1.Nodes;
                return (System.Int32[])val_2;
            }
            
            val_2 = 0;
            return (System.Int32[])val_2;
        }
        private double calcEdgeDistance(int sourceNodeId, int targetNodeId)
        {
            TzarGames.Common.Curves.SplineEntity val_1 = this.GetSplineEntityById(splineId:  sourceNodeId);
            TzarGames.Common.Curves.SplineEntity val_2 = this.GetSplineEntityById(splineId:  targetNodeId);
            double val_3 = val_2.Spline.<Length>k__BackingField;
            val_3 = (val_1.Spline.<Length>k__BackingField) + val_3;
            return (double)val_3;
        }
        private void OnEnable()
        {
            if(this.splineEntities == null)
            {
                    this.splineEntities = new System.Collections.Generic.List<TzarGames.Common.Curves.SplineEntity>();
            }
            
            if(this.connections == null)
            {
                    this.connections = new System.Collections.Generic.List<TzarGames.Common.Curves.Connection>();
            }
            
            this.updateGraph();
        }
        public TzarGames.Common.Curves.SplineEntity AddNewSpline(TzarGames.Common.Curves.BezierSpline spline)
        {
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(TzarGames.Common.Curves.SplineEntity).__il2cppRuntimeField_10 = this.currentSplineId;
                int val_2 = this.currentSplineId;
                val_2 = val_2 + 1;
                this.currentSplineId = val_2;
            }
            else
            {
                    mem[16] = this.currentSplineId;
                int val_3 = this.currentSplineId;
                val_3 = val_3 + 1;
                this.currentSplineId = val_3;
            }
            
            typeof(TzarGames.Common.Curves.SplineEntity).__il2cppRuntimeField_18 = spline;
            this.splineEntities.Add(item:  val_1);
            this.updateGraph();
            return (TzarGames.Common.Curves.SplineEntity)val_1;
        }
        public void RemoveSplineById(int splineId)
        {
            var val_6;
            var val_7;
            int val_8;
            val_6 = 1152921511087842224;
            val_7 = 0;
            goto label_1;
            label_6:
            val_7 = 1;
            label_1:
            if(val_7 >= this.splineEntities.Count)
            {
                goto label_3;
            }
            
            TzarGames.Common.Curves.SplineEntity val_2 = this.splineEntities.Item[1];
            if(val_2.Id != splineId)
            {
                goto label_6;
            }
            
            this.splineEntities.RemoveAt(index:  1);
            label_3:
            val_8 = this.connections.Count - 1;
            if((val_8 & 2147483648) != 0)
            {
                    return;
            }
            
            val_6 = 1152921511087892400;
            do
            {
                TzarGames.Common.Curves.Connection val_4 = this.connections.Item[val_8];
                if((val_4.ContainsSplineId(id:  splineId)) != false)
            {
                    val_4.RemoveSplineById(id:  splineId);
            }
            
                this.updateGraph();
                val_8 = val_8 - 1;
            }
            while((val_8 & 2147483648) == 0);
        
        }
        public void AddConnection(int firstSplineId, bool firstTail, int secondSplineId, bool secondTail)
        {
            int val_20;
            var val_21;
            var val_22;
            var val_23;
            System.Collections.Generic.List<TzarGames.Common.Curves.Connection> val_24;
            var val_25;
            TzarGames.Common.Curves.Connection val_26;
            val_20 = firstSplineId;
            firstTail = firstTail;
            TzarGames.Common.Curves.Connection val_4 = 0;
            TzarGames.Common.Curves.Connection val_1 = 0;
            bool val_2 = this.TryGetSplineConnection(splineId:  val_20, tail:  firstTail, connection: out  val_1);
            bool val_5 = this.TryGetSplineConnection(splineId:  secondSplineId, tail:  secondTail, connection: out  val_4);
            if(val_1 == 0)
            {
                goto label_2;
            }
            
            val_21 = val_1.GetSplineInfoById(id:  val_20);
            if(val_21 == null)
            {
                goto label_2;
            }
            
            var val_7 = (val_6.IsTail == true) ? 1 : 0;
            val_7 = val_7 ^ firstTail;
            var val_8 = (val_7 != true) ? 0 : (val_1);
            goto label_3;
            label_2:
            val_21 = 0;
            val_22 = 0;
            label_3:
            val_23 = 0;
            if(val_22 != 0)
            {
                goto label_5;
            }
            
            val_24 = val_4;
            if(val_24 == 0)
            {
                goto label_5;
            }
            
            val_23 = val_24.GetSplineInfoById(id:  secondSplineId);
            if(val_23 == null)
            {
                goto label_6;
            }
            
            var val_10 = (val_9.IsTail == true) ? 1 : 0;
            val_10 = val_10 ^ secondTail;
            val_25 = val_24;
            if(val_10 == true)
            {
                goto label_9;
            }
            
            label_5:
            if(val_25 != 0)
            {
                goto label_8;
            }
            
            goto label_9;
            label_6:
            val_23 = 0;
            label_9:
            object val_12 = null;
            val_26 = val_12;
            val_12 = new System.Object();
            typeof(TzarGames.Common.Curves.Connection).__il2cppRuntimeField_10 = new System.Collections.Generic.List<TzarGames.Common.Curves.ConnectedSplineInfo>();
            val_24 = this.connections;
            val_24.Add(item:  val_26);
            label_8:
            if(val_21 == 0)
            {
                goto label_12;
            }
            
            var val_14 = (1 != 0) ? 1 : 0;
            val_14 = val_14 ^ firstTail;
            if(val_14 == false)
            {
                goto label_13;
            }
            
            label_12:
            object val_15 = null;
            val_24 = val_15;
            val_15 = new System.Object();
            typeof(TzarGames.Common.Curves.ConnectedSplineInfo).__il2cppRuntimeField_10 = val_20;
            typeof(TzarGames.Common.Curves.ConnectedSplineInfo).__il2cppRuntimeField_14 = firstTail;
            Add(item:  val_24);
            label_13:
            if(val_23 == 0)
            {
                goto label_16;
            }
            
            var val_17 = (1 != 0) ? 1 : 0;
            val_17 = val_17 ^ secondTail;
            if(val_17 == false)
            {
                goto label_17;
            }
            
            label_16:
            object val_18 = null;
            val_20 = val_18;
            val_18 = new System.Object();
            typeof(TzarGames.Common.Curves.ConnectedSplineInfo).__il2cppRuntimeField_10 = secondSplineId;
            typeof(TzarGames.Common.Curves.ConnectedSplineInfo).__il2cppRuntimeField_14 = secondTail;
            Add(item:  val_20);
            label_17:
            this.updateGraph();
        }
        public TzarGames.Common.Curves.SplineEntity GetSplineEntityById(int splineId)
        {
            var val_3;
            var val_4;
            val_3 = splineId;
            List.Enumerator<T> val_1 = this.splineEntities.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0.InitializationCallback;
            if(0 != val_3)
            {
                goto label_4;
            }
            
            0.Dispose();
            return (TzarGames.Common.Curves.SplineEntity)val_4;
            label_2:
            0.Dispose();
            val_4 = 0;
            return (TzarGames.Common.Curves.SplineEntity)val_4;
        }
        public bool TryGetSplineConnection(int splineId, bool tail, out TzarGames.Common.Curves.Connection connection)
        {
            var val_3;
            var val_7;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            connection = 0;
            List.Enumerator<T> val_1 = this.connections.GetEnumerator();
            val_11 = 1152921511085053616;
            label_15:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            List.Enumerator<T> val_5 = connection.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_8 = val_7.InitializationCallback;
            if(0 != splineId)
            {
                goto label_8;
            }
            
            var val_9 = (0 != 0) ? 1 : 0;
            val_9 = val_9 ^ tail;
            if(val_9 == true)
            {
                goto label_8;
            }
            
            val_12 = 152;
            connection = val_3.InitializationCallback;
            goto label_9;
            label_5:
            val_12 = 119;
            label_9:
            val_13 = 0;
            val_7.Dispose();
            if(119 == 119)
            {
                goto label_15;
            }
            
            if(119 == 152)
            {
                goto label_13;
            }
            
            if(val_13 == 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_2:
            val_3.Dispose();
            val_14 = 0;
            return (bool)val_14 & 1;
            label_13:
            val_3.Dispose();
            return (bool)val_14 & 1;
        }
    
    }

}
