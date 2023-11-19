using UnityEngine;

namespace SA.IOSNative.StoreKit
{
    [Serializable]
    public class Product
    {
        // Fields
        public bool IsOpen;
        [UnityEngine.SerializeField]
        private bool _IsAvailable;
        [UnityEngine.SerializeField]
        private string _Id;
        [UnityEngine.SerializeField]
        private string _DisplayName;
        [UnityEngine.SerializeField]
        private string _Description;
        [UnityEngine.SerializeField]
        private float _Price;
        [UnityEngine.SerializeField]
        private string _LocalizedPrice;
        [UnityEngine.SerializeField]
        private string _CurrencySymbol;
        [UnityEngine.SerializeField]
        private string _CurrencyCode;
        [UnityEngine.SerializeField]
        private UnityEngine.Texture2D _Texture;
        [UnityEngine.SerializeField]
        private SA.IOSNative.StoreKit.ProductType _ProductType;
        [UnityEngine.SerializeField]
        private SA.IOSNative.StoreKit.PriceTier _PriceTier;
        
        // Properties
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public SA.IOSNative.StoreKit.ProductType Type { get; set; }
        public float Price { get; set; }
        public long PriceInMicros { get; }
        public string LocalizedPrice { get; set; }
        public string CurrencySymbol { get; set; }
        public string CurrencyCode { get; set; }
        public UnityEngine.Texture2D Texture { get; set; }
        public SA.IOSNative.StoreKit.PriceTier PriceTier { get; set; }
        public bool IsAvailable { get; set; }
        
        // Methods
        public Product()
        {
            var val_1;
            this.IsOpen = true;
            val_1 = null;
            val_1 = null;
            this._Id = System.String.Empty;
            this._Price = 0.99f;
            this._DisplayName = "New Product";
            this._LocalizedPrice = System.String.Empty;
            this._CurrencySymbol = "$";
            this._CurrencyCode = "USD";
        }
        public void UpdatePriceByTier()
        {
            this._Price = SA.IOSNative.StoreKit.SK_Util.GetPriceByTier(priceTier:  this);
        }
        public string get_Id()
        {
            return (string)this._Id;
        }
        public void set_Id(string value)
        {
            this._Id = value;
        }
        public string get_DisplayName()
        {
            return (string)this._DisplayName;
        }
        public void set_DisplayName(string value)
        {
            this._DisplayName = value;
        }
        public string get_Description()
        {
            return (string)this._Description;
        }
        public void set_Description(string value)
        {
            this._Description = value;
        }
        public SA.IOSNative.StoreKit.ProductType get_Type()
        {
            return (SA.IOSNative.StoreKit.ProductType)this._ProductType;
        }
        public void set_Type(SA.IOSNative.StoreKit.ProductType value)
        {
            this._ProductType = value;
        }
        public float get_Price()
        {
            return (float)this._Price;
        }
        public void set_Price(float value)
        {
            this._Price = value;
        }
        public long get_PriceInMicros()
        {
            float val_1 = 1000000f;
            val_1 = this._Price * val_1;
            return System.Convert.ToInt64(value:  val_1);
        }
        public string get_LocalizedPrice()
        {
            string val_3;
            var val_4;
            string val_5;
            val_3 = this;
            val_4 = null;
            val_4 = null;
            if((this._LocalizedPrice.Equals(value:  System.String.Empty)) != false)
            {
                    val_3 = this._CurrencySymbol;
                string val_2 = 0 + this._Price + " ";
                return val_5;
            }
            
            val_5 = this._LocalizedPrice;
            return val_5;
        }
        public void set_LocalizedPrice(string value)
        {
            this._LocalizedPrice = value;
        }
        public string get_CurrencySymbol()
        {
            return (string)this._CurrencySymbol;
        }
        public void set_CurrencySymbol(string value)
        {
            this._CurrencySymbol = value;
        }
        public string get_CurrencyCode()
        {
            return (string)this._CurrencyCode;
        }
        public void set_CurrencyCode(string value)
        {
            this._CurrencyCode = value;
        }
        public UnityEngine.Texture2D get_Texture()
        {
            return (UnityEngine.Texture2D)this._Texture;
        }
        public void set_Texture(UnityEngine.Texture2D value)
        {
            this._Texture = value;
        }
        public SA.IOSNative.StoreKit.PriceTier get_PriceTier()
        {
            return (SA.IOSNative.StoreKit.PriceTier)this._PriceTier;
        }
        public void set_PriceTier(SA.IOSNative.StoreKit.PriceTier value)
        {
            this._PriceTier = value;
        }
        public bool get_IsAvailable()
        {
            return (bool)this._IsAvailable;
        }
        public void set_IsAvailable(bool value)
        {
            this._IsAvailable = value;
        }
    
    }

}
