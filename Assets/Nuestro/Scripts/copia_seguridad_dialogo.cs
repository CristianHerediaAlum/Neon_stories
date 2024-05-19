// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;
// using UnityEngine.InputSystem;
// using UnityEngine.SceneManagement;  // Importar el namespace necesario para cargar escenas

// public class Dialogo : MonoBehaviour
// {
//     public TextMeshProUGUI dialogueText;
//     public string[] lines;
//     public float textSpeed = 0.05f;
//     public Button hablarButton; // Referencia al botón "Hablar"
//     public Button jugarButton;  // Referencia al botón "JUGAR"
//     public string sceneToLoad;  // Nombre de la escena a cargar
//     public GameObject jammo;

//     int index;

//     void Start()
//     {
//         dialogueText.text = string.Empty;
//         // Desactivamos el objeto de diálogo y el botón "JUGAR" al inicio
//         gameObject.SetActive(false);
//         jugarButton.gameObject.SetActive(false);

//         // Asociamos la función StartDialogue() al evento onClick del botón "Hablar"
//         hablarButton.onClick.AddListener(StartDialogue);
//         // Asociamos la función LoadGameScene() al evento onClick del botón "JUGAR"
//         jugarButton.onClick.AddListener(LoadGameScene);
//     }

//     void Update()
//     {
//         // Verificamos si se presiona la barra espaciadora
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             // Si el diálogo está activo, procedemos al siguiente diálogo
//             if (gameObject.activeSelf && dialogueText.text == lines[index])
//             {
//                 NextLine();
//             }
//         }
//     }

//     // Función para comenzar el diálogo
//     public void StartDialogue()
//     {
//         index = 0;
//         gameObject.SetActive(true); // Activamos el objeto de diálogo
//         hablarButton.gameObject.SetActive(false); // Desactivamos el botón "Hablar" al iniciar el diálogo
//         jugarButton.gameObject.SetActive(false); // Desactivamos el botón "JUGAR" al iniciar el diálogo
//         StartCoroutine(WriteLine());
//     }

//     // Función para avanzar al siguiente diálogo
//     public void NextLine()
//     {
//         if (index < lines.Length - 1)
//         {
//             index++;
//             dialogueText.text = string.Empty;
//             StartCoroutine(WriteLine());
//         }
//     }

//     // Corrutina para escribir el diálogo letra por letra
//     IEnumerator WriteLine()
//     {
//         // Si estamos en la última línea, activamos el botón "JUGAR"
//         if (index == lines.Length - 1)
//         {
//             jugarButton.gameObject.SetActive(true);
//         }

//         foreach (char ch in lines[index].ToCharArray())
//         {
//             dialogueText.text += ch;
//             yield return new WaitForSeconds(textSpeed);
//         }
//     }

//     // Función para cargar la escena del juego
//     public void LoadGameScene()
//     {
//         Variables_globales.playerposition = jammo.transform.position;
//         SceneManager.LoadScene(sceneToLoad);
//     }
// }
