using UnityEngine;

namespace SA.IOSNative.UserNotifications
{
    public class NotificationContent
    {
        // Fields
        public string Title;
        public string Subtitle;
        public string Body;
        public string Sound;
        public int Badge;
        public string LaunchImageName;
        public System.Collections.Generic.Dictionary<string, object> UserInfo;
        
        // Methods
        public NotificationContent()
        {
            null = null;
            this.Title = System.String.Empty;
            this.Subtitle = System.String.Empty;
            this.Body = System.String.Empty;
            this.Sound = System.String.Empty;
            this.LaunchImageName = System.String.Empty;
            this.UserInfo = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        public NotificationContent(System.Collections.Generic.Dictionary<string, object> contentDictionary)
        {
            var val_18;
            string val_19;
            string val_20;
            string val_21;
            string val_22;
            string val_23;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_24;
            val_18 = null;
            val_18 = null;
            this.Title = System.String.Empty;
            this.Subtitle = System.String.Empty;
            this.Body = System.String.Empty;
            this.Sound = System.String.Empty;
            this.LaunchImageName = System.String.Empty;
            this.UserInfo = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(contentDictionary.Item["title"] != null)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            val_19 = 0;
            label_5:
            this.Title = val_19;
            if(contentDictionary.Item["subtitle"] != null)
            {
                    if(null == null)
            {
                goto label_8;
            }
            
            }
            
            val_20 = 0;
            label_8:
            this.Subtitle = val_20;
            if(contentDictionary.Item["body"] != null)
            {
                    if(null == null)
            {
                goto label_11;
            }
            
            }
            
            val_21 = 0;
            label_11:
            this.Body = val_21;
            if(contentDictionary.Item["sound"] != null)
            {
                    if(null == null)
            {
                goto label_14;
            }
            
            }
            
            val_22 = 0;
            label_14:
            this.Sound = val_22;
            if(contentDictionary.Item["launchImageName"] != null)
            {
                    if(null == null)
            {
                goto label_17;
            }
            
            }
            
            val_23 = 0;
            label_17:
            this.LaunchImageName = val_23;
            object val_12 = contentDictionary.Item["badge"];
            this.Badge = System.Int32.Parse(s:  0);
            object val_14 = contentDictionary.Item["userInfo"];
            object val_15 = SA.Common.Data.Json.Deserialize(json:  0);
            val_24 = 0;
            if(val_15 != null)
            {
                    val_24 = val_15;
                val_24 = 0;
            }
            
            this.UserInfo = val_24;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.Title;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.Subtitle;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.Body;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.Sound;
            typeof(System.Object[]).__il2cppRuntimeField_40 = this.Badge;
            typeof(System.Object[]).__il2cppRuntimeField_44 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_48 = this.LaunchImageName;
            typeof(System.Object[]).__il2cppRuntimeField_50 = SA.Common.Data.Json.Serialize(obj:  0);
            return (string)0 + "{" + System.String.Format(format:  0, args:  "\"title\" : \"{0}\", \"subtitle\" : \"{1}\", \"body\" : \"{2}\", \"sound\" : \"{3}\", \"badge\" : {4}, \"launchImageName\" : \"{5}\", \"userInfo\" : {6}")(System.String.Format(format:  0, args:  "\"title\" : \"{0}\", \"subtitle\" : \"{1}\", \"body\" : \"{2}\", \"sound\" : \"{3}\", \"badge\" : {4}, \"launchImageName\" : \"{5}\", \"userInfo\" : {6}"));
        }
    
    }

}
