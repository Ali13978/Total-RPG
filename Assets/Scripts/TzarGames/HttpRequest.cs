using UnityEngine;

namespace TzarGames
{
    public class HttpRequest
    {
        // Fields
        private string _url;
        private byte[] _postData;
        private TzarGames.HttpRestMethods _method;
        private System.Collections.Generic.Dictionary<string, string> _customHeaders;
        private TzarGames.HttpForm _form;
        private static TzarGames.UpdateHelper _updateHelper;
        private UnityEngine.WWW _www;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.HttpRequest.requestDlg OnRequestDone;
        
        // Properties
        public string ErrorText { get; }
        public int StatusCode { get; }
        public bool Success { get; }
        public bool isDone { get; }
        public string Text { get; }
        public byte[] Data { get; }
        public UnityEngine.Texture2D Image { get; }
        
        // Methods
        public HttpRequest(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> customHeaders)
        {
            val_1 = new System.Object();
            this._url = url;
            this._postData = postData;
            this._customHeaders = val_1;
            this.initUpdater();
            this.createRequest(url:  this._url, postData:  this._postData, headers:  this._customHeaders);
        }
        public HttpRequest(string url)
        {
            this.initUpdater();
            this.createRequest(url:  url);
        }
        public HttpRequest(string url, TzarGames.HttpForm form)
        {
            val_1 = new System.Object();
            this._url = url;
            this._form = val_1;
            this.initUpdater();
            this.createRequest(url:  this._url, form:  this._form);
        }
        public string get_ErrorText()
        {
            var val_3;
            string val_1 = this._www.error;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_3 = null;
                val_3 = null;
                return (string)System.String.Empty;
            }
            
            if(this._www != null)
            {
                    return this._www.error;
            }
            
            return this._www.error;
        }
        public int get_StatusCode()
        {
            var val_9;
            var val_10;
            val_9 = this;
            if(this._www.isDone == false)
            {
                goto label_2;
            }
            
            string val_2 = this._www.error;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_6;
            }
            
            val_10 = 200;
            return (int)val_10;
            label_2:
            val_10 = 0;
            return (int)val_10;
            label_6:
            typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
            val_9 = this._www.error.Split(separator:  null);
            bool val_8 = System.Int32.TryParse(s:  0, result: out  val_9[0]);
            val_10 = 0;
            return (int)val_10;
        }
        public bool get_Success()
        {
            var val_5;
            if(this._www.isDone != false)
            {
                    var val_4 = ((this.StatusCode - 200) < 100) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public bool get_isDone()
        {
            if(this._www != null)
            {
                    return this._www.isDone;
            }
            
            return this._www.isDone;
        }
        public string get_Text()
        {
            if(this._www != null)
            {
                    return this._www.text;
            }
            
            return this._www.text;
        }
        public byte[] get_Data()
        {
            if(this._www != null)
            {
                    return this._www.bytes;
            }
            
            return this._www.bytes;
        }
        public UnityEngine.Texture2D get_Image()
        {
            if(this._www != null)
            {
                    return this._www.texture;
            }
            
            return this._www.texture;
        }
        public void add_OnRequestDone(TzarGames.HttpRequest.requestDlg value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnRequestDone);
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
            while(1152921511626676864 != this.OnRequestDone);
        
        }
        public void remove_OnRequestDone(TzarGames.HttpRequest.requestDlg value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnRequestDone);
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
            while(1152921511626813440 != this.OnRequestDone);
        
        }
        private void createRequest(string url)
        {
            this._www = new UnityEngine.WWW(url:  url);
        }
        private void createRequest(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers)
        {
            this._www = new UnityEngine.WWW(url:  url, postData:  postData, headers:  headers);
        }
        private void createRequest(string url, TzarGames.HttpForm form)
        {
            var val_6;
            TzarGames.HttpRequest val_28;
            var val_29;
            var val_30;
            var val_31;
            val_28 = this;
            var val_2 = (form._method < 5) ? (form._method + 5) : 0;
            if(val_2 > 9)
            {
                    return;
            }
            
            var val_3 = val_2 & 65535;
            val_3 = 993 >> val_3;
            if((val_3 & 1) == 0)
            {
                    return;
            }
            
            if(form._method == 0)
            {
                goto label_6;
            }
            
            if(form._binaryData != null)
            {
                    AddBinaryData(fieldName:  "binary", contents:  form._binaryData, fileName:  form.binaryFileName, mimeType:  form.mimeType);
            }
            
            AddField(fieldName:  "_method", value:  33130720 + (form._method < 0x5 ? (form._method + 5) : 0) << 3);
            Dictionary.Enumerator<TKey, TValue> val_5 = form._parameters.GetEnumerator();
            label_34:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            UnityEngine.Playables.PlayableHandle val_8 = val_6.GetHandle();
            if(val_8.m_Handle == 0)
            {
                goto label_34;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_8.m_Handle)) == false)
            {
                goto label_16;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_12 = val_8.m_Handle.InitializationCallback;
            if(val_12 != null)
            {
                    val_29 = null;
            }
            
            val_29 = null;
            var val_13 = (((System.Action<T>.__il2cppRuntimeField_typeHierarchy + (TzarGames.StringParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_29) ? (val_12) : 0;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_14 = val_8.m_Handle.InitializationCallback;
            if(val_14 != null)
            {
                    val_30 = null;
            }
            
            val_30 = null;
            var val_15 = (((System.Action<T>.__il2cppRuntimeField_typeHierarchy + (TzarGames.StringParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_30) ? (val_14) : 0;
            AddField(fieldName:  val_8.m_Handle.InitializationCallback, value:  (System.Action<T>.__il2cppRuntimeField_typeHierarchy + (TzarGames.StringParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_29 ? val_12 : 0 + 24, e:  (System.Action<T>.__il2cppRuntimeField_typeHierarchy + (TzarGames.StringParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_30 ? val_14 : 0 + 32);
            goto label_34;
            label_16:
            if((System.String.op_Equality(a:  0, b:  val_8.m_Handle)) == false)
            {
                goto label_34;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_19 = val_8.m_Handle.InitializationCallback;
            if(val_19 != null)
            {
                    val_31 = null;
            }
            
            val_31 = null;
            var val_20 = (((System.Action<T>.__il2cppRuntimeField_typeHierarchy + (TzarGames.IntParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_31) ? (val_19) : 0;
            AddField(fieldName:  val_8.m_Handle.InitializationCallback, i:  (System.Action<T>.__il2cppRuntimeField_typeHierarchy + (TzarGames.IntParameter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_31 ? val_19 : 0 + 24);
            goto label_34;
            label_6:
            this._www = new UnityEngine.WWW(url:  url);
            return;
            label_12:
            val_6.Dispose();
            Dictionary.Enumerator<TKey, TValue> val_22 = form._headers.GetEnumerator();
            label_43:
            if((0 & 1) == 0)
            {
                goto label_46;
            }
            
            UnityEngine.Playables.PlayableHandle val_23 = 0.GetHandle();
            headers.Add(key:  val_23.m_Handle.InitializationCallback, value:  val_23.m_Handle);
            goto label_43;
            label_46:
            0.Dispose();
            mem[1152921511627360552] = new UnityEngine.WWW(url:  url, form:  new UnityEngine.WWWForm());
        }
        private void updateFunc()
        {
            var val_3;
            if(this._www.isDone == false)
            {
                    return;
            }
            
            if(this.OnRequestDone != null)
            {
                    this.OnRequestDone.Invoke(request:  this);
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.HttpRequest._updateHelper.remove_OnUpdate(value:  new TzarGames.Common.TG_VoidDelegate(object:  this, method:  System.Void TzarGames.HttpRequest::updateFunc()));
        }
        private void initUpdater()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(0 == TzarGames.HttpRequest._updateHelper)
            {
                    UnityEngine.GameObject val_2 = new UnityEngine.GameObject();
                if(null != 0)
            {
                    hideFlags = 61;
            }
            else
            {
                    0.hideFlags = 61;
            }
            
                val_6 = null;
                val_6 = null;
                TzarGames.HttpRequest._updateHelper = AddComponent<TzarGames.UpdateHelper>();
            }
            
            val_7 = null;
            val_7 = null;
            TzarGames.HttpRequest._updateHelper.add_OnUpdate(value:  new TzarGames.Common.TG_VoidDelegate(object:  this, method:  System.Void TzarGames.HttpRequest::updateFunc()));
        }
        private static HttpRequest()
        {
        
        }
    
    }

}
