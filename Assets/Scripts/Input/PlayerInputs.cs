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

public class PlayerInputs : MonoBehaviour
{
    InputActions actions;

    public MoveInput moveInput;
    public ShotInput shotInput;

    Vector2 move;
    float shot;
    
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
