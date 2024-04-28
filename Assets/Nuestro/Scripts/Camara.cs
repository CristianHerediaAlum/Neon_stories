using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform; // referencia al transform del jugador
    public Vector3 offset; // offset de la cámara

    void Update()
    {
        // Actualiza la posición de la cámara para que coincida con la del jugador
        transform.position = playerTransform.position + offset;
    }
}