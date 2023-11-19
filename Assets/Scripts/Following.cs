using UnityEngine;
private class TH_Character.Following : TH_Character.Moving
{
    // Fields
    private const float positionChangeSquaredTreshold = 0.04;
    private UnityEngine.Vector3 lastFollowTargetPosition;
    private float offsetToFollowingObject;
    private float distance;
    private bool invokingCheck1;
    private bool invokingCheck2;
    private float check1_invokeTime;
    private float check2_invokeTime;
    
    // Properties
    public float checkFollowingRate1 { get; }
    public float checkFollowingRate2 { get; }
    
    // Methods
    public TH_Character.Following()
    {
        val_1 = new TH_Character.CharacterBaseState();
    }
    public float get_checkFollowingRate1()
    {
        if(this.CharacterOwner != null)
        {
                return (float)val_1.checkFollowingRate1;
        }
        
        return (float)val_1.checkFollowingRate1;
    }
    public float get_checkFollowingRate2()
    {
        if(this.CharacterOwner != null)
        {
                return (float)val_1.checkFollowingRate2;
        }
        
        return (float)val_1.checkFollowingRate2;
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        this.OnStateBegin(prevState:  prevState);
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.distance = mem[34807808];
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        UnityEngine.Vector3 val_3 = val_2.targetObject.cachedTransform.position;
        this.lastFollowTargetPosition = val_3;
        mem[1152921511559219412] = val_3.y;
        mem[1152921511559219416] = val_3.z;
        TzarGames.TzarHero.TH_Character val_4 = this.CharacterOwner;
        if(val_4.bFollowingToAttack != false)
        {
                this.CharacterOwner.Invoke(methodName:  "checkTarget", time:  0.1f);
        }
        
        this.offsetToFollowingObject = 0f;
        this.checkFollowing();
    }
    public override void Update()
    {
        float val_7;
        if(this.invokingCheck1 != false)
        {
                val_7 = UnityEngine.Time.time;
            TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
            if((val_7 - this.check1_invokeTime) >= val_2.checkFollowingRate1)
        {
                this.invokingCheck1 = false;
            this.checkFollowing();
        }
        
        }
        
        if(this.invokingCheck2 != false)
        {
                val_7 = UnityEngine.Time.time;
            TzarGames.TzarHero.TH_Character val_5 = this.CharacterOwner;
            if((val_7 - this.check2_invokeTime) >= val_5.checkFollowingRate2)
        {
                this.invokingCheck2 = false;
            this.checkFollowing2();
        }
        
        }
        
        this.Update();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        this.OnStateEnd(nextState:  nextState);
        if((this.invokingCheck1 & 255) != false)
        {
                this.invokingCheck1 = false;
        }
        
        if(this.invokingCheck1 >= true)
        {
                this.invokingCheck2 = false;
        }
        
        if((this.CharacterOwner.IsInvoking(methodName:  "checkTarget")) != false)
        {
                this.CharacterOwner.CancelInvoke(methodName:  "checkTarget");
        }
        
        TzarGames.TzarHero.TH_Character val_5 = this.CharacterOwner;
        val_5.bFollowingToAttack = false;
        this.CharacterOwner.StopMove();
    }
    public override void StopMove()
    {
    
    }
    public override void OnPathCalculationComplete(bool success)
    {
        if(success != false)
        {
                if((this.invokingCheck1 & 255) != false)
        {
                this.invokingCheck1 = false;
        }
        
            if(this.invokingCheck1 > true)
        {
                return;
        }
        
            this.invokingCheck2 = true;
            this.check2_invokeTime = UnityEngine.Time.time;
            return;
        }
        
        if(this.invokingCheck2 != false)
        {
                this.invokingCheck2 = false;
        }
        
        if(this.invokingCheck1 == true)
        {
                return;
        }
        
        this.invokingCheck1 = true;
        this.check1_invokeTime = UnityEngine.Time.time;
    }
    public override void OnStucked()
    {
        if(this.invokingCheck2 != false)
        {
                this.invokingCheck2 = false;
        }
        
        if(this.invokingCheck1 == true)
        {
                return;
        }
        
        this.invokingCheck1 = true;
        this.check1_invokeTime = UnityEngine.Time.time;
    }
    private void checkFollowing()
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if((this.isObjectValidForFollow(obj:  val_1.targetObject)) == false)
        {
            goto label_1;
        }
        
        if(this.isFollowedObjectReached() == false)
        {
            goto label_2;
        }
        
        bool val_5 = this.CharacterOwner.isObjectGoalReached();
        TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
        UnityEngine.Vector3 val_8 = val_7.targetObject.cachedTransform.position;
        this.CharacterOwner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        if(this.invokingCheck2 != false)
        {
                this.invokingCheck2 = false;
        }
        
        if(this.invokingCheck1 == true)
        {
                return;
        }
        
        this.invokingCheck1 = true;
        this.check1_invokeTime = UnityEngine.Time.time;
        return;
        label_1:
        this.resetFollowing();
        return;
        label_2:
        this.findFollowPath();
    }
    private void findFollowPath()
    {
        var val_10;
        float val_11;
        float val_12;
        val_10 = this;
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        val_11 = this.offsetToFollowingObject + this.distance;
        if((this.CharacterOwner.TryGetFreePositionNearObject(interObject:  val_2.targetObject, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, offset:  val_11, numberOfChecks:  2, angleStep:  30f)) != false)
        {
                val_12 = 0f;
            val_11 = val_12;
            if((this.CharacterOwner.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = val_12, y = 0f, z = 0f}, reachPositionHandler:  0, stoppingDistance:  null)) != false)
        {
                this.offsetToFollowingObject = 0f;
            val_10 = this.CharacterOwner;
            val_6.bGoingToInterObject = true;
            return;
        }
        
        }
        
        val_12 = this.offsetToFollowingObject;
        TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
        val_11 = val_12 + val_11;
        this.offsetToFollowingObject = val_11;
        if(this.invokingCheck2 != false)
        {
                this.invokingCheck2 = false;
        }
        
        if(this.invokingCheck1 == true)
        {
                return;
        }
        
        this.invokingCheck1 = true;
        this.check1_invokeTime = UnityEngine.Time.time;
    }
    private bool isFollowingEndPointFree()
    {
        var val_11;
        var val_12;
        var val_13;
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_11 = 3;
        val_12 = val_1.pathResult;
        TzarGames.GameFramework.IPathResult val_12 = val_1.pathResult;
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        val_12 = val_12 - 1;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_11 = 2;
        val_13 = val_3.pathResult;
        TzarGames.TzarHero.TH_Character val_5 = this.CharacterOwner;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  V0.16B);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        bool val_10 = this.CharacterOwner.IsSphereContainsOtherColliders(center:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, radius:  V0.16B, layerMask:  2147483647);
        val_10 = (~val_10) & 1;
        return (bool)val_10;
    }
    private bool isTargetPositionChanged()
    {
        var val_6;
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        UnityEngine.Vector3 val_2 = val_1.targetObject.cachedTransform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.lastFollowTargetPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        if(val_3.x > 0.04f)
        {
                TzarGames.TzarHero.TH_Character val_4 = this.CharacterOwner;
            UnityEngine.Vector3 val_5 = val_4.targetObject.cachedTransform.position;
            val_6 = 1;
            this.lastFollowTargetPosition = val_5;
            mem[1152921511560497748] = val_5.y;
            mem[1152921511560497752] = val_5.z;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private bool isObjectValidForFollow(TzarGames.TzarHero.TH_InteractiveObject obj)
    {
        var val_4;
        var val_5;
        val_4 = this;
        if((0 == obj) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false))
        {
            goto label_10;
        }
        
        if(obj == null)
        {
            goto label_12;
        }
        
        if(null != 0)
        {
            goto label_10;
        }
        
        val_4 = this.CharacterOwner;
        if(val_3._characterIsDead == false)
        {
            goto label_12;
        }
        
        label_10:
        val_5 = 0;
        return (bool)val_5;
        label_12:
        val_5 = 1;
        return (bool)val_5;
    }
    private bool isFollowedObjectReached()
    {
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        return TzarGames.TzarHero.TH_InteractiveObject.IsObjectsTouching(firstObject:  null, secondObject:  this.CharacterOwner, allowedDistanceError:  val_3._minDistanceToWaypoint + this.distance);
    }
    private bool isPathReady()
    {
        var val_4;
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1.pathResult == null)
        {
                return false;
        }
        
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = val_2.pathResult;
    }
    private void checkFollowing2()
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if((this.isObjectValidForFollow(obj:  val_1.targetObject)) == false)
        {
            goto label_1;
        }
        
        if(this.isFollowedObjectReached() == false)
        {
            goto label_2;
        }
        
        bool val_5 = this.CharacterOwner.isObjectGoalReached();
        TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
        UnityEngine.Vector3 val_8 = val_7.targetObject.cachedTransform.position;
        this.CharacterOwner.SetDesiredRotationToPosition(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        TzarGames.TzarHero.TH_Character val_9 = this.CharacterOwner;
        val_9.currentWaypoint = 0;
        val_9.pathResult = 0;
        if(this.invokingCheck2 != false)
        {
                this.invokingCheck2 = false;
        }
        
        if(this.invokingCheck1 == true)
        {
                return;
        }
        
        this.invokingCheck1 = true;
        this.check1_invokeTime = UnityEngine.Time.time;
        return;
        label_1:
        this.resetFollowing();
        return;
        label_2:
        if(((this.isTargetPositionChanged() == true) || (this.isPathReady() == false)) || (this.isFollowingEndPointFree() == false))
        {
            goto label_14;
        }
        
        TzarGames.TzarHero.TH_Character val_16 = this.CharacterOwner;
        if(val_16.bIsStucked == false)
        {
            goto label_16;
        }
        
        label_14:
        this.findFollowPath();
        return;
        label_16:
        if((this.invokingCheck1 & 255) != false)
        {
                this.invokingCheck1 = false;
        }
        
        if(this.invokingCheck1 > true)
        {
                return;
        }
        
        this.invokingCheck2 = true;
        this.check2_invokeTime = UnityEngine.Time.time;
    }
    private void invokeCheckFollowing2()
    {
        if((this.invokingCheck1 & 255) != false)
        {
                this.invokingCheck1 = false;
        }
        
        if(this.invokingCheck1 > true)
        {
                return;
        }
        
        this.invokingCheck2 = true;
        this.check2_invokeTime = UnityEngine.Time.time;
    }
    private void invokeCheckFollowing()
    {
        if(this.invokingCheck2 != false)
        {
                this.invokingCheck2 = false;
        }
        
        if(this.invokingCheck1 == true)
        {
                return;
        }
        
        this.invokingCheck1 = true;
        this.check1_invokeTime = UnityEngine.Time.time;
    }
    private void cancelCheckFollowing()
    {
        if(this.invokingCheck1 == false)
        {
                return;
        }
        
        this.invokingCheck1 = false;
    }
    private void cancelCheckFollowing2()
    {
        if(this.invokingCheck2 == false)
        {
                return;
        }
        
        this.invokingCheck2 = false;
    }
    private void resetFollowing()
    {
        this.ForceGotoState<Moving>(stateData:  0);
    }

}
