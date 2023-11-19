using UnityEngine;

namespace Mono.Xml
{
    internal class SmallXmlParserException : SystemException
    {
        // Fields
        private int line;
        private int column;
        
        // Properties
        public int Line { get; }
        public int Column { get; }
        
        // Methods
        public SmallXmlParserException(string msg, int line, int column)
        {
            string val_1 = System.String.Format(format:  0, arg0:  "{0}. At ({1},{2})", arg1:  msg, arg2:  line);
            this.line = line;
            this.column = column;
        }
        public int get_Line()
        {
            return (int)this.line;
        }
        public int get_Column()
        {
            return (int)this.column;
        }
    
    }

}
