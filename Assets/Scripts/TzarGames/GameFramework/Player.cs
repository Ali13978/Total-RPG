using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Player
    {
        // Fields
        private static System.Collections.Generic.List<TzarGames.GameFramework.Player> allPlayers;
        private static System.Collections.Generic.Dictionary<string, TzarGames.GameFramework.Player> loginToPlayerMapping;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<TzarGames.GameFramework.Player> OnLoginChanged;
        public UnityEngine.GameObject PlayerObject;
        public TzarGames.GameFramework.NetworkPlayer NetworkPlayer;
        public int SessionID;
        public System.Collections.Generic.List<TzarGames.GameFramework.Player> NeighbourPlayers;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Login>k__BackingField;
        public TzarGames.GameFramework.IPlayerComponent PlayerComponent;
        public bool DisconnectingFlag;
        
        // Properties
        public static System.Collections.Generic.List<TzarGames.GameFramework.Player> Players { get; }
        public bool itsMe { get; }
        public string Login { get; set; }
        public bool IsConnected { get; }
        
        // Methods
        private Player(string login)
        {
            this.NeighbourPlayers = new System.Collections.Generic.List<TzarGames.GameFramework.Player>();
            this.<Login>k__BackingField = login;
        }
        public static void add_OnLoginChanged(System.Action<TzarGames.GameFramework.Player> value)
        {
            var val_3;
            System.Action<TzarGames.GameFramework.Player> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.GameFramework.Player.OnLoginChanged;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = TzarGames.GameFramework.Player.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504908820496 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_OnLoginChanged(System.Action<TzarGames.GameFramework.Player> value)
        {
            var val_3;
            System.Action<TzarGames.GameFramework.Player> val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.GameFramework.Player.OnLoginChanged;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = TzarGames.GameFramework.Player.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504908820496 != val_4)
            {
                goto label_8;
            }
        
        }
        public static TzarGames.GameFramework.Player GetPlayerByLogin(string login)
        {
            var val_4;
            TzarGames.GameFramework.Player val_1 = 0;
            val_4 = null;
            val_4 = null;
            return (TzarGames.GameFramework.Player)((TzarGames.GameFramework.Player.loginToPlayerMapping.TryGetValue(key:  X1, value: out  val_1)) != true) ? (val_1) : 0;
        }
        public static System.Collections.Generic.List<TzarGames.GameFramework.Player> get_Players()
        {
            null = null;
            return (System.Collections.Generic.List<TzarGames.GameFramework.Player>)TzarGames.GameFramework.Player.allPlayers;
        }
        public static TzarGames.GameFramework.Player Create(string login)
        {
            string val_4;
            var val_5;
            TzarGames.GameFramework.Player val_6;
            var val_7;
            val_4 = X1;
            val_5 = null;
            val_5 = null;
            if((TzarGames.GameFramework.Player.loginToPlayerMapping.ContainsKey(key:  val_4)) != false)
            {
                    val_6 = 0;
                return val_6;
            }
            
            TzarGames.GameFramework.Player val_3 = null;
            val_6 = val_3;
            val_3 = new TzarGames.GameFramework.Player(login:  val_4);
            val_7 = null;
            val_7 = null;
            TzarGames.GameFramework.Player.loginToPlayerMapping.Add(key:  val_4, value:  val_6);
            val_4 = TzarGames.GameFramework.Player.allPlayers;
            val_4.Add(item:  val_6);
            return val_6;
        }
        public static void RemoveAll()
        {
            int val_5 = TzarGames.GameFramework.Player.Players.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                TzarGames.GameFramework.Player.Remove(player:  TzarGames.GameFramework.Player.Players.Item[val_5]);
                val_5 = val_5 - 1;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        public static void Remove(TzarGames.GameFramework.Player player)
        {
            null = null;
            bool val_1 = TzarGames.GameFramework.Player.allPlayers.Remove(item:  X1);
            bool val_2 = TzarGames.GameFramework.Player.loginToPlayerMapping.Remove(key:  X1 + 48);
        }
        public static void ChangeLogin(TzarGames.GameFramework.Player player, string newLogin)
        {
            var val_5;
            System.Collections.Generic.Dictionary<System.String, TzarGames.GameFramework.Player> val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = TzarGames.GameFramework.Player.loginToPlayerMapping;
            if((val_6.ContainsKey(key:  X22)) == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = TzarGames.GameFramework.Player.loginToPlayerMapping;
            if((val_6.ContainsKey(key:  X2)) == true)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            bool val_4 = TzarGames.GameFramework.Player.loginToPlayerMapping.Remove(key:  X22);
            val_6 = TzarGames.GameFramework.Player.loginToPlayerMapping;
            val_6.Add(key:  X2, value:  newLogin);
            mem2[0] = X2;
            if(TzarGames.GameFramework.Player.OnLoginChanged == null)
            {
                    return;
            }
            
            0.Invoke(obj:  newLogin);
        }
        public bool get_itsMe()
        {
            if(this.NetworkPlayer == null)
            {
                    return true;
            }
            
            goto typeof(TzarGames.GameFramework.NetworkPlayer).__il2cppRuntimeField_160;
        }
        public string get_Login()
        {
            return (string)this.<Login>k__BackingField;
        }
        private void set_Login(string value)
        {
            this.<Login>k__BackingField = value;
        }
        public bool get_IsConnected()
        {
            if(this.NetworkPlayer == null)
            {
                    return false;
            }
            
            goto typeof(TzarGames.GameFramework.NetworkPlayer).__il2cppRuntimeField_170;
        }
        private static Player()
        {
            TzarGames.GameFramework.Player.allPlayers = new System.Collections.Generic.List<TzarGames.GameFramework.Player>();
            TzarGames.GameFramework.Player.loginToPlayerMapping = new System.Collections.Generic.Dictionary<System.String, TzarGames.GameFramework.Player>();
        }
    
    }

}
