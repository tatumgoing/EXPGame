using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    //[Header("UI")]

    public GameObject gameOverUI;
    public GameObject winGameUI;

    public List<GameObject> lanterns = new List<GameObject>();

    public bool gameOver = false;

    void Start()
    {
        gameOverUI.SetActive(false);
        winGameUI.SetActive(false);
    }
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void WinGame()
    {
        winGameUI.SetActive(true);
    }
    public void StartOver()
    {
        //resets game back to start. update to just restart the gameobject if time
        Debug.Log("Clicked");

        Scene gameScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(gameScene.name);

    }
}
