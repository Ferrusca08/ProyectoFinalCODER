using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaras_controller : MonoBehaviour
{
    public GameObject[] camaras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            camaras[0].SetActive(true);
            camaras[1].SetActive(false);
            camaras[2].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
            camaras[0].SetActive(false);
            camaras[1].SetActive(true);
            camaras[2].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.N))
        {
            camaras[0].SetActive(false);
            camaras[1].SetActive(false);
            camaras[2].SetActive(true);
        }
    }

   // public void SwitchCamara(Input.Get)
}
