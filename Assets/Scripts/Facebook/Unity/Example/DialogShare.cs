using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class DialogShare : MenuBase
    {
        // Fields
        private string shareLink;
        private string shareTitle;
        private string shareDescription;
        private string shareImage;
        private string feedTo;
        private string feedLink;
        private string feedTitle;
        private string feedCaption;
        private string feedDescription;
        private string feedImage;
        private string feedMediaSource;
        
        // Methods
        public DialogShare()
        {
            var val_1;
            this.shareLink = "https://developers.facebook.com/";
            this.shareTitle = "Link Title";
            this.shareDescription = "Link Description";
            this.shareImage = "http://i.imgur.com/j4M7vCO.jpg";
            val_1 = null;
            val_1 = null;
            this.feedTo = System.String.Empty;
            this.feedLink = "https://developers.facebook.com/";
            this.feedTitle = "Test Title";
            this.feedCaption = "Test Caption";
            this.feedDescription = "Test Description";
            this.feedImage = "http://i.imgur.com/zkYlB.jpg";
            this.feedMediaSource = System.String.Empty;
        }
        protected override bool ShowDialogModeSelector()
        {
            return true;
        }
        protected override void GetGui()
        {
            var val_41;
            var val_42;
            var val_43;
            string val_44;
            string val_45;
            string val_46;
            string val_47;
            var val_48;
            var val_49;
            string val_50;
            string val_51;
            string val_52;
            val_41 = 1152921504742842368;
            val_42 = UnityEngine.GUI.enabled;
            if((this.Button(label:  "Share - Link")) != false)
            {
                    val_43 = null;
                val_43 = null;
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> val_4 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.ShareLink(contentURL:  0, contentTitle:  new System.Uri(uriString:  "https://developers.facebook.com/"), contentDescription:  System.String.Empty, photoURL:  System.String.Empty, callback:  0);
            }
            
            if((this.Button(label:  "Share - Link Photo")) != false)
            {
                    Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> val_8 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.ShareLink(contentURL:  0, contentTitle:  new System.Uri(uriString:  "https://developers.facebook.com/"), contentDescription:  "Link Share", photoURL:  "Look I\'m sharing a link", callback:  new System.Uri(uriString:  "http://i.imgur.com/j4M7vCO.jpg"));
            }
            
            val_44 = "Link";
            this.LabelAndTextField(label:  "Link", text: ref  this.shareLink);
            val_45 = "Title";
            this.LabelAndTextField(label:  "Title", text: ref  this.shareTitle);
            val_46 = "Description";
            this.LabelAndTextField(label:  "Description", text: ref  this.shareDescription);
            val_47 = "Image";
            this.LabelAndTextField(label:  "Image", text: ref  this.shareImage);
            if((this.Button(label:  "Share - Custom")) != false)
            {
                    Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> val_16 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.ShareLink(contentURL:  0, contentTitle:  new System.Uri(uriString:  this.shareLink), contentDescription:  this.shareTitle, photoURL:  this.shareDescription, callback:  new System.Uri(uriString:  this.shareImage));
                val_41 = val_41;
                val_46 = val_46;
                val_47 = "Image";
                val_44 = "Link";
                val_45 = "Title";
            }
            
            if(val_42 == false)
            {
                goto label_16;
            }
            
            if(Facebook.Unity.Constants.IsEditor == false)
            {
                goto label_15;
            }
            
            if(Facebook.Unity.Constants.IsEditor == false)
            {
                goto label_16;
            }
            
            val_48 = Facebook.Unity.FB.IsLoggedIn;
            goto label_20;
            label_16:
            val_48 = 0;
            goto label_20;
            label_15:
            val_48 = 1;
            label_20:
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Feed Share - No To")) != false)
            {
                    val_49 = null;
                val_49 = null;
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> val_23 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
                Facebook.Unity.FB.FeedShare(toId:  0, link:  System.String.Empty, linkName:  new System.Uri(uriString:  "https://developers.facebook.com/"), linkCaption:  "Test Title", linkDescription:  "Test caption", picture:  "Test Description", mediaSource:  new System.Uri(uriString:  "http://i.imgur.com/zkYlB.jpg"), callback:  System.String.Empty);
                val_44 = "Link";
                val_45 = "Title";
            }
            
            val_50 = this.feedTo;
            this.LabelAndTextField(label:  "To", text: ref  val_50);
            this.LabelAndTextField(label:  val_44, text: ref  this.feedLink);
            this.LabelAndTextField(label:  val_45, text: ref  this.feedTitle);
            val_51 = this.feedCaption;
            this.LabelAndTextField(label:  "Caption", text: ref  val_51);
            val_52 = this.feedDescription;
            this.LabelAndTextField(label:  val_46, text: ref  val_52);
            this.LabelAndTextField(label:  val_47, text: ref  this.feedImage);
            this.LabelAndTextField(label:  "Media Source", text: ref  this.feedMediaSource);
            if((this.Button(label:  "Feed Share - Custom")) != false)
            {
                    val_45 = 0;
                if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    System.Uri val_34 = null;
                val_45 = val_34;
                val_34 = new System.Uri(uriString:  mem[this.feedLink]);
            }
            
                val_51 = mem[this.feedDescription];
                val_50 = val_42;
                val_52 = 0;
                if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    System.Uri val_37 = null;
                val_52 = val_37;
                val_37 = new System.Uri(uriString:  mem[this.feedImage]);
            }
            
                val_47 = System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result);
                Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> val_38 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  val_47);
                Facebook.Unity.FB.FeedShare(toId:  0, link:  mem[this.feedTo], linkName:  val_45, linkCaption:  mem[this.feedTitle], linkDescription:  mem[this.feedCaption], picture:  val_51, mediaSource:  val_52, callback:  this.feedMediaSource);
                val_42 = val_50;
            }
            
            bool val_39 = val_42;
            UnityEngine.GUI.enabled = false;
        }
    
    }

}
