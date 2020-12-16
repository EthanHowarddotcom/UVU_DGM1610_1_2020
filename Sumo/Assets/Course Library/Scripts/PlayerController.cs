using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float speed = 5.0f;
    private GameObject FocalPoint;
    public bool hasPowerUp
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        FocalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(FocalPoint.transform.forward * speed * forwardInput);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Powerup")){
            hasPowerUp = true;
            Destroy(other.gameObject);
        }
    }
    private float powerupStrength = 15.0f

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("enemy") && hasPowerUp) 
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>(); 
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Player collided with " + collision.gameObject + "with powerup set to " + hasPowerUp)
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse); 
        }
    }
}
