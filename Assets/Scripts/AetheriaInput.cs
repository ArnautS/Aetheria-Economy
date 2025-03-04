// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Aetheria.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @AetheriaInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @AetheriaInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Aetheria"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b00bd617-6995-42af-ac1f-90d4766f7933"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""197ba05c-054a-44fc-8328-0d37e8ac00db"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""323b9ea0-f916-4609-b697-322fc0ef9420"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Minimap Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""5708685d-78bd-4d2b-8796-712704f21bfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Target Reticle"",
                    ""type"": ""Button"",
                    ""id"": ""86f2e6cc-b895-4c55-aa19-70220df477d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Target Previous"",
                    ""type"": ""Button"",
                    ""id"": ""2cf8e2b2-1463-463b-8f55-e79884f3767d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Target Next"",
                    ""type"": ""Button"",
                    ""id"": ""1e2bd5af-e174-4533-8c57-b04b7e9df92c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Target Nearest"",
                    ""type"": ""Button"",
                    ""id"": ""b2a42777-c22b-48f3-9e74-8dc715449845"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Heatsinks"",
                    ""type"": ""Button"",
                    ""id"": ""e6c6ff6a-4ac2-4e53-a3c9-9461f52e723f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Shield"",
                    ""type"": ""Button"",
                    ""id"": ""5566504f-ee89-4eb9-9bbb-03f4b22dfe7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Override Shutdown"",
                    ""type"": ""Button"",
                    ""id"": ""62a64686-4670-43c9-81ee-bbb8578e284b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ping"",
                    ""type"": ""Button"",
                    ""id"": ""cfc95f69-9b8a-41d5-a071-003b4e292524"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hide UI"",
                    ""type"": ""Button"",
                    ""id"": ""1cdb2515-91e1-4895-879d-8a7347e60b21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tractor Beam"",
                    ""type"": ""Value"",
                    ""id"": ""e61d5d8e-eaf7-449d-8d54-624e15b6c964"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3ea4d645-4504-4529-b061-ab81934c3752"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5f5442-8668-4b27-a940-df99bad7e831"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""495c3ec6-3188-4309-9072-f958e89c87ec"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Minimap Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5211a58c-428b-4ee6-820d-2f67789806d6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Target Reticle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e13d87d-e5bb-4363-b153-1e0c1e21e4eb"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Target Previous"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6e3164c-1b59-4eab-99d9-5a3bc294af0b"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Target Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b55dd143-367d-4842-82c8-593c301bcd69"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Target Nearest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71ac6088-1e18-4810-86be-1179918dd4a2"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Toggle Heatsinks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d59fb542-6ac5-466d-a668-67fd8c890232"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Toggle Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e8b5d19-20fd-43f3-88cf-6246f374e7cf"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Override Shutdown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""baa67cdf-3c91-46dd-965c-12370a897414"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Ping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f898572-d165-4e29-93c3-95c3efce5df9"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Hide UI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37683a7e-02b1-4daa-a990-a51a30e7f8e9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Tractor Beam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""9a15adda-ca0c-414c-891e-6407bfcd3661"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""add1d35f-58cd-4789-8868-f0afb51d87bc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""766f9151-3f3d-4e12-8ade-ce5aacd3940f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""9dc56d99-ed81-42c3-b38d-1a7e76688b34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dfeef3e2-b0cc-4a9c-97ea-48ab693ac37f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aae7decd-7584-44f4-87ad-09c14c406ead"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""25891af2-479b-4104-9a29-158aee22fa73"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc9af334-4f90-46dc-9b77-f381faa04a79"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""27901940-469e-42cd-92b3-f5f787a8d1d6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drag"",
                    ""type"": ""Value"",
                    ""id"": ""0c96ec22-9571-46c8-94bf-199e70e919ed"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""618fb60f-5dc7-47ec-8dbf-fdc3d4c515a1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=1.25,y=1.25)"",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Global"",
            ""id"": ""2e2023b8-ce3b-4cb3-a12a-ff4ac610f11b"",
            ""actions"": [
                {
                    ""name"": ""Zone Map"",
                    ""type"": ""Button"",
                    ""id"": ""e43f020b-dec0-43d2-a83b-1390d45819be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Galaxy Map"",
                    ""type"": ""Button"",
                    ""id"": ""d198f18c-8c55-4a31-a694-4959c763f664"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""dafe13a7-da46-408e-853e-6954e37da5c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Main Menu"",
                    ""type"": ""Button"",
                    ""id"": ""0515c617-9dff-406f-ab3e-763971d532d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Input Screen"",
                    ""type"": ""Button"",
                    ""id"": ""e76aa7e9-e24d-47e1-865d-ffe72ba5c1c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""31f7b7e1-d15e-40e8-b74f-2d0dc4195d4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7eadec25-7b3f-4d69-92b7-c756f5f9b0dd"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Zone Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2eb827dd-4707-4648-b7e5-cf1fd8fa00da"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f90929d5-d8d1-40dc-acc7-7ae294971d12"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Galaxy Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""873dbfff-25b2-4747-ab9d-53d34324d660"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Main Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a786bc6-2cb5-4951-86f8-ef4e9607eab8"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Input Screen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a03cee94-69c9-4a26-be58-46b26351c659"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_MinimapZoom = m_Player.FindAction("Minimap Zoom", throwIfNotFound: true);
        m_Player_TargetReticle = m_Player.FindAction("Target Reticle", throwIfNotFound: true);
        m_Player_TargetPrevious = m_Player.FindAction("Target Previous", throwIfNotFound: true);
        m_Player_TargetNext = m_Player.FindAction("Target Next", throwIfNotFound: true);
        m_Player_TargetNearest = m_Player.FindAction("Target Nearest", throwIfNotFound: true);
        m_Player_ToggleHeatsinks = m_Player.FindAction("Toggle Heatsinks", throwIfNotFound: true);
        m_Player_ToggleShield = m_Player.FindAction("Toggle Shield", throwIfNotFound: true);
        m_Player_OverrideShutdown = m_Player.FindAction("Override Shutdown", throwIfNotFound: true);
        m_Player_Ping = m_Player.FindAction("Ping", throwIfNotFound: true);
        m_Player_HideUI = m_Player.FindAction("Hide UI", throwIfNotFound: true);
        m_Player_TractorBeam = m_Player.FindAction("Tractor Beam", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_Drag = m_UI.FindAction("Drag", throwIfNotFound: true);
        // Global
        m_Global = asset.FindActionMap("Global", throwIfNotFound: true);
        m_Global_ZoneMap = m_Global.FindAction("Zone Map", throwIfNotFound: true);
        m_Global_GalaxyMap = m_Global.FindAction("Galaxy Map", throwIfNotFound: true);
        m_Global_Inventory = m_Global.FindAction("Inventory", throwIfNotFound: true);
        m_Global_MainMenu = m_Global.FindAction("Main Menu", throwIfNotFound: true);
        m_Global_InputScreen = m_Global.FindAction("Input Screen", throwIfNotFound: true);
        m_Global_Interact = m_Global.FindAction("Interact", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_MinimapZoom;
    private readonly InputAction m_Player_TargetReticle;
    private readonly InputAction m_Player_TargetPrevious;
    private readonly InputAction m_Player_TargetNext;
    private readonly InputAction m_Player_TargetNearest;
    private readonly InputAction m_Player_ToggleHeatsinks;
    private readonly InputAction m_Player_ToggleShield;
    private readonly InputAction m_Player_OverrideShutdown;
    private readonly InputAction m_Player_Ping;
    private readonly InputAction m_Player_HideUI;
    private readonly InputAction m_Player_TractorBeam;
    public struct PlayerActions
    {
        private @AetheriaInput m_Wrapper;
        public PlayerActions(@AetheriaInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @MinimapZoom => m_Wrapper.m_Player_MinimapZoom;
        public InputAction @TargetReticle => m_Wrapper.m_Player_TargetReticle;
        public InputAction @TargetPrevious => m_Wrapper.m_Player_TargetPrevious;
        public InputAction @TargetNext => m_Wrapper.m_Player_TargetNext;
        public InputAction @TargetNearest => m_Wrapper.m_Player_TargetNearest;
        public InputAction @ToggleHeatsinks => m_Wrapper.m_Player_ToggleHeatsinks;
        public InputAction @ToggleShield => m_Wrapper.m_Player_ToggleShield;
        public InputAction @OverrideShutdown => m_Wrapper.m_Player_OverrideShutdown;
        public InputAction @Ping => m_Wrapper.m_Player_Ping;
        public InputAction @HideUI => m_Wrapper.m_Player_HideUI;
        public InputAction @TractorBeam => m_Wrapper.m_Player_TractorBeam;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @MinimapZoom.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimapZoom;
                @MinimapZoom.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimapZoom;
                @MinimapZoom.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimapZoom;
                @TargetReticle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetReticle;
                @TargetReticle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetReticle;
                @TargetReticle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetReticle;
                @TargetPrevious.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetPrevious;
                @TargetPrevious.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetPrevious;
                @TargetPrevious.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetPrevious;
                @TargetNext.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetNext;
                @TargetNext.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetNext;
                @TargetNext.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetNext;
                @TargetNearest.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetNearest;
                @TargetNearest.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetNearest;
                @TargetNearest.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTargetNearest;
                @ToggleHeatsinks.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleHeatsinks;
                @ToggleHeatsinks.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleHeatsinks;
                @ToggleHeatsinks.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleHeatsinks;
                @ToggleShield.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleShield;
                @ToggleShield.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleShield;
                @ToggleShield.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnToggleShield;
                @OverrideShutdown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOverrideShutdown;
                @OverrideShutdown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOverrideShutdown;
                @OverrideShutdown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOverrideShutdown;
                @Ping.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPing;
                @Ping.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPing;
                @Ping.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPing;
                @HideUI.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHideUI;
                @HideUI.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHideUI;
                @HideUI.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHideUI;
                @TractorBeam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTractorBeam;
                @TractorBeam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTractorBeam;
                @TractorBeam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTractorBeam;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @MinimapZoom.started += instance.OnMinimapZoom;
                @MinimapZoom.performed += instance.OnMinimapZoom;
                @MinimapZoom.canceled += instance.OnMinimapZoom;
                @TargetReticle.started += instance.OnTargetReticle;
                @TargetReticle.performed += instance.OnTargetReticle;
                @TargetReticle.canceled += instance.OnTargetReticle;
                @TargetPrevious.started += instance.OnTargetPrevious;
                @TargetPrevious.performed += instance.OnTargetPrevious;
                @TargetPrevious.canceled += instance.OnTargetPrevious;
                @TargetNext.started += instance.OnTargetNext;
                @TargetNext.performed += instance.OnTargetNext;
                @TargetNext.canceled += instance.OnTargetNext;
                @TargetNearest.started += instance.OnTargetNearest;
                @TargetNearest.performed += instance.OnTargetNearest;
                @TargetNearest.canceled += instance.OnTargetNearest;
                @ToggleHeatsinks.started += instance.OnToggleHeatsinks;
                @ToggleHeatsinks.performed += instance.OnToggleHeatsinks;
                @ToggleHeatsinks.canceled += instance.OnToggleHeatsinks;
                @ToggleShield.started += instance.OnToggleShield;
                @ToggleShield.performed += instance.OnToggleShield;
                @ToggleShield.canceled += instance.OnToggleShield;
                @OverrideShutdown.started += instance.OnOverrideShutdown;
                @OverrideShutdown.performed += instance.OnOverrideShutdown;
                @OverrideShutdown.canceled += instance.OnOverrideShutdown;
                @Ping.started += instance.OnPing;
                @Ping.performed += instance.OnPing;
                @Ping.canceled += instance.OnPing;
                @HideUI.started += instance.OnHideUI;
                @HideUI.performed += instance.OnHideUI;
                @HideUI.canceled += instance.OnHideUI;
                @TractorBeam.started += instance.OnTractorBeam;
                @TractorBeam.performed += instance.OnTractorBeam;
                @TractorBeam.canceled += instance.OnTractorBeam;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_Drag;
    public struct UIActions
    {
        private @AetheriaInput m_Wrapper;
        public UIActions(@AetheriaInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @Drag => m_Wrapper.m_UI_Drag;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @Drag.started -= m_Wrapper.m_UIActionsCallbackInterface.OnDrag;
                @Drag.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnDrag;
                @Drag.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnDrag;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Drag.started += instance.OnDrag;
                @Drag.performed += instance.OnDrag;
                @Drag.canceled += instance.OnDrag;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Global
    private readonly InputActionMap m_Global;
    private IGlobalActions m_GlobalActionsCallbackInterface;
    private readonly InputAction m_Global_ZoneMap;
    private readonly InputAction m_Global_GalaxyMap;
    private readonly InputAction m_Global_Inventory;
    private readonly InputAction m_Global_MainMenu;
    private readonly InputAction m_Global_InputScreen;
    private readonly InputAction m_Global_Interact;
    public struct GlobalActions
    {
        private @AetheriaInput m_Wrapper;
        public GlobalActions(@AetheriaInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ZoneMap => m_Wrapper.m_Global_ZoneMap;
        public InputAction @GalaxyMap => m_Wrapper.m_Global_GalaxyMap;
        public InputAction @Inventory => m_Wrapper.m_Global_Inventory;
        public InputAction @MainMenu => m_Wrapper.m_Global_MainMenu;
        public InputAction @InputScreen => m_Wrapper.m_Global_InputScreen;
        public InputAction @Interact => m_Wrapper.m_Global_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Global; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GlobalActions set) { return set.Get(); }
        public void SetCallbacks(IGlobalActions instance)
        {
            if (m_Wrapper.m_GlobalActionsCallbackInterface != null)
            {
                @ZoneMap.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnZoneMap;
                @ZoneMap.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnZoneMap;
                @ZoneMap.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnZoneMap;
                @GalaxyMap.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnGalaxyMap;
                @GalaxyMap.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnGalaxyMap;
                @GalaxyMap.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnGalaxyMap;
                @Inventory.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInventory;
                @MainMenu.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnMainMenu;
                @MainMenu.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnMainMenu;
                @MainMenu.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnMainMenu;
                @InputScreen.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInputScreen;
                @InputScreen.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInputScreen;
                @InputScreen.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInputScreen;
                @Interact.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GlobalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ZoneMap.started += instance.OnZoneMap;
                @ZoneMap.performed += instance.OnZoneMap;
                @ZoneMap.canceled += instance.OnZoneMap;
                @GalaxyMap.started += instance.OnGalaxyMap;
                @GalaxyMap.performed += instance.OnGalaxyMap;
                @GalaxyMap.canceled += instance.OnGalaxyMap;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @MainMenu.started += instance.OnMainMenu;
                @MainMenu.performed += instance.OnMainMenu;
                @MainMenu.canceled += instance.OnMainMenu;
                @InputScreen.started += instance.OnInputScreen;
                @InputScreen.performed += instance.OnInputScreen;
                @InputScreen.canceled += instance.OnInputScreen;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GlobalActions @Global => new GlobalActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMinimapZoom(InputAction.CallbackContext context);
        void OnTargetReticle(InputAction.CallbackContext context);
        void OnTargetPrevious(InputAction.CallbackContext context);
        void OnTargetNext(InputAction.CallbackContext context);
        void OnTargetNearest(InputAction.CallbackContext context);
        void OnToggleHeatsinks(InputAction.CallbackContext context);
        void OnToggleShield(InputAction.CallbackContext context);
        void OnOverrideShutdown(InputAction.CallbackContext context);
        void OnPing(InputAction.CallbackContext context);
        void OnHideUI(InputAction.CallbackContext context);
        void OnTractorBeam(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnDrag(InputAction.CallbackContext context);
    }
    public interface IGlobalActions
    {
        void OnZoneMap(InputAction.CallbackContext context);
        void OnGalaxyMap(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnMainMenu(InputAction.CallbackContext context);
        void OnInputScreen(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
