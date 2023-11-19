using UnityEngine;
public class testFBX : MonoBehaviour
{
    // Fields
    public string filePath;
    
    // Methods
    public testFBX()
    {
    
    }
    private void Start()
    {
        this.LoadAttribute(attributeName:  "Connections");
    }
    private void Update()
    {
    
    }
    private void LoadAttribute(string attributeName)
    {
        string val_9;
        var val_10;
        string val_2 = 0 + attributeName;
        System.Text.RegularExpressions.Match val_3 = System.Text.RegularExpressions.Regex.Match(input:  0, pattern:  System.IO.File.ReadAllText(path:  0));
        int val_4 = val_3.Length;
        UnityEngine.Debug.Log(message:  0);
        string val_5 = val_3.Value;
        UnityEngine.Debug.Log(message:  0);
        int val_9 = System.IO.File.ReadAllText(path:  0).IndexOf(value:  "Objects:");
        UnityEngine.Debug.Log(message:  0);
        val_9 = this.filePath;
        null = new System.IO.StreamReader(path:  val_9);
        if(val_9 > 0)
        {
                do
        {
            val_9 = mem[null + 400 + 8];
            val_9 = val_9 - 1;
        }
        while(val_9 != 0);
        
        }
        
        var val_10 = 0;
        do
        {
            val_10 = val_10 + 1;
        }
        while(4096 != 123);
        
        val_10 = 1;
        goto label_19;
        label_18:
        val_10 = 2;
        label_19:
        val_10 = val_10 + 1;
        if(4096 == 125)
        {
            goto label_16;
        }
        
        if(4096 != 123)
        {
            goto label_19;
        }
        
        goto label_18;
        label_16:
        val_10 = val_10 - 1;
        if(val_10 != 0)
        {
            goto label_19;
        }
        
        UnityEngine.Debug.Log(message:  0);
    }

}
