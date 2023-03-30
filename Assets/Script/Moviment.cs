using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float velocidade;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidade;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidade;
        transform.Translate(moveX, 0, moveZ);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
      //  if (collision.collider.tag != "Hitted")
       // {
        //    hittedObstacles++;
        //    Debug.Log($"You hitted {hittedObstacles} obstacles");
        //}
    //}
}
