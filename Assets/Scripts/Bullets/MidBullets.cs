using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidBullets : BaseBullets
{
    // INHERITANCE
    // POLYMORPHISM
    void Start()
    {
        Power();
    }
    protected override void Power()
    {
        float power = 25000f;
        rb.AddRelativeForce(Vector3.forward * power * Time.deltaTime, ForceMode.Impulse);
    }

}
