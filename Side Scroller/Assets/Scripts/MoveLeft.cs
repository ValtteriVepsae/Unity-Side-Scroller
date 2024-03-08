using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour //this is actually move right script,
                                      //since I made the game on the wrong side
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed); //this script moves the
                                                                     //background and the
                                                                     //obstacles left on
                                                                     //the screen towards
                                                                     //the player
    }
}
