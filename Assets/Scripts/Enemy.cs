using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    
    [SerializeField] Transform player;
    [SerializeField] float speed = 2;
    Animator anim;
    
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
       

       

    }
    private void MoveEnemy()
    {
        transform.LookAt(player);
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Acceleration);
        anim.SetFloat("Speed_f", speed);
    }
    private void FixedUpdate()
    {
        MoveEnemy();
    }
}
