using UnityEngine;
public class ChatController : MonoBehaviour
{
    // Fields
    public TMPro.TMP_InputField TMP_ChatInput;
    public TMPro.TMP_Text TMP_ChatOutput;
    public UnityEngine.UI.Scrollbar ChatScrollbar;
    
    // Methods
    public ChatController()
    {
    
    }
    private void OnEnable()
    {
        this.TMP_ChatInput.onSubmit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void ChatController::AddToChatOutput(string newText)));
    }
    private void OnDisable()
    {
        this.TMP_ChatInput.onSubmit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void ChatController::AddToChatOutput(string newText)));
    }
    private void AddToChatOutput(string newText)
    {
        null = null;
        this.TMP_ChatInput.text = System.String.Empty;
        System.DateTime val_1 = System.DateTime.Now;
        typeof(System.String[]).__il2cppRuntimeField_20 = this.TMP_ChatOutput.text;
        typeof(System.String[]).__il2cppRuntimeField_28 = "[<#FFFF80>";
        typeof(System.String[]).__il2cppRuntimeField_30 = val_1.ticks._ticks.ToString(format:  "d2");
        typeof(System.String[]).__il2cppRuntimeField_38 = ":";
        typeof(System.String[]).__il2cppRuntimeField_40 = val_1.ticks._ticks.ToString(format:  "d2");
        typeof(System.String[]).__il2cppRuntimeField_48 = ":";
        typeof(System.String[]).__il2cppRuntimeField_50 = val_1.ticks._ticks.Second.ToString(format:  "d2");
        typeof(System.String[]).__il2cppRuntimeField_58 = "</color>] ";
        typeof(System.String[]).__il2cppRuntimeField_60 = newText;
        typeof(System.String[]).__il2cppRuntimeField_68 = "\n";
        this.TMP_ChatOutput.text = +0;
        this.TMP_ChatInput.ActivateInputField();
        this.ChatScrollbar.value = 0f;
    }

}
