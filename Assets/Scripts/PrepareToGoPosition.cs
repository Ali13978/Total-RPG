using UnityEngine;
private class TH_PlayerCharacter.PrepareToGoPosition : TH_Character.CharacterBaseState
{
    // Methods
    public TH_PlayerCharacter.PrepareToGoPosition()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        var val_8;
        this.OnStateBegin(prevState:  prevState);
        StateMachine val_2 = this.Owner;
        if(val_2 != null)
        {
                val_8 = null;
        }
        
        val_8 = null;
        var val_4 = (((StateMachine.__il2cppRuntimeField_typeHierarchy + TzarGames.TzarHero.TH_PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_8) ? (val_2) : 0;
        bool val_5 = this.CharacterOwner.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = (StateMachine.__il2cppRuntimeField_typeHierarchy + TzarGames.TzarHero.TH_PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_8 ? val_2 : 0 + 832, y = (StateMachine.__il2cppRuntimeField_typeHierarchy + TzarGames.TzarHero.TH_PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_8 ? val_2 : 0 + 836, z = (StateMachine.__il2cppRuntimeField_typeHierarchy + TzarGames.TzarHero.TH_PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_8 ? val_2 : 0 + 840}, reachPositionHandler:  0, stoppingDistance:  null);
        bool val_7 = this.CharacterOwner.GotoStateLate<Moving>();
        this.GotoNextOrDefaultState();
    }

}
