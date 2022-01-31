using Photon.Realtime;
using Photon.Pun;
using UnityEngine;
using OnlyOneGameDev.Utils;
using ExitGames.Client.Photon;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace OnlyOneGameDev.Network
{
    public class MatchmakingManager : Singleton<MatchmakingManager>, IInRoomCallbacks, IMatchmakingCallbacks
    {
        public int PlayerUID;

        protected override void Awake()
        {
            base.Awake();

            Events.OnStartMatch += StartMatch;

            DontDestroyOnLoad(gameObject);
            PhotonNetwork.AddCallbackTarget(this);
        }

        private void OnDestroy()
        {
            Events.OnStartMatch -= StartMatch;
        }

        #region Public Methods
        public void StartMatch()
        {
            PhotonNetwork.CurrentRoom.IsOpen = false;
            PhotonNetwork.LoadLevel(GameData.GAMEPLAY_SCENE);
        }

        public void LeftMatch()
        {
            PhotonNetwork.Disconnect();
            SceneManager.LoadScene(GameData.MENU_SCENE);
        }
        public int GetTotalPlayers()
        {
            return PhotonNetwork.CurrentRoom.PlayerCount;
        }
        public int GetLocalPlayerNumber()
        {
            return PhotonNetwork.LocalPlayer.ActorNumber;
        }

        #endregion

        #region Private Methods
        void SetPlayerUID()
        {
            PlayerUID = PhotonNetwork.CurrentRoom.PlayerCount - 1;
            Debug.Log($"<color=green>Player {PlayerUID}.</color>");
        }
        #endregion



        #region Photon Methods
        public void OnMasterClientSwitched(Player newMasterClient)
        {
            Debug.Log($"<color=yellow>OnMasterClientSwitched</color>");
        }

        public void OnPlayerEnteredRoom(Player newPlayer)
        {
            Debug.Log($"<color=green>{newPlayer.NickName} joined in this room. Player number: {newPlayer.ActorNumber}</color>");
            Events.OnPlayerEnteredRoom?.Invoke(newPlayer.NickName);
            Events.OnPlayerNumberEnteredRoom?.Invoke(newPlayer.ActorNumber);
        }

        public void OnPlayerLeftRoom(Player otherPlayer)
        {
            Debug.Log($"<color=green>{otherPlayer.NickName} left this room. Player number: {otherPlayer.ActorNumber}</color>");
            Events.OnPlayerLeftRoom?.Invoke(otherPlayer.NickName);
            Events.OnPlayerNumberLeftRoom?.Invoke(otherPlayer.ActorNumber);
        }

        public void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
        {
            Debug.Log($"<color=yellow>OnPlayerPropertiesUpdate</color>");
        }

        public void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
        {
            Debug.Log($"<color=yellow>OnRoomPropertiesUpdate</color>");
        }


        public void OnFriendListUpdate(List<FriendInfo> friendList)
        {

        }

        public void OnCreatedRoom()
        {

        }

        public void OnCreateRoomFailed(short returnCode, string message)
        {

        }

        public void OnJoinedRoom()
        {
            Debug.Log($"<color=yellow>(Matchmaking) OnJoinedRoom</color>");
            SetPlayerUID();
        }

        public void OnJoinRoomFailed(short returnCode, string message)
        {

        }

        public void OnJoinRandomFailed(short returnCode, string message)
        {

        }

        public void OnLeftRoom()
        {

        }

        #endregion

    }
}

