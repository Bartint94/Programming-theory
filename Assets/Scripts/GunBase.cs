using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GunBase : MonoBehaviour
{
   
    protected float shot;
    public Transform Cam;
    public GameObject bullet;
    public void Shot(float shot)
    {
        this.shot = shot;
    }
    protected abstract void Fire();

}
