using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class TokenResultCallback : ResultCallbackProxy<GooglePlayGames.Android.TokenResult>
    {
        // Fields
        private System.Action<int, string, string, string> callback;
        
        // Methods
        public TokenResultCallback(System.Action<int, string, string, string> callback)
        {
            this.callback = callback;
        }
        public override void OnResult(GooglePlayGames.Android.TokenResult arg_Result_1)
        {
            int val_8;
            string val_9;
            string val_10;
            if(this.callback == null)
            {
                    return;
            }
            
            if(arg_Result_1 != null)
            {
                    val_8 = arg_Result_1.getStatusCode();
                val_9 = arg_Result_1.getAuthCode();
                val_10 = arg_Result_1.getEmail();
            }
            else
            {
                    val_8 = 0.getStatusCode();
                val_9 = 0.getAuthCode();
                val_10 = 0.getEmail();
            }
            
            this.callback.Invoke(arg1:  val_8, arg2:  val_9, arg3:  val_10, arg4:  arg_Result_1.getIdToken());
        }
        public override string toString()
        {
            return this.ToString();
        }
    
    }

}
