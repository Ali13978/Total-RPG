using UnityEngine;

namespace Cinemachine.Timeline
{
    public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
    {
        // Fields
        public UnityEngine.ExposedReference<Cinemachine.CinemachineVirtualCameraBase> VirtualCamera;
        
        // Methods
        public CinemachineShot()
        {
        
        }
        public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
        {
            UnityEngine.Playables.ScriptPlayable<T> val_1 = UnityEngine.Playables.ScriptPlayable<Cinemachine.Timeline.CinemachineMixer>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Version = graph.m_Handle}, inputCount:  graph.m_Version);
            UnityEngine.Playables.Playable val_2 = UnityEngine.Playables.ScriptPlayable<Cinemachine.Timeline.CinemachineMixer>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = val_1.m_Handle.m_Handle}});
            return new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_2.m_Handle.m_Handle, m_Version = val_2.m_Handle.m_Version}};
        }
        public void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = driver;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = driver;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = driver;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = driver;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = driver;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = driver;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = driver;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = driver;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = driver;
        }
    
    }

}
