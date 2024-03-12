using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private GameObject gameoverscreen;
    private button restartbutton;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        gameoverscreen.SetActive(false);
        restartbutton.SetActive(false);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == true)
        {
            StartCoroutine(GameOverSequence());
        }

        if (playerControllerScript.gameOver == true)
    }
}
