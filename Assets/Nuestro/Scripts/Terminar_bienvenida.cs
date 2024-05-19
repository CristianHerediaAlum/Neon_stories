using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terminar_bienvenida : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            if(SceneManager.GetActiveScene().name == "Bienvenida")
                SceneManager.LoadScene("Principal");
            else if(SceneManager.GetActiveScene().name == "Final")
                SceneManager.LoadScene("Creditos");
        }
    }
}
