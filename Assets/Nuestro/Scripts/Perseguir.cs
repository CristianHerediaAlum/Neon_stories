using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    IEnumerator StartChaseAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        shouldChase = true;
    }

    void FixedUpdate()
    {
        if (shouldChase && player != null)
        {
            Vector3 newPosition = Vector3.MoveTowards(rb.position, player.transform.position, speed * Time.deltaTime);
            rb.MovePosition(newPosition);
        }
    }
}
