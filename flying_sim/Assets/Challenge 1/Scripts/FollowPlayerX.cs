using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public float xAngle, yAngle, zAngle;
    public GameObject Cam;
    private Vector3 offset = new Vector3(-100, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Cam.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
