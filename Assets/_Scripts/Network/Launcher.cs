using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

namespace Network
{
    public class Launcher : MonoBehaviourPunCallbacks
    {
        #region Public Methods

        public void Connect()
        {

            PhotonNetwork.AutomaticallySyncScene = true;
            if (PhotonNetwork.IsConnected)
            {
                Debug.Log("<color=yellow>User already online. Connecting to a random room...</color>");
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                Debug.Log("<color=yellow>Connecting to master...</color>");
                PhotonNetwork.ConnectUsingSettings();
                PhotonNetwork.GameVersion = "0.0.1";
            }

        }

        #endregion

        #region Private Methods


        #endregion

        #region Photon Methods
        public override void OnConnectedToMaster()
        {
            Debug.Log("<color=yellow>Connected to master. Connecting to a random room...</color>");
            PhotonNetwork.JoinRandomRoom();
        }

        public override void OnJoinRandomFailed(short returnCode, string message)
        {
            Debug.Log("<color=yellow>Error on try join a random room. Creating one...</color>");
            PhotonNetwork.CreateRoom(null, new RoomOptions
            {
                MaxPlayers = 4,
                CleanupCacheOnLeave = true
            });
        }

        public override void OnCreatedRoom()
        {
            Debug.Log("<color=yellow>Connected to a room.</color>");
        }
        #endregion
    }

}

