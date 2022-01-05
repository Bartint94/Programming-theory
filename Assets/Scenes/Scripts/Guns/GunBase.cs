using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
   
    protected float shot;
    [SerializeField] protected Transform Cam;
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform Point;
    Quaternion look;
    public void Shot(float shot)
    {
        this.shot = shot;
    }
    protected virtual void Fire()
    {
        if(shot>.2f)
        Instantiate(bullet, Point.transform.position, transform.rotation);
    }
   
   
    protected virtual void Update()
    {
        look = Quaternion.LookRotation(Cam.forward, Vector3.up);
        transform.rotation = look;

        
        
    }

}
