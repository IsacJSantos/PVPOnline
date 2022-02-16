using BraveHunter.Network;
using UnityEngine;

namespace BraveHunter.Gameplay
{
    public class HUDManager : MonoBehaviour
    {

        #region Public Methods
        public void LeftMatch()
        {
            MatchmakingManager.Instance.LeftMatch();
        }
        #endregion
    }
}

