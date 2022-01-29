using TMPro;
using UnityEngine.UI;
using UnityEngine;
using OnlyOneGameDev.Utils;
using OnlyOneGameDev.Network;
using Photon.Pun;

namespace OnlyOneGameDev.Lobby
{
    public class LobbyManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _title;
        [SerializeField] TextMeshProUGUI _playerCount;
        [SerializeField] Image[] _playerSlots;


        private void Awake()
        {
            Events.OnPlayerNumberEnteredRoom += OnPlayerEntered;
            Events.OnPlayerNumberLeftRoom += OnPlayerLeft;
        }
        private void Start()
        {


            SetPlayersSlot();
        }
        private void OnDestroy()
        {
            Events.OnPlayerNumberEnteredRoom -= OnPlayerEntered;
            Events.OnPlayerNumberLeftRoom -= OnPlayerLeft;
        }

        #region Private Methods
        void OnPlayerEntered(int number)
        {
            int index = number - 1;
            if (index < 0 || index >= _playerSlots.Length) return;

            _playerSlots[index].color = Color.green;
        }

        void OnPlayerLeft(int number)
        {
            int index = number - 1;
            if (index < 0 || index >= _playerSlots.Length) return;

            _playerSlots[index].color = Color.white;
        }

        void SetPlayersSlot()
        {
            for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
            {
                if (i >= 0 || i < _playerSlots.Length)
                {
                    _playerSlots[i].color = Color.green;
                }
            }
        }
        #endregion
    }
}

