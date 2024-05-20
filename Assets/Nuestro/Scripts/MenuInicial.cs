using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public void Jugar(){
        SceneManager.LoadScene("Principal");
    }

    public void Salir(){
        Application.Quit();
    }

}
