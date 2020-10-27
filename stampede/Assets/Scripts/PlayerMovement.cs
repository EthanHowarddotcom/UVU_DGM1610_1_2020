using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Speed of the player
    private int speed = 20;
    //Player boundaries 
    public float xRange = 15.0f;
    //Player controls (Left/Right)
    float horizontalInput;
    public GameObject foodProjectile; 
  

    // Update is called once per frame
    void Update()
    {
        // Assigns controls to player speed
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Enforces player boundaries 
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position = new Vector3(transform.position.x, 2, transform.position.z), foodProjectile.transform.rotation);
        }
    }

}
