// GENERATED AUTOMATICALLY FROM 'Assets/JZ/Input/Inputs/CutsceneInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CutsceneInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CutsceneInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CutsceneInputs"",
    ""maps"": [
        {
            ""name"": ""Map"",
            ""id"": ""140ee9c0-27d1-4982-ab6c-11f352a3bcf9"",
            ""actions"": [
                {
                    ""name"": ""Skip Scene"",
                    ""type"": ""Button"",
                    ""id"": ""d7aa7f9f-a2c9-446e-bed5-19154e30f580"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=2)""
                },
                {
                    ""name"": ""Next Line"",
                    ""type"": ""Button"",
                    ""id"": ""ed1392c8-96f2-4f8b-8513-8cbef35d8d0c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83b88229-a5da-4bb3-b158-5223f3721f5e"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip Scene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c63e3d5-15c1-4b42-bad9-dbd5dda7fe50"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip Scene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbd1c7ab-05ef-4f3b-9153-bac4de81330a"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next Line"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f202d889-8b6c-48a3-acb5-b02ae9bc1a84"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next Line"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b217571-8ea3-46f0-80b9-6b8989e81018"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next Line"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Map
        m_Map = asset.FindActionMap("Map", throwIfNotFound: true);
        m_Map_SkipScene = m_Map.FindAction("Skip Scene", throwIfNotFound: true);
        m_Map_NextLine = m_Map.FindAction("Next Line", throwIfNotFound: true);
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

    // Map
    private readonly InputActionMap m_Map;
    private IMapActions m_MapActionsCallbackInterface;
    private readonly InputAction m_Map_SkipScene;
    private readonly InputAction m_Map_NextLine;
    public struct MapActions
    {
        private @CutsceneInputs m_Wrapper;
        public MapActions(@CutsceneInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @SkipScene => m_Wrapper.m_Map_SkipScene;
        public InputAction @NextLine => m_Wrapper.m_Map_NextLine;
        public InputActionMap Get() { return m_Wrapper.m_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapActions set) { return set.Get(); }
        public void SetCallbacks(IMapActions instance)
        {
            if (m_Wrapper.m_MapActionsCallbackInterface != null)
            {
                @SkipScene.started -= m_Wrapper.m_MapActionsCallbackInterface.OnSkipScene;
                @SkipScene.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnSkipScene;
                @SkipScene.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnSkipScene;
                @NextLine.started -= m_Wrapper.m_MapActionsCallbackInterface.OnNextLine;
                @NextLine.performed -= m_Wrapper.m_MapActionsCallbackInterface.OnNextLine;
                @NextLine.canceled -= m_Wrapper.m_MapActionsCallbackInterface.OnNextLine;
            }
            m_Wrapper.m_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SkipScene.started += instance.OnSkipScene;
                @SkipScene.performed += instance.OnSkipScene;
                @SkipScene.canceled += instance.OnSkipScene;
                @NextLine.started += instance.OnNextLine;
                @NextLine.performed += instance.OnNextLine;
                @NextLine.canceled += instance.OnNextLine;
            }
        }
    }
    public MapActions @Map => new MapActions(this);
    public interface IMapActions
    {
        void OnSkipScene(InputAction.CallbackContext context);
        void OnNextLine(InputAction.CallbackContext context);
    }
}
