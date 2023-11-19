using UnityEngine;
private sealed class SplineGraph.<ShortestPath>c__AnonStorey0
{
    // Fields
    internal TzarGames.Common.Curves.SplineGraph.EdgeCostFunc edgeCostHandler;
    internal TzarGames.Common.Curves.SplineGraph $this;
    
    // Methods
    public SplineGraph.<ShortestPath>c__AnonStorey0()
    {
    
    }
    internal double <>m__0(Satsuma.Arc arc)
    {
        Satsuma.Node val_1 = this.$this.graph.U(arc:  new Satsuma.Arc() {<Id>k__BackingField = arc.<Id>k__BackingField});
        Satsuma.Node val_2 = this.$this.graph.V(arc:  new Satsuma.Arc() {<Id>k__BackingField = arc.<Id>k__BackingField});
        if(this.edgeCostHandler != null)
        {
                return this.edgeCostHandler.Invoke(sourceNode:  this.$this.nodeToIds.Item[new Satsuma.Node() {<Id>k__BackingField = val_1.<Id>k__BackingField}], targetNode:  this.$this.nodeToIds.Item[new Satsuma.Node() {<Id>k__BackingField = val_2.<Id>k__BackingField}]);
        }
        
        return this.edgeCostHandler.Invoke(sourceNode:  this.$this.nodeToIds.Item[new Satsuma.Node() {<Id>k__BackingField = val_1.<Id>k__BackingField}], targetNode:  this.$this.nodeToIds.Item[new Satsuma.Node() {<Id>k__BackingField = val_2.<Id>k__BackingField}]);
    }

}
