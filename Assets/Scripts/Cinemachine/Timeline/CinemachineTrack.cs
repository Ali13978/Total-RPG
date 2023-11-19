using UnityEngine;

namespace Cinemachine.Timeline
{
    [UnityEngine.Timeline.TrackClipTypeAttribute]
    [UnityEngine.Timeline.TrackMediaType]
    [UnityEngine.Timeline.TrackBindingTypeAttribute]
    [UnityEngine.Timeline.TrackColorAttribute]
    [Serializable]
    public class CinemachineTrack : TrackAsset
    {
        // Methods
        public CinemachineTrack()
        {
        
        }
        public override UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> val_1 = this.GetClips();
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = val_1;
            label_27:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = val_1;
            if(((val_1 & 1) & 1) == 0)
            {
                goto label_38;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = val_1;
            UnityEngine.Object val_6 = val_1.asset;
            if(val_6 == null)
            {
                goto label_20;
            }
            
            if(null == null)
            {
                goto label_19;
            }
            
            goto label_20;
            label_19:
            if(val_6 != null)
            {
                goto label_21;
            }
            
            label_20:
            label_21:
            UnityEngine.Object val_8 = 0 + 24;
            if(0 == val_8)
            {
                goto label_27;
            }
            
            val_1.displayName = val_8.name;
            goto label_27;
            label_38:
            if(val_1 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_16 = val_1;
            }
            
            UnityEngine.Playables.ScriptPlayable<T> val_12 = UnityEngine.Playables.ScriptPlayable<Cinemachine.Timeline.CinemachineMixer>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Version = graph.m_Handle}, inputCount:  graph.m_Version);
            UnityEngine.Playables.PlayableExtensions.SetInputCount<UnityEngine.Playables.ScriptPlayable<System.Object>>(playable:  new UnityEngine.Playables.ScriptPlayable<System.Object>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = val_12.m_Handle.m_Handle}}, value:  val_12.m_Handle.m_Version);
            UnityEngine.Playables.Playable val_13 = UnityEngine.Playables.ScriptPlayable<Cinemachine.Timeline.CinemachineMixer>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = val_12.m_Handle.m_Handle}});
            return new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_13.m_Handle.m_Handle, m_Version = val_13.m_Handle.m_Version}};
        }
    
    }

}
