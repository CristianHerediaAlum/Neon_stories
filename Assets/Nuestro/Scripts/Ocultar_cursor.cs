using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocultar_cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(Variables_globales.n_victorias);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        
    }
}
