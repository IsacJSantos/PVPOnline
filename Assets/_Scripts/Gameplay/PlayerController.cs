using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;
    [SerializeField] Animator _playerAnimator;
    [SerializeField] float _moveSpeed;
    MyPlayerInput _inputActions;

    Vector2 _currentMovementInput;
    Vector3 _currentMoviment;
    bool _isMovementPressed;
    private void OnEnable()
    {
        _inputActions.CharacterController.Enable();
    }

    private void OnDisable()
    {
        _inputActions.CharacterController.Disable();
    }
    private void Awake()
    {
        _inputActions = new MyPlayerInput();
        _inputActions.CharacterController.Move.performed += context => Move(context);
        _inputActions.CharacterController.Move.canceled += context => Move(context);
    }
    void Move(InputAction.CallbackContext context)
    {
        Debug.Log(context.ReadValue<Vector2>());
        _currentMovementInput = context.ReadValue<Vector2>();
        _currentMoviment.x = _currentMovementInput.x;
        _currentMoviment.z = _currentMovementInput.y;
        _isMovementPressed = _currentMovementInput.x != 0 || _currentMovementInput.y != 0;

        _playerAnimator.SetInteger("YValue", _currentMoviment.z == 0 ? 0 : (int)Mathf.Sign(_currentMoviment.z));
        _playerAnimator.SetInteger("XValue", _currentMoviment.x == 0 ? 0 : (int)Mathf.Sign(_currentMoviment.x));


    }
    private void Update()
    {
        if (!_isMovementPressed) return;


        _characterController.Move(_currentMoviment * _moveSpeed * Time.deltaTime);
    }
}
