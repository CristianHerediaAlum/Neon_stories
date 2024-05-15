using UnityEngine;
using UnityEngine.UI;

public class dialogo_c2 : MonoBehaviour
{
    public GameObject dialogoCiudad2;
    public Text[] textosDialogoc2;
    public Button botonSiguientec2;
    public Button botonJugarc2;

    private int indiceDialogoc2 = 0;

    void Start()
    {
        // Desactivar el diálogo al inicio
        dialogoCiudad2.SetActive(false);

        // Asignar función a los botones
        botonSiguientec2.onClick.AddListener(ProximoDialogo_c2);
        botonJugarc2.onClick.AddListener(IniciarJuego_c2);
    }

    void Update()
    {
        // Verificar si se presiona la tecla de espacio para mostrar el diálogo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!dialogoCiudad2.activeSelf) // Si el diálogo no está activo
            {
                MostrarDialogo_c2();
            }
            else // Si el diálogo está activo, avanzar al siguiente diálogo
            {
                ProximoDialogo_c2();
            }
        }
    }

    public void MostrarDialogo_c2()
    {
        // Mostrar el diálogo
        dialogoCiudad2.SetActive(true);
        // Mostrar el primer texto
        textosDialogoc2[0].gameObject.SetActive(true);
        // Desactivar el botón JUGAR al principio
        botonJugarc2.gameObject.SetActive(false);
    }

    void ProximoDialogo_c2()
    {
        // Ocultar el texto actual
        textosDialogoc2[indiceDialogoc2].gameObject.SetActive(false);
        // Incrementar el índice del diálogo
        indiceDialogoc2++;
        // Mostrar el siguiente texto
        if (indiceDialogoc2 < textosDialogoc2.Length - 1)
        {
            textosDialogoc2[indiceDialogoc2].gameObject.SetActive(true);
        }
        else
        {
            // Si es el último texto, activar el botón JUGAR
            textosDialogoc2[indiceDialogoc2].gameObject.SetActive(true);
            botonSiguientec2.gameObject.SetActive(false);
            botonJugarc2.gameObject.SetActive(true);
        }
    }

    void IniciarJuego_c2()
    {
        // Aquí puedes añadir la lógica para iniciar el juego
        // Por ejemplo, cargar una nueva escena, activar un GameObject relacionado con el juego, etc.
    }
}
