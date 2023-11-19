using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    public class StoreProductView
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action Loaded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action LoadFailed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action Appeared;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action Dismissed;
        private int _id;
        private System.Collections.Generic.List<string> _ids;
        private static System.Action <>f__am$cache0;
        private static System.Action <>f__am$cache1;
        private static System.Action <>f__am$cache2;
        private static System.Action <>f__am$cache3;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public StoreProductView()
        {
            var val_10;
            var val_14;
            var val_15;
            val_10 = null;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache0) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache0 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<Loaded>m__0());
                val_10 = null;
            }
            
            this.Loaded = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache0;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache1) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache1 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<LoadFailed>m__1());
            }
            
            this.LoadFailed = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache1;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache2) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache2 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<Appeared>m__2());
            }
            
            this.Appeared = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache2;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache3) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache3 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<Dismissed>m__3());
            }
            
            this.Dismissed = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache3;
            this._ids = new System.Collections.Generic.List<System.String>();
            IOSNativeSettings val_6 = IOSNativeSettings.Instance;
            List.Enumerator<T> val_7 = val_6.DefaultStoreProductsView.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            this.addProductId(productId:  0.InitializationCallback);
            goto label_11;
            label_10:
            val_14 = 0;
            val_15 = 1;
            0.Dispose();
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RegisterProductView(view:  this);
        }
        public StoreProductView(string[] ids)
        {
            var val_7;
            var val_11;
            val_7 = null;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache0) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache0 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<Loaded>m__0());
                val_7 = null;
            }
            
            this.Loaded = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache0;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache1) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache1 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<LoadFailed>m__1());
            }
            
            this.LoadFailed = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache1;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache2) == null)
            {
                    SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache2 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<Appeared>m__2());
            }
            
            this.Appeared = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache2;
            if((SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache3) == null)
            {
                    System.Action val_4 = new System.Action(object:  0, method:  static System.Void SA.IOSNative.StoreKit.StoreProductView::<Dismissed>m__3());
                SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache3 = val_4;
            }
            
            this.Dismissed = SA.IOSNative.StoreKit.StoreProductView.<>f__am$cache3;
            this._ids = new System.Collections.Generic.List<System.String>();
            val_11 = 0;
            goto label_6;
            label_10:
            this.addProductId(productId:  ids[val_4]);
            val_11 = 1;
            label_6:
            if(val_11 >= ids.Length)
            {
                goto label_8;
            }
            
            if(val_11 < ids.Length)
            {
                goto label_10;
            }
            
            goto label_10;
            label_8:
            SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.RegisterProductView(view:  this);
        }
        public void add_Loaded(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.Loaded);
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
            while(1152921510325164528 != this.Loaded);
        
        }
        public void remove_Loaded(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.Loaded);
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
            while(1152921510325301104 != this.Loaded);
        
        }
        public void add_LoadFailed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.LoadFailed);
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
            while(1152921510325437688 != this.LoadFailed);
        
        }
        public void remove_LoadFailed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.LoadFailed);
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
            while(1152921510325574264 != this.LoadFailed);
        
        }
        public void add_Appeared(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.Appeared);
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
            while(1152921510325710848 != this.Appeared);
        
        }
        public void remove_Appeared(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.Appeared);
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
            while(1152921510325847424 != this.Appeared);
        
        }
        public void add_Dismissed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.Dismissed);
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
            while(1152921510325984008 != this.Dismissed);
        
        }
        public void remove_Dismissed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.Dismissed);
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
            while(1152921510326120584 != this.Dismissed);
        
        }
        public void addProductId(string productId)
        {
            if((this._ids.Contains(item:  productId)) != false)
            {
                    return;
            }
            
            this._ids.Add(item:  productId);
        }
        public void Load()
        {
        
        }
        public void Show()
        {
        
        }
        public int get_Id()
        {
            return (int)this._id;
        }
        public void OnProductViewAppeard()
        {
            this.Appeared.Invoke();
        }
        public void OnProductViewDismissed()
        {
            this.Dismissed.Invoke();
        }
        public void OnContentLoaded()
        {
            this.Loaded.Invoke();
        }
        public void OnContentLoadFailed()
        {
            this.LoadFailed.Invoke();
        }
        public void SetId(int viewId)
        {
            this._id = viewId;
        }
        private static void <Loaded>m__0()
        {
        
        }
        private static void <LoadFailed>m__1()
        {
        
        }
        private static void <Appeared>m__2()
        {
        
        }
        private static void <Dismissed>m__3()
        {
        
        }
    
    }

}
