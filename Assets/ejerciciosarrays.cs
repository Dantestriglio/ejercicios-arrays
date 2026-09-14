using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosarrays : MonoBehaviour
{
    public GameObject[] cubitos;
    int contadora = 0;
    int contadorainversa;

    public GameObject[] cubitosApagados;
    int contadorEncendido = 0;
    int contadorUnico = -1;

    // Start is called before the first frame update
    void Start()
    {
        contadorainversa = cubitos.Length - 1;
        desactivartodoslosobjetos(cubitosApagados);
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

        if(Input.GetKeyDown(KeyCode.T))
        {
            if(contadorEncendido < cubitosApagados.Length)
            {
                cubitosApagados[contadorEncendido].SetActive(true);
                contadorEncendido++;
            }
        }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            if(contadorUnico >= 0)
            {
                cubitosApagados[contadorUnico].SetActive(false);
            }

            contadorUnico = (contadorUnico + 1) % cubitosApagados.Length;
            cubitosApagados[contadorUnico].SetActive(true);
        }
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
