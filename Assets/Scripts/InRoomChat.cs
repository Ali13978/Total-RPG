using UnityEngine;
[UnityEngine.RequireComponent]
public class InRoomChat : MonoBehaviour
{
    // Fields
    public UnityEngine.Rect GuiRect;
    public bool IsVisible;
    public bool AlignBottom;
    public System.Collections.Generic.List<string> messages;
    private string inputLine;
    private UnityEngine.Vector2 scrollPos;
    public static readonly string ChatRPC;
    
    // Methods
    public InRoomChat()
    {
        var val_3;
        this.GuiRect = 0;
        this.IsVisible = true;
        this.messages = new System.Collections.Generic.List<System.String>();
        val_3 = null;
        val_3 = null;
        this.inputLine = System.String.Empty;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.scrollPos = val_2;
        mem[1152921512468763932] = val_2.y;
    }
    public void Start()
    {
        if(this.AlignBottom == false)
        {
                return;
        }
        
        float val_2 = (float)UnityEngine.Screen.height - S0;
    }
    public void OnGUI()
    {
        string val_18;
        var val_19;
        UnityEngine.GUILayoutOption val_20;
        var val_21;
        var val_22;
        val_18 = this;
        if(this.IsVisible == false)
        {
                return;
        }
        
        if(PhotonNetwork.inRoom == false)
        {
                return;
        }
        
        if(UnityEngine.Event.current.type != 4)
        {
            goto label_10;
        }
        
        if(UnityEngine.Event.current.keyCode != 271)
        {
                if(UnityEngine.Event.current.keyCode != 13)
        {
            goto label_10;
        }
        
        }
        
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_13;
        }
        
        UnityEngine.GUI.FocusControl(name:  0);
        label_10:
        val_19 = null;
        val_19 = null;
        UnityEngine.GUI.SetNextControlName(name:  0);
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.GuiRect});
        UnityEngine.Vector2 val_10 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.scrollPos, y = V9.16B}, options:  0);
        this.scrollPos = val_10;
        mem[1152921512469057740] = val_10.y;
        UnityEngine.GUILayout.FlexibleSpace();
        System.Collections.Generic.List<System.String> val_18 = this.messages;
        val_18 = val_18.Count - 1;
        if((val_18 & 2147483648) == 0)
        {
                do
        {
            UnityEngine.GUILayout.Label(text:  0, options:  this.messages.Item[val_18]);
            val_18 = val_18 - 1;
        }
        while((val_18 & 2147483648) == 0);
        
        }
        
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.BeginHorizontal(options:  0);
        UnityEngine.GUI.SetNextControlName(name:  0);
        this.inputLine = UnityEngine.GUILayout.TextField(text:  0, options:  this.inputLine);
        val_20 = UnityEngine.GUILayout.ExpandWidth(expand:  false);
        typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = val_20;
        if((UnityEngine.GUILayout.Button(text:  0, options:  "Send")) != false)
        {
                val_20 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.inputLine;
            this.photonView.RPC(methodName:  "Chat", target:  0, parameters:  val_20);
            val_21 = null;
            val_21 = null;
            this.inputLine = System.String.Empty;
            val_18 = System.String.Empty;
            UnityEngine.GUI.FocusControl(name:  0);
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndArea();
        return;
        label_13:
        typeof(System.Object[]).__il2cppRuntimeField_20 = this.inputLine;
        this.photonView.RPC(methodName:  "Chat", target:  0, parameters:  null);
        val_22 = null;
        val_22 = null;
        this.inputLine = System.String.Empty;
        UnityEngine.GUI.FocusControl(name:  0);
    }
    [TzarRPC]
    public void Chat(string newLine, PhotonMessageInfo mi)
    {
        string val_9;
        if(mi.sender == null)
        {
            goto label_1;
        }
        
        string val_1 = mi.sender.NickName;
        if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_5;
        }
        
        int val_4 = mi.sender.ID;
        string val_5 = 0 + "player ";
        goto label_8;
        label_1:
        val_9 = "anonymous";
        goto label_9;
        label_5:
        label_8:
        val_9 = mi.sender.NickName;
        label_9:
        this.messages.Add(item:  0 + val_9 + ": "(": "));
    }
    public void AddLine(string newLine)
    {
        this.messages.Add(item:  newLine);
    }
    private static InRoomChat()
    {
        InRoomChat.ChatRPC = "Chat";
    }

}
