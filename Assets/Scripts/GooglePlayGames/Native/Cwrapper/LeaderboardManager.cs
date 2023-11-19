using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class LeaderboardManager
    {
        // Methods
        internal static extern void LeaderboardManager_FetchAll(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchAllCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_FetchScoreSummary(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string leaderboard_id, GooglePlayGames.Native.Cwrapper.Types.LeaderboardTimeSpan time_span, GooglePlayGames.Native.Cwrapper.Types.LeaderboardCollection collection, GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScoreSummaryCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern IntPtr LeaderboardManager_ScorePageToken(System.Runtime.InteropServices.HandleRef self, string leaderboard_id, GooglePlayGames.Native.Cwrapper.Types.LeaderboardStart start, GooglePlayGames.Native.Cwrapper.Types.LeaderboardTimeSpan time_span, GooglePlayGames.Native.Cwrapper.Types.LeaderboardCollection collection)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)leaderboard_id;
            }
        
        }
        internal static extern void LeaderboardManager_ShowAllUI(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowAllUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_FetchScorePage(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, IntPtr token, uint max_results, GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchScorePageCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_FetchAllScoreSummaries(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string leaderboard_id, GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchAllScoreSummariesCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_ShowUI(System.Runtime.InteropServices.HandleRef self, string leaderboard_id, GooglePlayGames.Native.Cwrapper.Types.LeaderboardTimeSpan time_span, GooglePlayGames.Native.Cwrapper.LeaderboardManager.ShowUICallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_Fetch(System.Runtime.InteropServices.HandleRef self, GooglePlayGames.Native.Cwrapper.Types.DataSource data_source, string leaderboard_id, GooglePlayGames.Native.Cwrapper.LeaderboardManager.FetchCallback callback, IntPtr callback_arg)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_SubmitScore(System.Runtime.InteropServices.HandleRef self, string leaderboard_id, ulong score, string metadata)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern void LeaderboardManager_FetchResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus LeaderboardManager_FetchResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr LeaderboardManager_FetchResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void LeaderboardManager_FetchAllResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus LeaderboardManager_FetchAllResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr LeaderboardManager_FetchAllResponse_GetData_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr LeaderboardManager_FetchAllResponse_GetData_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern void LeaderboardManager_FetchScorePageResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus LeaderboardManager_FetchScorePageResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr LeaderboardManager_FetchScorePageResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void LeaderboardManager_FetchScoreSummaryResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus LeaderboardManager_FetchScoreSummaryResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern IntPtr LeaderboardManager_FetchScoreSummaryResponse_GetData(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern void LeaderboardManager_FetchAllScoreSummariesResponse_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus LeaderboardManager_FetchAllScoreSummariesResponse_GetStatus(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ResponseStatus)X2;
            }
        
        }
        internal static extern UIntPtr LeaderboardManager_FetchAllScoreSummariesResponse_GetData_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr LeaderboardManager_FetchAllScoreSummariesResponse_GetData_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
    
    }

}
