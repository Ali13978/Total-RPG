using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_Main : TranslationJob
    {
        // Fields
        private I2.Loc.TranslationJob_WEB mWeb;
        private I2.Loc.TranslationJob_POST mPost;
        private I2.Loc.TranslationJob_GET mGet;
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        public string mErrorMessage;
        
        // Methods
        public TranslationJob_Main(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            this.mPost = new I2.Loc.TranslationJob_POST(requests:  requests, OnTranslationReady:  OnTranslationReady);
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_3;
            System.Action<System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery>, System.String> val_4;
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_5;
            var val_6;
            if(this.mWeb == null)
            {
                goto label_5;
            }
            
            if(this.mWeb == null)
            {
                goto label_14;
            }
            
            if(this.mWeb == 2)
            {
                goto label_3;
            }
            
            if(this.mWeb != 1)
            {
                goto label_5;
            }
            
            mem[1152921512256144160] = 1;
            goto label_5;
            label_3:
            this.mWeb.Dispose();
            this.mWeb = 0;
            val_4 = this._OnTranslationReady;
            I2.Loc.TranslationJob_POST val_1 = null;
            val_3 = this._requests;
            val_1 = new I2.Loc.TranslationJob_POST(requests:  val_3, OnTranslationReady:  val_4);
            this.mPost = val_1;
            label_5:
            if(this.mPost == null)
            {
                goto label_11;
            }
            
            if(this.mPost == null)
            {
                goto label_14;
            }
            
            if(this.mPost == 2)
            {
                goto label_9;
            }
            
            if(this.mPost != 1)
            {
                goto label_11;
            }
            
            mem[1152921512256144160] = 1;
            goto label_11;
            label_9:
            this.mPost.Dispose();
            this.mPost = 0;
            val_4 = this._OnTranslationReady;
            I2.Loc.TranslationJob_GET val_2 = null;
            val_3 = this._requests;
            val_2 = new I2.Loc.TranslationJob_GET(requests:  val_3, OnTranslationReady:  val_4);
            this.mGet = val_2;
            label_11:
            if(this.mGet == null)
            {
                    return (eJobState)this.mGet;
            }
            
            if(this.mGet == null)
            {
                goto label_14;
            }
            
            if(this.mGet == 2)
            {
                goto label_15;
            }
            
            if(this.mGet != 1)
            {
                    return (eJobState)this.mGet;
            }
            
            mem[1152921512256144160] = 1;
            return (eJobState)this.mGet;
            label_14:
            val_6 = 0;
            return (eJobState)this.mGet;
            label_15:
            this.mErrorMessage = this.mGet.mErrorMessage;
            if(this._OnTranslationReady != null)
            {
                    val_5 = this._requests;
                this._OnTranslationReady.Invoke(arg1:  val_5, arg2:  this.mGet.mErrorMessage);
            }
            
            this.mGet.Dispose();
            this.mGet = 0;
            return (eJobState)this.mGet;
        }
        public override void Dispose()
        {
            if(this.mPost != null)
            {
                    this.mPost.Dispose();
            }
            
            if(this.mGet != null)
            {
                    this.mGet.Dispose();
            }
            
            this.mPost = 0;
            this.mGet = 0;
        }
    
    }

}
