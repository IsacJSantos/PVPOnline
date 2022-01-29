using Photon.Realtime;
using Photon.Pun;
using UnityEngine;
using OnlyOneGameDev.Utils;
using ExitGames.Client.Photon;

namespace OnlyOneGameDev.Network
{
    public class MatchmakingManager : Singleton<MatchmakingManager>, IInRoomCallbacks
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            PhotonNetwork.AddCallbackTarget(this);
        }

        public int GetTotalPlayers()
        {
            return PhotonNetwork.CurrentRoom.PlayerCount;
        }
        public int GetLocalPlayerNumber()
        {
            return PhotonNetwork.LocalPlayer.ActorNumber;
        }
        #region Photon Methods
        public void OnMasterClientSwitched(Player newMasterClient)
        {
            Debug.Log($"<color=yellow>OnMasterClientSwitched</color>");
        }

        public void OnPlayerEnteredRoom(Player newPlayer)
        {
            Debug.Log($"<color=green>{newPlayer.NickName} joined in this room</color>");
            Events.OnPlayerEnteredRoom?.Invoke(newPlayer.NickName);
            Events.OnPlayerNumberEnteredRoom?.Invoke(newPlayer.ActorNumber);
        }

        public void OnPlayerLeftRoom(Player otherPlayer)
        {
            Debug.Log($"<color=green>{otherPlayer.NickName} left this room</color>");
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
        #endregion

    }
}

