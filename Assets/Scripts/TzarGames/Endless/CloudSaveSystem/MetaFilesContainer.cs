using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    [Serializable]
    internal class MetaFilesContainer
    {
        // Fields
        public TzarGames.Endless.CloudSaveSystem.SaveData[] Files;
        
        // Methods
        public MetaFilesContainer()
        {
        
        }
        public TzarGames.Endless.CloudSaveSystem.SaveData GetSaveData(string fileName)
        {
            var val_3;
            TzarGames.Endless.CloudSaveSystem.SaveData val_4;
            val_3 = 0;
            label_8:
            if(val_3 >= this.Files.Length)
            {
                goto label_2;
            }
            
            val_4 = this.Files[0];
            val_3 = val_3 + 1;
            if((System.String.op_Equality(a:  0, b:  this.Files[0x0][0].FileName)) == false)
            {
                goto label_8;
            }
            
            return (TzarGames.Endless.CloudSaveSystem.SaveData)val_4;
            label_2:
            val_4 = 0;
            return (TzarGames.Endless.CloudSaveSystem.SaveData)val_4;
        }
    
    }

}
