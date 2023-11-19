using UnityEngine;
public class QuitOnEscapeOrBack : MonoBehaviour
{
    // Methods
    public QuitOnEscapeOrBack()
    {
    
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
        {
                return;
        }
        
        UnityEngine.Application.Quit();
    }

}
