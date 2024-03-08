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
    public bool isonground = true; //this bool tests if the player is on the ground
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; //this part of code uses the earlier gravity value
                                            //to add gravity properties to the player
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground) //this part makes the player jump
                                                           //from the space key, and makes the player
                                                           //jump only when on the ground
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse); //this code provides
                                                                          //the jump force
            isonground = false; //this makes the players ground touching untrue when they jump
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isonground = true; //this provides the player the possibility to
                           //jump again when touching the ground
}
