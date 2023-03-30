using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            meshRenderer.material.color = Color.red;
            Debug.Log("Perdeu");
            
        }
    }
}



