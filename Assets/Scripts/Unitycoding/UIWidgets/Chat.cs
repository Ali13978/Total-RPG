using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class Chat : UIWidget
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        protected string filterMask;
        [UnityEngine.SerializeField]
        [UnityEngine.TextAreaAttribute]
        protected string filter;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Text text;
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.InputField input;
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Button submit;
        private string[] filterWords;
        
        // Methods
        public Chat()
        {
            this.filterMask = "*";
            this.filter = "fuck, ass, piss, cunt, shit";
        }
        protected override void OnStart()
        {
            var val_8;
            this.input.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void Unitycoding.UIWidgets.Chat::Submit(string text)));
            if(0 != this.submit)
            {
                    this.submit.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Unitycoding.UIWidgets.Chat::<OnStart>m__0()));
            }
            
            val_8 = null;
            val_8 = null;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
            this.filterWords = this.filter.Replace(oldValue:  " ", newValue:  System.String.Empty).Split(separator:  null);
        }
        private void Submit(string text)
        {
            var val_3;
            bool val_2 = System.String.IsNullOrEmpty(value:  0);
            val_3 = null;
            val_3 = null;
            this.input.text = System.String.Empty;
        }
        protected virtual void OnSubmit(string text)
        {
            string val_1 = 0 + this.text + "\n";
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5A0;
        }
        protected virtual string ApplyFilter(string text)
        {
            var val_5;
            var val_6;
            val_5 = text;
            val_6 = 0;
            goto label_1;
            label_10:
            val_5 = val_5.Replace(oldValue:  static_value_02131000, newValue:  X22);
            val_6 = 1;
            label_1:
            if(val_6 >= this.filterWords.Length)
            {
                    return (string)val_5;
            }
            
            null = new System.Text.StringBuilder();
            System.Text.StringBuilder val_4 = Insert(index:  0, value:  this.filterMask, count:  this.filterWords[1].Length);
            if(val_5 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        private void <OnStart>m__0()
        {
            this.Submit(text:  this.input.text);
        }
    
    }

}
