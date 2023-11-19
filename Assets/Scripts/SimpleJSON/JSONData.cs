using UnityEngine;

namespace SimpleJSON
{
    public class JSONData : JSONNode
    {
        // Fields
        private string m_Data;
        
        // Properties
        public override string Value { get; set; }
        
        // Methods
        public JSONData(string aData)
        {
            val_1 = new System.Object();
            this.m_Data = aData;
        }
        public JSONData(float aData)
        {
            val_1 = new System.Object();
            val_1.AsFloat = aData;
        }
        public JSONData(double aData)
        {
            val_1 = new System.Object();
            val_1.AsDouble = aData;
        }
        public JSONData(bool aData)
        {
            val_1 = new System.Object();
            val_1.AsBool = aData;
        }
        public JSONData(int aData)
        {
            val_1 = new System.Object();
            val_1.AsInt = aData;
        }
        public override string get_Value()
        {
            return (string)this.m_Data;
        }
        public override void set_Value(string value)
        {
            this.m_Data = value;
        }
        public override string ToString()
        {
            return 0 + "\"" + SimpleJSON.JSONNode.Escape(aText:  13656)(SimpleJSON.JSONNode.Escape(aText:  13656));
        }
        public override string ToString(string aPrefix)
        {
            return 0 + "\"" + SimpleJSON.JSONNode.Escape(aText:  13659)(SimpleJSON.JSONNode.Escape(aText:  13659));
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_11;
            var val_12;
            var val_18;
            var val_19;
            var val_20;
            var val_22;
            var val_23;
            var val_24;
            var val_26;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            string val_49;
            val_41 = aWriter;
            val_42 = this;
            val_43 = 1152921504608284672;
            val_44 = null;
            val_44 = null;
            object val_1 = null;
            val_45 = val_1;
            val_1 = new System.Object();
            typeof(SimpleJSON.JSONData).__il2cppRuntimeField_10 = System.String.Empty;
            AsInt = this.AsInt;
            if((System.String.op_Equality(a:  0, b:  typeof(SimpleJSON.JSONData).__il2cppRuntimeField_10)) == false)
            {
                goto label_5;
            }
            
            int val_4 = this.AsInt;
            label_26:
            val_46 = ???;
            val_42 = ???;
            val_41 = ???;
            val_45 = ???;
            val_43 = ???;
            goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_210;
            label_5:
            if((System.String.op_Equality(a:  0, b:  val_45 + 16)) == false)
            {
                goto label_10;
            }
            
            val_46 = val_7;
            val_42 = val_8;
            val_41 = val_9;
            val_45 = val_11;
            val_43 = val_12;
            goto val_41 + 576;
            label_10:
            val_47 = V0.16B;
            if(val_45 != 0)
            {
                    val_48 = val_47;
            }
            else
            {
                    val_48 = val_47;
            }
            
            val_49 = mem[val_11 + 16];
            val_49 = val_11 + 16;
            if((System.String.op_Equality(a:  0, b:  val_49)) == false)
            {
                goto label_17;
            }
            
            val_46 = val_18;
            val_42 = val_19;
            val_41 = val_20;
            val_45 = val_22;
            val_43 = val_23;
            val_49 = val_24;
            val_47 = val_26;
            goto val_9 + 496;
            label_17:
            if(val_45 != 0)
            {
                    var val_27 = val_42 & 1;
            }
            else
            {
                    var val_28 = val_42 & 1;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_22 + 16)) == false)
            {
                goto val_20 + 592;
            }
            
            var val_30 = val_42 & 1;
            goto label_26;
        }
    
    }

}
