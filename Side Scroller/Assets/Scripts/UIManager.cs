using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    PlayerController playerControllerScript;
    //Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void StartGame() => SceneManager.LoadScene("Game");

    public void MainMenu() => SceneManager.LoadScene("Start");

    //Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == true && Input.anyKeyDown)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
