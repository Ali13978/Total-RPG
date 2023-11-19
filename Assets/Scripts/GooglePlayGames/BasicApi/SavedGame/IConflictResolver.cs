using UnityEngine;

namespace GooglePlayGames.BasicApi.SavedGame
{
    public interface IConflictResolver
    {
        // Methods
        public abstract void ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata); // 0
        public abstract void ResolveConflict(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData); // 0
    
    }

}
