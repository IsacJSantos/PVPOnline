using UnityEngine.UI;
using UnityEngine;
using Photon.Pun;
using OnlyOneGameDev.Network;
using OnlyOneGameDev.Utils;

namespace OnlyOneGameDev.Lobby
{
    public class StartMatchButton : MonoBehaviour
    {
        [SerializeField] Canvas _cv;

        private void Awake()
        {
            if (PhotonNetwork.IsMasterClient)
                _cv.enabled = true;
            else
                _cv.enabled = false;

        }

        public void StartMatch()
        {
            if (!PhotonNetwork.IsMasterClient) return;

            if (MatchmakingManager.Instance.GetTotalPlayers() >= GameData.MIN_PLAYERS_TO_PLAY)
            {
                Debug.Log("<color=yellow>Starting match...</color>");
                PhotonNetwork.LoadLevel(3);
            }


        }
    }
}

