using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_CharacterAnim : CharacterAnimationBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private string defaultAnimationName;
        [UnityEngine.SerializeField]
        public string MoveSpeedParamName;
        [UnityEngine.SerializeField]
        private bool setGroundedParameter;
        [UnityEngine.SerializeField]
        public string isGroundedParamName;
        private const string moveSpeedMultiplierName = "Movement Speed Multiplier";
        private readonly int moveSpeedMultiplierParamHash;
        private int moveSpeedParamHash;
        private int isGroundedParamHash;
        [UnityEngine.SerializeField]
        private UnityEngine.Animator _animator;
        [UnityEngine.SerializeField]
        private int attackLayerNumber;
        [UnityEngine.SerializeField]
        private float movementAnimLerpSpeed;
        [UnityEngine.SerializeField]
        private float movementAnimSpeedScale;
        [UnityEngine.SerializeField]
        private int attackAnimsCount;
        [UnityEngine.SerializeField]
        private float attackSpeedScale;
        private float _currentMoveSpeed;
        [UnityEngine.SerializeField]
        private float attackLayerBlendSpeed;
        private float attackLayerBlend;
        private float targetAttackLayerBlend;
        private float currentAttackSpeed;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private string customAnimationTag;
        [UnityEngine.SerializeField]
        private int defaultCustomAnimationLayer;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_CharacterAnim.AnimationLayerInfo[] animationLayerInfo;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_CharacterAnim.StateBlendInfo> _stateBlendInfos;
        private TzarGames.Common.AnimationEventHandler animEventHandler;
        private TzarGames.Common.StateMachineBehaviourEventHandler[] stateHandlers;
        private System.Collections.Generic.Dictionary<int, TzarGames.TzarHero.TH_CharacterAnim.AnimationInfo> customAnimFinishedCallbacks;
        private System.Collections.Generic.Dictionary<int, int> layersToPlayingAnims;
        private bool isAttacking;
        private bool enableAnimation;
        
        // Properties
        public UnityEngine.Animator AnimatorComponent { get; }
        
        // Methods
        public TH_CharacterAnim()
        {
            this.defaultAnimationName = "Default";
            this.MoveSpeedParamName = "MoveSpeed";
            this.isGroundedParamName = "Is grounded";
            this.movementAnimLerpSpeed = 3f;
            this.attackLayerBlendSpeed = 5f;
            this.moveSpeedMultiplierParamHash = UnityEngine.Animator.StringToHash(name:  0);
            this.attackLayerNumber = 1;
            this.movementAnimSpeedScale = 1f;
            this.attackAnimsCount = 1;
            this.attackSpeedScale = 1f;
            this.currentAttackSpeed = 1f;
            this.defaultCustomAnimationLayer = 2;
            this.customAnimationTag = "Custom";
            this._stateBlendInfos = new System.Collections.Generic.List<StateBlendInfo>();
            this.customAnimFinishedCallbacks = new System.Collections.Generic.Dictionary<System.Int32, AnimationInfo>();
            this.enableAnimation = 1;
            this.layersToPlayingAnims = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        }
        public UnityEngine.Animator get_AnimatorComponent()
        {
            return (UnityEngine.Animator)this._animator;
        }
        protected override void Awake()
        {
            this.moveSpeedParamHash = UnityEngine.Animator.StringToHash(name:  0);
            this.isGroundedParamHash = UnityEngine.Animator.StringToHash(name:  0);
        }
        private void Start()
        {
            if(0 == this._animator)
            {
                    return;
            }
            
            this.initializeAnimator();
        }
        private void initializeAnimator()
        {
            var val_11;
            System.Action<UnityEngine.AnimationEvent> val_12;
            TzarGames.Common.StateMachineBehaviourEventHandler[] val_13;
            var val_14;
            var val_15;
            TzarGames.Common.StateMachineBehaviourEventHandler[] val_16;
            val_11 = 1152921504721543168;
            if(0 != this.animEventHandler)
            {
                    System.Action<UnityEngine.AnimationEvent> val_2 = null;
                val_12 = val_2;
                val_2 = new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::AnimEventHandlerOnOnAnimationEvent(UnityEngine.AnimationEvent animationEvent));
                this.animEventHandler.remove_OnAnimationEvent(value:  val_12);
            }
            
            TzarGames.Common.AnimationEventHandler val_3 = this._animator.GetComponent<TzarGames.Common.AnimationEventHandler>();
            this.animEventHandler = val_3;
            if(0 != val_3)
            {
                    System.Action<UnityEngine.AnimationEvent> val_5 = null;
                val_12 = val_5;
                val_5 = new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::AnimEventHandlerOnOnAnimationEvent(UnityEngine.AnimationEvent animationEvent));
                this.animEventHandler.add_OnAnimationEvent(value:  val_12);
            }
            
            val_13 = this.stateHandlers;
            if(val_13 == null)
            {
                goto label_13;
            }
            
            val_14 = 1152921504714088448;
            val_15 = 1152921511571433696;
            val_11 = 0;
            goto label_11;
            label_18:
            val_13.remove_OnExitFromState(value:  val_12);
            val_13 = this.stateHandlers;
            val_11 = 1;
            label_11:
            if(val_11 >= this.stateHandlers.Length)
            {
                goto label_13;
            }
            
            System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32> val_6 = null;
            TzarGames.Common.StateMachineBehaviourEventHandler val_11 = this.stateHandlers[1];
            val_6 = new System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::HandlerOnOnEnterToState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex));
            val_11.remove_OnEnterToState(value:  val_6);
            System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32> val_7 = new System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::HandlerOnOnExitFromState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex));
            if(val_11 != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_13:
            val_16 = this._animator.GetBehaviours<TzarGames.Common.StateMachineBehaviourEventHandler>();
            this.stateHandlers = val_16;
            if(val_16 == null)
            {
                    return;
            }
            
            val_14 = 1152921504714088448;
            val_15 = 1152921511571433696;
            val_11 = 0;
            goto label_21;
            label_28:
            val_16.add_OnExitFromState(value:  val_12);
            val_16 = this.stateHandlers;
            val_11 = 1;
            label_21:
            if(val_11 >= this.stateHandlers.Length)
            {
                    return;
            }
            
            System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32> val_9 = null;
            TzarGames.Common.StateMachineBehaviourEventHandler val_12 = this.stateHandlers[1];
            val_9 = new System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::HandlerOnOnEnterToState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex));
            val_12.add_OnEnterToState(value:  val_9);
            System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32> val_10 = new System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::HandlerOnOnExitFromState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex));
            if(val_12 != null)
            {
                goto label_28;
            }
            
            goto label_28;
        }
        private void HandlerOnOnExitFromState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex)
        {
            GooglePlayGames.BasicApi.ResponseStatus val_1 = animatorStateInfo.m_Name.Status;
            if((this.layersToPlayingAnims.ContainsKey(key:  layerIndex)) != false)
            {
                    if(this.layersToPlayingAnims.Item[layerIndex] == val_1)
            {
                    bool val_4 = this.layersToPlayingAnims.Remove(key:  layerIndex);
            }
            
            }
            
            if((this.customAnimFinishedCallbacks.TryGetValue(key:  val_1, value: out  0)) == false)
            {
                    return;
            }
            
            bool val_7 = this.customAnimFinishedCallbacks.Remove(key:  val_1);
            this = 11993091;
            val_8.Invoke();
        }
        private void HandlerOnOnEnterToState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex)
        {
            GooglePlayGames.BasicApi.ResponseStatus val_1 = animatorStateInfo.m_Name.Status;
            if((this.layersToPlayingAnims.ContainsKey(key:  layerIndex)) != false)
            {
                    this.layersToPlayingAnims.set_Item(key:  layerIndex, value:  val_1);
                return;
            }
            
            this.layersToPlayingAnims.Add(key:  layerIndex, value:  val_1);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            if(0 == this.animEventHandler)
            {
                    return;
            }
            
            this.animEventHandler.remove_OnAnimationEvent(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::AnimEventHandlerOnOnAnimationEvent(UnityEngine.AnimationEvent animationEvent)));
        }
        private void AnimEventHandlerOnOnAnimationEvent(UnityEngine.AnimationEvent animationEvent)
        {
            this.RaiseOnAnimationEvent(animEvent:  animationEvent);
        }
        public override void SetAttackSpeed(float speed)
        {
            this._animator.speed = speed;
        }
        public override void EnableAnimation(bool enable)
        {
            bool val_1 = enable;
            this.enableAnimation = val_1;
            this._animator.enabled = val_1;
        }
        private TzarGames.TzarHero.TH_CharacterAnim.AnimationLayerInfo getLayerInfoForAnimationName(string anim)
        {
            var val_3;
            AnimationLayerInfo val_4;
            val_3 = 0;
            label_6:
            if(val_3 >= this.animationLayerInfo.Length)
            {
                goto label_1;
            }
            
            val_4 = this.animationLayerInfo[0];
            val_3 = val_3 + 1;
            if((this.animationLayerInfo[0x0][0].AnimationName.Equals(value:  anim)) == false)
            {
                goto label_6;
            }
            
            return (AnimationLayerInfo)val_4;
            label_1:
            val_4 = 0;
            return (AnimationLayerInfo)val_4;
        }
        private int getLayerForAnimation(string anim)
        {
            AnimationLayerInfo[] val_2;
            int val_3;
            var val_3 = 0;
            label_6:
            val_2 = this.animationLayerInfo;
            if(val_3 >= this.animationLayerInfo.Length)
            {
                goto label_1;
            }
            
            AnimationLayerInfo val_2 = this.animationLayerInfo[0];
            val_2 = this.animationLayerInfo[0x0][0].AnimationName;
            val_3 = val_3 + 1;
            if((val_2.Equals(value:  anim)) == false)
            {
                goto label_6;
            }
            
            val_3 = this.animationLayerInfo[0x0][0].LayerIndex;
            return val_3;
            label_1:
            val_3 = this.defaultCustomAnimationLayer;
            return val_3;
        }
        private TzarGames.TzarHero.TH_CharacterAnim.StateBlendInfo getStateBlendInfoByLayer(int layerIndex)
        {
            var val_3;
            int val_1 = this._stateBlendInfos.Count;
            if(val_1 >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_3 = this._stateBlendInfos.Item[0];
                if(val_2.LayerIndex == layerIndex)
            {
                    return (StateBlendInfo)val_3;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
            
            }
            
            val_3 = 0;
            return (StateBlendInfo)val_3;
        }
        private void updateAttackWeight()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 * this.attackLayerBlendSpeed;
            float val_3 = UnityEngine.Mathf.Lerp(a:  this.attackLayerBlend, b:  this.targetAttackLayerBlend, t:  val_1 * this.currentAttackSpeed);
            this.attackLayerBlend = val_3;
            this._animator.SetLayerWeight(layerIndex:  this.attackLayerNumber, weight:  val_3);
        }
        private void Update()
        {
            int val_23;
            int val_24;
            var val_25;
            float val_26;
            float val_28;
            float val_29;
            float val_30;
            if(this._animator.enabled == false)
            {
                    return;
            }
            
            if(this._animator.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            val_23 = this.attackLayerNumber;
            UnityEngine.AnimatorStateInfo val_4 = this._animator.GetCurrentAnimatorStateInfo(layerIndex:  val_23);
            float val_23 = this.attackLayerBlend;
            float val_8 = ((-1623064752) != 1) ? 1f : 0f;
            val_23 = val_23 - val_8;
            this.targetAttackLayerBlend = val_8;
            if(System.Math.Abs(val_23) > 0.0001f)
            {
                    this.updateAttackWeight();
            }
            
            int val_9 = this._stateBlendInfos.Count;
            if(val_9 < 1)
            {
                    return;
            }
            
            label_26:
            val_24 = val_10.LayerIndex;
            if(this._animator.layerCount <= val_24)
            {
                goto label_22;
            }
            
            UnityEngine.AnimatorStateInfo val_12 = this._animator.GetCurrentAnimatorStateInfo(layerIndex:  val_24);
            bool val_13 = System.String.IsNullOrEmpty(value:  0);
            var val_15 = (val_13 != true) ? this.customAnimationTag : (val_10 + 32);
            if((val_13 != true) && ((((this._stateBlendInfos.Item[0] != 0) ? 1 : 0) & 1) == 0))
            {
                    val_25 = val_10 + 32;
            }
            
            val_26 = val_10.CurrentCustomLayerBlend;
            float val_17 = ( != 1) ? 1f : 0f;
            val_10.TargetCustomLayerBlend = val_17;
            val_28 = System.Math.Abs(val_26 - val_17);
            if(val_28 > 0.0001f)
            {
                goto label_20;
            }
            
            val_24 = this._animator;
            float val_19 = val_24.GetLayerWeight(layerIndex:  val_10.LayerIndex);
            val_29 = val_10.TargetCustomLayerBlend;
            val_19 = val_19 - val_29;
            val_28 = System.Math.Abs(val_19);
            if(val_28 <= 0.0001f)
            {
                goto label_22;
            }
            
            val_26 = val_10.CurrentCustomLayerBlend;
            label_20:
            val_30 = UnityEngine.Mathf.Lerp(a:  val_26, b:  val_29, t:  UnityEngine.Time.deltaTime * 10f);
            val_10.CurrentCustomLayerBlend = val_30;
            val_24 = this._animator;
            val_24.SetLayerWeight(layerIndex:  val_10.LayerIndex, weight:  val_30);
            label_22:
            val_23 = 0 + 1;
            if(val_9 != val_23)
            {
                goto label_26;
            }
        
        }
        public void SetAnimator(UnityEngine.Animator animator)
        {
            this._animator = animator;
            if(0 == animator)
            {
                    return;
            }
            
            this.initializeAnimator();
        }
        public override void PlayAttackAnimation(int animNumber, float timeDuration)
        {
            float val_3 = timeDuration;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  0);
            this._animator.Play(stateName:  0 + "Attack ", layer:  0, normalizedTime:  0f);
            val_3 = this.attackSpeedScale / val_3;
            this.currentAttackSpeed = val_3;
            this._animator.SetFloat(name:  "Attack Speed Multiplier", value:  val_3);
            this.targetAttackLayerBlend = 1f;
            this.isAttacking = true;
            this.updateAttackWeight();
        }
        public override void CancelAttackAnim()
        {
            this._animator.SetFloat(name:  "Attack Speed Multiplier", value:  1f);
            this.isAttacking = false;
            this.targetAttackLayerBlend = 0f;
            this.updateAttackWeight();
        }
        public override void PlayAnimation(string animName, bool play)
        {
            UnityEngine.Animator val_10;
            AnimationLayerInfo val_1 = this.getLayerInfoForAnimationName(anim:  animName);
            int val_2 = (val_1 != 0) ? val_1.LayerIndex : this.defaultCustomAnimationLayer;
            val_10 = this._animator;
            if(val_10.layerCount > val_2)
            {
                    val_10 = this.getStateBlendInfoByLayer(layerIndex:  val_2);
                if(val_10 == null)
            {
                    object val_5 = null;
                val_10 = val_5;
                val_5 = new System.Object();
                typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_10 = val_2;
                if(val_1 != null)
            {
                    typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_20 = val_1.Tag;
            }
            
                this._stateBlendInfos.Add(item:  val_10);
            }
            
                float val_6 = this._animator.GetLayerWeight(layerIndex:  val_2);
                if(null != 0)
            {
                    typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_14 = val_6;
                var val_7 = (play != true) ? 1f : 0f;
            }
            else
            {
                    typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_14 = val_6;
            }
            
                typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_18 = (play != true) ? 1f : 0f;
            }
            
            this._animator.SetBool(name:  animName, value:  play);
        }
        public void PlayAnimationOnce(string animName)
        {
            goto typeof(TzarGames.TzarHero.TH_CharacterAnim).__il2cppRuntimeField_230;
        }
        public override void PlayAnimationOnce(string animName, System.Action finishedCallback)
        {
            StateBlendInfo val_12;
            AnimationLayerInfo val_1 = this.getLayerInfoForAnimationName(anim:  animName);
            int val_2 = (val_1 != 0) ? val_1.LayerIndex : this.defaultCustomAnimationLayer;
            if(this._animator.layerCount > val_2)
            {
                    val_12 = this.getStateBlendInfoByLayer(layerIndex:  val_2);
                if(val_12 == null)
            {
                    object val_5 = null;
                val_12 = val_5;
                val_5 = new System.Object();
                typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_10 = val_2;
                if(val_1 != null)
            {
                    typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_20 = val_1.Tag;
            }
            
                this._stateBlendInfos.Add(item:  val_12);
            }
            
                float val_6 = this._animator.GetLayerWeight(layerIndex:  val_2);
                if(null != 0)
            {
                    typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_14 = val_6;
            }
            else
            {
                    mem[20] = val_6;
            }
            
                typeof(TH_CharacterAnim.StateBlendInfo).__il2cppRuntimeField_18 = 1065353216;
            }
            
            if(finishedCallback != null)
            {
                    val_12 = UnityEngine.Animator.StringToHash(name:  0);
                if((this.customAnimFinishedCallbacks.TryGetValue(key:  val_12, value: out  0)) != true)
            {
                    typeof(TH_CharacterAnim.AnimationInfo).__il2cppRuntimeField_10 = finishedCallback;
                typeof(TH_CharacterAnim.AnimationInfo).__il2cppRuntimeField_18 = val_2;
                this.customAnimFinishedCallbacks.Add(key:  val_12, value:  new System.Object());
            }
            
            }
            
            this._animator.Play(stateName:  animName, layer:  val_2, normalizedTime:  0f);
        }
        public override void ResetToDefaultAnimation()
        {
            this.stopOtherAnimations();
        }
        private void stopOtherAnimations()
        {
            var val_3;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.layersToPlayingAnims.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_13;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_4.Status;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Stop animation in layer {0}");
            this._animator.Play(stateName:  this.defaultAnimationName, layer:  val_4.Status);
            goto label_10;
            label_13:
            val_3.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public bool IsPlayingAnimation(string animationName)
        {
            UnityEngine.AnimatorStateInfo val_3 = this._animator.GetCurrentAnimatorStateInfo(layerIndex:  ((this.getLayerInfoForAnimationName(anim:  animationName)) == 0) ? this.defaultCustomAnimationLayer : val_1.LayerIndex);
            return false;
        }
        public UnityEngine.AnimatorStateInfo GetNextAnimatorState(string animationName)
        {
            int val_4;
            float val_5;
            int val_6;
            UnityEngine.AnimatorStateInfo val_0;
            UnityEngine.AnimatorStateInfo val_3 = this._animator.GetNextAnimatorStateInfo(layerIndex:  ((this.getLayerInfoForAnimationName(anim:  animationName)) == 0) ? this.defaultCustomAnimationLayer : val_1.LayerIndex);
            val_0.m_Loop = val_4;
            val_0.m_Name = val_6;
            val_0.m_Length = val_5;
            return val_0;
        }
        public UnityEngine.AnimatorStateInfo GetAnimationStateInfo(string animationName)
        {
            if(this._animator != null)
            {
                    return this._animator.GetCurrentAnimatorStateInfo(layerIndex:  ((this.getLayerInfoForAnimationName(anim:  animationName)) == 0) ? this.defaultCustomAnimationLayer : val_1.LayerIndex);
            }
            
            return this._animator.GetCurrentAnimatorStateInfo(layerIndex:  ((this.getLayerInfoForAnimationName(anim:  animationName)) == 0) ? this.defaultCustomAnimationLayer : val_1.LayerIndex);
        }
        public UnityEngine.AnimatorClipInfo[] GetNextClipInfos(string animationName)
        {
            if(this._animator != null)
            {
                    return this._animator.GetNextAnimatorClipInfo(layerIndex:  ((this.getLayerInfoForAnimationName(anim:  animationName)) == 0) ? this.defaultCustomAnimationLayer : val_1.LayerIndex);
            }
            
            return this._animator.GetNextAnimatorClipInfo(layerIndex:  ((this.getLayerInfoForAnimationName(anim:  animationName)) == 0) ? this.defaultCustomAnimationLayer : val_1.LayerIndex);
        }
        public override void PlayAnimationQueued(string animName)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override void SetMoveParameters(float speed, bool isGrounded)
        {
            float val_9 = speed / speed;
            if((System.Math.Abs(this._currentMoveSpeed - val_9)) > 0.0001f)
            {
                    this._currentMoveSpeed = val_9;
            }
            
            if(0 == this._animator)
            {
                    return;
            }
            
            if(this._animator.enabled == false)
            {
                    return;
            }
            
            this._animator.SetFloat(id:  this.moveSpeedParamHash, value:  UnityEngine.Mathf.Lerp(a:  this._animator.GetFloat(id:  this.moveSpeedParamHash), b:  this._currentMoveSpeed, t:  UnityEngine.Time.deltaTime * this.movementAnimLerpSpeed));
            val_9 = this.movementAnimSpeedScale;
            this._animator.SetFloat(id:  this.moveSpeedMultiplierParamHash, value:  val_9);
            if(this.setGroundedParameter == false)
            {
                    return;
            }
            
            this._animator.SetBool(id:  this.isGroundedParamHash, value:  isGrounded);
        }
        private void OnEnable()
        {
            if(0 == this._animator)
            {
                    return;
            }
            
            this.initializeAnimator();
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.enabled = true;
            if(0 == this._animator)
            {
                    return;
            }
            
            this._animator.enabled = true;
        }
        public override void OnPushedToPool()
        {
            TzarGames.Common.StateMachineBehaviourEventHandler[] val_6;
            var val_7;
            this.OnPushedToPool();
            this.enabled = false;
            this.enableAnimation = true;
            if(0 != this.animEventHandler)
            {
                    System.Action<UnityEngine.AnimationEvent> val_2 = new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::AnimEventHandlerOnOnAnimationEvent(UnityEngine.AnimationEvent animationEvent));
                this.animEventHandler.remove_OnAnimationEvent(value:  val_2);
                this.animEventHandler = 0;
            }
            
            val_6 = this.stateHandlers;
            if(val_6 == null)
            {
                goto label_5;
            }
            
            val_7 = 0;
            goto label_6;
            label_13:
            val_6.remove_OnExitFromState(value:  val_2);
            val_6 = this.stateHandlers;
            val_7 = 1;
            label_6:
            if(val_7 >= this.stateHandlers.Length)
            {
                goto label_8;
            }
            
            System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32> val_3 = null;
            TzarGames.Common.StateMachineBehaviourEventHandler val_6 = this.stateHandlers[1];
            val_3 = new System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::HandlerOnOnEnterToState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex));
            val_6.remove_OnEnterToState(value:  val_3);
            System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32> val_4 = new System.Action<UnityEngine.Animator, UnityEngine.AnimatorStateInfo, System.Int32>(object:  this, method:  System.Void TzarGames.TzarHero.TH_CharacterAnim::HandlerOnOnExitFromState(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo animatorStateInfo, int layerIndex));
            if(val_6 != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_8:
            this.stateHandlers = 0;
            label_5:
            this.customAnimFinishedCallbacks.Clear();
            this.layersToPlayingAnims.Clear();
            if(0 == this._animator)
            {
                    return;
            }
            
            this._animator.enabled = false;
        }
    
    }

}
