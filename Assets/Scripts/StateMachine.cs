using UnityEngine;
public class StateMachine : MonoBehaviour
{
    // Fields
    private StateMachine.State _defaultState;
    private System.Collections.Generic.Dictionary<System.Type, StateMachine.State> typeToStates;
    private System.Collections.Generic.List<StateMachine.State> states;
    private StateMachine.State currentState;
    private StateMachine.State pendingState;
    private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.Type>> _registeredTypes;
    
    // Properties
    public StateMachine.State CurrentState { get; }
    public System.Collections.Generic.IEnumerable<StateMachine.State> AllStates { get; }
    
    // Methods
    public StateMachine()
    {
        this.typeToStates = new System.Collections.Generic.Dictionary<System.Type, State>();
        this.initStates();
    }
    public StateMachine.State get_CurrentState()
    {
        return (State)this.currentState;
    }
    public StateMachine.State GetDefaultState()
    {
        return (State)this._defaultState;
    }
    public System.Collections.Generic.IEnumerable<StateMachine.State> get_AllStates()
    {
        return (System.Collections.Generic.IEnumerable<State>)this.states;
    }
    private void logNoStateFoundError(System.Type stateType)
    {
        System.Type val_1 = this.GetType();
        string val_2 = 0 + "State with type " + stateType + " not found in ";
        UnityEngine.Debug.LogError(message:  0);
    }
    protected virtual void Awake()
    {
        if(this.currentState != null)
        {
                return;
        }
        
        this.currentState = this._defaultState;
        if(this._defaultState == null)
        {
                return;
        }
        
        goto typeof(StateMachine.State).__il2cppRuntimeField_160;
    }
    public bool GotoState<T>(object stateData)
    {
        if(this != null)
        {
                return this.GotoState(stateType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), stateData:  stateData);
        }
        
        return this.GotoState(stateType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), stateData:  stateData);
    }
    public bool GotoState(System.Type stateType, object stateData)
    {
        var val_5;
        State val_1 = 0;
        if((this.typeToStates.TryGetValue(key:  stateType, value: out  val_1)) == false)
        {
            goto label_2;
        }
        
        if(val_1 == this.currentState)
        {
            goto label_3;
        }
        
        val_5 = this;
        bool val_4 = this._gotoStateInternal(nextState:  val_1, forceStateChange:  false, stateData:  stateData);
        goto label_5;
        label_2:
        this.logNoStateFoundError(stateType:  stateType);
        val_5 = 0;
        goto label_5;
        label_3:
        val_5 = 1;
        label_5:
        val_5 = val_5 & 1;
        return (bool)val_5;
    }
    public bool GotoStateLate<T>()
    {
        var val_6;
        State val_2 = 0;
        if((this.typeToStates.TryGetValue(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value: out  val_2)) != false)
        {
                if(val_2 != this.currentState)
        {
                this.pendingState = val_2;
        }
        
            val_6 = 1;
            return (bool)val_6;
        }
        
        this.logNoStateFoundError(stateType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_6 = 0;
        return (bool)val_6;
    }
    public void CancelLateState()
    {
        this.pendingState = 0;
    }
    public void ResetToDefaultState()
    {
        bool val_1 = this._gotoStateInternal(nextState:  this._defaultState, forceStateChange:  true, stateData:  0);
    }
    private bool GotoState(StateMachine.State state, object stateData)
    {
        var val_3 = 0;
        do
        {
            if(val_3 >= this.states.Count)
        {
                return false;
        }
        
            val_3 = val_3 + 1;
        }
        while(state != this.states.Item[0]);
        
        return this._gotoStateInternal(nextState:  state, forceStateChange:  false, stateData:  stateData);
    }
    private bool _gotoStateInternal(StateMachine.State nextState, bool forceStateChange, object stateData)
    {
        object val_3;
        var val_4;
        var val_6;
        val_3 = stateData;
        if(((forceStateChange != true) && (this.currentState != null)) && (this.currentState._uninterrupted != false))
        {
                if((this.currentState.CanBeInterruptedBy(state:  nextState)) == false)
        {
            goto label_6;
        }
        
        }
        
        if(nextState != null)
        {
                nextState.Data = val_3;
            val_4 = this;
            val_3 = this.currentState;
        }
        else
        {
                mem[16] = val_3;
            val_4 = this;
            val_3 = this.currentState;
        }
        
        if((nextState & 1) != 0)
        {
                val_3 = this.currentState;
            this.pendingState = 0;
            if(val_3 != null)
        {
                this.currentState.Data = 0;
        }
        
            this.currentState = nextState;
            val_6 = 1;
            return (bool)val_6;
        }
        
        label_6:
        val_6 = 0;
        return (bool)val_6;
    }
    private System.Collections.Generic.List<System.Type> initTypeStates()
    {
        System.Type val_22;
        StateMachine val_23;
        var val_24;
        var val_25;
        System.Type val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        StateMachine val_34;
        val_23 = this;
        val_24 = 1152921504901361664;
        System.Collections.Generic.List<System.Type> val_2 = 0;
        val_25 = null;
        val_25 = null;
        val_26 = this.GetType();
        if((StateMachine._registeredTypes.TryGetValue(key:  val_26, value: out  val_2)) != false)
        {
                val_27 = val_2;
            return (System.Collections.Generic.List<System.Type>)StateMachine._registeredTypes.Item[val_22];
        }
        
        System.Collections.Generic.List<System.Type> val_4 = new System.Collections.Generic.List<System.Type>();
        System.Type val_5 = this.GetType();
        Add(item:  val_5);
        goto label_7;
        label_15:
        Add(item:  val_5);
        label_7:
        if((val_5 == null) || (val_5 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))))
        {
            goto label_12;
        }
        
        if(null != 0)
        {
            goto label_15;
        }
        
        goto label_15;
        label_12:
        System.Collections.Generic.List<System.Type> val_7 = null;
        val_26 = val_7;
        val_7 = new System.Collections.Generic.List<System.Type>();
        int val_9 = Count - 1;
        if((val_9 & 2147483648) != 0)
        {
            goto label_17;
        }
        
        label_50:
        System.Type val_10 = Item[val_9];
        val_28 = null;
        val_28 = null;
        if((StateMachine._registeredTypes.ContainsKey(key:  val_10)) == false)
        {
            goto label_22;
        }
        
        val_29 = null;
        val_29 = null;
        val_23 = StateMachine._registeredTypes.Item[val_10];
        val_30 = 0;
        goto label_26;
        label_33:
        val_30 = 1;
        label_26:
        if(val_30 >= val_23.Count)
        {
            goto label_41;
        }
        
        System.Type val_14 = val_23.Item[1];
        if((Contains(item:  val_14)) == true)
        {
            goto label_33;
        }
        
        Add(item:  val_14);
        goto label_33;
        label_22:
        System.Collections.Generic.List<System.Type> val_17 = null;
        val_23 = val_17;
        val_17 = new System.Collections.Generic.List<System.Type>();
        val_31 = null;
        val_31 = null;
        StateMachine._registeredTypes.Add(key:  val_10, value:  val_23);
        AddRange(collection:  val_26);
        val_32 = 0;
        goto label_39;
        label_49:
        val_32 = 1;
        label_39:
        if(val_32 >= null)
        {
            goto label_41;
        }
        
        System.Type val_18 = val_10 + 8;
        if(1 == 0)
        {
            goto label_49;
        }
        
        System.Type val_19 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        if((1 & 1) == 0)
        {
            goto label_49;
        }
        
        Add(item:  1);
        Add(item:  1);
        goto label_49;
        label_41:
        val_24 = 1152921504901361664;
        val_9 = val_9 - 1;
        if((val_9 & 2147483648) == 0)
        {
            goto label_50;
        }
        
        label_17:
        val_34 = val_23;
        val_22 = this.GetType();
        return (System.Collections.Generic.List<System.Type>)StateMachine._registeredTypes.Item[val_22];
    }
    private void initStates()
    {
        var val_10;
        State val_11;
        System.Collections.Generic.List<System.Type> val_1 = this.initTypeStates();
        if(this.states == null)
        {
                this.states = new System.Collections.Generic.List<State>();
        }
        
        val_10 = 0;
        goto label_2;
        label_6:
        this.addStateByType(type:  val_1.Item[0]);
        val_10 = 1;
        label_2:
        if(val_10 >= val_1.Count)
        {
            goto label_4;
        }
        
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        val_11 = this.determineDefaultState();
        if(val_11 != null)
        {
            goto label_13;
        }
        
        if(this.states.Count < 1)
        {
            goto label_11;
        }
        
        val_10 = 1152921511211939104;
        if(this.states.Item[0] == null)
        {
            goto label_11;
        }
        
        val_11 = this.states.Item[0];
        goto label_13;
        label_11:
        StateMachine.State val_9 = null;
        val_11 = val_9;
        val_9 = new StateMachine.State();
        label_13:
        this._defaultState = val_11;
    }
    private void addStateByType(System.Type type)
    {
        State val_7;
        System.Type val_8;
        var val_9;
        val_8 = type;
        if(val_8.IsAbstract == true)
        {
                return;
        }
        
        val_9 = val_8;
        val_7 = System.Activator.CreateInstance(type:  0);
        if(val_7 != null)
        {
                val_9 = 0;
        }
        
        val_8 = 0 + "Cant create instance of type ";
        UnityEngine.Debug.LogWarning(message:  0);
    }
    private StateMachine.State determineDefaultState()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        val_8 = 0;
        goto label_1;
        label_35:
        val_7 = 1;
        val_8 = X23;
        label_1:
        if(val_7 >= this.states.Count)
        {
                return (State)val_8;
        }
        
        State val_2 = this.states.Item[1];
        if((val_2.defaultAttribute == 0) || (val_8 == 0))
        {
            goto label_35;
        }
        
        if((X23 + 28) != 2)
        {
            goto label_8;
        }
        
        if(val_2.defaultAttribute != 2)
        {
            goto label_35;
        }
        
        System.Type val_4 = val_2.GetType();
        typeof(System.Object[]).__il2cppRuntimeField_20 = "More than one default state in same class is not allowed. Class: ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_4;
        typeof(System.Object[]).__il2cppRuntimeField_30 = "; States:` ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_4;
        typeof(System.Object[]).__il2cppRuntimeField_40 = " , ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_8.GetType();
        string val_5 = +0;
        UnityEngine.Debug.LogError(message:  0);
        goto label_35;
        label_8:
        var val_6 = (val_2.defaultAttribute == 2) ? (val_2) : (val_8);
        goto label_35;
    }
    public void SetDefaultState(StateMachine.State state)
    {
        int val_1 = this.states.Count;
        if(val_1 < 1)
        {
            goto label_7;
        }
        
        var val_5 = 0;
        label_5:
        if(this.states.Item[0] == state)
        {
            goto label_4;
        }
        
        val_5 = val_5 + 1;
        if(val_5 < val_1)
        {
            goto label_5;
        }
        
        goto label_7;
        label_4:
        if(state != null)
        {
                this._defaultState = state;
            return;
        }
        
        label_7:
        string val_3 = this.name;
        string val_4 = 0 + "Failed to set default state ";
        UnityEngine.Debug.LogError(message:  0);
    }
    private static void dumpArray(object[] arrayToDump, string prefix = "")
    {
        var val_3;
        var val_4;
        val_3 = 0;
        goto label_1;
        label_10:
        val_4 = 34803712;
        UnityEngine.Debug.Log(message:  0);
        val_3 = 1;
        label_1:
        if(val_3 >= true)
        {
                return;
        }
        
        if(val_3 >= true)
        {
                val_4 = 0;
        }
        
        string val_1 = prefix + 8;
        string val_2 = 0 + X2;
        goto label_10;
    }
    protected virtual void OnStateChanged()
    {
    
    }
    private static StateMachine()
    {
        StateMachine._registeredTypes = new System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<System.Type>>();
    }

}
