using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour //this is actually move right script,
                                      //since I made the game on the wrong side
{
    public float speed = 5; //this is a speed at which the obstacles and background moves
    private PlayerController playerControllerScript;
    private float rightBound = 0; //this is a value for later check to destroy obstacles

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false) //this if statement checks if the game is not over
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed); //this script moves the background and the
        }                                                                //obstacles left on the screen towards the player
        if (transform.position.x > rightBound && gameObject.CompareTag("Obstacle")) //this checks if an obstacle has gone to certain x coordinate
        {
            Destroy(gameObject); //this destroys the object
        }
    }
}
