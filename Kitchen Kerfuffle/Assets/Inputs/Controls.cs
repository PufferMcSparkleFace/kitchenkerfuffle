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
                    ""processors"": """",
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
    public interface ITriangleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
