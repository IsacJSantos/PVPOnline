using BraveHunter.Utils;
using UnityEngine;

namespace BraveHunter.Gameplay
{
    public class DoorSystem : MonoBehaviour, IInteractable
    {
        [SerializeField] Animation _anim;

        bool _isOpen;

        #region Public Methods
        public void Interact()
        {
            ToggleDoor();
        }
        #endregion

        #region Private Methods
        void ToggleDoor()
        {
            if (_anim.IsPlaying("Closing") || _anim.IsPlaying("Opening")) { Debug.Log("Isplaying..."); return; }

            if (_isOpen)
                _anim.Play("Closing");
            else
                _anim.Play("Opening");

            _isOpen = !_isOpen;
        }
        #endregion
      
    }


}
