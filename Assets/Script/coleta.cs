using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleta : MonoBehaviour
{
    private GameObject objeto;
    // Start is called before the first frame update

    private float quantidade = 0;

    private void Start()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
           
            Destroy(gameObject);                  
            print(quantidade);

            quantidade++;
            

            if (quantidade > 5)
            {
                Debug.Log("Boa garoto");

            }

        }
    }
  
}
