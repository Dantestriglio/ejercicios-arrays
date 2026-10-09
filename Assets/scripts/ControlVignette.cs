using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ControlVignette : MonoBehaviour
{

    public PostProcessVolume volumenEfectos;
    Vignette vignette;
    // Start is called before the first frame update
    void Start()
    {
        volumenEfectos.profile.TryGetSettings(out vignette);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            cambiarintensidadVignette(0.1f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            cambiarintensidadVignette(0.3f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            cambiarintensidadVignette(0.65f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            cambiarintensidadVignette(1f);
        }
    }

    public void cambiarintensidadVignette(float nuevaintensidad)
    {
        
        vignette.intensity.overrideState = true;
        vignette.intensity.value = nuevaintensidad;
        
    }
}
