using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float distance = 10.0f; // distancia de la cámara al jugador
    public float mouseSensitivity = 100.0f;
    private float xRotation = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Bloquea el cursor al centro de la pantalla
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limita la rotación para que la cámara no de vueltas completas

        playerTransform.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }

    void LateUpdate()
    {
        // La cámara siempre está detrás del jugador
        transform.position = playerTransform.position - playerTransform.forward * distance;
    }
}