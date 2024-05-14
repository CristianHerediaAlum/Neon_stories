using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida_bloque : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") // Asegúrate de que tu jugador tenga la etiqueta "Player"
        {
            rb.isKinematic = false;
        }
    }
}