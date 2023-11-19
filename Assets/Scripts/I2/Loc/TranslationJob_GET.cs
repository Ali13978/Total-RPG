using UnityEngine;

namespace I2.Loc
{
    public class TranslationJob_GET : TranslationJob_WWW
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> _requests;
        private System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> _OnTranslationReady;
        private System.Collections.Generic.List<string> mQueries;
        public string mErrorMessage;
        
        // Methods
        public TranslationJob_GET(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> requests, System.Action<System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery>, string> OnTranslationReady)
        {
            this = new System.Object();
            this._requests = requests;
            this._OnTranslationReady = OnTranslationReady;
            this.mQueries = I2.Loc.GoogleTranslation.ConvertTranslationRequest(requests:  0, encodeGET:  requests);
            goto typeof(I2.Loc.TranslationJob_GET).__il2cppRuntimeField_160;
        }
        private void ExecuteNextQuery()
        {
            if(this.mQueries.Count != 0)
            {
                    int val_3 = this.mQueries.Count - 1;
                string val_4 = this.mQueries.Item[val_3];
                this.mQueries.RemoveAt(index:  val_3);
                UnityEngine.WWW val_7 = null;
                1152921509084995904 = val_7;
                val_7 = new UnityEngine.WWW(url:  System.String.Format(format:  0, arg0:  "{0}?action=Translate&list={1}", arg1:  I2.Loc.LocalizationManager.GetWebServiceURL(source:  0)));
                mem[1152921512255387944] = 1152921509084995904;
                return;
            }
            
            mem[1152921512255387936] = 1;
        }
        public override I2.Loc.TranslationJob.eJobState GetState()
        {
            if(this != null)
            {
                    if(this.isDone != false)
            {
                    System.Byte[] val_2 = X20.bytes;
                this.ProcessResult(bytes:  val_2, errorMsg:  X21.error);
                val_2.Dispose();
                mem[1152921512255569576] = 0;
            }
            else
            {
                    if(X20 != 0)
            {
                    return (eJobState)this;
            }
            
            }
            
            }
            
            this.ExecuteNextQuery();
            return (eJobState)this;
        }
        public void ProcessResult(byte[] bytes, string errorMsg)
        {
            string val_5 = errorMsg;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_5 = I2.Loc.GoogleTranslation.ParseTranslationResult(html:  0, requests:  System.Text.Encoding.UTF8);
                if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    if(this._OnTranslationReady == null)
            {
                    return;
            }
            
                this._OnTranslationReady.Invoke(arg1:  this._requests, arg2:  0);
                return;
            }
            
            }
            
            mem[1152921512255784992] = 2;
            this.mErrorMessage = val_5;
        }
    
    }

}
