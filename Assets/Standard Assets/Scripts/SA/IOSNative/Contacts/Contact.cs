using UnityEngine;

namespace SA.IOSNative.Contacts
{
    public class Contact
    {
        // Fields
        public string GivenName;
        public string FamilyName;
        public System.Collections.Generic.List<string> Emails;
        public System.Collections.Generic.List<SA.IOSNative.Contacts.PhoneNumber> PhoneNumbers;
        
        // Methods
        public Contact()
        {
            null = null;
            this.GivenName = System.String.Empty;
            this.FamilyName = System.String.Empty;
            this.Emails = new System.Collections.Generic.List<System.String>();
            this.PhoneNumbers = new System.Collections.Generic.List<SA.IOSNative.Contacts.PhoneNumber>();
        }
    
    }

}
