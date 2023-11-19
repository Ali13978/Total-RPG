using UnityEngine;

namespace GooglePlayGames.Native.Cwrapper
{
    internal static class ScorePage
    {
        // Methods
        internal static extern void ScorePage_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.LeaderboardTimeSpan ScorePage_TimeSpan(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (LeaderboardTimeSpan)X2;
            }
        
        }
        internal static extern UIntPtr ScorePage_LeaderboardId(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.LeaderboardCollection ScorePage_Collection(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (LeaderboardCollection)X2;
            }
        
        }
        internal static extern GooglePlayGames.Native.Cwrapper.Types.LeaderboardStart ScorePage_Start(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (LeaderboardStart)X2;
            }
        
        }
        internal static extern bool ScorePage_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool ScorePage_HasPreviousScorePage(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern bool ScorePage_HasNextScorePage(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern IntPtr ScorePage_PreviousScorePageToken(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern IntPtr ScorePage_NextScorePageToken(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern UIntPtr ScorePage_Entries_Length(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (UIntPtr)X2;
            }
        
        }
        internal static extern IntPtr ScorePage_Entries_GetElement(System.Runtime.InteropServices.HandleRef self, UIntPtr index)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)index;
            }
        
        }
        internal static extern void ScorePage_Entry_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
        internal static extern UIntPtr ScorePage_Entry_PlayerId(System.Runtime.InteropServices.HandleRef self, [In] [Out] byte[] out_arg, UIntPtr out_size)
        {
            if(25808612 != 0)
            {
                    var val_2 = (out_size == 0) ? 0 : (out_size + 32);
                return (UIntPtr)out_arg;
            }
        
        }
        internal static extern ulong ScorePage_Entry_LastModified(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern IntPtr ScorePage_Entry_Score(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (IntPtr)X2;
            }
        
        }
        internal static extern bool ScorePage_Entry_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern ulong ScorePage_Entry_LastModifiedTime(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (ulong)X2;
            }
        
        }
        internal static extern bool ScorePage_ScorePageToken_Valid(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return (bool)(X2 != 255) ? 1 : 0;
            }
        
        }
        internal static extern void ScorePage_ScorePageToken_Dispose(System.Runtime.InteropServices.HandleRef self)
        {
            if(25808612 != 0)
            {
                    return;
            }
        
        }
    
    }

}
