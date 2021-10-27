// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/BabyInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @BabyInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @BabyInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BabyInput"",
    ""maps"": [
        {
            ""name"": ""BabyMovement"",
            ""id"": ""9e61b83a-5457-46d0-be0f-3e25cf7a1a6b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3d0e7986-c6fb-4f30-9234-bc8928b16bdc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""7819da41-2796-45f6-9da3-c9ddd47818e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Force"",
                    ""type"": ""Button"",
                    ""id"": ""7c8839f5-2473-4b32-84b8-a148d3b22159"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""44a9b0c8-5ee2-4c03-8b5b-5724bdf84073"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""975bea1f-8654-414e-b28f-189af0686d18"",
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
                    ""id"": ""ae201714-829e-48e2-bfe9-c7f95da77f0f"",
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
                    ""id"": ""b912bdfe-7292-48d2-a31a-652110a6cd9d"",
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
                    ""id"": ""cd84eb7c-d977-4fb4-892b-b237acf09477"",
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
                    ""id"": ""81caf862-ca51-4843-85ff-9445b4565905"",
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
                    ""id"": ""2f665123-e9a2-4a43-b175-0e92ca0ad1e4"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5f1e8214-f51d-454c-84db-e83867a46440"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0aebcb5e-7a90-4b89-bf39-3c7584e5902a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8c5e163d-913a-41cc-ab0d-1bbbb57f0739"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1e1713de-932c-4bd3-a80f-8687a623585d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6fb7c072-c46d-4e02-891b-9bd964f9a85d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dffb142b-a8bf-4824-8cf1-5726d3a522ec"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Force"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": []
        },
        {
            ""name"": ""New control scheme1"",
            ""bindingGroup"": ""New control scheme1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // BabyMovement
        m_BabyMovement = asset.FindActionMap("BabyMovement", throwIfNotFound: true);
        m_BabyMovement_Move = m_BabyMovement.FindAction("Move", throwIfNotFound: true);
        m_BabyMovement_Rotate = m_BabyMovement.FindAction("Rotate", throwIfNotFound: true);
        m_BabyMovement_Force = m_BabyMovement.FindAction("Force", throwIfNotFound: true);
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

    // BabyMovement
    private readonly InputActionMap m_BabyMovement;
    private IBabyMovementActions m_BabyMovementActionsCallbackInterface;
    private readonly InputAction m_BabyMovement_Move;
    private readonly InputAction m_BabyMovement_Rotate;
    private readonly InputAction m_BabyMovement_Force;
    public struct BabyMovementActions
    {
        private @BabyInput m_Wrapper;
        public BabyMovementActions(@BabyInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BabyMovement_Move;
        public InputAction @Rotate => m_Wrapper.m_BabyMovement_Rotate;
        public InputAction @Force => m_Wrapper.m_BabyMovement_Force;
        public InputActionMap Get() { return m_Wrapper.m_BabyMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BabyMovementActions set) { return set.Get(); }
        public void SetCallbacks(IBabyMovementActions instance)
        {
            if (m_Wrapper.m_BabyMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnRotate;
                @Force.started -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnForce;
                @Force.performed -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnForce;
                @Force.canceled -= m_Wrapper.m_BabyMovementActionsCallbackInterface.OnForce;
            }
            m_Wrapper.m_BabyMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Force.started += instance.OnForce;
                @Force.performed += instance.OnForce;
                @Force.canceled += instance.OnForce;
            }
        }
    }
    public BabyMovementActions @BabyMovement => new BabyMovementActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    private int m_Newcontrolscheme1SchemeIndex = -1;
    public InputControlScheme Newcontrolscheme1Scheme
    {
        get
        {
            if (m_Newcontrolscheme1SchemeIndex == -1) m_Newcontrolscheme1SchemeIndex = asset.FindControlSchemeIndex("New control scheme1");
            return asset.controlSchemes[m_Newcontrolscheme1SchemeIndex];
        }
    }
    public interface IBabyMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnForce(InputAction.CallbackContext context);
    }
}
