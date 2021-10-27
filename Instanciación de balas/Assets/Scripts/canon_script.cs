using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon_script : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public float startD = 1.0f;
    public float spawnTiming = 1.5f;
    public float coolDown = 3.0f;
    public bool isShoot = false;
    public float timeBullet = 30.0f ;

    enum Dificutades  {Fácil, Medio, Díficil};
    [SerializeField]private Dificutades difficulty;

    // Start is called before the first frame update
    void Start()
    {/*
        switch(difficulty)
        {
            case 1:
                Debug.Log("Modo Fácil");
                InvokeRepeating("Shoot", (startD+3.0f), (spawnTiming+3.0f));

                break;
            
            case 2:
                Debug.Log("Modo Medio");
                InvokeRepeating("Shoot", startD, spawnTiming);

                break;

            case 3:
                Debug.Log("Modo Difícil");
                InvokeRepeating("Shoot", (startD-1.0f), (spawnTiming-1.0f));

                break;
            
            default:
                Debug.Log("M");
                break;
        }*/
       // InvokeRepeating("Shoot", startD, spawnTiming);

    }

    // Update is called once per frame
    void Update()
    {
       // if(!isShoot){
            
        //}
    }
    void Shoot()
    {
        int enemyIndex = Random.Range(0, bulletPrefabs.Length);
        Instantiate(bulletPrefabs[enemyIndex], transform.position, bulletPrefabs[enemyIndex].transform.rotation);
    }
}
