using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float speedPlayer ;
    public float liveBullet ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    //Movimiento DELANTERO
        /*
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Adelante");
            MovePlayer(Vector3.left);
        }
        
        
        // MOVIMIENTO TRASEROV
        if( Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Atrás");
            MovePlayer(Vector3.right);
        }
        */
        Move();
        //live
    }

    
    
    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer* Time.deltaTime * new Vector3 (ejeVertical,0,ejeHorizontal));

    }
    
    
    
    private void MovePlayer(Vector3 direccion){
        transform.Translate(speedPlayer* Time.deltaTime *direccion);
    }
}
