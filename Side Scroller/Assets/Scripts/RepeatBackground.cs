using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos; //this is a vector used for saving the starting position
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; //this saves the starting position of the background
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > startPos.x + 56.4) // this exact x coordinate makes the transition smooth
                                                      // I know it was made differently in the tutorial, but I was so pleased
                                                      // with finding the right X coordinate I decided to keep it this way
        {
            transform.position = startPos; //this code moves the background back to it's original position when that coordinate is reached
        }
    }
}
