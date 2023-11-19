using UnityEngine;

namespace Facebook.Unity.Example
{
    internal abstract class MenuBase : ConsoleBase
    {
        // Fields
        private static Facebook.Unity.ShareDialogMode shareDialogMode;
        
        // Methods
        protected MenuBase()
        {
        
        }
        protected abstract void GetGui(); // 0
        protected virtual bool ShowDialogModeSelector()
        {
            return false;
        }
        protected virtual bool ShowBackButton()
        {
            return true;
        }
        protected void HandleResult(Facebook.Unity.IResult result)
        {
            var val_13;
            var val_14;
            string val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            string val_20;
            string val_21;
            var val_22;
            if(result == null)
            {
                goto label_1;
            }
            
            this.LastResponseTexture = 0;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = result;
            goto label_5;
            label_1:
            this.LastResponse = "Null Response\n";
            string val_1 = this.LastResponse;
            goto label_6;
            label_5:
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_9;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = result;
            goto label_13;
            label_9:
            this.Status = "Error - Check log for details";
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_17 = result;
            goto label_17;
            label_13:
            if((result & 1) == 0)
            {
                goto label_18;
            }
            
            this.Status = "Cancelled - Check log for details";
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_18 = result;
            goto label_22;
            label_18:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_19 = result;
            goto label_26;
            label_17:
            val_13 = result;
            val_20 = "Error Response:\n";
            goto label_32;
            label_22:
            val_13 = result;
            val_20 = "Cancelled Response:\n";
            goto label_32;
            label_26:
            val_13 = result;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_35;
            }
            
            val_21 = "Empty Response\n";
            goto label_36;
            label_35:
            this.Status = "Success - Check log for details";
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_22 = result;
            val_13 = result;
            val_20 = "Success Response:\n";
            label_32:
            val_21 = 0 + val_20;
            label_36:
            this.LastResponse = val_21;
            val_15 = result;
            label_6:
            val_15 = null;
            Facebook.Unity.Example.LogView.AddLog(log:  val_15);
        }
        protected void OnGUI()
        {
            UnityEngine.GUILayoutOption val_14;
            var val_15;
            if(this.IsHorizontalLayout() != false)
            {
                    UnityEngine.GUILayout.BeginHorizontal(options:  0);
                UnityEngine.GUILayout.BeginVertical(options:  0);
            }
            
            UnityEngine.GUILayout.Label(text:  0, style:  this.GetType(), options:  this.LabelStyle);
            this.AddStatus();
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
                if((-1358496744) == 1)
            {
                    UnityEngine.Vector2 val_6 = this.ScrollPosition;
                UnityEngine.Touch val_7 = UnityEngine.Input.GetTouch(index:  0);
                val_6.y = val_6.y + val_6.y;
                this.ScrollPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            }
            
            }
            
            UnityEngine.Vector2 val_8 = this.ScrollPosition;
            val_14 = UnityEngine.GUILayout.MinWidth(minWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowFullWidth);
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = val_14;
            UnityEngine.Vector2 val_11 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, options:  0);
            this.ScrollPosition = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            if((this & 1) != 0)
            {
                    this.AddBackButton();
            }
            
            this.AddLogButton();
            if((this & 1) != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_14 = null;
                typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MinWidth(minWidth:  (float)Facebook.Unity.Example.ConsoleBase.MarginFix);
                UnityEngine.GUILayout.Label(content:  0, options:  UnityEngine.GUIContent.none);
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            if((this & 1) != 0)
            {
                    this.AddDialogModeButtons();
            }
            
            UnityEngine.GUILayout.BeginVertical(options:  0);
            UnityEngine.GUILayout.Space(pixels:  10f);
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.EndScrollView();
        }
        private void AddStatus()
        {
            UnityEngine.GUILayout.Space(pixels:  5f);
            string val_1 = this.Status;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MinWidth(minWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowWidth);
            UnityEngine.GUILayout.Box(text:  0, style:  0 + "Status: "("Status: "), options:  this.TextStyle);
        }
        private void AddBackButton()
        {
            System.Collections.Generic.Stack<System.String> val_1 = Facebook.Unity.Example.ConsoleBase.MenuStack;
            bool val_3 = System.Linq.Enumerable.Any<System.String>(source:  0);
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Back")) != false)
            {
                    this.GoBack();
            }
            
            UnityEngine.GUI.enabled = false;
        }
        private void AddLogButton()
        {
            if((this.Button(label:  "Log")) == false)
            {
                    return;
            }
            
            this.SwitchMenu(menuClass:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        private void AddDialogModeButtons()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  0).GetEnumerator();
            label_19:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = val_3;
            if(((val_3 & 1) & 1) == 0)
            {
                goto label_28;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = val_3;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.AddDialogModeButton(mode:  null);
            goto label_19;
            label_29:
            val_12 = this;
            if(null != 1)
            {
                goto label_20;
            }
            
            label_28:
            if(val_3 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_13 = val_3;
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            return;
            label_20:
            goto label_29;
        }
        private void AddDialogModeButton(Facebook.Unity.ShareDialogMode mode)
        {
            var val_7;
            bool val_1 = UnityEngine.GUI.enabled;
            if(val_1 != false)
            {
                    var val_2 = (Facebook.Unity.Example.MenuBase.shareDialogMode != mode) ? 1 : 0;
            }
            else
            {
                    val_7 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if((this.Button(label:  mode.ToString())) != false)
            {
                    Facebook.Unity.Example.MenuBase.shareDialogMode = null;
                FB.Mobile.ShareDialogMode = 0;
            }
            
            bool val_6 = val_1;
            UnityEngine.GUI.enabled = false;
        }
    
    }

}
