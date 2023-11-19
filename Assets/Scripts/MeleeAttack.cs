using UnityEngine;
protected class TH_Character.MeleeAttack : TH_Character.SimpleAttack
{
    // Properties
    protected override TzarGames.GameFramework.IWeaponObject weaponObject { get; set; }
    
    // Methods
    public TH_Character.MeleeAttack()
    {
        val_1 = new TH_Character.CharacterBaseState();
    }
    protected override TzarGames.GameFramework.IWeaponObject get_weaponObject()
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1.meleeCombatSystem != null)
        {
                return (TzarGames.GameFramework.IWeaponObject)val_1.meleeCombatSystem.WeaponObject;
        }
        
        return (TzarGames.GameFramework.IWeaponObject)val_1.meleeCombatSystem.WeaponObject;
    }
    protected override void set_weaponObject(TzarGames.GameFramework.IWeaponObject value)
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        val_1.meleeCombatSystem.WeaponObject = value;
    }
    protected override void startAttack()
    {
        UnityEngine.Vector3 val_48;
        System.Delegate val_49;
        var val_50;
        System.Object[] val_51;
        var val_52;
        this.startAttack();
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        val_48 = 1152921504721543168;
        if(0 != val_1.targetObject)
        {
                TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
        }
        
        TzarGames.TzarHero.TH_Character val_4 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
        val_4.meleeCombatSystem.UseOnCharacter(target:  0, weaponTemplate:  this.CharacterOwner.GetActiveWeaponTemplate(slot:  0), speedScale:  val_7.characterTemplateInstance.AttackSpeed);
        val_49 = this.CharacterOwner.OnServer;
        TzarGames.TzarHero.TH_Character val_11 = this.CharacterOwner;
        if(val_49 == false)
        {
            goto label_16;
        }
        
        val_50 = this.CharacterOwner;
        if(val_11.PlayerOwner.itsMe == false)
        {
            goto label_18;
        }
        
        if(0 == val_14.targetObject)
        {
            goto label_26;
        }
        
        TzarGames.TzarHero.TH_Character val_16 = this.CharacterOwner;
        if(0 == val_16.targetObject)
        {
            goto label_26;
        }
        
        val_50 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3> val_20 = null;
        val_49 = val_20;
        val_20 = new TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_meleeAttack_object(uint id, UnityEngine.Vector3 attackDir));
        val_51 = null;
        TzarGames.TzarHero.TH_Character val_21 = this.CharacterOwner;
        val_21.targetObject.generateId();
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_21.targetObject._id;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        val_48 = 1152921504607645696;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_48;
        if(val_50 != null)
        {
            goto label_64;
        }
        
        goto label_37;
        label_16:
        if(((val_11.OnClient == false) || (this.CharacterOwner.PlayerOwner == null)) || (this.CharacterOwner.PlayerOwner.itsMe == false))
        {
            goto label_43;
        }
        
        TzarGames.TzarHero.TH_Character val_28 = this.CharacterOwner;
        val_50 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_31 = this.CharacterOwner;
        if(0 != val_28.targetObject)
        {
            goto label_47;
        }
        
        TzarGames.GameFramework.RPCall<UnityEngine.Vector3> val_32 = null;
        val_49 = val_32;
        val_32 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  val_31, method:  System.Void TzarGames.TzarHero.TH_Character::server_meleeAttack(UnityEngine.Vector3 attackDir));
        val_51 = null;
        val_48 = 1152921505024093152;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_48;
        if(val_50 != null)
        {
            goto label_84;
        }
        
        goto label_53;
        label_18:
        TzarGames.GameFramework.RPCall<UnityEngine.Vector3> val_34 = null;
        val_49 = val_34;
        val_34 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_meleeAttack(UnityEngine.Vector3 attackDir));
        val_51 = null;
        val_48 = 1152921505024093152;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_48;
        val_52 = 4;
        goto label_65;
        label_26:
        val_50 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<UnityEngine.Vector3> val_37 = null;
        val_49 = val_37;
        val_37 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_meleeAttack(UnityEngine.Vector3 attackDir));
        val_51 = null;
        val_48 = 1152921505024093152;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_48;
        if(val_50 != null)
        {
            goto label_64;
        }
        
        label_37:
        label_64:
        val_52 = 2;
        goto label_65;
        label_47:
        TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3> val_45 = null;
        val_49 = val_45;
        val_45 = new TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3>(object:  val_31, method:  System.Void TzarGames.TzarHero.TH_Character::server_meleeAttack_object(uint id, UnityEngine.Vector3 attackDir));
        val_51 = null;
        TzarGames.TzarHero.TH_Character val_46 = this.CharacterOwner;
        val_46.targetObject.generateId();
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_46.targetObject._id;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        val_48 = 1152921504607645696;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_48;
        if(val_50 != null)
        {
            goto label_84;
        }
        
        label_53:
        label_84:
        val_52 = 5;
        label_65:
        val_50.RPC(methodDelegate:  val_49, rpcMode:  5, parameters:  val_51);
        label_43:
        TzarGames.TzarHero.TH_Character val_47 = this.CharacterOwner;
        mem[1152921511557330808] = val_47.targetObject;
    }

}
