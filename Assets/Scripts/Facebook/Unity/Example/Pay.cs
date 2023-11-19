using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class Pay : MenuBase
    {
        // Fields
        private string payProduct;
        
        // Methods
        public Pay()
        {
            null = null;
            this.payProduct = System.String.Empty;
        }
        protected override void GetGui()
        {
            this.LabelAndTextField(label:  "Product: ", text: ref  this.payProduct);
            if((this.Button(label:  "Call Pay")) != false)
            {
                    this.CallFBPay();
            }
            
            UnityEngine.GUILayout.Space(pixels:  10f);
        }
        private void CallFBPay()
        {
            Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> val_1 = new Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result));
            FB.Canvas.Pay(product:  0, action:  this.payProduct, quantity:  -1352732688, quantityMin:  new System.Nullable<System.Int32>() {HasValue = true}, quantityMax:  new System.Nullable<System.Int32>() {HasValue = false}, requestId:  0, pricepointId:  0, testCurrency:  0, callback:  0);
        }
    
    }

}
