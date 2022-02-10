using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryCanvas : MonoBehaviour
{
    [SerializeField] Canvas _cv;

    MyPlayerInput _playerInput;
    bool _isOpen;

    private void Awake()
    {
        _playerInput = new MyPlayerInput();
        _playerInput.HUDController.ToggleInventory.started += ToggleInventory;
    }
    private void OnEnable()
    {
        _playerInput.HUDController.Enable();
    }
    private void OnDisable()
    {
        _playerInput.HUDController.Disable();
    }
    public void ToggleInventory(InputAction.CallbackContext context) 
    {
        _isOpen = !_isOpen;
        _cv.enabled = _isOpen;
    }
}
