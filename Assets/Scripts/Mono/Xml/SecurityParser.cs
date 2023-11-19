using UnityEngine;

namespace Mono.Xml
{
    internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler
    {
        // Fields
        private System.Security.SecurityElement root;
        private System.Security.SecurityElement current;
        private System.Collections.Stack stack;
        
        // Methods
        public SecurityParser()
        {
            this.stack = new System.Collections.Stack();
        }
        public void LoadXml(string xml)
        {
            this.root = 0;
            this.Parse(input:  new System.IO.StringReader(s:  xml), handler:  this);
        }
        public System.Security.SecurityElement ToXml()
        {
            return (System.Security.SecurityElement)this.root;
        }
        public void OnStartParsing(Mono.Xml.SmallXmlParser parser)
        {
        
        }
        public void OnProcessingInstruction(string name, string text)
        {
        
        }
        public void OnIgnorableWhitespace(string s)
        {
        
        }
        public void OnStartElement(string name, Mono.Xml.SmallXmlParser.IAttrList attrs)
        {
            System.Collections.Stack val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            System.Security.SecurityElement val_1 = new System.Security.SecurityElement(tag:  name);
            if(this.root == null)
            {
                goto label_1;
            }
            
            val_6 = this;
            if(this.stack != null)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            label_4:
            0.AddChild(child:  val_1);
            goto label_5;
            label_1:
            this.root = val_1;
            this.current = val_1;
            val_6 = this.stack;
            label_5:
            val_7 = mem[mem[this.stack] + 600];
            val_7 = mem[this.stack] + 600;
            this.current = val_1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 0;
            val_8 = attrs;
            if(attrs < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            do
            {
                val_6 = this.current;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_7 = 2;
                val_9 = attrs;
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_10 = 3;
                val_11 = attrs;
                val_6.AddAttribute(name:  attrs, value:  attrs);
                val_9 = val_9 + 1;
            }
            while(val_9 != attrs);
        
        }
        public void OnEndElement(string name)
        {
            System.Collections.Stack val_2 = this.stack;
            if(val_2 != null)
            {
                    if(null == null)
            {
                goto label_3;
            }
            
            }
            
            val_2 = 0;
            label_3:
            this.current = val_2;
        }
        public void OnChars(string ch)
        {
            this.current.Text = ch;
        }
        public void OnEndParsing(Mono.Xml.SmallXmlParser parser)
        {
        
        }
    
    }

}
