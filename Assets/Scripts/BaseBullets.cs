using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullets : MonoBehaviour
{
   [SerializeField] protected float power = 500f;
    [SerializeField] float hit;
    Rigidbody rb;
    public Transform player;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
        rb.AddRelativeForce(Vector3.forward * power * Time.deltaTime, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Vector3 away = transform.position+ player.position;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(away * hit * Time.deltaTime, ForceMode.Impulse);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame

}
