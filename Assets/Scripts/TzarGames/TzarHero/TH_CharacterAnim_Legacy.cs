using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_CharacterAnim_Legacy : CharacterAnimationBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Animation _animation;
        [UnityEngine.SerializeField]
        private bool syncSlowAttackSpeed;
        public string IdleAnimationName;
        public string RunAnimationName;
        public string[] AttackAnimationNames;
        public string[] HitAnimationNames;
        public float attackCrossFadeLenght;
        public float attackEndFadeLength;
        private float moveSpeed;
        private int currentAttackAnimNum;
        private float attackTimeDuration;
        
        // Methods
        public TH_CharacterAnim_Legacy()
        {
            this.IdleAnimationName = "Idle";
            this.attackTimeDuration = 1f;
            this.attackCrossFadeLenght = 0.2f;
            this.attackEndFadeLength = 0.5f;
            this.RunAnimationName = "Run";
        }
        protected override void Awake()
        {
            this.Awake();
            bool val_1 = TzarGames.GameFramework.ApplicationManager.IsBatchMode;
        }
        private void Start()
        {
            if(TzarGames.GameFramework.ApplicationManager.IsBatchMode == false)
            {
                    return;
            }
            
            this.enabled = false;
        }
        private void Update()
        {
            if(this.CurrentState == null)
            {
                
            }
        
        }
        private void CrossfadeMovement(float fadeLength)
        {
            UnityEngine.Animation val_3;
            string val_4;
            val_3 = this._animation;
            float val_1 = this.moveSpeed / S2;
            if(val_1 >= 0.1f)
            {
                goto label_0;
            }
            
            val_4 = this.IdleAnimationName;
            if(val_3 != null)
            {
                goto label_5;
            }
            
            goto label_2;
            label_0:
            val_3.Item[this.RunAnimationName].speed = val_1;
            val_3 = this._animation;
            val_4 = this.RunAnimationName;
            if(val_3 != null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3.CrossFade(animation:  val_4, fadeLength:  fadeLength);
        }
        public override void SetMoveParameters(float speed, bool isGrounded)
        {
            this.moveSpeed = speed;
        }
        public override void PlayAttackAnimation(int animNumber, float timeDuration)
        {
            if(this.AttackAnimationNames.Length > animNumber)
            {
                    this.currentAttackAnimNum = animNumber;
            }
            else
            {
                    int val_2 = this.AttackAnimationNames.Length;
                val_2 = val_2 - 1;
                this.currentAttackAnimNum = val_2;
            }
            
            this.attackTimeDuration = timeDuration;
            bool val_1 = this.GotoState<Attack>(stateData:  0);
        }
        public override void CancelAttackAnim()
        {
            bool val_1 = this.GotoState<Moving>(stateData:  0);
        }
        public override void SetAttackSpeed(float speed)
        {
        
        }
        public override void EnableAnimation(bool enable)
        {
            enable = enable;
            this._animation.enabled = enable;
        }
        public void PlayHitAnimation()
        {
            string val_2 = this.HitAnimationNames[(long)UnityEngine.Random.Range(min:  0, max:  0)];
            goto typeof(TzarGames.TzarHero.TH_CharacterAnim_Legacy).__il2cppRuntimeField_230;
        }
        public override void PlayAnimationOnce(string animName, System.Action finishedCallback)
        {
            typeof(TH_CharacterAnim_Legacy.CustomAnimData).__il2cppRuntimeField_18 = 1;
            typeof(TH_CharacterAnim_Legacy.CustomAnimData).__il2cppRuntimeField_10 = animName;
            bool val_2 = this.GotoState<CustomAnimation>(stateData:  new System.Object());
        }
        public override void PlayAnimation(string animName, bool play)
        {
            var val_3;
            object val_4;
            var val_5;
            val_3 = play;
            if(val_3 != false)
            {
                    object val_1 = null;
                val_3 = val_1;
                val_1 = new System.Object();
                typeof(TH_CharacterAnim_Legacy.CustomAnimData).__il2cppRuntimeField_18 = 0;
                typeof(TH_CharacterAnim_Legacy.CustomAnimData).__il2cppRuntimeField_10 = animName;
                val_4 = val_3;
                val_5 = public System.Boolean StateMachine::GotoState<CustomAnimation>(object stateData);
            }
            else
            {
                    val_4 = 0;
                val_5 = public System.Boolean StateMachine::GotoState<Moving>(object stateData);
            }
            
            bool val_2 = this.GotoState<Moving>(stateData:  val_4);
        }
        public override void PlayAnimationQueued(string animName)
        {
            UnityEngine.AnimationState val_1 = this._animation.PlayQueued(animation:  animName);
        }
        public override void ResetToDefaultAnimation()
        {
            this.ResetToDefaultState();
        }
    
    }

}
