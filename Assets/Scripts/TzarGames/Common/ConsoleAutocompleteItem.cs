using UnityEngine;

namespace TzarGames.Common
{
    public class ConsoleAutocompleteItem : MonoBehaviour
    {
        // Fields
        public TzarGames.Common.ConsoleAutocompleteItemEvent OnClickEvent;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <MethodName>k__BackingField;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI text;
        
        // Properties
        public string MethodName { get; set; }
        
        // Methods
        public ConsoleAutocompleteItem()
        {
        
        }
        public string get_MethodName()
        {
            return (string)this.<MethodName>k__BackingField;
        }
        private void set_MethodName(string value)
        {
            this.<MethodName>k__BackingField = value;
        }
        public void SetMethodData(string methodName, System.Reflection.ParameterInfo[] parameters)
        {
            string val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = methodName;
            this.<MethodName>k__BackingField = val_2;
            val_3 = 0;
            goto label_1;
            label_29:
            val_4 = this;
            val_2 = +0;
            val_3 = 1;
            label_1:
            if(val_3 >= parameters.Length)
            {
                goto label_3;
            }
            
            if(val_3 >= parameters.Length)
            {
                    val_4 = 0;
            }
            
            System.Reflection.ParameterInfo val_2 = parameters[1];
            val_5 = 6;
            if(val_2 != null)
            {
                    val_5 = mem[null + 48];
                if(val_2 == null)
            {
                    val_5 = 0;
            }
            
            }
            
            val_5 = 0;
            typeof(System.String[]).__il2cppRuntimeField_20 = val_2;
            val_5 = mem[null + 48];
            if((" <color=gray>") == null)
            {
                    val_5 = 0;
            }
            
            val_5 = 0;
            typeof(System.String[]).__il2cppRuntimeField_28 = " <color=gray>";
            typeof(System.String[]).__il2cppRuntimeField_30 = val_2;
            typeof(System.String[]).__il2cppRuntimeField_38 = "(";
            typeof(System.String[]).__il2cppRuntimeField_40 = val_2;
            typeof(System.String[]).__il2cppRuntimeField_48 = ")</color>";
            goto label_29;
            label_3:
            mem[1152921511067792616].text = val_2;
        }
        public void OnClick()
        {
            this.OnClickEvent.Invoke(arg0:  this);
        }
        private void OnEnable()
        {
            this.OnClickEvent = new TzarGames.Common.ConsoleAutocompleteItemEvent();
        }
    
    }

}
