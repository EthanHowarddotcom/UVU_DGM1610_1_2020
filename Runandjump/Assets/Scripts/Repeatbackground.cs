using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeatbackground : MonoBehaviour
{
    private Vector3 startPos; 
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; 
    }

    // Update is called once per frame
    void Update()
    {
        //if the background is less than -50 on x, reset position
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
