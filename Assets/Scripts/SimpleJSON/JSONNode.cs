using UnityEngine;

namespace SimpleJSON
{
    public class JSONNode
    {
        // Properties
        public virtual SimpleJSON.JSONNode Item { get; set; }
        public virtual SimpleJSON.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual SimpleJSON.JSONArray AsArray { get; }
        public virtual SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public JSONNode()
        {
        
        }
        public virtual void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
        
        }
        public virtual SimpleJSON.JSONNode get_Item(int aIndex)
        {
            return 0;
        }
        public virtual void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
        
        }
        public virtual SimpleJSON.JSONNode get_Item(string aKey)
        {
            return 0;
        }
        public virtual void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
        
        }
        public virtual string get_Value()
        {
            null = null;
            return (string)System.String.Empty;
        }
        public virtual void set_Value(string value)
        {
        
        }
        public virtual int get_Count()
        {
            return 0;
        }
        public virtual void Add(SimpleJSON.JSONNode aItem)
        {
            null = null;
            goto typeof(SimpleJSON.JSONNode).__il2cppRuntimeField_150;
        }
        public virtual SimpleJSON.JSONNode Remove(string aKey)
        {
            return 0;
        }
        public virtual SimpleJSON.JSONNode Remove(int aIndex)
        {
            return 0;
        }
        public virtual SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
        {
            return (SimpleJSON.JSONNode)aNode;
        }
        public virtual System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs()
        {
            typeof(JSONNode.<>c__Iterator0).__il2cppRuntimeField_1C = -2;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>)new System.Object();
        }
        public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_DeepChilds()
        {
            if(null != 0)
            {
                    typeof(JSONNode.<>c__Iterator1).__il2cppRuntimeField_30 = this;
            }
            else
            {
                    mem[48] = this;
            }
            
            typeof(JSONNode.<>c__Iterator1).__il2cppRuntimeField_44 = -2;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>)new System.Object();
        }
        public override string ToString()
        {
            return "JSONNode";
        }
        public virtual string ToString(string aPrefix)
        {
            return "JSONNode";
        }
        public virtual int get_AsInt()
        {
            return (int)((System.Int32.TryParse(s:  0, result: out  this)) != true) ? 0 : 0;
        }
        public virtual void set_AsInt(int value)
        {
        
        }
        public virtual float get_AsFloat()
        {
            return (float)((System.Single.TryParse(s:  0, result: out  this)) != true) ? 0 : 0f;
        }
        public virtual void set_AsFloat(float value)
        {
        
        }
        public virtual double get_AsDouble()
        {
            return (double)((System.Double.TryParse(s:  0, result: out  this)) != true) ? 0 : 0;
        }
        public virtual void set_AsDouble(double value)
        {
        
        }
        public virtual bool get_AsBool()
        {
            bool val_6;
            var val_7;
            val_6 = this;
            if((System.Boolean.TryParse(value:  0, result: out  val_6)) != false)
            {
                    var val_3 = (0 != 0) ? 1 : 0;
            }
            else
            {
                    val_6 = val_6;
                bool val_4 = System.String.IsNullOrEmpty(value:  0);
                val_7 = val_4 ^ 1;
            }
            
            val_4 = val_7;
            return (bool)val_4;
        }
        public virtual void set_AsBool(bool value)
        {
            var val_1 = (value != true) ? "true" : "false";
            if(this == null)
            {
                
            }
        
        }
        public virtual SimpleJSON.JSONArray get_AsArray()
        {
            var val_2 = 0;
            return (SimpleJSON.JSONArray);
        }
        public virtual SimpleJSON.JSONClass get_AsObject()
        {
            var val_2 = 0;
            return (SimpleJSON.JSONClass);
        }
        public static SimpleJSON.JSONNode op_Implicit(string s)
        {
            typeof(SimpleJSON.JSONData).__il2cppRuntimeField_10 = X1;
            return (SimpleJSON.JSONNode)new System.Object();
        }
        public static string op_Implicit(SimpleJSON.JSONNode d)
        {
            if((SimpleJSON.JSONNode.op_Equality(a:  d, b:  null)) != false)
            {
                    return 0;
            }
            
            if(X1 == 0)
            {
                
            }
        
        }
        public static bool op_Equality(SimpleJSON.JSONNode a, object b)
        {
            if(X2 != 0)
            {
                    return System.Object.ReferenceEquals(objA:  0, objB:  b);
            }
            
            if(b == null)
            {
                    return System.Object.ReferenceEquals(objA:  0, objB:  b);
            }
            
            return System.Object.ReferenceEquals(objA:  0, objB:  b);
        }
        public static bool op_Inequality(SimpleJSON.JSONNode a, object b)
        {
            bool val_1 = SimpleJSON.JSONNode.op_Equality(a:  a, b:  b);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            return System.Object.ReferenceEquals(objA:  0, objB:  this);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        internal static string Escape(string aText)
        {
            var val_9;
            var val_10;
            val_9 = null;
            val_9 = null;
            val_10 = 0;
            if( >= X1.Length)
            {
                    return (string)System.String.Empty;
            }
            
            char val_3 = X1.Chars[1] & 65535;
            val_3 = val_3 - 1;
            if((((val_3 - 8) < '') ? (val_3) : 0) > 12)
            {
                    return (string)System.String.Empty;
            }
            
            var val_9 = 25804984 + (val_4 < '' ? ((val_2 & 65535) - 1) : 0) << 2;
            val_9 = val_9 + 25804984;
            goto (25804984 + (val_4 < '' ? ((val_2 & 65535) - 1) : 0) << 2 + 25804984);
        }
        public static SimpleJSON.JSONNode Parse(string aJSON)
        {
            var val_46;
            var val_47;
            var val_48;
            SimpleJSON.JSONNode val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            string val_59;
            var val_60;
            var val_61;
            System.Exception val_62;
            string val_63;
            val_46 = null;
            val_46 = null;
            var val_48 = 0;
            val_47 = 0;
            goto label_3;
            label_115:
            val_47 = 1;
            label_3:
            if(val_47 >= X1.Length)
            {
                goto label_5;
            }
            
            char val_4 = X1.Chars[1] & 65535;
            if((val_4 - 9) > '')
            {
                goto label_7;
            }
            
            if((25805264 + (((val_3 & 65535) - 9)) << 2) > 9)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            var val_46 = 25804928 + (25805264 + (((val_3 & 65535) - 9)) << 2) << 2;
            val_46 = val_46 + 25804928;
            goto (25804928 + (25805264 + (((val_3 & 65535) - 9)) << 2) << 2 + 25804928);
            label_7:
            var val_8 = ((val_4 - 91) < '') ? (val_4 - 80) : 0;
            if(val_8 > 11)
            {
                goto label_9;
            }
            
            if(val_8 == 0)
            {
                goto label_10;
            }
            
            if(val_8 != 11)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            if((val_48 & 1) != 0)
            {
                goto label_57;
            }
            
            SimpleJSON.JSONArray val_9 = null;
            val_49 = val_9;
            val_9 = new SimpleJSON.JSONArray();
            if(null != 0)
            {
                goto label_94;
            }
            
            goto label_14;
            label_9:
            if(val_8 != 12)
            {
                goto label_15;
            }
            
            if((val_48 & 1) == 0)
            {
                goto label_115;
            }
            
            char val_11 = X1.Chars[val_47 + 1];
            char val_12 = val_11 & 65535;
            char val_13 = val_12 - 114;
            val_12 = val_12 - 36;
            var val_14 = (val_13 < '') ? (val_12) : 0;
            val_13 = val_14 - 78;
            if(val_13 > 3)
            {
                goto label_18;
            }
            
            var val_47 = 25804968 + ((val_13 < '' ? ((val_11 & 65535) - 36) : 0 - 78)) << 2;
            val_47 = val_47 + 25804968;
            goto (25804968 + ((val_13 < '' ? ((val_11 & 65535) - 36) : 0 - 78)) << 2 + 25804968);
            label_10:
            if((val_4 - 32) > '')
            {
                goto label_22;
            }
            
            if((25805284 + (((val_3 & 65535) - 32)) << 2) > 14)
            {
                goto label_21;
            }
            
            if((25805284 + (((val_3 & 65535) - 32)) << 2) == 0)
            {
                goto label_22;
            }
            
            if((25805284 + (((val_3 & 65535) - 32)) << 2) != 7)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            if((val_48 & 1) != 0)
            {
                goto label_57;
            }
            
            goto label_115;
            label_21:
            if((25805284 + (((val_3 & 65535) - 32)) << 2) == 16)
            {
                goto label_27;
            }
            
            if((25805284 + (((val_3 & 65535) - 32)) << 2) != 15)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            label_22:
            if((val_4 - 123) > '')
            {
                goto label_31;
            }
            
            val_48 = mem[25805296 + (((val_3 & 65535) - 123)) << 2];
            val_48 = 25805296 + (((val_3 & 65535) - 123)) << 2;
            if(val_48 > 17)
            {
                goto label_30;
            }
            
            if(val_48 == 0)
            {
                goto label_31;
            }
            
            label_15:
            if(val_48 != 13)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            if((val_48 & 1) != 0)
            {
                goto label_57;
            }
            
            if(Count == 0)
            {
                goto label_35;
            }
            
            SimpleJSON.JSONNode val_18 = Pop();
            val_52 = null;
            val_52 = null;
            if((System.String.op_Inequality(a:  0, b:  System.String.Empty)) == false)
            {
                goto label_48;
            }
            
            val_53 = null;
            val_53 = null;
            bool val_21 = System.String.op_Inequality(a:  0, b:  System.String.Empty.Trim());
            if(val_21 == false)
            {
                goto label_48;
            }
            
            SimpleJSON.JSONNode val_22 = SimpleJSON.JSONNode.op_Implicit(s:  val_21);
            if(0 != 0)
            {
                goto label_48;
            }
            
            goto label_48;
            label_30:
            if(val_48 == 18)
            {
                goto label_49;
            }
            
            if(val_48 != 19)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            label_31:
            if(val_4 == ',')
            {
                goto label_51;
            }
            
            if(val_4 != (':'))
            {
                goto label_52;
            }
            
            if((val_48 & 1) != 0)
            {
                goto label_57;
            }
            
            val_54 = null;
            val_54 = null;
            goto label_115;
            label_51:
            if((val_48 & 1) != 0)
            {
                goto label_57;
            }
            
            val_55 = null;
            val_55 = null;
            if((System.String.op_Inequality(a:  0, b:  System.String.Empty)) == false)
            {
                goto label_68;
            }
            
            val_56 = null;
            val_56 = null;
            bool val_24 = System.String.op_Inequality(a:  0, b:  System.String.Empty);
            if(val_24 == false)
            {
                goto label_68;
            }
            
            SimpleJSON.JSONNode val_25 = SimpleJSON.JSONNode.op_Implicit(s:  val_24);
            if(0 != 0)
            {
                goto label_68;
            }
            
            goto label_68;
            label_52:
            char val_26 = X1.Chars[1];
            string val_27 = 0 + System.String.Empty;
            goto label_115;
            label_27:
            val_48 = val_48 ^ 1;
            goto label_115;
            label_18:
            if(val_14 != 0)
            {
                    return (SimpleJSON.JSONNode)0;
            }
            
            char val_28 = val_11 & 65535;
            if(val_28 == 'b')
            {
                goto label_75;
            }
            
            if(val_28 == 'f')
            {
                goto label_76;
            }
            
            if(val_28 != 'n')
            {
                goto label_93;
            }
            
            val_50 = null;
            val_51 = 10;
            goto label_89;
            label_49:
            if((val_48 & 1) == 0)
            {
                goto label_84;
            }
            
            label_57:
            char val_32 = X1.Chars[1];
            string val_33 = 0 + System.String.Empty;
            goto label_115;
            label_75:
            val_50 = null;
            val_51 = 8;
            goto label_89;
            label_76:
            val_50 = null;
            val_51 = 12;
            label_89:
            label_93:
            string val_34 = 0 + System.String.Empty;
            goto label_115;
            label_84:
            SimpleJSON.JSONClass val_35 = null;
            val_49 = val_35;
            val_35 = new SimpleJSON.JSONClass();
            if(null != 0)
            {
                goto label_94;
            }
            
            label_14:
            label_94:
            Push(t:  val_49);
            if((SimpleJSON.JSONNode.op_Equality(a:  new System.Collections.Generic.Stack<SimpleJSON.JSONNode>(), b:  0)) != true)
            {
                    val_57 = null;
                val_57 = null;
                if((System.String.op_Inequality(a:  0, b:  System.String.Empty.Trim())) != false)
            {
                    SimpleJSON.JSONNode val_40 = Peek();
                if(0 != 0)
            {
                goto label_105;
            }
            
            }
            
            }
            
            label_105:
            val_58 = null;
            val_58 = null;
            val_59 = System.String.Empty;
            goto label_109;
            label_48:
            val_60 = null;
            val_60 = null;
            val_59 = System.String.Empty;
            if(Count < 1)
            {
                goto label_115;
            }
            
            label_109:
            SimpleJSON.JSONNode val_44 = Peek();
            goto label_115;
            label_68:
            val_61 = null;
            val_61 = null;
            goto label_115;
            label_5:
            if((val_48 & 1) != 0)
            {
                goto label_119;
            }
            
            return (SimpleJSON.JSONNode)0;
            label_35:
            val_62 = null;
            val_63 = "JSON Parse: Too many closing brackets";
            goto label_120;
            label_119:
            val_62 = null;
            val_63 = "JSON Parse: Quotation marks seems to be messed up.";
            label_120:
            val_62 = new System.Exception(message:  val_63);
        }
        public virtual void Serialize(System.IO.BinaryWriter aWriter)
        {
        
        }
        public void SaveToStream(System.IO.Stream aData)
        {
            System.IO.BinaryWriter val_1 = new System.IO.BinaryWriter(output:  aData);
            goto typeof(SimpleJSON.JSONNode).__il2cppRuntimeField_2D0;
        }
        public void SaveToCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public void SaveToCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public string SaveToCompressedBase64()
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public void SaveToFile(string aFileName)
        {
            System.IO.Stream val_12;
            var val_13;
            var val_14;
            System.IO.FileInfo val_1 = new System.IO.FileInfo(fileName:  aFileName);
            System.IO.DirectoryInfo val_2 = Directory;
            System.IO.DirectoryInfo val_3 = System.IO.Directory.CreateDirectory(path:  0);
            val_12 = System.IO.File.OpenWrite(path:  0);
            this.SaveToStream(aData:  val_12);
            val_13 = 54;
            if(val_12 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = val_12;
            }
            
            if(54 == 54)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_12 = ???;
            val_13 = ???;
        }
        public string SaveToBase64()
        {
            var val_3;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            this.SaveToStream(aData:  val_1);
            if(null == 0)
            {
                goto label_4;
            }
            
            System.IO.MemoryStream val_5 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_5;
            }
            
            var val_3 = mem[null + 152];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_7:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[null + 258]))
            {
                goto label_7;
            }
            
            label_5:
            val_3 = val_1;
            goto label_8;
            label_6:
            val_5 = val_5 + (((mem[null + 152] + 8)) << 4);
            label_8:
            label_4:
            if(51 == 51)
            {
                    return (string)System.Convert.ToBase64String(inArray:  0);
            }
            
            if(0 == 0)
            {
                    return (string)System.Convert.ToBase64String(inArray:  0);
            }
            
            return (string)System.Convert.ToBase64String(inArray:  0);
        }
        public static SimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            var val_1 = X1 & 255;
            if((((val_1 - 1) < 7) ? (val_1 + 2) : 0) > 9)
            {
                    return (SimpleJSON.JSONNode);
            }
            
            var val_13 = 25805036 + (val_2 < 0x7 ? ((X1 & 255) + 2) : 0) << 2;
            val_13 = val_13 + 25805036;
            goto (25805036 + (val_2 < 0x7 ? ((X1 & 255) + 2) : 0) << 2 + 25805036);
        }
        public static SimpleJSON.JSONNode LoadFromCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static SimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static SimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            System.Exception val_1 = new System.Exception(message:  "Can\'t use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
        }
        public static SimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData)
        {
            var val_3;
            System.IO.BinaryReader val_1 = new System.IO.BinaryReader(input:  X1);
            if(null == 0)
            {
                goto label_1;
            }
            
            System.IO.BinaryReader val_5 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_2;
            }
            
            var val_3 = mem[null + 152];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_4:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[null + 258]))
            {
                goto label_4;
            }
            
            label_2:
            val_3 = val_1;
            goto label_5;
            label_3:
            val_5 = val_5 + (((mem[null + 152] + 8)) << 4);
            label_5:
            label_1:
            if(32 == 32)
            {
                    return (SimpleJSON.JSONNode)SimpleJSON.JSONNode.Deserialize(aReader:  val_1 = new System.IO.BinaryReader(input:  X1));
            }
            
            if(0 == 0)
            {
                    return (SimpleJSON.JSONNode)SimpleJSON.JSONNode.Deserialize(aReader:  val_1);
            }
            
            return (SimpleJSON.JSONNode)SimpleJSON.JSONNode.Deserialize(aReader:  val_1);
        }
        public static SimpleJSON.JSONNode LoadFromFile(string aFileName)
        {
            var val_4;
            System.IO.FileStream val_1 = System.IO.File.OpenRead(path:  0);
            if(val_1 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = val_1;
            }
            
            if(32 == 32)
            {
                    return (SimpleJSON.JSONNode)SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
            }
            
            if(0 == 0)
            {
                    return (SimpleJSON.JSONNode)SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
            }
            
            return (SimpleJSON.JSONNode)SimpleJSON.JSONNode.LoadFromStream(aData:  val_1);
        }
        public static SimpleJSON.JSONNode LoadFromBase64(string aBase64)
        {
            if(null != 0)
            {
                    return SimpleJSON.JSONNode.LoadFromStream(aData:  new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  0)));
            }
            
            return SimpleJSON.JSONNode.LoadFromStream(aData:  new System.IO.MemoryStream(buffer:  System.Convert.FromBase64String(s:  0)));
        }
    
    }

}
