using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosarrays : MonoBehaviour
{
    public GameObject[] cubitos;
    // Start is called before the first frame update
    void Start()
    {
        desactivarprimerelemento(cubitos);
        desactivartodoslosobjetos(cubitos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void desactivarprimerelemento(GameObject[] arr)
    {
        if(arr.Length > 0)
        {
            arr[0].SetActive(false);
        }
    }

    void desactivartodoslosobjetos(GameObject[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i].SetActive(false);
        }
    }

}
