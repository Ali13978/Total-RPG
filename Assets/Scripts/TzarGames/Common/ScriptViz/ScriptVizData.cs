using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    public class ScriptVizData : ScriptableObject
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.Node> _nodes;
        
        // Properties
        public System.Collections.Generic.List<TzarGames.Common.Node> Nodes { get; }
        
        // Methods
        public ScriptVizData()
        {
            this._nodes = new System.Collections.Generic.List<TzarGames.Common.Node>();
        }
        public System.Collections.Generic.List<TzarGames.Common.Node> get_Nodes()
        {
            return (System.Collections.Generic.List<TzarGames.Common.Node>)this._nodes;
        }
        public void AddNode(TzarGames.Common.Node node)
        {
            this._nodes.Add(item:  node);
        }
        public void RemoveNode(TzarGames.Common.Node node)
        {
            bool val_1 = this._nodes.Remove(item:  node);
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
        private void OnDestroy()
        {
        
        }
    
    }

}
