using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float hit;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
  
    {
        Vector3 away = transform.position - collision.transform.position;
            if (collision.gameObject.CompareTag("bullet"))
            {
                
                rb.AddForce(away * hit * Time.deltaTime, ForceMode.Impulse);
                
            }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
