using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcollisions : MonoBehaviour
{
    


    // Update is called once per fram

   void OnTriggerEnter(Collider other)
    {
        //Destroy this object
        Destroy(gameObject); 
        //Destroy Object this Object is colliding with
        Destroy(other.gameObject);
    }
}