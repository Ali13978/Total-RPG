using UnityEngine;

namespace TzarGames
{
    public class HttpApi
    {
        // Methods
        public HttpApi()
        {
        
        }
        public static TzarGames.HttpRequest Request(string url)
        {
            initUpdater();
            createRequest(url:  X1);
            return (TzarGames.HttpRequest)new System.Object();
        }
        public static TzarGames.HttpRequest Request(string url, byte[] postData)
        {
            return (TzarGames.HttpRequest)new TzarGames.HttpRequest(url:  postData, postData:  X2, customHeaders:  0);
        }
        public static TzarGames.HttpRequest Request(string url, TzarGames.HttpForm form)
        {
            return (TzarGames.HttpRequest)new TzarGames.HttpRequest(url:  form, form:  X2);
        }
        public static TzarGames.HttpRequest Request(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> customHeaders)
        {
            return (TzarGames.HttpRequest)new TzarGames.HttpRequest(url:  postData, postData:  customHeaders, customHeaders:  X3);
        }
    
    }

}
