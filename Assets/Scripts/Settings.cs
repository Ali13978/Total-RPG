using UnityEngine;
private class ChatUI.Settings : ChatUI.ChatState
{
    // Methods
    public ChatUI.Settings()
    {
    
    }
    public override void OnStateBegin(StateMachine.State prevState)
    {
        prevState.OnStateBegin(prevState:  prevState);
        TzarGames.Endless.UI.Chat.ChatUI val_1 = this.UI;
        this.updateUserList();
    }
    public override void OnStateEnd(StateMachine.State nextState)
    {
        nextState.OnStateEnd(nextState:  nextState);
        TzarGames.Endless.UI.Chat.ChatUI val_1 = this.UI;
        if(val_1.settingsWindow == null)
        {
            
        }
    
    }
    private void updateUserList()
    {
        var val_5;
        var val_28;
        TzarGames.Endless.UI.Chat.ChatUI val_1 = this.UI;
        TzarGames.Common.Utils.DestroyAllChilds(transform:  0);
        TzarGames.Common.Utils.DestroyAllChilds(transform:  0);
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_3 = val_1.activeMessages.GetEnumerator();
        label_21:
        if((0 & 1) == 0)
        {
            goto label_5;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        val_28 = val_1.chatProvider;
        if(((System.String.op_Equality(a:  0, b:  X23)) == true) || ((Contains(item:  X23)) == true))
        {
            goto label_21;
        }
        
        Add(item:  val_5.InitializationCallback);
        goto label_21;
        label_5:
        val_5.Dispose();
        int val_13 = Count - 1;
        if((val_13 & 2147483648) == 0)
        {
                do
        {
            string val_14 = Item[val_13];
            if((val_1.blockedUsers.Contains(item:  val_14)) != true)
        {
                Unitycoding.UIWidgets.RadialMenuItem val_16 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            text = val_14;
            val_14.isOn = false;
            val_16.transform.SetParent(parent:  val_1.currentUsersContainer);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            val_16.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            val_16.add_OnTogglePressed(value:  new System.Action<TzarGames.Endless.UI.Chat.ChatUserEntryUI>(object:  this, method:  System.Void ChatUI.Settings::EntryInstance_OnTogglePressed(TzarGames.Endless.UI.Chat.ChatUserEntryUI obj)));
        }
        
            val_13 = val_13 - 1;
        }
        while((val_13 & 2147483648) == 0);
        
        }
        
        List.Enumerator<T> val_21 = val_1.blockedUsers.GetEnumerator();
        label_60:
        if((0 & 1) == 0)
        {
            goto label_63;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_22 = val_5.InitializationCallback;
        Unitycoding.UIWidgets.RadialMenuItem val_23 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
        val_16.text = val_22;
        val_22.isOn = true;
        val_23.transform.SetParent(parent:  val_1.blockedUserContainer);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
        val_23.transform.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        System.Action<TzarGames.Endless.UI.Chat.ChatUserEntryUI> val_27 = new System.Action<TzarGames.Endless.UI.Chat.ChatUserEntryUI>(object:  this, method:  System.Void ChatUI.Settings::EntryInstance_OnTogglePressed(TzarGames.Endless.UI.Chat.ChatUserEntryUI obj));
        val_23.add_OnTogglePressed(value:  null);
        goto label_60;
        label_63:
        val_5.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    private void EntryInstance_OnTogglePressed(TzarGames.Endless.UI.Chat.ChatUserEntryUI obj)
    {
        var val_23;
        string val_24;
        System.Collections.Generic.List<System.String> val_25;
        var val_26;
        val_23 = obj.toggle.isOn;
        TzarGames.Endless.UI.Chat.ChatUI val_2 = this.UI;
        val_24 = obj.userName.text;
        bool val_4 = val_2.blockedUsers.Contains(item:  val_24);
        if(val_23 != false)
        {
                if(val_4 == true)
        {
                return;
        }
        
            TzarGames.Endless.UI.Chat.ChatUI val_6 = this.UI;
            val_25 = val_6.blockedUsers;
            val_25.Add(item:  obj.userName.text);
        }
        else
        {
                if(val_4 == false)
        {
                return;
        }
        
            TzarGames.Endless.UI.Chat.ChatUI val_8 = this.UI;
            val_25 = val_8.blockedUsers;
            bool val_10 = val_25.Remove(item:  obj.userName.text);
        }
        
        if(0 != TzarGames.Endless.EndlessGameState.Instance)
        {
                TzarGames.Common.SerializableData val_14 = TzarGames.Endless.EndlessGameState.Instance.CommonSaveGameData;
            val_24 = "CHAT_DATA_KEY";
            if((val_14.GetString(id:  "CHAT_DATA_KEY")) != null)
        {
                val_26 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
        }
        else
        {
                object val_17 = null;
            val_26 = val_17;
            val_17 = new System.Object();
        }
        
            TzarGames.Endless.UI.Chat.ChatUI val_18 = this.UI;
            typeof(ChatUI.ChatData).__il2cppRuntimeField_10 = val_18.blockedUsers;
            val_25 = UnityEngine.JsonUtility.ToJson(obj:  0);
            val_14.SetString(id:  "CHAT_DATA_KEY", stringValue:  val_25);
            if(TzarGames.Endless.EndlessGameState.Instance.IsItSafeStateToSaveGame() != false)
        {
                TzarGames.Endless.EndlessGameState.Instance.SaveGame();
        }
        
        }
        
        this.updateUserList();
    }

}
