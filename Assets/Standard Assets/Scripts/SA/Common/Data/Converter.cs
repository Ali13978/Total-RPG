using UnityEngine;

namespace SA.Common.Data
{
    public class Converter
    {
        // Fields
        public const char DATA_SPLITTER = '\x7c';
        public const string DATA_SPLITTER2 = "|%|";
        public const string ARRAY_SPLITTER = "%%%";
        public const string DATA_EOF = "endofline";
        
        // Methods
        public Converter()
        {
        
        }
        public static string SerializeArray(System.Collections.Generic.List<string> array, string splitter = "%%%")
        {
            T[] val_1 = splitter.ToArray();
            return SA.Common.Data.Converter.SerializeArray(array:  val_1, splitter:  val_1);
        }
        public static string SerializeArray(string[] array, string splitter = "%%%")
        {
            var val_6;
            var val_8;
            var val_9;
            string val_10;
            string val_11;
            string val_12;
            var val_13;
            val_6 = X2;
            if(splitter == null)
            {
                goto label_1;
            }
            
            val_8 = null;
            if(W24 == 0)
            {
                goto label_2;
            }
            
            val_9 = null;
            val_10 = System.String.Empty;
            if(W24 < 1)
            {
                    return val_12;
            }
            
            var val_6 = 0;
            string val_3 = splitter + 32;
            do
            {
                if(val_6 != 0)
            {
                    val_11 = 0 + val_10;
            }
            
                val_12 = 0 + val_11;
                val_6 = val_6 + 1;
            }
            while(W24 != val_6);
            
            return val_12;
            label_1:
            val_6 = 1152921504608284672;
            val_13 = null;
            val_13 = null;
            goto label_18;
            label_2:
            val_13 = null;
            label_18:
            val_12 = System.String.Empty;
            return val_12;
        }
        public static string[] ParseArray(string arrayData, string splitter = "%%%")
        {
            string val_5;
            var val_6;
            val_5 = X2;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            typeof(System.String[]).__il2cppRuntimeField_20 = val_5;
            val_6 = 0;
            goto label_6;
            label_16:
            Add(item:  val_5);
            val_6 = 1;
            label_6:
            if(val_6 >= val_2.Length)
            {
                goto label_12;
            }
            
            val_5 = splitter.Split(separator:  null, options:  0)[1];
            if((System.String.op_Equality(a:  0, b:  val_5)) == true)
            {
                goto label_12;
            }
            
            if(null != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_12:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
    
    }

}
