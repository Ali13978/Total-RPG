using UnityEngine;
public class MessageContainerExample : MonoBehaviour
{
    // Fields
    private Unitycoding.UIWidgets.MessageContainer messageContainer;
    public Unitycoding.UIWidgets.MessageOptions[] options;
    
    // Methods
    public MessageContainerExample()
    {
    
    }
    private void Start()
    {
        this.messageContainer = Unitycoding.UIWidgets.UIUtility.Find<Unitycoding.UIWidgets.Tooltip>(name:  0);
    }
    public void AddMessage()
    {
        Unitycoding.UIWidgets.MessageOptions val_2 = this.options[(long)UnityEngine.Random.Range(min:  0, max:  0)];
        if(this.messageContainer == null)
        {
            
        }
    
    }
    public void AddMessage(UnityEngine.UI.InputField input)
    {
        string val_1 = input.text;
        if(this.messageContainer == null)
        {
            
        }
    
    }
    public void AddMessage(float index)
    {
        Unitycoding.UIWidgets.MessageOptions val_2 = this.options[(long)UnityEngine.Mathf.RoundToInt(f:  index)];
        if(this.messageContainer == null)
        {
            
        }
    
    }

}
