using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;
    [SerializeField] Animator _playerAnimator;
    [SerializeField] Transform _playerTransform;
    [SerializeField] Transform _look;
    [SerializeField] float _moveSpeed;
    MyPlayerInput _inputActions;

    Vector2 _currentMovementInput;
    Vector3 _currentMoviment;
    bool _isMovementPressed;
   
    Quaternion rotation;
    Vector3 relativePos;
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
        _inputActions.CharacterController.Move.performed += SetMove;
        _inputActions.CharacterController.Move.canceled += SetMove;
        _inputActions.CharacterController.Rotate.performed += SetLookRotation;
    }
    private void Update()
    {
        if (_isMovementPressed) 
        {
            Move();
            Rotate();
        }
           
    }

    private void Move()
    {
        Vector3 motion = Vector3.zero;
        motion += _playerTransform.forward * _currentMoviment.z * _moveSpeed * Time.deltaTime;
        motion += _playerTransform.right * _currentMoviment.x * _moveSpeed * Time.deltaTime;
        _characterController.Move(motion);
    }

    private void Rotate()
    {
        relativePos = new Vector3(_look.position.x, _playerTransform.position.y, _look.position.z) - _playerTransform.position;
        rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        _playerTransform.rotation = rotation;
    }
    void SetMove(InputAction.CallbackContext context)
    {
       // Debug.Log(context.ReadValue<Vector2>());
        _currentMovementInput = context.ReadValue<Vector2>();
        _currentMoviment.x = _currentMovementInput.x;
        _currentMoviment.z = _currentMovementInput.y;
        _isMovementPressed = _currentMovementInput.x != 0 || _currentMovementInput.y != 0;

        _playerAnimator.SetInteger("YValue", _currentMoviment.z == 0 ? 0 : (int)Mathf.Sign(_currentMoviment.z));
        _playerAnimator.SetInteger("XValue", _currentMoviment.x == 0 ? 0 : (int)Mathf.Sign(_currentMoviment.x));


    }
    void SetLookRotation(InputAction.CallbackContext context)
    {

        Vector2 mousePos = context.ReadValue<Vector2>();
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            _look.position = hit.point;
                    
        }

    }
}
