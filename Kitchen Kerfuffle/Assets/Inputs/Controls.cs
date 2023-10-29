// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""TriangleControls"",
            ""id"": ""d45b2034-92c0-42a7-a2f4-e6c23324286a"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""93630b26-190d-4c9d-b365-b6748484478a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastFall"",
                    ""type"": ""Button"",
                    ""id"": ""78eb46a7-a73e-457a-8715-2d3a4922f3b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""345939ae-5694-484b-90cf-f693accac2b2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""a35f6d8f-6afc-424c-a2c7-d683c5b4ac5d"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Normal Shot"",
                    ""type"": ""Button"",
                    ""id"": ""1cd270f9-7491-46b1-b2bc-a389bf49b8d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special Shot"",
                    ""type"": ""Button"",
                    ""id"": ""556b776f-35a1-49d6-8f0f-85c3588c2092"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49e01195-ad47-44fd-87e1-c5f53b813e30"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6fe1c86-aaa2-46fd-bccb-44271ab7b07a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7197e831-2f50-4be4-aa11-a0483321c2ef"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ec3caf39-7cc1-4bd7-ae6d-86b4ccff1545"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""13fc1d04-762e-41ec-99bc-14d5fc2717c0"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ab4af620-f3b2-4740-81a6-8f453614f9ac"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f226895a-62f3-4eff-94a6-44898ecbae3c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.65)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edd01856-bfdc-45d9-b83e-9b0f34080972"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Normal Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""608d5e93-5165-4f1a-97f0-f0b835721a1c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CircleControls"",
            ""id"": ""2c9bafd3-fcf4-4c66-95ea-dbd6441796a6"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6a1ada67-03a0-446e-a3c8-9b387ce2c336"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""2c4ce34e-c5c5-484d-8f4b-9b7ec4d57621"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""6beb057f-4673-4e45-8ed3-3f4cd68fbd17"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Normal Shot"",
                    ""type"": ""Button"",
                    ""id"": ""8071498e-2802-497d-a81b-cd412b3521b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special Shot"",
                    ""type"": ""Button"",
                    ""id"": ""622f62c7-bb64-4aa4-b624-213d994956f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ddc6c67-7801-43e5-8913-1fb29b417e78"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5538868-0d5d-483f-a776-0acbda812b07"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e380d529-8f54-4945-8030-6923658530f3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a5e77645-9f0a-4697-b018-dde3e0bebb00"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b809a504-c6d4-44d5-92ca-0b54054123d9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7b98ea2b-db33-429e-bd27-47d5d65cb491"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.65)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93156f80-2ef4-4730-a3b8-c8f202947ebf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Normal Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26e97d7c-7897-45e6-bfa4-ae97102aebb4"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special Shot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayersMovement"",
            ""id"": ""d2da4b08-c064-4588-b7d3-8f7672340d25"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""7b49e643-563d-4d58-b223-278675c1aa64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1277afb9-eff4-4916-8d9f-537eb7019a92"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""94bb050e-fbc0-4969-968d-525d9e16aa76"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""53e53765-0794-4fb7-b30d-95be5df21f4f"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""19bff072-c9df-4e8e-a255-ed60ff7fa9a6"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TriangleControls
        m_TriangleControls = asset.FindActionMap("TriangleControls", throwIfNotFound: true);
        m_TriangleControls_Jump = m_TriangleControls.FindAction("Jump", throwIfNotFound: true);
        m_TriangleControls_FastFall = m_TriangleControls.FindAction("FastFall", throwIfNotFound: true);
        m_TriangleControls_Horizontal = m_TriangleControls.FindAction("Horizontal", throwIfNotFound: true);
        m_TriangleControls_Aim = m_TriangleControls.FindAction("Aim", throwIfNotFound: true);
        m_TriangleControls_NormalShot = m_TriangleControls.FindAction("Normal Shot", throwIfNotFound: true);
        m_TriangleControls_SpecialShot = m_TriangleControls.FindAction("Special Shot", throwIfNotFound: true);
        // CircleControls
        m_CircleControls = asset.FindActionMap("CircleControls", throwIfNotFound: true);
        m_CircleControls_Jump = m_CircleControls.FindAction("Jump", throwIfNotFound: true);
        m_CircleControls_Horizontal = m_CircleControls.FindAction("Horizontal", throwIfNotFound: true);
        m_CircleControls_Aim = m_CircleControls.FindAction("Aim", throwIfNotFound: true);
        m_CircleControls_NormalShot = m_CircleControls.FindAction("Normal Shot", throwIfNotFound: true);
        m_CircleControls_SpecialShot = m_CircleControls.FindAction("Special Shot", throwIfNotFound: true);
        // PlayersMovement
        m_PlayersMovement = asset.FindActionMap("PlayersMovement", throwIfNotFound: true);
        m_PlayersMovement_Movement = m_PlayersMovement.FindAction("Movement", throwIfNotFound: true);
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

    // TriangleControls
    private readonly InputActionMap m_TriangleControls;
    private ITriangleControlsActions m_TriangleControlsActionsCallbackInterface;
    private readonly InputAction m_TriangleControls_Jump;
    private readonly InputAction m_TriangleControls_FastFall;
    private readonly InputAction m_TriangleControls_Horizontal;
    private readonly InputAction m_TriangleControls_Aim;
    private readonly InputAction m_TriangleControls_NormalShot;
    private readonly InputAction m_TriangleControls_SpecialShot;
    public struct TriangleControlsActions
    {
        private @Controls m_Wrapper;
        public TriangleControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_TriangleControls_Jump;
        public InputAction @FastFall => m_Wrapper.m_TriangleControls_FastFall;
        public InputAction @Horizontal => m_Wrapper.m_TriangleControls_Horizontal;
        public InputAction @Aim => m_Wrapper.m_TriangleControls_Aim;
        public InputAction @NormalShot => m_Wrapper.m_TriangleControls_NormalShot;
        public InputAction @SpecialShot => m_Wrapper.m_TriangleControls_SpecialShot;
        public InputActionMap Get() { return m_Wrapper.m_TriangleControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TriangleControlsActions set) { return set.Get(); }
        public void SetCallbacks(ITriangleControlsActions instance)
        {
            if (m_Wrapper.m_TriangleControlsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnJump;
                @FastFall.started -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnFastFall;
                @FastFall.performed -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnFastFall;
                @FastFall.canceled -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnFastFall;
                @Horizontal.started -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnHorizontal;
                @Aim.started -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnAim;
                @NormalShot.started -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnNormalShot;
                @NormalShot.performed -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnNormalShot;
                @NormalShot.canceled -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnNormalShot;
                @SpecialShot.started -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnSpecialShot;
                @SpecialShot.performed -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnSpecialShot;
                @SpecialShot.canceled -= m_Wrapper.m_TriangleControlsActionsCallbackInterface.OnSpecialShot;
            }
            m_Wrapper.m_TriangleControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @FastFall.started += instance.OnFastFall;
                @FastFall.performed += instance.OnFastFall;
                @FastFall.canceled += instance.OnFastFall;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @NormalShot.started += instance.OnNormalShot;
                @NormalShot.performed += instance.OnNormalShot;
                @NormalShot.canceled += instance.OnNormalShot;
                @SpecialShot.started += instance.OnSpecialShot;
                @SpecialShot.performed += instance.OnSpecialShot;
                @SpecialShot.canceled += instance.OnSpecialShot;
            }
        }
    }
    public TriangleControlsActions @TriangleControls => new TriangleControlsActions(this);

    // CircleControls
    private readonly InputActionMap m_CircleControls;
    private ICircleControlsActions m_CircleControlsActionsCallbackInterface;
    private readonly InputAction m_CircleControls_Jump;
    private readonly InputAction m_CircleControls_Horizontal;
    private readonly InputAction m_CircleControls_Aim;
    private readonly InputAction m_CircleControls_NormalShot;
    private readonly InputAction m_CircleControls_SpecialShot;
    public struct CircleControlsActions
    {
        private @Controls m_Wrapper;
        public CircleControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_CircleControls_Jump;
        public InputAction @Horizontal => m_Wrapper.m_CircleControls_Horizontal;
        public InputAction @Aim => m_Wrapper.m_CircleControls_Aim;
        public InputAction @NormalShot => m_Wrapper.m_CircleControls_NormalShot;
        public InputAction @SpecialShot => m_Wrapper.m_CircleControls_SpecialShot;
        public InputActionMap Get() { return m_Wrapper.m_CircleControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CircleControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICircleControlsActions instance)
        {
            if (m_Wrapper.m_CircleControlsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnJump;
                @Horizontal.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnHorizontal;
                @Aim.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnAim;
                @NormalShot.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnNormalShot;
                @NormalShot.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnNormalShot;
                @NormalShot.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnNormalShot;
                @SpecialShot.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnSpecialShot;
                @SpecialShot.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnSpecialShot;
                @SpecialShot.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnSpecialShot;
            }
            m_Wrapper.m_CircleControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @NormalShot.started += instance.OnNormalShot;
                @NormalShot.performed += instance.OnNormalShot;
                @NormalShot.canceled += instance.OnNormalShot;
                @SpecialShot.started += instance.OnSpecialShot;
                @SpecialShot.performed += instance.OnSpecialShot;
                @SpecialShot.canceled += instance.OnSpecialShot;
            }
        }
    }
    public CircleControlsActions @CircleControls => new CircleControlsActions(this);

    // PlayersMovement
    private readonly InputActionMap m_PlayersMovement;
    private IPlayersMovementActions m_PlayersMovementActionsCallbackInterface;
    private readonly InputAction m_PlayersMovement_Movement;
    public struct PlayersMovementActions
    {
        private @Controls m_Wrapper;
        public PlayersMovementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayersMovement_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayersMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayersMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayersMovementActions instance)
        {
            if (m_Wrapper.m_PlayersMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayersMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayersMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayersMovementActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayersMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayersMovementActions @PlayersMovement => new PlayersMovementActions(this);
    public interface ITriangleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnNormalShot(InputAction.CallbackContext context);
        void OnSpecialShot(InputAction.CallbackContext context);
    }
    public interface ICircleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnNormalShot(InputAction.CallbackContext context);
        void OnSpecialShot(InputAction.CallbackContext context);
    }
    public interface IPlayersMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
