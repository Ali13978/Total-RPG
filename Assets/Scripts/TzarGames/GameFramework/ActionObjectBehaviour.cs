using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ActionObjectBehaviour : MonoBehaviour, IActionTarget
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ObjectAction[] actions;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.IObjectAction> OnActionPerformed;
        private System.Collections.Generic.List<TzarGames.GameFramework.IObjectAction> availableActions;
        
        // Methods
        public ActionObjectBehaviour()
        {
            this.availableActions = new System.Collections.Generic.List<TzarGames.GameFramework.IObjectAction>();
        }
        public void add_OnActionPerformed(System.Action<TzarGames.GameFramework.IObjectAction> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnActionPerformed);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511260705280 != this.OnActionPerformed);
        
        }
        public void remove_OnActionPerformed(System.Action<TzarGames.GameFramework.IObjectAction> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnActionPerformed);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511260841856 != this.OnActionPerformed);
        
        }
        private void Awake()
        {
            goto label_1;
            label_7:
            X21.Add(item:  34799616);
            0 = 1;
            label_1:
            if(0 >= this.actions.Length)
            {
                    return;
            }
            
            this.actions[1].Behaviour = this;
            if(this.availableActions != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public bool IsActionAvailable(TzarGames.GameFramework.IObjectAction action)
        {
            var val_4;
            if(this.enabled == false)
            {
                    return false;
            }
            
            val_4 = this.gameObject;
            if(val_4.activeInHierarchy == false)
            {
                    return false;
            }
            
            if(this.availableActions != null)
            {
                    return this.availableActions.Contains(item:  action);
            }
            
            return this.availableActions.Contains(item:  action);
        }
        public TzarGames.GameFramework.IObjectAction[] GetAvailableActions()
        {
            System.Collections.Generic.List<TzarGames.GameFramework.IObjectAction> val_5;
            var val_6;
            val_5 = this;
            val_6 = 0;
            if(this.enabled == false)
            {
                    return (TzarGames.GameFramework.IObjectAction[])val_5.ToArray();
            }
            
            val_6 = 0;
            if(this.gameObject.activeInHierarchy == false)
            {
                    return (TzarGames.GameFramework.IObjectAction[])val_5.ToArray();
            }
            
            val_5 = this.availableActions;
            return (TzarGames.GameFramework.IObjectAction[])val_5.ToArray();
        }
        private void callFailureEvent(TzarGames.GameFramework.ObjectAction action, TzarGames.GameFramework.IObjectActionResult result, TzarGames.GameFramework.IActionPerformer performer)
        {
            typeof(TzarGames.GameFramework.ActionEventData).__il2cppRuntimeField_10 = performer;
            typeof(TzarGames.GameFramework.ActionEventData).__il2cppRuntimeField_18 = this;
            typeof(TzarGames.GameFramework.ActionEventData).__il2cppRuntimeField_20 = result;
            action.OnActionFailed.Invoke(arg0:  new System.Object());
        }
        public TzarGames.GameFramework.IObjectActionResult DoAction(TzarGames.GameFramework.IObjectAction action, TzarGames.GameFramework.IActionPerformer performer)
        {
            TzarGames.GameFramework.IActionPerformer val_19;
            TzarGames.GameFramework.IObjectAction val_20;
            TzarGames.GameFramework.IObjectActionResult val_21;
            TzarGames.GameFramework.ObjectAction val_22;
            TzarGames.GameFramework.IObjectActionResult val_23;
            var val_24;
            var val_25;
            string val_26;
            var val_27;
            var val_28;
            val_19 = performer;
            val_20 = action;
            TzarGames.GameFramework.ObjectActionResult val_1 = null;
            val_21 = val_1;
            val_1 = new TzarGames.GameFramework.ObjectActionResult();
            Success = false;
            val_22 = 0;
            if(val_20 != null)
            {
                    val_22 = val_20;
                val_22 = 0;
            }
            
            if((this.availableActions.Contains(item:  val_20)) == false)
            {
                goto label_6;
            }
            
            if(val_22 == 0)
            {
                goto label_10;
            }
            
            TzarGames.GameFramework.ActionHandler val_6 = val_22.Handler;
            if(0 == val_6)
            {
                goto label_10;
            }
            
            val_23 = val_6;
            if(val_23 == null)
            {
                goto label_12;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_24 = val_23;
            goto label_16;
            label_6:
            if(null != 0)
            {
                    Message = "Action is not available";
            }
            else
            {
                    Message = "Action is not available";
            }
            
            val_20 = Message;
            UnityEngine.Debug.LogError(message:  0);
            if(val_22 != 0)
            {
                goto label_21;
            }
            
            return (TzarGames.GameFramework.IObjectActionResult)val_21;
            label_12:
            val_25 = val_6.Name;
            val_26 = "Cannot be performed: ";
            goto label_25;
            label_16:
            if(((val_23 & 1) & 1) == 0)
            {
                goto label_38;
            }
            
            val_23 = val_6;
            if(val_23 == null)
            {
                goto label_28;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_27 = val_23;
            goto label_32;
            label_28:
            val_25 = val_6.Name;
            val_26 = "Failed to perform: ";
            label_25:
            val_20 = 0 + val_26;
            if(null != 0)
            {
                    Message = val_20;
            }
            else
            {
                    Message = val_20;
            }
            
            Success = false;
            label_21:
            this.callFailureEvent(action:  val_22, result:  val_21, performer:  val_19);
            return (TzarGames.GameFramework.IObjectActionResult)val_21;
            label_32:
            if(((val_23 & 1) & 1) == 0)
            {
                goto label_38;
            }
            
            label_10:
            Success = true;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_28 = val_20;
            if((val_20 & 1) != 0)
            {
                    bool val_17 = this.availableActions.Remove(item:  val_20);
            }
            
            if(val_22 != 0)
            {
                    object val_18 = new System.Object();
                typeof(TzarGames.GameFramework.ActionEventData).__il2cppRuntimeField_10 = val_19;
                typeof(TzarGames.GameFramework.ActionEventData).__il2cppRuntimeField_18 = this;
                typeof(TzarGames.GameFramework.ActionEventData).__il2cppRuntimeField_20 = val_21;
                val_19 = 0;
                val_19.Invoke(arg0:  null);
            }
            
            if(this.OnActionPerformed == null)
            {
                    return (TzarGames.GameFramework.IObjectActionResult)val_21;
            }
            
            this.OnActionPerformed.Invoke(obj:  val_20);
            return (TzarGames.GameFramework.IObjectActionResult)val_21;
            label_38:
            this.callFailureEvent(action:  val_22, result:  val_23, performer:  val_19);
            val_21 = val_23;
            return (TzarGames.GameFramework.IObjectActionResult)val_21;
            label_56:
            mem[8] = ???;
            goto label_56;
        }
    
    }

}
