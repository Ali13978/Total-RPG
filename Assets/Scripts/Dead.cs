using UnityEngine;
[Uninterrupted]
protected class TH_Character.Dead : TH_Character.CharacterBaseState
{
    // Fields
    private int layerBeforeDeath;
    private UnityEngine.Coroutine destroyDelayRoutine;
    
    // Methods
    public TH_Character.Dead()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        object val_46;
        var val_47;
        var val_49;
        System.Object[] val_50;
        TzarGames.TzarHero.TH_Character val_51;
        float val_52;
        float val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_58;
        var val_59;
        object val_1 = null;
        val_46 = val_1;
        val_1 = new System.Object();
        this.OnStateBegin(prevState:  prevState);
        TzarGames.TzarHero.TH_Character val_2 = this.CharacterOwner;
        if(null != 0)
        {
                val_47 = val_46;
            typeof(TH_Character.Dead.<OnStateBegin>c__AnonStorey1).__il2cppRuntimeField_10 = val_2;
        }
        else
        {
                val_47 = 16;
            mem[16] = val_2;
        }
        
        val_49 = 0;
        typeof(TH_Character.Dead.<OnStateBegin>c__AnonStorey1).__il2cppRuntimeField_18 = ;
        if(val_47.OnServer != false)
        {
                if(mem[16].Connected != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40;
            this.CharacterOwner.RPC(methodDelegate:  new TzarGames.GameFramework.RPCall<UnityEngine.Vector3>(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_characterDead(UnityEngine.Vector3 force)), rpcMode:  2, parameters:  null);
            val_50 = null;
            this.CharacterOwner.CustomBufferedRPC(methodDelegate:  new TzarGames.GameFramework.RPCall_VOID(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_characterDead_post()), callForCurrentPlayers:  false, parameters:  val_50);
        }
        
        }
        
        mem2[0] = 1;
        if(null != 0)
        {
                val_51 = mem[16];
        }
        else
        {
                val_51 = mem[16];
        }
        
        val_52 = mem[(TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40];
        val_52 = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40;
        val_53 = mem[(TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 48];
        val_53 = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 48;
        bool val_12 = UnityEngine.Object.op_Inequality(x:  0, y:  val_2 + 464);
        val_2 + 208.ActualHitPoints = 0f;
        val_54 = 0;
        val_2 + 208.EnableHitPointsRegeneration = false;
        if((val_2 + 280) > 0f)
        {
                TzarGames.TzarHero.TH_Character val_15 = this.CharacterOwner;
            float val_44 = 2f;
            val_44 = val_15._destroyDelayAfterDeath + val_44;
            val_54 = 0;
            this.destroyDelayRoutine = this.CharacterOwner.StartCoroutine(routine:  this.destroyDelay(time:  (this.CharacterOwner.OnClient != true) ? (val_44) : val_15._destroyDelayAfterDeath));
        }
        
        if((val_2 + 328) == 0)
        {
            goto label_48;
        }
        
        var val_48 = val_2 + 328;
        if((val_2 + 328 + 258) == 0)
        {
            goto label_52;
        }
        
        var val_45 = val_2 + 328 + 152;
        var val_46 = 0;
        val_45 = val_45 + 8;
        label_54:
        if(((val_2 + 328 + 152 + 8) + -8) == null)
        {
            goto label_53;
        }
        
        val_46 = val_46 + 1;
        val_45 = val_45 + 16;
        if(val_46 < (val_2 + 328 + 258))
        {
            goto label_54;
        }
        
        label_52:
        val_54 = 21;
        val_55 = val_2 + 328;
        goto label_55;
        label_53:
        var val_47 = val_45;
        val_47 = val_47 + 21;
        val_48 = val_48 + val_47;
        val_55 = val_48 + 272;
        label_55:
        var val_52 = val_2 + 328;
        if((val_2 + 328 + 258) == 0)
        {
            goto label_59;
        }
        
        var val_49 = val_2 + 328 + 152;
        var val_50 = 0;
        val_49 = val_49 + 8;
        label_61:
        if(((val_2 + 328 + 152 + 8) + -8) == null)
        {
            goto label_60;
        }
        
        val_50 = val_50 + 1;
        val_49 = val_49 + 16;
        if(val_50 < (val_2 + 328 + 258))
        {
            goto label_61;
        }
        
        label_59:
        val_54 = 16;
        val_56 = val_2 + 328;
        goto label_62;
        label_60:
        var val_51 = val_49;
        val_51 = val_51 + 16;
        val_52 = val_52 + val_51;
        val_56 = val_52 + 272;
        label_62:
        label_48:
        if(((val_2 + 502) != 0) && (TzarGames.GameFramework.ApplicationManager.IsBatchMode != true))
        {
                if(val_26.Length >= 1)
        {
                var val_53 = 0;
            do
        {
            if(null != null)
        {
                1152921505864181456.isKinematic = false;
        }
        else
        {
                0.isKinematic = false;
        }
        
            1152921505864181456.useGravity = true;
            val_53 = mem[(TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40];
            val_53 = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40;
            val_52 = mem[(TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 48];
            val_52 = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 48;
            if(null != null)
        {
                1152921505864181456.AddForce(force:  new UnityEngine.Vector3() {x = val_53, y = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40 + 4, z = val_52});
        }
        else
        {
                0.AddForce(force:  new UnityEngine.Vector3() {x = val_53, y = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 40 + 4, z = val_52});
        }
        
            UnityEngine.Collider val_27 = 1152921505864181456.GetComponent<UnityEngine.Collider>();
            if(0 != val_27)
        {
                val_50 = mem[val_2 + 320];
            val_50 = val_2 + 320;
            if(0 != val_27)
        {
                val_27.enabled = true;
        }
        
        }
        
            val_53 = val_53 + 1;
        }
        while(val_26.Length != val_53);
        
        }
        
            bool val_30 = UnityEngine.Object.op_Inequality(x:  0, y:  val_2 + 352);
        }
        
        if((0 != (val_2 + 320)) && ((val_2 + 512) != 0))
        {
                val_2 + 320.enabled = false;
        }
        
        if((val_2 + 513) != 0)
        {
                this.layerBeforeDeath = mem[16].gameObject.layer;
            int val_35 = UnityEngine.LayerMask.NameToLayer(layerName:  0);
            TzarGames.Common.Utils.SetLayerRecursively(go:  0, layerNumber:  mem[16].gameObject);
        }
        
        if((val_2 + 600) != 0)
        {
                val_2 + 600.Invoke(deadEventData:  typeof(TH_Character.Dead.<OnStateBegin>c__AnonStorey1).__il2cppRuntimeField_18);
        }
        
        if(0 != ((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 32))
        {
                val_58 = mem[(TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 32];
            val_58 = (TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.TzarHero.DeadEventData.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_2 : 0 + 32;
            NotifyCharacterKill(killer:  64, victim:  mem[16]);
        }
        
        if(0 != mem[16].MyGameManager)
        {
                Event.EventFunction<TzarGames.TzarHero.ICharacterEvents> val_39 = new Event.EventFunction<TzarGames.TzarHero.ICharacterEvents>(object:  val_46, method:  System.Void TH_Character.Dead.<OnStateBegin>c__AnonStorey1::<>m__0(TzarGames.TzarHero.ICharacterEvents x));
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.Execute(functor:  0);
        }
        
        if(0 == TzarGames.GameFramework.GameManager.Instance)
        {
                return;
        }
        
        if(TzarGames.GameFramework.GameManager.Instance == null)
        {
                return;
        }
        
        TzarGames.GameFramework.GameManager val_43 = TzarGames.GameFramework.GameManager.Instance;
        if(val_43 != null)
        {
                val_59 = null;
        }
        
        if(val_43 != null)
        {
                val_59 = null;
        }
        
        NotifyCharacterDead(deadInfo:  typeof(TH_Character.Dead.<OnStateBegin>c__AnonStorey1).__il2cppRuntimeField_18);
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        var val_25;
        TzarGames.TzarHero.TH_Character val_26;
        var val_27;
        var val_28;
        var val_29;
        object val_1 = new System.Object();
        val_25 = 0;
        nextState.OnStateEnd(nextState:  nextState);
        val_26 = this.CharacterOwner;
        if(null != 0)
        {
                val_27 = val_1;
            typeof(TH_Character.Dead.<OnStateEnd>c__AnonStorey2).__il2cppRuntimeField_10 = val_26;
        }
        else
        {
                val_27 = 16;
            mem[16] = val_26;
            val_26 = mem[16];
        }
        
        if(val_26.OnServer != false)
        {
                if(val_27.Connected != false)
        {
                val_25 = 0;
            this.CharacterOwner.RemoveCustomBufferedRPC(methodDelegate:  new TzarGames.GameFramework.RPCall_VOID(object:  this.CharacterOwner, method:  System.Void TzarGames.TzarHero.TH_Character::client_characterDead_post()));
        }
        
        }
        
        mem2[0] = 0;
        if((val_2 + 328) == 0)
        {
            goto label_13;
        }
        
        var val_27 = val_2 + 328;
        if((val_2 + 328 + 258) == 0)
        {
            goto label_17;
        }
        
        var val_24 = val_2 + 328 + 152;
        var val_25 = 0;
        val_24 = val_24 + 8;
        label_19:
        if(((val_2 + 328 + 152 + 8) + -8) == null)
        {
            goto label_18;
        }
        
        val_25 = val_25 + 1;
        val_24 = val_24 + 16;
        if(val_25 < (val_2 + 328 + 258))
        {
            goto label_19;
        }
        
        label_17:
        val_25 = 16;
        val_28 = val_2 + 328;
        goto label_20;
        label_18:
        var val_26 = val_24;
        val_26 = val_26 + 16;
        val_27 = val_27 + val_26;
        val_28 = val_27 + 272;
        label_20:
        label_13:
        bool val_8 = UnityEngine.Object.op_Inequality(x:  0, y:  val_2 + 464);
        val_2 + 208.EnableHitPointsRegeneration = true;
        if(((val_2 + 502) == 0) || (TzarGames.GameFramework.ApplicationManager.IsBatchMode == true))
        {
            goto label_65;
        }
        
        val_29 = 0;
        goto label_45;
        label_60:
        val_29 = 1;
        label_45:
        if(val_29 >= val_15.Length)
        {
            goto label_47;
        }
        
        T val_28 = (0 == (val_2 + 504)) ? (mem[16] + 504) : (mem[16] + 152).GetComponentsInChildren<UnityEngine.Rigidbody>()[1];
        if(val_28 != 0)
        {
                val_28.isKinematic = true;
        }
        else
        {
                0.isKinematic = true;
        }
        
        UnityEngine.Collider val_16 = val_28.GetComponent<UnityEngine.Collider>();
        if((0 == val_16) || (0 == val_16))
        {
            goto label_60;
        }
        
        val_16.enabled = false;
        goto label_60;
        label_47:
        bool val_19 = UnityEngine.Object.op_Inequality(x:  0, y:  val_2 + 352);
        label_65:
        if((0 != (val_2 + 320)) && ((val_2 + 512) != 0))
        {
                val_2 + 320.enabled = true;
        }
        
        if((val_2 + 513) != 0)
        {
                TzarGames.Common.Utils.SetLayerRecursively(go:  0, layerNumber:  mem[16].gameObject);
        }
        
        if(this.destroyDelayRoutine != null)
        {
                this.CharacterOwner.StopCoroutine(routine:  this.destroyDelayRoutine);
            this.destroyDelayRoutine = 0;
        }
        
        if((val_2 + 648) != 0)
        {
                val_2 + 648.Invoke(character:  mem[16]);
        }
        
        Event.EventFunction<TzarGames.TzarHero.ICharacterEvents> val_23 = new Event.EventFunction<TzarGames.TzarHero.ICharacterEvents>(object:  val_1, method:  System.Void TH_Character.Dead.<OnStateEnd>c__AnonStorey2::<>m__0(TzarGames.TzarHero.ICharacterEvents x));
        TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.Execute(functor:  0);
        if(mem[16] == 0)
        {
            
        }
    
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator destroyDelay(float time)
    {
        if(null != 0)
        {
                typeof(TH_Character.Dead.<destroyDelay>c__Iterator0).__il2cppRuntimeField_10 = time;
        }
        else
        {
                mem[16] = time;
        }
        
        typeof(TH_Character.Dead.<destroyDelay>c__Iterator0).__il2cppRuntimeField_20 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }

}
