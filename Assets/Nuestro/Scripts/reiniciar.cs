using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class reiniciar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Principal")
        {
            if(transform.position.y <= 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if(transform.position.y <= -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
