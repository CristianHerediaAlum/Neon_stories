using UnityEngine;
using UnityEngine.UI;

public class apareceboton : MonoBehaviour
{

    
    public Transform player; // Referencia al transform del jugador
    public float interactionRadius = 30f; // Radio de interacción

    private CanvasGroup canvasGroup; // Referencia al CanvasGroup del botón en el Canvas hijo

    void Start()
    {
        // Obtener el CanvasGroup del objeto vacío
        canvasGroup = GetComponentInChildren<CanvasGroup>();

        if (canvasGroup == null)
        {
            Debug.LogError("CanvasGroup no encontrado. Asegúrate de que esté en el objeto vacío hijo.");
        }
    }

    void Update()
    {
        // Calcular la distancia entre el jugador y el personaje enemigo
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Si el jugador está dentro del radio de interacción, mostrar el botón
        if (distanceToPlayer <= interactionRadius)
        {
            ShowButton();
        }
        else // Si está fuera del radio, ocultar el botón
        {
            HideButton();
        }
    }

    void ShowButton()
    {
        // Activar el CanvasGroup para mostrar el botón
        canvasGroup.alpha = 1f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    void HideButton()
    {
        // Desactivar el CanvasGroup para ocultar el botón
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}
