using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class ReorderableListDebug : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Text DebugLabel;
        
        // Methods
        public ReorderableListDebug()
        {
        
        }
        private void Awake()
        {
            goto label_3;
            label_9:
            X21.AddListener(call:  X22);
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_3 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1];
            UnityEngine.Events.UnityAction<ReorderableListEventStruct> val_2 = new UnityEngine.Events.UnityAction<ReorderableListEventStruct>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ReorderableListDebug::ElementDropped(UnityEngine.UI.Extensions.ReorderableList.ReorderableListEventStruct droppedStruct));
            if((val_1[0x1][0] + 48) != 0)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        private void ElementDropped(UnityEngine.UI.Extensions.ReorderableList.ReorderableListEventStruct droppedStruct)
        {
            null = null;
            string val_2 = 0 + this.DebugLabel + "Dropped Object: "("Dropped Object: ") + droppedStruct.DroppedObject.name;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.DebugLabel;
            typeof(System.Object[]).__il2cppRuntimeField_28 = "Is Clone ?: ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = droppedStruct.IsAClone;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 31610372;
            typeof(System.Object[]).__il2cppRuntimeField_38 = "\n";
            string val_3 = +0;
            if(droppedStruct.IsAClone != false)
            {
                    string val_5 = 0 + this.DebugLabel + "Source Object: "("Source Object: ") + droppedStruct.SourceObject.name;
            }
            
            string val_7 = System.String.Format(format:  0, arg0:  "From {0} at Index {1} \n", arg1:  droppedStruct.FromList.name);
            string val_8 = 0 + this.DebugLabel;
            string val_10 = System.String.Format(format:  0, arg0:  "To {0} at Index {1} \n", arg1:  droppedStruct.ToList.name);
            string val_11 = 0 + this.DebugLabel;
        }
    
    }

}
