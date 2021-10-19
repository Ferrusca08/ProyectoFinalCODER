using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon_script : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public float startD = 1.0f;
    public float spawnTiming = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", startD, spawnTiming);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot()
    {
        int enemyIndex = Random.Range(0, bulletPrefabs.Length);
        Instantiate(bulletPrefabs[enemyIndex], transform.position, bulletPrefabs[enemyIndex].transform.rotation);
    }
}
