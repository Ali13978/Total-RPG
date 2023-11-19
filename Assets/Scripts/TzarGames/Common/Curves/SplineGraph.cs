using UnityEngine;

namespace TzarGames.Common.Curves
{
    internal class SplineGraph
    {
        // Fields
        private Satsuma.CustomGraph graph;
        private System.Collections.Generic.Dictionary<int, Satsuma.Node> idToNodes;
        private System.Collections.Generic.Dictionary<Satsuma.Node, int> nodeToIds;
        
        // Methods
        public SplineGraph()
        {
            this.graph = new Satsuma.CustomGraph();
            this.idToNodes = new System.Collections.Generic.Dictionary<System.Int32, Satsuma.Node>();
            this.nodeToIds = new System.Collections.Generic.Dictionary<Satsuma.Node, System.Int32>();
        }
        public void AddNode(int nodeId)
        {
            Satsuma.Node val_1 = this.graph.AddNode();
            this.idToNodes.Add(key:  nodeId, value:  new Satsuma.Node() {<Id>k__BackingField = val_1.<Id>k__BackingField});
            this.nodeToIds.Add(key:  new Satsuma.Node() {<Id>k__BackingField = val_1.<Id>k__BackingField}, value:  nodeId);
        }
        public bool HasNode(int nodeId)
        {
            if(this.idToNodes != null)
            {
                    return this.idToNodes.ContainsKey(key:  nodeId);
            }
            
            return this.idToNodes.ContainsKey(key:  nodeId);
        }
        public bool AddEdge(int node1, int node2)
        {
            int val_4;
            var val_5;
            val_4 = node1;
            if((this.idToNodes.TryGetValue(key:  val_4, value: out  new Satsuma.Node())) != false)
            {
                    val_4 = this.idToNodes;
                if((val_4.TryGetValue(key:  node2, value: out  new Satsuma.Node())) != false)
            {
                    val_4 = 0;
                val_5 = 1;
                Satsuma.Arc val_3 = this.graph.AddArc(u:  new Satsuma.Node(), v:  new Satsuma.Node(), directedness:  1);
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public TzarGames.Common.Curves.SplineGraphPath ShortestPath(int startNode, int endNode, TzarGames.Common.Curves.SplineGraph.EdgeCostFunc edgeCostHandler)
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            if(null != 0)
            {
                    typeof(SplineGraph.<ShortestPath>c__AnonStorey0).__il2cppRuntimeField_10 = edgeCostHandler;
            }
            else
            {
                    mem[16] = edgeCostHandler;
            }
            
            typeof(SplineGraph.<ShortestPath>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            if((this.idToNodes.TryGetValue(key:  startNode, value: out  new Satsuma.Node())) == false)
            {
                    return 0;
            }
            
            if((this.idToNodes.TryGetValue(key:  endNode, value: out  new Satsuma.Node())) == false)
            {
                    return 0;
            }
            
            Satsuma.Dijkstra val_5 = new Satsuma.Dijkstra(graph:  this.graph, cost:  new System.Func<Satsuma.Arc, System.Double>(object:  new System.Object(), method:  System.Double SplineGraph.<ShortestPath>c__AnonStorey0::<>m__0(Satsuma.Arc arc)), mode:  0);
            if(null != 0)
            {
                    AddSource(node:  new Satsuma.Node());
                Satsuma.Node val_6 = RunUntilFixed(target:  new Satsuma.Node());
                val_19 = 0;
            }
            else
            {
                    AddSource(node:  new Satsuma.Node());
                Satsuma.Node val_7 = RunUntilFixed(target:  new Satsuma.Node());
                val_19 = 0;
            }
            
            Satsuma.IPath val_8 = GetPath(node:  new Satsuma.Node());
            if(val_8 == null)
            {
                    return 0;
            }
            
            object val_9 = new System.Object();
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = val_8;
            typeof(TzarGames.Common.Curves.SplineGraphPath).__il2cppRuntimeField_10 = null;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = val_8;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_8;
            val_23 = 0;
            goto label_24;
            label_40:
            var val_13 = X28 + 0;
            val_23 = 1;
            mem2[0] = val_8;
            label_24:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_24 = val_8;
            if(((val_8 & 1) & 1) == 0)
            {
                goto label_49;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = val_8;
            if(null != null)
            {
                goto label_40;
            }
            
            goto label_40;
            label_49:
            if(val_8 != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_26 = val_8;
            }
            
            if(0 == 242)
            {
                    return 0;
            }
            
            if((this.nodeToIds.Item[new Satsuma.Node() {<Id>k__BackingField = val_8}]) == 0)
            {
                    return 0;
            }
            
            return 0;
        }
        public void Clear()
        {
            this.graph.Clear();
            this.idToNodes.Clear();
            this.nodeToIds.Clear();
        }
    
    }

}
