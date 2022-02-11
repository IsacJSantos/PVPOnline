using TMPro;
using UnityEngine.UI;
using UnityEngine;
using BraveHunter.Utils;
using BraveHunter.Network;


namespace BraveHunter.Lobby
{
    public class LobbyManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _title;
        [SerializeField] TextMeshProUGUI _playerCount;
        [SerializeField] Image[] _playerSlots;


        private void Awake()
        {
            Events.OnPlayerEnteredRoom += OnPlayerEntered;
            Events.OnPlayerLeftRoom += OnPlayerLeft;
        }
        private void Start()
        {
            SetPlayersCount();
        }
        private void OnDestroy()
        {
            Events.OnPlayerEnteredRoom -= OnPlayerEntered;
            Events.OnPlayerLeftRoom -= OnPlayerLeft;
        }

 
        #region Private Methods

        void OnPlayerEntered(string nickName)
        {
            SetPlayersCount();
        }

        void OnPlayerLeft(string nickName)
        {
            SetPlayersCount();
        }

        void SetPlayersCount()
        {
            int totalPlayers = MatchmakingManager.Instance.GetTotalPlayers();
            _playerCount.text = $"{totalPlayers}/{GameData.MAX_PLAYERS_PER_ROOM}";

            if (totalPlayers >= GameData.MIN_PLAYERS_TO_PLAY)
                _playerCount.color = Color.green;
            else
                _playerCount.color = Color.white;

        }

        #endregion
    }
}

