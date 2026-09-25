using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosarrays : MonoBehaviour
{
    public GameObject[] cubitos;
    int contadora = 0;
    int contadorainversa;



    // Start is called before the first frame update
    void Start()
    {
        contadorainversa = cubitos.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            if(contadora < cubitos.Length)
            {
                cubitos[contadora].SetActive(false);
                contadora++;
            }
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            if(contadorainversa >= 0)
            {
                cubitos[contadorainversa].SetActive(false);
                contadorainversa--;
            }
        }
    }



}
