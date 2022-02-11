using Photon.Pun;
using UnityEngine;
using BraveHunter.Network;
public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] Transform[] _spawnPoints;
    [SerializeField] string _playerReference;

    private void Start()
    {
        SpawnPlayer();
    }

    #region Public Methods
    #endregion

    #region Private Methods
    void SpawnPlayer()
    {
        Vector3 pos = _spawnPoints[MatchmakingManager.Instance.PlayerUID].position;
        PhotonNetwork.Instantiate(_playerReference,pos,Quaternion.identity);
    }
    #endregion
}
