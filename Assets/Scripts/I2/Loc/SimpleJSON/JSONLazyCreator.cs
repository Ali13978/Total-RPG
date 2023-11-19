using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    internal class JSONLazyCreator : JSONNode
    {
        // Fields
        private I2.Loc.SimpleJSON.JSONNode m_Node;
        private string m_Key;
        
        // Properties
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override int AsInt { get; set; }
        public override float AsFloat { get; set; }
        public override double AsDouble { get; set; }
        public override bool AsBool { get; set; }
        public override I2.Loc.SimpleJSON.JSONArray AsArray { get; }
        public override I2.Loc.SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public JSONLazyCreator(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = 0;
        }
        public JSONLazyCreator(I2.Loc.SimpleJSON.JSONNode aNode, string aKey)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = val_1;
        }
        private void Set(I2.Loc.SimpleJSON.JSONNode aVal)
        {
            if(this.m_Key != null)
            {
                    if(this.m_Node != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            this.m_Node = 0;
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            typeof(I2.Loc.SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_10 = this;
            typeof(I2.Loc.SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_18 = 0;
            return (I2.Loc.SimpleJSON.JSONNode)new System.Object();
        }
        public override void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
        {
            Add(aItem:  value);
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONArray());
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            typeof(I2.Loc.SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_10 = this;
            typeof(I2.Loc.SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_18 = aKey;
            return (I2.Loc.SimpleJSON.JSONNode)new System.Object();
        }
        public override void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONClass());
        }
        public override void Add(I2.Loc.SimpleJSON.JSONNode aItem)
        {
            Add(aItem:  aItem);
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONArray());
        }
        public override void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
            this.Set(aVal:  new I2.Loc.SimpleJSON.JSONClass());
        }
        public static bool op_Equality(I2.Loc.SimpleJSON.JSONLazyCreator a, object b)
        {
            if(X2 == 0)
            {
                    return true;
            }
            
            return System.Object.ReferenceEquals(objA:  0, objB:  b);
        }
        public static bool op_Inequality(I2.Loc.SimpleJSON.JSONLazyCreator a, object b)
        {
            var val_3;
            if(X2 != 0)
            {
                    val_3 = (System.Object.ReferenceEquals(objA:  0, objB:  b)) ^ 1;
                return (bool)val_3 & 1;
            }
            
            val_3 = 0;
            return (bool)val_3 & 1;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                    return true;
            }
            
            return System.Object.ReferenceEquals(objA:  0, objB:  this);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override string ToString()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public override string ToString(string aPrefix)
        {
            null = null;
            return (string)System.String.Empty;
        }
        public override int get_AsInt()
        {
            AsInt = 0;
            this.Set(aVal:  new System.Object());
            return 0;
        }
        public override void set_AsInt(int value)
        {
            AsInt = value;
            this.Set(aVal:  new System.Object());
        }
        public override float get_AsFloat()
        {
            AsFloat = 0f;
            this.Set(aVal:  new System.Object());
            return 0f;
        }
        public override void set_AsFloat(float value)
        {
            AsFloat = value;
            this.Set(aVal:  new System.Object());
        }
        public override double get_AsDouble()
        {
            AsDouble = 0;
            this.Set(aVal:  new System.Object());
            return 0;
        }
        public override void set_AsDouble(double value)
        {
            AsDouble = value;
            this.Set(aVal:  new System.Object());
        }
        public override bool get_AsBool()
        {
            AsBool = false;
            this.Set(aVal:  new System.Object());
            return false;
        }
        public override void set_AsBool(bool value)
        {
            AsBool = value;
            this.Set(aVal:  new System.Object());
        }
        public override I2.Loc.SimpleJSON.JSONArray get_AsArray()
        {
            I2.Loc.SimpleJSON.JSONArray val_1 = new I2.Loc.SimpleJSON.JSONArray();
            this.Set(aVal:  val_1);
            return val_1;
        }
        public override I2.Loc.SimpleJSON.JSONClass get_AsObject()
        {
            I2.Loc.SimpleJSON.JSONClass val_1 = new I2.Loc.SimpleJSON.JSONClass();
            this.Set(aVal:  val_1);
            return val_1;
        }
    
    }

}
