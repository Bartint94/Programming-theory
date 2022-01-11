using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject lGun;
    [SerializeField] GameObject mGun;
    
    void Start()
    {
        GunChoice();
    }
    void GunChoice()
    {
        if(MenuManager.Instance.gunNr==2)
        {
            mGun.gameObject.SetActive(true);
        }
        else
        {
            lGun.gameObject.SetActive(true);
        }
    }
    
    void Update()
    {
       
    }

}
