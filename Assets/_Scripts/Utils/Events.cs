namespace OnlyOneGameDev.Utils
{
    public class Events
    {
        #region MatchmakingManager
        public static StringEvent OnPlayerEnteredRoom;
        public static StringEvent OnPlayerLeftRoom;

        public static IntEvent OnPlayerNumberEnteredRoom;
        public static IntEvent OnPlayerNumberLeftRoom;
        #endregion

        #region Lobby
        public static SimpleEvent OnStartMatch;
        #endregion



        public delegate void SimpleEvent();
        public delegate void IntEvent(int i);
        public delegate void StringEvent(string s);
    }
}

