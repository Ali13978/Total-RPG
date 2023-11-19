using UnityEngine;
protected class TH_Character.RangeAttack : TH_Character.SimpleAttack
{
    // Properties
    protected override TzarGames.GameFramework.IWeaponObject weaponObject { get; set; }
    
    // Methods
    public TH_Character.RangeAttack()
    {
        val_1 = new TH_Character.CharacterBaseState();
    }
    protected override TzarGames.GameFramework.IWeaponObject get_weaponObject()
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(val_1.rangeCombatSystem != null)
        {
                return (TzarGames.GameFramework.IWeaponObject)val_1.rangeCombatSystem.WeaponObject;
        }
        
        return (TzarGames.GameFramework.IWeaponObject)val_1.rangeCombatSystem.WeaponObject;
    }
    protected override void set_weaponObject(TzarGames.GameFramework.IWeaponObject value)
    {
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        val_1.rangeCombatSystem.WeaponObject = value;
    }
    protected override void startAttack()
    {
        UnityEngine.Vector3 val_68;
        System.Delegate val_69;
        var val_70;
        System.Object[] val_71;
        TzarGames.GameFramework.NetworkViewBase val_72;
        TzarGames.GameFramework.NetworkViewBase val_73;
        UnityEngine.Object val_74;
        var val_75;
        this.startAttack();
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        if(0 != val_1.targetObject)
        {
                TzarGames.TzarHero.TH_Character val_3 = this.CharacterOwner;
            if(val_3.targetObject != null)
        {
                val_68 = 1152921504921595904;
        }
        
        }
        
        TzarGames.TzarHero.TH_Character val_4 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_7 = this.CharacterOwner;
        UnityEngine.GameObject val_9 = val_4.rangeCombatSystem.Use(weaponTemplate:  this.CharacterOwner.GetActiveWeaponTemplate(slot:  0), speedScale:  val_7.characterTemplateInstance.AttackSpeed, attackDirection:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, projectileFireSource:  0, target:  0, autoLaunch:  true);
        val_69 = this.CharacterOwner;
        if(this.CharacterOwner.OnServer == false)
        {
            goto label_16;
        }
        
        val_69 = val_69.PlayerOwner;
        if(val_69.itsMe == false)
        {
            goto label_18;
        }
        
        if(0 != val_9)
        {
            goto label_21;
        }
        
        TzarGames.TzarHero.TH_Character val_18 = this.CharacterOwner;
        if(0 == val_18.targetObject)
        {
            goto label_29;
        }
        
        TzarGames.TzarHero.TH_Character val_20 = this.CharacterOwner;
        if(0 == val_20.targetObject)
        {
            goto label_29;
        }
        
        val_70 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3> val_24 = null;
        val_69 = val_24;
        val_24 = new TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_rangeAttack_object(uint id, UnityEngine.Vector3 attackDir));
        val_71 = null;
        TzarGames.TzarHero.TH_Character val_25 = this.CharacterOwner;
        val_25.targetObject.generateId();
        goto label_32;
        label_16:
        if(((val_69.OnClient == false) || (this.CharacterOwner.PlayerOwner == null)) || (this.CharacterOwner.PlayerOwner.itsMe == false))
        {
            goto label_57;
        }
        
        TzarGames.TzarHero.TH_Character val_32 = this.CharacterOwner;
        val_70 = this.CharacterOwner;
        TzarGames.TzarHero.TH_Character val_35 = this.CharacterOwner;
        if(0 != val_32.targetObject)
        {
            goto label_42;
        }
        
        TzarGames.GameFramework.RPCall<UnityEngine.Vector3> val_36 = null;
        val_69 = val_36;
        val_36 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  val_35, method:  System.Void TzarGames.TzarHero.TH_Character::server_rangeAttack(UnityEngine.Vector3 attackDir));
        val_71 = null;
        val_68 = 1152921505024093152;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_68;
        if(val_70 != null)
        {
            goto label_122;
        }
        
        goto label_48;
        label_18:
        if(0 == val_9)
        {
            goto label_51;
        }
        
        val_73 = val_9.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
        goto label_65;
        label_21:
        val_74 = val_9.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
        if(0 == val_74)
        {
            goto label_57;
        }
        
        TzarGames.TzarHero.TH_Character val_41 = this.CharacterOwner;
        if(0 == val_41.targetObject)
        {
            goto label_65;
        }
        
        TzarGames.TzarHero.TH_Character val_43 = this.CharacterOwner;
        if(0 == val_43.targetObject)
        {
            goto label_65;
        }
        
        val_70 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkViewID, System.UInt32, UnityEngine.Vector3> val_47 = null;
        val_69 = val_47;
        val_47 = new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkViewID, System.UInt32, UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_rangeAttack_viewid_object(TzarGames.GameFramework.NetworkViewID viewId, uint id, UnityEngine.Vector3 attackDir));
        val_71 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_74;
        TzarGames.TzarHero.TH_Character val_48 = this.CharacterOwner;
        val_48.targetObject.generateId();
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_48.targetObject._id;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        val_68 = 1152921504607645696;
        typeof(System.Object[]).__il2cppRuntimeField_30 = val_68;
        if(val_70 != null)
        {
            goto label_102;
        }
        
        goto label_91;
        label_65:
        val_70 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkViewID, UnityEngine.Vector3> val_51 = null;
        val_69 = val_51;
        val_51 = new TzarGames.GameFramework.RPCall<TzarGames.GameFramework.NetworkViewID, UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_rangeAttack_viewid(TzarGames.GameFramework.NetworkViewID viewId, UnityEngine.Vector3 attackDir));
        val_71 = null;
        val_72 = val_73;
        label_32:
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_72;
        val_68 = typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_180;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_68;
        if(val_70 != null)
        {
            goto label_102;
        }
        
        goto label_91;
        label_51:
        val_70 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<UnityEngine.Vector3> val_54 = null;
        val_69 = val_54;
        val_54 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_rangeAttack(UnityEngine.Vector3 attackDir));
        val_71 = null;
        val_68 = 1152921505024093152;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_68;
        val_75 = 4;
        goto label_103;
        label_29:
        val_70 = this.CharacterOwner;
        TzarGames.GameFramework.RPCall<UnityEngine.Vector3> val_57 = null;
        val_69 = val_57;
        val_57 = new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_rangeAttack(UnityEngine.Vector3 attackDir));
        val_71 = null;
        val_68 = 1152921505024093152;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_68;
        if(val_70 != null)
        {
            goto label_102;
        }
        
        label_91:
        label_102:
        val_75 = 2;
        goto label_103;
        label_42:
        TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3> val_64 = null;
        val_69 = val_64;
        val_64 = new TzarGames.GameFramework.RPCall<System.UInt32, UnityEngine.Vector3>(object:  val_35, method:  System.Void TzarGames.TzarHero.TH_Character::server_rangeAttack_object(uint id, UnityEngine.Vector3 attackDir));
        val_71 = null;
        TzarGames.TzarHero.TH_Character val_65 = this.CharacterOwner;
        val_65.targetObject.generateId();
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_65.targetObject._id;
        typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
        val_68 = 1152921504607645696;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_68;
        if(val_70 != null)
        {
            goto label_122;
        }
        
        label_48:
        label_122:
        val_75 = 5;
        label_103:
        val_70.RPC(methodDelegate:  val_69, rpcMode:  5, parameters:  val_71);
        label_57:
        TzarGames.TzarHero.TH_Character val_66 = this.CharacterOwner;
        mem[1152921511558319480] = val_66.targetObject;
    }
    public override void Update()
    {
        this.Update();
        TzarGames.TzarHero.TH_Character val_1 = this.CharacterOwner;
        UnityEngine.Vector3 val_3 = this.CharacterOwner.GetDesiredRotationDirection();
        val_1.rangeCombatSystem.ActualAttackDirection = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }

}
