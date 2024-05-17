using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostrar_puente : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Obtén todos los componentes MeshRenderer en este objeto y sus hijos
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();

        // Activa todos los MeshRenderers
        foreach (MeshRenderer renderer in renderers)
        {
            renderer.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
