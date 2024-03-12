using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRb;
    public float jumpforce; //This is in-editor editable value that provides the jump
                            //force for the player
    public float gravityModifier; //this editable value provides gravity to the player
    public bool isonground = true; //this bool is for isonground code
    public bool gameOver = false; //this bool is for gameover code
    private Animator playerAnim; //this is animation controller for the player
    public ParticleSystem explosionParticle; //this is a particlesystem option used to insert a particle effect
    public ParticleSystem dirtParticle; //this is a particlesystem option used to insert a particle effect
    public AudioClip jumpSound; //this is an audio option used to insert sfx sounds
    public AudioClip crashSound; //this is an audio option used to insert sfx sounds
    private AudioSource playerAudio; //this is a source for the player audio

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; //this part of code uses the earlier gravity value
                                            //to add gravity properties to the player
        playerAnim = GetComponent<Animator>(); //this part calls the animator at the start of the game
        playerAudio = GetComponent<AudioSource>(); //this part calls the audio source at the start of the game
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground && !gameOver) //this part makes the player jump
                                                                        //from the space key, and makes the player
                                                                        //jump only when on the ground
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse); //this code provides the jump force
            isonground = false; //this makes the players ground touching untrue when they jump
            playerAnim.SetTrigger("Jump_trig"); //this calls the specific animation when the player presses spacebar
            dirtParticle.Stop(); //this stops the dirt particles when the player is in the air
            playerAudio.PlayOneShot(jumpSound, 1.0f); //this plays the jump sound chosen in the editor when the player presses spacebar
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) //this checks if the player is colliding with the ground
        {
            isonground = true; //this makes the isonground check true when the player is colliding with the ground
            dirtParticle.Play(); //this starts the particles spawning when the player is touching the ground
        }
        else if (collision.gameObject.CompareTag("Obstacle")) //this checks if the player is colliding with an obstacle
        {
            gameOver = true; //this makes the gameover bool true
            Debug.Log("Game Over!"); //this writes "Game Over!" in the debuglog when the player touches an obstacle
            playerAnim.SetBool("Death_b", true); //this plays the death animation
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play(); //this plays the explosion effect when the player touches an obstacle
            dirtParticle.Stop(); //this stops the dirt particle from playing when the player touches an obstacle
            playerAudio.PlayOneShot(crashSound, 1.0f); //this plays the crash sound when the player collides with an obstacle
        }
    }
}
