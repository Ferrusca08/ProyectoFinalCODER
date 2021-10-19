using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    public int damage ;
    public Vector3 direction ;
    public float speed = 5.0f ;
    public float liveBullet = 20.0f ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ShootBullet();
    }
    private void ShootBullet()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
