using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject lGun;
    [SerializeField] GameObject mGun;
    public List<GameObject> enemyPerfab = new List<GameObject>();
    void Start()
    {
        EnemySpawn();
    }
    void EnemySpawn()
    {

        Instantiate(enemyPerfab[Random.Range(0,enemyPerfab.Count)],gameObject.transform.position,transform.rotation);
    }
    
    void Update()
    {
        
    }

}
