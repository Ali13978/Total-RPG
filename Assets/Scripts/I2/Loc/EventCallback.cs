using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class EventCallback
    {
        // Fields
        public UnityEngine.MonoBehaviour Target;
        public string MethodName;
        
        // Methods
        public EventCallback()
        {
            null = null;
            this.MethodName = System.String.Empty;
        }
        public void Execute(UnityEngine.Object Sender)
        {
            if(this.HasCallback() == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.Target.gameObject.SendMessage(methodName:  this.MethodName, value:  Sender, options:  1);
        }
        public bool HasCallback()
        {
            string val_4;
            var val_5;
            val_4 = this;
            if(0 != this.Target)
            {
                    val_4 = this.MethodName;
                val_5 = (System.String.IsNullOrEmpty(value:  0)) ^ 1;
                return (bool)val_5 & 1;
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
    
    }

}
