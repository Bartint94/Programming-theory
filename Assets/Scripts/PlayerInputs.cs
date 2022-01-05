using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class ShotInput : UnityEvent<float> { }

public class PlayerInputs : MonoBehaviour
{
    InputActions actions;


    public ShotInput shotInput;


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
    }
    public void OnShot(InputAction.CallbackContext cont)
    {
        shot = cont.ReadValue<float>();
        shotInput.Invoke(shot);
    }
  


}
