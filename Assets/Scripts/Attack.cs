using UnityEngine;
protected class TH_CharacterAnim_Legacy.Attack : TH_CharacterAnim_Legacy.CharacterAnimState
{
    // Fields
    private float attackStartTime;
    private string attackAnimName;
    private float lastAnimTime;
    private bool attackPlayFinished;
    
    // Methods
    public TH_CharacterAnim_Legacy.Attack()
    {
        null = null;
        this.attackAnimName = System.String.Empty;
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        this.attackStartTime = UnityEngine.Time.time;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_2 = this.Animation;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_3 = this.Animation;
        this.attackPlayFinished = false;
        this.lastAnimTime = 0f;
        this.attackAnimName = val_2.AttackAnimationNames[val_3.currentAttackAnimNum];
    }
    public override void Update()
    {
        this.Update();
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_2 = this.Animation;
        if((UnityEngine.Time.time - this.attackStartTime) >= 0)
        {
            goto label_2;
        }
        
        float val_4 = UnityEngine.Time.time;
        float val_21 = val_4;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_5 = this.Animation;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_6 = this.Animation;
        val_4 = val_21 - this.attackStartTime;
        val_21 = val_4 / val_5.attackTimeDuration;
        if(val_21 >= val_6.attackEndFadeLength)
        {
            goto label_5;
        }
        
        UnityEngine.AnimationState val_8 = val_7._animation.Item[this.attackAnimName];
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_10 = this.Animation;
        if(val_8.length >= val_10.attackTimeDuration)
        {
            goto label_10;
        }
        
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_11 = this.Animation;
        if(val_11.syncSlowAttackSpeed == false)
        {
            goto label_12;
        }
        
        label_10:
        float val_12 = val_8.length;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_13 = this.Animation;
        val_12 = val_12 / val_13.attackTimeDuration;
        val_8.speed = val_12;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_14 = this.Animation;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_15 = this.Animation;
        val_14._animation.CrossFade(animation:  this.attackAnimName, fadeLength:  val_15.attackCrossFadeLenght);
        return;
        label_2:
        this.ForceGotoState<Moving>(stateData:  0);
        return;
        label_5:
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_16 = this.Animation;
        this.Animation.CrossfadeMovement(fadeLength:  val_16.attackEndFadeLength);
        return;
        label_12:
        if(this.attackPlayFinished == true)
        {
                return;
        }
        
        if(val_8.time < 0)
        {
                this.attackPlayFinished = true;
            return;
        }
        
        this.lastAnimTime = val_8.time;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_19 = this.Animation;
        TzarGames.TzarHero.TH_CharacterAnim_Legacy val_20 = this.Animation;
        val_19._animation.CrossFade(animation:  this.attackAnimName, fadeLength:  val_20.attackCrossFadeLenght);
        val_8.speed = 1f;
    }

}
