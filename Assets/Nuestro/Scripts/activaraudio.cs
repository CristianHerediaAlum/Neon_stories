using UnityEngine;
using UnityEngine.UI;

public class activar_audio : MonoBehaviour
{
    public Button talkButton;  // El botón que pulsarás
    public AudioSource audioSource;  // El componente AudioSource que reproducirá el audio

    void Start()
    {
        // Asegúrate de que el botón y el AudioSource están asignados
        if (talkButton != null && audioSource != null)
        {
            // Añadir un listener al botón para que llame a la función PlayAudio cuando se haga clic
            talkButton.onClick.AddListener(PlayAudio);
        }
        else
        {
            Debug.LogError("Faltan referencias al Button o AudioSource en el inspector.");
        }
    }

    void PlayAudio()
    {
        // Verificar si el AudioSource no está ya reproduciendo audio
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
