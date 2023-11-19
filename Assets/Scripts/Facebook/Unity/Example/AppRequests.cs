using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class AppRequests : MenuBase
    {
        // Fields
        private string requestMessage;
        private string requestTo;
        private string requestFilter;
        private string requestExcludes;
        private string requestMax;
        private string requestData;
        private string requestTitle;
        private string requestObjectID;
        private int selectedAction;
        private string[] actionTypeStrings;
        
        // Methods
        public AppRequests()
        {
            null = null;
            this.requestMessage = System.String.Empty;
            this.requestTo = System.String.Empty;
            this.requestFilter = System.String.Empty;
            this.requestExcludes = System.String.Empty;
            this.requestMax = System.String.Empty;
            this.requestData = System.String.Empty;
            this.requestTitle = System.String.Empty;
            this.requestObjectID = System.String.Empty;
            typeof(System.String[]).__il2cppRuntimeField_20 = "NONE";
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(System.String[]).__il2cppRuntimeField_28 = 0.ToString();
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            typeof(System.String[]).__il2cppRuntimeField_30 = 1.ToString();
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y});
            typeof(System.String[]).__il2cppRuntimeField_38 = 2.ToString();
            this.actionTypeStrings = null;
        }
        protected override void GetGui()
        {
            var val_59;
            var val_60;
            var val_61;
            string val_62;
            string val_63;
            IntPtr val_64;
            var val_65;
            string val_66;
            string val_67;
            var val_68;
            string val_69;
            System.Collections.Generic.IEnumerable<System.String> val_70;
            bool val_71;
            Facebook.Unity.OGActionType val_72;
            if((this.Button(label:  "Select - Filter None")) != false)
            {
                    val_59 = null;
                val_59 = null;
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> val_2 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.AppRequest(message:  0, to:  "Test Message", filters:  0, excludeIds:  0, maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  0, title:  System.String.Empty, callback:  System.String.Empty);
            }
            
            if((this.Button(label:  "Select - Filter app_users")) != false)
            {
                    Add(item:  "app_users");
                val_60 = null;
                val_60 = null;
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> val_5 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.AppRequest(message:  0, to:  "Test Message", filters:  0, excludeIds:  new System.Collections.Generic.List<System.Object>(), maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  0, title:  System.String.Empty, callback:  System.String.Empty);
            }
            
            if((this.Button(label:  "Select - Filter app_non_users")) != false)
            {
                    Add(item:  "app_non_users");
                val_61 = null;
                val_61 = null;
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> val_8 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.AppRequest(message:  0, to:  "Test Message", filters:  0, excludeIds:  new System.Collections.Generic.List<System.Object>(), maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  0, title:  System.String.Empty, callback:  System.String.Empty);
            }
            
            this.LabelAndTextField(label:  "Message: ", text: ref  this.requestMessage);
            val_62 = this.requestTo;
            this.LabelAndTextField(label:  "To (optional): ", text: ref  val_62);
            this.LabelAndTextField(label:  "Filter (optional): ", text: ref  this.requestFilter);
            val_63 = this.requestExcludes;
            this.LabelAndTextField(label:  "Exclude Ids (optional): ", text: ref  val_63);
            this.LabelAndTextField(label:  "Filters: ", text: ref  val_63);
            this.LabelAndTextField(label:  "Max Recipients (optional): ", text: ref  this.requestMax);
            this.LabelAndTextField(label:  "Data (optional): ", text: ref  this.requestData);
            this.LabelAndTextField(label:  "Title (optional): ", text: ref  this.requestTitle);
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            float val_18 = this.ScaleFactor;
            val_18 = val_18 * 200f;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MaxWidth(maxWidth:  val_18);
            UnityEngine.GUILayout.Label(text:  0, style:  "Request Action (optional): ", options:  this.LabelStyle);
            val_64 = null;
            float val_22 = this.ScaleFactor;
            val_22 = ((Facebook.Unity.Constants.IsMobile != true) ? 60f : 24f) * val_22;
            UnityEngine.GUILayoutOption val_24 = UnityEngine.GUILayout.MinHeight(minHeight:  val_22);
            if(val_24 != null)
            {
                    val_65 = val_24;
            }
            
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = val_24;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_28 = UnityEngine.GUILayout.MaxWidth(maxWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowWidth - 150);
            this.selectedAction = UnityEngine.GUILayout.Toolbar(selected:  0, texts:  this.selectedAction, style:  this.actionTypeStrings, options:  this.ButtonStyle);
            UnityEngine.GUILayout.EndHorizontal();
            val_66 = this.requestObjectID;
            this.LabelAndTextField(label:  "Request Object ID (optional): ", text: ref  val_66);
            if((this.Button(label:  "Custom App Request")) == false)
            {
                    return;
            }
            
            System.Nullable<Facebook.Unity.OGActionType> val_31 = this.GetSelectedOGActionType();
            val_67 = this.requestMessage;
            if(((-1356367176) & 1) == 0)
            {
                goto label_32;
            }
            
            bool val_32 = System.String.IsNullOrEmpty(value:  0);
            if(val_32 == false)
            {
                goto label_35;
            }
            
            val_69 = 0;
            val_68 = ;
            val_63 = mem[this.requestObjectID];
            goto label_36;
            label_32:
            bool val_37 = System.String.IsNullOrEmpty(value:  0);
            val_66 = 0;
            System.Collections.Generic.IEnumerable<System.String> val_38 = (val_37 != true) ? 0 : (val_67);
            if(val_37 != true)
            {
                    typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
                val_66 = mem[this.requestTo].Split(separator:  null);
                val_70 = val_38;
            }
            
            bool val_41 = System.String.IsNullOrEmpty(value:  0);
            val_62 = 0;
            if(val_41 != true)
            {
                    typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
                System.String[] val_45 = mem[this.requestFilter].Split(separator:  null);
                System.Collections.Generic.IEnumerable<TResult> val_46 = System.Linq.Enumerable.OfType<System.String>(source:  0);
                val_62 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
                val_70 = (val_41 != true) ? 0 : (val_70);
                val_66 = (val_41 != true) ? 0 : (val_66);
            }
            
            bool val_48 = System.String.IsNullOrEmpty(value:  0);
            val_71 = 0;
            val_38 = (val_48 != true) ? 0 : (val_70);
            if(val_48 != true)
            {
                    typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
                val_71 = mem[this.requestExcludes].Split(separator:  null);
                val_70 = val_38;
                val_66 = (val_48 != true) ? 0 : (val_66);
                val_62 = (val_48 != true) ? 0 : (val_62);
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_57;
            }
            
            goto label_58;
            label_35:
            typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
            val_69 = mem[this.requestTo].Split(separator:  null);
            val_72 = (val_32 != true) ? 0 : (val_67);
            label_36:
            val_62 = this.requestData;
            val_66 = this.requestTitle;
            val_64 = System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result);
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> val_56 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  val_64);
            Facebook.Unity.FB.AppRequest(message:  0, actionType:  val_72, objectId:  (val_32 != true) ? 0 : (), to:  (val_32 != true) ? 0 : (mem[this.requestObjectID]), data:  val_69, title:  val_62, callback:  val_66);
            return;
            label_57:
            int val_57 = System.Int32.Parse(s:  0);
            label_58:
            val_63 = this.requestTitle;
            val_64 = System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result);
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> val_58 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  val_64);
            Facebook.Unity.FB.AppRequest(message:  0, to:  val_70, filters:  val_66, excludeIds:  val_62, maxRecipients:  new System.Nullable<System.Int32>() {HasValue = val_71}, data:  0, title:  this.requestData, callback:  val_63);
        }
        private System.Nullable<Facebook.Unity.OGActionType> GetSelectedOGActionType()
        {
            var val_10;
            string val_10 = this.actionTypeStrings[this.selectedAction];
            val_10 = 0;
            string val_1 = 0.ToString();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if((System.String.op_Equality(a:  0, b:  val_10)) != false)
            {
                    return 0;
            }
            
            val_10 = 1;
            string val_4 = 1.ToString();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            if((System.String.op_Equality(a:  0, b:  val_10)) != false)
            {
                    return 0;
            }
            
            val_10 = 2;
            string val_7 = 2.ToString();
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y});
            if((System.String.op_Equality(a:  0, b:  val_10)) == false)
            {
                    return 0;
            }
            
            return 0;
        }
    
    }

}
