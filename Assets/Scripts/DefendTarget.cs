using UnityEngine;
private class CharacterAI.DefendTarget : CharacterAI.BaseState
{
    // Methods
    public CharacterAI.DefendTarget()
    {
    
    }
    private bool hasObstacle(TzarGames.TzarHero.TH_Character target)
    {
        TzarGames.TzarHero.CharacterAI val_1 = this.AI;
        UnityEngine.Vector3 val_2 = val_1.controlledCharacter.GroundPivotPosition;
        UnityEngine.Vector3 val_3 = target.GroundPivotPosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_1.controlledCharacter.AttackHeightOffset);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        TzarGames.TzarHero.CharacterAI val_10 = this.AI;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        TzarGames.TzarHero.CharacterAI val_12 = this.AI;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_12.obstacleCheckRadius);
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        TzarGames.TzarHero.CharacterAI val_15 = this.AI;
        int val_16 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
        float val_19 = val_10.obstacleCheckRadius;
        val_19 = val_14.x - val_19;
        return (bool)UnityEngine.Physics.BoxCast(center:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, halfExtents:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, direction:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.z, z = val_14.x}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, orientation:  new UnityEngine.Quaternion() {x = val_14.z, y = val_19}, maxDistance:  val_13.y, layerMask:  -1727165248);
    }
    public override void Update()
    {
        UnityEngine.Object val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        this.Update();
        val_32 = 1152921504721543168;
        if(0 == val_1.controlledCharacter)
        {
                return;
        }
        
        if(val_1.controlledCharacter.IsUsingSkill() == true)
        {
                return;
        }
        
        if(0 == (val_1.<Target>k__BackingField))
        {
                return;
        }
        
        UnityEngine.Vector3 val_8 = val_1.<Target>k__BackingField.GroundPivotPosition;
        val_33 = val_8.z;
        UnityEngine.Vector3 val_9 = val_1.controlledCharacter.GroundPivotPosition;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_33}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_34 = val_10.x;
        if(this.AI != null)
        {
                val_35 = val_1.maxDefendDistance;
            val_36 = val_35;
        }
        else
        {
                val_36 = 0f;
            val_35 = 0f;
        }
        
        val_35 = val_36 * val_35;
        if(val_34 >= val_35)
        {
            goto label_17;
        }
        
        val_32 = val_1.controlledCharacter.TryFindTargetForAttack(radius:  val_1.enemyDetectRadius);
        if(0 == val_32)
        {
            goto label_23;
        }
        
        val_1.controlledCharacter.Target = val_32;
        if((val_1.checkObstacles == false) || ((this.hasObstacle(target:  val_32)) == false))
        {
            goto label_26;
        }
        
        if(val_1.controlledCharacter == null)
        {
            goto label_27;
        }
        
        val_1.controlledCharacter.StopAttack();
        goto label_28;
        label_17:
        if(val_1.controlledCharacter.IsAttacking != false)
        {
                val_1.controlledCharacter.StopAttack();
        }
        
        if(val_1.controlledCharacter.IsFollowing == true)
        {
                return;
        }
        
        val_34 = val_1.followRadius;
        label_58:
        val_1.controlledCharacter.Follow(character:  val_1.<Target>k__BackingField, attack:  false, distance:  val_34);
        return;
        label_23:
        if(val_1.controlledCharacter.IsAttacking == true)
        {
                return;
        }
        
        float val_32 = val_1.followRadius;
        val_32 = val_32 * val_32;
        if(val_34 < val_32)
        {
                return;
        }
        
        if(val_1.controlledCharacter.IsAttacking != false)
        {
                val_1.controlledCharacter.StopAttack();
        }
        
        if(val_1.controlledCharacter.IsFollowing == true)
        {
                return;
        }
        
        if(val_1.controlledCharacter == null)
        {
            goto label_46;
        }
        
        val_37 = val_1.controlledCharacter.MinDistanceToWaypoint;
        goto label_47;
        label_26:
        val_1.controlledCharacter.AttackCharacter(character:  val_32, ignoreAttackRangeCheck:  false);
        return;
        label_27:
        0.StopAttack();
        label_28:
        val_34 = val_1.controlledCharacter.MinDistanceToWaypoint;
        if((TzarGames.TzarHero.TH_InteractiveObject.IsObjectsTouching(firstObject:  0, secondObject:  val_1.controlledCharacter, allowedDistanceError:  val_34)) == false)
        {
            goto label_53;
        }
        
        if(val_1.controlledCharacter.IsMovingOnPath == true)
        {
                return;
        }
        
        if(val_1.controlledCharacter == null)
        {
            goto label_55;
        }
        
        val_34 = val_1.controlledCharacter.GetAttackRadius();
        goto label_56;
        label_53:
        val_1.controlledCharacter.GoToObject(interObject:  val_32, withinAttackRange:  false);
        return;
        label_46:
        float val_28 = 0.MinDistanceToWaypoint;
        val_37 = val_28;
        label_47:
        val_28 = val_1.followRadius - val_37;
        goto label_58;
        label_55:
        val_34 = 0.GetAttackRadius();
        label_56:
        if((val_1.controlledCharacter.TryGetFreePositionNearObject(interObject:  val_32, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, offset:  val_34, numberOfChecks:  1, angleStep:  30f)) == false)
        {
                return;
        }
        
        val_34 = 0f;
        val_33 = 0f;
        bool val_31 = val_1.controlledCharacter.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = val_34, y = 0f, z = val_33}, reachPositionHandler:  0, stoppingDistance:  0f);
    }

}
