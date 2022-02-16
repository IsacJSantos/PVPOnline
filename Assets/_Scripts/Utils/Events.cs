using UnityEngine;

namespace BraveHunter.Utils
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

        #region Inventory
        public static ItemDataGameObjectEvent OnItemView;
        public static ItemDataGameObjectEvent OnItemOutOfView;

        public static ItemDataGameObjectEvent OnItemCollect;

        public static ItemDataGameObjectEvent OnConfirmItemCollect;
        #endregion



        public delegate void SimpleEvent();
        public delegate void IntEvent(int i);
        public delegate void StringEvent(string s);

        public delegate void ItemDataEvent(ItemData td);
        public delegate void ItemDataGameObjectEvent(ItemData td, GameObject go);
    }
}

