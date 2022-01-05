using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullets : MonoBehaviour
{

    Rigidbody rb;
    
    protected void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
  
    protected virtual void Power()
    {
        float power = 5000f;
    rb.AddRelativeForce(Vector3.forward * power * Time.deltaTime, ForceMode.Impulse);
    }
 
}
