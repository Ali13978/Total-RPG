using UnityEngine;

namespace SA.IOSNative.Contacts
{
    public class ContactsResult : Result
    {
        // Fields
        private System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> _Contacts;
        
        // Properties
        public System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> Contacts { get; }
        
        // Methods
        public ContactsResult(System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> contacts)
        {
            this._Contacts = new System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>();
            this = new System.Object();
            this._Contacts = contacts;
        }
        public ContactsResult(SA.Common.Models.Error error)
        {
            this._Contacts = new System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>();
            this = new System.Object();
            mem[1152921510336854688] = error;
        }
        public System.Collections.Generic.List<SA.IOSNative.Contacts.Contact> get_Contacts()
        {
            return (System.Collections.Generic.List<SA.IOSNative.Contacts.Contact>)this._Contacts;
        }
    
    }

}
