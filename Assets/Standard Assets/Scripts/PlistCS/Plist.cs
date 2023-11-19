using UnityEngine;

namespace PlistCS
{
    public static class Plist
    {
        // Fields
        private static System.Collections.Generic.List<int> offsetTable;
        private static System.Collections.Generic.List<byte> objectTable;
        private static int refCount;
        private static int objRefSize;
        private static int offsetByteSize;
        private static long offsetTableOffset;
        private static System.Collections.Generic.Dictionary<string, int> <>f__switch$map0;
        private static System.Collections.Generic.Dictionary<string, int> <>f__switch$map1;
        
        // Methods
        public static object readPlist(string path)
        {
            var val_3;
            System.IO.FileStream val_1 = new System.IO.FileStream(path:  X1, mode:  3, access:  1);
            if(null == 0)
            {
                goto label_3;
            }
            
            System.IO.FileStream val_5 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_3 = mem[null + 152];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_3 = val_1;
            goto label_7;
            label_5:
            val_5 = val_5 + (((mem[null + 152] + 8)) << 4);
            label_7:
            label_3:
            if(35 == 35)
            {
                    return (object)PlistCS.Plist.readPlist(stream:  null, type:  val_1);
            }
            
            if(0 == 0)
            {
                    return (object)PlistCS.Plist.readPlist(stream:  null, type:  val_1);
            }
            
            return (object)PlistCS.Plist.readPlist(stream:  null, type:  val_1);
        }
        public static object readPlistSource(string source)
        {
            System.Text.Encoding.UTF8 = null;
            return PlistCS.Plist.readPlist(data:  System.Text.Encoding.UTF8);
        }
        public static object readPlist(byte[] data)
        {
            return PlistCS.Plist.readPlist(stream:  null, type:  new System.IO.MemoryStream(buffer:  X1));
        }
        public static PlistCS.plistType getPlistType(System.IO.Stream stream)
        {
            return (PlistCS.plistType)((System.BitConverter.ToInt64(value:  0, startIndex:  460851360)) != 3472403351741427810) ? (1 + 1) : 1;
        }
        public static object readPlist(System.IO.Stream stream, PlistCS.plistType type)
        {
            var val_6;
            var val_7;
            var val_8;
            val_7 = W2;
            if(val_7 == 0)
            {
                    val_7 = PlistCS.Plist.getPlistType(stream:  null);
                int val_2 = type.CompareTo(target:  0);
            }
            
            if(val_7 != 1)
            {
                goto label_17;
            }
            
            val_6 = 0;
            if(null == 0)
            {
                goto label_11;
            }
            
            System.IO.BinaryReader val_8 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_12;
            }
            
            var val_6 = mem[null + 152];
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_14:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (mem[null + 258]))
            {
                goto label_14;
            }
            
            label_12:
            val_8 = new System.IO.BinaryReader(input:  type);
            goto label_15;
            label_13:
            val_8 = val_8 + (((mem[null + 152] + 8)) << 4);
            label_15:
            label_11:
            if(109 == 109)
            {
                    return (object)PlistCS.Plist.readBinary(data:  null);
            }
            
            label_17:
            System.Xml.XmlDocument val_5 = new System.Xml.XmlDocument();
            return PlistCS.Plist.readXml(xml:  null);
        }
        public static void writeXml(object value, string path)
        {
            var val_9;
            var val_10;
            var val_11;
            System.IO.StreamWriter val_1 = null;
            val_9 = val_1;
            val_1 = new System.IO.StreamWriter(path:  X2);
            string val_2 = PlistCS.Plist.writeXml(value:  null);
            val_10 = 37;
            System.IO.StreamWriter val_11 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_9 = mem[null + 152];
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_11 = val_9;
            goto label_7;
            label_5:
            val_11 = val_11 + (((mem[null + 152] + 8)) << 4);
            label_7:
            if(0 == 0)
            {
                    return;
            }
            
            if(37 == 37)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
        }
        public static void writeXml(object value, System.IO.Stream stream)
        {
            var val_9;
            var val_10;
            var val_11;
            System.IO.StreamWriter val_1 = null;
            val_9 = val_1;
            val_1 = new System.IO.StreamWriter(stream:  X2);
            string val_2 = PlistCS.Plist.writeXml(value:  null);
            val_10 = 37;
            System.IO.StreamWriter val_11 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_9 = mem[null + 152];
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_11 = val_9;
            goto label_7;
            label_5:
            val_11 = val_11 + (((mem[null + 152] + 8)) << 4);
            label_7:
            if(0 == 0)
            {
                    return;
            }
            
            if(37 == 37)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
        }
        public static string writeXml(object value)
        {
            var val_7;
            var val_8;
            var val_9;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            System.Xml.XmlWriterSettings val_2 = new System.Xml.XmlWriterSettings();
            System.Text.UTF8Encoding val_3 = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  false);
            Encoding = null;
            ConformanceLevel = 2;
            Indent = true;
            System.Xml.XmlWriter val_4 = System.Xml.XmlWriter.Create(stream:  0, settings:  val_1);
            val_4.WriteStartElement(localName:  "plist");
            val_4.WriteAttributeString(localName:  "version", value:  "1.0");
            PlistCS.Plist.compose(value:  null, writer:  X1);
            val_7 = 0;
            if(val_4 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_8 = val_4;
            }
            
            if((158 != 158) && (val_7 != 0))
            {
                    val_7 = 0;
            }
            
            if(null == 0)
            {
                goto label_19;
            }
            
            System.IO.MemoryStream val_10 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_20;
            }
            
            var val_8 = mem[null + 152];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_22:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (mem[null + 258]))
            {
                goto label_22;
            }
            
            label_20:
            val_9 = val_1;
            goto label_23;
            label_21:
            val_10 = val_10 + (((mem[null + 152] + 8)) << 4);
            label_23:
            label_19:
            if(158 == 158)
            {
                    return (string)System.Text.Encoding.UTF8;
            }
            
            if(val_7 == 0)
            {
                    return (string)System.Text.Encoding.UTF8;
            }
            
            return (string)System.Text.Encoding.UTF8;
        }
        public static void writeBinary(object value, string path)
        {
            var val_10;
            var val_11;
            var val_12;
            System.IO.BinaryWriter val_2 = null;
            val_10 = val_2;
            val_2 = new System.IO.BinaryWriter(output:  new System.IO.FileStream(path:  X2, mode:  2));
            System.Byte[] val_3 = PlistCS.Plist.writeBinary(value:  null);
            val_11 = 43;
            System.IO.BinaryWriter val_12 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_10 = mem[null + 152];
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_12 = val_10;
            goto label_7;
            label_5:
            val_12 = val_12 + (((mem[null + 152] + 8)) << 4);
            label_7:
            if(0 == 0)
            {
                    return;
            }
            
            if(43 == 43)
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
        }
        public static void writeBinary(object value, System.IO.Stream stream)
        {
            var val_9;
            var val_10;
            var val_11;
            System.IO.BinaryWriter val_1 = null;
            val_9 = val_1;
            val_1 = new System.IO.BinaryWriter(output:  X2);
            System.Byte[] val_2 = PlistCS.Plist.writeBinary(value:  null);
            val_10 = 37;
            System.IO.BinaryWriter val_11 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_9 = mem[null + 152];
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_11 = val_9;
            goto label_7;
            label_5:
            val_11 = val_11 + (((mem[null + 152] + 8)) << 4);
            label_7:
            if(0 == 0)
            {
                    return;
            }
            
            if(37 == 37)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
        }
        public static byte[] writeBinary(object value)
        {
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            val_33 = null;
            val_33 = null;
            PlistCS.Plist.offsetTable.Clear();
            PlistCS.Plist.objectTable.Clear();
            PlistCS.Plist.refCount = 0;
            PlistCS.Plist.objRefSize = 0;
            PlistCS.Plist.offsetByteSize = 0;
            PlistCS.Plist.offsetTableOffset = 0;
            int val_2 = (PlistCS.Plist.countObject(value:  PlistCS.Plist.objectTable)) - 1;
            PlistCS.Plist.refCount = val_2;
            PlistCS.Plist.objRefSize = val_4.Length;
            System.Byte[] val_6 = PlistCS.Plist.writeBinaryString(value:  PlistCS.Plist.composeBinary(obj:  PlistCS.Plist.RegulateNullBytes(value:  System.BitConverter.GetBytes(value:  0))), head:  true);
            PlistCS.Plist.offsetTableOffset = (long)PlistCS.Plist.objectTable.Count;
            PlistCS.Plist.offsetTable.Add(item:  PlistCS.Plist.objectTable.Count - 8);
            if(PlistCS.Plist.offsetTable != null)
            {
                    val_34 = PlistCS.Plist.offsetTable.Count;
            }
            else
            {
                    val_34 = 0.Count;
            }
            
            int val_13 = PlistCS.Plist.offsetTable.Item[val_34 - 1];
            System.Byte[] val_15 = PlistCS.Plist.RegulateNullBytes(value:  System.BitConverter.GetBytes(value:  0));
            PlistCS.Plist.offsetByteSize = val_15.Length;
            PlistCS.Plist.offsetTable.Reverse();
            val_35 = 0;
            goto label_15;
            label_29:
            AddRange(collection:  X21);
            val_35 = 1;
            label_15:
            val_36 = null;
            val_36 = null;
            val_37 = null;
            if(val_35 >= PlistCS.Plist.offsetTable.Count)
            {
                goto label_19;
            }
            
            val_38 = null;
            PlistCS.Plist.offsetTable.set_Item(index:  1, value:  PlistCS.Plist.objectTable.Count - PlistCS.Plist.offsetTable.Item[1]);
            int val_23 = PlistCS.Plist.offsetTable.Item[1];
            System.Byte[] val_24 = System.BitConverter.GetBytes(value:  0);
            System.Byte[] val_25 = PlistCS.Plist.RegulateNullBytes(value:  val_24, minBytes:  val_24);
            System.Array.Reverse(array:  0);
            if(null != 0)
            {
                goto label_29;
            }
            
            goto label_29;
            label_19:
            val_39 = null;
            PlistCS.Plist.objectTable.AddRange(collection:  new System.Collections.Generic.List<System.Byte>());
            PlistCS.Plist.objectTable.AddRange(collection:  null);
            PlistCS.Plist.objectTable.Add(item:  System.Convert.ToByte(value:  0));
            PlistCS.Plist.objectTable.Add(item:  System.Convert.ToByte(value:  0));
            var val_29 = (long)val_2 + 1;
            System.Array.Reverse(array:  0);
            PlistCS.Plist.objectTable.AddRange(collection:  System.BitConverter.GetBytes(value:  0));
            PlistCS.Plist.objectTable.AddRange(collection:  System.BitConverter.GetBytes(value:  0));
            System.Array.Reverse(array:  0);
            PlistCS.Plist.objectTable.AddRange(collection:  System.BitConverter.GetBytes(value:  0));
            if(PlistCS.Plist.objectTable != null)
            {
                    return PlistCS.Plist.objectTable.ToArray();
            }
            
            return PlistCS.Plist.objectTable.ToArray();
        }
        private static object readXml(System.Xml.XmlDocument xml)
        {
            X1.DocumentElement = null;
            return PlistCS.Plist.parse(node:  X1.DocumentElement);
        }
        private static object readBinary(byte[] data)
        {
            var val_12;
            var val_13;
            val_12 = null;
            val_12 = null;
            PlistCS.Plist.offsetTable.Clear();
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            PlistCS.Plist.objectTable.Clear();
            PlistCS.Plist.refCount = 0;
            PlistCS.Plist.objRefSize = 0;
            PlistCS.Plist.offsetByteSize = 0;
            PlistCS.Plist.offsetTableOffset = 0;
            System.Collections.Generic.List<System.Byte> val_2 = new System.Collections.Generic.List<System.Byte>(collection:  X1);
            if(null != 0)
            {
                    val_13 = Count;
            }
            else
            {
                    val_13 = Count;
            }
            
            PlistCS.Plist.parseTrailer(trailer:  GetRange(index:  val_13 - 32, count:  32));
            PlistCS.Plist.objectTable = GetRange(index:  0, count:  0);
            System.Collections.Generic.List<T> val_11 = GetRange(index:  0, count:  (Count - 32) - PlistCS.Plist.offsetTableOffset);
            PlistCS.Plist.parseOffsetTable(offsetTableBytes:  val_11);
            return PlistCS.Plist.parseBinary(objRef:  val_11);
        }
        private static System.Collections.Generic.Dictionary<string, object> parseDictionary(System.Xml.XmlNode node)
        {
            var val_6;
            if((X1 & 1) != 0)
            {
                goto label_3;
            }
            
            val_6 = 0;
            goto label_4;
            label_16:
            val_6 = 1;
            label_4:
            if(val_6 >= X1)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            val_6 = val_6 + 1;
            if((System.String.op_Inequality(a:  0, b:  X1)) == true)
            {
                goto label_10;
            }
            
            object val_3 = PlistCS.Plist.parse(node:  null);
            if(val_3 == null)
            {
                goto label_16;
            }
            
            Add(key:  X1, value:  val_3);
            goto label_16;
            label_10:
            System.ApplicationException val_4 = new System.ApplicationException(message:  "expected a key node");
            label_17:
            label_3:
            System.DataMisalignedException val_5 = new System.DataMisalignedException(message:  "Dictionary elements must have an even number of child nodes");
            goto label_17;
        }
        private static System.Collections.Generic.List<object> parseArray(System.Xml.XmlNode node)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            label_21:
            var val_9 = X1;
            if((X1 + 258) == 0)
            {
                goto label_4;
            }
            
            var val_6 = X1 + 152;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_6:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (X1 + 258))
            {
                goto label_6;
            }
            
            label_4:
            val_7 = X1;
            goto label_7;
            label_5:
            var val_8 = val_6;
            val_8 = val_8 + 1;
            val_9 = val_9 + val_8;
            val_7 = val_9 + 272;
            label_7:
            if(((X1 & 1) & 1) == 0)
            {
                goto label_30;
            }
            
            var val_12 = X1;
            if((X1 + 258) == 0)
            {
                goto label_10;
            }
            
            var val_10 = X1 + 152;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_12:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (X1 + 258))
            {
                goto label_12;
            }
            
            label_10:
            val_8 = X1;
            goto label_13;
            label_11:
            val_12 = val_12 + (((X1 + 152 + 8)) << 4);
            val_8 = val_12 + 272;
            label_13:
            val_9 = X1;
            val_9 = 0;
            object val_5 = PlistCS.Plist.parse(node:  null);
            if(val_5 == null)
            {
                goto label_21;
            }
            
            Add(item:  val_5);
            goto label_21;
            label_30:
            if(X1 == 0)
            {
                goto label_23;
            }
            
            var val_15 = X1;
            if((X1 + 258) == 0)
            {
                goto label_24;
            }
            
            var val_13 = X1 + 152;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_26:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_25;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (X1 + 258))
            {
                goto label_26;
            }
            
            label_24:
            val_10 = X1;
            goto label_27;
            label_25:
            val_15 = val_15 + (((X1 + 152 + 8)) << 4);
            val_10 = val_15 + 272;
            label_27:
            label_23:
            if(0 == 93)
            {
                    return (System.Collections.Generic.List<System.Object>)new System.Collections.Generic.List<System.Object>();
            }
            
            if(null == 0)
            {
                    return (System.Collections.Generic.List<System.Object>)new System.Collections.Generic.List<System.Object>();
            }
            
            return (System.Collections.Generic.List<System.Object>)new System.Collections.Generic.List<System.Object>();
        }
        private static void composeArray(System.Collections.Generic.List<object> value, System.Xml.XmlWriter writer)
        {
            var val_3;
            PlistCS.Plist val_5;
            var val_6;
            X2.WriteStartElement(localName:  "array");
            List.Enumerator<T> val_1 = writer.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            PlistCS.Plist.compose(value:  null, writer:  val_3.InitializationCallback);
            goto label_6;
            label_3:
            val_5 = 0;
            val_6 = 1;
            val_3.Dispose();
            if(X2 != 0)
            {
                    return;
            }
        
        }
        private static object parse(System.Xml.XmlNode node)
        {
            string val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_15 = X1;
            int val_2 = 0;
            if(val_15 == 0)
            {
                goto label_13;
            }
            
            val_16 = null;
            val_16 = null;
            if((PlistCS.Plist.<>f__switch$map0) == null)
            {
                    if(null != 0)
            {
                    val_17 = 1152921510153291024;
                Add(key:  "dict", value:  0);
                Add(key:  "array", value:  1);
                Add(key:  "string", value:  2);
                Add(key:  "integer", value:  3);
                Add(key:  "real", value:  4);
                Add(key:  "false", value:  5);
                Add(key:  "true", value:  6);
                Add(key:  "null", value:  7);
                Add(key:  "date", value:  8);
            }
            else
            {
                    val_17 = 1152921510153291024;
                Add(key:  "dict", value:  0);
                Add(key:  "array", value:  1);
                Add(key:  "string", value:  2);
                Add(key:  "integer", value:  3);
                Add(key:  "real", value:  4);
                Add(key:  "false", value:  5);
                Add(key:  "true", value:  6);
                Add(key:  "null", value:  7);
                Add(key:  "date", value:  8);
            }
            
                Add(key:  "data", value:  9);
                val_18 = null;
                val_18 = null;
                PlistCS.Plist.<>f__switch$map0 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(capacity:  10);
                val_16 = null;
            }
            
            val_16 = null;
            if((TryGetValue(key:  val_15, value: out  val_2)) == false)
            {
                goto label_13;
            }
            
            val_19 = 0;
            if(((val_2 < 10) ? 11 : 0) > 20)
            {
                    return (object);
            }
            
            var val_15 = 25815992 + (val_2 < 0xA ? 11 : 0) << 2;
            val_15 = val_15 + 25815992;
            goto (25815992 + (val_2 < 0xA ? 11 : 0) << 2 + 25815992);
            label_13:
            System.ApplicationException val_14 = new System.ApplicationException(message:  System.String.Format(format:  0, arg0:  "Plist Node `{0}\' is not supported"));
        }
        private static void compose(object value, System.Xml.XmlWriter writer)
        {
            System.Xml.XmlWriter val_28;
            System.Collections.Generic.Dictionary<TKey, TValue> val_29;
            var val_31;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_33;
            var val_35;
            string val_36;
            var val_37;
            string val_38;
            string val_39;
            string val_40;
            var val_42;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            val_28 = writer;
            if(val_28 == null)
            {
                goto label_2;
            }
            
            val_29 = 1152921504608284672;
            if(null == null)
            {
                goto label_2;
            }
            
            if((null == null) || (null == null))
            {
                goto label_4;
            }
            
            val_31 = 1152921504616644608;
            val_33 = null;
            val_35 = 0;
            if((val_28.GetType().StartsWith(value:  "System.Collections.Generic.Dictionary`2[System.String")) == false)
            {
                goto label_9;
            }
            
            val_33 = null;
            val_33 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_36 = val_28;
            if(val_36 == null)
            {
                goto label_12;
            }
            
            val_37 = 0;
            goto label_13;
            label_2:
            if(val_28 != null)
            {
                    var val_3 = (null == null) ? (val_28) : 0;
            }
            else
            {
                    val_38 = 0;
            }
            
            X2.WriteElementString(localName:  "string", value:  val_38);
            return;
            label_4:
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            System.Globalization.NumberFormatInfo val_5 = System.Globalization.NumberFormatInfo.InvariantInfo;
            val_39;
            val_40 = "integer";
            goto label_88;
            label_9:
            val_42 = null;
            if(val_28 == null)
            {
                goto label_25;
            }
            
            val_45 = val_28;
            if(val_45 == null)
            {
                    val_45 = 0;
            }
            
            val_39 = System.Convert.ToBase64String(inArray:  0);
            val_40 = "data";
            goto label_88;
            label_12:
            val_36 = 0;
            val_37 = 1;
            label_13:
            if(mem[282584257676929] == 0)
            {
                goto label_31;
            }
            
            var val_21 = mem[282584257676823];
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_33:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_32;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < mem[282584257676929])
            {
                goto label_33;
            }
            
            label_31:
            val_35 = 4;
            val_46 = val_36;
            goto label_34;
            label_32:
            var val_23 = val_21;
            val_23 = val_23 + 4;
            val_36 = val_36 + val_23;
            val_46 = val_36 + 272;
            label_34:
            var val_26 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_36;
            }
            
            var val_24 = mem[282584257676823];
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_38:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_37;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < mem[282584257676929])
            {
                goto label_38;
            }
            
            label_36:
            val_35 = 0;
            val_47 = val_36;
            goto label_39;
            label_37:
            val_26 = val_26 + (((mem[282584257676823] + 8)) << 4);
            val_47 = val_26 + 272;
            label_39:
            label_58:
            var val_30 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_41;
            }
            
            var val_27 = mem[282584257676823];
            var val_28 = 0;
            val_27 = val_27 + 8;
            label_43:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_28 = val_28 + 1;
            val_27 = val_27 + 16;
            if(val_28 < mem[282584257676929])
            {
                goto label_43;
            }
            
            label_41:
            val_35 = 1;
            val_48 = val_36;
            goto label_44;
            label_42:
            var val_29 = val_27;
            val_29 = val_29 + 1;
            val_30 = val_30 + val_29;
            val_48 = val_30 + 272;
            label_44:
            if((0 & 1) == 0)
            {
                goto label_89;
            }
            
            var val_33 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_47;
            }
            
            var val_31 = mem[282584257676823];
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_49:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_48;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < mem[282584257676929])
            {
                goto label_49;
            }
            
            label_47:
            val_35 = 0;
            val_49 = val_36;
            goto label_50;
            label_48:
            val_33 = val_33 + (((mem[282584257676823] + 8)) << 4);
            val_49 = val_33 + 272;
            label_50:
            var val_37 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_53;
            }
            
            var val_34 = mem[282584257676823];
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_55:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_54;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < mem[282584257676929])
            {
                goto label_55;
            }
            
            label_53:
            val_35 = 2;
            val_50 = val_36;
            goto label_56;
            label_54:
            var val_36 = val_34;
            val_36 = val_36 + 2;
            val_37 = val_37 + val_36;
            val_50 = val_37 + 272;
            label_56:
            Add(key:  val_36, value:  val_36);
            goto label_58;
            label_89:
            if(val_36 == 0)
            {
                goto label_59;
            }
            
            var val_40 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_60;
            }
            
            var val_38 = mem[282584257676823];
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_62:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_61;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < mem[282584257676929])
            {
                goto label_62;
            }
            
            label_60:
            val_51 = val_36;
            goto label_63;
            label_25:
            val_52 = null;
            if(null == null)
            {
                goto label_65;
            }
            
            val_52 = 1152921504772341760;
            if(null == val_52)
            {
                goto label_65;
            }
            
            if(null == null)
            {
                goto label_66;
            }
            
            if(null != null)
            {
                goto label_67;
            }
            
            val_53 = null;
            val_53 = null;
            val_29 = System.String.Empty;
            X2.WriteElementString(localName:  val_28.ToString().ToLower(), value:  val_29);
            return;
            label_61:
            val_40 = val_40 + (((mem[282584257676823] + 8)) << 4);
            val_51 = val_40 + 272;
            label_63:
            label_59:
            PlistCS.Plist.writeDictionaryValues(dictionary:  null, writer:  val_33);
            return;
            label_65:
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            System.Globalization.NumberFormatInfo val_13 = System.Globalization.NumberFormatInfo.InvariantInfo;
            val_39;
            val_40 = "real";
            goto label_88;
            label_66:
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_39 = System.Xml.XmlConvert.ToString(value:  new System.DateTime() {ticks = new System.TimeSpan(), kind = 1152921504772341760}, mode:  1152921505067698336);
            val_40 = "date";
            label_88:
            X2.WriteElementString(localName:  val_40, value:  val_39);
            return;
            label_99:
            label_67:
            System.Type val_18 = val_28.GetType();
            System.Exception val_20 = new System.Exception(message:  System.String.Format(format:  0, arg0:  "Value type \'{0}\' is unhandled"));
            goto label_99;
        }
        private static void writeDictionaryValues(System.Collections.Generic.Dictionary<string, object> dictionary, System.Xml.XmlWriter writer)
        {
            X2.WriteStartElement(localName:  "dict");
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = writer.Keys.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_13;
            }
            
            X2.WriteElementString(localName:  "key", value:  0);
            PlistCS.Plist.compose(value:  null, writer:  writer.Item[0]);
            goto label_9;
            label_13:
            if(X2 != 0)
            {
                    return;
            }
        
        }
        private static int countObject(object value)
        {
            var val_15;
            var val_21;
            var val_22;
            var val_23;
            PlistCS.Plist val_24;
            var val_25;
            var val_26;
            var val_27;
            PlistCS.Plist val_28;
            var val_29;
            val_21 = X1;
            System.Type val_1 = val_21.GetType();
            if(val_1 == null)
            {
                goto label_21;
            }
            
            val_22 = 1152921504608284672;
            if((System.String.op_Equality(a:  0, b:  val_1)) == false)
            {
                goto label_6;
            }
            
            val_22 = 1152921509344237104;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_7 = 0.Keys.GetEnumerator();
            val_23 = 0;
            goto label_11;
            label_17:
            val_23 = val_7.host_enumerator.current.Value + val_23;
            label_11:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            object val_8 = 0.Item[0];
            goto label_17;
            label_6:
            if((System.String.op_Equality(a:  0, b:  val_1)) == false)
            {
                goto label_21;
            }
            
            val_26 = 0;
            List.Enumerator<T> val_13 = val_26.GetEnumerator();
            val_23 = 1152921504840073216;
            val_27 = 0;
            goto label_25;
            label_30:
            val_27 = val_13.current + val_27;
            label_25:
            if((0 & 1) == 0)
            {
                goto label_26;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_16 = val_15.InitializationCallback;
            goto label_30;
            label_21:
            val_29 = 1;
            return (int)val_29;
            label_12:
            val_24 = 0;
            val_25 = 1;
            val_28 = 0.Keys;
            val_29 = (val_23 + val_28.Count) + 1;
            return (int)val_29;
            label_26:
            val_28 = 0;
            val_22 = 1;
            val_15.Dispose();
            val_29 = val_27 + 1;
            return (int)val_29;
        }
        private static byte[] writeBinaryDictionary(System.Collections.Generic.Dictionary<string, object> dictionary)
        {
            var val_24;
            var val_31;
            var val_32;
            System.Collections.Generic.IEnumerable<T> val_33;
            var val_34;
            System.Byte[] val_35;
            var val_36;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            val_31 = X1.Count - 1;
            goto label_2;
            label_14:
            Add(item:  W23);
            val_31 = val_31 - 1;
            int val_29 = PlistCS.Plist.refCount;
            val_29 = val_29 - 1;
            PlistCS.Plist.refCount = val_29;
            label_2:
            int val_5 = X1.Count;
            if((val_31 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            X1.Values.CopyTo(array:  null, index:  0);
            var val_7 = null + (((long)(int)(((val_4 - 1) - 1))) << 3);
            System.Byte[] val_8 = PlistCS.Plist.composeBinary(obj:  null);
            PlistCS.Plist.offsetTable.Add(item:  PlistCS.Plist.objectTable.Count);
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_4:
            val_32 = val_5 - 1;
            goto label_15;
            label_27:
            Add(item:  val_5);
            val_32 = val_32 - 1;
            int val_30 = PlistCS.Plist.refCount;
            val_30 = val_30 - 1;
            PlistCS.Plist.refCount = val_30;
            label_15:
            if((val_32 & 2147483648) != 0)
            {
                goto label_17;
            }
            
            X1.Keys.CopyTo(array:  null, index:  0);
            var val_12 = null + (((long)(int)(((val_5 - 1) - 1))) << 3);
            System.Byte[] val_13 = PlistCS.Plist.composeBinary(obj:  null);
            PlistCS.Plist.offsetTable.Add(item:  PlistCS.Plist.objectTable.Count);
            if(null != 0)
            {
                goto label_27;
            }
            
            goto label_27;
            label_17:
            if(X1.Count > 14)
            {
                    Add(item:  223);
                val_33 = val_1;
                val_34 = X1;
                val_34 = null;
                AddRange(collection:  PlistCS.Plist.writeBinaryInteger(value:  233226240, write:  val_34.Count));
            }
            else
            {
                    int val_17 = X1.Count;
                val_33 = val_1;
                byte val_20 = ((System.Convert.ToByte(value:  0)) | 208) & 255;
                Add(item:  System.Convert.ToByte(value:  0));
            }
            
            List.Enumerator<T> val_22 = GetEnumerator();
            label_46:
            if((0 & 1) == 0)
            {
                goto label_54;
            }
            
            GooglePlayGames.BasicApi.ResponseStatus val_25 = val_24.Status;
            val_35 = null;
            val_35 = null;
            System.Array.Reverse(array:  0);
            InsertRange(index:  0, collection:  PlistCS.Plist.RegulateNullBytes(value:  val_35, minBytes:  System.BitConverter.GetBytes(value:  0)));
            goto label_46;
            label_54:
            val_24.Dispose();
            InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>());
            val_36 = null;
            val_36 = null;
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  val_33);
            return (System.Byte[])ToArray();
        }
        private static byte[] composeBinaryArray(System.Collections.Generic.List<object> objects)
        {
            var val_18;
            int val_24;
            object val_25;
            var val_26;
            System.Byte[] val_27;
            var val_28;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            val_24 = X1.Count - 1;
            goto label_2;
            label_10:
            Add(item:  W24);
            val_24 = val_24 - 1;
            int val_23 = PlistCS.Plist.refCount;
            val_23 = val_23 - 1;
            PlistCS.Plist.refCount = val_23;
            label_2:
            if((val_24 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            object val_5 = X1.Item[val_24];
            val_25 = null;
            System.Byte[] val_6 = PlistCS.Plist.composeBinary(obj:  val_25);
            PlistCS.Plist.offsetTable.Add(item:  PlistCS.Plist.objectTable.Count);
            if(null != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_4:
            if(X1.Count > 14)
            {
                    Add(item:  175);
                val_26 = X1;
                val_26 = null;
                AddRange(collection:  PlistCS.Plist.writeBinaryInteger(value:  233226240, write:  val_26.Count));
            }
            else
            {
                    int val_11 = X1.Count;
                byte val_14 = ((System.Convert.ToByte(value:  0)) | 160) & 255;
                Add(item:  System.Convert.ToByte(value:  0));
            }
            
            List.Enumerator<T> val_16 = GetEnumerator();
            label_29:
            if((0 & 1) == 0)
            {
                goto label_37;
            }
            
            GooglePlayGames.BasicApi.ResponseStatus val_19 = val_18.Status;
            val_27 = null;
            val_27 = null;
            System.Array.Reverse(array:  0);
            InsertRange(index:  0, collection:  PlistCS.Plist.RegulateNullBytes(value:  val_27, minBytes:  System.BitConverter.GetBytes(value:  0)));
            goto label_29;
            label_37:
            val_18.Dispose();
            InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>());
            val_28 = null;
            val_28 = null;
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>());
            return (System.Byte[])ToArray();
        }
        private static byte[] composeBinary(object obj)
        {
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_29 = X1;
            int val_3 = 0;
            System.Type val_1 = val_29.GetType();
            if(val_1 != null)
            {
                    val_30 = null;
                val_30 = null;
                if((PlistCS.Plist.<>f__switch$map1) == null)
            {
                    if(null != 0)
            {
                    val_31 = 1152921510153291024;
                Add(key:  "System.Collections.Generic.Dictionary`2[System.String,System.Object]", value:  0);
                Add(key:  "System.Collections.Generic.List`1[System.Object]", value:  1);
                Add(key:  "System.Byte[]", value:  2);
                Add(key:  "System.Double", value:  3);
                Add(key:  "System.Int32", value:  4);
                Add(key:  "System.String", value:  5);
                Add(key:  "System.DateTime", value:  6);
            }
            else
            {
                    val_31 = 1152921510153291024;
                Add(key:  "System.Collections.Generic.Dictionary`2[System.String,System.Object]", value:  0);
                Add(key:  "System.Collections.Generic.List`1[System.Object]", value:  1);
                Add(key:  "System.Byte[]", value:  2);
                Add(key:  "System.Double", value:  3);
                Add(key:  "System.Int32", value:  4);
                Add(key:  "System.String", value:  5);
                Add(key:  "System.DateTime", value:  6);
            }
            
                Add(key:  "System.Boolean", value:  7);
                val_32 = null;
                val_32 = null;
                PlistCS.Plist.<>f__switch$map1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(capacity:  8);
                val_30 = null;
            }
            
                val_30 = null;
                val_33 = PlistCS.Plist.<>f__switch$map1;
                if(((TryGetValue(key:  val_1, value: out  val_3)) != false) && (val_3 <= 8))
            {
                    if(11 > 18)
            {
                    return (System.Byte[])val_33;
            }
            
            }
            
            }
            
            val_29 = null;
            val_33 = val_29;
            return (System.Byte[])val_33;
            label_65:
            goto label_65;
        }
        public static byte[] writeBinaryDate(System.DateTime obj)
        {
            if(null != 0)
            {
                    Reverse();
            }
            else
            {
                    Reverse();
            }
            
            Insert(index:  0, item:  51);
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>(collection:  PlistCS.Plist.RegulateNullBytes(value:  null = null, minBytes:  System.BitConverter.GetBytes(value:  PlistCS.PlistDateConverter.ConvertToAppleTimeStamp(date:  new System.DateTime() {ticks = new System.TimeSpan(), kind = obj.kind})))));
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        public static byte[] writeBinaryBool(bool obj)
        {
            var val_3;
            typeof(System.Byte[]).__il2cppRuntimeField_20 = (W1 != 1) ? (8 + 1) : 8;
            val_3 = null;
            val_3 = null;
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>(collection:  null));
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        private static byte[] writeBinaryInteger(int value, bool write)
        {
            System.Collections.Generic.List<System.Byte> val_12;
            System.Byte[] val_13;
            var val_14;
            var val_15;
            val_12 = W2;
            System.Collections.Generic.List<System.Byte> val_2 = new System.Collections.Generic.List<System.Byte>(collection:  System.BitConverter.GetBytes(value:  0));
            T[] val_3 = ToArray();
            val_13 = null;
            goto label_6;
            label_10:
            Add(item:  0);
            label_6:
            if(null != 0)
            {
                    val_14 = Count;
            }
            else
            {
                    val_14 = Count;
            }
            
            double val_12 = (double)Count;
            val_12 = val_12 / 0.693147180559945;
            if((double)val_14 != val_12)
            {
                goto label_10;
            }
            
            double val_13 = (double)Count;
            val_13 = val_13 / 0.693147180559945;
            double val_10 = (int)val_13 | 16;
            Reverse();
            Insert(index:  0, item:  System.Convert.ToByte(value:  0));
            if((val_12 & 1) != 0)
            {
                    val_15 = null;
                val_15 = null;
                val_12 = PlistCS.Plist.objectTable;
                val_12.InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>(collection:  PlistCS.Plist.RegulateNullBytes(value:  val_13)));
            }
            
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        private static byte[] writeBinaryDouble(double value)
        {
            System.Byte[] val_10;
            var val_11;
            var val_12;
            val_10 = null;
            goto label_5;
            label_9:
            Add(item:  0);
            label_5:
            if(null != 0)
            {
                    val_11 = Count;
            }
            else
            {
                    val_11 = Count;
            }
            
            double val_10 = (double)Count;
            val_10 = val_10 / 0.693147180559945;
            if((double)val_11 != val_10)
            {
                goto label_9;
            }
            
            double val_11 = (double)Count;
            val_11 = val_11 / 0.693147180559945;
            double val_8 = (int)val_11 | 32;
            Reverse();
            Insert(index:  0, item:  System.Convert.ToByte(value:  0));
            val_12 = null;
            val_12 = null;
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>(collection:  PlistCS.Plist.RegulateNullBytes(value:  val_10, minBytes:  System.BitConverter.GetBytes(value:  value))));
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        private static byte[] writeBinaryByteArray(byte[] value)
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>(collection:  X1);
            if((X1 + 24) > 14)
            {
                    Add(item:  79);
                val_9 = val_1;
                val_9 = null;
                AddRange(collection:  PlistCS.Plist.writeBinaryInteger(value:  233226240, write:  Count));
            }
            else
            {
                    byte val_7 = ((System.Convert.ToByte(value:  0)) | 64) & 255;
                Add(item:  System.Convert.ToByte(value:  0));
            }
            
            InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>());
            val_10 = null;
            val_10 = null;
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  val_1);
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        private static byte[] writeBinaryString(string value, bool head)
        {
            var val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            val_13 = 0;
            goto label_2;
            label_9:
            Add(item:  W24);
            val_13 = 1;
            label_2:
            if(val_13 >= val_3.Length)
            {
                goto label_4;
            }
            
            char val_13 = head.ToCharArray()[1];
            byte val_4 = System.Convert.ToByte(value:  ' ');
            if(null != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_4:
            if((W2 & 1) != 0)
            {
                    if(head.Length > 14)
            {
                    Add(item:  95);
                val_14 = val_1;
                val_14 = null;
                AddRange(collection:  PlistCS.Plist.writeBinaryInteger(value:  233226240, write:  Count));
            }
            else
            {
                    int val_8 = head.Length;
                byte val_11 = ((System.Convert.ToByte(value:  0)) | 80) & 255;
                Add(item:  System.Convert.ToByte(value:  0));
            }
            
            }
            
            InsertRange(index:  0, collection:  new System.Collections.Generic.List<System.Byte>());
            val_15 = null;
            val_15 = null;
            PlistCS.Plist.objectTable.InsertRange(index:  0, collection:  val_1);
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        private static byte[] RegulateNullBytes(byte[] value)
        {
            return PlistCS.Plist.RegulateNullBytes(value:  null, minBytes:  X1);
        }
        private static byte[] RegulateNullBytes(byte[] value, int minBytes)
        {
            System.Collections.Generic.IEnumerable<T> val_12;
            var val_12 = W2;
            val_12 = minBytes;
            System.Array.Reverse(array:  0);
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>(collection:  val_12);
            goto label_1;
            label_10:
            bool val_2 = Remove(item:  val_12);
            label_1:
            if(((Count <= 0) || ((Item[0] & 255) != 0)) || (Count <= val_12))
            {
                goto label_7;
            }
            
            if(null == 0)
            {
                goto label_8;
            }
            
            byte val_7 = Item[0];
            goto label_10;
            label_8:
            byte val_8 = Item[0];
            goto label_10;
            label_7:
            if(Count < val_12)
            {
                    val_12 = val_12 - Count;
                if(val_12 >= 1)
            {
                    val_12 = 1152921510155950720;
                do
            {
                Insert(index:  0, item:  0);
                val_12 = val_12 - 1;
            }
            while(val_12 != 0);
            
            }
            
            }
            
            System.Array.Reverse(array:  0);
            return (System.Byte[])ToArray();
        }
        private static void parseTrailer(System.Collections.Generic.List<byte> trailer)
        {
            PlistCS.Plist.offsetByteSize = System.BitConverter.ToInt32(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  null = null, minBytes:  X1.GetRange(index:  6, count:  1).ToArray()));
            T[] val_6 = X1.GetRange(index:  7, count:  1).ToArray();
            PlistCS.Plist.objRefSize = System.BitConverter.ToInt32(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  val_6, minBytes:  val_6));
            System.Array.Reverse(array:  0);
            PlistCS.Plist.refCount = System.BitConverter.ToInt32(value:  0, startIndex:  X1.GetRange(index:  12, count:  4).ToArray());
            System.Array.Reverse(array:  0);
            PlistCS.Plist.offsetTableOffset = System.BitConverter.ToInt64(value:  0, startIndex:  X1.GetRange(index:  24, count:  8).ToArray());
        }
        private static void parseOffsetTable(System.Collections.Generic.List<byte> offsetTableBytes)
        {
            int val_6;
            var val_7;
            val_6 = 0;
            goto label_1;
            label_11:
            X21.Add(item:  W22);
            val_6 = PlistCS.Plist.offsetByteSize + val_6;
            label_1:
            if(val_6 >= X1.Count)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            System.Array.Reverse(array:  0);
            int val_5 = System.BitConverter.ToInt32(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  0, minBytes:  X1.GetRange(index:  val_6, count:  PlistCS.Plist.offsetByteSize).ToArray()));
            if(PlistCS.Plist.offsetTable != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        private static object parseBinaryDictionary(int objRef)
        {
            var val_26;
            var val_27;
            var val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            int val_34;
            int val_36;
            int val_37;
            var val_38;
            string val_39;
            object val_40;
            val_26 = null;
            val_26 = null;
            int val_3 = PlistCS.Plist.offsetTable.Item[W1];
            int val_5 = PlistCS.Plist.getCount(bytePosition:  val_3, newBytePosition: out  val_3);
            val_27 = null;
            if(val_5 > 14)
            {
                    val_28 = null;
                System.Byte[] val_9 = System.BitConverter.GetBytes(value:  0);
                System.Byte[] val_10 = PlistCS.Plist.RegulateNullBytes(value:  val_9, minBytes:  val_9);
                int val_24 = val_10.Length;
                val_24 = PlistCS.Plist.offsetTable.Item[W1] + val_24;
                val_29 = val_24 + 2;
            }
            else
            {
                    val_30 = null;
                val_29 = PlistCS.Plist.offsetTable.Item[W1] + 1;
            }
            
            val_31 = null;
            val_32 = 1152921509624663856;
            val_33 = 1152921504657805312;
            val_34 = val_29;
            goto label_15;
            label_26:
            Add(item:  PlistCS.Plist.offsetTable);
            val_31 = null;
            val_34 = PlistCS.Plist.objRefSize + val_34;
            label_15:
            val_31 = null;
            val_36 = PlistCS.Plist.objRefSize;
            if(val_34 >= (val_29 + ((val_5 << 1) * val_36)))
            {
                goto label_18;
            }
            
            val_37 = PlistCS.Plist.objRefSize;
            System.Array.Reverse(array:  0);
            int val_17 = System.BitConverter.ToInt32(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  0, minBytes:  PlistCS.Plist.objectTable.GetRange(index:  val_34, count:  val_37).ToArray()));
            if(null != 0)
            {
                goto label_26;
            }
            
            goto label_26;
            label_18:
            if(val_5 < 1)
            {
                    return (object)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            val_33 = 1152921504608284672;
            val_32 = 1152921509093701200;
            var val_25 = 0;
            label_35:
            val_38 = new System.Collections.Generic.List<System.Int32>();
            int val_18 = Item[0];
            val_38 = null;
            val_39 = PlistCS.Plist.parseBinary(objRef:  233226240);
            val_40 = PlistCS.Plist.parseBinary(objRef:  Item[val_5 + val_25]);
            if(val_39 != null)
            {
                    if(null == null)
            {
                goto label_34;
            }
            
            }
            
            val_39 = 0;
            label_34:
            Add(key:  val_39, value:  val_40);
            val_25 = val_25 + 1;
            if(val_25 < val_5)
            {
                goto label_35;
            }
            
            return (object)new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        private static object parseBinaryArray(int objRef)
        {
            var val_21;
            var val_22;
            var val_23;
            int val_24;
            var val_25;
            var val_26;
            int val_27;
            int val_29;
            int val_30;
            var val_31;
            object val_32;
            val_21 = null;
            val_21 = null;
            int val_3 = PlistCS.Plist.offsetTable.Item[W1];
            int val_5 = PlistCS.Plist.getCount(bytePosition:  val_3, newBytePosition: out  val_3);
            val_22 = null;
            if(val_5 > 14)
            {
                    val_23 = null;
                System.Byte[] val_9 = System.BitConverter.GetBytes(value:  0);
                System.Byte[] val_10 = PlistCS.Plist.RegulateNullBytes(value:  val_9, minBytes:  val_9);
                int val_19 = val_10.Length;
                val_19 = PlistCS.Plist.offsetTable.Item[W1] + val_19;
                val_24 = val_19 + 2;
            }
            else
            {
                    val_25 = null;
                val_24 = PlistCS.Plist.offsetTable.Item[W1] + 1;
            }
            
            val_26 = null;
            val_27 = val_24;
            goto label_15;
            label_26:
            Add(item:  PlistCS.Plist.offsetTable);
            val_26 = null;
            val_27 = PlistCS.Plist.objRefSize + val_27;
            label_15:
            val_26 = null;
            val_29 = PlistCS.Plist.objRefSize;
            if(val_27 >= (val_24 + (val_29 * val_5)))
            {
                goto label_18;
            }
            
            val_30 = PlistCS.Plist.objRefSize;
            System.Array.Reverse(array:  0);
            int val_16 = System.BitConverter.ToInt32(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  0, minBytes:  PlistCS.Plist.objectTable.GetRange(index:  val_27, count:  val_30).ToArray()));
            if(null != 0)
            {
                goto label_26;
            }
            
            goto label_26;
            label_18:
            if(val_5 < 1)
            {
                    return (object)new System.Collections.Generic.List<System.Object>();
            }
            
            var val_20 = 0;
            do
            {
                val_31 = new System.Collections.Generic.List<System.Int32>();
                int val_17 = Item[0];
                val_31 = null;
                val_32 = PlistCS.Plist.parseBinary(objRef:  233226240);
                Add(item:  val_32);
                val_20 = val_20 + 1;
            }
            while(val_5 != val_20);
            
            return (object)new System.Collections.Generic.List<System.Object>();
        }
        private static int getCount(int bytePosition, out int newBytePosition)
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = X2;
            val_9 = null;
            val_9 = null;
            byte val_2 = PlistCS.Plist.objectTable.Item[1257792240] & 15;
            val_10 = (System.Convert.ToByte(value:  0)) & 255;
            if(val_10 > 14)
            {
                    object val_5 = PlistCS.Plist.parseBinaryInt(headerPosition:  233226240, newHeaderPosition: out  1152921510159606513);
                val_8 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                return (int)val_10;
            }
            
            mem2[0] = 1152921510159606513;
            return (int)val_10;
        }
        private static object parseBinary(int objRef)
        {
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            int val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_18 = W1;
            val_19 = null;
            val_19 = null;
            byte val_3 = PlistCS.Plist.objectTable.Item[PlistCS.Plist.offsetTable.Item[val_18]] & 240;
            if(val_3 <= 63)
            {
                goto label_5;
            }
            
            if(val_3 <= 95)
            {
                goto label_6;
            }
            
            if(val_3 == 96)
            {
                goto label_7;
            }
            
            if(val_3 == 160)
            {
                    return PlistCS.Plist.parseBinaryArray(objRef:  233226240);
            }
            
            if(val_3 != 208)
            {
                goto label_24;
            }
            
            return PlistCS.Plist.parseBinaryDictionary(objRef:  233226240);
            label_5:
            if(val_3 > 31)
            {
                goto label_12;
            }
            
            if(val_3 == 0)
            {
                goto label_13;
            }
            
            if(val_3 != 16)
            {
                goto label_24;
            }
            
            val_20 = null;
            val_20 = null;
            return PlistCS.Plist.parseBinaryInt(headerPosition:  PlistCS.Plist.offsetTable.Item[val_18]);
            label_6:
            if(val_3 == 64)
            {
                goto label_18;
            }
            
            if(val_3 != 80)
            {
                goto label_24;
            }
            
            val_21 = null;
            val_21 = null;
            return PlistCS.Plist.parseBinaryAsciiString(headerPosition:  PlistCS.Plist.offsetTable.Item[val_18]);
            label_12:
            if(val_3 == 32)
            {
                goto label_23;
            }
            
            if(val_3 != 48)
            {
                goto label_24;
            }
            
            val_22 = null;
            val_22 = null;
            return PlistCS.Plist.parseBinaryDate(headerPosition:  PlistCS.Plist.offsetTable.Item[val_18]);
            label_7:
            val_23 = null;
            val_23 = null;
            return PlistCS.Plist.parseBinaryUnicodeString(headerPosition:  PlistCS.Plist.offsetTable.Item[val_18]);
            label_13:
            val_24 = null;
            val_24 = null;
            val_25 = PlistCS.Plist.offsetTable.Item[val_18];
            if((PlistCS.Plist.objectTable.Item[val_25] & 255) == 0)
            {
                goto label_37;
            }
            
            val_26 = null;
            val_26 = null;
            val_25 = PlistCS.Plist.offsetTable;
            val_18 = val_25.Item[val_18];
            var val_14 = ((PlistCS.Plist.objectTable.Item[val_18] & 255) == 9) ? 1 : 0;
            return (object)val_27;
            label_18:
            val_28 = null;
            val_28 = null;
            return PlistCS.Plist.parseBinaryByteArray(headerPosition:  PlistCS.Plist.offsetTable.Item[val_18]);
            label_23:
            val_29 = null;
            val_29 = null;
            return PlistCS.Plist.parseBinaryReal(headerPosition:  PlistCS.Plist.offsetTable.Item[val_18]);
            label_37:
            val_27 = 0;
            return (object)val_27;
            label_24:
            System.Exception val_17 = new System.Exception(message:  "This type is not supported");
        }
        public static object parseBinaryDate(int headerPosition)
        {
            null = null;
            System.Array.Reverse(array:  0);
            System.DateTime val_5 = PlistCS.PlistDateConverter.ConvertFromAppleTimeStamp(timestamp:  System.BitConverter.ToDouble(value:  0, startIndex:  PlistCS.Plist.objectTable.GetRange(index:  W1 + 1, count:  8).ToArray()));
            return (object)val_5;
        }
        private static object parseBinaryInt(int headerPosition)
        {
            return (object)PlistCS.Plist.parseBinaryInt(headerPosition:  233226240, newHeaderPosition: out  W1);
        }
        private static object parseBinaryInt(int headerPosition, out int newHeaderPosition)
        {
            null = null;
            byte val_1 = PlistCS.Plist.objectTable.Item[1258443984];
            val_1 = val_1 & 15;
            System.Array.Reverse(array:  0);
            mem2[0] = 1152921510160258257 + 1;
            return (object)System.BitConverter.ToInt32(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  0, minBytes:  PlistCS.Plist.objectTable.GetRange(index:  1258443985, count:  1).ToArray()));
        }
        private static object parseBinaryReal(int headerPosition)
        {
            null = null;
            byte val_1 = PlistCS.Plist.objectTable.Item[W1];
            val_1 = val_1 & 15;
            System.Array.Reverse(array:  0);
            return (object)System.BitConverter.ToDouble(value:  0, startIndex:  PlistCS.Plist.RegulateNullBytes(value:  0, minBytes:  PlistCS.Plist.objectTable.GetRange(index:  W1 + 1, count:  1).ToArray()));
        }
        private static object parseBinaryAsciiString(int headerPosition)
        {
            var val_7;
            string val_8;
            var val_9;
            System.Collections.Generic.List<T> val_3 = PlistCS.Plist.objectTable.GetRange(index:  0, count:  PlistCS.Plist.getCount(bytePosition:  233226240, newBytePosition: out  W1));
            if(val_3.Count >= 1)
            {
                    val_7 = val_3.ToArray();
                val_8 = System.Text.Encoding.ASCII;
                return (object)val_8;
            }
            
            val_7 = 1152921504608284672;
            val_9 = null;
            val_9 = null;
            val_8 = System.String.Empty;
            return (object)val_8;
        }
        private static object parseBinaryUnicodeString(int headerPosition)
        {
            var val_9;
            var val_10;
            int val_3 = (PlistCS.Plist.getCount(bytePosition:  233226240, newBytePosition: out  W1)) << 1;
            if(val_3 >= 1)
            {
                    var val_13 = 0;
                do
            {
                val_9 = null;
                val_9 = null;
                byte val_6 = PlistCS.Plist.objectTable.GetRange(index:  0 + val_13, count:  1).Item[0];
                byte val_10 = PlistCS.Plist.objectTable.GetRange(index:  (0 + val_13) + 1, count:  1).Item[0];
                val_10 = null;
                val_10 = null;
                var val_11 = val_13 + 1;
                if(System.BitConverter.IsLittleEndian != false)
            {
                    typeof(System.Byte[]).__il2cppRuntimeField_20 = val_10;
                typeof(System.Byte[]).__il2cppRuntimeField_21 = val_6;
            }
            else
            {
                    typeof(System.Byte[]).__il2cppRuntimeField_20 = val_6;
                typeof(System.Byte[]).__il2cppRuntimeField_21 = val_10;
            }
            
                val_13 = val_13 + 2;
            }
            while(val_13 < (long)val_3);
            
            }
            
            System.Text.Encoding val_12 = System.Text.Encoding.Unicode;
            if(val_12 != null)
            {
                    return (object)val_12;
            }
            
            return (object)val_12;
        }
        private static object parseBinaryByteArray(int headerPosition)
        {
            return (object)PlistCS.Plist.objectTable.GetRange(index:  0, count:  PlistCS.Plist.getCount(bytePosition:  233226240, newBytePosition: out  W1)).ToArray();
        }
        private static Plist()
        {
            PlistCS.Plist.offsetTable = new System.Collections.Generic.List<System.Int32>();
            PlistCS.Plist.objectTable = new System.Collections.Generic.List<System.Byte>();
        }
    
    }

}
