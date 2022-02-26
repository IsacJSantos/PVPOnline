using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace BraveHunter.Gameplay
{
    public class PlayerInteractSystem : MonoBehaviour
    {

        IInteractable _interactable;
        MyPlayerInput _inputActions;
        private void Awake()
        {
            _inputActions = new MyPlayerInput();
            _inputActions.CharacterController.Interact.performed += InteractWith;
        }
        private void OnEnable()
        {
            _inputActions.Enable();
        }
        private void OnDisable()
        {
            _inputActions.Disable();
        }

        private void OnTriggerEnter(Collider other)
        {
            IInteractable interactable = other.gameObject.GetComponent<IInteractable>();
            if (interactable != null)
                _interactable = interactable;
        }

        private void OnTriggerExit(Collider other)
        {
            if (_interactable != null)
                _interactable = null;
        }

        #region Public Methods

        #endregion

        #region Private Methods
        void InteractWith(InputAction.CallbackContext context) 
        {
            if (_interactable != null)
                _interactable.Interact();
        }

        #endregion
    }
}
