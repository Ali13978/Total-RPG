using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    internal class ObjectAction : IObjectAction
    {
        // Fields
        [UnityEngine.SerializeField]
        private string name;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite icon;
        [UnityEngine.SerializeField]
        private bool useOnce;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ActionHandler _handler;
        public TzarGames.GameFramework.PerformedActionEvent OnActionPerformed;
        public TzarGames.GameFramework.PerformedActionEvent OnActionFailed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ActionObjectBehaviour <Behaviour>k__BackingField;
        
        // Properties
        public UnityEngine.Sprite Icon { get; }
        public TzarGames.GameFramework.ActionObjectBehaviour Behaviour { get; set; }
        public TzarGames.GameFramework.ActionHandler Handler { get; }
        public bool UseOnce { get; }
        
        // Methods
        public ObjectAction()
        {
            this.useOnce = true;
        }
        public UnityEngine.Sprite get_Icon()
        {
            return (UnityEngine.Sprite)this.icon;
        }
        public TzarGames.GameFramework.ActionObjectBehaviour get_Behaviour()
        {
            return (TzarGames.GameFramework.ActionObjectBehaviour)this.<Behaviour>k__BackingField;
        }
        public void set_Behaviour(TzarGames.GameFramework.ActionObjectBehaviour value)
        {
            this.<Behaviour>k__BackingField = value;
        }
        public TzarGames.GameFramework.ActionHandler get_Handler()
        {
            return (TzarGames.GameFramework.ActionHandler)this._handler;
        }
        public bool get_UseOnce()
        {
            return (bool)this.useOnce;
        }
    
    }

}
