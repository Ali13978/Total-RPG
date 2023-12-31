using UnityEngine;

namespace Mono.Xml
{
    internal class SmallXmlParser
    {
        // Fields
        private Mono.Xml.SmallXmlParser.IContentHandler handler;
        private System.IO.TextReader reader;
        private System.Collections.Stack elementNames;
        private System.Collections.Stack xmlSpaces;
        private string xmlSpace;
        private System.Text.StringBuilder buffer;
        private char[] nameBuffer;
        private bool isWhitespace;
        private Mono.Xml.SmallXmlParser.AttrListImpl attributes;
        private int line;
        private int column;
        private bool resetColumn;
        
        // Methods
        public SmallXmlParser()
        {
            this.elementNames = new System.Collections.Stack();
            this.xmlSpaces = new System.Collections.Stack();
            this.buffer = new System.Text.StringBuilder(capacity:  200);
            this.nameBuffer = null;
            this.line = 1;
            this.attributes = new SmallXmlParser.AttrListImpl();
        }
        private System.Exception Error(string msg)
        {
            return (System.Exception)new Mono.Xml.SmallXmlParserException(msg:  msg, line:  this.line, column:  this.column);
        }
        private System.Exception UnexpectedEndError()
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this.elementNames;
            string val_2 = System.String.Join(separator:  0, value:  ",");
            return this.Error(msg:  System.String.Format(format:  0, arg0:  "Unexpected end of stream. Element stack content is {0}"));
        }
        private bool IsNameChar(char c, bool start)
        {
            var val_9;
            char val_1 = c - 45;
            val_1 = val_1 & 65535;
            if(val_1 >= '')
            {
                    char val_2 = c & 65535;
                val_9 = 1;
                if((val_2 == (':')) || (val_2 == '_'))
            {
                    return (bool)val_9;
            }
            
                char val_3 = c & 65535;
                if(val_3 >= 'ā')
            {
                    val_9 = 1;
                if(((val_3 - 1765) < '') || (val_3 == 'ՙ'))
            {
                    return (bool)val_9;
            }
            
                char val_5 = c - 699;
                val_5 = val_5 & 65535;
                if(val_5 < '')
            {
                    return (bool)val_9;
            }
            
            }
            
                if((System.Char.GetUnicodeCategory(c:  ' ')) > 9)
            {
                    return (bool)val_9;
            }
            
                if((25812080 + (val_6) << 2) == 0)
            {
                    return (bool)val_9;
            }
            
                if((25812080 + (val_6) << 2) != 12)
            {
                    return (bool)val_9;
            }
            
            }
            
            val_9 = start ^ 1;
            return (bool)val_9;
        }
        private bool IsWhitespace(int c)
        {
            int val_1 = c - 9;
            if(val_1 > 4)
            {
                    return (bool)(c == 32) ? 1 : 0;
            }
            
            val_1 = val_1 & 31;
            val_1 = 19 >> val_1;
            val_1 = val_1 & 1;
            if(val_1 == 0)
            {
                    return (bool)(c == 32) ? 1 : 0;
            }
            
            return true;
        }
        public void SkipWhitespaces()
        {
            this.SkipWhitespaces(expected:  false);
        }
        private void HandleWhitespaces()
        {
            goto label_0;
            label_5:
            System.Text.StringBuilder val_1 = X20.Append(value:  W21);
            label_0:
            System.IO.TextReader val_2 = this.reader - 9;
            val_2 = val_2 & 31;
            val_2 = 19 >> val_2;
            val_2 = val_2 & ((val_2 < 5) ? 1 : 0);
            if(this.reader != 32)
            {
                    if((val_2 & 1) == 0)
            {
                goto label_3;
            }
            
            }
            
            int val_4 = this.Read();
            if(this.buffer != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            if(this.reader == 60)
            {
                    return;
            }
            
            if((this.reader & 2147483648) != 0)
            {
                    return;
            }
            
            this.isWhitespace = false;
        }
        public void SkipWhitespaces(bool expected)
        {
            goto label_1;
            label_6:
            int val_1 = this.Read();
            expected = 0;
            label_1:
            if((this.reader - 9) > 4)
            {
                goto label_3;
            }
            
            if((25812128 + ((this.reader - 9)) << 2) == 4)
            {
                goto label_6;
            }
            
            goto label_5;
            label_3:
            if(this.reader == 32)
            {
                goto label_6;
            }
            
            goto label_8;
            label_5:
            if((25812128 + ((this.reader - 9)) << 2) != 0)
            {
                    if((25812128 + ((this.reader - 9)) << 2) != 5)
            {
                    return;
            }
            
            }
            
            label_8:
            if((expected & 1) == 0)
            {
                    return;
            }
            
            System.Exception val_3 = this.Error(msg:  "Whitespace is expected.");
        }
        private int Peek()
        {
            if(this.reader == null)
            {
                
            }
        
        }
        private int Read()
        {
            if(this.reader != 10)
            {
                goto label_1;
            }
            
            this.resetColumn = true;
            goto label_2;
            label_1:
            if(this.resetColumn == false)
            {
                goto label_3;
            }
            
            label_2:
            int val_1 = this.line;
            this.resetColumn = false;
            val_1 = val_1 + 1;
            this.line = val_1;
            this.column = 1;
            return (int)this.reader;
            label_3:
            int val_2 = this.column;
            val_2 = val_2 + 1;
            this.column = val_2;
            return (int)this.reader;
        }
        public void Expect(int c)
        {
            int val_1 = this.Read();
            if((val_1 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(val_1 != c)
            {
                goto label_2;
            }
            
            return;
            label_1:
            System.Exception val_2 = this.UnexpectedEndError();
            goto label_3;
            label_2:
            System.Exception val_4 = this.Error(msg:  System.String.Format(format:  0, arg0:  "Expected \'{0}\' but got {1}", arg1:  c));
            label_3:
        }
        private string ReadUntil(char until, bool handleReferences)
        {
            goto label_7;
            label_9:
            System.Text.StringBuilder val_1 = X23.Append(value:  ' ');
            label_7:
            if((this.reader & 2147483648) != 0)
            {
                goto label_3;
            }
            
            int val_3 = this.Read() & 65535;
            if(val_3 == until)
            {
                goto label_4;
            }
            
            if((val_3 != 38) || (handleReferences == false))
            {
                goto label_6;
            }
            
            this.ReadReference();
            goto label_7;
            label_6:
            if(this.buffer != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_4:
            this.buffer.Length = 0;
            return (string)this.buffer;
            label_3:
            System.Exception val_4 = this.UnexpectedEndError();
        }
        public string ReadName()
        {
            char val_6;
            var val_7;
            int val_8;
            char val_9;
            System.Char[] val_10;
            string val_11;
            if(((this.reader & 2147483648) != 0) || ((this.reader.IsNameChar(c:  this.reader, start:  true)) == false))
            {
                goto label_4;
            }
            
            val_6 = this.reader;
            if((val_6 & 2147483648) != 0)
            {
                goto label_15;
            }
            
            val_7 = 0;
            val_8 = 0;
            label_14:
            val_9 = val_6;
            if((this.reader.IsNameChar(c:  val_9, start:  false)) == false)
            {
                goto label_7;
            }
            
            if(val_8 == this.nameBuffer.Length)
            {
                    val_9 = this.nameBuffer;
                val_10 = null;
                System.Array.Copy(sourceArray:  0, sourceIndex:  val_9, destinationArray:  0, destinationIndex:  410741984, length:  0);
                this.nameBuffer = val_10;
            }
            else
            {
                    val_10 = this.nameBuffer;
            }
            
            if(val_8 >= this.nameBuffer.Length)
            {
                    val_9 = 0;
            }
            
            val_8 = val_8 + 1;
            val_10[0] = val_6;
            int val_4 = this.Read();
            val_6 = this.reader;
            val_7 = val_7 + 2;
            if((val_6 & 2147483648) == 0)
            {
                goto label_14;
            }
            
            label_7:
            if(val_8 == 0)
            {
                goto label_15;
            }
            
            return 0.CreateString(val:  this.nameBuffer, startIndex:  0, length:  val_8);
            label_4:
            val_11 = "XML name start character is expected.";
            goto label_16;
            label_15:
            val_11 = "Valid XML name is expected.";
            label_16:
            System.Exception val_5 = this.Error(msg:  val_11);
        }
        public void Parse(System.IO.TextReader input, Mono.Xml.SmallXmlParser.IContentHandler handler)
        {
            var val_5;
            var val_6;
            var val_7;
            this.handler = handler;
            this.reader = input;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = handler;
            val_6 = 1634628197;
            goto label_6;
            label_8:
            this.ReadContent();
            label_6:
            if((this.reader & 2147483648) == 0)
            {
                goto label_8;
            }
            
            this.HandleBufferedContent();
            if(this.elementNames < 1)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = 1;
                val_7 = handler;
                this.Cleanup();
                return;
            }
            
            System.Exception val_4 = this.Error(msg:  System.String.Format(format:  0, arg0:  "Insufficient close tag: {0}"));
        }
        private void Cleanup()
        {
            this.line = 1;
            this.column = 0;
            this.handler = 0;
            this.reader = 0;
            this.attributes.Clear();
            this.buffer.Length = 0;
            this.isWhitespace = false;
            this.xmlSpace = 0;
        }
        public void ReadContent()
        {
            var val_30;
            var val_31;
            AttrListImpl val_32;
            var val_33;
            var val_34;
            string val_35;
            string val_36;
            IContentHandler val_37;
            object val_38;
            string val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_47;
            string val_49;
            val_30 = this;
            System.IO.TextReader val_1 = this.reader - 9;
            var val_2 = (val_1 < 5) ? 1 : 0;
            if(this.reader == 32)
            {
                goto label_2;
            }
            
            val_1 = val_1 & 31;
            val_1 = 19 >> val_1;
            val_2 = val_1 & val_2;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            label_2:
            val_31 = 0;
            if(this.buffer.Length == 0)
            {
                    this.isWhitespace = true;
            }
            
            this.HandleWhitespaces();
            label_3:
            if(this.reader != 60)
            {
                goto label_7;
            }
            
            int val_4 = this.Read();
            if(this.reader == 63)
            {
                goto label_9;
            }
            
            if(this.reader == 47)
            {
                goto label_10;
            }
            
            if(this.reader != 33)
            {
                goto label_11;
            }
            
            int val_5 = this.Read();
            if(this.reader != 91)
            {
                goto label_13;
            }
            
            int val_6 = this.Read();
            if((System.String.op_Inequality(a:  0, b:  this.ReadName())) == true)
            {
                goto label_16;
            }
            
            this.Expect(c:  91);
            this.ReadCDATASection();
            return;
            label_7:
            this.ReadCharacters();
            return;
            label_9:
            this.HandleBufferedContent();
            int val_9 = this.Read();
            string val_10 = this.ReadName();
            this.SkipWhitespaces(expected:  false);
            val_33 = 1152921504608284672;
            val_34 = null;
            val_34 = null;
            val_35 = System.String.Empty;
            if(this.reader == 63)
            {
                goto label_25;
            }
            
            goto label_21;
            label_28:
            val_36 = 0 + val_35;
            label_21:
            string val_12 = this.ReadUntil(until:  '?', handleReferences:  false);
            val_37 = 0 + val_36;
            if(this.reader == 62)
            {
                goto label_25;
            }
            
            goto label_28;
            label_10:
            this.HandleBufferedContent();
            if(this.elementNames == null)
            {
                goto label_30;
            }
            
            int val_14 = this.Read();
            this.SkipWhitespaces(expected:  false);
            val_38 = this.elementNames;
            if(val_38 == null)
            {
                goto label_32;
            }
            
            if(null == null)
            {
                goto label_33;
            }
            
            label_32:
            val_38 = 0;
            label_33:
            if(this.xmlSpaces < 1)
            {
                goto label_36;
            }
            
            val_39 = this.xmlSpaces;
            if(val_39 != null)
            {
                    if(null == null)
            {
                goto label_39;
            }
            
            }
            
            val_39 = 0;
            label_39:
            this.xmlSpace = val_39;
            goto label_40;
            label_25:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_40 = this.handler;
            goto label_77;
            label_11:
            this.HandleBufferedContent();
            string val_18 = this.ReadName();
            goto label_46;
            label_50:
            val_32 = this.attributes;
            this.ReadAttribute(a:  val_32);
            label_46:
            if(this.reader != 62)
            {
                    if(this.reader != 47)
            {
                goto label_50;
            }
            
            }
            
            val_33 = 1152921504904024064;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_41 = this.handler;
            goto label_55;
            label_13:
            if(this.reader != 45)
            {
                goto label_57;
            }
            
            this.ReadComment();
            return;
            label_36:
            this.xmlSpace = 0;
            label_40:
            val_42 = val_38;
            if((System.String.op_Inequality(a:  0, b:  this.ReadName())) == true)
            {
                goto label_60;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_42 = 3;
            val_43 = this.handler;
            goto label_65;
            label_55:
            val_44 = this.attributes;
            this.attributes.Clear();
            this.SkipWhitespaces(expected:  false);
            if(this.reader != 47)
            {
                goto label_69;
            }
            
            int val_22 = this.Read();
            val_37 = this.handler;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_44 = 3;
            val_45 = val_37;
            goto label_74;
            label_69:
            val_37 = this.xmlSpace;
            if(this.xmlSpaces != null)
            {
                goto label_77;
            }
            
            goto label_77;
            label_65:
            this.Expect(c:  62);
            return;
            label_74:
            label_77:
            this.Expect(c:  62);
            return;
            label_30:
            System.Exception val_25 = this.UnexpectedEndError();
            goto label_78;
            label_60:
            val_47 = System.String.Format(format:  0, arg0:  "End tag mismatch: expected {0} but found {1}", arg1:  val_38);
            goto label_81;
            label_16:
            val_49 = "Invalid declaration markup";
            goto label_87;
            label_57:
            if((System.String.op_Inequality(a:  0, b:  ReadName())) != false)
            {
                    val_49 = "Invalid declaration markup.";
            }
            else
            {
                    val_49 = "This parser does not support document type.";
            }
            
            label_87:
            label_81:
            System.Exception val_29 = Error(msg:  val_49);
            label_78:
        }
        private void HandleBufferedContent()
        {
            var val_3;
            if(this.buffer.Length == 0)
            {
                    return;
            }
            
            if(this.isWhitespace != false)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
            }
            
            val_3 = this.handler;
            this.buffer.Length = 0;
            this.isWhitespace = false;
        }
        private void ReadCharacters()
        {
            this.isWhitespace = false;
            goto label_6;
            label_2:
            int val_1 = this.Read();
            this.ReadReference();
            label_6:
            if(this.reader == 38)
            {
                goto label_2;
            }
            
            if(this.reader == 1)
            {
                    return;
            }
            
            if(this.reader == 60)
            {
                    return;
            }
            
            System.Text.StringBuilder val_3 = this.buffer.Append(value:  this.Read());
            goto label_6;
        }
        private void ReadReference()
        {
            System.Text.StringBuilder val_16;
            var val_17;
            if(this.reader == 35)
            {
                    int val_1 = this.Read();
                int val_2 = this.ReadCharacterReference();
                return;
            }
            
            string val_3 = this.ReadName();
            this.Expect(c:  59);
            if(val_3 == null)
            {
                goto label_26;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                goto label_6;
            }
            
            val_16 = this.buffer;
            val_17 = 38;
            goto label_23;
            label_6:
            if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                goto label_11;
            }
            
            val_16 = this.buffer;
            val_17 = 34;
            goto label_23;
            label_11:
            if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                goto label_16;
            }
            
            val_16 = this.buffer;
            val_17 = 39;
            goto label_23;
            label_16:
            if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                goto label_21;
            }
            
            val_16 = this.buffer;
            val_17 = 60;
            goto label_23;
            label_21:
            if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                goto label_26;
            }
            
            val_16 = this.buffer;
            val_17 = 62;
            label_23:
            System.Text.StringBuilder val_14 = val_16.Append(value:  '>');
            return;
            label_26:
            System.Exception val_15 = this.Error(msg:  "General non-predefined entity reference is not supported in this parser.");
        }
        private int ReadCharacterReference()
        {
            var val_13;
            var val_14;
            System.IO.TextReader val_15;
            if(this.reader != 120)
            {
                goto label_1;
            }
            
            int val_1 = this.Read();
            val_13 = 0;
            if((this.reader & 2147483648) != 0)
            {
                    return (int)val_13;
            }
            
            label_10:
            if((this.reader - 48) <= 9)
            {
                goto label_4;
            }
            
            if((this.reader - 65) <= 5)
            {
                goto label_5;
            }
            
            if((this.reader - 97) > 5)
            {
                    return (int)val_13;
            }
            
            val_14 = this.reader - 83;
            goto label_8;
            label_4:
            val_14 = this.reader - 44;
            goto label_8;
            label_5:
            val_14 = this.reader - 51;
            label_8:
            val_14 = val_14 & 31;
            val_13 = val_13 << val_14;
            int val_5 = this.Read();
            val_15 = this.reader;
            if((val_15 & 2147483648) == 0)
            {
                goto label_10;
            }
            
            return (int)val_13;
            label_1:
            val_13 = 0;
            if((this.reader - 48) > 9)
            {
                    return (int)val_13;
            }
            
            do
            {
                System.IO.TextReader val_7 = this.reader + 20;
                val_7 = val_7 & 31;
                val_13 = val_13 << val_7;
                int val_8 = this.Read();
                val_15 = this.reader;
            }
            while((val_15 - 48) < 10);
            
            return (int)val_13;
        }
        private void ReadAttribute(Mono.Xml.SmallXmlParser.AttrListImpl a)
        {
            System.IO.TextReader val_6;
            var val_7;
            this.SkipWhitespaces(expected:  true);
            val_6 = this.reader;
            if(val_6 == 47)
            {
                    return;
            }
            
            val_6 = this.reader;
            if(val_6 == 62)
            {
                    return;
            }
            
            string val_1 = this.ReadName();
            this.SkipWhitespaces(expected:  false);
            this.Expect(c:  61);
            this.SkipWhitespaces(expected:  false);
            int val_2 = this.Read();
            if(val_2 == 34)
            {
                goto label_5;
            }
            
            if(val_2 != 39)
            {
                goto label_6;
            }
            
            val_7 = 39;
            goto label_7;
            label_5:
            val_7 = 34;
            label_7:
            string val_3 = this.ReadUntil(until:  '"', handleReferences:  true);
            if((System.String.op_Equality(a:  0, b:  val_1)) != false)
            {
                    this.xmlSpace = val_3;
            }
            
            a.Add(name:  val_1, value:  val_3);
            return;
            label_6:
            System.Exception val_5 = this.Error(msg:  "Invalid attribute value markup.");
        }
        private void ReadCDATASection()
        {
            var val_7;
            goto label_1;
            label_12:
            System.Text.StringBuilder val_1 = X21.Append(value:  ' ');
            label_1:
            val_7 = 0;
            goto label_2;
            label_6:
            val_7 = 1;
            label_2:
            if((this.reader & 2147483648) != 0)
            {
                goto label_4;
            }
            
            int val_3 = this.Read() & 65535;
            if(val_3 == 62)
            {
                goto label_5;
            }
            
            if(val_3 == 93)
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            if(val_7 >= 2)
            {
                goto label_8;
            }
            
            label_7:
            var val_8 = 0;
            goto label_9;
            label_11:
            System.Text.StringBuilder val_4 = X21.Append(value:  ']');
            label_9:
            val_8 = val_8 + 1;
            if(val_8 < val_7)
            {
                goto label_11;
            }
            
            goto label_12;
            label_8:
            if(val_7 < 3)
            {
                    return;
            }
            
            var val_5 = val_7 + 1;
            do
            {
                System.Text.StringBuilder val_6 = this.buffer.Append(value:  ']');
                val_5 = val_5 - 1;
            }
            while(val_5 >= 4);
            
            return;
            label_4:
            System.Exception val_7 = this.UnexpectedEndError();
        }
        private void ReadComment()
        {
            this.Expect(c:  45);
            this.Expect(c:  45);
            do
            {
            
            }
            while(this.Read() != 45);
            
            if(this.Read() == 45)
            {
                    if(this.Read() == 62)
            {
                    return;
            }
            
                System.Exception val_4 = this.Error(msg:  "\'--\' is not allowed inside comment markup.");
            }
        
        }
    
    }

}
