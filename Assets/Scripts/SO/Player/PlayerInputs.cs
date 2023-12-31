//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/SO/Player/PlayerInputs.inputactions
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

public partial class @PlayerInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""GameControls"",
            ""id"": ""347aaa92-3c9a-44a0-b797-8500078f2af9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""145c0cde-ca04-4071-b1a9-686cc4d2ff86"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f7c201b5-d5c6-465c-b6fd-bf2d641e0c90"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Mainhand"",
                    ""type"": ""Button"",
                    ""id"": ""b22c8141-eed2-4437-a507-2061010a0093"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Offhand"",
                    ""type"": ""Button"",
                    ""id"": ""192697d8-8009-425c-a5b3-e868a17725ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Primary"",
                    ""type"": ""Button"",
                    ""id"": ""3fb8eb8d-7d13-456e-ae33-91e541b28180"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Secondary"",
                    ""type"": ""Button"",
                    ""id"": ""3aa90c08-71e1-44ba-b4ef-c8ed3193bbe6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ultimate"",
                    ""type"": ""Button"",
                    ""id"": ""24b33f43-20bb-4ffd-9945-f655f5d5cbfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""3fa43525-f645-4969-8ee3-8bbc0ebfd4bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""424e2358-98d6-4075-a416-4b1ae8b1b72d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""220ad90b-2edd-4dee-9b43-ff25e2351818"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""d3bbde05-ce68-4760-9bd6-9882a7e3869c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b22be6e4-9169-46b6-b59b-98e48f75514c"",
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
                    ""id"": ""1ff3e889-fabe-4d46-b0b8-35ab1e469d30"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24cd1e44-1f9d-41a2-9f07-e167f64aa26d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ab0f995b-2701-4e8e-b2dc-9ca4feec8baa"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""579cd5d2-f32a-46e1-bce4-e469657dedf7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c87cb518-5630-4cdd-a1b0-d611656c72ac"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a7bbd325-ace9-478f-927c-85680ac5562a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0a938a46-48dd-42e7-a9cc-0481ce2b2fe3"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d517356e-f0c3-45d9-bb8c-e64a7587cfc5"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3bf23cce-1da3-4d56-abf5-d13d3f705c58"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1caad71f-3514-4a08-91a0-ec73fc44a68e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Mainhand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77c1b070-ea2b-41c5-a707-c3b32e5eb906"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Offhand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1db4be77-8853-4fcc-9b88-5dc27c2ac029"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a148cb8-6116-4545-bc67-897ff97089b6"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cc92433-a8f0-4c66-aeac-3ca3d31cd1cb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Ultimate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df0d41a0-825e-42ed-a451-1c7a2d31adb4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21fcc3a1-0fcc-4c8d-bbc1-2575f9f3f53a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75595f87-1a35-4da9-ae26-078e854de7c5"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""633e4129-38c9-4919-b99c-3db0cd3a88ba"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b3d78a1-37f9-4f0a-ad60-c7570c1deca4"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_Move = m_GameControls.FindAction("Move", throwIfNotFound: true);
        m_GameControls_Look = m_GameControls.FindAction("Look", throwIfNotFound: true);
        m_GameControls_Mainhand = m_GameControls.FindAction("Mainhand", throwIfNotFound: true);
        m_GameControls_Offhand = m_GameControls.FindAction("Offhand", throwIfNotFound: true);
        m_GameControls_Primary = m_GameControls.FindAction("Primary", throwIfNotFound: true);
        m_GameControls_Secondary = m_GameControls.FindAction("Secondary", throwIfNotFound: true);
        m_GameControls_Ultimate = m_GameControls.FindAction("Ultimate", throwIfNotFound: true);
        m_GameControls_Roll = m_GameControls.FindAction("Roll", throwIfNotFound: true);
        m_GameControls_Interact = m_GameControls.FindAction("Interact", throwIfNotFound: true);
        m_GameControls_Continue = m_GameControls.FindAction("Continue", throwIfNotFound: true);
        m_GameControls_Menu = m_GameControls.FindAction("Menu", throwIfNotFound: true);
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

    // GameControls
    private readonly InputActionMap m_GameControls;
    private IGameControlsActions m_GameControlsActionsCallbackInterface;
    private readonly InputAction m_GameControls_Move;
    private readonly InputAction m_GameControls_Look;
    private readonly InputAction m_GameControls_Mainhand;
    private readonly InputAction m_GameControls_Offhand;
    private readonly InputAction m_GameControls_Primary;
    private readonly InputAction m_GameControls_Secondary;
    private readonly InputAction m_GameControls_Ultimate;
    private readonly InputAction m_GameControls_Roll;
    private readonly InputAction m_GameControls_Interact;
    private readonly InputAction m_GameControls_Continue;
    private readonly InputAction m_GameControls_Menu;
    public struct GameControlsActions
    {
        private @PlayerInputs m_Wrapper;
        public GameControlsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GameControls_Move;
        public InputAction @Look => m_Wrapper.m_GameControls_Look;
        public InputAction @Mainhand => m_Wrapper.m_GameControls_Mainhand;
        public InputAction @Offhand => m_Wrapper.m_GameControls_Offhand;
        public InputAction @Primary => m_Wrapper.m_GameControls_Primary;
        public InputAction @Secondary => m_Wrapper.m_GameControls_Secondary;
        public InputAction @Ultimate => m_Wrapper.m_GameControls_Ultimate;
        public InputAction @Roll => m_Wrapper.m_GameControls_Roll;
        public InputAction @Interact => m_Wrapper.m_GameControls_Interact;
        public InputAction @Continue => m_Wrapper.m_GameControls_Continue;
        public InputAction @Menu => m_Wrapper.m_GameControls_Menu;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLook;
                @Mainhand.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMainhand;
                @Mainhand.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMainhand;
                @Mainhand.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMainhand;
                @Offhand.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnOffhand;
                @Offhand.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnOffhand;
                @Offhand.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnOffhand;
                @Primary.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPrimary;
                @Primary.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPrimary;
                @Primary.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPrimary;
                @Secondary.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnSecondary;
                @Secondary.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnSecondary;
                @Secondary.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnSecondary;
                @Ultimate.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnUltimate;
                @Ultimate.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnUltimate;
                @Ultimate.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnUltimate;
                @Roll.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRoll;
                @Interact.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnInteract;
                @Continue.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnContinue;
                @Menu.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_GameControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Mainhand.started += instance.OnMainhand;
                @Mainhand.performed += instance.OnMainhand;
                @Mainhand.canceled += instance.OnMainhand;
                @Offhand.started += instance.OnOffhand;
                @Offhand.performed += instance.OnOffhand;
                @Offhand.canceled += instance.OnOffhand;
                @Primary.started += instance.OnPrimary;
                @Primary.performed += instance.OnPrimary;
                @Primary.canceled += instance.OnPrimary;
                @Secondary.started += instance.OnSecondary;
                @Secondary.performed += instance.OnSecondary;
                @Secondary.canceled += instance.OnSecondary;
                @Ultimate.started += instance.OnUltimate;
                @Ultimate.performed += instance.OnUltimate;
                @Ultimate.canceled += instance.OnUltimate;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IGameControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMainhand(InputAction.CallbackContext context);
        void OnOffhand(InputAction.CallbackContext context);
        void OnPrimary(InputAction.CallbackContext context);
        void OnSecondary(InputAction.CallbackContext context);
        void OnUltimate(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnContinue(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
