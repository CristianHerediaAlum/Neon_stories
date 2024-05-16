using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// public class Perseguir : MonoBehaviour
// {
//     public float speed = 2.0f;
//     private GameObject player;
//     private bool shouldChase = false;
//     private Rigidbody rb;
//     // Start is called before the first frame update
//     void Start()
//     {
//         player = GameObject.FindGameObjectWithTag("Player");
//         StartCoroutine(StartChaseAfterDelay(2.0f));
//     }

//     IEnumerator StartChaseAfterDelay(float delay)
//     {
//         yield return new WaitForSeconds(delay);
//         shouldChase = true;
//     }
//     // Update is called once per frame
//     void Update()
//     {
//         if (shouldChase && player != null)
//         {
//             transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
//         }
//     }
// }

public class Perseguir : MonoBehaviour
{
    public float speed = 2.0f;
    private GameObject player;
    private bool shouldChase = false;
    private Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        StartCoroutine(StartChaseAfterDelay(2.0f));
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            // Reiniciar el nivel
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    IEnumerator StartChaseAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        shouldChase = true;
    }

    void FixedUpdate()
    {
        if (shouldChase && player != null)
        {
            Vector3 directionToPlayer = (player.transform.position - transform.position).normalized;
            Vector3 newPosition = transform.position + directionToPlayer * speed * Time.deltaTime;

            RaycastHit hit;
            if (Physics.Raycast(transform.position, directionToPlayer, out hit, speed * Time.deltaTime, LayerMask.GetMask("Default")))
            {
                if (hit.collider.gameObject != player)
                {
                    // Si se detecta un obstáculo, ajusta la dirección para esquivarlo
                    Vector3 avoidDirection = Vector3.Reflect(directionToPlayer, hit.normal);
                    newPosition = transform.position + avoidDirection * speed * Time.deltaTime;
                }
            }

            rb.MovePosition(newPosition);

            Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToPlayer, speed * Time.deltaTime);
        }
    }
}
