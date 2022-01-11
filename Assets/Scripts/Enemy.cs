using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float hit;
    [SerializeField] Transform Player;
    [SerializeField] float Speed_f = 2;
    Animator anim;
    bool death_b = false;
    public float angle;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
  
    {
       
            if (collision.gameObject.CompareTag("bullet"))
            {

            
            
            Speed_f = 0;
            death_b = true;
                
            }

        
    }

    
    void Update()
    {
        angle = transform.localRotation.z;
        if (angle>0.3f)
        {
            Speed_f = 0f;
        }

       

    }
    private void MoveEnemy()
    {
        
        rb.AddForce(Player.position * Speed_f, ForceMode.Acceleration);
        anim.SetFloat("Speed_f", Speed_f);
        anim.SetBool("Death_b", death_b);
    }
    private void FixedUpdate()
    {
        MoveEnemy();
    }
}
