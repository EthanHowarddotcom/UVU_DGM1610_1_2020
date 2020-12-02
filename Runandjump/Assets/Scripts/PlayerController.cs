using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float jumpForce; 
    public float gravityModifier; 
    public bool isOnGround = true; 
    public bool gameOver = false;

    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle; 

    public AudioClip jumpSound;
    public AudioClip impactSound;
    private AudioSource playerAudio; 

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; 
        
        playerAnim = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>(); 
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
             playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse); 
             isOnGround = false; 
             playerAnim.SetTrigger("Jump_trig");
             dirtParticle.Stop();
             playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacal"))
        {
            gameOver = true; 
            Debug.Log("Game over");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(impactSound, 1.0f); 
            
        }
       
    }
}
