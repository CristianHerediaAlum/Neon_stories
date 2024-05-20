using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
// using UnityEngine.SceneManagement;

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
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            Cursor.visible = false;
        }
        // if(Input.GetKeyDown(KeyCode.F))
        // {
        //     Variables_globales.playerposition = transform.position;
        //     SceneManager.LoadScene("Puzle_calamar");
        // }
    }
}
