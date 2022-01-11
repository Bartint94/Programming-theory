using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class ShotInput : UnityEvent<float> { }
[Serializable]
public class MoveInput : UnityEvent<float,float> { }
[Serializable]
public class LookInput : UnityEvent<float,float> { }
[Serializable]
public class JumpInput : UnityEvent<float> { }


public class PlayerInputs : MonoBehaviour
{
    InputActions actions;

    public JumpInput jumpInput;
    public LookInput lookInput;
    public MoveInput moveInput;
    public ShotInput shotInput;

    Vector2 move;
    Vector2 look;
    float shot;
    float jump;
    
    private void Awake()
    {
        actions = new InputActions();
    }
    private void OnEnable()
    {
        actions.Enable();
        actions.Gameplay.Shoot.performed += OnShot;
        actions.Gameplay.Shoot.canceled += OnShot;

        actions.Gameplay.Move.performed += OnMove;
        actions.Gameplay.Move.canceled += OnMove;

        actions.Gameplay.Look.performed += OnLook;
        actions.Gameplay.Look.canceled += OnLook;

        actions.Gameplay.Jump.performed += OnJump;
        actions.Gameplay.Jump.canceled += OnJump;
    }
    public void OnJump(InputAction.CallbackContext cont)
    {
        jump = cont.ReadValue<float>();
        jumpInput.Invoke(jump);
    }
    public void OnLook(InputAction.CallbackContext cont)
    {
        look = cont.ReadValue<Vector2>();
        lookInput.Invoke(look.x, look.y);
    }
    public void OnShot(InputAction.CallbackContext cont)
    {
        shot = cont.ReadValue<float>();
        shotInput.Invoke(shot);
    }
    public void OnMove(InputAction.CallbackContext cont)
    {
        move = cont.ReadValue<Vector2>();
        moveInput.Invoke(move.x, move.y);
    }



}
