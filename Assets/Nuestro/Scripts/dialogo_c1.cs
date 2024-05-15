using UnityEngine;
using UnityEngine.UI;

public class dialogo_c1 : MonoBehaviour
{
    public GameObject dialogoCiudad1;
    public Text[] textosDialogoc1;
    public Button botonSiguientec1;
    public Button botonJugarc1;

    private int indiceDialogoc1 = 0;

    void Start()
    {
        // Desactivar el diálogo al inicio
        dialogoCiudad1.SetActive(false);

        // Asignar función a los botones
        botonSiguientec1.onClick.AddListener(ProximoDialogo_c1);
        botonJugarc1.onClick.AddListener(IniciarJuego_c1);
    }

    void Update()
    {
        // Verificar si se presiona la tecla de espacio para mostrar el diálogo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!dialogoCiudad1.activeSelf) // Si el diálogo no está activo
            {
                MostrarDialogo_c1();
            }
            else // Si el diálogo está activo, avanzar al siguiente diálogo
            {
                ProximoDialogo_c1();
            }
        }
    }

    public void MostrarDialogo_c1()
    {
        // Mostrar el diálogo
        dialogoCiudad1.SetActive(true);
        // Mostrar el primer texto
        textosDialogoc1[0].gameObject.SetActive(true);
        // Desactivar el botón JUGAR al principio
        botonJugarc1.gameObject.SetActive(false);
    }

    void ProximoDialogo_c1()
    {
        // Ocultar el texto actual
        textosDialogoc1[indiceDialogoc1].gameObject.SetActive(false);
        // Incrementar el índice del diálogo
        indiceDialogoc1++;
        // Mostrar el siguiente texto
        if (indiceDialogoc1 < textosDialogoc1.Length - 1)
        {
            textosDialogoc1[indiceDialogoc1].gameObject.SetActive(true);
        }
        else
        {
            // Si es el último texto, activar el botón JUGAR
            textosDialogoc1[indiceDialogoc1].gameObject.SetActive(true);
            botonSiguientec1.gameObject.SetActive(false);
            botonJugarc1.gameObject.SetActive(true);
        }
    }

    void IniciarJuego_c1()
    {
        // Aquí puedes añadir la lógica para iniciar el juego
        // Por ejemplo, cargar una nueva escena, activar un GameObject relacionado con el juego, etc.
    }
}
