using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class MessageContainer : UIContainer<Unitycoding.UIWidgets.MessageOptions>
    {
        // Fields
        [UnityEngine.SerializeField]
        public bool fadeMessage;
        
        // Methods
        public MessageContainer()
        {
            this.fadeMessage = true;
        }
        public virtual bool Add(string message)
        {
            Unitycoding.UIWidgets.MessageOptions val_1 = new Unitycoding.UIWidgets.MessageOptions();
            typeof(Unitycoding.UIWidgets.MessageOptions).__il2cppRuntimeField_18 = message;
            goto typeof(Unitycoding.UIWidgets.MessageContainer).__il2cppRuntimeField_1D0;
        }
        public virtual bool Add(string message, UnityEngine.Sprite icon)
        {
            Unitycoding.UIWidgets.MessageOptions val_1 = new Unitycoding.UIWidgets.MessageOptions();
            if(null != 0)
            {
                    typeof(Unitycoding.UIWidgets.MessageOptions).__il2cppRuntimeField_18 = message;
            }
            else
            {
                    mem[24] = message;
            }
            
            typeof(Unitycoding.UIWidgets.MessageOptions).__il2cppRuntimeField_30 = icon;
            goto typeof(Unitycoding.UIWidgets.MessageContainer).__il2cppRuntimeField_1D0;
        }
        public virtual bool Remove(string message)
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = message;
            val_10 = 0;
            goto label_1;
            label_8:
            val_10 = 1;
            label_1:
            if(val_10 >= this.Items.Count)
            {
                goto label_3;
            }
            
            Unitycoding.UIWidgets.MessageOptions val_4 = this.Items.Item[1];
            if((System.String.op_Equality(a:  0, b:  val_4.text)) == false)
            {
                goto label_8;
            }
            
            val_9 = this.Slots;
            UnityEngine.GameObject val_8 = val_9.Item[1].gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  0);
            this.RefreshSlots();
            val_11 = 1;
            return (bool)val_11;
            label_3:
            val_11 = 0;
            return (bool)val_11;
        }
    
    }

}
