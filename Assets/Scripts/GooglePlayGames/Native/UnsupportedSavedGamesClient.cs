using UnityEngine;

namespace GooglePlayGames.Native
{
    internal class UnsupportedSavedGamesClient : ISavedGameClient
    {
        // Fields
        private readonly string mMessage;
        
        // Methods
        public UnsupportedSavedGamesClient(string message)
        {
            this.mMessage = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        }
        public void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
        public void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
        public void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> completedCallback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
        public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
        public void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
        public void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
        public void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException(message:  this.mMessage);
        }
    
    }

}
