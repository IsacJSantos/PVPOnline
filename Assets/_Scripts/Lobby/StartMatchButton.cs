using UnityEngine.UI;
using UnityEngine;
using Photon.Pun;
using BraveHunter.Utils;

namespace BraveHunter.Lobby
{
    public class StartMatchButton : MonoBehaviour
    {
        [SerializeField] Canvas _cv;
        [SerializeField] Button _startMatchButotn;

        private void Awake()
        {
            Events.OnPlayerEnteredRoom += OnPlayerEnter;
            Events.OnPlayerLeftRoom += OnPlayerExit;

            if (PhotonNetwork.IsMasterClient)
                _cv.enabled = true;
            else
                _cv.enabled = false;

            SetButtonInteractable();
        }

        private void OnDestroy()
        {
            Events.OnPlayerEnteredRoom -= OnPlayerEnter;
            Events.OnPlayerLeftRoom -= OnPlayerExit;
        }

        #region Public Methods

        public void StartMatch()
        {
            if (!PhotonNetwork.IsMasterClient) return;

            if (PhotonNetwork.CurrentRoom.PlayerCount >= GameData.MIN_PLAYERS_TO_PLAY)
            {
                Debug.Log("<color=yellow>Starting match...</color>");
                Events.OnStartMatch?.Invoke();
            }

        }

        #endregion

        #region Private Methods

        void OnPlayerEnter(string nickName)
        {
            SetButtonInteractable();
        }
        void OnPlayerExit(string nickName)
        {
            SetButtonInteractable();
        }

        void SetButtonInteractable()
        {
            if (!PhotonNetwork.IsMasterClient) return;

            _startMatchButotn.interactable = PhotonNetwork.CurrentRoom.PlayerCount >= GameData.MIN_PLAYERS_TO_PLAY;
        }
        #endregion
    }
}

