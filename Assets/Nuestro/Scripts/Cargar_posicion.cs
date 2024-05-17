using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargar_posicion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Variables_globales.playerposition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
