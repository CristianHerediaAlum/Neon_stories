using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Romper_pared : MonoBehaviour
{
    string objectName;
    // Start is called before the first frame update
    void Start()
    {
        objectName = gameObject.name;
        // Debug.Log(objectName);
    }

    // Update is called once per frame
    void Update()
    {
        if(Variables_globales.n_victorias == 1 && objectName == "Pared_medieval")
            Destroy(gameObject);
        else if(Variables_globales.n_victorias == 2 && (objectName == "Pared_dino" || objectName == "Pared_dino(1)" ))
            Destroy(gameObject);
    }
}
