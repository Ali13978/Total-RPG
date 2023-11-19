using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class LogView : ConsoleBase
    {
        // Fields
        private static string datePatt;
        private static System.Collections.Generic.IList<string> events;
        
        // Methods
        public LogView()
        {
        
        }
        public static void AddLog(string log)
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            System.DateTime val_1 = System.DateTime.Now;
            string val_3 = System.String.Format(format:  0, arg0:  "{0}\n{1}\n", arg1:  val_1.ticks._ticks.ToString(format:  Facebook.Unity.Example.LogView.datePatt));
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = Facebook.Unity.Example.LogView.events;
        }
        protected void OnGUI()
        {
            var val_17;
            UnityEngine.GUILayout.BeginVertical(options:  0);
            if((this.Button(label:  "Back")) != false)
            {
                    this.GoBack();
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  0);
                if((-1359321576) == 1)
            {
                    UnityEngine.Vector2 val_4 = this.ScrollPosition;
                UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
                val_4.y = val_4.y + val_4.y;
                this.ScrollPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            }
            
            }
            
            UnityEngine.Vector2 val_6 = this.ScrollPosition;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MinWidth(minWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowFullWidth);
            UnityEngine.Vector2 val_9 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, options:  0);
            this.ScrollPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            val_17 = null;
            val_17 = null;
            TSource[] val_10 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.ExpandHeight(expand:  false);
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_28 = UnityEngine.GUILayout.MaxWidth(maxWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowWidth);
            string val_16 = UnityEngine.GUILayout.TextArea(text:  0, style:  System.String.Join(separator:  0, value:  "\n"), options:  this.TextStyle);
            UnityEngine.GUILayout.EndScrollView();
            UnityEngine.GUILayout.EndVertical();
        }
        private static LogView()
        {
            Facebook.Unity.Example.LogView.datePatt = "M/d/yyyy hh:mm:ss tt";
            Facebook.Unity.Example.LogView.events = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
