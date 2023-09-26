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
            ""id"": ""bb8a4829-9a38-4fe2-9548-f8452ed7c4cd"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fd67ef56-e683-4a57-bd4e-154a8800f742"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8427d11b-a651-40ae-931a-fbb3022bda0c"",
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
                    ""id"": ""6f549154-71b4-494a-9cb2-917cbcfd95d3"",
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
                    ""id"": ""9ab80aae-b349-4a40-a681-2c2dfa5d7285"",
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
                    ""id"": ""4d1cb3a5-aeb2-49a1-a7b0-25cb8829c7e5"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
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
    public struct TriangleControlsActions
    {
        private @Controls m_Wrapper;
        public TriangleControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_TriangleControls_Jump;
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
            }
            m_Wrapper.m_TriangleControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public TriangleControlsActions @TriangleControls => new TriangleControlsActions(this);
    public interface ITriangleControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}
