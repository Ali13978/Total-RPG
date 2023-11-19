using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXParser
    {
        // Fields
        public const string PBX_HEADER_TOKEN = "// !$*UTF8*$!\n";
        public const char WHITESPACE_SPACE = '\x20';
        public const char WHITESPACE_TAB = '\x9';
        public const char WHITESPACE_NEWLINE = '\xa';
        public const char WHITESPACE_CARRIAGE_RETURN = '\xd';
        public const char ARRAY_BEGIN_TOKEN = '\x28';
        public const char ARRAY_END_TOKEN = '\x29';
        public const char ARRAY_ITEM_DELIMITER_TOKEN = '\x2c';
        public const char DICTIONARY_BEGIN_TOKEN = '\x7b';
        public const char DICTIONARY_END_TOKEN = '\x7d';
        public const char DICTIONARY_ASSIGN_TOKEN = '\x3d';
        public const char DICTIONARY_ITEM_DELIMITER_TOKEN = '\x3b';
        public const char QUOTEDSTRING_BEGIN_TOKEN = '\x22';
        public const char QUOTEDSTRING_END_TOKEN = '\x22';
        public const char QUOTEDSTRING_ESCAPE_TOKEN = '\x5c';
        public const char END_OF_FILE = '\x1a';
        public const string COMMENT_BEGIN_TOKEN = "/*";
        public const string COMMENT_END_TOKEN = "*/";
        public const string COMMENT_LINE_TOKEN = "//";
        private const int BUILDER_CAPACITY = 20000;
        private char[] data;
        private int index;
        private UnityEditor.XCodeEditor.PBXResolver resolver;
        private string marker;
        
        // Methods
        public PBXParser()
        {
        
        }
        public UnityEditor.XCodeEditor.PBXDictionary Decode(string data)
        {
            var val_8;
            if((data.StartsWith(value:  "// !$*UTF8*$!\n")) != false)
            {
                    this.data = data.Substring(startIndex:  13).ToCharArray();
                this.index = 0;
                object val_5 = this.ParseValue();
                val_8 = 0;
                if(val_5 == null)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_8;
            }
            
                val_8 = val_5;
            }
            else
            {
                    UnityEngine.Debug.Log(message:  0);
            }
            
            val_8 = 0;
            return (UnityEditor.XCodeEditor.PBXDictionary)val_8;
        }
        public string Encode(UnityEditor.XCodeEditor.PBXDictionary pbxData, bool readable = False)
        {
            bool val_12;
            var val_13;
            val_12 = readable;
            val_13 = this;
            this.resolver = new UnityEditor.XCodeEditor.PBXResolver(pbxData:  pbxData);
            this.resolver = 0;
            System.Text.StringBuilder val_5 = Append(value:  "\n");
            if((this.SerializeValue(value:  pbxData, builder:  new System.Text.StringBuilder(value:  "// !$*UTF8*$!\n", capacity:  32), readable:  val_12, indent:  0)) == false)
            {
                    return 0;
            }
            
            val_13 = ???;
            val_12 = ???;
            goto mem[null + 320];
        }
        private void Indent(System.Text.StringBuilder builder, int deep)
        {
            null = null;
            System.Text.StringBuilder val_2 = builder.Append(value:  System.String.Empty.PadLeft(totalWidth:  deep, paddingChar:  '	'));
        }
        private void Endline(System.Text.StringBuilder builder, bool useSpace = False)
        {
            System.Text.StringBuilder val_2 = builder.Append(value:  (useSpace != true) ? " " : "\n");
        }
        private void MarkSection(System.Text.StringBuilder builder, string name)
        {
            var val_8;
            if((name | this.marker) == null)
            {
                    return;
            }
            
            if(this.marker != null)
            {
                    val_8 = 1152921504608284672;
                if((System.String.op_Inequality(a:  0, b:  name)) != false)
            {
                    System.Text.StringBuilder val_4 = builder.Append(value:  System.String.Format(format:  0, arg0:  "/* End {0} section */\n"));
            }
            
            }
            
            if(name != null)
            {
                    val_8 = 1152921504608284672;
                if((System.String.op_Inequality(a:  0, b:  name)) != false)
            {
                    System.Text.StringBuilder val_7 = builder.Append(value:  System.String.Format(format:  0, arg0:  "\n/* Begin {0} section */\n"));
            }
            
            }
            
            this.marker = name;
        }
        private bool GUIDComment(string guid, System.Text.StringBuilder builder)
        {
            var val_9;
            var val_11;
            val_9 = builder;
            string val_1 = this.resolver.ResolveName(guid:  guid);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if((this.resolver.ResolveBuildPhaseNameForFile(guid:  guid)) == null)
            {
                goto label_4;
            }
            
            string val_5 = System.String.Format(format:  0, arg0:  " /* {0} in {1} */", arg1:  val_1);
            goto label_7;
            label_3:
            val_9 = 0 + "GUIDComment " + guid;
            UnityEngine.Debug.Log(message:  0);
            val_11 = 0;
            return (bool)val_11;
            label_4:
            label_7:
            System.Text.StringBuilder val_8 = val_9.Append(value:  System.String.Format(format:  0, arg0:  " /* {0} */"));
            val_11 = 1;
            return (bool)val_11;
        }
        private char NextToken()
        {
            bool val_1 = this.SkipWhitespaces();
            return this.StepForeward(step:  1);
        }
        private string Peek(int step = 1)
        {
            var val_3;
            string val_4;
            val_3 = null;
            val_3 = null;
            val_4 = System.String.Empty;
            if(step < 1)
            {
                    return (string)val_4;
            }
            
            var val_5 = 1;
            do
            {
                int val_3 = this.data.Length;
                val_3 = val_3 - 1;
                int val_1 = val_5 + this.index;
                if(val_3 < val_1)
            {
                    return (string)val_4;
            }
            
                char val_4 = this.data[(long)val_1];
                val_4 = 0 + val_4;
                val_5 = val_5 + 1;
            }
            while(val_5 <= step);
            
            return (string)val_4;
        }
        private bool SkipWhitespaces()
        {
            var val_7;
            do
            {
                val_7 = 0;
            }
            while((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  this.StepForeward(step:  1).ToString(provider:  0))) == true);
            
            char val_5 = this.StepBackward(step:  1);
            if(this.SkipComments() == false)
            {
                    return (bool)val_7 & 1;
            }
            
            val_7 = 1;
            return (bool)val_7 & 1;
        }
        private bool SkipComments()
        {
            var val_14;
            var val_15;
            string val_16;
            string val_17;
            var val_18;
            val_14 = this;
            val_15 = null;
            val_15 = null;
            val_16 = System.String.Empty;
            val_17 = this.Peek(step:  2);
            if(val_17 == null)
            {
                goto label_15;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_17)) == false)
            {
                goto label_6;
            }
            
            goto label_7;
            label_12:
            val_16 = 0 + val_16;
            label_7:
            val_17 = this.Peek(step:  2);
            if((val_17.CompareTo(strB:  "*/")) == 0)
            {
                goto label_9;
            }
            
            char val_6 = this.StepForeward(step:  1);
            goto label_12;
            label_6:
            if((System.String.op_Equality(a:  0, b:  val_17)) == false)
            {
                goto label_15;
            }
            
            val_17 = 1152921504696090624;
            do
            {
            
            }
            while((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  this.StepForeward(step:  1).ToString(provider:  0))) == false);
            
            goto label_19;
            label_15:
            val_18 = 0;
            return (bool)val_18;
            label_9:
            val_14 = this.StepForeward(step:  2);
            string val_13 = 0 + val_16;
            label_19:
            val_18 = 1;
            return (bool)val_18;
        }
        private char StepForeward(int step = 1)
        {
            int val_1 = this.index + step;
            int val_2 = System.Math.Min(val1:  0, val2:  this.data.Length);
            this.index = val_2;
            return (char)this.data[(long)val_2];
        }
        private char StepBackward(int step = 1)
        {
            int val_1 = this.index - step;
            int val_2 = System.Math.Max(val1:  0, val2:  0);
            this.index = val_2;
            return (char)this.data[(long)val_2];
        }
        private object ParseValue()
        {
            var val_7;
            bool val_1 = this.SkipWhitespaces();
            char val_3 = (this.StepForeward(step:  1)) & 65535;
            if(val_3 > ''')
            {
                goto label_1;
            }
            
            if(val_3 == '')
            {
                goto label_2;
            }
            
            if(val_3 != '"')
            {
                goto label_5;
            }
            
            return this.ParseString();
            label_1:
            if(val_3 == '(')
            {
                    return (object)this.ParseArray();
            }
            
            if(val_3 != '{')
            {
                goto label_5;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary val_4 = this.ParseDictionary();
            return (object)this.ParseArray();
            label_2:
            UnityEngine.Debug.Log(message:  0);
            val_7 = 0;
            return (object)this.ParseArray();
            label_5:
            char val_6 = this.StepBackward(step:  1);
            return this.ParseEntity();
        }
        private UnityEditor.XCodeEditor.PBXDictionary ParseDictionary()
        {
            var val_16;
            bool val_1 = this.SkipWhitespaces();
            val_16 = null;
            val_16 = null;
            bool val_3 = this.SkipWhitespaces();
            char val_5 = (this.StepForeward(step:  1)) & 65535;
            val_5 = val_5 - 52;
            if((((val_5 - 59) < '') ? (val_5) : 0) > 9)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)new UnityEditor.XCodeEditor.PBXDictionary();
            }
            
            var val_16 = 25809120 + (val_6 < '' ? ((val_4 & 65535) - 52) : 0) << 2;
            val_16 = val_16 + 25809120;
            goto (25809120 + (val_6 < '' ? ((val_4 & 65535) - 52) : 0) << 2 + 25809120);
        }
        private UnityEditor.XCodeEditor.PBXList ParseArray()
        {
            goto label_3;
            label_8:
            int val_2 = Add(value:  X21);
            label_3:
            bool val_3 = this.SkipWhitespaces();
            char val_5 = (this.StepForeward(step:  1)) & 65535;
            if((val_5 - 41) > '')
            {
                goto label_4;
            }
            
            if((25809408 + (((val_4 & 65535) - 41)) << 2) == 7)
            {
                goto label_3;
            }
            
            if((25809408 + (((val_4 & 65535) - 41)) << 2) != 6)
            {
                    if((25809408 + (((val_4 & 65535) - 41)) << 2) != 0)
            {
                    return (UnityEditor.XCodeEditor.PBXList)new UnityEditor.XCodeEditor.PBXList();
            }
            
            }
            
            label_4:
            if(val_5 == '')
            {
                goto label_6;
            }
            
            char val_7 = this.StepBackward(step:  1);
            object val_8 = this.ParseValue();
            if(null != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            string val_9 = 0 + "Error: Reached end of file inside a list: "("Error: Reached end of file inside a list: ");
            UnityEngine.Debug.Log(message:  0);
            return (UnityEditor.XCodeEditor.PBXList)new UnityEditor.XCodeEditor.PBXList();
        }
        private object ParseString()
        {
            var val_9;
            string val_10;
            char val_11;
            val_9 = null;
            val_9 = null;
            val_10 = System.String.Empty;
            val_11 = this.StepForeward(step:  1);
            if((val_11 & 65535) == '"')
            {
                    return (object)val_10;
            }
            
            do
            {
                val_10 = 0 + val_10;
                if((val_11 & 65535) == '\')
            {
                    char val_5 = this.StepForeward(step:  1);
                val_10 = 0 + val_10;
            }
            
                val_11 = this.StepForeward(step:  1);
            }
            while((val_11 & 65535) != '"');
            
            return (object)val_10;
        }
        private object ParseEntity()
        {
            var val_8;
            string val_9;
            val_8 = null;
            val_8 = null;
            val_9 = System.String.Empty;
            goto label_3;
            label_9:
            val_9 = 0 + val_9;
            label_3:
            if((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  this.Peek(step:  1))) == true)
            {
                goto label_6;
            }
            
            char val_4 = this.StepForeward(step:  1);
            goto label_9;
            label_6:
            if(val_9.Length == 24)
            {
                    return (object)val_9;
            }
            
            if((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  val_9)) == false)
            {
                    return (object)val_9;
            }
            
            val_9 = System.Int32.Parse(s:  0);
            return (object)val_9;
        }
        private bool SerializeValue(object value, System.Text.StringBuilder builder, bool readable = False, int indent = 0)
        {
            bool val_21;
            System.Text.StringBuilder val_22;
            var val_23;
            System.Collections.ICollection val_24;
            var val_25;
            var val_30;
            var val_31;
            string val_32;
            var val_33;
            val_21 = readable;
            val_22 = builder;
            val_23 = this;
            if(value == null)
            {
                goto label_1;
            }
            
            if(value.GetType().IsArray == false)
            {
                goto label_7;
            }
            
            val_24 = value;
            if(val_24 == null)
            {
                    val_24 = 0;
            }
            
            System.Collections.ArrayList val_5 = new System.Collections.ArrayList(c:  val_24);
            readable = val_21;
            bool val_6 = this.SerializeArray(anArray:  null, builder:  val_22, readable:  readable, indent:  indent);
            val_25 = 1;
            return (bool)val_25;
            label_1:
            label_31:
            System.Text.StringBuilder val_7 = val_22.Append(value:  "null");
            val_25 = 1;
            return (bool)val_25;
            label_7:
            if(null == null)
            {
                goto label_14;
            }
            
            val_21 = 1152921504608231424;
            if(null == null)
            {
                goto label_15;
            }
            
            if(null == null)
            {
                goto label_16;
            }
            
            val_23 = value.GetType();
            if(val_23.IsPrimitive == false)
            {
                goto label_18;
            }
            
            string val_11 = System.Convert.ToString(value:  0);
            goto label_21;
            label_14:
            val_30 = 0;
            val_31 = 0;
            val_32 = value;
            goto label_24;
            label_15:
            val_33 = 1152921504606900224;
            goto label_38;
            label_16:
            int val_14 = System.Convert.ToInt32(value:  0);
            label_21:
            if(val_22 != null)
            {
                goto label_31;
            }
            
            goto label_31;
            label_18:
            System.Type val_15 = value.GetType();
            val_22 = 0 + "Error: unknown object of type "("Error: unknown object of type ");
            UnityEngine.Debug.LogWarning(message:  0);
            val_25 = 0;
            return (bool)val_25;
            label_38:
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_32 = System.Convert.ToString(value:  ' ');
            val_30 = 0;
            val_31 = 0;
            label_24:
            bool val_19 = this.SerializeString(aString:  val_32, builder:  val_22, useQuotes:  false, readable:  false);
            val_25 = 1;
            return (bool)val_25;
            label_40:
            goto label_40;
        }
        private bool SerializeDictionary(System.Collections.Generic.Dictionary<string, object> dictionary, System.Text.StringBuilder builder, bool readable = False, int indent = 0)
        {
            var val_5;
            var val_24;
            if(readable != false)
            {
                    builder.Append(value:  '{').Endline(builder:  builder, useSpace:  false);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = dictionary.GetEnumerator();
            int val_8 = indent + 1;
            bool val_9 = ((indent == 1) ? 1 : 0) & readable;
            label_23:
            if((0 & 1) == 0)
            {
                goto label_29;
            }
            
            UnityEngine.Playables.PlayableHandle val_10 = val_5.GetHandle();
            if(val_9 != false)
            {
                    this.MarkSection(builder:  builder, name:  val_10.m_Handle.GetType());
            }
            
            if(readable != false)
            {
                    this.Indent(builder:  builder, deep:  val_8);
            }
            
            bool val_13 = this.SerializeString(aString:  val_10.m_Handle.InitializationCallback, builder:  builder, useQuotes:  false, readable:  false);
            System.Text.StringBuilder val_15 = builder.Append(value:  System.String.Format(format:  0, arg0:  " {0} "));
            if(readable == false)
            {
                goto label_16;
            }
            
            if(val_10.m_Handle.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_16;
            }
            
            var val_20 = (val_10.m_Handle.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) ? 1 : 0;
            goto label_20;
            label_16:
            val_24 = 0;
            label_20:
            bool val_21 = this.SerializeValue(value:  val_10.m_Handle, builder:  builder, readable:  false, indent:  val_8);
            builder.Append(value:  ';').Endline(builder:  builder, useSpace:  readable ^ 1);
            goto label_23;
            label_29:
            val_5.Dispose();
            if(val_9 != false)
            {
                    this.MarkSection(builder:  builder, name:  0);
            }
            
            if(readable != false)
            {
                    this.Indent(builder:  builder, deep:  indent);
            }
            
            System.Text.StringBuilder val_23 = builder.Append(value:  '}');
            return true;
        }
        private bool SerializeArray(System.Collections.ArrayList anArray, System.Text.StringBuilder builder, bool readable = False, int indent = 0)
        {
            var val_8;
            var val_9;
            if(readable != false)
            {
                    builder.Append(value:  '(').Endline(builder:  builder, useSpace:  false);
            }
            
            val_8 = 0;
            int val_3 = indent + 1;
            goto label_2;
            label_8:
            builder.Append(value:  ',').Endline(builder:  builder, useSpace:  readable ^ 1);
            val_8 = 1;
            label_2:
            if(val_8 >= anArray)
            {
                goto label_4;
            }
            
            if(readable != false)
            {
                    anArray.Indent(builder:  builder, deep:  val_3);
            }
            
            readable = readable;
            if((this.SerializeValue(value:  anArray, builder:  builder, readable:  readable, indent:  val_3)) == false)
            {
                goto label_6;
            }
            
            if(builder != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_4:
            if(readable != false)
            {
                    anArray.Indent(builder:  builder, deep:  indent);
            }
            
            System.Text.StringBuilder val_7 = builder.Append(value:  ')');
            val_9 = 1;
            return (bool)val_9;
            label_6:
            val_9 = 0;
            return (bool)val_9;
        }
        private bool SerializeString(string aString, System.Text.StringBuilder builder, bool useQuotes = False, bool readable = False)
        {
            bool val_12 = useQuotes;
            if((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  aString)) != false)
            {
                    System.Text.StringBuilder val_2 = builder.Append(value:  aString);
                bool val_3 = this.GUIDComment(guid:  aString, builder:  builder);
                return true;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_8;
            }
            
            if(builder == null)
            {
                goto label_9;
            }
            
            System.Text.StringBuilder val_5 = builder.Append(value:  '"');
            goto label_17;
            label_8:
            val_12 = val_12 | ((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  aString)) ^ 1);
            if(val_12 != false)
            {
                    System.Text.StringBuilder val_8 = builder.Append(value:  '"');
            }
            
            System.Text.StringBuilder val_9 = builder.Append(value:  aString);
            if(val_12 == false)
            {
                    return true;
            }
            
            if(builder != null)
            {
                goto label_17;
            }
            
            goto label_18;
            label_9:
            System.Text.StringBuilder val_10 = 0.Append(value:  '"');
            label_18:
            label_17:
            System.Text.StringBuilder val_11 = builder.Append(value:  '"');
            return true;
        }
    
    }

}
