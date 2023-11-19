using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class EndlessSaveData
    {
        // Fields
        private const int actual_version = 0;
        [UnityEngine.SerializeField]
        private int version;
        [UnityEngine.SerializeField]
        private string appVersion;
        [UnityEngine.SerializeField]
        private string deviceID;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Endless.EndlessCharacterData> characters;
        [UnityEngine.SerializeField]
        private int selectedCharacterNumber;
        [UnityEngine.SerializeField]
        private TzarGames.Common.SerializableData data;
        [UnityEngine.SerializeField]
        private double _gameTimeInSeconds;
        public bool IsTutorialCompleted;
        public bool OldTutorialCompletedFlagInitialized;
        public bool IsGamePurchased;
        
        // Properties
        public string AppVersion { get; set; }
        public string DeviceID { get; set; }
        public int Version { get; set; }
        public TzarGames.Common.SerializableData Data { get; }
        public double GameTimeInSeconds { get; set; }
        public TzarGames.Endless.EndlessCharacterData[] Characters { get; }
        public TzarGames.Endless.EndlessCharacterData SelectedCharacter { get; }
        public int CharacterCount { get; }
        public int SelectedCharacterNumber { get; set; }
        
        // Methods
        public EndlessSaveData()
        {
            this.characters = new System.Collections.Generic.List<TzarGames.Endless.EndlessCharacterData>();
            this.version = 0;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            this.appVersion = TzarGames.Endless.EndlessGameState.Instance.Version;
        }
        public string get_AppVersion()
        {
            return (string)this.appVersion;
        }
        public void set_AppVersion(string value)
        {
            this.appVersion = value;
        }
        public string get_DeviceID()
        {
            return (string)this.deviceID;
        }
        public void set_DeviceID(string value)
        {
            this.deviceID = value;
        }
        public int get_Version()
        {
            return (int)this.version;
        }
        public void set_Version(int value)
        {
            this.version = value;
        }
        public TzarGames.Common.SerializableData get_Data()
        {
            TzarGames.Common.SerializableData val_2 = this.data;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            TzarGames.Common.SerializableData val_1 = null;
            val_2 = val_1;
            val_1 = new TzarGames.Common.SerializableData();
            this.data = val_2;
            return val_2;
        }
        public double get_GameTimeInSeconds()
        {
            return (double)this._gameTimeInSeconds;
        }
        public void set_GameTimeInSeconds(double value)
        {
            this._gameTimeInSeconds = value;
        }
        public TzarGames.Endless.EndlessCharacterData[] get_Characters()
        {
            if(this.characters != null)
            {
                    return this.characters.ToArray();
            }
            
            return this.characters.ToArray();
        }
        public TzarGames.Endless.EndlessCharacterData get_SelectedCharacter()
        {
            int val_3;
            var val_4;
            val_3 = this;
            if(this.selectedCharacterNumber < this.characters.Count)
            {
                    val_3 = this.selectedCharacterNumber;
                TzarGames.Endless.EndlessCharacterData val_2 = this.characters.Item[val_3];
                return (TzarGames.Endless.EndlessCharacterData)val_4;
            }
            
            val_4 = 0;
            return (TzarGames.Endless.EndlessCharacterData)val_4;
        }
        public int get_CharacterCount()
        {
            if(this.characters != null)
            {
                    return this.characters.Count;
            }
            
            return this.characters.Count;
        }
        public int get_SelectedCharacterNumber()
        {
            return (int)this.selectedCharacterNumber;
        }
        public void set_SelectedCharacterNumber(int value)
        {
            this.selectedCharacterNumber = value;
        }
        public int GetNumberOfCharacter(TzarGames.Endless.ICharacterInfo characterInfo)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            if((this.characters.Contains(item:  null)) == false)
            {
                goto label_8;
            }
            
            val_6 = 0;
            goto label_6;
            label_10:
            val_6 = 1;
            label_6:
            if(val_6 >= this.characters.Count)
            {
                goto label_8;
            }
            
            if(this.characters.Item[1] != characterInfo)
            {
                goto label_10;
            }
            
            return (int)val_6;
            label_8:
            val_6 = 0;
            return (int)val_6;
        }
        public void RemoveCharacterAt(int number)
        {
            if(this.characters.Count > number)
            {
                    this.characters.RemoveAt(index:  number);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public int AddCharacter(TzarGames.Endless.EndlessCharacterData characterData)
        {
            this.characters.Add(item:  characterData);
            int val_1 = this.characters.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
