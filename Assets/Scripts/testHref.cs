using UnityEngine;
public class testHref : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Extensions.TextPic textPic;
    
    // Methods
    public testHref()
    {
    
    }
    private void Awake()
    {
        this.textPic = this.GetComponent<UnityEngine.UI.Extensions.TextPic>();
    }
    private void OnEnable()
    {
        this.textPic.onHrefClick.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void testHref::OnHrefClick(string hrefName)));
    }
    private void OnDisable()
    {
        this.textPic.onHrefClick.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void testHref::OnHrefClick(string hrefName)));
    }
    private void OnHrefClick(string hrefName)
    {
        string val_1 = 0 + "Click on the ";
        UnityEngine.Debug.Log(message:  0);
    }

}
