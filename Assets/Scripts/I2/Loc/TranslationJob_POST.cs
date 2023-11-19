using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_POST : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        
        // Methods
        public TranslationJob_POST(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            AddField(fieldName:  "action", value:  "Translate");
            AddField(fieldName:  "list", value:  I2.Loc.GoogleTranslation.ConvertTranslationRequest(requests:  0, encodeGET:  requests).Item[0]);
            mem[1152921512256462552] = new UnityEngine.WWW(url:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0), form:  new UnityEngine.WWWForm());
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this == null)
            {
                    return (eJobState)val_2;
            }
            
            if(this.isDone == false)
            {
                    return (eJobState)val_2;
            }
            
            System.Byte[] val_2 = X20.bytes;
            this.ProcessResult(bytes:  val_2, errorMsg:  X21.error);
            val_2.Dispose();
            mem[1152921512256635992] = 0;
            return (eJobState)val_2;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_5;
            var val_6;
            val_5 = errorMsg;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_5 = System.Text.Encoding.UTF8;
                if(this._OnTranslationReady != null)
            {
                    this._OnTranslationReady.Invoke(arg1:  this._requests, arg2:  I2.Loc.GoogleTranslation.ParseTranslationResult(html:  0, requests:  val_5));
            }
            
                val_6 = 1;
            }
            else
            {
                    val_6 = 2;
            }
            
            mem[1152921512256850384] = val_6;
        }
    
    }

}
