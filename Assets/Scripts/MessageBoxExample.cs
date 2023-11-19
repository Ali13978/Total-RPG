using UnityEngine;
public class MessageBoxExample : MonoBehaviour
{
    // Fields
    public string title;
    public string message;
    public UnityEngine.Sprite icon;
    public string[] options;
    private Unitycoding.UIWidgets.MessageBox messageBox;
    private Unitycoding.UIWidgets.MessageBox verticalMessageBox;
    
    // Methods
    public MessageBoxExample()
    {
    
    }
    private void Start()
    {
        this.messageBox = Unitycoding.UIWidgets.UIUtility.Find<Unitycoding.UIWidgets.Tooltip>(name:  0);
        this.verticalMessageBox = Unitycoding.UIWidgets.UIUtility.Find<Unitycoding.UIWidgets.Tooltip>(name:  0);
    }
    public void Show()
    {
        if(this.messageBox == null)
        {
            
        }
    
    }
    public void ShowWithCallback()
    {
        UnityEngine.Events.UnityAction<System.String> val_1 = new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void MessageBoxExample::OnMessageBoxResult(string result));
        if(this.messageBox == null)
        {
            
        }
    
    }
    private void OnMessageBoxResult(string result)
    {
        string val_1 = 0 + "Click result: "("Click result: ");
        typeof(System.String[]).__il2cppRuntimeField_20 = "OK";
        if(this.messageBox == null)
        {
            
        }
    
    }
    public void ShowVerticalMessageBox()
    {
        if(this.verticalMessageBox == null)
        {
            
        }
    
    }

}
