//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Input/MyPlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MyPlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyPlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyPlayerInput"",
    ""maps"": [
        {
            ""name"": ""CharacterController"",
            ""id"": ""8ebc07a9-25e5-4bc0-ab9d-d5a057220b6d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""521df14a-6c4a-4c59-bae2-9a52b1c6b4bc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""9c002476-92d3-4d06-890e-635f79a30d97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ca75e86-fdcb-458e-841c-4519147cbfc6"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""542452bd-01bc-4bb0-9e5c-94866dafbc0c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ee68bc5-8057-41e5-9f70-c66dcdf835a0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c08b889b-ff9b-4fdb-a229-97f176655b50"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""710e6e02-f692-4488-801f-f6f19c7aa370"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f9de6b1-a180-4659-878d-f46662cb08ec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6dbeb9f8-7b76-463e-a703-c26c68179285"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HUDController"",
            ""id"": ""e66428ef-8ccd-454c-a248-5e3467df034e"",
            ""actions"": [
                {
                    ""name"": ""ToggleInventory"",
                    ""type"": ""Button"",
                    ""id"": ""932eab82-73f5-4464-91e9-606089a7a801"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CollectItem"",
                    ""type"": ""Button"",
                    ""id"": ""53c86c64-63b1-4616-b272-da8836ecfdba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c06aeedd-b030-4c3f-8580-4a6e07aa7388"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13327a80-f1a3-42a9-ad7b-b0c490b1d283"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CollectItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterController
        m_CharacterController = asset.FindActionMap("CharacterController", throwIfNotFound: true);
        m_CharacterController_Move = m_CharacterController.FindAction("Move", throwIfNotFound: true);
        m_CharacterController_Interact = m_CharacterController.FindAction("Interact", throwIfNotFound: true);
        // HUDController
        m_HUDController = asset.FindActionMap("HUDController", throwIfNotFound: true);
        m_HUDController_ToggleInventory = m_HUDController.FindAction("ToggleInventory", throwIfNotFound: true);
        m_HUDController_CollectItem = m_HUDController.FindAction("CollectItem", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CharacterController
    private readonly InputActionMap m_CharacterController;
    private ICharacterControllerActions m_CharacterControllerActionsCallbackInterface;
    private readonly InputAction m_CharacterController_Move;
    private readonly InputAction m_CharacterController_Interact;
    public struct CharacterControllerActions
    {
        private @MyPlayerInput m_Wrapper;
        public CharacterControllerActions(@MyPlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CharacterController_Move;
        public InputAction @Interact => m_Wrapper.m_CharacterController_Interact;
        public InputActionMap Get() { return m_Wrapper.m_CharacterController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControllerActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControllerActions instance)
        {
            if (m_Wrapper.m_CharacterControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CharacterControllerActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_CharacterControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public CharacterControllerActions @CharacterController => new CharacterControllerActions(this);

    // HUDController
    private readonly InputActionMap m_HUDController;
    private IHUDControllerActions m_HUDControllerActionsCallbackInterface;
    private readonly InputAction m_HUDController_ToggleInventory;
    private readonly InputAction m_HUDController_CollectItem;
    public struct HUDControllerActions
    {
        private @MyPlayerInput m_Wrapper;
        public HUDControllerActions(@MyPlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleInventory => m_Wrapper.m_HUDController_ToggleInventory;
        public InputAction @CollectItem => m_Wrapper.m_HUDController_CollectItem;
        public InputActionMap Get() { return m_Wrapper.m_HUDController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HUDControllerActions set) { return set.Get(); }
        public void SetCallbacks(IHUDControllerActions instance)
        {
            if (m_Wrapper.m_HUDControllerActionsCallbackInterface != null)
            {
                @ToggleInventory.started -= m_Wrapper.m_HUDControllerActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.performed -= m_Wrapper.m_HUDControllerActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.canceled -= m_Wrapper.m_HUDControllerActionsCallbackInterface.OnToggleInventory;
                @CollectItem.started -= m_Wrapper.m_HUDControllerActionsCallbackInterface.OnCollectItem;
                @CollectItem.performed -= m_Wrapper.m_HUDControllerActionsCallbackInterface.OnCollectItem;
                @CollectItem.canceled -= m_Wrapper.m_HUDControllerActionsCallbackInterface.OnCollectItem;
            }
            m_Wrapper.m_HUDControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleInventory.started += instance.OnToggleInventory;
                @ToggleInventory.performed += instance.OnToggleInventory;
                @ToggleInventory.canceled += instance.OnToggleInventory;
                @CollectItem.started += instance.OnCollectItem;
                @CollectItem.performed += instance.OnCollectItem;
                @CollectItem.canceled += instance.OnCollectItem;
            }
        }
    }
    public HUDControllerActions @HUDController => new HUDControllerActions(this);
    public interface ICharacterControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IHUDControllerActions
    {
        void OnToggleInventory(InputAction.CallbackContext context);
        void OnCollectItem(InputAction.CallbackContext context);
    }
}
