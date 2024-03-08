using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; //this chooses the object to spawn
    private float startDelay = 3; //this is how long from the start of the game it
                                  //takes to spawn the first obstacle
    private float repeatRate = 3; //this is how long it takes to spawn another after another
    private Vector3 spawnPos = new Vector3(25, 0, 6); //this is the spawning coordinates
                                                      //for the object to spawn to
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate); //this code invokes SpawnObstacle
                                                                  //part of the code by
                                                                  //the startDelay and repeatRate
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); //this code spawns
                                                                                  //the obstacles
    }
}
