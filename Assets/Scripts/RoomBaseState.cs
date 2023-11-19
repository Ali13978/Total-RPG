using UnityEngine;
private abstract class FinalBossLogic.RoomBaseState : FinalBossLogic.BaseState
{
    // Fields
    private TzarGames.Endless.FinalBossLogic.RoomInfo room;
    private bool isEscaping;
    private bool isReachedTeleport;
    private float maxEscapeTime;
    private float currentEscapeTime;
    
    // Methods
    protected FinalBossLogic.RoomBaseState()
    {
        this.maxEscapeTime = 3f;
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        RoomInfo val_6;
        prevState.OnStateBegin(prevState:  prevState);
        val_6 = 0;
        if(true != 0)
        {
                val_6 = true;
            val_6 = 0;
        }
        
        this.room = val_6;
        TzarGames.Endless.FinalBossLogic val_3 = this.Logic;
        val_3.bossAI.SetAiType(type:  2);
        TzarGames.Endless.FinalBossLogic val_4 = this.Logic;
        val_4.bossAI.enabled = true;
        TzarGames.Endless.FinalBossLogic val_5 = this.Logic;
        val_5.bossAI.SetDefendPoint(point:  this.room.DefendPoint);
        this.currentEscapeTime = 0f;
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        this.isEscaping = false;
    }
    public override void Update()
    {
        object val_39;
        float val_40;
        var val_41;
        val_39 = this;
        this.Update();
        if(this.isEscaping == false)
        {
            goto label_1;
        }
        
        val_40 = this.currentEscapeTime;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_40 + val_1;
        this.currentEscapeTime = val_1;
        if(val_1 < this.maxEscapeTime)
        {
                return;
        }
        
        val_39 = ???;
        val_40 = ???;
        goto typeof(FinalBossLogic.RoomBaseState).__il2cppRuntimeField_1A0;
        label_1:
        if((val_39.IsBossHealthIsLow(percent:  val_39 + 48 + 24)) == false)
        {
                return;
        }
        
        mem2[0] = 1;
        TzarGames.Endless.FinalBossLogic val_3 = val_39.Logic;
        TzarGames.TzarHero.TH_Character val_4 = val_3.bossAI.GetControlledCharacter();
        if(val_4.isDead != false)
        {
                val_39.ForceGotoState<FinalBossLogic.Final>(stateData:  0);
            return;
        }
        
        TzarGames.Endless.FinalBossLogic val_22 = val_39.Logic;
        val_22.bossAI.enabled = false;
        TzarGames.Endless.FinalBossLogic val_23 = val_39.Logic;
        val_41 = 0;
        goto label_13;
        label_18:
        ???.enabled = false;
        val_41 = 1;
        label_13:
        if(val_41 >= val_24.Length)
        {
            goto label_15;
        }
        
        if((val_23.bossAI.GetComponents<TzarGames.TzarHero.Skills.BasicSkillAI>()[1]) != 0)
        {
            goto label_18;
        }
        
        goto label_18;
        label_15:
        TzarGames.Endless.FinalBossLogic val_26 = val_39.Logic;
        string val_27 = val_26.bossEscapeLayer.Name;
        val_4.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  0);
        val_4.IgnoreDamage.AddModificator(owner:  val_39, value:  true, booleanOperator:  1);
        TzarGames.Endless.FinalBossLogic val_30 = val_39.Logic;
        UnityEngine.Vector3 val_31 = val_4.Position;
        UnityEngine.Quaternion val_33 = val_4.transform.rotation;
        TzarGames.GameFramework.TzarBehaviour val_34 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, rotation:  new UnityEngine.Quaternion() {x = val_33.x, y = val_33.y, z = val_33.z, w = val_33.w});
        TzarGames.Endless.FinalBossLogic val_35 = val_39.Logic;
        val_35.illusions.Add(item:  val_34);
        val_34.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  val_39, method:  System.Void FinalBossLogic.RoomBaseState::Illusion_OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)));
        TzarGames.Endless.FinalBossLogic val_37 = val_39.Logic;
        val_37.mover.MoveCharacter(ch:  val_4, position:  val_39 + 48 + 32, callback:  new System.Action<System.Boolean>(object:  val_39, method:  System.Void FinalBossLogic.RoomBaseState::onMoveComplete(bool success)));
    }
    private void Illusion_OnCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
    {
        TzarGames.Endless.FinalBossLogic val_1 = this.Logic;
        bool val_2 = val_1.illusions.Remove(item:  deadEventData.Victim);
    }
    private void onMoveComplete(bool success)
    {
        TzarGames.Endless.FinalBossLogic val_1 = this.Logic;
        if(success == true)
        {
                return;
        }
        
        if((this.isEscaping & 255) == false)
        {
                return;
        }
        
        if(this.isEscaping > true)
        {
                return;
        }
        
        TzarGames.Endless.FinalBossLogic val_5 = this.Logic;
        val_5.mover.MoveCharacter(ch:  val_1.bossAI.GetControlledCharacter(), position:  this.room.EscapePoint, callback:  new System.Action<System.Boolean>(object:  this, method:  System.Void FinalBossLogic.RoomBaseState::onMoveComplete(bool success)));
    }
    protected abstract void Next(); // 0
    internal virtual void NotifyEscapePointReached()
    {
        var val_11;
        var val_12;
        var val_13;
        this.isReachedTeleport = true;
        if(this.isEscaping == false)
        {
                return;
        }
        
        typeof(FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0).__il2cppRuntimeField_18 = this;
        TzarGames.Endless.FinalBossLogic val_2 = this.Logic;
        typeof(FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0).__il2cppRuntimeField_10 = val_2.bossAI.GetControlledCharacter();
        TzarGames.Endless.FinalBossLogic val_4 = this.Logic;
        val_4.mover.CancelMoveToPosition();
        typeof(FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0).__il2cppRuntimeField_10.StopMove();
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = 21;
        val_12 = typeof(FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0).__il2cppRuntimeField_10.Movement;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_11 = 16;
        val_13 = typeof(FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0).__il2cppRuntimeField_10.Movement;
        TzarGames.Endless.FinalBossLogic val_9 = this.Logic;
        val_9.mover.TeleportToPosition(position:  this.room.TeleportPoint, finishCallback:  new System.Action(object:  new System.Object(), method:  System.Void FinalBossLogic.RoomBaseState.<NotifyEscapePointReached>c__AnonStorey0::<>m__0()));
    }

}
