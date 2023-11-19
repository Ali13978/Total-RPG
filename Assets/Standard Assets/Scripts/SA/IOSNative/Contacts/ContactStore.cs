using UnityEngine;

namespace SA.IOSNative.Contacts
{
    public class ContactStore : Singleton<SA.IOSNative.Contacts.ContactStore>
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<SA.IOSNative.Contacts.ContactsResult> ContactsLoadResult;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<SA.IOSNative.Contacts.ContactsResult> ContactsPickResult;
        private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache0;
        private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache1;
        private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache2;
        private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache3;
        private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache4;
        private static System.Action<SA.IOSNative.Contacts.ContactsResult> <>f__am$cache5;
        
        // Methods
        public ContactStore()
        {
            System.Action<SA.IOSNative.Contacts.ContactsResult> val_4;
            if((SA.IOSNative.Contacts.ContactStore.<>f__am$cache4) == null)
            {
                    System.Action<SA.IOSNative.Contacts.ContactsResult> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void SA.IOSNative.Contacts.ContactStore::<ContactsLoadResult>m__4(SA.IOSNative.Contacts.ContactsResult ));
                SA.IOSNative.Contacts.ContactStore.<>f__am$cache4 = val_4;
            }
            
            this.ContactsLoadResult = SA.IOSNative.Contacts.ContactStore.<>f__am$cache4;
            if((SA.IOSNative.Contacts.ContactStore.<>f__am$cache5) == null)
            {
                    System.Action<SA.IOSNative.Contacts.ContactsResult> val_2 = null;
                val_4 = val_2;
                val_2 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void SA.IOSNative.Contacts.ContactStore::<ContactsPickResult>m__5(SA.IOSNative.Contacts.ContactsResult ));
                SA.IOSNative.Contacts.ContactStore.<>f__am$cache5 = val_4;
            }
            
            this.ContactsPickResult = SA.IOSNative.Contacts.ContactStore.<>f__am$cache5;
        }
        private void add_ContactsLoadResult(System.Action<SA.IOSNative.Contacts.ContactsResult> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ContactsLoadResult);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510337219368 != this.ContactsLoadResult);
        
        }
        private void remove_ContactsLoadResult(System.Action<SA.IOSNative.Contacts.ContactsResult> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ContactsLoadResult);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510337355944 != this.ContactsLoadResult);
        
        }
        private void add_ContactsPickResult(System.Action<SA.IOSNative.Contacts.ContactsResult> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.ContactsPickResult);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510337492528 != this.ContactsPickResult);
        
        }
        private void remove_ContactsPickResult(System.Action<SA.IOSNative.Contacts.ContactsResult> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.ContactsPickResult);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510337629104 != this.ContactsPickResult);
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void ShowContactsPickerUI(System.Action<SA.IOSNative.Contacts.ContactsResult> callback)
        {
            this.add_ContactsPickResult(value:  callback);
        }
        public void RetrievePhoneContacts(System.Action<SA.IOSNative.Contacts.ContactsResult> callback)
        {
            this.add_ContactsLoadResult(value:  callback);
        }
        private SA.IOSNative.Contacts.Contact ParseContactData(string data)
        {
            var val_7;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
            System.String[] val_1 = data.Split(separator:  null);
            typeof(SA.IOSNative.Contacts.Contact).__il2cppRuntimeField_10 = val_1[0];
            typeof(SA.IOSNative.Contacts.Contact).__il2cppRuntimeField_18 = val_1[1];
            SA.IOSNative.Contacts.Contact.__il2cppRuntimeField_byval_arg.AddRange(collection:  SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  val_1[2]));
            val_7 = 0;
            goto label_12;
            label_22:
            Add(item:  SA.IOSNative.Contacts.Contact.__il2cppRuntimeField_byval_arg);
            val_7 = 1;
            label_12:
            if(val_7 >= val_4.Length)
            {
                    return (SA.IOSNative.Contacts.Contact)new SA.IOSNative.Contacts.Contact();
            }
            
            SA.IOSNative.Contacts.PhoneNumber val_6 = new SA.IOSNative.Contacts.PhoneNumber();
            typeof(SA.IOSNative.Contacts.PhoneNumber).__il2cppRuntimeField_10 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  val_1[3])[1];
            typeof(SA.IOSNative.Contacts.PhoneNumber).__il2cppRuntimeField_18 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  val_1[4])[1];
            if(null != 0)
            {
                goto label_22;
            }
            
            goto label_22;
        }
        private System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> ParseContactArray(string data)
        {
            SA.IOSNative.Contacts.Contact val_6;
            var val_7;
            val_6 = "|%|";
            typeof(System.String[]).__il2cppRuntimeField_20 = val_6;
            val_7 = 0;
            goto label_6;
            label_16:
            Add(item:  val_6);
            val_7 = 1;
            label_6:
            if(val_7 >= val_1.Length)
            {
                    return (System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>)new System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>();
            }
            
            val_6 = data.Split(separator:  null, options:  0)[1];
            bool val_3 = System.String.op_Equality(a:  0, b:  val_6);
            if(val_3 == true)
            {
                    return (System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>)new System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>();
            }
            
            SA.IOSNative.Contacts.Contact val_5 = val_3.ParseContactData(data:  val_1[0x1] + 32);
            if(null != 0)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        private void OnContactPickerDidCancel(string errorData)
        {
            System.Action<SA.IOSNative.Contacts.ContactsResult> val_4;
            var val_5;
            val_4 = this.ContactsPickResult;
            val_4.Invoke(obj:  new SA.IOSNative.Contacts.ContactsResult(error:  new SA.Common.Models.Error(code:  0, message:  "User Canceled")));
            val_5 = null;
            if((SA.IOSNative.Contacts.ContactStore.<>f__am$cache0) == null)
            {
                    System.Action<SA.IOSNative.Contacts.ContactsResult> val_3 = null;
                val_4 = val_3;
                val_3 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void SA.IOSNative.Contacts.ContactStore::<OnContactPickerDidCancel>m__0(SA.IOSNative.Contacts.ContactsResult ));
                SA.IOSNative.Contacts.ContactStore.<>f__am$cache0 = val_4;
                val_5 = null;
            }
            
            this.ContactsPickResult = SA.IOSNative.Contacts.ContactStore.<>f__am$cache0;
        }
        private void OnPickerDidSelectContacts(string data)
        {
            SA.IOSNative.Contacts.ContactsResult val_6;
            ISN_Logger.Log(message:  0, logType:  "[ContactStore] OnPickerDidSelectContacts");
            System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> val_1 = this.ParseContactArray(data:  data);
            ISN_Logger.Log(message:  0, logType:  0 + "[ContactStore] Picked " + val_1.Count);
            SA.IOSNative.Contacts.ContactsResult val_4 = null;
            val_6 = val_4;
            val_4 = new SA.IOSNative.Contacts.ContactsResult(contacts:  val_1);
            this.ContactsPickResult.Invoke(obj:  val_6);
            if((SA.IOSNative.Contacts.ContactStore.<>f__am$cache1) == null)
            {
                    System.Action<SA.IOSNative.Contacts.ContactsResult> val_5 = null;
                val_6 = val_5;
                val_5 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void SA.IOSNative.Contacts.ContactStore::<OnPickerDidSelectContacts>m__1(SA.IOSNative.Contacts.ContactsResult ));
                SA.IOSNative.Contacts.ContactStore.<>f__am$cache1 = val_6;
            }
            
            this.ContactsPickResult = SA.IOSNative.Contacts.ContactStore.<>f__am$cache1;
        }
        private void OnContactsRetrieveFailed(string errorData)
        {
            System.Action<SA.IOSNative.Contacts.ContactsResult> val_4;
            ISN_Logger.Log(message:  0, logType:  "[ContactStore] OnContactsRetrieveFailed");
            val_4 = this.ContactsLoadResult;
            val_4.Invoke(obj:  new SA.IOSNative.Contacts.ContactsResult(error:  new SA.Common.Models.Error(errorData:  errorData)));
            if((SA.IOSNative.Contacts.ContactStore.<>f__am$cache2) == null)
            {
                    System.Action<SA.IOSNative.Contacts.ContactsResult> val_3 = null;
                val_4 = val_3;
                val_3 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void SA.IOSNative.Contacts.ContactStore::<OnContactsRetrieveFailed>m__2(SA.IOSNative.Contacts.ContactsResult ));
                SA.IOSNative.Contacts.ContactStore.<>f__am$cache2 = val_4;
            }
            
            this.ContactsLoadResult = SA.IOSNative.Contacts.ContactStore.<>f__am$cache2;
        }
        private void OnContactsRetrieveFinished(string data)
        {
            SA.IOSNative.Contacts.ContactsResult val_6;
            ISN_Logger.Log(message:  0, logType:  "[ContactStore] OnContactsRetrieveFinished");
            System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> val_1 = this.ParseContactArray(data:  data);
            ISN_Logger.Log(message:  0, logType:  0 + "[ContactStore] Loaded " + val_1.Count);
            SA.IOSNative.Contacts.ContactsResult val_4 = null;
            val_6 = val_4;
            val_4 = new SA.IOSNative.Contacts.ContactsResult(contacts:  val_1);
            this.ContactsLoadResult.Invoke(obj:  val_6);
            if((SA.IOSNative.Contacts.ContactStore.<>f__am$cache3) == null)
            {
                    System.Action<SA.IOSNative.Contacts.ContactsResult> val_5 = null;
                val_6 = val_5;
                val_5 = new System.Action<SA.IOSNative.Contacts.ContactsResult>(object:  0, method:  static System.Void SA.IOSNative.Contacts.ContactStore::<OnContactsRetrieveFinished>m__3(SA.IOSNative.Contacts.ContactsResult ));
                SA.IOSNative.Contacts.ContactStore.<>f__am$cache3 = val_6;
            }
            
            this.ContactsLoadResult = SA.IOSNative.Contacts.ContactStore.<>f__am$cache3;
        }
        private static void <OnContactPickerDidCancel>m__0(SA.IOSNative.Contacts.ContactsResult )
        {
        
        }
        private static void <OnPickerDidSelectContacts>m__1(SA.IOSNative.Contacts.ContactsResult )
        {
        
        }
        private static void <OnContactsRetrieveFailed>m__2(SA.IOSNative.Contacts.ContactsResult )
        {
        
        }
        private static void <OnContactsRetrieveFinished>m__3(SA.IOSNative.Contacts.ContactsResult )
        {
        
        }
        private static void <ContactsLoadResult>m__4(SA.IOSNative.Contacts.ContactsResult )
        {
        
        }
        private static void <ContactsPickResult>m__5(SA.IOSNative.Contacts.ContactsResult )
        {
        
        }
    
    }

}
