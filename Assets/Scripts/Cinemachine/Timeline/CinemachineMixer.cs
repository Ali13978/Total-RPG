using UnityEngine;

namespace Cinemachine.Timeline
{
    public sealed class CinemachineMixer : PlayableBehaviour
    {
        // Fields
        private Cinemachine.CinemachineBrain mBrain;
        private int mBrainOverrideId;
        private bool mPlaying;
        private float mLastOverrideFrame;
        
        // Methods
        public CinemachineMixer()
        {
            this.mBrainOverrideId = 0;
        }
        public override void OnGraphStop(UnityEngine.Playables.Playable playable)
        {
            if(0 != this.mBrain)
            {
                    this.mBrain.ReleaseCameraOverride(overrideId:  this.mBrainOverrideId);
            }
            else
            {
                    this = this.mBrainOverrideId;
            }
            
            mem2[0] = 0;
        }
        public override void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData)
        {
            UnityEngine.Object val_4;
            Cinemachine.Timeline.CinemachineMixer val_23;
            object val_24;
            int val_25;
            var val_26;
            var val_27;
            float val_28;
            float val_29;
            UnityEngine.Object val_30;
            float val_32;
            val_24 = playerData;
            val_25 = playable.m_Handle.m_Version;
            this.ProcessFrame(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = val_25}}, info:  new UnityEngine.Playables.FrameData() {m_FrameID = info.m_FrameID, m_Weight = info.m_Weight, m_EffectiveParentSpeed = info.m_EffectiveParentSpeed}, playerData:  val_24);
            val_27 = 0;
            if(val_24 != null)
            {
                    UnityEngine.Object val_1 = (null == null) ? (val_24) : 0;
            }
            
            if(0 == val_1)
            {
                    val_24 = 0;
            }
            else
            {
                    val_24 = val_1.GetComponent<Cinemachine.CinemachineBrain>();
            }
            
            this.mBrain = val_24;
            if(0 == val_24)
            {
                    return;
            }
            
            if((UnityEngine.Playables.PlayableExtensions.GetInputCount<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = playable.m_Handle.m_Handle}})) < 1)
            {
                goto label_13;
            }
            
            val_28 = 0.0001f;
            var val_23 = 0;
            val_24 = 0;
            val_26 = 0;
            val_29 = 1f;
            label_23:
            UnityEngine.Playables.Playable val_9 = UnityEngine.Playables.PlayableExtensions.GetInput<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = playable.m_Handle.m_Handle}}, inputPort:  val_25);
            val_30 = val_9.m_Handle.m_Version;
            UnityEngine.Playables.ScriptPlayable<T> val_10 = UnityEngine.Playables.ScriptPlayable<Cinemachine.Timeline.CinemachineShotPlayable>.op_Explicit(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = val_9.m_Handle.m_Handle}});
            float val_11 = UnityEngine.Playables.PlayableExtensions.GetInputWeight<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = playable.m_Handle.m_Handle}}, inputIndex:  val_25);
            if(val_10.m_Handle.m_Handle == 0)
            {
                goto label_21;
            }
            
            val_30 = val_4;
            if((0 == val_30) || ((val_11 <= val_28) || ((UnityEngine.Playables.PlayableExtensions.GetPlayState<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = playable.m_Handle.m_Handle}})) != 1)))
            {
                goto label_21;
            }
            
            val_23 = val_23 + 1;
            val_29 = val_11;
            var val_14 = (val_23 == 1) ? 0 : (val_24);
            if(val_23 == 2)
            {
                goto label_24;
            }
            
            label_21:
            val_26 = val_26 + 1;
            if(val_26 < (UnityEngine.Playables.PlayableExtensions.GetInputCount<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Version = playable.m_Handle.m_Handle}})))
            {
                goto label_23;
            }
            
            goto label_24;
            label_13:
            val_24 = 0;
            val_29 = 1f;
            label_24:
            val_23 = this;
            val_32 = info.m_FrameID;
            if(mem[1152921511753813564] == true)
            {
                goto label_25;
            }
            
            if((mem[1152921511753813560] & 2147483648) != 0)
            {
                    mem[1152921511753813568] = -1f;
            }
            
            val_28 = UnityEngine.Time.realtimeSinceStartup;
            val_32 = UnityEngine.Time.unscaledDeltaTime;
            if(UnityEngine.Application.isPlaying != true)
            {
                    if(mem[1152921511753813568] >= 0)
            {
                    if((val_28 - mem[1152921511753813568]) <= UnityEngine.Time.maximumDeltaTime)
            {
                goto label_29;
            }
            
            }
            
                val_32 = -1f;
            }
            
            label_29:
            mem[1152921511753813568] = val_28;
            label_25:
            val_25 = mem[1152921511753813560];
            mem[1152921511753813560] = this.mBrain.SetCameraOverride(overrideId:  val_25, camA:  val_24, camB:  0, weightB:  val_29, deltaTime:  val_32);
        }
        public override void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
        {
            this.mPlaying = (1152921511753986208 == 1) ? 1 : 0;
        }
    
    }

}
