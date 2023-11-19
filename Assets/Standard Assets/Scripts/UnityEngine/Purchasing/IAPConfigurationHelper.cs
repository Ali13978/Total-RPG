using UnityEngine;

namespace UnityEngine.Purchasing
{
    public static class IAPConfigurationHelper
    {
        // Methods
        public static void PopulateConfigurationBuilder(ref UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.Purchasing.ProductCatalog catalog)
        {
            var val_31;
            var val_32;
            UnityEngine.Purchasing.ProductType val_33;
            System.Collections.Generic.List<T> val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            string val_46;
            var val_47;
            var val_48;
            System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> val_1 = X2.allValidProducts;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_32 = val_1;
            val_33 = val_1;
            val_34 = 0;
            goto label_91;
            label_99:
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_35 = val_33;
            System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> val_4 = val_33.allStoreIDs;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_36 = val_4;
            if(val_4 < 1)
            {
                goto label_52;
            }
            
            UnityEngine.Purchasing.IDs val_6 = new UnityEngine.Purchasing.IDs();
            System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> val_7 = val_33.allStoreIDs;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_37 = val_7;
            label_44:
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_38 = val_7;
            if(((val_7 & 1) & 1) == 0)
            {
                goto label_93;
            }
            
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_39 = val_7;
            typeof(System.String[]).__il2cppRuntimeField_20 = val_7;
            Add(id:  X25, stores:  null);
            goto label_44;
            label_93:
            if(val_7 != null)
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                val_40 = val_7;
            }
            
            if(0 == 134)
            {
                
            }
            
            label_52:
            System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> val_13 = new System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition>();
            System.Collections.Generic.IList<UnityEngine.Purchasing.ProductCatalogPayout> val_14 = val_33.Payouts;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_41 = val_14;
            label_76:
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_42 = val_14;
            if(((val_14 & 1) & 1) == 0)
            {
                goto label_92;
            }
            
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_43 = val_14;
            UnityEngine.Purchasing.PayoutDefinition val_23 = new UnityEngine.Purchasing.PayoutDefinition(typeString:  val_14.typeString, subtype:  val_14.subtype, quantity:  val_14.quantity, data:  val_14.data);
            Add(item:  null);
            goto label_76;
            label_92:
            if(val_14 != null)
            {
                    var val_41 = 0;
                val_41 = val_41 + 1;
                val_44 = val_14;
            }
            
            if(0 == 240)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_34 = 0;
            }
            else
            {
                    val_34 = 0;
            }
            
            }
            
            val_45 = mem[catalog];
            val_45 = catalog;
            if(val_33 != null)
            {
                
            }
            else
            {
                    val_46 = 11993091;
            }
            
            UnityEngine.Purchasing.ConfigurationBuilder val_26 = val_45.AddProduct(id:  val_46, type:  val_33, storeIDs:  null, payouts:  ToArray());
            label_91:
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_47 = val_33;
            if(((val_33 & 1) & 1) != 0)
            {
                goto label_99;
            }
            
            if(val_33 != null)
            {
                    var val_43 = 0;
                val_43 = val_43 + 1;
                val_48 = val_33;
            }
            
            if((0 != 297) && ( != 0))
            {
                    val_31 = ???;
                val_33 = ???;
                val_34 = ???;
                val_45 = ???;
            }
            
            var val_30 = val_31 - 96;
        }
    
    }

}
