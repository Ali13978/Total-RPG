using UnityEngine;

namespace GooglePlayGames.BasicApi.SavedGame
{
    public interface ISavedGameClient
    {
        // Methods
        public abstract void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback); // 0
        public abstract void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback); // 0
        public abstract void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> completedCallback); // 0
        public abstract void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback); // 0
        public abstract void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback); // 0
        public abstract void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback); // 0
        public abstract void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata); // 0
    
    }

}
