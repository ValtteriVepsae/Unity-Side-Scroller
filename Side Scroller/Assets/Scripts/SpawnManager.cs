using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; //this chooses the object to spawn
    private float startDelay = 3; //this is how long from the start of the game it
                                  //takes to spawn the first obstacle
    private float repeatRate = 3; //this is how long it takes to spawn another after another
    private Vector3 spawnPos = new Vector3(-50, 0, 6); //this is the spawning coordinates
                                                      //for the object to spawn to
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate); //this code invokes SpawnObstacle
                                                                  //part of the code by
                                                                  //the startDelay and repeatRate
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false) //this if statement checks if the game is not over
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); //this code spawns
        }                                                                             //the obstacles
    }
}
