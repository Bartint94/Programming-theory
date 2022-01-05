using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMid : GunBase
{
    [SerializeField] Vector3 pointShot;
    [SerializeField] Transform Point;
    void Start()
    {

    }

    protected override void Fire()
    {
        
        Instantiate(bullet,Point.transform.position,transform.rotation);
    }
    void Update()
    {
        if (shot > .1f)
        {
            Fire();
        }
        Quaternion look = Quaternion.LookRotation(Cam.forward, Vector3.up);

        transform.rotation = look;











        
    }
}