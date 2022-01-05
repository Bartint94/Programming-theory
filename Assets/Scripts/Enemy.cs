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
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
  
    {
        Vector3 away = Player.position+transform.position + new Vector3(0,1,0);
            if (collision.gameObject.CompareTag("bullet"))
            {

            transform.Translate(away*Time.fixedDeltaTime*hit,Space.World);
            
            Speed_f = 0;
            death_b = true;
                
            }

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Speed_f * Time.deltaTime, Space.Self);
        anim.SetFloat("Speed_f", Speed_f);
        anim.SetBool("Death_b", death_b);
    }
}
