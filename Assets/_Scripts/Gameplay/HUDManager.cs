using OnlyOneGameDev.Network;
using UnityEngine;

namespace OnlyOneGameDev.Gameplay
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

