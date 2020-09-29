using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    public float xAngle, yAngle, zAngle;
   public GameObject propeller; 
    void Start()
    {
        
        
        propeller.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        propeller.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
