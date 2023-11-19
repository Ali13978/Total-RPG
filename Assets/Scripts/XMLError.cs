using UnityEngine;
public class MiniParser.XMLError : Exception
{
    // Fields
    protected string descr;
    protected int line;
    protected int column;
    
    // Properties
    public int Line { get; }
    public int Column { get; }
    
    // Methods
    public MiniParser.XMLError()
    {
        this.descr = "Unknown";
        this.line = 0;
        this.column = 0;
    }
    public MiniParser.XMLError(string descr)
    {
        this.descr = descr;
        this.line = 0;
        this.column = 0;
    }
    public MiniParser.XMLError(string descr, int line, int column)
    {
        this.descr = descr;
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
    public override string ToString()
    {
        return (string)System.String.Format(format:  0, arg0:  "{0} @ (line = {1}, col = {2})", arg1:  this.descr, arg2:  this.line);
    }

}
