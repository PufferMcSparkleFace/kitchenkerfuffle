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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""36563719-114c-47df-8495-77239679db30"",
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
                    ""id"": ""e3a9e4fa-ab46-422d-8709-d51e754ebd94"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
                    ""id"": ""0f220f38-138d-4fa9-9ebb-4b0f44dc1f19"",
                    ""path"": ""<Gamepad>/leftStick/up"",
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
                    ""id"": ""3c34e6d9-b878-487b-b4af-c34c84959dea"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a3ba0a2-9b05-4a50-b79c-63b71845ef95"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1a795f54-a2d2-419b-84fb-4ff58676ffbc"",
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
                    ""id"": ""cefcc3c7-7805-46d0-8142-97dc08a93f48"",
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
                    ""id"": ""93000ec5-70c6-4051-ac91-5ee357d2309d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
    public struct TriangleControlsActions
    {
        private @Controls m_Wrapper;
        public TriangleControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_TriangleControls_Jump;
        public InputAction @FastFall => m_Wrapper.m_TriangleControls_FastFall;
        public InputAction @Horizontal => m_Wrapper.m_TriangleControls_Horizontal;
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
            }
        }
    }
    public TriangleControlsActions @TriangleControls => new TriangleControlsActions(this);
    public interface ITriangleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnFastFall(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
    }
}
