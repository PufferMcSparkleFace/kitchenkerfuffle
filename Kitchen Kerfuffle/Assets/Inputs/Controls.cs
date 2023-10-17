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
                    ""id"": ""6d1e4ec0-853b-48aa-bf16-aea6ed93372d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
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
                    ""name"": ""FastFall"",
                    ""type"": ""Button"",
                    ""id"": ""f1f31c8c-aaea-486e-8493-d1f8f845cdac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""2c4ce34e-c5c5-484d-8f4b-9b7ec4d57621"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""6beb057f-4673-4e45-8ed3-3f4cd68fbd17"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0ddc6c67-7801-43e5-8913-1fb29b417e78"",
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
                    ""id"": ""de2aa61c-bdf5-4d18-9764-077c2dc8a078"",
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
                    ""id"": ""6693a2f4-225d-4c6d-9c18-5ad07b13f951"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd3f89c3-7d71-4848-a4fc-a4c42971b716"",
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
                    ""id"": ""58f29a6f-ec12-49bb-90f3-5e4c6a4f6dd5"",
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
                    ""id"": ""7d1f5679-18e0-4a36-a243-4ef9bbf62632"",
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
                    ""id"": ""453bf98c-db98-4679-9d3a-65123ab4b6ce"",
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
                    ""id"": ""7b98ea2b-db33-429e-bd27-47d5d65cb491"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.65)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
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
        // CircleControls
        m_CircleControls = asset.FindActionMap("CircleControls", throwIfNotFound: true);
        m_CircleControls_Jump = m_CircleControls.FindAction("Jump", throwIfNotFound: true);
        m_CircleControls_FastFall = m_CircleControls.FindAction("FastFall", throwIfNotFound: true);
        m_CircleControls_Horizontal = m_CircleControls.FindAction("Horizontal", throwIfNotFound: true);
        m_CircleControls_Aim = m_CircleControls.FindAction("Aim", throwIfNotFound: true);
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
    public struct TriangleControlsActions
    {
        private @Controls m_Wrapper;
        public TriangleControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_TriangleControls_Jump;
        public InputAction @FastFall => m_Wrapper.m_TriangleControls_FastFall;
        public InputAction @Horizontal => m_Wrapper.m_TriangleControls_Horizontal;
        public InputAction @Aim => m_Wrapper.m_TriangleControls_Aim;
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
            }
        }
    }
    public TriangleControlsActions @TriangleControls => new TriangleControlsActions(this);

    // CircleControls
    private readonly InputActionMap m_CircleControls;
    private ICircleControlsActions m_CircleControlsActionsCallbackInterface;
    private readonly InputAction m_CircleControls_Jump;
    private readonly InputAction m_CircleControls_FastFall;
    private readonly InputAction m_CircleControls_Horizontal;
    private readonly InputAction m_CircleControls_Aim;
    public struct CircleControlsActions
    {
        private @Controls m_Wrapper;
        public CircleControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_CircleControls_Jump;
        public InputAction @FastFall => m_Wrapper.m_CircleControls_FastFall;
        public InputAction @Horizontal => m_Wrapper.m_CircleControls_Horizontal;
        public InputAction @Aim => m_Wrapper.m_CircleControls_Aim;
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
                @FastFall.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnFastFall;
                @FastFall.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnFastFall;
                @FastFall.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnFastFall;
                @Horizontal.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnHorizontal;
                @Aim.started -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_CircleControlsActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_CircleControlsActionsCallbackInterface = instance;
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
            }
        }
    }
    public CircleControlsActions @CircleControls => new CircleControlsActions(this);
    public interface ITriangleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface ICircleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
