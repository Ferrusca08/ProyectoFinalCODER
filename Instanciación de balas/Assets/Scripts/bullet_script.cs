using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    public int damage ;
    public Vector3 direction ;
    public float speed = 5.0f ;
    public float timeBullet = 30.0f ;
    public Vector3 newScale = new Vector3(3,3,3) ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Disparo(Vector3.left);

    if(Input.GetKeyDown(KeyCode.Space))
    {
        transform.localScale = newScale;
    }
    
    timeBullet -= Time.deltaTime;
    if(timeBullet > 0){
        Disparo(Vector3.left);
    }
    else
    {
        Destroy(gameObject);
    }
    Debug.Log(timeBullet);
    

    }
    //Metodo de movimineto para la bala
    private void Disparo(Vector3 direction)
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
