using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outofbounds : MonoBehaviour
{
    //Sets the boundaries for gameobjects
    private float topBounds = 45; 
    private float bottomBounds = -20;
    private float sideBounds = -40;
    private float sideBounds2 = 40;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        //If object goes too far to the top of the screen, this destroys it. 
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        //Same but for bottom
        if(transform.position.z < bottomBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            Time.timeScale = 0; 
        }
        //Same but for the right
        if (transform.position.x > sideBounds2)
        {
            Destroy(gameObject);
        }
        //Same but for the left
        if(transform.position.x < sideBounds)
        {
            Destroy(gameObject);
        }

    }
}
