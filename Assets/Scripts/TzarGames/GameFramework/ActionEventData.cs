using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ActionEventData
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IActionPerformer <Performer>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ActionObjectBehaviour <Behaviour>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IObjectActionResult <Result>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.IActionPerformer Performer { get; set; }
        public TzarGames.GameFramework.ActionObjectBehaviour Behaviour { get; set; }
        public TzarGames.GameFramework.IObjectActionResult Result { get; set; }
        
        // Methods
        public ActionEventData(TzarGames.GameFramework.ActionObjectBehaviour behaviour, TzarGames.GameFramework.IActionPerformer performer, TzarGames.GameFramework.IObjectActionResult result)
        {
            this.<Performer>k__BackingField = performer;
            this.<Behaviour>k__BackingField = behaviour;
            this.<Result>k__BackingField = result;
        }
        public TzarGames.GameFramework.IActionPerformer get_Performer()
        {
            return (TzarGames.GameFramework.IActionPerformer)this.<Performer>k__BackingField;
        }
        private void set_Performer(TzarGames.GameFramework.IActionPerformer value)
        {
            this.<Performer>k__BackingField = value;
        }
        public TzarGames.GameFramework.ActionObjectBehaviour get_Behaviour()
        {
            return (TzarGames.GameFramework.ActionObjectBehaviour)this.<Behaviour>k__BackingField;
        }
        private void set_Behaviour(TzarGames.GameFramework.ActionObjectBehaviour value)
        {
            this.<Behaviour>k__BackingField = value;
        }
        public TzarGames.GameFramework.IObjectActionResult get_Result()
        {
            return (TzarGames.GameFramework.IObjectActionResult)this.<Result>k__BackingField;
        }
        private void set_Result(TzarGames.GameFramework.IObjectActionResult value)
        {
            this.<Result>k__BackingField = value;
        }
    
    }

}
