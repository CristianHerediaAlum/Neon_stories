using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganar_puzle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        // if(other.gameObject.tag == "Player")
        // {
        Debug.Log("Ganaste");
        Variables_globales.n_victorias++;
        if(SceneManager.GetActiveScene().name == "Puzle_calamar")
            SceneManager.LoadScene("Final");
        else
            SceneManager.LoadScene("Principal");
         // }
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ganaste");
        Variables_globales.n_victorias++;
        SceneManager.LoadScene("Principal");
    }

}
